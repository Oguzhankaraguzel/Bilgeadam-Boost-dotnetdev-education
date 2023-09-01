using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TelefonYonetim.Enum;
using TelefonYonetim.Sınıflar;

namespace TelefonYonetim.Formlar
{
    public partial class TELEFONDUZENLEME : Form
    {
        #region AnaGövde
        public TELEFONDUZENLEME()
        {
            InitializeComponent();
            Render();
            SetDefault();
            FillTheList();
        }


        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            int index = lstTelefonlar.SelectedIndex;
            if (index < -1)
            {
                MessageBox.Show("GÜNCELLEMEK İÇİN LÜTFEN LİSTEDEN BİR TELEFON SEÇİNİZ", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            else
            {
                DialogResult dr = MessageBox.Show("SEÇİLİ TELEFONUn BİLGİLERİNİ GÜNCELLEMEK İSTEDİĞİNİZE EMİN MİSİNİZ?", "UYARI", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if ((dr == DialogResult.Yes) && (DataSecurity()))
                {
                    TelefonListesi.UpdateList(index, txtMarka.Text, txtModel.Text, GetRdbValue(), Convert.ToInt32(txtYil.Text), SesDosyaYolu());
                    MessageBox.Show("TELEFON BİLGİLERİ BAŞARIYLA GÜNCELLENDİ");
                    SetDefault();
                    FillTheList();
                }
                else
                {
                    SetDefault();
                }
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            int index = lstTelefonlar.SelectedIndex;
            if (index < -1)
            {
                MessageBox.Show("SİLMEK İÇİN LÜTFEN LİSTEDEN BİR TELEFON SEÇİNİZ", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                DialogResult dr = MessageBox.Show("SEÇİLİ TELEFONU SİLMEK İSTEDİĞİNİZE EMİN MİSİNİZ?", "UYARI", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    TelefonListesi.RemoveList(index);
                    SetDefault();
                    FillTheList();
                }
                else
                {
                    SetDefault();
                }
            }
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (DataSecurity())
            {
                TelefonListesi.AddList(txtMarka.Text, txtModel.Text, GetRdbValue(), Convert.ToInt32(txtYil.Text), SesDosyaYolu());
                MessageBox.Show("Telefon Başarıyla Eklendi");
                SetDefault();
                FillTheList();
            }
            else
            {
                MessageBox.Show("HATALI BİR İŞLEM YAPTINIZ LÜTFEN TEKRAR DENEYİNİZ", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Error);
                SetDefault();
            }
        }

        private void btnOynat_Click(object sender, EventArgs e)
        {
            try
            {
                int index = lstTelefonlar.SelectedIndex;
                SoundPlayer sp = new SoundPlayer(TelefonListesi.Telefonlar[index].SesDosyasıYolu);
                sp.Play();

            }
            catch (Exception)
            {

            }
        }

        private void lblFotografYolu_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                int index = lstTelefonlar.SelectedIndex;
                pctTelefonFotograf.ImageLocation = FotografDosyaYolu();
                TelefonListesi.Telefonlar[index].Fotograf = pctTelefonFotograf.ImageLocation;
            }
            catch (Exception)
            {
                MessageBox.Show("FOTOĞRAFI EKLEYEBİLMEK İÇİN LÜTFEN LİSTEDEN BİR ÜRÜN SEÇİN. EĞER ÜRÜN YOKSA LÜTFEN EKLEYİN");
            }

        }

        private void lstTelefonlar_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                int index = lstTelefonlar.SelectedIndex;
                pctTelefonFotograf.ImageLocation = TelefonListesi.Telefonlar[index].Fotograf;
                if (pctTelefonFotograf.Image == null)
                {
                    pctTelefonFotograf.Image = pctTelefonFotograf.ErrorImage;
                }
            }
            catch (Exception)
            {

            }
        }

        #endregion

        #region Metodlar
        /// <summary>
        /// Form üzerindeki listeyi Telefon listesini kullanarak doldurur
        /// </summary>
        private void FillTheList()
        {
            lstTelefonlar.Items.Clear();
            foreach (Telefon item in TelefonListesi.Telefonlar)
            {
                lstTelefonlar.Items.Add($"{item.Marka} | {item.Model} | {item.Yil} | {item.Durumu}");
            }
        }


        /// <summary>
        /// From ekranını standardize eder
        /// </summary>
        private void SetDefault()
        {
            txtMarka.Text = "";
            txtModel.Text = "";
            txtYil.Text = "";
            rdbKullanımda.Checked = true;
            lstTelefonlar.SelectedIndex = -1;
            txtMarka.Select();
        }

        /// <summary>
        /// Radiobuttun isimlerini enumları kullanarak yazdırır.
        /// </summary>
        private void Render()
        {
            rdbSatısta.Text = Durum.SATIŞTA.ToString();
            rdbKullanımda.Text = Durum.KULLANIMDA.ToString();
            rdbHurda.Text = Durum.HURDA.ToString();
        }

        /// <summary>
        /// Radiobutton seçimine göre enum'dan değer döndürür
        /// </summary>
        /// <returns></returns>
        private string GetRdbValue()
        {
            if (rdbSatısta.Checked == true)
            {
                return Durum.SATIŞTA.ToString(); ;
            }
            else if (rdbKullanımda.Checked == true)
            {
                return Durum.KULLANIMDA.ToString(); ;
            }
            else
            {
                return Durum.HURDA.ToString(); ;
            }
        }

        /// <summary>
        /// Telefon için girilen bilginin doğruluğunu kontrol eder
        /// </summary>
        private bool DataSecurity()
        {
            bool security = false;
            if ((txtMarka.Text == "") && (txtModel.Text == "") && (txtYil.Text == ""))
            {
                MessageBox.Show("LÜTFEN TELEFON HAKKINDA BİLGİLERİ GİRİNİZ.");
                security = false;
            }
            else if (Convert.ToUInt32(txtYil.Text) > DateTime.Now.Year)
            {
                MessageBox.Show("LÜTFEN TELEFON HAKKINDA BİLGİLERİ KONTROL EDİNİZ.");
                security = false;
            }
            else
            {
                security = true;
            }
            return security;
        }

        /// <summary>
        /// Ses dosyası için dosya yolunu seçtirir
        /// </summary>
        /// <returns></returns>
        public string SesDosyaYolu()
        {
            DialogResult dr = MessageBox.Show("SES DOSYASI EKLEMEK İSTERMİSİNİZ", "HATIRLATMA", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);
            if (dr == DialogResult.Yes)
            {
                string filename;

                var loadDialog = new OpenFileDialog { Filter = "WAV File|*.wav", InitialDirectory = @"C:\Your\Start\Directory\" };

                if (loadDialog.ShowDialog() == DialogResult.OK)
                {
                    filename = loadDialog.FileName;
                    return filename;
                }

                else
                {
                    return "";
                }
            }
            else
            {
                return "";
            }
        }

        public string FotografDosyaYolu()
        {
            DialogResult dr = MessageBox.Show("FOTOĞRAF EKLEMEK İSTERMİSİNİZ", "HATIRLATMA", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);
            if (dr == DialogResult.Yes)
            {
                string filename;

                var loadDialog = new OpenFileDialog { Filter = "JPEG File|*.jpeg", InitialDirectory = @"C:\Your\Start\Directory\" };

                if (loadDialog.ShowDialog() == DialogResult.OK)
                {
                    filename = loadDialog.FileName;
                    return filename;
                }

                else
                {
                    return null;
                }
            }
            else
            {
                return null;
            }
        }

        #endregion

    }
}
