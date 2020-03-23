namespace Bai_1
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
            this.components = new System.ComponentModel.Container();
            this.lblPassWord = new System.Windows.Forms.Label();
            this.txtPassWord = new System.Windows.Forms.TextBox();
            this.btnHienThi = new System.Windows.Forms.Button();
            this.lblHienThi = new System.Windows.Forms.Label();
            this.txtHienThi = new System.Windows.Forms.TextBox();
            this.btnTiep = new System.Windows.Forms.Button();
            this.btnDong = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.SuspendLayout();
            // 
            // lblPassWord
            // 
            this.lblPassWord.AutoSize = true;
            this.lblPassWord.Location = new System.Drawing.Point(22, 40);
            this.lblPassWord.Name = "lblPassWord";
            this.lblPassWord.Size = new System.Drawing.Size(82, 13);
            this.lblPassWord.TabIndex = 0;
            this.lblPassWord.Text = "Nhập Password";
            // 
            // txtPassWord
            // 
            this.txtPassWord.Location = new System.Drawing.Point(123, 37);
            this.txtPassWord.Name = "txtPassWord";
            this.txtPassWord.PasswordChar = '*';
            this.txtPassWord.Size = new System.Drawing.Size(239, 20);
            this.txtPassWord.TabIndex = 1;
            // 
            // btnHienThi
            // 
            this.btnHienThi.Location = new System.Drawing.Point(67, 147);
            this.btnHienThi.Name = "btnHienThi";
            this.btnHienThi.Size = new System.Drawing.Size(75, 23);
            this.btnHienThi.TabIndex = 2;
            this.btnHienThi.Text = "Hiển Thị";
            this.btnHienThi.UseVisualStyleBackColor = true;
            this.btnHienThi.Click += new System.EventHandler(this.btnHienThi_Click);
            // 
            // lblHienThi
            // 
            this.lblHienThi.AutoSize = true;
            this.lblHienThi.Location = new System.Drawing.Point(44, 86);
            this.lblHienThi.Name = "lblHienThi";
            this.lblHienThi.Size = new System.Drawing.Size(43, 13);
            this.lblHienThi.TabIndex = 3;
            this.lblHienThi.Text = "Hiển thị";
            // 
            // txtHienThi
            // 
            this.txtHienThi.Location = new System.Drawing.Point(123, 83);
            this.txtHienThi.Name = "txtHienThi";
            this.txtHienThi.ReadOnly = true;
            this.txtHienThi.Size = new System.Drawing.Size(239, 20);
            this.txtHienThi.TabIndex = 4;
            // 
            // btnTiep
            // 
            this.btnTiep.Location = new System.Drawing.Point(191, 147);
            this.btnTiep.Name = "btnTiep";
            this.btnTiep.Size = new System.Drawing.Size(75, 23);
            this.btnTiep.TabIndex = 5;
            this.btnTiep.Text = "Tiếp";
            this.btnTiep.UseVisualStyleBackColor = true;
            this.btnTiep.Click += new System.EventHandler(this.btnTiep_Click);
            // 
            // btnDong
            // 
            this.btnDong.Location = new System.Drawing.Point(318, 147);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(75, 23);
            this.btnDong.TabIndex = 6;
            this.btnDong.Text = "Đóng";
            this.btnDong.UseVisualStyleBackColor = true;
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(455, 219);
            this.Controls.Add(this.btnDong);
            this.Controls.Add(this.btnTiep);
            this.Controls.Add(this.txtHienThi);
            this.Controls.Add(this.lblHienThi);
            this.Controls.Add(this.btnHienThi);
            this.Controls.Add(this.txtPassWord);
            this.Controls.Add(this.lblPassWord);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPassWord;
        private System.Windows.Forms.TextBox txtPassWord;
        private System.Windows.Forms.Button btnHienThi;
        private System.Windows.Forms.Label lblHienThi;
        private System.Windows.Forms.TextBox txtHienThi;
        private System.Windows.Forms.Button btnTiep;
        private System.Windows.Forms.Button btnDong;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
    }
}

