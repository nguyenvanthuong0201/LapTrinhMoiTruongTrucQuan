using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai_1_Monney
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

       
        private int intSoLuong;
        private decimal decDonGia, decThanhTien;

        private void txtSoLuong_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 'A' && e.KeyChar <= 'Z') || (e.KeyChar >= 'a' && e.KeyChar <= 'z')) e.Handled = true;
        }

        private void txtDonGia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 'A' && e.KeyChar <= 'Z') || (e.KeyChar >= 'a' && e.KeyChar <= 'z')) e.Handled = true;
        }

        private void btnTiepTheo_Click(object sender, EventArgs e)
        {
            txtTenHang.Clear();
            txtDonGia.Clear();
            txtSoLuong.Clear();
            txtThanhTien.Clear();
        }

        private void btnKetThuc_Click(object sender, EventArgs e)
        {
            DialogResult dl;
            dl = MessageBox.Show("bạn có chắc là muốn thoát không", "WARNING", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(dl==DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            if (txtSoLuong.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập số lượng");
                txtSoLuong.Focus();
            }
            else if (txtDonGia.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập đơn giá");
                txtDonGia.Focus();
            }
            else if(txtTenHang.Text == "")
                    {
                MessageBox.Show("bạn chưa nhập tên hàng");
                txtTenHang.Focus();
            }
            else
            {
                intSoLuong = Convert.ToInt32(txtSoLuong.Text);
                decDonGia = Convert.ToDecimal(txtDonGia.Text);
            }
            /// Kiểm tra dữ liệu có hợp lệ không    
            if(intSoLuong <=0)
            {
                MessageBox.Show("Số lượng phải lớn hơn 0");
                txtSoLuong.Focus();
            }
            else if(decDonGia <=0)
            {
                MessageBox.Show("Đơn giá phải lớn hơn 0");
                txtDonGia.Focus();
            }
            else
            {
                decThanhTien = intSoLuong * decDonGia;
                txtThanhTien.Text = decThanhTien.ToString();
            }
            
            
        
        }
    }
}
