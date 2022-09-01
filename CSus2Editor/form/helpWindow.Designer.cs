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
            this.rtb_helpText = new System.Windows.Forms.RichTextBox();
            this.pnl_UIHelp.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_UIHelp
            // 
            this.pnl_UIHelp.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnl_UIHelp.Controls.Add(this.rtb_helpText);
            this.pnl_UIHelp.Location = new System.Drawing.Point(4, 4);
            this.pnl_UIHelp.Name = "pnl_UIHelp";
            this.pnl_UIHelp.Size = new System.Drawing.Size(394, 413);
            this.pnl_UIHelp.TabIndex = 0;
            // 
            // rtb_helpText
            // 
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
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Csus2 Editor Help";
            this.Load += new System.EventHandler(this.formLoad);
            this.Resize += new System.EventHandler(this.formResize);
            this.pnl_UIHelp.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_UIHelp;
        private System.Windows.Forms.RichTextBox rtb_helpText;
    }
}