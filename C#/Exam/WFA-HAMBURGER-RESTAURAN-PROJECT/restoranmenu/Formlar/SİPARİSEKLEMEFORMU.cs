using restoranmenu.Enumlar;
using restoranmenu.Siniflar;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace restoranmenu.Formlar
{
    public partial class SIPARISEKLEMEFORMU : Form
    {

        #region Özellikler
        List<Urun> urunler = new List<Urun>();
        List<EkstraMalzeme> malzemeler = new List<EkstraMalzeme>();

        private static List<decimal> _urunTutar = new List<decimal>();

        public static List<decimal> UrunTutar
        {
            get { return _urunTutar; }
        }

        private static List<decimal> _malzemeTutar = new List<decimal>();

        public static List<decimal> MalemeTutar
        {
            get { return _malzemeTutar; }
        }

        private static List<string> _siparisler = new List<string>();

        public static List<string> Siparisler
        {
            get { return _siparisler; }
        }


        private static decimal _hesap = 0;

        public static decimal Hesap
        {
            get { return _hesap; }
        }

        private static int _satilanUrunAdedi = 0;

        public static decimal SatilanUrunAdedi
        {
            get { return _satilanUrunAdedi; }
        }
        #endregion

        #region AnaGövde

        public SIPARISEKLEMEFORMU()
        {
            InitializeComponent();
            rdbBuyuk.Text = Boylar.BÜYÜK.ToString();
            rdbOrta.Text = Boylar.ORTA.ToString();
            rdbKucuk.Text = Boylar.KÜÇÜK.ToString();
            rdbKucuk.Checked = true;
            nudAdet.Value = 1;
            nudAdet.Minimum = 1;
            pcbUrunResmi.Image = pcbUrunResmi.ErrorImage;
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (cmbUrunListe.SelectedIndex == -1)
            {
                MessageBox.Show("SİPARİŞ EKLEMEK İÇİN LÜTFEN BİR ÜRÜN SEÇİN! EĞER ÜRÜN YOKSA LÜTFEN YENİ BİR ÜRÜN EKLEYİN", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                _hesap += UrunTutarı() + EkstraMalzemeTutarı();
                _urunTutar.Add(UrunTutarı());
                _malzemeTutar.Add(EkstraMalzemeTutarı());

                lblTutar.Text = $"{_hesap} TL";

                rtbSiparisBilgi.Text += FisYazdırma();

                _siparisler.Add(FisYazdırma());

                _satilanUrunAdedi += (int)nudAdet.Value;

                SetDefault();
            }
        }

        private void btnTamamla_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("SİPARİŞİ TAMAMLAMAK ÜZERESİNİZ! EMİN MİSİNİZ? SİPARİŞİ İPTAL ETMEK İTERSENİZ LÜTFEN İPTAL TUŞUNA BASINIZ.", "UYARI", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                Sıfırlama();
                SiparisKontrolEkranı.SiparisYonetimFormuShow();
            }

            else if (dr == DialogResult.No)
            {

            }

            else
            {
                Sıfırlama();
            }
        }

        private void SIPARISEKLEMEFORMU_Activated(object sender, EventArgs e)
        {
            urunler = URUMEKLEMEFORMU.UrunListesi;

            cmbUrunListe.Items.Clear();

            foreach (Urun urun in urunler)
            {
                cmbUrunListe.Items.Add(urun.UrunAdi);
            }

            malzemeler = EkstraMalzemeEklemeFormu.MalzemeList;

            flpMalzeme.Controls.Clear();

            int index = 0;
            foreach (EkstraMalzeme malzeme in malzemeler)
            {
                CheckBox cbx = new CheckBox();
                cbx.Name = $"cbxMazeme{index++}";
                cbx.Text = malzeme.MalzemeAdi;
                flpMalzeme.Controls.Add(cbx);
            }

            SetDefault();
        }

        private void cmbUrunListe_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = cmbUrunListe.SelectedIndex;

            try
            {
                pcbUrunResmi.Image = urunler[index].UrunFotografi;
                if (pcbUrunResmi.Image == null)
                {
                    pcbUrunResmi.Image = pcbUrunResmi.ErrorImage;
                }
            }
            catch (Exception)
            {

            }
        } 
        #endregion

        #region Metotlar
        private string FisYazdırma()
        {
            string fis = $"OOP HAMBURGERCİSİ {DateTime.Now} ; ";

            int index = cmbUrunListe.SelectedIndex;

            if (rdbBuyuk.Checked)
            {
                fis += $"{nudAdet.Value} X {Boylar.BÜYÜK} boy {urunler[index].UrunAdi}";
            }

            else if (rdbOrta.Checked)
            {
                fis += $"{nudAdet.Value} X {Boylar.ORTA} boy {urunler[index].UrunAdi}";
            }

            else
            {
                fis += $"{nudAdet.Value} X {Boylar.KÜÇÜK} boy {urunler[index].UrunAdi}";
            }

            index = 0;

            foreach (CheckBox cbx in flpMalzeme.Controls)
            {
                if (cbx.Checked)
                {
                    fis += $" + {malzemeler[index].MalzemeAdi}";
                }

                index++;
            }

            fis += $"\n Tutar = {UrunTutarı()+ EkstraMalzemeTutarı()} TL\n\n";

            return fis;
        }

        private void Sıfırlama()
        {
            SetDefault();

            _hesap = 0;

            lblTutar.Text = "0 TL";

            rtbSiparisBilgi.Text = string.Empty;
        }

        private decimal EkstraMalzemeTutarı()
        {
            decimal tutar = 0;
            int index = 0;

            foreach (CheckBox cbx in flpMalzeme.Controls)
            {
                if (cbx.Checked)
                {
                    tutar += malzemeler[index].MalzemeFiyati;
                }

                index++;
            }

            return tutar;
        }

        private decimal UrunTutarı()
        {
            decimal tutar = 0;

            int index = cmbUrunListe.SelectedIndex;

            if (rdbBuyuk.Checked)
            {
                tutar = urunler[index].BuyukBoyFiyati * nudAdet.Value;
            }

            else if (rdbOrta.Checked)
            {
                tutar = urunler[index].OrtaBoyFiyati * nudAdet.Value;
            }

            else
            {
                tutar = urunler[index].KucukBoyFiyati * nudAdet.Value;
            }

            return tutar;
        }

        private void SetDefault() 
        {
            cmbUrunListe.SelectedIndex = -1;

            rdbKucuk.Checked = true;

            foreach (CheckBox cbx in flpMalzeme.Controls)
            {
                cbx.Checked = false;
            }

            nudAdet.Value = 1;

            pcbUrunResmi.Image = pcbUrunResmi.ErrorImage;
        }
        #endregion

    }
}
