using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSus2Editor
{
    public partial class timesigWindow : Form
    {
        public timesigWindow()
        {
            InitializeComponent();
        }

        //On form load
        private void formLoad(object sender, EventArgs e)
        {
            //Stop resize
            this.FormBorderStyle = FormBorderStyle.FixedSingle;

            //Set time signature label
            timeSigLabel();

        }//End formLoad

        //Format time signature label
        private void timeSigLabel()
        {

            lbl_newSig.Text = "Signature: " + nud_beats.Value + "/" + nud_quarters.Value;

        }//End timeSigLabel

        //Finalize new time signature and pass values to main window
        private void clickNewSig(object sender, EventArgs e)
        {

            //Send values
            mainWindow.beats = (int)nud_beats.Value;
            mainWindow.quarters = (int)nud_quarters.Value;

            //Refresh columns
            mainWindow.refreshColumns();

            //Close window
            timesigWindow.ActiveForm.Close();

        }//End clickNewSig

        private void changeNud(object sender, EventArgs e)
        {

            timeSigLabel();

        }
    }
}
