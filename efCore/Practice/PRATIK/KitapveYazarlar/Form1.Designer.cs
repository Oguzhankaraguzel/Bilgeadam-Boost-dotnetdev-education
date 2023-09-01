namespace KitapveYazarlar
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            txtKitapAdı = new TextBox();
            btnKitapEkle = new Button();
            label2 = new Label();
            txtYazarAdı = new TextBox();
            btnYazarEkle = new Button();
            label3 = new Label();
            label4 = new Label();
            lblDurum = new Label();
            dgvKitaplar = new DataGridView();
            dgvYazarlar = new DataGridView();
            dgvKitapYazar = new DataGridView();
            button1 = new Button();
            label5 = new Label();
            btnKitapSil = new Button();
            btnYazarSil = new Button();
            btnXdelete = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvKitaplar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvYazarlar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvKitapYazar).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(13, 15);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(102, 22);
            label1.TabIndex = 0;
            label1.Text = "KİTAP ADI";
            // 
            // txtKitapAdı
            // 
            txtKitapAdı.Location = new Point(122, 12);
            txtKitapAdı.Name = "txtKitapAdı";
            txtKitapAdı.Size = new Size(273, 30);
            txtKitapAdı.TabIndex = 1;
            // 
            // btnKitapEkle
            // 
            btnKitapEkle.Location = new Point(401, 12);
            btnKitapEkle.Name = "btnKitapEkle";
            btnKitapEkle.Size = new Size(138, 29);
            btnKitapEkle.TabIndex = 2;
            btnKitapEkle.Text = "KİTAP EKLE";
            btnKitapEkle.UseVisualStyleBackColor = true;
            btnKitapEkle.Click += btnKitapEkle_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(3, 51);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(112, 22);
            label2.TabIndex = 0;
            label2.Text = "YAZAR ADI";
            // 
            // txtYazarAdı
            // 
            txtYazarAdı.Location = new Point(122, 48);
            txtYazarAdı.Name = "txtYazarAdı";
            txtYazarAdı.Size = new Size(273, 30);
            txtYazarAdı.TabIndex = 1;
            // 
            // btnYazarEkle
            // 
            btnYazarEkle.Location = new Point(401, 48);
            btnYazarEkle.Name = "btnYazarEkle";
            btnYazarEkle.Size = new Size(138, 29);
            btnYazarEkle.TabIndex = 2;
            btnYazarEkle.Text = "YAZAR EKLE";
            btnYazarEkle.UseVisualStyleBackColor = true;
            btnYazarEkle.Click += btnYazarEkle_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(122, 149);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(103, 22);
            label3.TabIndex = 0;
            label3.Text = "KİTAPLAR";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(459, 149);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(112, 22);
            label4.TabIndex = 0;
            label4.Text = "YAZARLAR";
            // 
            // lblDurum
            // 
            lblDurum.AutoSize = true;
            lblDurum.Location = new Point(705, 149);
            lblDurum.Margin = new Padding(4, 0, 4, 0);
            lblDurum.Name = "lblDurum";
            lblDurum.Size = new Size(0, 22);
            lblDurum.TabIndex = 0;
            // 
            // dgvKitaplar
            // 
            dgvKitaplar.BackgroundColor = SystemColors.ActiveBorder;
            dgvKitaplar.BorderStyle = BorderStyle.Fixed3D;
            dgvKitaplar.CellBorderStyle = DataGridViewCellBorderStyle.Sunken;
            dgvKitaplar.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvKitaplar.Location = new Point(12, 174);
            dgvKitaplar.Name = "dgvKitaplar";
            dgvKitaplar.RowHeadersWidth = 51;
            dgvKitaplar.RowTemplate.Height = 29;
            dgvKitaplar.Size = new Size(325, 347);
            dgvKitaplar.TabIndex = 3;
            dgvKitaplar.CellEndEdit += dgvKitaplar_CellEndEdit;
            dgvKitaplar.SelectionChanged += dgvKitaplar_SelectionChanged;
            // 
            // dgvYazarlar
            // 
            dgvYazarlar.BackgroundColor = SystemColors.ActiveBorder;
            dgvYazarlar.BorderStyle = BorderStyle.Fixed3D;
            dgvYazarlar.CellBorderStyle = DataGridViewCellBorderStyle.Sunken;
            dgvYazarlar.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvYazarlar.Location = new Point(343, 174);
            dgvYazarlar.Name = "dgvYazarlar";
            dgvYazarlar.RowHeadersWidth = 51;
            dgvYazarlar.RowTemplate.Height = 29;
            dgvYazarlar.Size = new Size(339, 347);
            dgvYazarlar.TabIndex = 3;
            dgvYazarlar.CellEndEdit += dgvYazarlar_CellEndEdit;
            dgvYazarlar.SelectionChanged += dgvYazarlar_SelectionChanged;
            // 
            // dgvKitapYazar
            // 
            dgvKitapYazar.BackgroundColor = SystemColors.ActiveBorder;
            dgvKitapYazar.BorderStyle = BorderStyle.Fixed3D;
            dgvKitapYazar.CellBorderStyle = DataGridViewCellBorderStyle.Sunken;
            dgvKitapYazar.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvKitapYazar.Location = new Point(688, 174);
            dgvKitapYazar.Name = "dgvKitapYazar";
            dgvKitapYazar.RowHeadersWidth = 51;
            dgvKitapYazar.RowTemplate.Height = 29;
            dgvKitapYazar.Size = new Size(353, 347);
            dgvKitapYazar.TabIndex = 3;
            // 
            // button1
            // 
            button1.Location = new Point(545, 12);
            button1.Name = "button1";
            button1.Size = new Size(225, 65);
            button1.TabIndex = 4;
            button1.Text = "KİTAPLA YAZARI BAĞDAŞTIR";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label5
            // 
            label5.BackColor = Color.IndianRed;
            label5.Font = new Font("Times New Roman", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(776, 12);
            label5.Name = "label5";
            label5.Size = new Size(265, 66);
            label5.TabIndex = 5;
            label5.Text = "Kitaplar veya Yazarlar tablolarında Hücrelere tıklayarak düzenleme yapabilirsiniz. Satır seçerek silme işlemi yapabilirsiniz";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnKitapSil
            // 
            btnKitapSil.Location = new Point(115, 117);
            btnKitapSil.Name = "btnKitapSil";
            btnKitapSil.Size = new Size(110, 29);
            btnKitapSil.TabIndex = 6;
            btnKitapSil.Text = "KİTAP SİL";
            btnKitapSil.UseVisualStyleBackColor = true;
            btnKitapSil.Click += btnKitapSil_Click;
            // 
            // btnYazarSil
            // 
            btnYazarSil.Location = new Point(445, 117);
            btnYazarSil.Name = "btnYazarSil";
            btnYazarSil.Size = new Size(126, 29);
            btnYazarSil.TabIndex = 7;
            btnYazarSil.Text = "YAZAR SİL";
            btnYazarSil.UseVisualStyleBackColor = true;
            btnYazarSil.Click += btnYazarSil_Click;
            // 
            // btnXdelete
            // 
            btnXdelete.Location = new Point(705, 117);
            btnXdelete.Name = "btnXdelete";
            btnXdelete.Size = new Size(267, 29);
            btnXdelete.TabIndex = 8;
            btnXdelete.Text = "KİTAP YAZAR BAĞI KOPAR";
            btnXdelete.UseVisualStyleBackColor = true;
            btnXdelete.Click += btnXdelete_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveBorder;
            ClientSize = new Size(1053, 533);
            Controls.Add(btnXdelete);
            Controls.Add(btnYazarSil);
            Controls.Add(btnKitapSil);
            Controls.Add(label5);
            Controls.Add(button1);
            Controls.Add(dgvKitapYazar);
            Controls.Add(dgvYazarlar);
            Controls.Add(dgvKitaplar);
            Controls.Add(btnYazarEkle);
            Controls.Add(lblDurum);
            Controls.Add(btnKitapEkle);
            Controls.Add(label4);
            Controls.Add(txtYazarAdı);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtKitapAdı);
            Controls.Add(label1);
            Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "Form1";
            Text = "KİTAPLAR VE YAZARLAR";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgvKitaplar).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvYazarlar).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvKitapYazar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtKitapAdı;
        private Button btnKitapEkle;
        private Label label2;
        private TextBox txtYazarAdı;
        private Button btnYazarEkle;
        private Label label3;
        private Label label4;
        private Label lblDurum;
        private DataGridView dgvKitaplar;
        private DataGridView dgvYazarlar;
        private DataGridView dgvKitapYazar;
        private Button button1;
        private Label label5;
        private Button btnKitapSil;
        private Button btnYazarSil;
        private Button btnXdelete;
    }
}