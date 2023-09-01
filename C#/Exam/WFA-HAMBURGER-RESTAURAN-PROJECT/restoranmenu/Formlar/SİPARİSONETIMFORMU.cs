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
    public partial class SIPARISONETIMFORMU : Form
    {
        public SIPARISONETIMFORMU()
        {
            InitializeComponent();
            lblCiro.Text = "0 TL";
            lblEkstraMalzemeGeliri.Text = "0 TL";
            lblSatılanUrunAdedi.Text = "0 TL";
            lblToplamSiparisSayisi.Text = "0 TL";
            rtbSiparislerListesi.Text = "";
        }

        private void SIPARISONETIMFORMU_Activated(object sender, EventArgs e)
        {
            lblCiro.Text = (SIPARISEKLEMEFORMU.UrunTutar.Sum()+ SIPARISEKLEMEFORMU.MalemeTutar.Sum()).ToString() + "TL";
            lblEkstraMalzemeGeliri.Text = SIPARISEKLEMEFORMU.MalemeTutar.Sum().ToString() + "TL";
            lblSatılanUrunAdedi.Text = SIPARISEKLEMEFORMU.SatilanUrunAdedi.ToString();
            lblToplamSiparisSayisi.Text = SIPARISEKLEMEFORMU.UrunTutar.Count().ToString();

            rtbSiparislerListesi.Text = string.Empty;

            foreach (string siparisler in SIPARISEKLEMEFORMU.Siparisler)
            {
                rtbSiparislerListesi.Text += siparisler + "\n\n";
            }
        }

    }
}
