using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai_3_CVHinhTron
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private double bankinh,dientich,chuvi;

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult dl;
            dl = MessageBox.Show("Bạn muốn thoát chương trình ?", "warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(dl == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtDientich.Clear();
            txtChuVi.Clear();
            txtBanKinh.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtBanKinh.Text == "")
            {
                MessageBox.Show("bạn chưa nhập bán kính ");
                txtBanKinh.Focus();
            }
            else
            {
                bankinh = Convert.ToDouble(txtBanKinh.Text);
            }
            if(bankinh<=0)
            {
                MessageBox.Show("Bán kính > 0");
                txtBanKinh.Focus();
            }
            else
            {
                chuvi = bankinh * 2 * Math.PI;
                txtChuVi.Text = chuvi.ToString();
                dientich = bankinh * bankinh * Math.PI;
                txtDientich.Text = dientich.ToString();
            }
        }

    }
}
