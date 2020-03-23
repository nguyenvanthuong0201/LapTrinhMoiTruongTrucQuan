using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai_4_PT12
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        double a, b, c,n,n1,n2 ,nghiemkep;

        private void txtC_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 'a' && e.KeyChar <= 'z') || (e.KeyChar >= 'a' && e.KeyChar <= 'z')) e.Handled = true;
        }

        private void txtB_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 'a' && e.KeyChar <= 'z') || (e.KeyChar >= 'a' && e.KeyChar <= 'z')) e.Handled = true;
        }

        private void txtA_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 'a' && e.KeyChar <= 'z') || (e.KeyChar >= 'a' && e.KeyChar <= 'z')) e.Handled = true;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult dl;
            dl = MessageBox.Show("Bạn muốn thoát chương trình ", "warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dl == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnTiep_Click(object sender, EventArgs e)
        {
            txtA.Clear();
            txtB.Clear();
            txtC.Clear();
            txtNghiem1.Clear();
            txtNghiem2.Clear();
        }

        double delta = 0;

        private void btnTinh_Click(object sender, EventArgs e)
        {
            if (txtA.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập A");
                txtA.Focus();
            }
            else if (txtB.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập B");
                txtB.Focus();
            }
            else if (txtC.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập C");
                txtC.Focus();
            }
            else
            {
                a = Convert.ToDouble(txtA.Text);
                b = Convert.ToDouble(txtB.Text);
                c = Convert.ToDouble(txtC.Text);
            }
            if (a == 0)
            {
                if (b != 0)
                {
                    MessageBox.Show("Phương trình có 1 nghiệm");
                    n = (-b / a);
                    txtNghiem1.Text = n.ToString();
                }
                else if (b == 0 && c == 0)
                {
                    MessageBox.Show("Phương trình vô số nghiệm");
                    txtA.Focus();
                }
                else
                {
                    MessageBox.Show("Phương trình vô nghiệm");
                    txtA.Focus();
                }
            }
            else
            {
                delta = Math.Pow(b, 2) - 4 * a * c;
                if (delta < 0)
                {
                    MessageBox.Show("Phương trình vô nghiệm");
                    txtA.Focus();
                }
                else if (delta == 0)
                {
                    MessageBox.Show("Phương trình có 1 nghiệm kép :");
                    nghiemkep = -b / (2 * a);
                    txtNghiem1.Text = nghiemkep.ToString();
                }
                else
                {

                    MessageBox.Show("Phương trình có 2 nghiệm phân biệt");
                    n1 = (-b + Math.Sqrt(delta)) / (2 * a);
                    n2 = (-b - Math.Sqrt(delta)) / (2 * a);
                    txtNghiem1.Text = n1.ToString();
                    txtNghiem2.Text = n2.ToString();
                }
            }
        }
    }
}
