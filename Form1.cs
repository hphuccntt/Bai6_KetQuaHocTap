using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai6_KetQuaHocTap
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void lblKQ_Click(object sender, EventArgs e)
        {
            double hk1 = Convert.ToDouble(txtA.Text);
            double hk2 = Convert.ToDouble(txtB.Text);         
            double dtb = (hk1 + hk2) / 2;


            txtdtb.Text = dtb.ToString();



            if (dtb > 4)
            {
                txtKQ.Text = "Lên Lớp";
            }
            else
            {
                txtKQ.Text = "Ở Lại Lớp";
            }


                if (dtb < 5)
            {
                txtXL.Text = "Yếu";
            }              
            else if (dtb <= 6)
            {
                txtXL.Text = "Trung Bình";
            }               
            else if (dtb <= 8)
            {
                txtXL.Text = "Khá";
            }           
            else
            {
                txtXL.Text = "Giỏi";
            }
        }
    }
}


