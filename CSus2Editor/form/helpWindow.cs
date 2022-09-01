using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace CSus2Editor
{
    public partial class helpWindow : Form
    {

        //Get help text from file
        string helpText = System.IO.File.ReadAllText(@".\res\Help.txt");

        public helpWindow()
        {
            InitializeComponent();
        }

        //Fake-disable rich text boxes
        

        //on loading help window
        private void formLoad(object sender, EventArgs e)
        {

            rtb_helpText.Text = helpText;

            ControlExtensions.DisableRTB(rtb_helpText, helpWindow.ActiveForm);

        }//End formLoad

        private void formResize(object sender, EventArgs e)
        {
            //Resize panel
            pnl_UIHelp.Width = (helpWindow.ActiveForm.Width - 24);
            pnl_UIHelp.Height = (helpWindow.ActiveForm.Height - 47);
            //Resize text box
            rtb_helpText.Width = (helpWindow.ActiveForm.Width - 24);
            rtb_helpText.Height = (helpWindow.ActiveForm.Height - 47);

        }
    }
}
