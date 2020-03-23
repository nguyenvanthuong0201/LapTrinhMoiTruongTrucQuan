using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai_2_Event
{
    public partial class SimpleEvent : Form
    {
        public SimpleEvent()
        {
            InitializeComponent();
        }

        private void btnClickMe_Click(object sender, EventArgs e)
        {
            MessageBox.Show("button was clicker.");

        }

        private void SimpleEvent_Load(object sender, EventArgs e)
        {
            MessageBox.Show("form was clicker.");
        }
    }
}
