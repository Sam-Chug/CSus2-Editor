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
            this.nud_offset = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nud_quarters)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_beats)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_offset)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_UIPickSig
            // 
            this.lbl_UIPickSig.AutoSize = true;
            this.lbl_UIPickSig.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_UIPickSig.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_UIPickSig.Location = new System.Drawing.Point(4, 4);
            this.lbl_UIPickSig.Name = "lbl_UIPickSig";
            this.lbl_UIPickSig.Size = new System.Drawing.Size(119, 17);
            this.lbl_UIPickSig.TabIndex = 0;
            this.lbl_UIPickSig.Text = "Pick a time signature:";
            // 
            // nud_quarters
            // 
            this.nud_quarters.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nud_quarters.Location = new System.Drawing.Point(4, 50);
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
            this.nud_quarters.Size = new System.Drawing.Size(49, 23);
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
            this.nud_beats.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nud_beats.Location = new System.Drawing.Point(4, 24);
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
            this.nud_beats.Size = new System.Drawing.Size(49, 23);
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
            this.lbl_UIBeats.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_UIBeats.Location = new System.Drawing.Point(55, 27);
            this.lbl_UIBeats.Name = "lbl_UIBeats";
            this.lbl_UIBeats.Size = new System.Drawing.Size(35, 15);
            this.lbl_UIBeats.TabIndex = 3;
            this.lbl_UIBeats.Text = "Beats";
            // 
            // lbl_UINotesPerBeat
            // 
            this.lbl_UINotesPerBeat.AutoSize = true;
            this.lbl_UINotesPerBeat.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_UINotesPerBeat.Location = new System.Drawing.Point(55, 53);
            this.lbl_UINotesPerBeat.Name = "lbl_UINotesPerBeat";
            this.lbl_UINotesPerBeat.Size = new System.Drawing.Size(83, 15);
            this.lbl_UINotesPerBeat.TabIndex = 4;
            this.lbl_UINotesPerBeat.Text = "Notes per Beat";
            // 
            // btn_setNewSig
            // 
            this.btn_setNewSig.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_setNewSig.Location = new System.Drawing.Point(150, 24);
            this.btn_setNewSig.Name = "btn_setNewSig";
            this.btn_setNewSig.Size = new System.Drawing.Size(111, 50);
            this.btn_setNewSig.TabIndex = 5;
            this.btn_setNewSig.Text = "Set Time Signature";
            this.btn_setNewSig.UseVisualStyleBackColor = true;
            this.btn_setNewSig.Click += new System.EventHandler(this.clickNewSig);
            // 
            // lbl_newSig
            // 
            this.lbl_newSig.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_newSig.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_newSig.Location = new System.Drawing.Point(151, 4);
            this.lbl_newSig.Name = "lbl_newSig";
            this.lbl_newSig.Size = new System.Drawing.Size(109, 18);
            this.lbl_newSig.TabIndex = 6;
            this.lbl_newSig.Text = "new-sig";
            // 
            // nud_offset
            // 
            this.nud_offset.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nud_offset.Location = new System.Drawing.Point(4, 76);
            this.nud_offset.Maximum = new decimal(new int[] {
            16,
            0,
            0,
            0});
            this.nud_offset.Minimum = new decimal(new int[] {
            16,
            0,
            0,
            -2147483648});
            this.nud_offset.Name = "nud_offset";
            this.nud_offset.Size = new System.Drawing.Size(49, 23);
            this.nud_offset.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(55, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 15);
            this.label1.TabIndex = 8;
            this.label1.Text = "Column Offset";
            // 
            // timesigWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(264, 103);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nud_offset);
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
            ((System.ComponentModel.ISupportInitialize)(this.nud_offset)).EndInit();
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
        private System.Windows.Forms.NumericUpDown nud_offset;
        private System.Windows.Forms.Label label1;
    }
}