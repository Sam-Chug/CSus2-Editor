namespace CSus2Editor.form
{
    partial class loadWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(loadWindow));
            this.tb_sequence = new System.Windows.Forms.TextBox();
            this.lbl_UILoadText = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tb_sequence
            // 
            this.tb_sequence.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_sequence.Location = new System.Drawing.Point(4, 67);
            this.tb_sequence.Name = "tb_sequence";
            this.tb_sequence.Size = new System.Drawing.Size(336, 23);
            this.tb_sequence.TabIndex = 0;
            this.tb_sequence.KeyDown += new System.Windows.Forms.KeyEventHandler(this.pressEnter);
            // 
            // lbl_UILoadText
            // 
            this.lbl_UILoadText.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_UILoadText.Location = new System.Drawing.Point(4, 4);
            this.lbl_UILoadText.Name = "lbl_UILoadText";
            this.lbl_UILoadText.Size = new System.Drawing.Size(336, 60);
            this.lbl_UILoadText.TabIndex = 1;
            this.lbl_UILoadText.Text = "Paste your sequence into the textbox and press the enter key.\r\n\r\nThis program wil" +
    "l only load note sequences that follow the editor\'s output format!";
            // 
            // loadWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 94);
            this.Controls.Add(this.lbl_UILoadText);
            this.Controls.Add(this.tb_sequence);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "loadWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Load Sequence";
            this.Load += new System.EventHandler(this.formLoad);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_sequence;
        private System.Windows.Forms.Label lbl_UILoadText;
    }
}