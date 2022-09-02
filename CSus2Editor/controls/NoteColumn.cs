using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Diagnostics;
using System.Media;
using System.Runtime.InteropServices;

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

        public NoteColumn()
        {
            InitializeComponent();
        }

        //On load, populate button list
        private void controlLoad(object sender, EventArgs e)
        {


            formatRTBText();

            //Disable RTB usage
            ControlExtensions.DisableRTB(rtb_notes, pnl_Buttons);

        }//End controlLoad

        private void formatRTBText()
        {

            //Format note texts
            rtb_notes.Text = "\r\nE2\r\n\r\nD#\r\n\r\nC#\r\n\r\nB\r\n\r\nA\r\n\r\nG#\r\n\r\nF#\r\n\r\nE\r\n\r\n" + (index + 1);
            rtb_notes.SelectAll();
            rtb_notes.SelectionAlignment = HorizontalAlignment.Center;

        }

        //Clear note selection and formatting
        private void clearNote(object sender, EventArgs e)
        {

            //Clear previous button
            foreach (Control c in pnl_Buttons.Controls)
            {
                if (c is NoteButton)
                {
                    pnl_Buttons.Controls.Remove(c);
                    mainWindow.indexList[index] = 0;
                }
            }

        }//End clearNote

        public void setColorRTB(Color color)
        {

            rtb_notes.BackColor = color;

        }

        //Find position of mouse inside note column
        private void mouseMove(object sender, MouseEventArgs e)
        {

            //Get mouse X and Y
            mouseX = e.Location.X;
            mouseY = e.Location.Y;

        }//End mouseMove

        //Process clicked spot on note column
        private void mouseClick(object sender, EventArgs e)
        {

            getAreaClicked();

        }//End mouseClick

        //Process note clicked and apply to note index
        private void getAreaClicked()
        {

            //Get y index position
            int y = Math.Min((mouseY - 4) / 36, 7);

            //Clear previous note
            clearNote(null, null);

            //Generate Note
            placeNote(y);

            //Play seleced note
            mainWindow.notes = new SoundPlayer(@".\sounds\note" + mainWindow.noteFileName[noteIndex.Length - y] + ".wav");
            mainWindow.notes.Play();

        }//End getAreaClicked

        //Place note at specified location in column
        public void placeNote(int y)
        {

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
