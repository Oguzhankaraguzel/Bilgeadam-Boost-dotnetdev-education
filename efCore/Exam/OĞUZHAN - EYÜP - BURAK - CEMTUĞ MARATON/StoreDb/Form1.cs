using Microsoft.EntityFrameworkCore;
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
    public partial class Form1 : Form
    {
        StoreDbContext _db;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Form2 frm = new Form2();
            frm.ShowDialog();
            _db = new StoreDbContext();
            dgvAlbums.DataSource = _db.Albums.ToList();
            dgvArtist.DataSource = _db.Artists.ToList();
        }

        private void btnAlbumAdd_Click(object sender, EventArgs e)
        {
            Album alb = new Album();
            alb.AlbumName = txtAlbumName.Text;
            alb.SingerName = dgvArtist.SelectedRows[0].Cells[1].Value.ToString();
            alb.Artist = dgvArtist.SelectedRows[0].DataBoundItem as Artist;
            var art = dgvArtist.SelectedRows[0].DataBoundItem as Artist;

            _db.Artists.Update(art);
            _db.Albums.Add(alb);
            _db.SaveChanges();
            art.Albums.Add(alb);
            _db.SaveChanges();
            dgvAlbums.DataSource = _db.Albums.ToList();
            dgvArtist.DataSource = _db.Artists.ToList();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Artist art = new Artist();
            art.Name = txtArtistName.Text;
            _db.Artists.Add(art);
            _db.SaveChanges();
            dgvArtist.DataSource = _db.Artists.ToList();
        }

        private void btnAlbumDelete_Click(object sender, EventArgs e)
        {
            _db.Artists.Remove(dgvAlbums.SelectedRows[0].DataBoundItem as Artist);
            _db.SaveChanges();
            dgvAlbums.DataSource = _db.Albums.ToList();
            dgvArtist.DataSource = _db.Artists.ToList();
        }

        private void btnArtistDelete_Click(object sender, EventArgs e)
        {
            _db.Artists.Remove(dgvArtist.SelectedRows[0].DataBoundItem as Artist);
            _db.SaveChanges();
            dgvArtist.DataSource = _db.Artists.ToList();
            dgvAlbums.DataSource = _db.Albums.ToList();
        }

        private void dgvAlbums_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            _db.SaveChanges();
        }

        private void dgvArtist_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            _db.SaveChanges();
        }

        private void no2List_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form4 frm = new Form4();
            DataGridView dgv = frm.MyDataGridView;
            dgv.DataSource = _db.Albums.Where(a => a.SaleContinue).ToList();
            frm.ShowDialog();
        }

        private void no3List_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //var query = 
            Form4 frm = new Form4();
            DataGridView dgv = frm.MyDataGridView;
            dgv.DataSource = _db.Albums.Where(a => !a.SaleContinue).ToList();
            frm.ShowDialog();
        }

        private void no4List_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //var query = 
            Form4 frm = new Form4();
            DataGridView dgv = frm.MyDataGridView;
            dgv.DataSource = _db.Albums
                .OrderByDescending(a => a.Id)
                .Take(10)
                .ToList();
            frm.ShowDialog();
        }

        private void no5List_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //var query = 
            Form4 frm = new Form4();
            DataGridView dgv = frm.MyDataGridView;
            dgv.DataSource = _db.Albums.Where(a => a.Discount > 0).ToList();
            frm.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var alb = dgvAlbums.SelectedRows[0].DataBoundItem as Album;
            alb.SaleContinue = !alb.SaleContinue;
            _db.Albums.Update(alb);
            _db.SaveChanges();
        }

        private void btnAddArtist_Click(object sender, EventArgs e)
        {
            var alb = (Album)dgvAlbums.SelectedRows[0].DataBoundItem;
            
            var art = dgvArtist.SelectedRows[0].DataBoundItem as Artist;

            art.Albums.Add(alb);
            _db.Artists.Update(art);
            _db.SaveChanges();
            dgvAlbums.DataSource = _db.Albums.ToList();
            dgvArtist.DataSource = _db.Artists.ToList();
        }
    }
}
