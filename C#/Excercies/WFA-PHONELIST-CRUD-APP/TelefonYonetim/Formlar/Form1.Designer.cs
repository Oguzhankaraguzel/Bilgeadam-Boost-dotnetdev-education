namespace TelefonYonetim
{
    partial class FRMTELEFONYONETIM
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
            this.tELEFONLARToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnsTelDuzenle = new System.Windows.Forms.ToolStripMenuItem();
            this.mnsTelListele = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tELEFONLARToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(11, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(982, 30);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tELEFONLARToolStripMenuItem
            // 
            this.tELEFONLARToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnsTelDuzenle,
            this.mnsTelListele});
            this.tELEFONLARToolStripMenuItem.Name = "tELEFONLARToolStripMenuItem";
            this.tELEFONLARToolStripMenuItem.Size = new System.Drawing.Size(109, 24);
            this.tELEFONLARToolStripMenuItem.Text = "TELEFONLAR";
            // 
            // mnsTelDuzenle
            // 
            this.mnsTelDuzenle.Name = "mnsTelDuzenle";
            this.mnsTelDuzenle.Size = new System.Drawing.Size(250, 26);
            this.mnsTelDuzenle.Text = "TELEFONLARI DÜZENLE";
            this.mnsTelDuzenle.Click += new System.EventHandler(this.mnsTelDuzenle_Click);
            // 
            // mnsTelListele
            // 
            this.mnsTelListele.Name = "mnsTelListele";
            this.mnsTelListele.Size = new System.Drawing.Size(250, 26);
            this.mnsTelListele.Text = "TELEFONLARI LİSTELE";
            this.mnsTelListele.Click += new System.EventHandler(this.mnsTelListele_Click);
            // 
            // FRMTELEFONYONETIM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 653);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Agency FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FRMTELEFONYONETIM";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TELEFON YÖNETİM MERKEZİ";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tELEFONLARToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnsTelDuzenle;
        private System.Windows.Forms.ToolStripMenuItem mnsTelListele;
    }
}

