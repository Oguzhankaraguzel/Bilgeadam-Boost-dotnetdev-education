using restoranmenu.Siniflar;
using System;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace restoranmenu
{
    public partial class URUMEKLEMEFORMU : Form
    {
        /*
         * Ürün için gerekli bilgileri kullanıcıdan alır.
         * Bilgilerin doğru girilip girilmediği kontrol edilir.
         * Eğer bilgiler doğru girilmişse bilgiler üst katmana yollanmak üzere listeye eklenir.
         * 
         * listeden eleman çıkartılabilir
         * Çıkarılma konusunda kullanıcının emin olup olmadığı kontrol edilir.
         * 
         * Listedeki elemanlar güncellenebilir.
         * Aynı şekilde verilerin doğruluğu kontrol edilir.
         * Kullanıcının emin olup olmadığı sorulur.
         * Kullanıcı emin ise bilgiler güncellenir.
         * listedeki elemanlarda güncellenir.
         */
        #region Özellikler

        private static List<Urun> urunlistesi = new List<Urun>
        {
            new Urun{UrunAdi = "STAKEHOUSE BURGER", BuyukBoyFiyati = 52m, OrtaBoyFiyati = 50m, KucukBoyFiyati = 47.75m},
            new Urun{UrunAdi = "WHOOPER BURGER", BuyukBoyFiyati = 45m, OrtaBoyFiyati = 41.75m, KucukBoyFiyati = 39.75m},
            new Urun{UrunAdi = "KÖFTE BURGER", BuyukBoyFiyati = 35m, OrtaBoyFiyati = 31.75m, KucukBoyFiyati = 29.75m},
            new Urun{UrunAdi = "TAVUK BURGER", BuyukBoyFiyati = 25m, OrtaBoyFiyati = 21.50m, KucukBoyFiyati = 20m}
        };
        public static List<Urun> UrunListesi => urunlistesi;//intelisense yaptı
        #endregion

        #region AnaGövde

        public URUMEKLEMEFORMU()
        {
            InitializeComponent();
            listeyiDoldur();
        }

        private void btnUrunEkle_Click(object sender, EventArgs e)
        {

            if (DataGuvenlik())
            {
                Urun urun = new Urun();
                urun.UrunAdi = txtUrunAdi.Text.ToUpper();
                urun.BuyukBoyFiyati = ParaBilgisiDuzenle(txtBuyukBoyFiyat.Text);
                urun.OrtaBoyFiyati = ParaBilgisiDuzenle(txtOrtaBoyFiyat.Text);
                urun.KucukBoyFiyati = ParaBilgisiDuzenle(txtKucukBoyFiyat.Text);
                urun.UrunFotografi = pictureBox1.Image;

                urunlistesi.Add(urun);

                listeyiDoldur();
                SetDefault();
            }

            else
            {
                MessageBox.Show("HATALI GİRİŞ YAPTINIZ! LÜTFEN VERİLERİ DOĞRU BİÇİMDE GİRMEYE ÇALIŞINIZ", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnUrunSil_Click(object sender, EventArgs e)
        {
            if (lsbUrunListe.SelectedIndex == -1)
            {
                MessageBox.Show("Silmek icin lunfen bir isim secin!");
            }
            else
            {
                if (MessageBox.Show("\"" + lsbUrunListe.SelectedItem.ToString() + "\"\nSilmek istediginize emin misiniz?", "UYARI", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    urunlistesi.RemoveRange(lsbUrunListe.SelectedIndex, 1);
                    listeyiDoldur();
                    SetDefault();
                }
            }

        }


        private void btnUrunGuncelle_Click(object sender, EventArgs e)
        {
            if (lsbUrunListe.SelectedIndex == -1)
            {
                MessageBox.Show("Guncellemek icin lutfen bir Ürün secin!");
            }
            else
            {
                if (MessageBox.Show("\"" + lsbUrunListe.SelectedItem.ToString() + "\"\nGuncellemek istediginize emin misiniz?", "UYARI", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    if (DataGuvenlik())
                    {
                        int index = lsbUrunListe.SelectedIndex;
                        lsbUrunListe.Items.Remove(lsbUrunListe.SelectedItem);


                        urunlistesi[index].UrunAdi = txtUrunAdi.Text;
                        urunlistesi[index].BuyukBoyFiyati = ParaBilgisiDuzenle(txtBuyukBoyFiyat.Text);
                        urunlistesi[index].OrtaBoyFiyati = ParaBilgisiDuzenle(txtOrtaBoyFiyat.Text);
                        urunlistesi[index].KucukBoyFiyati = ParaBilgisiDuzenle(txtKucukBoyFiyat.Text);
                        urunlistesi[index].UrunFotografi = pictureBox1.Image;

                        listeyiDoldur();

                        try
                        {
                            lsbUrunListe.GetSelected(index + 1);
                        }
                        catch (Exception)
                        {

                        }
                        SetDefault();
                    }

                    else
                    {
                        MessageBox.Show("HATALI GİRİŞ YAPTINIZ! LÜTFEN VERİLERİ DOĞRU BİÇİMDE GİRMEYE ÇALIŞINIZ", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FotografGoruntule();
        }

        private void lsbUrunListe_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                int index = lsbUrunListe.SelectedIndex;
                txtUrunAdi.Text = urunlistesi[index].UrunAdi;
                txtBuyukBoyFiyat.Text = urunlistesi[index].BuyukBoyFiyati.ToString();
                txtOrtaBoyFiyat.Text = urunlistesi[index].OrtaBoyFiyati.ToString();
                txtKucukBoyFiyat.Text = urunlistesi[index].KucukBoyFiyati.ToString();
                pictureBox1.Image = urunlistesi[index].UrunFotografi;
            }
            catch (Exception)
            {

            }
        } 
        #endregion

        #region Metodlar

        public void FotografGoruntule()
        {
            string adres = Dosyayolu();
            pictureBox1.ImageLocation = adres;
        }

        public string Dosyayolu()
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

        private bool DataGuvenlik()
        {
            bool guvenlik = false;
            decimal rakamGuvenligi;
            if ((txtUrunAdi.Text != "") && (txtBuyukBoyFiyat.Text != "") && (txtOrtaBoyFiyat.Text != "") && (txtKucukBoyFiyat.Text != ""))
            {
                guvenlik = true;
            }

            try
            {
                rakamGuvenligi = Convert.ToDecimal(txtBuyukBoyFiyat.Text);
                rakamGuvenligi = Convert.ToDecimal(txtOrtaBoyFiyat.Text);
                rakamGuvenligi = Convert.ToDecimal(txtKucukBoyFiyat.Text);
            }
            catch (Exception)
            {
                guvenlik = false;
            }

            return guvenlik;
        }

        private decimal ParaBilgisiDuzenle(string paraBilgisi)
        {
            decimal para = 0;
            para = Convert.ToDecimal(paraBilgisi.Replace('.', ','));
            return para;
        }

        private void SetDefault() 
        {
            txtUrunAdi.Text = string.Empty;
            txtBuyukBoyFiyat.Text = string.Empty;
            txtOrtaBoyFiyat.Text = string.Empty;
            txtKucukBoyFiyat.Text = string.Empty;
            pictureBox1.Image = null;
        }

        private void listeyiDoldur() 
        {
            lsbUrunListe.Items.Clear();
            foreach (Urun urun in urunlistesi)
            {
                lsbUrunListe.Items.Add($"ÜRÜN ADI : {urun.UrunAdi} ; KÜÇÜK BOY FİYATI : {urun.KucukBoyFiyati} TL ; ORTA BOY FİYATI : {urun.OrtaBoyFiyati} TL ; BÜYÜK BOY FİYATI : {urun.BuyukBoyFiyati} TL"); 
            }
        }
        #endregion


    }
}
