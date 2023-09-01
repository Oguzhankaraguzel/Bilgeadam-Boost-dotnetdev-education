
namespace Wfaklasor
{
    partial class Form1
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
            this.grpKlasorOlusturma = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtKlasorAdi = new System.Windows.Forms.TextBox();
            this.btnKlasorOlustur = new System.Windows.Forms.Button();
            this.lnkDosyaYoluSec = new System.Windows.Forms.LinkLabel();
            this.txtDosyaYolu = new System.Windows.Forms.TextBox();
            this.grpKlasorListele = new System.Windows.Forms.GroupBox();
            this.lnkKlasorSec = new System.Windows.Forms.LinkLabel();
            this.lstDosyalar = new System.Windows.Forms.ListBox();
            this.grpDosyaIslemleri = new System.Windows.Forms.GroupBox();
            this.txtYazi = new System.Windows.Forms.TextBox();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.grpKlasorOlusturma.SuspendLayout();
            this.grpKlasorListele.SuspendLayout();
            this.grpDosyaIslemleri.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpKlasorOlusturma
            // 
            this.grpKlasorOlusturma.Controls.Add(this.txtDosyaYolu);
            this.grpKlasorOlusturma.Controls.Add(this.lnkDosyaYoluSec);
            this.grpKlasorOlusturma.Controls.Add(this.btnKlasorOlustur);
            this.grpKlasorOlusturma.Controls.Add(this.txtKlasorAdi);
            this.grpKlasorOlusturma.Controls.Add(this.label1);
            this.grpKlasorOlusturma.Location = new System.Drawing.Point(12, 12);
            this.grpKlasorOlusturma.Name = "grpKlasorOlusturma";
            this.grpKlasorOlusturma.Size = new System.Drawing.Size(338, 216);
            this.grpKlasorOlusturma.TabIndex = 0;
            this.grpKlasorOlusturma.TabStop = false;
            this.grpKlasorOlusturma.Text = "Klasor Olusturma";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Klasor Adi Girin";
            // 
            // txtKlasorAdi
            // 
            this.txtKlasorAdi.Location = new System.Drawing.Point(11, 67);
            this.txtKlasorAdi.Name = "txtKlasorAdi";
            this.txtKlasorAdi.Size = new System.Drawing.Size(321, 30);
            this.txtKlasorAdi.TabIndex = 1;
            // 
            // btnKlasorOlustur
            // 
            this.btnKlasorOlustur.Location = new System.Drawing.Point(11, 167);
            this.btnKlasorOlustur.Name = "btnKlasorOlustur";
            this.btnKlasorOlustur.Size = new System.Drawing.Size(321, 43);
            this.btnKlasorOlustur.TabIndex = 2;
            this.btnKlasorOlustur.Text = "Klasor Olustur";
            this.btnKlasorOlustur.UseVisualStyleBackColor = true;
            this.btnKlasorOlustur.Click += new System.EventHandler(this.btnKlasorOlustur_Click);
            // 
            // lnkDosyaYoluSec
            // 
            this.lnkDosyaYoluSec.AutoSize = true;
            this.lnkDosyaYoluSec.Location = new System.Drawing.Point(6, 100);
            this.lnkDosyaYoluSec.Name = "lnkDosyaYoluSec";
            this.lnkDosyaYoluSec.Size = new System.Drawing.Size(166, 25);
            this.lnkDosyaYoluSec.TabIndex = 3;
            this.lnkDosyaYoluSec.TabStop = true;
            this.lnkDosyaYoluSec.Text = "Kayit Yeri Secin";
            this.lnkDosyaYoluSec.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkDosyaYoluSec_LinkClicked);
            // 
            // txtDosyaYolu
            // 
            this.txtDosyaYolu.Location = new System.Drawing.Point(11, 131);
            this.txtDosyaYolu.Name = "txtDosyaYolu";
            this.txtDosyaYolu.ReadOnly = true;
            this.txtDosyaYolu.Size = new System.Drawing.Size(321, 30);
            this.txtDosyaYolu.TabIndex = 4;
            // 
            // grpKlasorListele
            // 
            this.grpKlasorListele.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpKlasorListele.Controls.Add(this.lstDosyalar);
            this.grpKlasorListele.Controls.Add(this.lnkKlasorSec);
            this.grpKlasorListele.Location = new System.Drawing.Point(356, 12);
            this.grpKlasorListele.Name = "grpKlasorListele";
            this.grpKlasorListele.Size = new System.Drawing.Size(482, 216);
            this.grpKlasorListele.TabIndex = 1;
            this.grpKlasorListele.TabStop = false;
            this.grpKlasorListele.Text = "Klasor Listele";
            // 
            // lnkKlasorSec
            // 
            this.lnkKlasorSec.AutoSize = true;
            this.lnkKlasorSec.Location = new System.Drawing.Point(6, 39);
            this.lnkKlasorSec.Name = "lnkKlasorSec";
            this.lnkKlasorSec.Size = new System.Drawing.Size(118, 25);
            this.lnkKlasorSec.TabIndex = 0;
            this.lnkKlasorSec.TabStop = true;
            this.lnkKlasorSec.Text = "Klasor Sec";
            this.lnkKlasorSec.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkKlasorSec_LinkClicked);
            // 
            // lstDosyalar
            // 
            this.lstDosyalar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstDosyalar.FormattingEnabled = true;
            this.lstDosyalar.ItemHeight = 25;
            this.lstDosyalar.Location = new System.Drawing.Point(11, 67);
            this.lstDosyalar.Name = "lstDosyalar";
            this.lstDosyalar.Size = new System.Drawing.Size(465, 129);
            this.lstDosyalar.TabIndex = 1;
            // 
            // grpDosyaIslemleri
            // 
            this.grpDosyaIslemleri.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpDosyaIslemleri.Controls.Add(this.btnKaydet);
            this.grpDosyaIslemleri.Controls.Add(this.txtYazi);
            this.grpDosyaIslemleri.Location = new System.Drawing.Point(23, 234);
            this.grpDosyaIslemleri.Name = "grpDosyaIslemleri";
            this.grpDosyaIslemleri.Size = new System.Drawing.Size(815, 388);
            this.grpDosyaIslemleri.TabIndex = 2;
            this.grpDosyaIslemleri.TabStop = false;
            this.grpDosyaIslemleri.Text = "Dosya Islemleri";
            // 
            // txtYazi
            // 
            this.txtYazi.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtYazi.Location = new System.Drawing.Point(6, 29);
            this.txtYazi.Multiline = true;
            this.txtYazi.Name = "txtYazi";
            this.txtYazi.Size = new System.Drawing.Size(803, 292);
            this.txtYazi.TabIndex = 0;
            // 
            // btnKaydet
            // 
            this.btnKaydet.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnKaydet.Location = new System.Drawing.Point(521, 327);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(288, 55);
            this.btnKaydet.TabIndex = 1;
            this.btnKaydet.Text = "Dosya Olarak Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(853, 635);
            this.Controls.Add(this.grpDosyaIslemleri);
            this.Controls.Add(this.grpKlasorListele);
            this.Controls.Add(this.grpKlasorOlusturma);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grpKlasorOlusturma.ResumeLayout(false);
            this.grpKlasorOlusturma.PerformLayout();
            this.grpKlasorListele.ResumeLayout(false);
            this.grpKlasorListele.PerformLayout();
            this.grpDosyaIslemleri.ResumeLayout(false);
            this.grpDosyaIslemleri.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpKlasorOlusturma;
        private System.Windows.Forms.TextBox txtDosyaYolu;
        private System.Windows.Forms.LinkLabel lnkDosyaYoluSec;
        private System.Windows.Forms.Button btnKlasorOlustur;
        private System.Windows.Forms.TextBox txtKlasorAdi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grpKlasorListele;
        private System.Windows.Forms.ListBox lstDosyalar;
        private System.Windows.Forms.LinkLabel lnkKlasorSec;
        private System.Windows.Forms.GroupBox grpDosyaIslemleri;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.TextBox txtYazi;
    }
}

