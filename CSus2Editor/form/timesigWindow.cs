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
        public timesigWindow() {
            InitializeComponent();
        }

        //On form load
        private void formLoad(object sender, EventArgs e) {

            //Stop resize
            this.FormBorderStyle = FormBorderStyle.FixedSingle;

            //Set time signature label
            changeNud(null, e);

            //Set default values to current beat and quarter values
            nud_beats.Value = mainWindow.beats;
            nud_quarters.Value = mainWindow.quarters;
            nud_offset.Value = mainWindow.offset;

        }//End formLoad

        //Finalize new time signature and pass values to main window
        private void clickNewSig(object sender, EventArgs e) {

            //Send values
            mainWindow.beats = (int)nud_beats.Value;
            mainWindow.quarters = (int)nud_quarters.Value;
            mainWindow.offset = (int)nud_offset.Value;

            //Get main window
            mainWindow main = this.Owner as mainWindow;

            //Refresh columns
            main.refreshColumns();

            //Close window
            timesigWindow.ActiveForm.Close();

        }//End clickNewSig

        //Change time signature label to reflect numericupdown values
        private void changeNud(object sender, EventArgs e) {

            //Change time sig label
            lbl_newSig.Text = "Signature: " + nud_beats.Value + "/" + nud_quarters.Value;

        }//End changeNud

        private void changeNud(object sender, MouseEventArgs e) {

        }
    }
}
