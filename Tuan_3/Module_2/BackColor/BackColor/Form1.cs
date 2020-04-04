using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BackColor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void rd_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rad = (RadioButton)sender;
            pnback.BackColor = rad.ForeColor;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            rdRed.CheckedChanged += rd_CheckedChanged;
            rdGreen.CheckedChanged += rd_CheckedChanged;
            rdBlue.CheckedChanged += rd_CheckedChanged;

        }
    }
}
