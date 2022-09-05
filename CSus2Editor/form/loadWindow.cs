using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSus2Editor.form {
    public partial class loadWindow : Form {
        public loadWindow() {
            InitializeComponent();
        }

        //On form load
        private void formLoad(object sender, EventArgs e) {
            //Stop resize
            this.FormBorderStyle = FormBorderStyle.FixedSingle;

        }//End formLoad

        //On pressing enter in load window
        private void pressEnter(object sender, KeyEventArgs e) {
            //Get enter keypress
            if (e.KeyCode == Keys.Enter) {
                string loadSeq = "";

                //Get sequence from text box
                loadSeq = tb_sequence.Text;

                //Grab mainwindow
                mainWindow main = this.Owner as mainWindow;

                //Check validity of sequence, load if valid
                main.loadSequence(loadSeq);

                //Close load window
                loadWindow.ActiveForm.Close();
            }
        }//End pressEnter
    }
}
