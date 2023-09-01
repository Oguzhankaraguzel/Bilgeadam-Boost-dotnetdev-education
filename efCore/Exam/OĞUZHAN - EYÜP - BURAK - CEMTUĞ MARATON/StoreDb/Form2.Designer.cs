namespace StoreDb
{
    partial class Form2
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
            txtUserName = new TextBox();
            txtUserPassword = new TextBox();
            CreateUser = new LinkLabel();
            btnAcsess = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(13, 9);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(150, 22);
            label1.TabIndex = 0;
            label1.Text = "KULLANICI ADI";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(100, 45);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(63, 22);
            label2.TabIndex = 0;
            label2.Text = "ŞİFRE";
            // 
            // txtUserName
            // 
            txtUserName.Location = new Point(170, 6);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(171, 30);
            txtUserName.TabIndex = 1;
            // 
            // txtUserPassword
            // 
            txtUserPassword.Location = new Point(170, 42);
            txtUserPassword.Name = "txtUserPassword";
            txtUserPassword.Size = new Size(171, 30);
            txtUserPassword.TabIndex = 1;
            // 
            // CreateUser
            // 
            CreateUser.AutoSize = true;
            CreateUser.Location = new Point(347, 42);
            CreateUser.Name = "CreateUser";
            CreateUser.Size = new Size(163, 22);
            CreateUser.TabIndex = 2;
            CreateUser.TabStop = true;
            CreateUser.Text = "HESAP OLUŞTUR";
            CreateUser.LinkClicked += CreateUser_LinkClicked;
            // 
            // btnAcsess
            // 
            btnAcsess.Location = new Point(347, 6);
            btnAcsess.Name = "btnAcsess";
            btnAcsess.Size = new Size(157, 29);
            btnAcsess.TabIndex = 3;
            btnAcsess.Text = "GİRİŞ";
            btnAcsess.UseVisualStyleBackColor = true;
            btnAcsess.Click += btnAcsess_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(11F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(516, 81);
            ControlBox = false;
            Controls.Add(btnAcsess);
            Controls.Add(CreateUser);
            Controls.Add(txtUserPassword);
            Controls.Add(txtUserName);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "Form2";
            Text = "KULLANICI GİRİŞİ";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtUserName;
        private TextBox txtUserPassword;
        private LinkLabel CreateUser;
        private Button btnAcsess;
    }
}