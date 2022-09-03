using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSus2Editor {
    public partial class NoteButton : UserControl {
        public int index;

        public NoteButton() {
            InitializeComponent();
        }

        //on load, format button
        private void controlLoad(object sender, EventArgs e) {
            btn_note.BackColor = Color.LightGreen;
            btn_note.Size = new Size(36, 36);
            btn_note.FlatStyle = FlatStyle.Flat;
            btn_note.FlatAppearance.MouseOverBackColor = btn_note.BackColor;
            btn_note.FlatAppearance.BorderSize = 0;
            btn_note.Font = new Font("Comic Sans MS", 9, FontStyle.Bold);
            btn_note.TabStop = false;

        }//End controlLoad

        //Set text to selected note
        public void setText(string text) {
            this.btn_note.Text = text;

        }//End setText

        //on clicking note, delete note
        private void onClick(object sender, EventArgs e) {
            mainWindow.indexList[index] = 0;
            this.Parent.Controls.Remove(this);

        }//End onClick
    }
}
