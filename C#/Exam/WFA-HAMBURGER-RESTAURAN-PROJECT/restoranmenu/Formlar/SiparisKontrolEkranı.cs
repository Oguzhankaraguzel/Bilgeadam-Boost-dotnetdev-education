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
    public partial class SiparisKontrolEkranı : Form
    {
        private static EkstraMalzemeEklemeFormu emef = new EkstraMalzemeEklemeFormu();
        private static URUMEKLEMEFORMU uef = new URUMEKLEMEFORMU();
        private static SIPARISEKLEMEFORMU sef = new SIPARISEKLEMEFORMU();
        private static SIPARISONETIMFORMU syf = new SIPARISONETIMFORMU();

        public static void SiparisYonetimFormuShow() 
        {
            syf.Show();
            syf.Activate();
        }

        public SiparisKontrolEkranı()
        {
            InitializeComponent();
            
            emef.MdiParent= this;
            uef.MdiParent = this;
            sef.MdiParent = this;
            syf.MdiParent = this;
        }

        private void mnsSiparisOlustur_Click(object sender, EventArgs e)
        {
            sef.Show();
            sef.Activate();
        }

        private void mnsSiparisBilgileri_Click(object sender, EventArgs e)
        {
            syf.Show();
            syf.Activate();
        }

        private void mnsUrunEkle_Click(object sender, EventArgs e)
        {
            uef.Show();
            uef.Activate();
        }

        private void mnsMalzemeEkle_Click(object sender, EventArgs e)
        {
            emef.Show();
            emef.Activate();
        }

        private void SiparisKontrolEkranı_Load(object sender, EventArgs e)
        {

        }
    }
}
