using KisiRehberiDB.Models;
using Microsoft.IdentityModel.Tokens;
using System.Text.RegularExpressions;

namespace KisiRehberiDB
{
    public partial class Form1 : Form
    {
        KisiRehberiDbContext _db;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            _db = new KisiRehberiDbContext();
            dgvRehber.DataSource = _db.Contacts.ToList();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (long.TryParse(txtTelNo.Text, out long result))
            {
                try
                {
                    Contact person = new Contact();
                    person.FirstName = txtAd.Text.Trim();
                    person.LastName = txtSoyad.Text.Trim();
                    person.PhoneNumber = txtTelNo.Text;
                    _db.Contacts.Add(person);
                    _db.SaveChanges();
                    dgvRehber.DataSource = _db.Contacts.ToList();
                    MessageBox.Show("Yeni kiþi baþarýyla eklendi.", "BÝLGÝLENDÝRME", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                catch (Exception)
                {
                    MessageBox.Show("Bir hata oluþtu! Lütfen tekrar deneyiniz.", "BÝLGÝLENDÝRME", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                finally 
                {
                    TxtClear();
                }     
            }
            else MessageBox.Show("Ýsim bilgileri boþ olamaz ve Telefon numarasý sadece sayýlardan oluþabilir.","UYARI",MessageBoxButtons.OK,MessageBoxIcon.Error);
            
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            try
            {
                _db.Remove(dgvRehber.SelectedRows[0].DataBoundItem as Contact);
                _db.SaveChanges();
                dgvRehber.DataSource = _db.Contacts.ToList();
                MessageBox.Show("Kiþi baþarýyla silindi.", "BÝLGÝLENDÝRME", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception)
            {
                MessageBox.Show("Silmek için lütfen bir kiþi (satýr) seçiniz.", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtArama_TextChanged(object sender, EventArgs e)
        {
            if (txtArama.Text.IsNullOrEmpty())
            {
                dgvRehber.DataSource = _db.Contacts.ToList();
            }
            else
            {
                dgvRehber.DataSource = _db.Contacts.Where(c => c.FirstName.Contains(txtArama.Text) || c.LastName.Contains(txtArama.Text) || c.PhoneNumber.Contains(txtArama.Text)).ToList();
            }
        }

        private void dgvRehber_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            _db.SaveChanges();
        }

        private void TxtClear() 
        {
            txtAd.Clear();
            txtSoyad.Clear();
            txtTelNo.Clear();
            txtArama.Clear();
        }
        
    }
}