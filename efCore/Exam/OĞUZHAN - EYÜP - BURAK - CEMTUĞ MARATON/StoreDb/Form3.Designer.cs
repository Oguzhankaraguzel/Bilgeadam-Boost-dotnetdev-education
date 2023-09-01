namespace StoreDb
{
    partial class Form3
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
            label2 = new Label();
            txtNewUN = new TextBox();
            txtNewUP = new TextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(201, 22);
            label1.TabIndex = 0;
            label1.Text = "YENİ KULLANICI ADI";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(99, 44);
            label2.Name = "label2";
            label2.Size = new Size(114, 22);
            label2.TabIndex = 0;
            label2.Text = "YENİ ŞİFRE";
            // 
            // txtNewUN
            // 
            txtNewUN.Location = new Point(219, 7);
            txtNewUN.Name = "txtNewUN";
            txtNewUN.Size = new Size(220, 27);
            txtNewUN.TabIndex = 1;
            // 
            // txtNewUP
            // 
            txtNewUP.Location = new Point(219, 42);
            txtNewUP.Name = "txtNewUP";
            txtNewUP.Size = new Size(220, 27);
            txtNewUP.TabIndex = 2;
            // 
            // button1
            // 
            button1.Location = new Point(445, 7);
            button1.Name = "button1";
            button1.Size = new Size(167, 62);
            button1.TabIndex = 3;
            button1.Text = "OLUŞTUR";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(623, 80);
            ControlBox = false;
            Controls.Add(button1);
            Controls.Add(txtNewUP);
            Controls.Add(txtNewUN);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form3";
            Text = "KULLANICI OLUŞTUR";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtNewUN;
        private TextBox txtNewUP;
        private Button button1;
    }
}