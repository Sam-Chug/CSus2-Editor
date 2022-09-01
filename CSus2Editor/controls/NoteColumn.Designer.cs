
namespace CSus2Editor
{
    partial class NoteColumn
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnl_Buttons = new System.Windows.Forms.Panel();
            this.rtb_notes = new System.Windows.Forms.RichTextBox();
            this.pnl_Buttons.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_Buttons
            // 
            this.pnl_Buttons.BackColor = System.Drawing.Color.Transparent;
            this.pnl_Buttons.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl_Buttons.Controls.Add(this.rtb_notes);
            this.pnl_Buttons.Location = new System.Drawing.Point(0, 0);
            this.pnl_Buttons.Name = "pnl_Buttons";
            this.pnl_Buttons.Size = new System.Drawing.Size(36, 350);
            this.pnl_Buttons.TabIndex = 9;
            // 
            // rtb_notes
            // 
            this.rtb_notes.BackColor = System.Drawing.Color.White;
            this.rtb_notes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtb_notes.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtb_notes.Location = new System.Drawing.Point(0, 0);
            this.rtb_notes.Name = "rtb_notes";
            this.rtb_notes.ReadOnly = true;
            this.rtb_notes.Size = new System.Drawing.Size(36, 350);
            this.rtb_notes.TabIndex = 11;
            this.rtb_notes.Text = "\nE2\n\nD#\n\nC#\n\nB\n\nA\n\nG#\n\nF#\n\nE";
            this.rtb_notes.Click += new System.EventHandler(this.mouseClick);
            this.rtb_notes.MouseMove += new System.Windows.Forms.MouseEventHandler(this.mouseMove);
            // 
            // NoteColumn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnl_Buttons);
            this.Name = "NoteColumn";
            this.Size = new System.Drawing.Size(36, 350);
            this.Load += new System.EventHandler(this.controlLoad);
            this.pnl_Buttons.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnl_Buttons;
        public System.Windows.Forms.RichTextBox rtb_notes;
    }
}
