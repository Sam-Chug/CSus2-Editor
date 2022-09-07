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
        public static bool measureLines = true;
        public static bool drawCrewmate = true;
        public static bool drawCrewmateEmpty = false;
        public static bool followPlayBar = true;

        //On clicking about under help
        private void clickAbout(object sender, EventArgs e) {
            MessageBox.Show("CSus2 Music Box Editor " + mainWindow.version +
                          "\nCreated By: Reaganomics Lamborghini",
                          "About CSus2 Editor");

        }//End clickAbout

        //On clicking exit under file
        private void clickExit(object sender, EventArgs e) {
            //Prompt user if sure to exit
            if (MessageBox.Show("Are you sure you want to exit?", "Warning!", MessageBoxButtons.YesNo) == DialogResult.Yes) {
                //Close application
                Application.Exit();
            }
        }//End clickExit

        //On clicking view help under help
        private void clickViewHelp(object sender, EventArgs e) {
            helpWindow help = new helpWindow();
            help.ShowDialog(this);

        }//End clickViewHelp

        //Open time signature window
        private void clickTimeSignature(object sender, EventArgs e) {
            timesigWindow timeSig = new timesigWindow();
            timeSig.ShowDialog(this);

        }//End clickTimeSignature

        //Open load sequence window
        private void loadSequence(object sender, EventArgs e) {
            //Create new loadWindow and set owner to mainWindow
            loadWindow load = new loadWindow();
            load.ShowDialog(this);

        }//End loadSequence

        private void clickNewSequence(object sender, EventArgs e) {
            //Generate new sequence based on the size of two measures
            generateNewPanels(Math.Min(2 * beats * quarters, maxColumns));

        }//End clickNewSequence

        //OPTIONS//

        //Option to follow the playbar as the song plays
        private void clickFollowPlay(object sender, EventArgs e) {
            followPlayBar ^= true;
            options_followPlay.Checked = followPlayBar;

        }//End clickFollowPlay

        //Option to draw crewmate when playing song
        private void clickCrewmate(object sender, EventArgs e) {
            drawCrewmate ^= true;
            options_showCrewmate.Checked = drawCrewmate;

        }//End clickCrewmate

        //Option to show measure lines on the sequencer
        private void clickMeasureLines(object sender, EventArgs e) {
            measureLines ^= true;
            options_measureLines.Checked = measureLines;

            //Refresh column colors
            refreshColumns();

        }//End clickMeasureLines

        //Option to draw crewmates on empty notes
        private void clickCMDrawEmpty(object sender, EventArgs e) {
            drawCrewmateEmpty ^= true;
            cm_drawEmpty.Checked = drawCrewmateEmpty;

        }//End clickCMDrawEmpty


    }
}
