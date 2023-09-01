using StoreDb.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StoreDb
{
    public partial class Form2 : Form
    {
        StoreDbContext _db;
        public Form2()
        {
            InitializeComponent();
            _db = new StoreDbContext();
        }

        private void btnAcsess_Click(object sender, EventArgs e)
        {
            if (_db.Users.Where(x => x.Name == txtUserName.Text && x.Password == sha256_hash(txtUserPassword.Text)) == null)
            {
                MessageBox.Show("HATALI BİR GİRİŞ YAPTINIZ!İSTERSENİZ KATIY OLABİLİR YA DA YENİDEN DENEYEBİLİRSİNİZ.");
            }
            else
            {
                MessageBox.Show("BAŞARILI BİR ŞEKİLDE GİRİŞ YAPTINIZ");
                this.Close();
            }

        }

        private string sha256_hash(string sifre)
        {
            using (SHA256 hash = SHA256Managed.Create())
            { return string.Concat(hash.ComputeHash(Encoding.UTF8.GetBytes(sifre)).Select(l => l.ToString("X2"))); }
        }

        private void CreateUser_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form3 frm = new();
            frm.ShowDialog();
        }
    }
}
