using NorthwindQuery.Models;

namespace NorthwindQuery
{
    public partial class Form1 : Form
    {
        NorthwindContext _db;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            _db = new NorthwindContext();
            dgvCustomers.DataSource = _db.Customers.ToList();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            Customer csm = new Customer();
            csm.CustomerId = txtCustomerID.Text;
            csm.CompanyName = txtCustomerName.Text;
            _db.Customers.Add(csm);
            _db.SaveChanges();
            dgvCustomers.DataSource = _db.Customers.ToList();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            _db.Customers.Remove(dgvCustomers.SelectedRows[0].DataBoundItem as Customer);
            _db.SaveChanges();
            dgvCustomers.DataSource = _db.Customers.ToList();
        }

        private void dgvCustomers_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            _db.SaveChanges();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 frm = new Form2();
            DataGridView dgv = frm.MyDataGridView;
            dgv.DataSource = _db.Products.Where(prod => prod.UnitPrice >= 20 || prod.UnitPrice <= 50).Select(prod => new { prod.ProductId, prod.ProductName, prod.UnitPrice, prod.UnitsInStock, prod.Category }).ToList();
            frm.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 frm = new Form2();
            DataGridView dgv = frm.MyDataGridView;
            dgv.DataSource = _db.Orders
         .Join(_db.Customers, o => o.CustomerId, c => c.CustomerId, (o, c) => new { Order = o, Customer = c })
         .Join(_db.Employees, oc => oc.Order.EmployeeId, e => e.EmployeeId, (oc, e) => new { OrderCustomer = oc, Employee = e })
         .Join(_db.Shippers, oce => oce.OrderCustomer.Order.ShipVia, s => s.ShipperId, (oce, s) => new { OrderCustomerEmployee = oce, Shipper = s }).Select(x => new
         {
             MusteriﬁirketAdi = x.OrderCustomerEmployee.OrderCustomer.Customer.CompanyName,
             CalisanAdiSoyadi = x.OrderCustomerEmployee.Employee.FirstName + " " + x.OrderCustomerEmployee.Employee.LastName,
             SiparisID = x.OrderCustomerEmployee.OrderCustomer.Order.OrderId,
             SiparisTarihi = x.OrderCustomerEmployee.OrderCustomer.Order.OrderDate,
             KargoSirketAdi = x.Shipper.CompanyName
         }).ToList();
            frm.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form2 frm = new Form2();
            DataGridView dgv = frm.MyDataGridView;
            dgv.DataSource = _db.Customers.Where(cust => cust.CompanyName.Contains("restaurant")).ToList();
            frm.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Product product = new Product();
            product.CategoryId = 1;
            product.ProductName = "Cola";
            product.UnitPrice = 5;
            product.UnitsInStock = 500;
            _db.Products.Add(product);
            _db.SaveChanges();

            Form2 frm = new Form2();
            DataGridView dgv = frm.MyDataGridView;
            dgv.DataSource = _db.Products.ToList();
            frm.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form2 frm = new Form2();
            DataGridView dgv = frm.MyDataGridView;
            dgv.DataSource = _db.Employees.Select(emp => new { emp.FirstName, emp.LastName, emp.BirthDate, Yas = DateTime.Now.Year - Convert.ToDateTime(emp.BirthDate).Year }).ToList();
            frm.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form2 frm = new Form2();
            DataGridView dgv = frm.MyDataGridView;
            dgv.DataSource = _db.Products.GroupBy(x => x.CategoryId).Select(x => new { Category = x.Key, StokMiktar˝ = x.Sum(y => y.UnitsInStock) }).ToList();
            frm.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form2 frm = new Form2();
            DataGridView dgv = frm.MyDataGridView;
            dgv.DataSource = _db.Products.OrderByDescending(x => x.UnitsInStock).ToList();
            frm.ShowDialog();
            dgv.DataSource = _db.Products.OrderByDescending(prod => prod.ProductName).ToList();
            frm.ShowDialog();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Form2 frm = new Form2();
            DataGridView dgv = frm.MyDataGridView;
            dgv.DataSource = _db.OrderDetails.GroupBy(od => od.OrderId).Select(x => new { OrderId = x.Key, ToplamSat˝˛Tutar˝ = x.Sum(x => x.UnitPrice * x.Quantity) }).OrderBy(x => x.ToplamSat˝˛Tutar˝).ToList();
            frm.ShowDialog();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Form2 frm = new Form2();
            DataGridView dgv = frm.MyDataGridView;
            dgv.DataSource = _db.Categories.Join(_db.Products, x => x.CategoryId, y => y.CategoryId, (x, y) => new { Product = y.ProductName, Category = x.CategoryName }).OrderBy(x => x.Category).ToList();
            frm.ShowDialog();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Form2 frm = new Form2();
            DataGridView dgv = frm.MyDataGridView;
            dgv.DataSource = _db.Categories.
                Join(_db.Products, c => c.CategoryId, p => p.CategoryId, (c, p) => new { Categories = c, Products = p }).
                Join(_db.OrderDetails, cp => cp.Products.ProductId, od => od.ProductId, (cp, od) => new { Products = cp, OrderDetail = od }).
                Join(_db.Orders, pod => pod.OrderDetail.OrderId, o => o.OrderId, (pod, o) => new { ProductOD = pod, Orders = o }).
                Join(_db.Shippers, podo => podo.Orders.ShipVia, s => s.ShipperId, (podo, s) => new { ProductODOrders = podo, Shipper = s }).Select(x => new {
                    TekStunda›simler = x.ProductODOrders.ProductOD.Products.Categories.CategoryName + " " + x.ProductODOrders.ProductOD.OrderDetail.Product.ProductName + " " +
                      x.Shipper.CompanyName
                }).ToList();
            frm.ShowDialog();
        }
    }
}