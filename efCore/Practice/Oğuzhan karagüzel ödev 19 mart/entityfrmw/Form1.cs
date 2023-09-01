using entityfrmw.Models;

namespace entityfrmw
{
    public partial class Form1 : Form
    {
        //Database tipinde bir de�i�ken olu�turulur
        NorthwindContext _db;
        public Form1()
        {
            InitializeComponent();
            //de�i�kenin i�ine database s�n�f�n�n instance'� al�n�r.
            _db = new NorthwindContext();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Bilgiler ekrana yazd�r�l�r;
            RealRefresh();
        }


        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtID.Text))
            {
                MessageBox.Show("ID bilgisi bo� olamaz");
            }
            else
            {
                try
                {
                    Customer cst = new Customer() { CustomerId = txtID.Text, CompanyName = txtCompanyName.Text };
                    CRUD(cst, 'e');
                    MessageBox.Show("Ekleme i�lei ba�ar�l�");
                }
                catch (Exception)
                {
                    MessageBox.Show("Ekleme i�lemi s�ras�nda bir hata olu�tu! \"ID\" bilgisini hatal� girmi� olabilir veya ayn� \"ID\" 'ye sahip ba�ka bir �irket olabilir", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    RealRefresh();
                }
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (dgvCompany.SelectedRows.Count == 0 || dgvCompany.SelectedRows.Count > 1)
            {
                MessageBox.Show("Silme i�lemi s�ras�nda bir hata olu�tu! Silmek i�in (sadece) bir sat�r se�meliisiniz. E�er bir h�cre i�indeki veriyi silmek istiyorsan�z, h�creye �ift t�klayarak \"H�CRE D�ZENLEME MODU\" 'na ge�ebilirsiniz", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else if (MessageBox.Show("Se�ili sat�r� silmek istedi�inize emin misiniz!", "UYARI", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                try
                {
                    CRUD(dgvCompany.SelectedRows[0].DataBoundItem as Customer, 's');
                    MessageBox.Show("Silme i�lemi ba�ar�l�");
                }
                catch (Exception)
                {
                    MessageBox.Show("Silme i�lemi s�ras�nda bir hata olu�tu! Silmek i�in bir sat�r se�meliisiniz. E�er bir h�cre i�indeki veriyi silmek istiyorsan�z, h�creye �ift t�klayarak \"H�CRE D�ZENLEME MODU\" 'na ge�ebilirsiniz", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                MessageBox.Show("G�ncelleme i�lemi ba�ar�l�");
            }
            catch (Exception)
            {
                MessageBox.Show("G�ncellemek i�in l�tfen (sadece) bir sat�r se�in ve �irket ad�n� gerekli yere yaz�n! Ya da bir h�cre �zerine �ift y�klayarak \"�CRE D�ZENLEME MODU\" 'na ge�ebilirsiniz", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void dgvCompany_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            _db.SaveChanges();
        }

        #region Metodlar
        /// <summary>
        /// Northwind database �st�nde b�t�n "CRUD" i�lemlerini yapar.  
        /// </summary>
        /// <param name="cst">Customer tipinde de�i�ken al�r</param>
        /// <param name="islem">Ekleme i�in 'e', Silme i�in 's', G�ncelleme i�in 'g'</param>
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
                throw new ArgumentOutOfRangeException("islem de�i�keni ancak 'e' (ekle),'s' (sil),'g' (g�ncelle) de�erlerini alabilir");
            }

        }

        /// <summary>
        /// T�m se�imleri s�f�rlar ve TextBox'lar� temizler 
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