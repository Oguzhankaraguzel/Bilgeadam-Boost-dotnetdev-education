using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sifreolusturma
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private string[] Sifreler(int sifreSayisi, int sifreUzunlugu)
        {
            string[] sifreler = new string[sifreSayisi];
            Random random = new Random();
            int sayac = 0;
            for (int i = 0; i < sifreSayisi; i++)
            {

                while (sayac < sifreUzunlugu)
                {

                    char c = (char)random.Next(1, 128);

                    /*
                     * Karmasik gozukebilir ancak her || isaretlerinin aralari incelendiginde 4 tane ayri if blogunun birlestirildigi gorulebilir.
                     * 
                     * Iki ayri || isareti arasinda kalan parantezler incelendiginde sartlart gayet anlasilabilir.
                     * 
                     * Ornek olarak Buyuk harf isaretlenmisse ve rastgele olusturulan karakter buyuk harf ise sifreye eklenir.
                     * 
                     */
                    if ((cbxBuyukHarf.Checked && (c >= 'A' && c <= 'Z'))||(cbxKucukHarf.Checked && (c >= 'a' && c <= 'z')) ||(cbxRakam.Checked && (c >= '0' && c <= '9')) ||(cbxOzelKarakter.Checked && ((c >= 33 && c <= 47) || (c >= 58 && c <= 64) || (c >= 91 && c <= 96) || (c >= 123 && c <= 126))))
                    {
                        sifreler[i] += c;
                        sayac++;
                    }

                }
                sayac = 0;
            }
            return sifreler;
        }

        private void btnUret_Click(object sender, EventArgs e)
        {
            if (!cbxBuyukHarf.Checked && !cbxKucukHarf.Checked && !cbxOzelKarakter.Checked && !cbxRakam.Checked)
            {
                MessageBox.Show("Lutfen Sifrenizin Hangi Karakterlerden Olusacagini Seciniz", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (nudSifreSayisi.Value == 0 || nudSifreSayisi.Value == 0)
            {
                MessageBox.Show("Lutfen Sifre Parametrelerini Giriniz", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            else
            {

                string[] sifreler = Sifreler(Convert.ToInt32(nudSifreSayisi.Value), Convert.ToInt32(nudSifreUzunlugu.Value));

                lstSifreler.Items.Clear();//butona 2. kez basildiginda sifirlamak icin

                for (int i = 0; i < Convert.ToInt32(nudSifreSayisi.Value); i++)
                {
                    lstSifreler.Items.Add((i + 1) + "-) " + sifreler[i]);
                }
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            nudSifreSayisi.Maximum = 15;
            nudSifreUzunlugu.Maximum = 20;
            nudSifreSayisi.Value = 0;
            nudSifreUzunlugu.Value = 0;
        }

        private void lstSifreler_MouseClick(object sender, MouseEventArgs e)
        {
            txtSifre.Text = lstSifreler.SelectedItem.ToString().Substring(lstSifreler.SelectedIndex >= 9 ? 5 : 4);
        }
    }
}
