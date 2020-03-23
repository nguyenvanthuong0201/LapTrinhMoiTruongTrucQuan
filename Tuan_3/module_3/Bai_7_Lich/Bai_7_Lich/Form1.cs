using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai_7_Lich
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        int intDuonglich;
        string strCan = "";
        string strChi = "";
        private void button1_Click(object sender, EventArgs e)
        {
            if(txtDuongLich.Text=="")
            {
                MessageBox.Show("Bạn chưa nhập số năm");
                txtDuongLich.Focus();
            }
            else
            {
                intDuonglich = Convert.ToInt32(txtDuongLich.Text);
            }
            if(intDuonglich <= 0) 
            {
                MessageBox.Show(" Số năm phải lớn hơn 0");
                txtDuongLich.Focus();
            }
            else
            {
                ///// Tính CAN
                switch (intDuonglich % 10)
                {
                    case 0 :
                        strCan = "Canh ";
                        break;
                    case 1:
                        strCan = "Tân ";
                        break;
                    case 2:
                        strCan = "Nhâm ";
                        break;
                    case 3:
                        strCan = "Quý ";
                        break;
                    case 4:
                        strCan = "Giáp ";
                        break;
                    case 5:
                        strCan = "Ất ";
                        break;
                    case 6:
                        strCan = "Bính ";
                        break;
                    case 7:
                        strCan = "Đinh";
                        break;
                    case 8:
                        strCan = "Mậu ";
                        break;
                    case 9:
                        strCan = "Kỷ ";
                        break;
                }
                ///tính CHI
                switch(intDuonglich%12)
                {
                    case 0:
                        strChi = "Thân";
                        break;
                    case 1:
                        strChi = "Dậu";
                        break;
                    case 2:
                        strChi = "Tuất";
                        break;
                    case 3:
                        strChi = "Hợi";
                        break;
                    case 4:
                        strChi = "Tí";
                        break;
                    case 5:
                        strChi = "Sửu";
                        break;
                    case 6:
                        strChi = "Dần";
                        break;
                    case 7:
                        strChi = "Mẹo";
                        break;
                    case 8:
                        strChi = "Thình";
                        break;
                    case 9:
                        strChi = "Tỵ";
                        break;
                    case 10:
                        strChi = "Ngọ";
                        break;
                    case 11:
                        strChi = "Mùi";
                        break;

                   
                }
            
            }
            txtAmLich.Text = strCan + strChi;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult dl;
            dl = MessageBox.Show("Bạn muốn thoát chương trình ", "warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dl == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtDuongLich.Focus();
        }
    }
}
