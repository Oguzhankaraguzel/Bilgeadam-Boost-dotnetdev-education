using static System.Net.WebRequestMethods;

namespace KitapveYazarlar
{
    public partial class Form1 : Form
    {
        KitapYazarDbContext _db;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            _db = new KitapYazarDbContext();
            DataRefresh();
        }

        private void btnKitapEkle_Click(object sender, EventArgs e)
        {
            Kitap ktb = new Kitap();
            ktb.KitapAdi = txtKitapAdý.Text;
            _db.Kitaplar.Add(ktb);
            _db.SaveChanges();
            DataRefresh();
        }

        private void btnYazarEkle_Click(object sender, EventArgs e)
        {
            Yazar yzr = new Yazar();
            yzr.YazarAdi = txtYazarAdý.Text;
            _db.Yazarlar.Add(yzr);
            _db.SaveChanges();
            DataRefresh();
        }



        private void dgvKitaplar_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                lblDurum.Text = "KÝTABIN YAZARLARI";
                var query = from ky in _db.KitapYazar
                            join k in _db.Kitaplar on ky.KitapId equals k.Id
                            join y in _db.Yazarlar on ky.YazarId equals y.Id
                            where k.Id == Convert.ToInt32(dgvKitaplar.SelectedRows[0].Cells[0].Value)
                            select new { KitapAdi = k.KitapAdi, YazarAdi = y.YazarAdi };

                dgvKitapYazar.DataSource = query.ToList();
            }
            catch (Exception)
            {

            }

        }

        private void dgvYazarlar_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                lblDurum.Text = "YAZARIN KÝTAPLARI";
                var query = from ky in _db.KitapYazar
                            join k in _db.Kitaplar on ky.KitapId equals k.Id
                            join y in _db.Yazarlar on ky.YazarId equals y.Id
                            where y.Id == Convert.ToInt32(dgvYazarlar.SelectedRows[0].Cells[0].Value)
                            select new { YazarAdi = y.YazarAdi, KitapAdi = k.KitapAdi };

                dgvKitapYazar.DataSource = query.ToList();
            }
            catch (Exception)
            {

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            KitapYazar kitapYazar = new KitapYazar();
            kitapYazar.KitapId = Convert.ToInt32(dgvKitaplar.SelectedRows[0].Cells[0].Value);
            kitapYazar.YazarId = Convert.ToInt32(dgvYazarlar.SelectedRows[0].Cells[0].Value);
            _db.KitapYazar.Add(kitapYazar);
            _db.SaveChanges();
            DataRefresh();

        }

        private void dgvKitaplar_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            _db.SaveChanges();
            DataRefresh();
        }

        private void dgvYazarlar_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            _db.SaveChanges();
            DataRefresh();
        }

        #region Metodlar
        private void DataRefresh()
        {
            dgvKitaplar.DataSource = _db.Kitaplar
               .Select(k => new { k.Id, k.KitapAdi })
               .ToList();
            dgvYazarlar.DataSource = _db.Yazarlar
                .Select(y => new { y.Id, y.YazarAdi })
                .ToList();
            var query = from ky in _db.KitapYazar
                        join k in _db.Kitaplar on ky.KitapId equals k.Id
                        join y in _db.Yazarlar on ky.YazarId equals y.Id
                        select new { KitapAdi = k.KitapAdi, YazarAdi = y.YazarAdi };
            lblDurum.Text = "KÝTAPLAR VE YAZARLAR";
            dgvKitapYazar.DataSource = query.ToList();
        }
        #endregion

        private void btnKitapSil_Click(object sender, EventArgs e)
        {
            int index = Convert.ToInt32(dgvKitaplar.SelectedRows[0].Cells[0].Value);
            Kitap ktp = _db.Kitaplar.Where(k => k.Id == index).FirstOrDefault();

            _db.KitapYazar.RemoveRange(_db.KitapYazar.Where(ky => ky.KitapId == index));

            _db.Kitaplar.Remove(ktp);
            _db.SaveChanges();
            DataRefresh();
        }

        private void btnYazarSil_Click(object sender, EventArgs e)
        {
            int index = Convert.ToInt32(dgvYazarlar.SelectedRows[0].Cells[0].Value);
            Yazar yzr = _db.Yazarlar.Where(y => y.Id == index).FirstOrDefault();

            _db.KitapYazar.RemoveRange(_db.KitapYazar.Where(ky => ky.YazarId == index));

            _db.Yazarlar.Remove(yzr);
            _db.SaveChanges();
            DataRefresh();
        }

        private void btnXdelete_Click(object sender, EventArgs e)
        {
            KitapYazar kyr = new KitapYazar();

            kyr.KitapId = _db.Kitaplar.Where(k => k.KitapAdi == dgvKitapYazar.SelectedRows[0].Cells[0].Value.ToString()).FirstOrDefault().Id;

            kyr.YazarId = _db.Yazarlar.Where(y => y.YazarAdi == dgvKitapYazar.SelectedRows[0].Cells[1].Value.ToString()).FirstOrDefault().Id;

            _db.Remove(kyr);
            _db.SaveChanges();
            DataRefresh();
        }
    }
}