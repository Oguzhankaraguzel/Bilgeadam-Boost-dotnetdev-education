using System;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Aranankelime
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btnAra.Enabled = false;
            txtAranacakKelime.Enabled = false;
            MessageBox.Show("Birden fazla kelime aramak isterseniz, aralarina ',' koyarak yaziniz", "BILGILENDIRME", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        string Dosyayolu()
        {
            string filename;

            var loadDialog = new OpenFileDialog { Filter = "Text File|*.txt", InitialDirectory = @"C:\Your\Start\Directory\" };

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

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (txtDosyaYolu.Text != null)
            {
                txtDosyaYolu.Text = Dosyayolu();
                TextReader text = new StreamReader(txtDosyaYolu.Text);
                rtbYazdir.Text = text.ReadToEnd();
                text.Close();
                btnAra.Enabled = true;
                txtAranacakKelime.Enabled = true;
            }
            else
            {
                MessageBox.Show("LUTFEN BIR DOSYA SECIN", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            /*
             * Hocam find metodunu kullamak üzere 2 ya da 3 metod deneim.
             * 
             * Ancak hiçbirinde düzgün çalışmadı. Sebebinide bulamadım.
             * 
             * Aşağıdaki kodları youtube videolarından kopya çektim Yine olmadı.
             * 
             * Kodların üzerine yarım saat düşündüm, ufak tefek değişiklikler yaptım Yine olmadı.
             * 
             * Sorunun ne olduğuyla ilgili ödev dosyasının içinde size bir resim yolayacağım.
             * 
             * Yapabildiğim bu hocam daha da ilerisine gidemedim.
             * 
             * sorunu size şu şekilde anlatırsam : 
             * 
             * bırakın .NET aramatı 'e' harfini bile aradım bazılarını bulup bazılarını bulmuyor.
             * 
             * Örnek bir metin yazayım hocam. Varsayalımki program 'e' harflerini siliyor:
             * 
             * BilgAdam ğitim videolarını izlrken anlamakta güçlük çktiğim yerlri başka eğitim vidoları izleyrek kapattım.
             * 
             * Bu sorunu çözemedim.
             */
            if (txtAranacakKelime.Text == null || txtAranacakKelime.Text == "")
            {
                MessageBox.Show("LUTFEN ARANACAK BIR HARF YA DA KELIME GIRINIZ", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                string[] aranacakKelimeler = txtAranacakKelime.Text.Split(',');
                foreach (string kelime in aranacakKelimeler)
                {
                    int baslangicIndexi = 0;
                    while (baslangicIndexi < rtbYazdir.Text.LastIndexOf(kelime))
                    {
                        int kelimeBaslangicIndex = rtbYazdir.Find(kelime, baslangicIndexi, rtbYazdir.Text.Length ,RichTextBoxFinds.None);

                        if (kelimeBaslangicIndex != -1)
                        {
                            rtbYazdir.SelectionStart = kelimeBaslangicIndex;
                            rtbYazdir.SelectionLength = kelime.Length;
                            rtbYazdir.SelectionBackColor = Color.Red;
                        }
                        else
                        {
                            break;
                        }
                        //baslangicIndexi += kelimeBaslangicIndex + kelime.Length;
                        baslangicIndexi += rtbYazdir.Text.IndexOf(kelime, baslangicIndexi, StringComparison.InvariantCultureIgnoreCase) + 1;
                    }
                }
            }
        }4

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            rtbYazdir.SelectionStart = 0;
            rtbYazdir.SelectAll();
            rtbYazdir.SelectionBackColor = Color.White;
        }
    }
}
