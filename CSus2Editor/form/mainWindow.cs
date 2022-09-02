using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Diagnostics;
using System.Media;
using System.IO;

namespace CSus2Editor
{
    public partial class mainWindow : Form
    {

        public static List<NoteColumn> noteCols = new List<NoteColumn>();

        private static string PLAY_SONG_TEXT = "Play Song";
        private static string STOP_SONG_TEXT = "Stop Song";

        //FreeSO's weird messed up note index
        string[] noteFSO = { "empty", "C", "D", "E", "F", "G", "A", "B", "H" };

        public static string[] noteFileName = { "empty", "E", "FS", "GS", "A", "B", "CS", "DS", "E2" };

        public static int[] indexList;

        public static int pnlScroll = 0;

        public mainWindow()
        {

            InitializeComponent();

        }

        public static SoundPlayer notes = new SoundPlayer();

        //On loading, set initial values
        private void windowLoad(object sender, EventArgs e)
        {

            //Set default values
            nud_seqLength.Value = 16;
            nud_addColumns.Value = 1;
            nud_noteInterval.Value = 5;

            //Generate note columns
            generateNewPanels();

            //Set tick to timer
            songTime.Tick += new EventHandler(nextTick);

        }//End windowLoad

        //Generate panels based on sequence length
        private void generateNewPanels()
        {

            //CLear previous panels
            pnl_buttons.Controls.Clear();
            noteCols.Clear();

            //Index list to parse values for each usercontrol
            indexList = new int[(int)nud_seqLength.Value];

            //For sequence length, make and place new usercontrols
            for (int i = 0; i < nud_seqLength.Value; i++)
            {

                NoteColumn notes = new NoteColumn();

                notes.Location = new Point((i * notes.Width), -10);
                notes.index = i;

                pnl_buttons.Controls.Add(notes);
                
                notes.rtb_notes.BackColor = beatColor(i);

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

            generateNewPanels();
            
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
            for (int i = 0; i < indexList.Length; i++) {
                if (indexList[i] != 0) {
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
            if(indexList.Length == 100)
            {
                MessageBox.Show("Column limit reached!", "Warning!");
                return;
            }

            //Reset scroll to 0 to stop bug
            pnl_buttons.HorizontalScroll.Value = 0;

            //number of columns to add
            int addValue = (int)nud_addColumns.Value;

            if (indexList.Length + nud_addColumns.Value > 100)
            {

                addValue = 100 - indexList.Length;

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

        private void loopCheckboxClicked(object sender, EventArgs e) {
            // Unused.
        }
    }
}
