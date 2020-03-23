namespace Bai_3_HoTen
{
    partial class frmHoTen
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
            this.lblHo = new System.Windows.Forms.Label();
            this.txtHo = new System.Windows.Forms.TextBox();
            this.btnHo = new System.Windows.Forms.Button();
            this.btnTen = new System.Windows.Forms.Button();
            this.btnHoTen = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.lblTen = new System.Windows.Forms.Label();
            this.txtTen = new System.Windows.Forms.TextBox();
            this.lblHoTen = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblHo
            // 
            this.lblHo.AutoSize = true;
            this.lblHo.Location = new System.Drawing.Point(56, 53);
            this.lblHo.Name = "lblHo";
            this.lblHo.Size = new System.Drawing.Size(24, 13);
            this.lblHo.TabIndex = 0;
            this.lblHo.Text = "Họ ";
            // 
            // txtHo
            // 
            this.txtHo.Location = new System.Drawing.Point(162, 53);
            this.txtHo.Name = "txtHo";
            this.txtHo.Size = new System.Drawing.Size(187, 20);
            this.txtHo.TabIndex = 1;
            // 
            // btnHo
            // 
            this.btnHo.Location = new System.Drawing.Point(59, 160);
            this.btnHo.Name = "btnHo";
            this.btnHo.Size = new System.Drawing.Size(75, 23);
            this.btnHo.TabIndex = 2;
            this.btnHo.Text = "Họ";
            this.btnHo.UseVisualStyleBackColor = true;
            this.btnHo.Click += new System.EventHandler(this.btnHo_Click);
            // 
            // btnTen
            // 
            this.btnTen.Location = new System.Drawing.Point(177, 160);
            this.btnTen.Name = "btnTen";
            this.btnTen.Size = new System.Drawing.Size(75, 23);
            this.btnTen.TabIndex = 3;
            this.btnTen.Text = "Tên";
            this.btnTen.UseVisualStyleBackColor = true;
            this.btnTen.Click += new System.EventHandler(this.btnTen_Click);
            // 
            // btnHoTen
            // 
            this.btnHoTen.Location = new System.Drawing.Point(297, 160);
            this.btnHoTen.Name = "btnHoTen";
            this.btnHoTen.Size = new System.Drawing.Size(75, 23);
            this.btnHoTen.TabIndex = 4;
            this.btnHoTen.Text = "Họ Tên";
            this.btnHoTen.UseVisualStyleBackColor = true;
            this.btnHoTen.Click += new System.EventHandler(this.btnHoTen_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(177, 212);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(75, 23);
            this.btnThoat.TabIndex = 5;
            this.btnThoat.Text = "Thoat";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // lblTen
            // 
            this.lblTen.AutoSize = true;
            this.lblTen.Location = new System.Drawing.Point(56, 99);
            this.lblTen.Name = "lblTen";
            this.lblTen.Size = new System.Drawing.Size(26, 13);
            this.lblTen.TabIndex = 6;
            this.lblTen.Text = "Tên";
            // 
            // txtTen
            // 
            this.txtTen.Location = new System.Drawing.Point(162, 96);
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(187, 20);
            this.txtTen.TabIndex = 7;
            // 
            // lblHoTen
            // 
            this.lblHoTen.AutoSize = true;
            this.lblHoTen.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblHoTen.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHoTen.Location = new System.Drawing.Point(191, 9);
            this.lblHoTen.Name = "lblHoTen";
            this.lblHoTen.Padding = new System.Windows.Forms.Padding(50, 0, 50, 0);
            this.lblHoTen.Size = new System.Drawing.Size(100, 25);
            this.lblHoTen.TabIndex = 8;
            // 
            // frmHoTen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(477, 268);
            this.Controls.Add(this.lblHoTen);
            this.Controls.Add(this.txtTen);
            this.Controls.Add(this.lblTen);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnHoTen);
            this.Controls.Add(this.btnTen);
            this.Controls.Add(this.btnHo);
            this.Controls.Add(this.txtHo);
            this.Controls.Add(this.lblHo);
            this.Name = "frmHoTen";
            this.Text = "Bài tập họ tên";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHo;
        private System.Windows.Forms.TextBox txtHo;
        private System.Windows.Forms.Button btnHo;
        private System.Windows.Forms.Button btnTen;
        private System.Windows.Forms.Button btnHoTen;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Label lblTen;
        private System.Windows.Forms.TextBox txtTen;
        private System.Windows.Forms.Label lblHoTen;
    }
}

