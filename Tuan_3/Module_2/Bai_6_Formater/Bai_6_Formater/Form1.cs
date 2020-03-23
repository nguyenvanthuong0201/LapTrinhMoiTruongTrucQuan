using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai_6_Formater
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ToolTip toolTip = new ToolTip();
            toolTip.SetToolTip(picSmall, "Click tao đi nè ");
            ToolTip toolTip2 = new ToolTip();
            toolTip2.SetToolTip(picBig, "không thích thì cũng Click tao đi nè ");
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            picSmall.Visible = false;
            picBig.Visible = true;
        }

        private void picBig_Click(object sender, EventArgs e)
        {
            picBig.Visible = false;
            picSmall.Visible = true;
        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            lblMessage.Text = txtName.Text + " : " + txtMessage.Text;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            lblMessage.Text = "";
            txtMessage.Clear();
            txtName.Clear();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void radRed_CheckedChanged(object sender, EventArgs e)
        {
            lblMessage.ForeColor = Color.Red;
        }

        private void radGreen_CheckedChanged(object sender, EventArgs e)
        {
            lblMessage.ForeColor = Color.Green;
        }

        private void radBlue_CheckedChanged(object sender, EventArgs e)
        {
            lblMessage.ForeColor = Color.Blue;
        }

        private void radBlack_CheckedChanged(object sender, EventArgs e)
        {
            lblMessage.ForeColor = Color.Black;
        }

        private void chkMessage_CheckedChanged(object sender, EventArgs e)
        {
            lblMessage.Visible = chkMessage.Checked;
        }
    }
}
