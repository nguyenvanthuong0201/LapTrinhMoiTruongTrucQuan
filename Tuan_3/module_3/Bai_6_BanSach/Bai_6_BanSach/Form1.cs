using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai_6_BanSach
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }
        private int soluong, thanhtien;
        private int dongia = 300;

        private void txtSoLuong_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 'a' && e.KeyChar <= 'z') || (e.KeyChar >= 'a' && e.KeyChar <= 'z')) e.Handled = true;
        }

        private void btnTiep_Click(object sender, EventArgs e)
        {
            txtKhachHang.Clear();
            txtSoLuong.Clear();
            txtThanhTien.Clear();
        }

        private void btnKetThuc_Click(object sender, EventArgs e)
        {

        }
        
        private void btnTinh_Click(object sender, EventArgs e)
        {
            if (txtSoLuong.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập số lượng");
                txtSoLuong.Focus();
            }
            else if (txtKhachHang.Text == "")
            {
                MessageBox.Show("bạn chưa nhập đơn giá");
                txtKhachHang.Focus();
            }
            else
            {
                soluong = Convert.ToInt32(txtSoLuong.Text);
            }

            if (soluong <= 0)
            {
                MessageBox.Show("Số lượng phải lớn hơn 0");
                txtSoLuong.Focus();
            }
            else
            {
                ///tính tổng gộp;
                thanhtien = soluong * dongia;
                txtThanhTien.Text = thanhtien.ToString();
            }
        }
    }
}
