using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai_8_Formater2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pic1_Click(object sender, EventArgs e)
        {
            pic1.Visible = false;
            pic2.Visible = true;
        }

        private void pic2_Click(object sender, EventArgs e)
        {
            pic2.Visible = false;
            pic1.Visible = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ToolTip toolTip = new ToolTip();
            toolTip.SetToolTip(pic1, "click me to ON the light");
            ToolTip toolTip1 = new ToolTip();
            toolTip1.SetToolTip(pic2, "click me to OFF the light");
            
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            lblName.Text = txtName.Text;
            lblMessage.Text = txtName.Text + ":  turn on the light";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
