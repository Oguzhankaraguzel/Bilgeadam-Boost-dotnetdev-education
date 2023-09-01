using restoranmenu.Siniflar;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace restoranmenu.Formlar
{
    public partial class EkstraMalzemeEklemeFormu : Form
    {
        /*
         * Ekstra malzeme için gerekli bilgileri kullanıcıdan alır.
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
        private static List<EkstraMalzeme> malzemeList = new List<EkstraMalzeme> 
        {
            new EkstraMalzeme{MalzemeAdi = "KETÇAP", MalzemeFiyati = 2m },
            new EkstraMalzeme{MalzemeAdi = "MAYONEZ", MalzemeFiyati = 2m},
            new EkstraMalzeme{MalzemeAdi = "RANCH", MalzemeFiyati = 4m},
            new EkstraMalzeme{MalzemeAdi = "HARDAL", MalzemeFiyati = 3m},
        };
        public static List<EkstraMalzeme> MalzemeList => malzemeList;
        #endregion

        #region AnaGövde

        public EkstraMalzemeEklemeFormu()
        {
            InitializeComponent();
            listeyiDoldur();
        }

        private void btnMalzemeEkle_Click(object sender, EventArgs e)
        {
            if (DataGuvenlik())
            {
                EkstraMalzeme ekstraMalzeme = new EkstraMalzeme();
                ekstraMalzeme.MalzemeAdi = txtMalzemeAdi.Text.ToUpper();
                ekstraMalzeme.MalzemeFiyati = ParaBilgisiDuzenle();

                malzemeList.Add(ekstraMalzeme);

                listeyiDoldur();
            }

            else
            {
                MessageBox.Show("HATALI GİRİŞ YAPTINIZ! LÜTFEN VERİLERİ DOĞRU BİÇİMDE GİRMEYE ÇALIŞINIZ", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void btnMalzemeGuncelle_Click(object sender, EventArgs e)
        {
            if (lstMalzemeListesi.SelectedIndex == -1)
            {
                MessageBox.Show("Guncellemek icin lutfen bir Ürün secin!");
            }
            else
            {
                if ((MessageBox.Show("\"" + lstMalzemeListesi.SelectedItem.ToString() + "\"\nGuncellemek istediginize emin misiniz?", "UYARI", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning) == DialogResult.Yes) && (DataGuvenlik()))
                {
                    int index = lstMalzemeListesi.SelectedIndex;
                    lstMalzemeListesi.Items.Remove(lstMalzemeListesi.SelectedItem);

                    malzemeList[index].MalzemeAdi = txtMalzemeAdi.Text;
                    malzemeList[index].MalzemeFiyati = ParaBilgisiDuzenle();

                    listeyiDoldur();
                    SetDefault();

                    try
                    {
                        lstMalzemeListesi.GetSelected(index + 1);
                    }
                    catch (Exception)
                    {

                    }
                }

                else
                {
                    MessageBox.Show("HATALI GİRİŞ YAPTINIZ! LÜTFEN VERİLERİ DOĞRU BİÇİMDE GİRMEYE ÇALIŞINIZ", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    SetDefault();
                }
            }
        }

        private void btnMalzemeSil_Click(object sender, EventArgs e)
        {
            if (lstMalzemeListesi.SelectedIndex == -1)
            {
                MessageBox.Show("Silmek icin lunfen bir isim secin!");
            }
            else
            {
                if (MessageBox.Show("\"" + lstMalzemeListesi.SelectedItem.ToString() + "\"\nSilmek istediginize emin misiniz?", "UYARI", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    malzemeList.RemoveRange(lstMalzemeListesi.SelectedIndex, 1);
                    listeyiDoldur();
                    SetDefault();
                }
            }
        }

        private void lstMalzemeListesi_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                int index = lstMalzemeListesi.SelectedIndex;
                txtMalzemeAdi.Text = malzemeList[index].MalzemeAdi;
                txtMalzemeFiyati.Text = malzemeList[index].MalzemeFiyati.ToString();
            }
            catch (Exception)
            {

            }
        } 
        #endregion

        #region Metodlar

        private bool DataGuvenlik()
        {
            bool guvenlik = false;
            decimal rakamGuvenligi;
            if ((txtMalzemeAdi.Text != "") && (txtMalzemeFiyati.Text != ""))
            {
                guvenlik = true;
            }

            try
            {
                rakamGuvenligi = Convert.ToDecimal(txtMalzemeFiyati.Text);
            }
            catch (Exception)
            {
                guvenlik = false;
            }

            return guvenlik;
        }

        private decimal ParaBilgisiDuzenle() 
        {
            decimal para = 0;
            para = Convert.ToDecimal(txtMalzemeFiyati.Text.Replace('.',','));
            return para;
        }

        private void listeyiDoldur()
        {
            lstMalzemeListesi.Items.Clear();
            foreach (EkstraMalzeme ekstraMalzeme in malzemeList)
            {
                lstMalzemeListesi.Items.Add($"{ekstraMalzeme.MalzemeAdi} {ekstraMalzeme.MalzemeFiyati} TL");
            }
        }

        private void SetDefault() 
        {
            txtMalzemeAdi.Text = "";
            txtMalzemeFiyati.Text = "";
        }
        #endregion


    }
}
