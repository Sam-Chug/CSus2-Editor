namespace CSus2Editor
{
    partial class helpWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(helpWindow));
            this.tc_helpTabs = new System.Windows.Forms.TabControl();
            this.tp_sequencer = new System.Windows.Forms.TabPage();
            this.tp_interface = new System.Windows.Forms.TabPage();
            this.rtb_sequencer = new System.Windows.Forms.RichTextBox();
            this.rtb_interface = new System.Windows.Forms.RichTextBox();
            this.lbl_focus = new System.Windows.Forms.Label();
            this.tp_options = new System.Windows.Forms.TabPage();
            this.tp_tips = new System.Windows.Forms.TabPage();
            this.rtb_options = new System.Windows.Forms.RichTextBox();
            this.rtb_tips = new System.Windows.Forms.RichTextBox();
            this.tc_helpTabs.SuspendLayout();
            this.tp_sequencer.SuspendLayout();
            this.tp_interface.SuspendLayout();
            this.tp_options.SuspendLayout();
            this.tp_tips.SuspendLayout();
            this.SuspendLayout();
            // 
            // tc_helpTabs
            // 
            this.tc_helpTabs.Controls.Add(this.tp_sequencer);
            this.tc_helpTabs.Controls.Add(this.tp_interface);
            this.tc_helpTabs.Controls.Add(this.tp_options);
            this.tc_helpTabs.Controls.Add(this.tp_tips);
            this.tc_helpTabs.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tc_helpTabs.Location = new System.Drawing.Point(4, 4);
            this.tc_helpTabs.Name = "tc_helpTabs";
            this.tc_helpTabs.SelectedIndex = 0;
            this.tc_helpTabs.Size = new System.Drawing.Size(392, 414);
            this.tc_helpTabs.TabIndex = 1;
            this.tc_helpTabs.SelectedIndexChanged += new System.EventHandler(this.changeTab);
            // 
            // tp_sequencer
            // 
            this.tp_sequencer.Controls.Add(this.rtb_sequencer);
            this.tp_sequencer.Location = new System.Drawing.Point(4, 24);
            this.tp_sequencer.Name = "tp_sequencer";
            this.tp_sequencer.Padding = new System.Windows.Forms.Padding(3);
            this.tp_sequencer.Size = new System.Drawing.Size(384, 386);
            this.tp_sequencer.TabIndex = 0;
            this.tp_sequencer.Text = "Sequencer";
            this.tp_sequencer.UseVisualStyleBackColor = true;
            // 
            // tp_interface
            // 
            this.tp_interface.Controls.Add(this.rtb_interface);
            this.tp_interface.Location = new System.Drawing.Point(4, 24);
            this.tp_interface.Name = "tp_interface";
            this.tp_interface.Padding = new System.Windows.Forms.Padding(3);
            this.tp_interface.Size = new System.Drawing.Size(384, 386);
            this.tp_interface.TabIndex = 1;
            this.tp_interface.Text = "Interface";
            this.tp_interface.UseVisualStyleBackColor = true;
            // 
            // rtb_sequencer
            // 
            this.rtb_sequencer.BackColor = System.Drawing.Color.White;
            this.rtb_sequencer.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtb_sequencer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtb_sequencer.Location = new System.Drawing.Point(3, 3);
            this.rtb_sequencer.Name = "rtb_sequencer";
            this.rtb_sequencer.ReadOnly = true;
            this.rtb_sequencer.Size = new System.Drawing.Size(378, 380);
            this.rtb_sequencer.TabIndex = 0;
            this.rtb_sequencer.Text = "";
            // 
            // rtb_interface
            // 
            this.rtb_interface.BackColor = System.Drawing.Color.White;
            this.rtb_interface.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtb_interface.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtb_interface.Location = new System.Drawing.Point(3, 3);
            this.rtb_interface.Name = "rtb_interface";
            this.rtb_interface.ReadOnly = true;
            this.rtb_interface.Size = new System.Drawing.Size(378, 380);
            this.rtb_interface.TabIndex = 1;
            this.rtb_interface.Text = "";
            // 
            // lbl_focus
            // 
            this.lbl_focus.AutoSize = true;
            this.lbl_focus.Location = new System.Drawing.Point(216, -14);
            this.lbl_focus.Name = "lbl_focus";
            this.lbl_focus.Size = new System.Drawing.Size(0, 13);
            this.lbl_focus.TabIndex = 1;
            // 
            // tp_options
            // 
            this.tp_options.Controls.Add(this.rtb_options);
            this.tp_options.Location = new System.Drawing.Point(4, 24);
            this.tp_options.Name = "tp_options";
            this.tp_options.Size = new System.Drawing.Size(384, 386);
            this.tp_options.TabIndex = 2;
            this.tp_options.Text = "Options";
            this.tp_options.UseVisualStyleBackColor = true;
            // 
            // tp_tips
            // 
            this.tp_tips.Controls.Add(this.rtb_tips);
            this.tp_tips.Location = new System.Drawing.Point(4, 24);
            this.tp_tips.Name = "tp_tips";
            this.tp_tips.Size = new System.Drawing.Size(384, 386);
            this.tp_tips.TabIndex = 3;
            this.tp_tips.Text = "Tips";
            this.tp_tips.UseVisualStyleBackColor = true;
            // 
            // rtb_options
            // 
            this.rtb_options.BackColor = System.Drawing.Color.White;
            this.rtb_options.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtb_options.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtb_options.Location = new System.Drawing.Point(0, 0);
            this.rtb_options.Name = "rtb_options";
            this.rtb_options.ReadOnly = true;
            this.rtb_options.Size = new System.Drawing.Size(384, 386);
            this.rtb_options.TabIndex = 2;
            this.rtb_options.Text = "";
            // 
            // rtb_tips
            // 
            this.rtb_tips.BackColor = System.Drawing.Color.White;
            this.rtb_tips.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtb_tips.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtb_tips.Location = new System.Drawing.Point(0, 0);
            this.rtb_tips.Name = "rtb_tips";
            this.rtb_tips.ReadOnly = true;
            this.rtb_tips.Size = new System.Drawing.Size(384, 386);
            this.rtb_tips.TabIndex = 2;
            this.rtb_tips.Text = "";
            // 
            // helpWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(398, 421);
            this.Controls.Add(this.lbl_focus);
            this.Controls.Add(this.tc_helpTabs);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "helpWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Csus2 Editor Help";
            this.Load += new System.EventHandler(this.formLoad);
            this.Resize += new System.EventHandler(this.formResize);
            this.tc_helpTabs.ResumeLayout(false);
            this.tp_sequencer.ResumeLayout(false);
            this.tp_interface.ResumeLayout(false);
            this.tp_options.ResumeLayout(false);
            this.tp_tips.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TabControl tc_helpTabs;
        private System.Windows.Forms.TabPage tp_sequencer;
        private System.Windows.Forms.TabPage tp_interface;
        private System.Windows.Forms.RichTextBox rtb_sequencer;
        private System.Windows.Forms.RichTextBox rtb_interface;
        private System.Windows.Forms.Label lbl_focus;
        private System.Windows.Forms.TabPage tp_options;
        private System.Windows.Forms.RichTextBox rtb_options;
        private System.Windows.Forms.TabPage tp_tips;
        private System.Windows.Forms.RichTextBox rtb_tips;
    }
}