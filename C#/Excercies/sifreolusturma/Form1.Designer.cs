namespace sifreolusturma
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
            this.grpParametreler = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSifre = new System.Windows.Forms.TextBox();
            this.btnUret = new System.Windows.Forms.Button();
            this.nudSifreUzunlugu = new System.Windows.Forms.NumericUpDown();
            this.nudSifreSayisi = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbxOzelKarakter = new System.Windows.Forms.CheckBox();
            this.cbxRakam = new System.Windows.Forms.CheckBox();
            this.cbxBuyukHarf = new System.Windows.Forms.CheckBox();
            this.cbxKucukHarf = new System.Windows.Forms.CheckBox();
            this.lstSifreler = new System.Windows.Forms.ListBox();
            this.grpParametreler.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSifreUzunlugu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSifreSayisi)).BeginInit();
            this.SuspendLayout();
            // 
            // grpParametreler
            // 
            this.grpParametreler.Controls.Add(this.label3);
            this.grpParametreler.Controls.Add(this.txtSifre);
            this.grpParametreler.Controls.Add(this.btnUret);
            this.grpParametreler.Controls.Add(this.nudSifreUzunlugu);
            this.grpParametreler.Controls.Add(this.nudSifreSayisi);
            this.grpParametreler.Controls.Add(this.label2);
            this.grpParametreler.Controls.Add(this.label1);
            this.grpParametreler.Controls.Add(this.cbxOzelKarakter);
            this.grpParametreler.Controls.Add(this.cbxRakam);
            this.grpParametreler.Controls.Add(this.cbxBuyukHarf);
            this.grpParametreler.Controls.Add(this.cbxKucukHarf);
            this.grpParametreler.Location = new System.Drawing.Point(16, 15);
            this.grpParametreler.Margin = new System.Windows.Forms.Padding(5);
            this.grpParametreler.Name = "grpParametreler";
            this.grpParametreler.Padding = new System.Windows.Forms.Padding(5);
            this.grpParametreler.Size = new System.Drawing.Size(368, 394);
            this.grpParametreler.TabIndex = 0;
            this.grpParametreler.TabStop = false;
            this.grpParametreler.Text = "PARAMETRELER";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(8, 278);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(178, 76);
            this.label3.TabIndex = 5;
            this.label3.Text = "Sifreyi edinmek icin uzerine tiklayin";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtSifre
            // 
            this.txtSifre.Location = new System.Drawing.Point(8, 359);
            this.txtSifre.Name = "txtSifre";
            this.txtSifre.Size = new System.Drawing.Size(329, 27);
            this.txtSifre.TabIndex = 6;
            // 
            // btnUret
            // 
            this.btnUret.Location = new System.Drawing.Point(193, 278);
            this.btnUret.Margin = new System.Windows.Forms.Padding(4);
            this.btnUret.Name = "btnUret";
            this.btnUret.Size = new System.Drawing.Size(144, 76);
            this.btnUret.TabIndex = 3;
            this.btnUret.Text = "URET";
            this.btnUret.UseVisualStyleBackColor = true;
            this.btnUret.Click += new System.EventHandler(this.btnUret_Click);
            // 
            // nudSifreUzunlugu
            // 
            this.nudSifreUzunlugu.Location = new System.Drawing.Point(193, 240);
            this.nudSifreUzunlugu.Margin = new System.Windows.Forms.Padding(4);
            this.nudSifreUzunlugu.Name = "nudSifreUzunlugu";
            this.nudSifreUzunlugu.Size = new System.Drawing.Size(144, 27);
            this.nudSifreUzunlugu.TabIndex = 2;
            // 
            // nudSifreSayisi
            // 
            this.nudSifreSayisi.Location = new System.Drawing.Point(193, 195);
            this.nudSifreSayisi.Margin = new System.Windows.Forms.Padding(4);
            this.nudSifreSayisi.Name = "nudSifreSayisi";
            this.nudSifreSayisi.Size = new System.Drawing.Size(144, 27);
            this.nudSifreSayisi.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 242);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(155, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Sifre Uzunlugu :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 198);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Sifre Sayisi :";
            // 
            // cbxOzelKarakter
            // 
            this.cbxOzelKarakter.AutoSize = true;
            this.cbxOzelKarakter.Location = new System.Drawing.Point(8, 139);
            this.cbxOzelKarakter.Margin = new System.Windows.Forms.Padding(4);
            this.cbxOzelKarakter.Name = "cbxOzelKarakter";
            this.cbxOzelKarakter.Size = new System.Drawing.Size(159, 24);
            this.cbxOzelKarakter.TabIndex = 0;
            this.cbxOzelKarakter.Text = "Ozel Karakter";
            this.cbxOzelKarakter.UseVisualStyleBackColor = true;
            // 
            // cbxRakam
            // 
            this.cbxRakam.AutoSize = true;
            this.cbxRakam.Location = new System.Drawing.Point(8, 107);
            this.cbxRakam.Margin = new System.Windows.Forms.Padding(4);
            this.cbxRakam.Name = "cbxRakam";
            this.cbxRakam.Size = new System.Drawing.Size(93, 24);
            this.cbxRakam.TabIndex = 0;
            this.cbxRakam.Text = "Rakam";
            this.cbxRakam.UseVisualStyleBackColor = true;
            // 
            // cbxBuyukHarf
            // 
            this.cbxBuyukHarf.AutoSize = true;
            this.cbxBuyukHarf.Location = new System.Drawing.Point(8, 75);
            this.cbxBuyukHarf.Margin = new System.Windows.Forms.Padding(4);
            this.cbxBuyukHarf.Name = "cbxBuyukHarf";
            this.cbxBuyukHarf.Size = new System.Drawing.Size(135, 24);
            this.cbxBuyukHarf.TabIndex = 0;
            this.cbxBuyukHarf.Text = "Buyuk Harf";
            this.cbxBuyukHarf.UseVisualStyleBackColor = true;
            // 
            // cbxKucukHarf
            // 
            this.cbxKucukHarf.AutoSize = true;
            this.cbxKucukHarf.Location = new System.Drawing.Point(8, 44);
            this.cbxKucukHarf.Margin = new System.Windows.Forms.Padding(4);
            this.cbxKucukHarf.Name = "cbxKucukHarf";
            this.cbxKucukHarf.Size = new System.Drawing.Size(134, 24);
            this.cbxKucukHarf.TabIndex = 0;
            this.cbxKucukHarf.Text = "Kucuk Harf";
            this.cbxKucukHarf.UseVisualStyleBackColor = true;
            // 
            // lstSifreler
            // 
            this.lstSifreler.BackColor = System.Drawing.SystemColors.ControlDark;
            this.lstSifreler.FormattingEnabled = true;
            this.lstSifreler.ItemHeight = 20;
            this.lstSifreler.Location = new System.Drawing.Point(392, 15);
            this.lstSifreler.Margin = new System.Windows.Forms.Padding(4);
            this.lstSifreler.Name = "lstSifreler";
            this.lstSifreler.Size = new System.Drawing.Size(287, 404);
            this.lstSifreler.TabIndex = 1;
            this.lstSifreler.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lstSifreler_MouseClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(695, 428);
            this.Controls.Add(this.lstSifreler);
            this.Controls.Add(this.grpParametreler);
            this.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Form1";
            this.Text = "SIFRE URETECI";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grpParametreler.ResumeLayout(false);
            this.grpParametreler.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSifreUzunlugu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSifreSayisi)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpParametreler;
        private System.Windows.Forms.Button btnUret;
        private System.Windows.Forms.NumericUpDown nudSifreUzunlugu;
        private System.Windows.Forms.NumericUpDown nudSifreSayisi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox cbxOzelKarakter;
        private System.Windows.Forms.CheckBox cbxRakam;
        private System.Windows.Forms.CheckBox cbxBuyukHarf;
        private System.Windows.Forms.CheckBox cbxKucukHarf;
        private System.Windows.Forms.ListBox lstSifreler;
        private System.Windows.Forms.TextBox txtSifre;
        private System.Windows.Forms.Label label3;
    }
}

