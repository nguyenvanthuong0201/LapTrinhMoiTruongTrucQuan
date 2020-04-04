namespace AddButton
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtNumberControl = new System.Windows.Forms.TextBox();
            this.btnAddButton = new System.Windows.Forms.Button();
            this.pnButton = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblMessage = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Number of control";
            // 
            // txtNumberControl
            // 
            this.txtNumberControl.Location = new System.Drawing.Point(108, 19);
            this.txtNumberControl.Name = "txtNumberControl";
            this.txtNumberControl.Size = new System.Drawing.Size(100, 20);
            this.txtNumberControl.TabIndex = 1;
            // 
            // btnAddButton
            // 
            this.btnAddButton.Location = new System.Drawing.Point(226, 17);
            this.btnAddButton.Name = "btnAddButton";
            this.btnAddButton.Size = new System.Drawing.Size(75, 23);
            this.btnAddButton.TabIndex = 2;
            this.btnAddButton.Text = "Add Button";
            this.btnAddButton.UseVisualStyleBackColor = true;
            this.btnAddButton.Click += new System.EventHandler(this.btnAddButton_Click);
            // 
            // pnButton
            // 
            this.pnButton.AutoScroll = true;
            this.pnButton.Location = new System.Drawing.Point(0, 46);
            this.pnButton.Name = "pnButton";
            this.pnButton.Size = new System.Drawing.Size(322, 187);
            this.pnButton.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lblMessage);
            this.panel2.Location = new System.Drawing.Point(0, 239);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(322, 53);
            this.panel2.TabIndex = 4;
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.Location = new System.Drawing.Point(119, 22);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(0, 13);
            this.lblMessage.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(327, 292);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pnButton);
            this.Controls.Add(this.btnAddButton);
            this.Controls.Add(this.txtNumberControl);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNumberControl;
        private System.Windows.Forms.Button btnAddButton;
        private System.Windows.Forms.Panel pnButton;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblMessage;
    }
}

