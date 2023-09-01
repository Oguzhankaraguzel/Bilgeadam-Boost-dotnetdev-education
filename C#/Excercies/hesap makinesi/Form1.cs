using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace HESAP_MAKINESI
{
    public partial class Form1 : Form
    {
        double sayi1 = 0;
        char islem;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblSonuc.Text = "0";
            lblYazi.Text = "0";
        }

        private void btnNokta_Click(object sender, EventArgs e)
        {
            if (lblYazi.Text.Contains(","))
            {

            }
            else
            {
                lblYazi.Text += ","; 
            }
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            if (lblYazi.Text == "0" && lblYazi.Text != null)
            {
                lblYazi.Text = "0";
            }
            else
            {
                lblYazi.Text = lblYazi.Text + "0";
            };
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            if (lblYazi.Text == "0" && lblYazi.Text != null)
            {
                lblYazi.Text = "1";
            }
            else
            {
                lblYazi.Text = lblYazi.Text + "1";
            }
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            if (lblYazi.Text == "0" && lblYazi.Text != null)
            {
                lblYazi.Text = "2";
            }
            else
            {
                lblYazi.Text = lblYazi.Text + "2";
            };
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            if (lblYazi.Text == "0" && lblYazi.Text != null)
            {
                lblYazi.Text = "3";
            }
            else
            {
                lblYazi.Text = lblYazi.Text + "3";
            }
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            if (lblYazi.Text == "0" && lblYazi.Text != null)
            {
                lblYazi.Text = "4";
            }
            else
            {
                lblYazi.Text = lblYazi.Text + "4";
            };
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            if (lblYazi.Text == "0" && lblYazi.Text != null)
            {
                lblYazi.Text = "5";
            }
            else
            {
                lblYazi.Text = lblYazi.Text + "5";
            }
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            if (lblYazi.Text == "0" && lblYazi.Text != null)
            {
                lblYazi.Text = "6";
            }
            else
            {
                lblYazi.Text = lblYazi.Text + "6";
            }
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            if (lblYazi.Text == "0" && lblYazi.Text != null)
            {
                lblYazi.Text = "7";
            }
            else
            {
                lblYazi.Text = lblYazi.Text + "7";
            }
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            if (lblYazi.Text == "0" && lblYazi.Text != null)
            {
                lblYazi.Text = "8";
            }
            else
            {
                lblYazi.Text = lblYazi.Text + "8";
            }
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            if (lblYazi.Text == "0" && lblYazi.Text != null)
            {
                lblYazi.Text = "9";
            }
            else
            {
                lblYazi.Text = lblYazi.Text + "9";
            }
        }

        private void btnArti_Click(object sender, EventArgs e)
        {
            sayi1 = Convert.ToDouble(lblYazi.Text);
            lblYazi.Text = "0";
            lblSonuc.Text = sayi1.ToString() + " + ";
            islem = '+';
        }
        private void btnEksi_Click(object sender, EventArgs e)
        {
            sayi1 = Convert.ToDouble(lblYazi.Text);
            lblYazi.Text = "0";
            lblSonuc.Text = sayi1.ToString() + " - ";
            islem = '-';
        }

        private void btnCarpma_Click(object sender, EventArgs e)
        {
            sayi1 = Convert.ToDouble(lblYazi.Text);
            lblYazi.Text = "0";
            lblSonuc.Text = sayi1.ToString() + " x ";
            islem = '*';
        }

        private void btnBolme_Click(object sender, EventArgs e)
        {
            sayi1 = Convert.ToDouble(lblYazi.Text);
            lblYazi.Text = "0";
            lblSonuc.Text = sayi1.ToString() + " / ";
            islem = '/';
        }

        private void btnEsittir_Click(object sender, EventArgs e)
        {
            double sayi2;
            double sonuc;
            sayi2 = Convert.ToDouble(lblYazi.Text);
            if (islem == '+')
            {
                sonuc = (sayi1 + sayi2);
                lblSonuc.Text = sonuc.ToString();
            }
            if (islem == '-')
            {
                sonuc = (sayi1 - sayi2);
                lblSonuc.Text = sonuc.ToString();
            }
            if (islem == '*')
            {
                sonuc = (sayi1 * sayi2);
                lblSonuc.Text = sonuc.ToString();
            }
            if (islem == '/')
            {
                if (sayi2 == 0)
                {
                    lblSonuc.Text = "Hicbir sayi sifira bolunemez";
                }
                else
                {
                    sonuc = (sayi1 / sayi2);
                    lblSonuc.Text = sonuc.ToString();
                }
            }
            if (islem == '^')
            {
                sonuc = Math.Pow(sayi1, sayi2);
                lblSonuc.Text = sonuc.ToString();
            }
            if (islem == 'r')
            {
                sonuc = Math.Pow(sayi1, (1 / sayi2));
                lblSonuc.Text = sonuc.ToString();
            }
            if (islem == 'l')
            {
                sonuc = Math.Log(sayi2, sayi1);
                lblSonuc.Text = sonuc.ToString();
            }
            btnArti.Enabled = true;
            btnEksi.Enabled = true;
            btnCarpma.Enabled = true;
            btnBolme.Enabled = true;
            btnLog.Enabled = true;
            btnLn.Enabled = true;
            btnKok.Enabled = true;
            btnKare.Enabled = true;
            btnUssu.Enabled = true;
            lblYazi.Text = "0";
            sayi1 = 0; sayi2 = 0; islem = ' ';
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            lblYazi.Text = "0";
        }

        private void btnCE_Click(object sender, EventArgs e)
        {
            lblYazi.Text = "0";
            lblSonuc.Text = "0";
            sayi1 = 0;
            btnArti.Enabled = true;
            btnEksi.Enabled = true;
            btnCarpma.Enabled = true;
            btnBolme.Enabled = true;
            btnLog.Enabled = true;
            btnLn.Enabled = true;
            btnKok.Enabled = true;
            btnKare.Enabled = true;
            btnUssu.Enabled = true;
        }

        private void btnCevap_Click(object sender, EventArgs e)
        {
            lblYazi.Text = lblSonuc.Text;
            lblSonuc.Text = "0";
        }

        private void btnKare_Click(object sender, EventArgs e)
        {
            lblSonuc.Text = (double.Parse(lblYazi.Text) * double.Parse(lblYazi.Text)).ToString();
            lblYazi.Text = "0";
        }

        private void btnUssu_Click(object sender, EventArgs e)
        {
            sayi1 = Convert.ToDouble(lblYazi.Text);
            lblYazi.Text = "0";
            lblSonuc.Text = sayi1.ToString() + " ^ ";
            islem = '^';
            btnArti.Enabled = false;
            btnEksi.Enabled = false;
            btnCarpma.Enabled = false;
            btnBolme.Enabled = false;
            btnLog.Enabled = false;
            btnLn.Enabled = false;
            btnKok.Enabled = false;
            btnKare.Enabled = false;
            btnUssu.Enabled = false;
        }

        private void btnKok_Click(object sender, EventArgs e)
        {
            sayi1 = Convert.ToDouble(lblYazi.Text);
            lblYazi.Text = "0";
            lblSonuc.Text = sayi1.ToString() + " ^ 1/ ";
            islem = 'r';
            btnArti.Enabled = false;
            btnEksi.Enabled = false;
            btnCarpma.Enabled = false;
            btnBolme.Enabled = false;
            btnLog.Enabled = false;
            btnLn.Enabled = false;
            btnKok.Enabled = false;
            btnKare.Enabled = false;
            btnUssu.Enabled = false;
        }

        private void btnLn_Click(object sender, EventArgs e)
        {
            if (lblYazi.Text == "0")
            {
                lblSonuc.Text = "TANIMSIZ";
            }
            else
            {
                sayi1 = Convert.ToDouble(lblYazi.Text);
                lblSonuc.Text = Math.Log(sayi1).ToString();
                sayi1 = 0;
                lblYazi.Text = "0"; 
            }
        }

        private void btnLog_Click(object sender, EventArgs e)
        {
            sayi1 = Convert.ToDouble(lblYazi.Text);
            if (sayi1 <= 0)
            {
                lblSonuc.Text = "Logaritma tabani 0'den buyuk pozitif bir sayi olmalidir.";
                sayi1 = 0;
                lblYazi.Text = "0";
            }
            else if (sayi1 == 1)
            {
                lblSonuc.Text = "Logaritma tabani 1'e esit olamaz";
                lblYazi.Text = "0";
                sayi1= 0;
            }
            else
            {
                lblSonuc.Text = "log " + sayi1.ToString() + " ( )";
                lblYazi.Text = "0";
                islem = 'l';
                btnArti.Enabled = false;
                btnEksi.Enabled = false;
                btnCarpma.Enabled = false;
                btnBolme.Enabled = false;
                btnLog.Enabled = false;
                btnLn.Enabled = false;
                btnKok.Enabled = false;
                btnKare.Enabled = false;
                btnUssu.Enabled = false;
            }
            
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (lblYazi.Text.Length <= 1)
            {
                lblYazi.Text = "0";
            }
            else
            {
                lblYazi.Text = lblYazi.Text.Remove(lblYazi.Text.Length - 1); 
            }
        }

        
    }
}
