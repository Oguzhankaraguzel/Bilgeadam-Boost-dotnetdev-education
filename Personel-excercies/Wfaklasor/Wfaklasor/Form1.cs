using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Wfaklasor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btnKlasorOlustur.Enabled = false;
        }

        private void lnkDosyaYoluSec_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            txtDosyaYolu.Text = SelectFolder();
            btnKlasorOlustur.Enabled = true;
        }

        string SelectFolder()
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            DialogResult dr = fbd.ShowDialog();
            if (dr == DialogResult.OK)
            {
                return fbd.SelectedPath;
            }
            else
            {
                return null;
            }
        }
        void MesajKutusu(string mesaj)
        {
            MessageBox.Show(mesaj, "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnKlasorOlustur_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtKlasorAdi.Text))
            {
                MesajKutusu("Lutfen bir klasor adi giriniz.");
                return;
            }
            Directory.CreateDirectory($"{txtDosyaYolu.Text}/{txtKlasorAdi.Text}");
            MesajKutusu("Klasor Basariyla Olusturuldu");
            txtKlasorAdi.Text = string.Empty;
            txtDosyaYolu.Text = string.Empty;
            btnKlasorOlustur.Enabled = false;
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                string selectedPath = SelectFolder();
                string fileName = Guid.NewGuid().ToString().ToLower();
                FileStream fs = File.Create($"{selectedPath}/{fileName}.txt");
                fs.Close();
                File.WriteAllText($"{selectedPath}/{fileName}.txt", txtYazi.Text);
                MesajKutusu("Yazdirma islemi basariyla yapildi");
            }
            catch (Exception ex)
            {
                MesajKutusu(ex.Message);
            }
            finally
            {
                txtYazi.Text = string.Empty;
            }
        }

        private void lnkKlasorSec_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            lstDosyalar.Items.Clear();
            string selectedPath = SelectFolder();
            string[] files = Directory.GetFiles(selectedPath);
            lstDosyalar.Items.AddRange(files);
        }
    }
}
