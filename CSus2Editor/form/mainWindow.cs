using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Diagnostics;
using System.Media;
using System.IO;
using System.CodeDom.Compiler;
using System.Runtime.CompilerServices;
using System.Linq;
using System.Reflection;
using System.Data.Common;

namespace CSus2Editor
{
    public partial class mainWindow : Form
    {
        //So I dont forget to change it in the texts again lmao
        public static string version = "v1.3.0";

        //Note column list
        public static List<NoteColumn> noteCols = new List<NoteColumn>();

        //FreeSO's weird messed up note index
        public string[] noteFSO = { "I", "C", "D", "E", "F", "G", "A", "B", "H" };

        //note(x).wav strings
        public static string[] noteFileName = { "empty", "E", "FS", "GS", "A", "B", "CS", "DS", "E2" };

        //note index array
        public static int[] indexList;

        //Max column amount
        int maxColumns = 1000;

        //Time signature vars
        public static int beats = 4;
        public static int quarters = 4;
        public static int offset = 0;

        //Loop check
        bool loopSong = false;

        //Sound player for playing note sounds
        public static SoundPlayer notes = new SoundPlayer();

        public mainWindow() {
            InitializeComponent();
        }

        //On loading, set initial values
        private void windowLoad(object sender, EventArgs e) {
            //Set default values
            nud_addColumns.Value = 1;
            nud_noteInterval.Value = 5;

            //Default options
            options_measureLines.Checked = measureLines;
            options_followPlay.Checked = followPlayBar;
            options_showCrewmate.Checked = drawCrewmate;
            cm_drawEmpty.Checked = drawCrewmateEmpty;

            //Focus sequencer
            focusSequencer();

            //Generate two measures of note columns
            generateNewPanels(2 * beats * quarters);

            //Set tick to timer
            songTime.Tick += new EventHandler(nextTick);

            //Disable summary textbox
            ControlExtensions.DisableRTB(rtb_seqSummary, pnl_UISummary);

            //Draw images for media buttons
            {
                //Play
                btn_play.BackgroundImage = Image.FromFile(@".\res\media\play.png");
                btn_play.BackgroundImageLayout = ImageLayout.Stretch;

                //Play from start
                btn_playStart.BackgroundImage = Image.FromFile(@".\res\media\playstart.png");
                btn_playStart.BackgroundImageLayout = ImageLayout.Stretch;

                //Loop
                btn_loop.BackgroundImage = Image.FromFile(@".\res\media\repeatoff.png");
                btn_loop.BackgroundImageLayout = ImageLayout.Stretch;
            }
        }//End windowLoad

        //Call whenever adding or removing columns
        private void addColumnRange() {
            //Set add columns min/max to length of note columns
            nud_addColumns.Maximum = maxColumns - indexList.Length;
            nud_addColumns.Minimum = -indexList.Length;
            //Set column edit location min/max to length of columns or 1
            nud_insertColumn.Maximum = indexList.Length;
            nud_insertColumn.Minimum = 0;
        }

        //Generate panels based on requested length
        public void generateNewPanels(int panels) {
            //Clear previous panels
            pnl_buttons.Controls.Clear();
            noteCols.Clear();

            //Index list to parse values for each usercontrol
            indexList = new int[panels];

            //For sequence length, make and place new usercontrols
            for (int i = 0; i < panels; i++) {
                //New note column
                NoteColumn notes = new NoteColumn();

                //Move to end of existing notecolumns
                notes.Location = new Point((i * notes.Width), -10);
                notes.index = i;

                //Add to panel's controls
                pnl_buttons.Controls.Add(notes);

                //Get time signature color and apply to richtextbox
                notes.rtb_notes.BackColor = NoteUtils.beatColor(i);

                //Add note column to list
                noteCols.Add(notes);
            }

            //Remove vertical scrollbar (weird workaround)
            pnl_buttons.VerticalScroll.Maximum = 0;
            pnl_buttons.AutoScroll = false;
            pnl_buttons.VerticalScroll.Visible = false;
            pnl_buttons.AutoScroll = true;

            //Set center scroll color
            scrollSequencer(null, null);

            //Set min/max for editing columns
            addColumnRange();

        }//End generateNewPanels

        //Update note sequence
        private void clickUpdate(object sender, EventArgs e) {

            //Get and write note sequence text
            tb_noteSequence.Text = NoteUtils.sequenceText((int)nud_noteInterval.Value);

            //Get and write sequence summary text
            summaryText();

        }//End clickUpdate

        //Write sequence summary text
        private void summaryText() {

            //Clear previous entry
            rtb_seqSummary.Clear();

            //Check if length of sequence doesn't pass ingame limits (1024 characters)
            rtb_seqSummary.AppendText("Length: ");

            if (tb_noteSequence.Text.Length > 1024) {
                rtb_seqSummary.SelectionColor = Color.Red;
            }
            else {
                rtb_seqSummary.SelectionColor = Color.Green;
            }

            rtb_seqSummary.AppendText(tb_noteSequence.Text.Length + " characters");
            rtb_seqSummary.SelectionColor = Color.Black;
            rtb_seqSummary.AppendText("\nPlayback: ");

            //Check if sequence will play back correctly in game
            if (NoteUtils.auditSequence((int)nud_noteInterval.Value).Count != 0) {

                rtb_seqSummary.SelectionColor = Color.Red;
                rtb_seqSummary.AppendText("Error Found" +
                                        "\n(Click for more info)");
            }
            else {
                rtb_seqSummary.SelectionColor = Color.Green;
                rtb_seqSummary.AppendText("Optimal");
            }

        }//End summaryText

        //Copy sequence to clipboard
        private void copyText(object sender, EventArgs e) {
            //Copy sequence to clipboard
            if (tb_noteSequence.Text != "") {
                System.Windows.Forms.Clipboard.SetText(tb_noteSequence.Text);
            }
        }//End copyText

        //Upon resizing, fit controls to window
        private void resizeForm(object sender, EventArgs e) {
            if (mainWindow.ActiveForm != null) {

                //Note column holder and horizontal lines
                pnl_buttons.Width = mainWindow.ActiveForm.ClientSize.Width - 8;

                //Get new center column position
                scrollSequencer(null, null);
            }
        }//End resizeForm

        //Song timer
        Timer songTime = new Timer();

        //Song note index
        int songNote = 0;

        //On clicking play song button
        private void clickListen(object sender, EventArgs e) {

            //Focus sequencer
            focusSequencer();

            if (songTime.Enabled) {
                // Stop the song and reset the currently playing note's color.
                songTime.Enabled = false;
                btn_play.BackgroundImage = Image.FromFile(@".\res\media\play.png");
                if (songNote == 0) {
                    // The "previous note" is the final one.
                    noteCols[noteCols.Count - 1].setColorRTB(NoteUtils.beatColor(noteCols.Count - 1));
                    noteCols[noteCols.Count - 1].drawCrewmate(false);
                    scrollSequencer(null, null);
                }
                else {
                    noteCols[songNote - 1].setColorRTB(NoteUtils.beatColor(songNote - 1));
                    noteCols[songNote - 1].drawCrewmate(false);
                    scrollSequencer(null, null);
                }
                return;
            }

            //Print sequence to textbox
            clickUpdate(null, e);

            //Reset played note index
            songNote = 0;

            //Set interval (default 33ms)
            songTime.Interval = (int)nud_noteInterval.Value * 33;

            //If pressing play from start, play from start
            if (((Button)sender).Name == "btn_playStart") songNote = 0;
            //If pressing play, start from column at center of screen
            else songNote = centerColumn();

            EndFor: int endFor;

            //Start timer
            songTime.Enabled = true;
            btn_play.BackgroundImage = Image.FromFile(@".\res\media\stop.png");

            //Set center column
            scrollSequencer(null, null);

        }//End clickListen

        //Tick process for timer to play song
        private void nextTick(object Sender, EventArgs e) {

            //If "follow play bar" otpion enabled, scroll bar moves to play bar
            if (followPlayBar) {
                pnl_buttons.HorizontalScroll.Value = moveScrollBar(songNote);
            }

            //Color current column
            noteCols[songNote].setColorRTB(Color.LemonChiffon);

            //Get interval if changed while playing
            songTime.Interval = (int)nud_noteInterval.Value * 33;

            // Change the previous note to its original color.
            if (songNote == 0) {
                // The "previous note" is the final one.
                noteCols[noteCols.Count - 1].setColorRTB(NoteUtils.beatColor(noteCols.Count - 1));
                noteCols[noteCols.Count - 1].drawCrewmate(false);
            }
            else {
                noteCols[songNote - 1].setColorRTB(NoteUtils.beatColor(songNote - 1));
                noteCols[songNote - 1].drawCrewmate(false);
            }

            //Play note if not null
            if (indexList[songNote] != 0) {
                //Get note from folder
                notes = new SoundPlayer(@".\sounds\note" + noteFileName[indexList[songNote]] + ".wav");
                //Play note
                notes.Play();
                //Generate crewmate at note location
                noteCols[songNote].drawCrewmate(true);
            }
            //If null, draw crewmate at index equal to last non-null index
            else {
                noteCols[songNote].drawCrewmate(true);
            }

            //Check if end of note sequence reached
            if (songNote + 1 < indexList.Length) {
                //Play note if not end of sequence
                songNote++;
            }
            else if (loopSong) // Loop back to beginning
            {
                songNote = 0;
            }
            else //Stop timer if end of sequence reached
            {
                //Force back to default
                noteCols[songNote].setColorRTB(NoteUtils.beatColor(songNote));
                noteCols[songNote].drawCrewmate(false);
                //Stop timer
                songTime.Enabled = false;
                scrollSequencer(null, null);
                btn_play.BackgroundImage = Image.FromFile(@".\res\media\play.png");
            }

            bool restEmpty = true;

            //For the rest of the song
            for (int i = songNote; i < indexList.Length; i++) {
                //Check following notes if empty
                restEmpty &= (indexList[i] == 0);
            }

            if (restEmpty && !loopSong) //If all following notes empty, end song early
            {
                //Force back to default
                noteCols[songNote - 1].setColorRTB(NoteUtils.beatColor(songNote - 1));
                noteCols[songNote - 1].drawCrewmate(false);
                //Stop timer
                songTime.Enabled = false;
                scrollSequencer(null, null);
                btn_play.BackgroundImage = Image.FromFile(@".\res\media\play.png");
            }
        }//End next tick

        //Add specified number of new columns
        private void clickAddColumns(object sender, EventArgs e) {

            //Get values for edit length and location
            int addValue = (int)nud_addColumns.Value;
            int addIndex = (int)nud_insertColumn.Value - 1;

            //Stop song if currently playing
            songTime.Enabled = false;
            btn_play.BackgroundImage = Image.FromFile(@".\res\media\play.png");

            //Focus sequencer
            focusSequencer();

            //Stop columns from going over limit value
            if (indexList.Length == 1 && indexList.Length + addValue <= 1) {
                MessageBox.Show("Column limit reached!", "Warning!");
                return;
            }
            else if (indexList.Length == maxColumns && indexList.Length + addValue <= maxColumns) {
                MessageBox.Show("Column limit reached!", "Warning!");
                return;
            }

            //Weird workaround for negative values deleting note at edit start location
            if (addValue < 0) {
                addIndex++;
            }

            //Reset scroll to 0 to stop bug
            pnl_buttons.HorizontalScroll.Value = 0;

            //Cap additions and subtractions to either 1 or the max column limit
            if (indexList.Length + nud_addColumns.Value > maxColumns) {
                addValue = maxColumns - indexList.Length;
            }
            else if (indexList.Length + nud_addColumns.Value < 1) {
                addValue = -(indexList.Length - 1);
            }

            //Cap removal of columns to range of columns between the edit location and the end of song
            if (addIndex + -addValue > indexList.Length) {
                addValue = -(indexList.Length - addIndex);
            }

            //Old number of columns
            int oldSize = indexList.Length;

            //Stupid workaround
            int firstInd = indexList[0];

            //Temp new array
            int[] newIndex = new int[indexList.Length + addValue];

            //Copy old indexlist to new one
            for (int i = 0; i < newIndex.Length; i++) {
                //If before new columns, copy index note
                if (i < addIndex) {
                    newIndex[i] = indexList[i];
                }
                //If in range between new columns starting and ending
                else if (i >= addIndex && i <= (addIndex) + addValue) {
                    //If i in range of original song length
                    if (i <= (indexList.Length - 1)) {
                        //If note is present at column addition start
                        if (indexList[i] != 0 && i == addIndex) {
                            //Copy note to new index
                            newIndex[i] = indexList[i];
                        }
                        else {
                            //otherwise, make empty
                            newIndex[i] = 0;
                        }
                    }
                }
                else {
                    //If after added section of columns, copy notes at location minus added column amount
                    newIndex[i] = indexList[i - addValue];
                }
            }//End for

            //Generate new set of panels of new length
            generateNewPanels(newIndex.Length);

            //Apply new index to old index
            indexList = newIndex;

            //Place notes where they should be
            for (int i = 0; i < indexList.Length; i++) {
                if (indexList[i] != 0) {
                    noteCols[i].placeNote(7 - (indexList[i] - 1));
                }
            }
        }//End clickAddColumns

        //Refresh columns after changing time signature
        public void refreshColumns() {

            //Parse columns and change color
            for (int i = 0; i < noteCols.Count; i++) {
                noteCols[i].setColorRTB(NoteUtils.beatColor(i));
            }
        }//End refreshColumns

        //Process note string and load into the sequencer
        public void loadSequence(string seq) {

            if (NoteUtils.loadValidity(seq)) return;

            string noteParse = "";

            List<string> noteHolder = new List<string>();
            List<int> noteInt = new List<int>();

            //Focus sequencer
            focusSequencer();

            //Split string into each note with it's interval
            for (int i = 0; i < seq.Length; i++) {
                //If note is letter, start new entry
                if (char.IsLetter(seq[i])) {
                    //Start new note on letter
                    noteParse = Convert.ToString(seq[i]);
                }
                else {
                    //Add numbers to end of letter
                    noteParse += seq[i];
                }

                //If next character is letter, add entry to parsed notes
                if (seq.Length > i + 1) {
                    if (char.IsLetter(seq[i + 1])) {
                        noteHolder.Add(noteParse);
                    }
                }
                //Add entry at the end of sequence (workaround)
                else noteHolder.Add(noteParse);
            }//End for

            //Get index of note and interval total
            for (int i = 0; i < noteHolder.Count; i++) {
                //Get string at location in loaded note index
                string s = noteHolder[i];
                int noteIndex = 0;

                //Find number value of loaded notes
                for (int j = 0; j < noteFSO.Length; j++) {
                    //Check against FreeSO's notes
                    if (Convert.ToString(s[0]) == noteFSO[j]) {
                        //Get index value of note
                        noteIndex = j;
                        //Replace noteholder value with index
                        noteHolder[i] = Convert.ToString(noteIndex);
                        goto EndFor;
                    }
                }
            EndFor: int endFor;

                //Add loaded note interval to list
                noteInt.Add(int.Parse(s.Remove(0, 1)));
            }

            //Get master interval from last loaded entry
            int interval = noteInt[noteInt.Count - 1];
            //Set player note interval to master value
            nud_noteInterval.Value = interval;

            //Process loaded intervals against master interval to get column interval
            for (int i = 0; i < noteInt.Count; i++) {
                noteInt[i] = noteInt[i] / interval;
            }

            //Generate loaded song's note columns
            generateNewPanels(noteInt.Sum());

            //Reset index list to enter loaded notes
            indexList = new int[noteInt.Sum()];

            int parse = 0;
            int wait = 0;

            //Fill index list with notes, based on length between each note
            for (int i = 0; i < indexList.Length; i++) {
                //If interval is finished
                if (wait == 0) {
                    //Add note and go to next interval
                    indexList[i] = int.Parse(noteHolder[parse]);
                    wait = noteInt[parse];

                    //Place loaded note in proper location on number column
                    if (int.Parse(noteHolder[parse]) != 0) {
                        noteCols[i].placeNote(7 - (int.Parse(noteHolder[parse]) - 1));
                    }

                    //Increment place in loaded sequence
                    parse++;
                }

                //Tick down interval
                wait--;
            }
        }//End loadSequence

        //Center scroll bar around the play bar as it moves through the sequence
        public int moveScrollBar(int column) {

            int pos = 0;
            int columnWidth = noteCols[column].Width;

            //Set followed column to one at center of screen
            int follow = column - ((pnl_buttons.Width / 2) / noteCols[column].Width) - 1;

            //Get percentage of column passed to apply to scrolbar's move position percent
            double columnP = (double)(follow * noteCols[column].Width) / (noteCols.Count * columnWidth);

            //Get position of new scrollbar position
            pos = (int)(columnP * pnl_buttons.HorizontalScroll.Maximum);

            //Clamp position to min and max scroll bar size
            pos = Math.Max(pos, 0);
            pos = Math.Min(pos, pnl_buttons.HorizontalScroll.Maximum);

            //Return scroll position
            return pos;
        }//End moveScrollBar

        //Set focus to sequencer
        //Weird workaround to fix sequencer position from changing when clicking note for the first time
        private void focusSequencer() {

            pnl_buttons.Focus();

        }//End focusSequencer

        //Set loop button's image based on looping disabled/enabled
        private void clickLoop(object sender, EventArgs e) {

            loopSong ^= true;

            if (loopSong) {
                btn_loop.BackgroundImage = Image.FromFile(@".\res\media\repeaton.png");
            }
            else {
                btn_loop.BackgroundImage = Image.FromFile(@".\res\media\repeatoff.png");
            }
        }//End clickLoop

        //Clicking on sequence summary opens a window showing error columns
        private void clickSummary(object sender, EventArgs e) {

            //Get list of bad columns
            List<int> errorList = NoteUtils.auditSequence((int)nud_noteInterval.Value);
            //String for messagebox
            string errorMessage = "";

            //For each bad column
            if (errorList.Count != 0) {

                //Format "s" based on count
                if (errorList.Count == 1) errorMessage = "Error found at: ";
                else errorMessage = "Errors found at:";

                //Add column number plus formatted text
                for (int i = 0; i < errorList.Count; i++) {
                    errorMessage += "\nColumn: " + (errorList[i] + 1);
                }

                //Show messagebox
                MessageBox.Show(errorMessage, "Errors");
            }
        }//End clickSummary

        //Set color of center column
        private void scrollSequencer(object sender, ScrollEventArgs e) {

            //Fix for crashing when maximizing window
            if (this.Width >= indexList.Length * noteCols[0].Width) return;

            noteCols[previousColumn].setColorRTB(NoteUtils.beatColor(previousColumn));

            if (!songTime.Enabled) {
                noteCols[centerColumn()].setColorRTB(Color.LemonChiffon);
            }
        }//End scrollSequencer

        //Variable for previous center column
        int previousColumn;

        //Return number of column in center of screen
        private int centerColumn() {

            //Scroll percentage of scrollbar
            double scrollP = (double)pnl_buttons.HorizontalScroll.Value / (double)pnl_buttons.HorizontalScroll.Maximum;

            //Column in center of screen
            int pos = (int)(scrollP * noteCols.Count) + (int)((double)pnl_buttons.Width / 72d) + 1;

            previousColumn = pos;
            return pos;

        }//End centerColumn
    }
}
