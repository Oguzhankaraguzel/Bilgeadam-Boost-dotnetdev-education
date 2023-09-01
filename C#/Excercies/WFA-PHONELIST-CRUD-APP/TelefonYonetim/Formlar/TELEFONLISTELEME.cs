using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TelefonYonetim.Enum;
using TelefonYonetim.Sınıflar;

namespace TelefonYonetim.Formlar
{
    public partial class TELEFONLISTELEME : Form
    {
        #region AnaGövde
        public TELEFONLISTELEME()
        {
            InitializeComponent();
            FillTheComboBox();
            comboBox1.SelectedIndex = -1;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = comboBox1.SelectedIndex;
            try
            {
                lblMarka.Text = TelefonListesi.Telefonlar[index].Marka;
                lblModel.Text = TelefonListesi.Telefonlar[index].Model;
                lblYil.Text = TelefonListesi.Telefonlar[index].Yil.ToString();

                switch (TelefonListesi.Telefonlar[index].Durumu)
                {
                    case "SATIŞTA":
                        lblDurum.Text = "SATIŞTA";
                        lblDurum.BackColor = Color.Green;
                        break;
                    case "KULLANIMDA":
                        lblDurum.Text = "KULLANIMDA";
                        lblDurum.BackColor = Color.Yellow;
                        break;
                    case "HURDA":
                        lblDurum.Text = "HURDA";
                        lblDurum.BackColor = Color.Red;
                        break;
                    default:
                        break;
                }
                
                SoundPlayer sp = new SoundPlayer(TelefonListesi.Telefonlar[index].SesDosyasıYolu);

                sp.Play();

                pctTelefonResmi.ImageLocation = TelefonListesi.Telefonlar[index].Fotograf;
            }
            catch (Exception)
            {

            }
        }
        #endregion

        #region Metodlar
        private void FillTheComboBox()
        {
            comboBox1.Items.Clear();
            foreach (var item in TelefonListesi.Telefonlar)
            {
                comboBox1.Items.Add($"{item.Marka} {item.Model} {item.Yil} ");
            }
        } 
        #endregion
    }
}
