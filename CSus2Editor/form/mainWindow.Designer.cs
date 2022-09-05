
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
            this.label1 = new System.Windows.Forms.Label();
            this.nud_noteInterval = new System.Windows.Forms.NumericUpDown();
            this.btn_seqUpdate = new System.Windows.Forms.Button();
            this.lbl_UIHLine1 = new System.Windows.Forms.Label();
            this.btn_playSong = new System.Windows.Forms.Button();
            this.lbl_UIHLine2 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ms_File = new System.Windows.Forms.ToolStripMenuItem();
            this.newSequenceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.file_loadSeq = new System.Windows.Forms.ToolStripMenuItem();
            this.file_exit = new System.Windows.Forms.ToolStripMenuItem();
            this.ms_options = new System.Windows.Forms.ToolStripMenuItem();
            this.options_timeSignature = new System.Windows.Forms.ToolStripMenuItem();
            this.options_measureLines = new System.Windows.Forms.ToolStripMenuItem();
            this.options_firstNote = new System.Windows.Forms.ToolStripMenuItem();
            this.options_followPlay = new System.Windows.Forms.ToolStripMenuItem();
            this.options_showCrewmate = new System.Windows.Forms.ToolStripMenuItem();
            this.cm_drawEmpty = new System.Windows.Forms.ToolStripMenuItem();
            this.ms_Help = new System.Windows.Forms.ToolStripMenuItem();
            this.help_viewHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.help_about = new System.Windows.Forms.ToolStripMenuItem();
            this.lbl_UIAddColumns = new System.Windows.Forms.Label();
            this.nud_addColumns = new System.Windows.Forms.NumericUpDown();
            this.btn_addColumns = new System.Windows.Forms.Button();
            this.lbl_UIVLine2 = new System.Windows.Forms.Label();
            this.loopCheckbox = new System.Windows.Forms.CheckBox();
            this.lbl_UIVLine1 = new System.Windows.Forms.Label();
            this.lbl_UIEditAfterColumn = new System.Windows.Forms.Label();
            this.nud_insertColumn = new System.Windows.Forms.NumericUpDown();
            this.pnl_buttons = new CSus2Editor.PanelNoScrollOnFocus();
            ((System.ComponentModel.ISupportInitialize)(this.nud_noteInterval)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_addColumns)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_insertColumn)).BeginInit();
            this.SuspendLayout();
            // 
            // tb_noteSequence
            // 
            this.tb_noteSequence.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_noteSequence.Location = new System.Drawing.Point(4, 449);
            this.tb_noteSequence.Name = "tb_noteSequence";
            this.tb_noteSequence.Size = new System.Drawing.Size(503, 49);
            this.tb_noteSequence.TabIndex = 7;
            this.tb_noteSequence.Text = "";
            this.tb_noteSequence.Click += new System.EventHandler(this.copyText);
            // 
            // lbl_UINoteSequence
            // 
            this.lbl_UINoteSequence.AutoSize = true;
            this.lbl_UINoteSequence.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_UINoteSequence.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_UINoteSequence.Location = new System.Drawing.Point(4, 429);
            this.lbl_UINoteSequence.Name = "lbl_UINoteSequence";
            this.lbl_UINoteSequence.Size = new System.Drawing.Size(227, 17);
            this.lbl_UINoteSequence.TabIndex = 2;
            this.lbl_UINoteSequence.Text = "Note Sequence - Click to copy to clipboard";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(322, 378);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Interval (30/sec)";
            // 
            // nud_noteInterval
            // 
            this.nud_noteInterval.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nud_noteInterval.Location = new System.Drawing.Point(322, 398);
            this.nud_noteInterval.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nud_noteInterval.Name = "nud_noteInterval";
            this.nud_noteInterval.Size = new System.Drawing.Size(99, 23);
            this.nud_noteInterval.TabIndex = 5;
            this.nud_noteInterval.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // btn_seqUpdate
            // 
            this.btn_seqUpdate.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_seqUpdate.Location = new System.Drawing.Point(509, 448);
            this.btn_seqUpdate.Name = "btn_seqUpdate";
            this.btn_seqUpdate.Size = new System.Drawing.Size(72, 50);
            this.btn_seqUpdate.TabIndex = 8;
            this.btn_seqUpdate.Text = "Generate";
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
            this.btn_playSong.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_playSong.Location = new System.Drawing.Point(509, 377);
            this.btn_playSong.Name = "btn_playSong";
            this.btn_playSong.Size = new System.Drawing.Size(72, 45);
            this.btn_playSong.TabIndex = 6;
            this.btn_playSong.Text = "Play Song";
            this.btn_playSong.UseVisualStyleBackColor = true;
            this.btn_playSong.Click += new System.EventHandler(this.clickListen);
            // 
            // lbl_UIHLine2
            // 
            this.lbl_UIHLine2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_UIHLine2.Location = new System.Drawing.Point(-1, 424);
            this.lbl_UIHLine2.Name = "lbl_UIHLine2";
            this.lbl_UIHLine2.Size = new System.Drawing.Size(600, 2);
            this.lbl_UIHLine2.TabIndex = 11;
            this.lbl_UIHLine2.Text = "label2";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.Control;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ms_File,
            this.ms_options,
            this.ms_Help});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 1, 0, 1);
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.menuStrip1.Size = new System.Drawing.Size(584, 24);
            this.menuStrip1.TabIndex = 12;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ms_File
            // 
            this.ms_File.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newSequenceToolStripMenuItem,
            this.file_loadSeq,
            this.file_exit});
            this.ms_File.Name = "ms_File";
            this.ms_File.Size = new System.Drawing.Size(37, 22);
            this.ms_File.Text = "File";
            // 
            // newSequenceToolStripMenuItem
            // 
            this.newSequenceToolStripMenuItem.Name = "newSequenceToolStripMenuItem";
            this.newSequenceToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.newSequenceToolStripMenuItem.Text = "New Sequence";
            this.newSequenceToolStripMenuItem.Click += new System.EventHandler(this.clickNewSequence);
            // 
            // file_loadSeq
            // 
            this.file_loadSeq.Name = "file_loadSeq";
            this.file_loadSeq.Size = new System.Drawing.Size(154, 22);
            this.file_loadSeq.Text = "Load Sequence";
            this.file_loadSeq.Click += new System.EventHandler(this.loadSequence);
            // 
            // file_exit
            // 
            this.file_exit.Name = "file_exit";
            this.file_exit.Size = new System.Drawing.Size(154, 22);
            this.file_exit.Text = "Exit";
            this.file_exit.Click += new System.EventHandler(this.clickExit);
            // 
            // ms_options
            // 
            this.ms_options.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.options_timeSignature,
            this.options_measureLines,
            this.options_firstNote,
            this.options_followPlay,
            this.options_showCrewmate});
            this.ms_options.Name = "ms_options";
            this.ms_options.Size = new System.Drawing.Size(61, 22);
            this.ms_options.Text = "Options";
            // 
            // options_timeSignature
            // 
            this.options_timeSignature.Name = "options_timeSignature";
            this.options_timeSignature.Size = new System.Drawing.Size(181, 22);
            this.options_timeSignature.Text = "Time Signature";
            this.options_timeSignature.Click += new System.EventHandler(this.clickTimeSignature);
            // 
            // options_measureLines
            // 
            this.options_measureLines.Name = "options_measureLines";
            this.options_measureLines.Size = new System.Drawing.Size(181, 22);
            this.options_measureLines.Text = "Show Measure Lines";
            this.options_measureLines.Click += new System.EventHandler(this.clickMeasureLines);
            // 
            // options_firstNote
            // 
            this.options_firstNote.Name = "options_firstNote";
            this.options_firstNote.Size = new System.Drawing.Size(181, 22);
            this.options_firstNote.Text = "Play at First Note";
            this.options_firstNote.Click += new System.EventHandler(this.clickFirstNote);
            // 
            // options_followPlay
            // 
            this.options_followPlay.Name = "options_followPlay";
            this.options_followPlay.Size = new System.Drawing.Size(181, 22);
            this.options_followPlay.Text = "Follow Play Bar";
            this.options_followPlay.Click += new System.EventHandler(this.clickFollowPlay);
            // 
            // options_showCrewmate
            // 
            this.options_showCrewmate.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cm_drawEmpty});
            this.options_showCrewmate.Name = "options_showCrewmate";
            this.options_showCrewmate.Size = new System.Drawing.Size(181, 22);
            this.options_showCrewmate.Text = "Show Crewmate";
            this.options_showCrewmate.Click += new System.EventHandler(this.clickCrewmate);
            // 
            // cm_drawEmpty
            // 
            this.cm_drawEmpty.Name = "cm_drawEmpty";
            this.cm_drawEmpty.Size = new System.Drawing.Size(172, 22);
            this.cm_drawEmpty.Text = "Draw Empty Notes";
            this.cm_drawEmpty.Click += new System.EventHandler(this.clickCMDrawEmpty);
            // 
            // ms_Help
            // 
            this.ms_Help.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.help_viewHelp,
            this.help_about});
            this.ms_Help.Name = "ms_Help";
            this.ms_Help.Size = new System.Drawing.Size(44, 22);
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
            this.lbl_UIAddColumns.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_UIAddColumns.Location = new System.Drawing.Point(4, 378);
            this.lbl_UIAddColumns.Name = "lbl_UIAddColumns";
            this.lbl_UIAddColumns.Size = new System.Drawing.Size(131, 17);
            this.lbl_UIAddColumns.TabIndex = 13;
            this.lbl_UIAddColumns.Text = "Add or Remove Columns";
            // 
            // nud_addColumns
            // 
            this.nud_addColumns.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nud_addColumns.Location = new System.Drawing.Point(4, 398);
            this.nud_addColumns.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nud_addColumns.Name = "nud_addColumns";
            this.nud_addColumns.Size = new System.Drawing.Size(131, 23);
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
            this.btn_addColumns.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_addColumns.Location = new System.Drawing.Point(244, 377);
            this.btn_addColumns.Name = "btn_addColumns";
            this.btn_addColumns.Size = new System.Drawing.Size(72, 45);
            this.btn_addColumns.TabIndex = 4;
            this.btn_addColumns.Text = "Edit Columns";
            this.btn_addColumns.UseVisualStyleBackColor = true;
            this.btn_addColumns.Click += new System.EventHandler(this.clickAddColumns);
            // 
            // lbl_UIVLine2
            // 
            this.lbl_UIVLine2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_UIVLine2.Location = new System.Drawing.Point(318, 374);
            this.lbl_UIVLine2.Name = "lbl_UIVLine2";
            this.lbl_UIVLine2.Size = new System.Drawing.Size(2, 51);
            this.lbl_UIVLine2.TabIndex = 18;
            this.lbl_UIVLine2.Text = "label2";
            // 
            // loopCheckbox
            // 
            this.loopCheckbox.AutoSize = true;
            this.loopCheckbox.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loopCheckbox.Location = new System.Drawing.Point(432, 378);
            this.loopCheckbox.Margin = new System.Windows.Forms.Padding(2);
            this.loopCheckbox.Name = "loopCheckbox";
            this.loopCheckbox.Padding = new System.Windows.Forms.Padding(0, 1, 0, 0);
            this.loopCheckbox.Size = new System.Drawing.Size(50, 20);
            this.loopCheckbox.TabIndex = 19;
            this.loopCheckbox.Text = "Loop";
            this.loopCheckbox.UseVisualStyleBackColor = true;
            // 
            // lbl_UIVLine1
            // 
            this.lbl_UIVLine1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_UIVLine1.Location = new System.Drawing.Point(424, 374);
            this.lbl_UIVLine1.Name = "lbl_UIVLine1";
            this.lbl_UIVLine1.Size = new System.Drawing.Size(2, 51);
            this.lbl_UIVLine1.TabIndex = 20;
            this.lbl_UIVLine1.Text = "label3";
            // 
            // lbl_UIEditAfterColumn
            // 
            this.lbl_UIEditAfterColumn.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_UIEditAfterColumn.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_UIEditAfterColumn.Location = new System.Drawing.Point(138, 378);
            this.lbl_UIEditAfterColumn.Name = "lbl_UIEditAfterColumn";
            this.lbl_UIEditAfterColumn.Size = new System.Drawing.Size(104, 17);
            this.lbl_UIEditAfterColumn.TabIndex = 21;
            this.lbl_UIEditAfterColumn.Text = "Edit After Column:";
            // 
            // nud_insertColumn
            // 
            this.nud_insertColumn.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nud_insertColumn.Location = new System.Drawing.Point(138, 398);
            this.nud_insertColumn.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nud_insertColumn.Name = "nud_insertColumn";
            this.nud_insertColumn.Size = new System.Drawing.Size(104, 23);
            this.nud_insertColumn.TabIndex = 22;
            this.nud_insertColumn.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // pnl_buttons
            // 
            this.pnl_buttons.BackColor = System.Drawing.Color.White;
            this.pnl_buttons.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnl_buttons.Location = new System.Drawing.Point(4, 27);
            this.pnl_buttons.Name = "pnl_buttons";
            this.pnl_buttons.Size = new System.Drawing.Size(577, 343);
            this.pnl_buttons.TabIndex = 0;
            // 
            // mainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 501);
            this.Controls.Add(this.nud_insertColumn);
            this.Controls.Add(this.lbl_UIEditAfterColumn);
            this.Controls.Add(this.lbl_UIHLine2);
            this.Controls.Add(this.lbl_UIVLine1);
            this.Controls.Add(this.loopCheckbox);
            this.Controls.Add(this.lbl_UIVLine2);
            this.Controls.Add(this.pnl_buttons);
            this.Controls.Add(this.btn_addColumns);
            this.Controls.Add(this.nud_addColumns);
            this.Controls.Add(this.lbl_UIAddColumns);
            this.Controls.Add(this.btn_playSong);
            this.Controls.Add(this.lbl_UIHLine1);
            this.Controls.Add(this.btn_seqUpdate);
            this.Controls.Add(this.nud_noteInterval);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_UINoteSequence);
            this.Controls.Add(this.tb_noteSequence);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(600, 540);
            this.Name = "mainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Csus2 Music Box Editor";
            this.Load += new System.EventHandler(this.windowLoad);
            this.Resize += new System.EventHandler(this.resizeForm);
            ((System.ComponentModel.ISupportInitialize)(this.nud_noteInterval)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_addColumns)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_insertColumn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbl_UINoteSequence;
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
        private System.Windows.Forms.Label lbl_UIVLine2;
        private System.Windows.Forms.CheckBox loopCheckbox;
        private System.Windows.Forms.Label lbl_UIVLine1;
        private System.Windows.Forms.ToolStripMenuItem file_loadSeq;
        private System.Windows.Forms.ToolStripMenuItem options_firstNote;
        private System.Windows.Forms.ToolStripMenuItem options_showCrewmate;
        private System.Windows.Forms.ToolStripMenuItem options_measureLines;
        private System.Windows.Forms.ToolStripMenuItem cm_drawEmpty;
        private System.Windows.Forms.ToolStripMenuItem newSequenceToolStripMenuItem;
        private System.Windows.Forms.Label lbl_UIEditAfterColumn;
        private System.Windows.Forms.NumericUpDown nud_insertColumn;
        private System.Windows.Forms.ToolStripMenuItem options_followPlay;
    }
}

