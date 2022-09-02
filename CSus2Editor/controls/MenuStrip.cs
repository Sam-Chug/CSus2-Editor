using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Diagnostics;
using System.Media;
using CSus2Editor.form;

namespace CSus2Editor
{
    public partial class mainWindow
    {

        bool firstNote = true;
        public static bool drawCremate = true;

        //On clicking about under help
        private void clickAbout(object sender, EventArgs e)
        {
            MessageBox.Show("CSus2 Music Box Editor " + mainWindow.version + 
                          "\nCreated By: Reaganomics Lamborghini",
                          "About CSus2 Editor");

        }//End clickAbout

        //On clicking view help under help
        private void clickViewHelp(object sender, EventArgs e)
        {
            helpWindow help = new helpWindow();
            help.Show();

        }//End clickViewHelp

        //On clicking exit under file
        private void clickExit(object sender, EventArgs e)
        {
            //Prompt user if sure to exit
            if (MessageBox.Show("Are you sure you want to exit?", "Warning!", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                //Close application
                Application.Exit();
            }
        }//End clickExit

        //Open time signature window
        private void clickTimeSignature(object sender, EventArgs e)
        {
            timesigWindow timeSig = new timesigWindow();
            timeSig.Show();

        }//End clickTimeSignature

        //Open load sequence window
        private void loadSequence(object sender, EventArgs e)
        {
            //Create new loadWindow and set owner to mainWindow
            loadWindow load = new loadWindow();
            load.ShowDialog(this);

        }//End loadSequence

        //Option to play from first note or from beginning of sequence
        private void clickFirstNote(object sender, EventArgs e)
        {

            firstNote ^= true;
            options_firstNote.Checked = firstNote;

        }//End clickFirstNote

        //Option to draw crewmate when playing song
        private void clickCrewmate(object sender, EventArgs e)
        {

            drawCremate ^= true;
            options_showCrewmate.Checked = drawCremate;

        }//End clickCrewmate
    }
}
