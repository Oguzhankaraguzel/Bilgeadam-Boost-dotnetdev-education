using entityfrmw.Models;

namespace entityfrmw
{
    public partial class Form1 : Form
    {
        //Database tipinde bir deðiþken oluþturulur
        NorthwindContext _db;
        public Form1()
        {
            InitializeComponent();
            //deðiþkenin içine database sýnýfýnýn instance'ý alýnýr.
            _db = new NorthwindContext();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Bilgiler ekrana yazdýrýlýr;
            RealRefresh();
        }


        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtID.Text))
            {
                MessageBox.Show("ID bilgisi boþ olamaz");
            }
            else
            {
                try
                {
                    Customer cst = new Customer() { CustomerId = txtID.Text, CompanyName = txtCompanyName.Text };
                    CRUD(cst, 'e');
                    MessageBox.Show("Ekleme iþlei baþarýlý");
                }
                catch (Exception)
                {
                    MessageBox.Show("Ekleme iþlemi sýrasýnda bir hata oluþtu! \"ID\" bilgisini hatalý girmiþ olabilir veya ayný \"ID\" 'ye sahip baþka bir þirket olabilir", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    RealRefresh();
                }
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (dgvCompany.SelectedRows.Count == 0 || dgvCompany.SelectedRows.Count > 1)
            {
                MessageBox.Show("Silme iþlemi sýrasýnda bir hata oluþtu! Silmek için (sadece) bir satýr seçmeliisiniz. Eðer bir hücre içindeki veriyi silmek istiyorsanýz, hücreye çift týklayarak \"HÜCRE DÜZENLEME MODU\" 'na geçebilirsiniz", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else if (MessageBox.Show("Seçili satýrý silmek istediðinize emin misiniz!", "UYARI", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                try
                {
                    CRUD(dgvCompany.SelectedRows[0].DataBoundItem as Customer, 's');
                    MessageBox.Show("Silme iþlemi baþarýlý");
                }
                catch (Exception)
                {
                    MessageBox.Show("Silme iþlemi sýrasýnda bir hata oluþtu! Silmek için bir satýr seçmeliisiniz. Eðer bir hücre içindeki veriyi silmek istiyorsanýz, hücreye çift týklayarak \"HÜCRE DÜZENLEME MODU\" 'na geçebilirsiniz", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            try
            {
                dgvCompany.SelectedRows[0].Cells["CompanyName"].Value = txtCompanyName.Text;
                _db.SaveChanges();
                RealRefresh();
                MessageBox.Show("Güncelleme iþlemi baþarýlý");
            }
            catch (Exception)
            {
                MessageBox.Show("Güncellemek için lütfen (sadece) bir satýr seçin ve þirket adýný gerekli yere yazýn! Ya da bir hücre üzerine çift yýklayarak \"ÜCRE DÜZENLEME MODU\" 'na geçebilirsiniz", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void dgvCompany_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            _db.SaveChanges();
        }

        #region Metodlar
        /// <summary>
        /// Northwind database üstünde bütün "CRUD" iþlemlerini yapar.  
        /// </summary>
        /// <param name="cst">Customer tipinde deðiþken alýr</param>
        /// <param name="islem">Ekleme için 'e', Silme için 's', Güncelleme için 'g'</param>
        /// <exception cref="NullReferenceException"></exception>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        private void CRUD(Customer cst, char islem)
        {
            if (islem == 'e')
            {
                _db.Customers.Add(cst);
                _db.SaveChanges();
                RealRefresh();
            }
            else if (islem == 's')
            {
                _db.Customers.Remove(cst);
                _db.SaveChanges();
                RealRefresh();
            }
            else if (islem == 'g')
            {
                _db.Customers.Update(cst);
                _db.SaveChanges();
                RealRefresh();
            }
            else if (cst == null)
            {
                throw new NullReferenceException();
            }
            else
            {
                throw new ArgumentOutOfRangeException("islem deðiþkeni ancak 'e' (ekle),'s' (sil),'g' (güncelle) deðerlerini alabilir");
            }

        }

        /// <summary>
        /// Tüm seçimleri sýfýrlar ve TextBox'larý temizler 
        /// </summary>
        private void RealRefresh()
        {
            txtID.Clear();
            txtCompanyName.Clear();
            dgvCompany.ClearSelection();
            dgvCompany.DataSource = null;
            dgvCompany.DataSource = _db.Customers.ToList();
            dgvCompany.Refresh();
        }
        #endregion


    }
}