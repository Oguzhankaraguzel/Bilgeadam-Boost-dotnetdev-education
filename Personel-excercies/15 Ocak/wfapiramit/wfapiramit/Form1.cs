using System;
using System.Windows.Forms;

namespace wfapiramit
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //satir sayisi
        int a = 0;
        // yazdirilacak sayi
        int k = 0;
        // toplam sayi
        int s = 0;



        private void btnGiris_Click(object sender, EventArgs e)
        {
            a = Convert.ToInt32(txtSayi.Text);
            for (int i = 0; i < a; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    lblUcgen.Text += Convert.ToString(k) + " ";
                    k += 2;
                    s += k;
                }
                lblUcgen.Text += Environment.NewLine;
            }
            lblUcgen.Text += Environment.NewLine;
            lblUcgen.Text += "toplam sayi = " + s;
            if (true)
            {

            }

        }

        private void lblUcgen_Click(object sender, EventArgs e)
        {

        }
    }
}
