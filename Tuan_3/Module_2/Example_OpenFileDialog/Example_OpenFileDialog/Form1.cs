using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Example_OpenFileDialog
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnOpenFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog openfile = new OpenFileDialog();
            openfile.Filter = "All files (*.*)|*.*|exe files (*.exe)|*.exe"; 
            if(openfile.ShowDialog()==DialogResult.OK)
            {
                picdemo.Image = Image.FromFile(openfile.FileName);
            }
            
         }   
    }
}

