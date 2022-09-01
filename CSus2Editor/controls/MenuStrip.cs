using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Diagnostics;
using System.Media;

namespace CSus2Editor
{
    public partial class mainWindow
    {

        //On clicking about under help
        private void clickAbout(object sender, EventArgs e)
        {

            MessageBox.Show("CSus2 Music Box Editor Version 1.0" +
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
    }
}
