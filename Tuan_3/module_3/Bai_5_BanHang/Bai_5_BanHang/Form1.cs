using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai_5_BanHang
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private int soluong, dongia, thanhtien, tongsl, tongtien, trungbinh,tongthanhtien;
        private int solan = 0;


        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult dl;
            dl = MessageBox.Show("Bạn muốn thoát chương trình ", "warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(dl==DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            txtDonGia.Clear();
            txtSoLuong.Clear();
            txtThanhTien.Clear();
        }

        private void txtDonGia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 'a' && e.KeyChar <= 'z') || (e.KeyChar >= 'a' && e.KeyChar <= 'z')) e.Handled = true;

        }

        private void txtSoLuong_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 'a' && e.KeyChar <= 'z') || (e.KeyChar >= 'a' && e.KeyChar <= 'z')) e.Handled = true;
        }

        private void btnTinh_Click(object sender, EventArgs e)
        {
            if(txtSoLuong.Text=="")
            {
                MessageBox.Show("Bạn chưa nhập số lượng");
                txtSoLuong.Focus();
            }
            else if(txtDonGia.Text =="")
            {
                MessageBox.Show("bạn chưa nhập đơn giá");
                txtDonGia.Focus();
            }
            else
            {
                soluong = Convert.ToInt32(txtSoLuong.Text);
                dongia = Convert.ToInt32(txtDonGia.Text);
            }

            if(soluong <=0)
            {
                MessageBox.Show("Số lượng phải lớn hơn 0");
                txtSoLuong.Focus();
            }
            else if(dongia<=0)
            {
                MessageBox.Show("Đơn giá  phải lớn hơn 0");
                txtDonGia.Focus();
            }
            else
            {
                ///tính tổng gộp;
                thanhtien = soluong * dongia;
                txtThanhTien.Text = thanhtien.ToString();
                tongsl += soluong;
                txtTongSL.Text = tongsl.ToString();
                tongtien += thanhtien;
                txtTongTien.Text = tongtien.ToString();
                ///tính trung bình;
                solan += 1;
                tongthanhtien += thanhtien;
                trungbinh = (tongthanhtien) / solan;
                txtTrungBinh.Text = trungbinh.ToString();
            }
           
          



            
            

        }
    }
}
