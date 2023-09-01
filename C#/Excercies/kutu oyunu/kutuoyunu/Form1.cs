using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kutuoyunu
{
    public partial class AnaSayfa : Form
    {
        public AnaSayfa()
        {
            InitializeComponent();
        }

        private void AnaSayfa_KeyDown(object sender, KeyEventArgs e)
        {
            Keys key = e.KeyCode;
            switch (key) 
            {
                case Keys.Up:
                case Keys.W:
                    YukariCik();
                    break;
                case Keys.Down:
                case Keys.S: 
                    AsagiIn();
                    break;
                case Keys.Right:
                case Keys.D:
                    SagaGit();
                    break;
                case Keys.Left:
                case Keys.A:
                    SolaGit();
                    break;
            }
            OyunBittiMi();
        }
        int kazanSayac = 0;
        int kaybetSayac = 0;

        private void OyunBittiMi()
        {
            bool kazandiMi = pnlKutu.Bounds.IntersectsWith(lblBitir.Bounds);
            if (kazandiMi) 
            {
                kazanSayac++;
                lblKazan.Text = kazanSayac.ToString();
                DialogResult dr = MessageBox.Show("Tekrar Deneyiniz", "Kazandiniz!", MessageBoxButtons.YesNo);
                if (dr == DialogResult.Yes)
                {
                    pnlKutu.Location = new Point(127, 250);
                }
                else
                {
                    Application.Exit();
                }
            }
            bool kaybettiMi = pnlKutu.Bounds.IntersectsWith(lbl1D.Bounds) || pnlKutu.Bounds.IntersectsWith(lbl2D.Bounds) || pnlKutu.Bounds.IntersectsWith(lbl3D.Bounds) || pnlKutu.Bounds.IntersectsWith(lbl4D.Bounds) || pnlKutu.Bounds.IntersectsWith(lbl5D.Bounds) || pnlKutu.Bounds.IntersectsWith(lbl6D.Bounds) || pnlKutu.Bounds.IntersectsWith(lbl7D.Bounds);
            if (kaybettiMi) 
            {
                kaybetSayac++;
                lblKaybet.Text = kaybetSayac.ToString();
                DialogResult dr = MessageBox.Show("Tekrar Deneyiniz", "Kaybettiniz!", MessageBoxButtons.YesNo);
                if (dr == DialogResult.Yes)
                {
                    pnlKutu.Location = new Point(127, 250);
                }
                else
                {
                    Application.Exit();
                }
            }

        }

        private void SolaGit()
        {
            pnlKutu.Left -= 10;
        }

        private void SagaGit()
        {
            pnlKutu.Left += 10;
        }

        private void AsagiIn()
        {
            pnlKutu.Top += 10;
        }

        private void YukariCik()
        {
            pnlKutu.Top -= 10;
        }
    }
}
