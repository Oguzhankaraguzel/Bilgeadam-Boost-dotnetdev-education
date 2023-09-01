namespace KisiRehberiDB
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
            dgvRehber = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtAd = new TextBox();
            txtSoyad = new TextBox();
            txtTelNo = new TextBox();
            txtArama = new TextBox();
            btnEkle = new Button();
            btnSil = new Button();
            label5 = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dgvRehber).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // dgvRehber
            // 
            dgvRehber.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvRehber.BackgroundColor = SystemColors.ActiveBorder;
            dgvRehber.BorderStyle = BorderStyle.Fixed3D;
            dgvRehber.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRehber.Location = new Point(13, 157);
            dgvRehber.Margin = new Padding(4);
            dgvRehber.Name = "dgvRehber";
            dgvRehber.RowHeadersWidth = 51;
            dgvRehber.RowTemplate.Height = 29;
            dgvRehber.Size = new Size(811, 408);
            dgvRehber.TabIndex = 0;
            dgvRehber.CellEndEdit += dgvRehber_CellEndEdit;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(179, 15);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(38, 22);
            label1.TabIndex = 1;
            label1.Text = "AD";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(142, 51);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(75, 22);
            label2.TabIndex = 1;
            label2.Text = "SOYAD";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(14, 87);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(203, 22);
            label3.TabIndex = 1;
            label3.Text = "TELEFON NUMARASI";
            // 
            // txtAd
            // 
            txtAd.Location = new Point(224, 12);
            txtAd.Name = "txtAd";
            txtAd.Size = new Size(207, 30);
            txtAd.TabIndex = 2;
            // 
            // txtSoyad
            // 
            txtSoyad.Location = new Point(224, 48);
            txtSoyad.Name = "txtSoyad";
            txtSoyad.Size = new Size(207, 30);
            txtSoyad.TabIndex = 2;
            // 
            // txtTelNo
            // 
            txtTelNo.Location = new Point(224, 84);
            txtTelNo.Name = "txtTelNo";
            txtTelNo.Size = new Size(207, 30);
            txtTelNo.TabIndex = 2;
            // 
            // txtArama
            // 
            txtArama.Location = new Point(224, 120);
            txtArama.Name = "txtArama";
            txtArama.Size = new Size(207, 30);
            txtArama.TabIndex = 2;
            txtArama.TextChanged += txtArama_TextChanged;
            // 
            // btnEkle
            // 
            btnEkle.Location = new Point(437, 12);
            btnEkle.Name = "btnEkle";
            btnEkle.Size = new Size(154, 66);
            btnEkle.TabIndex = 3;
            btnEkle.Text = "KİŞİ EKLE";
            btnEkle.UseVisualStyleBackColor = true;
            btnEkle.Click += btnEkle_Click;
            // 
            // btnSil
            // 
            btnSil.Location = new Point(437, 84);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(154, 66);
            btnSil.TabIndex = 3;
            btnSil.Text = "KİŞİ SİL";
            btnSil.UseVisualStyleBackColor = true;
            btnSil.Click += btnSil_Click;
            // 
            // label5
            // 
            label5.BackColor = Color.Silver;
            label5.BorderStyle = BorderStyle.Fixed3D;
            label5.ForeColor = Color.Sienna;
            label5.Location = new Point(598, 15);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(226, 135);
            label5.TabIndex = 1;
            label5.Text = "HÜCRELERE TIKLAYARAK HÜCRE DÜZENLEME MODUNA GEÇEBİLİRSİNİZ.";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources._3142_png_860_removebg_preview;
            pictureBox1.Location = new Point(178, 112);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(39, 38);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveBorder;
            ClientSize = new Size(837, 578);
            Controls.Add(pictureBox1);
            Controls.Add(btnSil);
            Controls.Add(btnEkle);
            Controls.Add(txtArama);
            Controls.Add(txtTelNo);
            Controls.Add(txtSoyad);
            Controls.Add(txtAd);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dgvRehber);
            Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "Form1";
            Text = "TELEFON REHBERİ";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgvRehber).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvRehber;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtAd;
        private TextBox txtSoyad;
        private TextBox txtTelNo;
        private TextBox txtArama;
        private Button btnEkle;
        private Button btnSil;
        private Label label5;
        private PictureBox pictureBox1;
    }
}