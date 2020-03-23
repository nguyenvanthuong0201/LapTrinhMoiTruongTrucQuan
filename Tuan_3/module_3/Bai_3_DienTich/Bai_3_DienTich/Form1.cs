using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai_3_DienTich
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private int dai, rong,
         dientich;

        private void btnTiepTheo_Click(object sender, EventArgs e)
        {
            txtDai.Clear();
            txtDienTich.Clear();
            txtRong.Clear();
        }

        private void txtDai_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 'a' && e.KeyChar <= 'z') || (e.KeyChar >= 'A' && e.KeyChar <= 'Z')) e.Handled = true;
        }

        private void txtRong_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 'a' && e.KeyChar <= 'z') || (e.KeyChar >= 'A' && e.KeyChar <= 'Z')) e.Handled = true;

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult dl;
            dl = MessageBox.Show("bạn có muốn thoát không ?","warning",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if(dl == DialogResult.Yes)
            { 
                this.Close();
            }
        }

        private void btnTinh_Click(object sender, EventArgs e)
        {
            if(txtDai.Text =="")
            {
                MessageBox.Show(" Nhập chiều dài");
                txtDai.Focus();
            }
            else if(txtRong.Text == "")
            {
                MessageBox.Show("nhập chiều rộng");
                txtRong.Focus();
            }
            else
            {
                dai = Convert.ToInt32(txtDai.Text);
                rong = Convert.ToInt32(txtRong.Text);
            }
            if(dai <=0)
            {
                MessageBox.Show("Chiều dài >= 0");
                txtDai.Focus();
            }
            else if( rong<=0)
            {
                MessageBox.Show("Chiều rộng >=0");
                txtRong.Focus();
            }
            else
            {
                dientich = dai * rong;
                txtDienTich.Text = dientich.ToString();
            }
        }
    }
}
