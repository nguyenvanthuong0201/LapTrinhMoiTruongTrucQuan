namespace BackColor
{
    partial class Form1
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
            this.pnback = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdBlue = new System.Windows.Forms.RadioButton();
            this.rdGreen = new System.Windows.Forms.RadioButton();
            this.rdRed = new System.Windows.Forms.RadioButton();
            this.pnback.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnback
            // 
            this.pnback.Controls.Add(this.label1);
            this.pnback.Location = new System.Drawing.Point(3, 3);
            this.pnback.Name = "pnback";
            this.pnback.Size = new System.Drawing.Size(278, 41);
            this.pnback.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(118, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdBlue);
            this.groupBox1.Controls.Add(this.rdGreen);
            this.groupBox1.Controls.Add(this.rdRed);
            this.groupBox1.Location = new System.Drawing.Point(38, 72);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // rdBlue
            // 
            this.rdBlue.AutoSize = true;
            this.rdBlue.ForeColor = System.Drawing.Color.Aqua;
            this.rdBlue.Location = new System.Drawing.Point(34, 77);
            this.rdBlue.Name = "rdBlue";
            this.rdBlue.Size = new System.Drawing.Size(46, 17);
            this.rdBlue.TabIndex = 2;
            this.rdBlue.TabStop = true;
            this.rdBlue.Text = "Blue";
            this.rdBlue.UseVisualStyleBackColor = true;
            // 
            // rdGreen
            // 
            this.rdGreen.AutoSize = true;
            this.rdGreen.ForeColor = System.Drawing.Color.Lime;
            this.rdGreen.Location = new System.Drawing.Point(34, 54);
            this.rdGreen.Name = "rdGreen";
            this.rdGreen.Size = new System.Drawing.Size(54, 17);
            this.rdGreen.TabIndex = 1;
            this.rdGreen.TabStop = true;
            this.rdGreen.Text = "Green";
            this.rdGreen.UseVisualStyleBackColor = true;
            // 
            // rdRed
            // 
            this.rdRed.AutoSize = true;
            this.rdRed.Checked = true;
            this.rdRed.ForeColor = System.Drawing.Color.Red;
            this.rdRed.Location = new System.Drawing.Point(34, 32);
            this.rdRed.Name = "rdRed";
            this.rdRed.Size = new System.Drawing.Size(45, 17);
            this.rdRed.TabIndex = 0;
            this.rdRed.TabStop = true;
            this.rdRed.Text = "Red";
            this.rdRed.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 252);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pnback);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.pnback.ResumeLayout(false);
            this.pnback.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnback;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdBlue;
        private System.Windows.Forms.RadioButton rdGreen;
        private System.Windows.Forms.RadioButton rdRed;
        private System.Windows.Forms.Label label1;
    }
}

