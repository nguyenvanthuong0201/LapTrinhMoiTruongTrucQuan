using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnHienThi_Click(object sender, EventArgs e)
        {
            txtHienThi.Text = txtPassWord.Text;
        }

        private void btnTiep_Click(object sender, EventArgs e)
        {
            txtHienThi.Text = "";
            txtPassWord.Clear();
            txtPassWord.Focus();

        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
