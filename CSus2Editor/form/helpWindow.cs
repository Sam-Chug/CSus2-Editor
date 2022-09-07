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

namespace CSus2Editor {
    public partial class helpWindow : Form {
        
        public helpWindow() {
            InitializeComponent();
        }

        //on loading help window
        private void formLoad(object sender, EventArgs e) {

            //Disable currently shown richtextbox
            changeTab(null, null);

            //Get rtf format string from files and write to richtextboxes
            rtb_sequencer.Rtf = System.IO.File.ReadAllText(@".\res\rtf\Sequencer.rtf");
            rtb_interface.Rtf = System.IO.File.ReadAllText(@".\res\rtf\Interface.rtf");
            rtb_options.Rtf = System.IO.File.ReadAllText(@".\res\rtf\Options.rtf");
            rtb_tips.Rtf = System.IO.File.ReadAllText(@".\res\rtf\Tips.rtf");

        }//End formLoad

        //Resize richtextbox with form
        private void formResize(object sender, EventArgs e) {

            //Resize tab control on window resize
            tc_helpTabs.Size = new Size(this.ClientSize.Width - 8, this.ClientSize.Height - 8);

        }//End formResize

        //Disable selected tab's richtextboxes
        private void changeTab(object sender, EventArgs e) {

        }//End changeTab
    }
}
