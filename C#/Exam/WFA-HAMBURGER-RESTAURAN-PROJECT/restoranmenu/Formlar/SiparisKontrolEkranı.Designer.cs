namespace restoranmenu.Formlar
{
    partial class SiparisKontrolEkranı
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnsSiparisYonetimi = new System.Windows.Forms.ToolStripMenuItem();
            this.mnsSiparisOlustur = new System.Windows.Forms.ToolStripMenuItem();
            this.mnsSiparisBilgileri = new System.Windows.Forms.ToolStripMenuItem();
            this.mnsUrunYonetimi = new System.Windows.Forms.ToolStripMenuItem();
            this.mnsUrunEkle = new System.Windows.Forms.ToolStripMenuItem();
            this.mnsMalzemeEkle = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnsSiparisYonetimi,
            this.mnsUrunYonetimi});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1019, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mnsSiparisYonetimi
            // 
            this.mnsSiparisYonetimi.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnsSiparisOlustur,
            this.mnsSiparisBilgileri});
            this.mnsSiparisYonetimi.Name = "mnsSiparisYonetimi";
            this.mnsSiparisYonetimi.Size = new System.Drawing.Size(143, 24);
            this.mnsSiparisYonetimi.Text = "SİPARİŞ YÖNETİMİ";
            // 
            // mnsSiparisOlustur
            // 
            this.mnsSiparisOlustur.Name = "mnsSiparisOlustur";
            this.mnsSiparisOlustur.Size = new System.Drawing.Size(209, 26);
            this.mnsSiparisOlustur.Text = "SİPARİŞ OLUŞTUR";
            this.mnsSiparisOlustur.Click += new System.EventHandler(this.mnsSiparisOlustur_Click);
            // 
            // mnsSiparisBilgileri
            // 
            this.mnsSiparisBilgileri.Name = "mnsSiparisBilgileri";
            this.mnsSiparisBilgileri.Size = new System.Drawing.Size(209, 26);
            this.mnsSiparisBilgileri.Text = "SİPARİŞ BİLGİLERİ";
            this.mnsSiparisBilgileri.Click += new System.EventHandler(this.mnsSiparisBilgileri_Click);
            // 
            // mnsUrunYonetimi
            // 
            this.mnsUrunYonetimi.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnsUrunEkle,
            this.mnsMalzemeEkle});
            this.mnsUrunYonetimi.Name = "mnsUrunYonetimi";
            this.mnsUrunYonetimi.Size = new System.Drawing.Size(133, 24);
            this.mnsUrunYonetimi.Text = "ÜRÜN YÖNETİMİ";
            // 
            // mnsUrunEkle
            // 
            this.mnsUrunEkle.Name = "mnsUrunEkle";
            this.mnsUrunEkle.Size = new System.Drawing.Size(252, 26);
            this.mnsUrunEkle.Text = "ÜRÜN EKLE";
            this.mnsUrunEkle.Click += new System.EventHandler(this.mnsUrunEkle_Click);
            // 
            // mnsMalzemeEkle
            // 
            this.mnsMalzemeEkle.Name = "mnsMalzemeEkle";
            this.mnsMalzemeEkle.Size = new System.Drawing.Size(252, 26);
            this.mnsMalzemeEkle.Text = "EKSTRA MALZEME EKLE";
            this.mnsMalzemeEkle.Click += new System.EventHandler(this.mnsMalzemeEkle_Click);
            // 
            // SiparisKontrolEkranı
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1019, 662);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "SiparisKontrolEkranı";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RESTORANT YÖNETİM PANELİ";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.SiparisKontrolEkranı_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnsSiparisYonetimi;
        private System.Windows.Forms.ToolStripMenuItem mnsSiparisOlustur;
        private System.Windows.Forms.ToolStripMenuItem mnsSiparisBilgileri;
        private System.Windows.Forms.ToolStripMenuItem mnsUrunYonetimi;
        private System.Windows.Forms.ToolStripMenuItem mnsUrunEkle;
        private System.Windows.Forms.ToolStripMenuItem mnsMalzemeEkle;
    }
}