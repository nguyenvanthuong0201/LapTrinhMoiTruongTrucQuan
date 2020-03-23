namespace Bai_3_DienTich
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtDienTich = new System.Windows.Forms.TextBox();
            this.txtRong = new System.Windows.Forms.TextBox();
            this.txtDai = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnTiepTheo = new System.Windows.Forms.Button();
            this.btnTinh = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtDienTich);
            this.panel1.Controls.Add(this.txtRong);
            this.panel1.Controls.Add(this.txtDai);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(363, 169);
            this.panel1.TabIndex = 0;
            // 
            // txtDienTich
            // 
            this.txtDienTich.Location = new System.Drawing.Point(145, 121);
            this.txtDienTich.Name = "txtDienTich";
            this.txtDienTich.ReadOnly = true;
            this.txtDienTich.Size = new System.Drawing.Size(173, 20);
            this.txtDienTich.TabIndex = 5;
            this.txtDienTich.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtRong
            // 
            this.txtRong.Location = new System.Drawing.Point(145, 79);
            this.txtRong.Name = "txtRong";
            this.txtRong.Size = new System.Drawing.Size(173, 20);
            this.txtRong.TabIndex = 4;
            this.txtRong.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtRong.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtRong_KeyPress);
            // 
            // txtDai
            // 
            this.txtDai.Location = new System.Drawing.Point(145, 40);
            this.txtDai.Name = "txtDai";
            this.txtDai.Size = new System.Drawing.Size(173, 20);
            this.txtDai.TabIndex = 3;
            this.txtDai.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtDai.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDai_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(43, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Diện Tích";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Chiều Rộng";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Chiều dài";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnExit);
            this.panel2.Controls.Add(this.btnTiepTheo);
            this.panel2.Controls.Add(this.btnTinh);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 192);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(363, 76);
            this.panel2.TabIndex = 1;
            // 
            // btnExit
            // 
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Location = new System.Drawing.Point(265, 27);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnTiepTheo
            // 
            this.btnTiepTheo.Location = new System.Drawing.Point(144, 27);
            this.btnTiepTheo.Name = "btnTiepTheo";
            this.btnTiepTheo.Size = new System.Drawing.Size(75, 23);
            this.btnTiepTheo.TabIndex = 1;
            this.btnTiepTheo.Text = "Tiếp theo";
            this.btnTiepTheo.UseVisualStyleBackColor = true;
            this.btnTiepTheo.Click += new System.EventHandler(this.btnTiepTheo_Click);
            // 
            // btnTinh
            // 
            this.btnTinh.Location = new System.Drawing.Point(32, 27);
            this.btnTinh.Name = "btnTinh";
            this.btnTinh.Size = new System.Drawing.Size(75, 23);
            this.btnTinh.TabIndex = 0;
            this.btnTinh.Text = "Tính";
            this.btnTinh.UseVisualStyleBackColor = true;
            this.btnTinh.Click += new System.EventHandler(this.btnTinh_Click);
            // 
            // Form1
            // 
            this.AcceptButton = this.btnTinh;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(363, 268);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtDienTich;
        private System.Windows.Forms.TextBox txtRong;
        private System.Windows.Forms.TextBox txtDai;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnTiepTheo;
        private System.Windows.Forms.Button btnTinh;
    }
}

