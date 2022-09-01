namespace CSus2Editor
{
    partial class timesigWindow
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(timesigWindow));
            this.lbl_UIPickSig = new System.Windows.Forms.Label();
            this.nud_quarters = new System.Windows.Forms.NumericUpDown();
            this.nud_beats = new System.Windows.Forms.NumericUpDown();
            this.lbl_UIBeats = new System.Windows.Forms.Label();
            this.lbl_UINotesPerBeat = new System.Windows.Forms.Label();
            this.btn_setNewSig = new System.Windows.Forms.Button();
            this.lbl_newSig = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nud_quarters)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_beats)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_UIPickSig
            // 
            this.lbl_UIPickSig.AutoSize = true;
            this.lbl_UIPickSig.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_UIPickSig.Location = new System.Drawing.Point(4, 4);
            this.lbl_UIPickSig.Name = "lbl_UIPickSig";
            this.lbl_UIPickSig.Size = new System.Drawing.Size(110, 15);
            this.lbl_UIPickSig.TabIndex = 0;
            this.lbl_UIPickSig.Text = "Pick a time signature:";
            // 
            // nud_quarters
            // 
            this.nud_quarters.Location = new System.Drawing.Point(4, 47);
            this.nud_quarters.Maximum = new decimal(new int[] {
            16,
            0,
            0,
            0});
            this.nud_quarters.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.nud_quarters.Name = "nud_quarters";
            this.nud_quarters.Size = new System.Drawing.Size(49, 20);
            this.nud_quarters.TabIndex = 1;
            this.nud_quarters.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.nud_quarters.ValueChanged += new System.EventHandler(this.changeNud);
            this.nud_quarters.Click += new System.EventHandler(this.changeNud);
            this.nud_quarters.MouseUp += new System.Windows.Forms.MouseEventHandler(this.changeNud);
            // 
            // nud_beats
            // 
            this.nud_beats.Location = new System.Drawing.Point(4, 23);
            this.nud_beats.Maximum = new decimal(new int[] {
            16,
            0,
            0,
            0});
            this.nud_beats.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.nud_beats.Name = "nud_beats";
            this.nud_beats.Size = new System.Drawing.Size(49, 20);
            this.nud_beats.TabIndex = 2;
            this.nud_beats.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.nud_beats.ValueChanged += new System.EventHandler(this.changeNud);
            this.nud_beats.Click += new System.EventHandler(this.changeNud);
            this.nud_beats.MouseUp += new System.Windows.Forms.MouseEventHandler(this.changeNud);
            // 
            // lbl_UIBeats
            // 
            this.lbl_UIBeats.AutoSize = true;
            this.lbl_UIBeats.Location = new System.Drawing.Point(55, 26);
            this.lbl_UIBeats.Name = "lbl_UIBeats";
            this.lbl_UIBeats.Size = new System.Drawing.Size(34, 13);
            this.lbl_UIBeats.TabIndex = 3;
            this.lbl_UIBeats.Text = "Beats";
            // 
            // lbl_UINotesPerBeat
            // 
            this.lbl_UINotesPerBeat.AutoSize = true;
            this.lbl_UINotesPerBeat.Location = new System.Drawing.Point(55, 50);
            this.lbl_UINotesPerBeat.Name = "lbl_UINotesPerBeat";
            this.lbl_UINotesPerBeat.Size = new System.Drawing.Size(78, 13);
            this.lbl_UINotesPerBeat.TabIndex = 4;
            this.lbl_UINotesPerBeat.Text = "Notes per Beat";
            // 
            // btn_setNewSig
            // 
            this.btn_setNewSig.Location = new System.Drawing.Point(134, 22);
            this.btn_setNewSig.Name = "btn_setNewSig";
            this.btn_setNewSig.Size = new System.Drawing.Size(91, 45);
            this.btn_setNewSig.TabIndex = 5;
            this.btn_setNewSig.Text = "Set Time Signature";
            this.btn_setNewSig.UseVisualStyleBackColor = true;
            this.btn_setNewSig.Click += new System.EventHandler(this.clickNewSig);
            // 
            // lbl_newSig
            // 
            this.lbl_newSig.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_newSig.Location = new System.Drawing.Point(135, 4);
            this.lbl_newSig.Name = "lbl_newSig";
            this.lbl_newSig.Size = new System.Drawing.Size(89, 15);
            this.lbl_newSig.TabIndex = 6;
            this.lbl_newSig.Text = "new-sig";
            // 
            // timesigWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(228, 70);
            this.Controls.Add(this.lbl_newSig);
            this.Controls.Add(this.btn_setNewSig);
            this.Controls.Add(this.lbl_UINotesPerBeat);
            this.Controls.Add(this.lbl_UIBeats);
            this.Controls.Add(this.nud_beats);
            this.Controls.Add(this.nud_quarters);
            this.Controls.Add(this.lbl_UIPickSig);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "timesigWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Time Signature";
            this.Load += new System.EventHandler(this.formLoad);
            ((System.ComponentModel.ISupportInitialize)(this.nud_quarters)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_beats)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_UIPickSig;
        private System.Windows.Forms.NumericUpDown nud_quarters;
        private System.Windows.Forms.NumericUpDown nud_beats;
        private System.Windows.Forms.Label lbl_UIBeats;
        private System.Windows.Forms.Label lbl_UINotesPerBeat;
        private System.Windows.Forms.Button btn_setNewSig;
        private System.Windows.Forms.Label lbl_newSig;
    }
}