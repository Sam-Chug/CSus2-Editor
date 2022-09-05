using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Diagnostics;
using System.Media;
using System.Runtime.InteropServices;
using System.Linq;

namespace CSus2Editor
{
    public partial class NoteColumn : UserControl
    {
        //Real note index
        public static string[] noteIndex = { "E", "F#", "G#", "A", "B", "C#", "D#", "E2" };

        //Note column ID
        public int index;

        //Mouse position vars
        int mouseX;
        int mouseY;

        public NoteColumn() {
            InitializeComponent();
        }

        //On load, populate button list
        private void controlLoad(object sender, EventArgs e) {
            //Format richtextbox
            formatRTBText();

            //Disable RTB usage
            ControlExtensions.DisableRTB(rtb_notes, pnl_Buttons);

        }//End controlLoad

        //Set richtextbox text, center it, and add it's # position in the column list
        private void formatRTBText() {
            //Format note texts
            rtb_notes.Text = "\r\nE2\r\n\r\nD#\r\n\r\nC#\r\n\r\nB\r\n\r\nA\r\n\r\nG#\r\n\r\nF#\r\n\r\nE\r\n\r\n" + (index + 1);
            rtb_notes.SelectAll();
            rtb_notes.SelectionAlignment = HorizontalAlignment.Center;

        }//End formatRTBText

        //Clear note selection and formatting
        private void clearNote(object sender, EventArgs e) {
            //Clear previous button
            foreach (Control c in pnl_Buttons.Controls) {
                if (c is NoteButton) {
                    pnl_Buttons.Controls.Remove(c);
                    mainWindow.indexList[index] = 0;
                }
            }
        }//End clearNote

        //Set backcolor of richtextbox
        public void setColorRTB(Color color) {
            rtb_notes.BackColor = color;

        }//End setColorRTB

        //This whole thing is sus
        public void drawCrewmate(bool alive) {
            //Check for draw cremate option
            if (!mainWindow.drawCrewmate) return;

            //Generate crewmate at note
            if (alive) {
                //If no notes, skip drawing - workaround for getting stuck in loop
                if (mainWindow.indexList.Sum() == 0) return;

                //New crewmate
                Crewmate crewmate = new Crewmate();
                pnl_Buttons.Controls.Add(crewmate);
                crewmate.BackColor = Color.LemonChiffon;

                int crewmateY = mainWindow.indexList[index];

                //Check if drawing empty note crewmates is enabled
                if (!mainWindow.drawCrewmateEmpty) goto EndFor;

                //Workaround for weird behavior at index 0
                if (index == 0 && mainWindow.indexList[index] == 0) {
                    //Search ahead for first non-null note
                    for (int i = 0; i < mainWindow.indexList.Length; i++) {
                        if (mainWindow.indexList[i] != 0) {
                            //Set Y to last value in indexlist
                            crewmateY = mainWindow.indexList[i];
                            goto EndFor;
                        }
                    }
                }

                //Backwards search to find first non-null note
                if (mainWindow.indexList[index] == 0) {
                    for (int i = (mainWindow.indexList[index] - (mainWindow.indexList[index] - index)); i-- > 0;) {
                        //Set crewmate location to last non-null note
                        if (mainWindow.indexList[i] != 0) {
                            crewmateY = mainWindow.indexList[i];
                            goto EndFor;
                        }
                        //If no non-null notes behind, search ahead for first non-null note
                        if (i == 0) {
                            for (int j = 0; j < mainWindow.indexList.Length; j++) {
                                if (mainWindow.indexList[j] != 0) {
                                    crewmateY = mainWindow.indexList[j];
                                    goto EndFor;
                                }
                            }
                        }
                    }
                }
            EndFor: int endFor;

                //Set min Y
                crewmateY = Math.Min(crewmateY, 8);

                //Set crewmate backcolor green if on note
                if (mainWindow.indexList[index] != 0) crewmate.BackColor = Color.LightGreen;

                //Skip empty note drawing if option disabled
                if (!mainWindow.drawCrewmateEmpty && crewmateY == 0) return;

                //Set location to note index and bring to front
                crewmate.Location = new Point(0, ((8 - crewmateY) * 36) + 9);
                crewmate.BringToFront();
            }

            //Kill crewmate after note passed
            else {
                //Find crewmate in vents
                foreach (Control c in pnl_Buttons.Controls) {
                    //Crewmate gets voted out
                    if (c is Crewmate) {
                        pnl_Buttons.Controls.Remove(c);
                    }
                }
            }
        }//End drawCrewmate

        //Find position of mouse inside note column
        private void mouseMove(object sender, MouseEventArgs e) {
            //Get mouse X and Y
            mouseX = e.Location.X;
            mouseY = e.Location.Y;

        }//End mouseMove

        //Process clicked spot on note column
        private void mouseClick(object sender, EventArgs e) {
            getAreaClicked();

        }//End mouseClick

        //Process note clicked and apply to note index
        private void getAreaClicked() {
            //Get y index position
            int y = (mouseY - 10) / 36;

            //Check if note in range
            if (y <= 7) {
                //Clear previous note
                clearNote(null, null);
                //Place new note
                placeNote(y);
            }
            else return;

            //Play seleced note
            mainWindow.notes = new SoundPlayer(@".\sounds\note" + mainWindow.noteFileName[noteIndex.Length - y] + ".wav");
            mainWindow.notes.Play();

        }//End getAreaClicked

        //Place note at specified location in column
        public void placeNote(int y) {
            //Create new button control
            NoteButton highlight = new NoteButton();
            pnl_Buttons.Controls.Add(highlight);

            //Set formatting on button
            highlight.index = index;
            highlight.Location = new Point(0, (y * 36) + 9);
            highlight.setText(noteIndex[noteIndex.Length - (y + 1)]);
            highlight.BringToFront();

            //Set index to list
            mainWindow.indexList[index] = noteIndex.Length - y;

        }//End placeNote
    }
}
