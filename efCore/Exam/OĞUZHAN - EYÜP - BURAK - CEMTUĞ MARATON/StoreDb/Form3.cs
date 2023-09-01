using StoreDb.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StoreDb
{
    public partial class Form3 : Form
    {
        StoreDbContext _db;
        public Form3()
        {
            InitializeComponent();
        }

        private string sha256_hash(string sifre) 
        { using (SHA256 hash = SHA256Managed.Create()) 
            { return string.Concat(hash.ComputeHash(Encoding.UTF8.GetBytes(sifre)).Select(l => l.ToString("X2"))); } }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtNewUP.Text.Length < 8)
            {
                MessageBox.Show("Şifreniz en az 8 karakter uzunluğunda olmalıdır.");
                return;
            }

            int uppercaseCount = 0;
            int lowercaseCount = 0;
            int specialCharCount = 0;

            // büyük harf, küçük harf ve özel karakter sayısı kontrolü
            foreach (char c in txtNewUP.Text)
            {
                if (char.IsUpper(c))
                {
                    uppercaseCount++;
                }
                else if (char.IsLower(c))
                {
                    lowercaseCount++;
                }
                else if (c == '!' || c == ';' || c == '+' || c == '*')
                {
                    specialCharCount++;
                }
            }

            if (uppercaseCount < 2 || lowercaseCount < 3 || specialCharCount < 2)
            {
                MessageBox.Show("Şifreniz en az 2 büyük harf, 3 küçük harf ve 2 özel karakter içermelidir.");
                return;
            }

            else
            {
                _db = new StoreDbContext();
                User user = new();
                user.Name = txtNewUN.Text;
                user.Password = sha256_hash(txtNewUP.Text);
                _db.Users.Add(user);
                _db.SaveChanges();
                MessageBox.Show("Başarıyla giriş yaptınız");
                this.Close();
            }

        }
    }
}
