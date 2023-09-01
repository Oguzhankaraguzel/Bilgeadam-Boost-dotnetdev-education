namespace entityfrmw
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
            dgvCompany = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            txtID = new TextBox();
            txtCompanyName = new TextBox();
            btnEkle = new Button();
            btnSil = new Button();
            btnGuncelle = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvCompany).BeginInit();
            SuspendLayout();
            // 
            // dgvCompany
            // 
            dgvCompany.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvCompany.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCompany.Location = new Point(12, 151);
            dgvCompany.Name = "dgvCompany";
            dgvCompany.RowHeadersWidth = 51;
            dgvCompany.RowTemplate.Height = 29;
            dgvCompany.Size = new Size(1176, 467);
            dgvCompany.TabIndex = 0;
            dgvCompany.CellEndEdit += dgvCompany_CellEndEdit;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(126, 18);
            label1.Name = "label1";
            label1.Size = new Size(33, 28);
            label1.TabIndex = 1;
            label1.Text = "ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(40, 75);
            label2.Name = "label2";
            label2.Size = new Size(119, 28);
            label2.TabIndex = 1;
            label2.Text = "ŞİRKET ADI";
            // 
            // txtID
            // 
            txtID.Location = new Point(165, 12);
            txtID.Name = "txtID";
            txtID.Size = new Size(382, 34);
            txtID.TabIndex = 2;
            // 
            // txtCompanyName
            // 
            txtCompanyName.Location = new Point(165, 69);
            txtCompanyName.Name = "txtCompanyName";
            txtCompanyName.Size = new Size(382, 34);
            txtCompanyName.TabIndex = 2;
            // 
            // btnEkle
            // 
            btnEkle.Location = new Point(553, 12);
            btnEkle.Name = "btnEkle";
            btnEkle.Size = new Size(163, 91);
            btnEkle.TabIndex = 3;
            btnEkle.Text = "EKLE";
            btnEkle.UseVisualStyleBackColor = true;
            btnEkle.Click += btnEkle_Click;
            // 
            // btnSil
            // 
            btnSil.Location = new Point(722, 12);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(175, 91);
            btnSil.TabIndex = 4;
            btnSil.Text = "SİL";
            btnSil.UseVisualStyleBackColor = true;
            btnSil.Click += btnSil_Click;
            // 
            // btnGuncelle
            // 
            btnGuncelle.Location = new Point(903, 12);
            btnGuncelle.Name = "btnGuncelle";
            btnGuncelle.Size = new Size(194, 91);
            btnGuncelle.TabIndex = 5;
            btnGuncelle.Text = "GÜNCELLE";
            btnGuncelle.UseVisualStyleBackColor = true;
            btnGuncelle.Click += btnGuncelle_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(12F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1200, 630);
            Controls.Add(btnGuncelle);
            Controls.Add(btnSil);
            Controls.Add(btnEkle);
            Controls.Add(txtCompanyName);
            Controls.Add(txtID);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dgvCompany);
            Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgvCompany).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvCompany;
        private Label label1;
        private Label label2;
        private TextBox txtID;
        private TextBox txtCompanyName;
        private Button btnEkle;
        private Button btnSil;
        private Button btnGuncelle;
    }
}