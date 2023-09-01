using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PERSONELEKLEME
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            string tamAd = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(txtAd.Text.Trim()) + " " + txtSoyad.Text.Trim().ToUpper();
            string sehir = txtSehir.Text.Trim().ToUpper();
            lstPersonel.Items.Add(tamAd + " - " + sehir);
            txtAd.Text = "";
            txtSoyad.Text = "";
            txtSehir.Text = "";
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (lstPersonel.SelectedIndex == -1)
            {
                MessageBox.Show("Guncellemek icin lunfen bir isim secin!");
            }
            else
            {
                if (MessageBox.Show("\"" + lstPersonel.SelectedItem.ToString() + "\"\nGuncellemek istediginize emin misiniz?", "UYARI", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    string tamAd = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(txtAd.Text.Trim()) + " " + txtSoyad.Text.Trim().ToUpper();
                    string sehir = txtSehir.Text.Trim().ToUpper();
                    int index = lstPersonel.SelectedIndex;
                    lstPersonel.Items.Remove(lstPersonel.SelectedItem);
                    lstPersonel.Items.Insert(index, tamAd + " - " + sehir);
                    txtAd.Text = "";
                    txtSoyad.Text = "";
                    txtSehir.Text = "";
                }
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            try
            {
                if (lstPersonel.SelectedIndex == -1)
                {
                    MessageBox.Show("Silmek icin lunfen bir isim secin!");
                }
                else
                {
                    if (MessageBox.Show("\"" + lstPersonel.SelectedItem.ToString() + "\"\nSilmek istediginize emin misiniz?", "UYARI", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        lstPersonel.Items.Remove(lstPersonel.Items[lstPersonel.SelectedIndex]);
                    }
                }
            }
            catch (Exception)
            {
            }
        }
    }
}
