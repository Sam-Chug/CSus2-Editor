
namespace CSus2Editor
{
    partial class mainWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainWindow));
            this.tb_noteSequence = new System.Windows.Forms.RichTextBox();
            this.lbl_UINoteSequence = new System.Windows.Forms.Label();
            this.lbl_UISetSongLength = new System.Windows.Forms.Label();
            this.nud_seqLength = new System.Windows.Forms.NumericUpDown();
            this.btn_generateNew = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.nud_noteInterval = new System.Windows.Forms.NumericUpDown();
            this.btn_seqUpdate = new System.Windows.Forms.Button();
            this.lbl_UIHLine1 = new System.Windows.Forms.Label();
            this.btn_playSong = new System.Windows.Forms.Button();
            this.lbl_UIHLine2 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ms_File = new System.Windows.Forms.ToolStripMenuItem();
            this.file_exit = new System.Windows.Forms.ToolStripMenuItem();
            this.ms_options = new System.Windows.Forms.ToolStripMenuItem();
            this.options_timeSignature = new System.Windows.Forms.ToolStripMenuItem();
            this.ms_Help = new System.Windows.Forms.ToolStripMenuItem();
            this.help_viewHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.help_about = new System.Windows.Forms.ToolStripMenuItem();
            this.lbl_UIAddColumns = new System.Windows.Forms.Label();
            this.nud_addColumns = new System.Windows.Forms.NumericUpDown();
            this.btn_addColumns = new System.Windows.Forms.Button();
            this.lbl_UIVLine1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pnl_buttons = new CSus2Editor.PanelNoScrollOnFocus();
            ((System.ComponentModel.ISupportInitialize)(this.nud_seqLength)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_noteInterval)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_addColumns)).BeginInit();
            this.SuspendLayout();
            // 
            // tb_noteSequence
            // 
            this.tb_noteSequence.Location = new System.Drawing.Point(4, 442);
            this.tb_noteSequence.Name = "tb_noteSequence";
            this.tb_noteSequence.Size = new System.Drawing.Size(466, 25);
            this.tb_noteSequence.TabIndex = 7;
            this.tb_noteSequence.Text = "";
            this.tb_noteSequence.Click += new System.EventHandler(this.copyText);
            // 
            // lbl_UINoteSequence
            // 
            this.lbl_UINoteSequence.AutoSize = true;
            this.lbl_UINoteSequence.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_UINoteSequence.Location = new System.Drawing.Point(4, 424);
            this.lbl_UINoteSequence.Name = "lbl_UINoteSequence";
            this.lbl_UINoteSequence.Size = new System.Drawing.Size(212, 15);
            this.lbl_UINoteSequence.TabIndex = 2;
            this.lbl_UINoteSequence.Text = "Note Sequence - Click to copy to clipboard";
            // 
            // lbl_UISetSongLength
            // 
            this.lbl_UISetSongLength.AutoSize = true;
            this.lbl_UISetSongLength.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_UISetSongLength.Location = new System.Drawing.Point(4, 378);
            this.lbl_UISetSongLength.Name = "lbl_UISetSongLength";
            this.lbl_UISetSongLength.Size = new System.Drawing.Size(89, 15);
            this.lbl_UISetSongLength.TabIndex = 3;
            this.lbl_UISetSongLength.Text = "Set Song Length";
            // 
            // nud_seqLength
            // 
            this.nud_seqLength.Location = new System.Drawing.Point(4, 396);
            this.nud_seqLength.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nud_seqLength.Name = "nud_seqLength";
            this.nud_seqLength.Size = new System.Drawing.Size(89, 20);
            this.nud_seqLength.TabIndex = 1;
            this.nud_seqLength.Value = new decimal(new int[] {
            16,
            0,
            0,
            0});
            this.nud_seqLength.KeyDown += new System.Windows.Forms.KeyEventHandler(this.setLengthEnter);
            // 
            // btn_generateNew
            // 
            this.btn_generateNew.Location = new System.Drawing.Point(95, 377);
            this.btn_generateNew.Name = "btn_generateNew";
            this.btn_generateNew.Size = new System.Drawing.Size(75, 40);
            this.btn_generateNew.TabIndex = 2;
            this.btn_generateNew.Text = "Generate New Sheet";
            this.btn_generateNew.UseVisualStyleBackColor = true;
            this.btn_generateNew.Click += new System.EventHandler(this.clickGenerate);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Location = new System.Drawing.Point(352, 378);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "Interval (30/sec)";
            // 
            // nud_noteInterval
            // 
            this.nud_noteInterval.Location = new System.Drawing.Point(352, 396);
            this.nud_noteInterval.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nud_noteInterval.Name = "nud_noteInterval";
            this.nud_noteInterval.Size = new System.Drawing.Size(87, 20);
            this.nud_noteInterval.TabIndex = 5;
            this.nud_noteInterval.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // btn_seqUpdate
            // 
            this.btn_seqUpdate.Location = new System.Drawing.Point(473, 441);
            this.btn_seqUpdate.Name = "btn_seqUpdate";
            this.btn_seqUpdate.Size = new System.Drawing.Size(80, 27);
            this.btn_seqUpdate.TabIndex = 8;
            this.btn_seqUpdate.Text = "Update";
            this.btn_seqUpdate.UseVisualStyleBackColor = true;
            this.btn_seqUpdate.Click += new System.EventHandler(this.clickUpdate);
            // 
            // lbl_UIHLine1
            // 
            this.lbl_UIHLine1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_UIHLine1.Location = new System.Drawing.Point(-1, 373);
            this.lbl_UIHLine1.Name = "lbl_UIHLine1";
            this.lbl_UIHLine1.Size = new System.Drawing.Size(600, 2);
            this.lbl_UIHLine1.TabIndex = 9;
            this.lbl_UIHLine1.Text = "label2";
            // 
            // btn_playSong
            // 
            this.btn_playSong.Location = new System.Drawing.Point(447, 377);
            this.btn_playSong.Name = "btn_playSong";
            this.btn_playSong.Size = new System.Drawing.Size(106, 40);
            this.btn_playSong.TabIndex = 6;
            this.btn_playSong.Text = "Play Song";
            this.btn_playSong.UseVisualStyleBackColor = true;
            this.btn_playSong.Click += new System.EventHandler(this.clickListen);
            // 
            // lbl_UIHLine2
            // 
            this.lbl_UIHLine2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_UIHLine2.Location = new System.Drawing.Point(-1, 419);
            this.lbl_UIHLine2.Name = "lbl_UIHLine2";
            this.lbl_UIHLine2.Size = new System.Drawing.Size(600, 2);
            this.lbl_UIHLine2.TabIndex = 11;
            this.lbl_UIHLine2.Text = "label2";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.Control;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ms_File,
            this.ms_options,
            this.ms_Help});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.menuStrip1.Size = new System.Drawing.Size(556, 24);
            this.menuStrip1.TabIndex = 12;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ms_File
            // 
            this.ms_File.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.file_exit});
            this.ms_File.Name = "ms_File";
            this.ms_File.Size = new System.Drawing.Size(37, 20);
            this.ms_File.Text = "File";
            // 
            // file_exit
            // 
            this.file_exit.Name = "file_exit";
            this.file_exit.Size = new System.Drawing.Size(93, 22);
            this.file_exit.Text = "Exit";
            this.file_exit.Click += new System.EventHandler(this.clickExit);
            // 
            // ms_options
            // 
            this.ms_options.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.options_timeSignature});
            this.ms_options.Name = "ms_options";
            this.ms_options.Size = new System.Drawing.Size(61, 20);
            this.ms_options.Text = "Options";
            // 
            // options_timeSignature
            // 
            this.options_timeSignature.Name = "options_timeSignature";
            this.options_timeSignature.Size = new System.Drawing.Size(153, 22);
            this.options_timeSignature.Text = "Time Signature";
            this.options_timeSignature.Click += new System.EventHandler(this.clickTimeSignature);
            // 
            // ms_Help
            // 
            this.ms_Help.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.help_viewHelp,
            this.help_about});
            this.ms_Help.Name = "ms_Help";
            this.ms_Help.Size = new System.Drawing.Size(44, 20);
            this.ms_Help.Text = "Help";
            // 
            // help_viewHelp
            // 
            this.help_viewHelp.Name = "help_viewHelp";
            this.help_viewHelp.Size = new System.Drawing.Size(127, 22);
            this.help_viewHelp.Text = "View Help";
            this.help_viewHelp.Click += new System.EventHandler(this.clickViewHelp);
            // 
            // help_about
            // 
            this.help_about.Name = "help_about";
            this.help_about.Size = new System.Drawing.Size(127, 22);
            this.help_about.Text = "About";
            this.help_about.Click += new System.EventHandler(this.clickAbout);
            // 
            // lbl_UIAddColumns
            // 
            this.lbl_UIAddColumns.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_UIAddColumns.Location = new System.Drawing.Point(178, 378);
            this.lbl_UIAddColumns.Name = "lbl_UIAddColumns";
            this.lbl_UIAddColumns.Size = new System.Drawing.Size(89, 15);
            this.lbl_UIAddColumns.TabIndex = 13;
            this.lbl_UIAddColumns.Text = "Add Columns";
            // 
            // nud_addColumns
            // 
            this.nud_addColumns.Location = new System.Drawing.Point(178, 396);
            this.nud_addColumns.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nud_addColumns.Name = "nud_addColumns";
            this.nud_addColumns.Size = new System.Drawing.Size(89, 20);
            this.nud_addColumns.TabIndex = 3;
            this.nud_addColumns.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nud_addColumns.KeyDown += new System.Windows.Forms.KeyEventHandler(this.addColumnsEnter);
            // 
            // btn_addColumns
            // 
            this.btn_addColumns.Location = new System.Drawing.Point(269, 377);
            this.btn_addColumns.Name = "btn_addColumns";
            this.btn_addColumns.Size = new System.Drawing.Size(75, 40);
            this.btn_addColumns.TabIndex = 4;
            this.btn_addColumns.Text = "Add Columns";
            this.btn_addColumns.UseVisualStyleBackColor = true;
            this.btn_addColumns.Click += new System.EventHandler(this.clickAddColumns);
            // 
            // lbl_UIVLine1
            // 
            this.lbl_UIVLine1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_UIVLine1.Location = new System.Drawing.Point(173, 374);
            this.lbl_UIVLine1.Name = "lbl_UIVLine1";
            this.lbl_UIVLine1.Size = new System.Drawing.Size(2, 47);
            this.lbl_UIVLine1.TabIndex = 17;
            this.lbl_UIVLine1.Text = "label2";
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Location = new System.Drawing.Point(347, 374);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(2, 47);
            this.label2.TabIndex = 18;
            this.label2.Text = "label2";
            // 
            // pnl_buttons
            // 
            this.pnl_buttons.BackColor = System.Drawing.Color.White;
            this.pnl_buttons.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnl_buttons.Location = new System.Drawing.Point(4, 27);
            this.pnl_buttons.Name = "pnl_buttons";
            this.pnl_buttons.Size = new System.Drawing.Size(549, 343);
            this.pnl_buttons.TabIndex = 0;
            // 
            // mainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(556, 471);
            this.Controls.Add(this.lbl_UIHLine2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbl_UIVLine1);
            this.Controls.Add(this.pnl_buttons);
            this.Controls.Add(this.btn_addColumns);
            this.Controls.Add(this.nud_addColumns);
            this.Controls.Add(this.lbl_UIAddColumns);
            this.Controls.Add(this.btn_playSong);
            this.Controls.Add(this.lbl_UIHLine1);
            this.Controls.Add(this.btn_seqUpdate);
            this.Controls.Add(this.nud_noteInterval);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_generateNew);
            this.Controls.Add(this.nud_seqLength);
            this.Controls.Add(this.lbl_UISetSongLength);
            this.Controls.Add(this.lbl_UINoteSequence);
            this.Controls.Add(this.tb_noteSequence);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(572, 477);
            this.Name = "mainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Csus2 Music Box Editor";
            this.Load += new System.EventHandler(this.windowLoad);
            this.Resize += new System.EventHandler(this.resizeForm);
            ((System.ComponentModel.ISupportInitialize)(this.nud_seqLength)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_noteInterval)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_addColumns)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbl_UINoteSequence;
        private System.Windows.Forms.Label lbl_UISetSongLength;
        private System.Windows.Forms.NumericUpDown nud_seqLength;
        private System.Windows.Forms.Button btn_generateNew;
        public System.Windows.Forms.RichTextBox tb_noteSequence;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nud_noteInterval;
        private System.Windows.Forms.Button btn_seqUpdate;
        private System.Windows.Forms.Label lbl_UIHLine1;
        private System.Windows.Forms.Button btn_playSong;
        private System.Windows.Forms.Label lbl_UIHLine2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ms_File;
        private System.Windows.Forms.ToolStripMenuItem file_exit;
        private System.Windows.Forms.ToolStripMenuItem ms_Help;
        private System.Windows.Forms.ToolStripMenuItem help_viewHelp;
        private System.Windows.Forms.ToolStripMenuItem help_about;
        private System.Windows.Forms.Label lbl_UIAddColumns;
        private System.Windows.Forms.NumericUpDown nud_addColumns;
        private System.Windows.Forms.Button btn_addColumns;
        private PanelNoScrollOnFocus pnl_buttons;
        private System.Windows.Forms.ToolStripMenuItem ms_options;
        private System.Windows.Forms.ToolStripMenuItem options_timeSignature;
        private System.Windows.Forms.Label lbl_UIVLine1;
        private System.Windows.Forms.Label label2;
    }
}

