using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wfaascii
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        int satirSayisi = 0;
        
        private void btnGiris_Click(object sender, EventArgs e)
        {
            satirSayisi = Convert.ToInt32(txtSatirSayisi.Text);
            int a = 65;
            for (int i= 0; i < satirSayisi; i++)
            {
                for (int j= 0; j <(satirSayisi/2)+1;j++)
                {
                    lblYazdir.Text += Char.ConvertFromUtf32(a);
                    a++;
                }
                for (int k = 0; k <(satirSayisi/2);k++)
                {
                    lblYazdir.Text += Char.ConvertFromUtf32(a);
                    a--;
                }
                lblYazdir.Text += Environment.NewLine;
                
            }
        }
    }
}
