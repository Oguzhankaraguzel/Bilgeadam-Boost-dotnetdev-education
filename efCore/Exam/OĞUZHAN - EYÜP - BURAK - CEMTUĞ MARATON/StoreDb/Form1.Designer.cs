namespace StoreDb
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
            label1 = new Label();
            txtAlbumName = new TextBox();
            btnAlbumAdd = new Button();
            label2 = new Label();
            txtArtistName = new TextBox();
            button1 = new Button();
            dgvAlbums = new DataGridView();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            dgvArtist = new DataGridView();
            no2List = new LinkLabel();
            no3List = new LinkLabel();
            no4List = new LinkLabel();
            no5List = new LinkLabel();
            btnAlbumDelete = new Button();
            btnArtistDelete = new Button();
            button2 = new Button();
            btnAddArtist = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvAlbums).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvArtist).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(26, 9);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(117, 22);
            label1.TabIndex = 0;
            label1.Text = "ALBÜM ADI";
            // 
            // txtAlbumName
            // 
            txtAlbumName.Location = new Point(150, 6);
            txtAlbumName.Name = "txtAlbumName";
            txtAlbumName.Size = new Size(268, 30);
            txtAlbumName.TabIndex = 1;
            // 
            // btnAlbumAdd
            // 
            btnAlbumAdd.Location = new Point(150, 42);
            btnAlbumAdd.Name = "btnAlbumAdd";
            btnAlbumAdd.Size = new Size(268, 29);
            btnAlbumAdd.TabIndex = 2;
            btnAlbumAdd.Text = "ALBÜM EKLE";
            btnAlbumAdd.UseVisualStyleBackColor = true;
            btnAlbumAdd.Click += btnAlbumAdd_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(13, 82);
            label2.Name = "label2";
            label2.Size = new Size(130, 22);
            label2.TabIndex = 3;
            label2.Text = "SANATÇI ADI";
            // 
            // txtArtistName
            // 
            txtArtistName.Location = new Point(150, 77);
            txtArtistName.Name = "txtArtistName";
            txtArtistName.Size = new Size(268, 30);
            txtArtistName.TabIndex = 4;
            // 
            // button1
            // 
            button1.Location = new Point(150, 113);
            button1.Name = "button1";
            button1.Size = new Size(268, 29);
            button1.TabIndex = 5;
            button1.Text = "SANATÇI EKLE";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // dgvAlbums
            // 
            dgvAlbums.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAlbums.Location = new Point(26, 294);
            dgvAlbums.Name = "dgvAlbums";
            dgvAlbums.RowHeadersWidth = 51;
            dgvAlbums.RowTemplate.Height = 29;
            dgvAlbums.Size = new Size(800, 188);
            dgvAlbums.TabIndex = 6;
            dgvAlbums.CellEndEdit += dgvAlbums_CellEndEdit;
            // 
            // label3
            // 
            label3.BackColor = Color.IndianRed;
            label3.Location = new Point(424, 6);
            label3.Name = "label3";
            label3.Size = new Size(306, 136);
            label3.TabIndex = 7;
            label3.Text = "HÜCRELERE TIKLAYARAK HÜCRE DÜZENLEME MODUNA GEÇEBİLİRSİNİZ. ALBÜM EKLERKEN SANATÇI LİSTESİNDEN BİRİSİNİ SEÇMENİZ GEREKİR";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(26, 269);
            label4.Name = "label4";
            label4.Size = new Size(115, 22);
            label4.TabIndex = 8;
            label4.Text = "ALBÜMLER";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(832, 269);
            label5.Name = "label5";
            label5.Size = new Size(130, 22);
            label5.TabIndex = 9;
            label5.Text = "SANATÇILAR";
            // 
            // dgvArtist
            // 
            dgvArtist.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvArtist.Location = new Point(832, 294);
            dgvArtist.Name = "dgvArtist";
            dgvArtist.RowHeadersWidth = 51;
            dgvArtist.RowTemplate.Height = 29;
            dgvArtist.Size = new Size(256, 188);
            dgvArtist.TabIndex = 10;
            dgvArtist.CellEndEdit += dgvArtist_CellEndEdit;
            // 
            // no2List
            // 
            no2List.AutoSize = true;
            no2List.Location = new Point(736, 6);
            no2List.Name = "no2List";
            no2List.Size = new Size(193, 22);
            no2List.TabIndex = 11;
            no2List.TabStop = true;
            no2List.Text = "Satışı durmuş albümler";
            no2List.LinkClicked += no2List_LinkClicked;
            // 
            // no3List
            // 
            no3List.AutoSize = true;
            no3List.Location = new Point(736, 28);
            no3List.Name = "no3List";
            no3List.Size = new Size(230, 22);
            no3List.TabIndex = 12;
            no3List.TabStop = true;
            no3List.Text = "Satışı devam eden albümler";
            no3List.LinkClicked += no3List_LinkClicked;
            // 
            // no4List
            // 
            no4List.AutoSize = true;
            no4List.Location = new Point(736, 50);
            no4List.Name = "no4List";
            no4List.Size = new Size(271, 22);
            no4List.TabIndex = 13;
            no4List.TabStop = true;
            no4List.Text = "Sisteme en son eklenen 10 albüm";
            no4List.LinkClicked += no4List_LinkClicked;
            // 
            // no5List
            // 
            no5List.AutoSize = true;
            no5List.Location = new Point(736, 77);
            no5List.Name = "no5List";
            no5List.Size = new Size(178, 22);
            no5List.TabIndex = 14;
            no5List.TabStop = true;
            no5List.Text = "İndirimdeki albümler";
            no5List.LinkClicked += no5List_LinkClicked;
            // 
            // btnAlbumDelete
            // 
            btnAlbumDelete.Location = new Point(26, 237);
            btnAlbumDelete.Name = "btnAlbumDelete";
            btnAlbumDelete.Size = new Size(123, 29);
            btnAlbumDelete.TabIndex = 15;
            btnAlbumDelete.Text = "ALBÜM SİL";
            btnAlbumDelete.UseVisualStyleBackColor = true;
            btnAlbumDelete.Click += btnAlbumDelete_Click;
            // 
            // btnArtistDelete
            // 
            btnArtistDelete.Location = new Point(832, 237);
            btnArtistDelete.Name = "btnArtistDelete";
            btnArtistDelete.Size = new Size(141, 29);
            btnArtistDelete.TabIndex = 16;
            btnArtistDelete.Text = "SANATÇI SİL";
            btnArtistDelete.UseVisualStyleBackColor = true;
            btnArtistDelete.Click += btnArtistDelete_Click;
            // 
            // button2
            // 
            button2.Location = new Point(155, 237);
            button2.Name = "button2";
            button2.Size = new Size(381, 29);
            button2.TabIndex = 17;
            button2.Text = "SATIŞTAN KALDIR VEYA SATIŞA SUN";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // btnAddArtist
            // 
            btnAddArtist.Location = new Point(542, 237);
            btnAddArtist.Name = "btnAddArtist";
            btnAddArtist.Size = new Size(284, 29);
            btnAddArtist.TabIndex = 18;
            btnAddArtist.Text = "ALBÜME SANATÇI EKLE";
            btnAddArtist.UseVisualStyleBackColor = true;
            btnAddArtist.Click += btnAddArtist_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1100, 494);
            Controls.Add(btnAddArtist);
            Controls.Add(button2);
            Controls.Add(btnArtistDelete);
            Controls.Add(btnAlbumDelete);
            Controls.Add(no5List);
            Controls.Add(no4List);
            Controls.Add(no3List);
            Controls.Add(no2List);
            Controls.Add(dgvArtist);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(dgvAlbums);
            Controls.Add(button1);
            Controls.Add(txtArtistName);
            Controls.Add(label2);
            Controls.Add(btnAlbumAdd);
            Controls.Add(txtAlbumName);
            Controls.Add(label1);
            Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgvAlbums).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvArtist).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtAlbumName;
        private Button btnAlbumAdd;
        private Label label2;
        private TextBox txtArtistName;
        private Button button1;
        private DataGridView dgvAlbums;
        private Label label3;
        private Label label4;
        private Label label5;
        private DataGridView dgvArtist;
        private LinkLabel no2List;
        private LinkLabel no3List;
        private LinkLabel no4List;
        private LinkLabel no5List;
        private Button btnAlbumDelete;
        private Button btnArtistDelete;
        private Button button2;
        private Button btnAddArtist;
    }
}