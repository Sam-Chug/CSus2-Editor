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
            this.pnl_UIHelp = new System.Windows.Forms.Panel();
            this.lbl_UIFocusTarget = new System.Windows.Forms.Label();
            this.rtb_helpText = new System.Windows.Forms.RichTextBox();
            this.pnl_UIHelp.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_UIHelp
            // 
            this.pnl_UIHelp.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnl_UIHelp.Controls.Add(this.lbl_UIFocusTarget);
            this.pnl_UIHelp.Controls.Add(this.rtb_helpText);
            this.pnl_UIHelp.Location = new System.Drawing.Point(4, 4);
            this.pnl_UIHelp.Name = "pnl_UIHelp";
            this.pnl_UIHelp.Size = new System.Drawing.Size(394, 413);
            this.pnl_UIHelp.TabIndex = 0;
            // 
            // lbl_UIFocusTarget
            // 
            this.lbl_UIFocusTarget.AutoSize = true;
            this.lbl_UIFocusTarget.Location = new System.Drawing.Point(46, 64);
            this.lbl_UIFocusTarget.Name = "lbl_UIFocusTarget";
            this.lbl_UIFocusTarget.Size = new System.Drawing.Size(0, 13);
            this.lbl_UIFocusTarget.TabIndex = 1;
            // 
            // rtb_helpText
            // 
            this.rtb_helpText.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtb_helpText.Location = new System.Drawing.Point(-2, -2);
            this.rtb_helpText.Name = "rtb_helpText";
            this.rtb_helpText.ReadOnly = true;
            this.rtb_helpText.Size = new System.Drawing.Size(394, 413);
            this.rtb_helpText.TabIndex = 0;
            this.rtb_helpText.Text = "";
            // 
            // helpWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(402, 421);
            this.Controls.Add(this.pnl_UIHelp);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "helpWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Csus2 Editor Help";
            this.Load += new System.EventHandler(this.formLoad);
            this.Resize += new System.EventHandler(this.formResize);
            this.pnl_UIHelp.ResumeLayout(false);
            this.pnl_UIHelp.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_UIHelp;
        private System.Windows.Forms.RichTextBox rtb_helpText;
        private System.Windows.Forms.Label lbl_UIFocusTarget;
    }
}