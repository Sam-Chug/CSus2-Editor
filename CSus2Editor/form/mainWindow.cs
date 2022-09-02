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

namespace CSus2Editor
{
    public partial class mainWindow : Form
    {
        //So I dont forget to change it in the texts again lmao
        public static string version = "v1.1.0";

        public static List<NoteColumn> noteCols = new List<NoteColumn>();

        private static string PLAY_SONG_TEXT = "Play Song";
        private static string STOP_SONG_TEXT = "Stop Song";

        //FreeSO's weird messed up note index
        public string[] noteFSO = { "empty", "C", "D", "E", "F", "G", "A", "B", "H" };

        //note(x).wav strings
        public static string[] noteFileName = { "empty", "E", "FS", "GS", "A", "B", "CS", "DS", "E2" };

        //note index array
        public static int[] indexList;

        //Max column amount
        int maxColumns = 250;

        //Sound player for playing note sounds
        public static SoundPlayer notes = new SoundPlayer();

        public mainWindow()
        {
            InitializeComponent();
        }

        //On loading, set initial values
        private void windowLoad(object sender, EventArgs e)
        {
            //Set default values
            nud_seqLength.Value = 16;
            nud_addColumns.Value = 1;
            nud_noteInterval.Value = 5;

            nud_seqLength.Maximum = maxColumns;
            nud_addColumns.Maximum = maxColumns;

            //Generate note columns
            generateNewPanels((int)nud_seqLength.Value);

            //Set tick to timer
            songTime.Tick += new EventHandler(nextTick);

        }//End windowLoad

        //Generate panels based on requested length
        public void generateNewPanels(int panels)
        {
            //CLear previous panels
            pnl_buttons.Controls.Clear();
            noteCols.Clear();

            //Index list to parse values for each usercontrol
            indexList = new int[panels];

            //For sequence length, make and place new usercontrols
            for (int i = 0; i < panels; i++)
            {
                //New note column
                NoteColumn notes = new NoteColumn();

                //Move to end of existing notecolumns
                notes.Location = new Point((i * notes.Width), -10);
                notes.index = i;

                //Add to panel's controls
                pnl_buttons.Controls.Add(notes);
                
                //Get time signature color and apply to richtextbox
                notes.rtb_notes.BackColor = beatColor(i);

                //Add note column to list
                noteCols.Add(notes);
            }

            //Remove vertical scrollbar (weird workaround)
            pnl_buttons.VerticalScroll.Maximum = 0;
            pnl_buttons.AutoScroll = false;
            pnl_buttons.VerticalScroll.Visible = false;
            pnl_buttons.AutoScroll = true;

        }//End generateNewPanels

        //On changing sequence length and clicking generate new sequence
        private void clickGenerate(object sender, EventArgs e)
        {
            generateNewPanels((int)nud_seqLength.Value);
            
        }//End clickGenerate

        //Update note sequence
        private void clickUpdate(object sender, EventArgs e)
        {
            string sequence = "";
            int interval = 0;

            //Get each note and add sequence
            for (int i = 0; i < noteCols.Count; i++)
            {
                interval = (int)nud_noteInterval.Value;

                if (indexList[i] != 0)
                {
                    sequence += noteFSO[indexList[i]];
                }

                //Check if array has a following value
                if(indexList.Length > (i + 1))
                {
                    //If note null
                    if (indexList[i + 1] == 0)
                    {
                        //Find interval until next note
                        for (int j = 0; j < (noteCols.Count - i); j++)
                        {
                            //Check if next note in search is null
                            if(indexList.Length > (i + j + 1))
                            {
                                //If next search is null
                                if (indexList[i + j + 1] == 0)
                                {
                                    //Increment interval
                                    interval += (int)nud_noteInterval.Value;
                                }
                                //If not null, end increment
                                else goto ForEnd;
                            }
                            else //If end of song reached, add default interval instead of sum of intervals
                            {
                                interval = (int)nud_noteInterval.Value;
                            }
                        }
                    }
                //Placeholder for goto
                ForEnd: int skip;
                }

                //Only write interval for non-null note index
                if (indexList[i] != 0)
                {
                    sequence += interval;
                }
            }

            //Set sequence text
            tb_noteSequence.Text = sequence;

        }//End clickUpdate

        //Copy sequence to clipboard
        private void copyText(object sender, EventArgs e)
        {
            //Copy sequence to clipboard
            if(tb_noteSequence.Text != "")
            {
                System.Windows.Forms.Clipboard.SetText(tb_noteSequence.Text);
            }
        }//End copyText

        //Upon resizing, fit panel to window
        private void resizeForm(object sender, EventArgs e)
        {
            if (mainWindow.ActiveForm != null)
            {
                //Process resizable controls
                pnl_buttons.Width = mainWindow.ActiveForm.Width - 23;
                lbl_UIHLine1.Width = mainWindow.ActiveForm.Width;
                lbl_UIHLine2.Width = mainWindow.ActiveForm.Width;
            }

        }//End resizeForm

        //Song timer
        Timer songTime = new Timer();

        //Song note index
        int songNote = 0;

        //On clicking play song button
        private void clickListen(object sender, EventArgs e)
        {
            if (songTime.Enabled)
            {
                // Stop the song and reset the currently playing note's color.
                songTime.Enabled = false;
                btn_playSong.Text = PLAY_SONG_TEXT;
                if (songNote == 0) {
                    // The "previous note" is the final one.
                    noteCols[noteCols.Count - 1].setColorRTB(beatColor(noteCols.Count - 1));
                } else {
                    noteCols[songNote - 1].setColorRTB(beatColor(songNote - 1));
                }
                return;
            }

            //Print sequence to textbox
            clickUpdate(null, e);

            //Reset played note index
            songNote = 0;

            //Set interval (default 33ms)
            songTime.Interval = (int)nud_noteInterval.Value * 33;

            //Find first non-empty note
            for (int i = 0; i < indexList.Length; i++)
            {
                if (indexList[i] != 0)
                {
                    //Set played note index to first non-empty note
                    songNote = i;
                    goto EndFor;
                }
            }
            EndFor: int endFor;

            //Start timer
            songTime.Enabled = true;
            btn_playSong.Text = STOP_SONG_TEXT;

        }//End clickListen

        //Tick process for timer to play song
        private void nextTick(object Sender, EventArgs e)
        {
            //Color current column
            noteCols[songNote].setColorRTB(Color.LemonChiffon);

            // Change the previous note to its original color.
            if (songNote == 0)
            {
                // The "previous note" is the final one.
                noteCols[noteCols.Count - 1].setColorRTB(beatColor(noteCols.Count - 1));
            }
            else
            {
                noteCols[songNote - 1].setColorRTB(beatColor(songNote - 1));
            }

            //Play note if not null
            if (indexList[songNote] != 0)
            {
                //Get note from folder
                notes = new SoundPlayer(@".\sounds\note" + noteFileName[indexList[songNote]] + ".wav");
                //Play note
                notes.Play();
            }

            //Check if end of note sequence reached
            if (songNote + 1 < indexList.Length)
            {
                //Play note if not end of sequence
                songNote++;
            }
            else if (loopCheckbox.Checked) // Loop back to beginning
            {
                songNote = 0;
            }
            else //Stop timer if end of sequence reached
            {
                //Force back to default
                noteCols[songNote].setColorRTB(beatColor(songNote));
                //Stop timer
                songTime.Enabled = false;
                btn_playSong.Text = PLAY_SONG_TEXT;
            }

            bool restEmpty = true;

            //For the rest of the song
            for (int i = songNote; i < indexList.Length; i++)
            {
                //Check following notes if empty
                restEmpty &= (indexList[i] == 0);
            }

            if (restEmpty && !loopCheckbox.Checked) //If all following notes empty, end song early
            {
                //Force back to default
                noteCols[songNote - 1].setColorRTB(beatColor(songNote - 1));
                //Stop timer
                songTime.Enabled = false;
                btn_playSong.Text = PLAY_SONG_TEXT;
            }

        }//End next tick

        //Add specified number of new columns
        private void clickAddColumns(object sender, EventArgs e)
        {
            //Stop columns from going over 100
            if(indexList.Length == maxColumns)
            {
                MessageBox.Show("Column limit reached!", "Warning!");
                return;
            }

            //Reset scroll to 0 to stop bug
            pnl_buttons.HorizontalScroll.Value = 0;

            //number of columns to add
            int addValue = (int)nud_addColumns.Value;

            if (indexList.Length + nud_addColumns.Value > maxColumns)
            {
                addValue = maxColumns - indexList.Length;
            }

            //Old number of columns
            int oldSize = indexList.Length;

            //Stupid workaround
            int firstInd = indexList[0];

            //Temp new array
            int[] newIndex = new int[indexList.Length + addValue];

            //Copy old index to new index
            for (int i = 0; i < indexList.Length; i++)
            {
                newIndex[i] = indexList[i];
            }

            //Apply new temp to indexList
            indexList = newIndex;

            //Add specified number of new columns
            for (int i = 0; i < addValue; i++)
            {
                //New column
                NoteColumn notes = new NoteColumn();

                //Set variables
                notes.Location = new Point((i + oldSize) * notes.Width, -10);
                notes.index = (i + oldSize);

                //Add to panel
                pnl_buttons.Controls.Add(notes);

                //Set backcolor based on index
                notes.rtb_notes.BackColor = (beatColor(i + oldSize));

                //Add to list
                noteCols.Add(notes);

                //Stupid workaround
                indexList[0] = firstInd;

            }//End for
        }//End clickAddColumns

        //Pressing enter on sequence length box (QoL)
        private void setLengthEnter(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                //Generate new sequence
                clickGenerate(null, e);
            }
        }//End setLengthEnter

        //Pressing enter on add columns box (QoL)
        private void addColumnsEnter(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                //Add new columns
                clickAddColumns(null, e);
            }
        }//End addColumnsEnter

        //Time signature vars
        public static int beats = 4;
        public static int quarters = 4;

        //Use beat and quarters to color columns based on time signature
        public static Color beatColor(int i)
        {
            //Default color
            Color c = Color.White;

            //Beats
            if((i + 1) % quarters == 1)
            {
                c = Color.LightBlue;
            }
            //Measures
            if ((i + 1) % (beats * quarters) == 1)
            {
                c = Color.LightCoral;
            }
            if ((i + 1) % (beats * beats * quarters) == 1)
            {
                c = Color.Plum;
            }

            //Return color
            return c;

        }//End beatColor

        //Refresh columns after changing time signature
        public static void refreshColumns()
        {
            //Parse columns and change color
            for (int i = 0; i < noteCols.Count; i++)
            {
                noteCols[i].setColorRTB(beatColor(i));
            }
        }//End refreshColumns

        //Check validity of loaded sequence
        public void loadValidity(string seq)
        {
            bool error = false;
            bool numCheck = false;
            bool letterCheck = false;

            for (int i = 0; i < seq.Length; i++)
            {
                //Lower case check
                if (char.IsLetter(seq[i]) && char.IsLower(seq[i]))
                {
                    error = true;
                }

                //Check if there are numbers
                if (char.IsNumber(seq[i]))
                {
                    numCheck = true;
                }

                //Check if each note follows FreeSO's notation
                if (char.IsLetter(seq[i]))
                {
                    bool notationCheck = false;

                    for (int j = 0; j < noteFSO.Length; j++)
                    {
                        if (Convert.ToString(seq[i]) == noteFSO[j])
                        {
                            notationCheck = true;
                            letterCheck = true;
                        }
                    }
                    if (!notationCheck)
                    {
                        error = true;
                    }
                }

                //Make sure letter always follows number
                if (i > 0)
                {
                    if (char.IsLetter(seq[i]) && !char.IsNumber(seq[i - 1]))
                    {
                        error = true;
                    }
                }

                //Check if letters follow another
                if(seq.Length < (i + 1))
                {
                    if (char.IsLetter(seq[i]) && char.IsLetter(seq[i + 1]))
                    {
                        error = true;
                    }
                }

                //Make sure last character is a number
                if (!char.IsDigit(seq[seq.Length - 1]))
                {
                    error = true;
                }
            }

            //Check for numbers and valid letters
            if (!numCheck || !letterCheck)
            {
                error = true;
            }

            //If error found, show warning and do not pass to loading
            if (error)
            {
                MessageBox.Show("This sequence does not follow the input format!", "Warning!");
                return;
            }

            //Move on to loading sequence if it checks out
            loadSequence(seq);

        }//End loadValidity

        //Process note string and load into the sequencer
        public void loadSequence(string seq)
        {

            string noteParse = "";

            List<string> noteHolder = new List<string>();
            List<int> noteInt = new List<int>();

            //Split string into each note with it's interval
            for (int i = 0; i < seq.Length; i++)
            {
                //If note is letter, start new entry
                if (char.IsLetter(seq[i]))
                {
                    //Start new note on letter
                    noteParse = Convert.ToString(seq[i]);
                }
                else
                {
                    //Add numbers to end of letter
                    noteParse += seq[i];
                }

                //If next character is letter, add entry to parsed notes
                if(seq.Length > i + 1)
                {
                    if (char.IsLetter(seq[i + 1]))
                    {
                        noteHolder.Add(noteParse);
                    }
                }
                //Add entry at the end of sequence (workaround)
                else noteHolder.Add(noteParse);
            }//End for

            //Get index of note and interval total
            for (int i = 0; i < noteHolder.Count; i++)
            {
                //Get string at location in loaded note index
                string s = noteHolder[i];
                int noteIndex = 0;

                //Find number value of loaded notes
                for (int j = 0; j < noteFSO.Length; j++)
                {
                    //Check against FreeSO's notes
                    if(Convert.ToString(s[0]) == noteFSO[j])
                    {
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
            nud_noteInterval.Value = 7;

            //Process loaded intervals against master interval to get column interval
            for (int i = 0; i < noteInt.Count; i++)
            {
                noteInt[i] = noteInt[i] / interval;
            }

            //Generate loaded song's note columns
            generateNewPanels(noteInt.Sum());

            //Reset index list to enter loaded notes
            indexList = new int[noteInt.Sum()];

            int parse = 0;
            int wait = 0;

            //Fill index list with notes, based on length between each note
            for (int i = 0; i < indexList.Length; i++)
            {
                //If interval is finished
                if(wait == 0)
                {
                    //Add note and go to next interval
                    indexList[i] = int.Parse(noteHolder[parse]);
                    wait = noteInt[parse];

                    //Place loaded note in proper location on number column
                    noteCols[i].placeNote(7 - (int.Parse(noteHolder[parse]) - 1));

                    //Increment place in loaded sequence
                    parse++;
                }
                //Tick down interval
                wait--;
            }
        }//End loadSequence
    }
}
