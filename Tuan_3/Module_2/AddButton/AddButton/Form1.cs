using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AddButton
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAddButton_Click(object sender, EventArgs e)
        {
            pnButton.Controls.Clear();
            for (int i = 0; i < Int32.Parse(txtNumberControl.Text);i++)
            {
                Button btnRunTime = new Button();
                btnRunTime.BackColor = Color.Red;
                btnRunTime.Location = new System.Drawing.Point(pnButton.Width / 2 - btnRunTime.Width / 2,  i * btnRunTime.Height);
               btnRunTime.Text = "a_" + i;
           //     btnRunTime.Tag = i;
               btnRunTime.Click += btnRuntime_Click;
                pnButton.Controls.Add(btnRunTime);
            }
         }
        private void btnRuntime_Click(object sender, EventArgs e)
        {
            Button btn =(Button) sender;
            lblMessage.Text = "Button " + btn.Text + " was click";
        }
    }
}
