namespace CSus2Editor
{
    partial class NoteButton
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
            this.btn_note = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_note
            // 
            this.btn_note.Location = new System.Drawing.Point(0, 0);
            this.btn_note.Name = "btn_note";
            this.btn_note.Size = new System.Drawing.Size(36, 36);
            this.btn_note.TabIndex = 0;
            this.btn_note.UseVisualStyleBackColor = true;
            this.btn_note.Click += new System.EventHandler(this.onClick);
            // 
            // NoteButton
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.btn_note);
            this.Name = "NoteButton";
            this.Size = new System.Drawing.Size(36, 36);
            this.Load += new System.EventHandler(this.controlLoad);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_note;
    }
}
