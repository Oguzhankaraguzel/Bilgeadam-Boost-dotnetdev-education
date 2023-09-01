namespace TelefonYonetim.Formlar
{
    partial class TELEFONDUZENLEME
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
            this.label3 = new System.Windows.Forms.Label();
            this.txtMarka = new System.Windows.Forms.TextBox();
            this.txtModel = new System.Windows.Forms.TextBox();
            this.txtYil = new System.Windows.Forms.TextBox();
            this.lstTelefonlar = new System.Windows.Forms.ListBox();
            this.grpDurum = new System.Windows.Forms.GroupBox();
            this.rdbHurda = new System.Windows.Forms.RadioButton();
            this.rdbKullanımda = new System.Windows.Forms.RadioButton();
            this.rdbSatısta = new System.Windows.Forms.RadioButton();
            this.btnEkle = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.btnOynat = new System.Windows.Forms.Button();
            this.pctTelefonFotograf = new System.Windows.Forms.PictureBox();
            this.lblFotografYolu = new System.Windows.Forms.LinkLabel();
            this.grpDurum.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctTelefonFotograf)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(89, 37);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "MARKA : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(88, 77);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 23);
            this.label2.TabIndex = 0;
            this.label2.Text = "MODEL : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(128, 119);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 23);
            this.label3.TabIndex = 0;
            this.label3.Text = "YIL : ";
            // 
            // txtMarka
            // 
            this.txtMarka.Location = new System.Drawing.Point(192, 34);
            this.txtMarka.Name = "txtMarka";
            this.txtMarka.Size = new System.Drawing.Size(292, 31);
            this.txtMarka.TabIndex = 1;
            // 
            // txtModel
            // 
            this.txtModel.Location = new System.Drawing.Point(193, 74);
            this.txtModel.Name = "txtModel";
            this.txtModel.Size = new System.Drawing.Size(292, 31);
            this.txtModel.TabIndex = 1;
            // 
            // txtYil
            // 
            this.txtYil.Location = new System.Drawing.Point(193, 116);
            this.txtYil.Name = "txtYil";
            this.txtYil.Size = new System.Drawing.Size(292, 31);
            this.txtYil.TabIndex = 1;
            // 
            // lstTelefonlar
            // 
            this.lstTelefonlar.FormattingEnabled = true;
            this.lstTelefonlar.HorizontalScrollbar = true;
            this.lstTelefonlar.ItemHeight = 23;
            this.lstTelefonlar.Location = new System.Drawing.Point(491, 34);
            this.lstTelefonlar.Name = "lstTelefonlar";
            this.lstTelefonlar.Size = new System.Drawing.Size(479, 441);
            this.lstTelefonlar.TabIndex = 2;
            this.lstTelefonlar.SelectedIndexChanged += new System.EventHandler(this.lstTelefonlar_SelectedIndexChanged);
            // 
            // grpDurum
            // 
            this.grpDurum.Controls.Add(this.rdbHurda);
            this.grpDurum.Controls.Add(this.rdbKullanımda);
            this.grpDurum.Controls.Add(this.rdbSatısta);
            this.grpDurum.Location = new System.Drawing.Point(92, 153);
            this.grpDurum.Name = "grpDurum";
            this.grpDurum.Size = new System.Drawing.Size(392, 178);
            this.grpDurum.TabIndex = 3;
            this.grpDurum.TabStop = false;
            this.grpDurum.Text = "DURUMU";
            // 
            // rdbHurda
            // 
            this.rdbHurda.AutoSize = true;
            this.rdbHurda.Location = new System.Drawing.Point(6, 126);
            this.rdbHurda.Name = "rdbHurda";
            this.rdbHurda.Size = new System.Drawing.Size(17, 16);
            this.rdbHurda.TabIndex = 2;
            this.rdbHurda.TabStop = true;
            this.rdbHurda.UseVisualStyleBackColor = true;
            // 
            // rdbKullanımda
            // 
            this.rdbKullanımda.AutoSize = true;
            this.rdbKullanımda.Location = new System.Drawing.Point(6, 82);
            this.rdbKullanımda.Name = "rdbKullanımda";
            this.rdbKullanımda.Size = new System.Drawing.Size(17, 16);
            this.rdbKullanımda.TabIndex = 1;
            this.rdbKullanımda.TabStop = true;
            this.rdbKullanımda.UseVisualStyleBackColor = true;
            // 
            // rdbSatısta
            // 
            this.rdbSatısta.AutoSize = true;
            this.rdbSatısta.Location = new System.Drawing.Point(6, 38);
            this.rdbSatısta.Name = "rdbSatısta";
            this.rdbSatısta.Size = new System.Drawing.Size(17, 16);
            this.rdbSatısta.TabIndex = 0;
            this.rdbSatısta.TabStop = true;
            this.rdbSatısta.UseVisualStyleBackColor = true;
            // 
            // btnEkle
            // 
            this.btnEkle.BackColor = System.Drawing.Color.Green;
            this.btnEkle.Location = new System.Drawing.Point(491, 481);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(129, 92);
            this.btnEkle.TabIndex = 4;
            this.btnEkle.Text = "EKLE";
            this.btnEkle.UseVisualStyleBackColor = false;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // btnSil
            // 
            this.btnSil.BackColor = System.Drawing.Color.Red;
            this.btnSil.Location = new System.Drawing.Point(841, 481);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(129, 92);
            this.btnSil.TabIndex = 4;
            this.btnSil.Text = "SİL";
            this.btnSil.UseVisualStyleBackColor = false;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.BackColor = System.Drawing.Color.Yellow;
            this.btnGuncelle.Location = new System.Drawing.Point(666, 481);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(129, 92);
            this.btnGuncelle.TabIndex = 4;
            this.btnGuncelle.Text = "GÜNCELLE";
            this.btnGuncelle.UseVisualStyleBackColor = false;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // btnOynat
            // 
            this.btnOynat.Location = new System.Drawing.Point(92, 358);
            this.btnOynat.Name = "btnOynat";
            this.btnOynat.Size = new System.Drawing.Size(392, 48);
            this.btnOynat.TabIndex = 5;
            this.btnOynat.Text = "OYNAT";
            this.btnOynat.UseVisualStyleBackColor = true;
            this.btnOynat.Click += new System.EventHandler(this.btnOynat_Click);
            // 
            // pctTelefonFotograf
            // 
            this.pctTelefonFotograf.Location = new System.Drawing.Point(242, 425);
            this.pctTelefonFotograf.Name = "pctTelefonFotograf";
            this.pctTelefonFotograf.Size = new System.Drawing.Size(242, 216);
            this.pctTelefonFotograf.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pctTelefonFotograf.TabIndex = 6;
            this.pctTelefonFotograf.TabStop = false;
            // 
            // lblFotografYolu
            // 
            this.lblFotografYolu.AutoSize = true;
            this.lblFotografYolu.Location = new System.Drawing.Point(60, 425);
            this.lblFotografYolu.Name = "lblFotografYolu";
            this.lblFotografYolu.Size = new System.Drawing.Size(176, 23);
            this.lblFotografYolu.TabIndex = 7;
            this.lblFotografYolu.TabStop = true;
            this.lblFotografYolu.Text = "FOTĞRAF YÜKLE";
            this.lblFotografYolu.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblFotografYolu_LinkClicked);
            // 
            // TELEFONDUZENLEME
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 653);
            this.Controls.Add(this.lblFotografYolu);
            this.Controls.Add(this.pctTelefonFotograf);
            this.Controls.Add(this.btnOynat);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.grpDurum);
            this.Controls.Add(this.lstTelefonlar);
            this.Controls.Add(this.txtYil);
            this.Controls.Add(this.txtModel);
            this.Controls.Add(this.txtMarka);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Agency FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "TELEFONDUZENLEME";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "TELEFONDUZENLEME";
            this.grpDurum.ResumeLayout(false);
            this.grpDurum.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctTelefonFotograf)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMarka;
        private System.Windows.Forms.TextBox txtModel;
        private System.Windows.Forms.TextBox txtYil;
        private System.Windows.Forms.ListBox lstTelefonlar;
        private System.Windows.Forms.GroupBox grpDurum;
        private System.Windows.Forms.RadioButton rdbHurda;
        private System.Windows.Forms.RadioButton rdbKullanımda;
        private System.Windows.Forms.RadioButton rdbSatısta;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Button btnOynat;
        private System.Windows.Forms.PictureBox pctTelefonFotograf;
        private System.Windows.Forms.LinkLabel lblFotografYolu;
    }
}