namespace MyConstruction
{
    partial class setting
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
            this.box = new System.Windows.Forms.GroupBox();
            this.rdoPDFBox = new System.Windows.Forms.RadioButton();
            this.rdoItext = new System.Windows.Forms.RadioButton();
            this.box.SuspendLayout();
            this.SuspendLayout();
            // 
            // box
            // 
            this.box.Controls.Add(this.rdoItext);
            this.box.Controls.Add(this.rdoPDFBox);
            this.box.Location = new System.Drawing.Point(175, 134);
            this.box.Name = "box";
            this.box.Size = new System.Drawing.Size(172, 125);
            this.box.TabIndex = 0;
            this.box.TabStop = false;
            this.box.Text = "PDF Library";
            // 
            // rdoPDFBox
            // 
            this.rdoPDFBox.AutoSize = true;
            this.rdoPDFBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.rdoPDFBox.Location = new System.Drawing.Point(3, 15);
            this.rdoPDFBox.Margin = new System.Windows.Forms.Padding(5);
            this.rdoPDFBox.Name = "rdoPDFBox";
            this.rdoPDFBox.Padding = new System.Windows.Forms.Padding(5);
            this.rdoPDFBox.Size = new System.Drawing.Size(166, 26);
            this.rdoPDFBox.TabIndex = 0;
            this.rdoPDFBox.TabStop = true;
            this.rdoPDFBox.Text = "PDF box";
            this.rdoPDFBox.UseVisualStyleBackColor = true;
            this.rdoPDFBox.CheckedChanged += new System.EventHandler(this.rdoPDFBox_CheckedChanged);
            // 
            // rdoItext
            // 
            this.rdoItext.AutoSize = true;
            this.rdoItext.Dock = System.Windows.Forms.DockStyle.Top;
            this.rdoItext.Location = new System.Drawing.Point(3, 41);
            this.rdoItext.Margin = new System.Windows.Forms.Padding(5);
            this.rdoItext.Name = "rdoItext";
            this.rdoItext.Padding = new System.Windows.Forms.Padding(5);
            this.rdoItext.Size = new System.Drawing.Size(166, 26);
            this.rdoItext.TabIndex = 1;
            this.rdoItext.TabStop = true;
            this.rdoItext.Text = "ITextSharp";
            this.rdoItext.UseVisualStyleBackColor = true;
            this.rdoItext.CheckedChanged += new System.EventHandler(this.rdoItext_CheckedChanged);
            // 
            // setting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(680, 468);
            this.Controls.Add(this.box);
            this.Name = "setting";
            this.Text = "setting";
            this.box.ResumeLayout(false);
            this.box.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox box;
        private System.Windows.Forms.RadioButton rdoItext;
        private System.Windows.Forms.RadioButton rdoPDFBox;
    }
}