namespace Code_Handler
{
    partial class CodeImport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CodeImport));
            this.btnProcessCodes = new System.Windows.Forms.Button();
            this.camocodesRT = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cccodesRT = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.othercodesRT = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnProcessCodes
            // 
            this.btnProcessCodes.Location = new System.Drawing.Point(391, 350);
            this.btnProcessCodes.Name = "btnProcessCodes";
            this.btnProcessCodes.Size = new System.Drawing.Size(111, 23);
            this.btnProcessCodes.TabIndex = 2;
            this.btnProcessCodes.Text = "Process codes";
            this.btnProcessCodes.UseVisualStyleBackColor = true;
            this.btnProcessCodes.Click += new System.EventHandler(this.btnProcessCodes_Click);
            // 
            // camocodesRT
            // 
            this.camocodesRT.Location = new System.Drawing.Point(12, 28);
            this.camocodesRT.Name = "camocodesRT";
            this.camocodesRT.Size = new System.Drawing.Size(358, 96);
            this.camocodesRT.TabIndex = 3;
            this.camocodesRT.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Paste Your CAMO CODES here:";
            // 
            // cccodesRT
            // 
            this.cccodesRT.Location = new System.Drawing.Point(12, 153);
            this.cccodesRT.Name = "cccodesRT";
            this.cccodesRT.Size = new System.Drawing.Size(358, 96);
            this.cccodesRT.TabIndex = 5;
            this.cccodesRT.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(184, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Paste Your CC Container Codes here:";
            // 
            // othercodesRT
            // 
            this.othercodesRT.Location = new System.Drawing.Point(12, 277);
            this.othercodesRT.Name = "othercodesRT";
            this.othercodesRT.Size = new System.Drawing.Size(358, 96);
            this.othercodesRT.TabIndex = 7;
            this.othercodesRT.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 258);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Paste all other codes here:";
            // 
            // CodeImport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(526, 391);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.othercodesRT);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cccodesRT);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.camocodesRT);
            this.Controls.Add(this.btnProcessCodes);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CodeImport";
            this.Text = "CodeImport";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnProcessCodes;
        private System.Windows.Forms.RichTextBox camocodesRT;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox cccodesRT;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox othercodesRT;
        private System.Windows.Forms.Label label3;
    }
}