namespace restoranmenu.Formlar
{
    partial class EkstraMalzemeEklemeFormu
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMalzemeAdi = new System.Windows.Forms.TextBox();
            this.txtMalzemeFiyati = new System.Windows.Forms.TextBox();
            this.lstMalzemeListesi = new System.Windows.Forms.ListBox();
            this.btnMalzemeSil = new System.Windows.Forms.Button();
            this.btnMalzemeGuncelle = new System.Windows.Forms.Button();
            this.btnMalzemeEkle = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(65, 15);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "MALZEME ADI";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 65);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(178, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "MALZEME FİYATI";
            // 
            // txtMalzemeAdi
            // 
            this.txtMalzemeAdi.Location = new System.Drawing.Point(223, 12);
            this.txtMalzemeAdi.Name = "txtMalzemeAdi";
            this.txtMalzemeAdi.Size = new System.Drawing.Size(283, 30);
            this.txtMalzemeAdi.TabIndex = 2;
            // 
            // txtMalzemeFiyati
            // 
            this.txtMalzemeFiyati.Location = new System.Drawing.Point(223, 62);
            this.txtMalzemeFiyati.Name = "txtMalzemeFiyati";
            this.txtMalzemeFiyati.Size = new System.Drawing.Size(283, 30);
            this.txtMalzemeFiyati.TabIndex = 2;
            // 
            // lstMalzemeListesi
            // 
            this.lstMalzemeListesi.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstMalzemeListesi.FormattingEnabled = true;
            this.lstMalzemeListesi.ItemHeight = 23;
            this.lstMalzemeListesi.Location = new System.Drawing.Point(512, 12);
            this.lstMalzemeListesi.Name = "lstMalzemeListesi";
            this.lstMalzemeListesi.Size = new System.Drawing.Size(596, 625);
            this.lstMalzemeListesi.TabIndex = 3;
            this.lstMalzemeListesi.SelectedIndexChanged += new System.EventHandler(this.lstMalzemeListesi_SelectedIndexChanged);
            // 
            // btnMalzemeSil
            // 
            this.btnMalzemeSil.Location = new System.Drawing.Point(355, 109);
            this.btnMalzemeSil.Name = "btnMalzemeSil";
            this.btnMalzemeSil.Size = new System.Drawing.Size(151, 55);
            this.btnMalzemeSil.TabIndex = 4;
            this.btnMalzemeSil.Text = "MALZEME SİL";
            this.btnMalzemeSil.UseVisualStyleBackColor = true;
            this.btnMalzemeSil.Click += new System.EventHandler(this.btnMalzemeSil_Click);
            // 
            // btnMalzemeGuncelle
            // 
            this.btnMalzemeGuncelle.Location = new System.Drawing.Point(192, 109);
            this.btnMalzemeGuncelle.Name = "btnMalzemeGuncelle";
            this.btnMalzemeGuncelle.Size = new System.Drawing.Size(157, 55);
            this.btnMalzemeGuncelle.TabIndex = 4;
            this.btnMalzemeGuncelle.Text = "MALZEME GÜNCELLE";
            this.btnMalzemeGuncelle.UseVisualStyleBackColor = true;
            this.btnMalzemeGuncelle.Click += new System.EventHandler(this.btnMalzemeGuncelle_Click);
            // 
            // btnMalzemeEkle
            // 
            this.btnMalzemeEkle.Location = new System.Drawing.Point(32, 109);
            this.btnMalzemeEkle.Name = "btnMalzemeEkle";
            this.btnMalzemeEkle.Size = new System.Drawing.Size(154, 55);
            this.btnMalzemeEkle.TabIndex = 4;
            this.btnMalzemeEkle.Text = "MALZEME EKLE";
            this.btnMalzemeEkle.UseVisualStyleBackColor = true;
            this.btnMalzemeEkle.Click += new System.EventHandler(this.btnMalzemeEkle_Click);
            // 
            // EkstraMalzemeEklemeFormu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(1120, 647);
            this.Controls.Add(this.btnMalzemeEkle);
            this.Controls.Add(this.btnMalzemeGuncelle);
            this.Controls.Add(this.btnMalzemeSil);
            this.Controls.Add(this.lstMalzemeListesi);
            this.Controls.Add(this.txtMalzemeFiyati);
            this.Controls.Add(this.txtMalzemeAdi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "EkstraMalzemeEklemeFormu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "EKSTRA MALZEME EKLEME FORMU";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMalzemeAdi;
        private System.Windows.Forms.TextBox txtMalzemeFiyati;
        private System.Windows.Forms.ListBox lstMalzemeListesi;
        private System.Windows.Forms.Button btnMalzemeSil;
        private System.Windows.Forms.Button btnMalzemeGuncelle;
        private System.Windows.Forms.Button btnMalzemeEkle;
    }
}