namespace LoginWFA
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            lblilk = new Label();
            label2 = new Label();
            txtUserNameOrEMail = new TextBox();
            button1 = new Button();
            label3 = new Label();
            label4 = new Label();
            txtPassword = new TextBox();
            button2 = new Button();
            panel1 = new Panel();
            label1 = new Label();
            pctCatPicture = new PictureBox();
            pctLogo = new PictureBox();
            label5 = new Label();
            label6 = new Label();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            label7 = new Label();
            pictureBox3 = new PictureBox();
            checkBox1 = new CheckBox();
            pictureBox4 = new PictureBox();
            pictureBox5 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pctCatPicture).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pctLogo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            SuspendLayout();
            // 
            // lblilk
            // 
            lblilk.AutoSize = true;
            lblilk.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblilk.ForeColor = Color.Gainsboro;
            lblilk.Location = new Point(357, 85);
            lblilk.Name = "lblilk";
            lblilk.Size = new Size(156, 23);
            lblilk.TabIndex = 1;
            lblilk.Text = "Ready to Login";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.Gainsboro;
            label2.Location = new Point(296, 157);
            label2.Name = "label2";
            label2.Size = new Size(175, 19);
            label2.TabIndex = 1;
            label2.Text = "E-Mail or User Name";
            // 
            // txtUserNameOrEMail
            // 
            txtUserNameOrEMail.BackColor = Color.LightGray;
            txtUserNameOrEMail.BorderStyle = BorderStyle.None;
            txtUserNameOrEMail.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtUserNameOrEMail.ForeColor = Color.Gray;
            txtUserNameOrEMail.Location = new Point(296, 197);
            txtUserNameOrEMail.Margin = new Padding(3, 4, 3, 4);
            txtUserNameOrEMail.Multiline = true;
            txtUserNameOrEMail.Name = "txtUserNameOrEMail";
            txtUserNameOrEMail.Size = new Size(249, 47);
            txtUserNameOrEMail.TabIndex = 1;
            txtUserNameOrEMail.Text = "Username";
            txtUserNameOrEMail.TextChanged += txtUserNameOrEMail_TextChanged;
            // 
            // button1
            // 
            button1.BackColor = Color.Black;
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.White;
            button1.Location = new Point(296, 443);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(249, 51);
            button1.TabIndex = 3;
            button1.Text = "Sign In";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.Gainsboro;
            label3.Location = new Point(296, 277);
            label3.Name = "label3";
            label3.Size = new Size(87, 19);
            label3.TabIndex = 1;
            label3.Text = "Password";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.Gainsboro;
            label4.Location = new Point(418, 388);
            label4.Name = "label4";
            label4.Size = new Size(136, 19);
            label4.TabIndex = 1;
            label4.Text = "Show Password";
            // 
            // txtPassword
            // 
            txtPassword.BackColor = Color.LightGray;
            txtPassword.BorderStyle = BorderStyle.None;
            txtPassword.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtPassword.ForeColor = Color.Gray;
            txtPassword.Location = new Point(296, 315);
            txtPassword.Margin = new Padding(3, 4, 3, 4);
            txtPassword.Multiline = true;
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(249, 47);
            txtPassword.TabIndex = 2;
            txtPassword.Text = "Password";
            txtPassword.TextChanged += txtPassword_TextChanged;
            // 
            // button2
            // 
            button2.BackColor = Color.Gainsboro;
            button2.FlatStyle = FlatStyle.Popup;
            button2.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = Color.Black;
            button2.Location = new Point(637, 443);
            button2.Margin = new Padding(3, 4, 3, 4);
            button2.Name = "button2";
            button2.Size = new Size(249, 51);
            button2.TabIndex = 4;
            button2.Text = "Sign Up";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(128, 64, 64);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pctCatPicture);
            panel1.Controls.Add(pctLogo);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(229, 600);
            panel1.TabIndex = 6;
            // 
            // label1
            // 
            label1.ForeColor = SystemColors.GradientActiveCaption;
            label1.Location = new Point(117, 134);
            label1.Name = "label1";
            label1.Size = new Size(112, 143);
            label1.TabIndex = 21;
            label1.Text = "HELLO ,CONTINUE TO STAY FIT";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pctCatPicture
            // 
            pctCatPicture.Image = Properties.Resources.CatPhoto;
            pctCatPicture.Location = new Point(0, 134);
            pctCatPicture.Name = "pctCatPicture";
            pctCatPicture.Size = new Size(111, 146);
            pctCatPicture.SizeMode = PictureBoxSizeMode.Zoom;
            pctCatPicture.TabIndex = 20;
            pctCatPicture.TabStop = false;
            // 
            // pctLogo
            // 
            pctLogo.Dock = DockStyle.Top;
            pctLogo.Image = Properties.Resources.Logo;
            pctLogo.Location = new Point(0, 0);
            pctLogo.Name = "pctLogo";
            pctLogo.Size = new Size(229, 128);
            pctLogo.SizeMode = PictureBoxSizeMode.Zoom;
            pctLogo.TabIndex = 1;
            pctLogo.TabStop = false;
            // 
            // label5
            // 
            label5.BackColor = Color.White;
            label5.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.Gainsboro;
            label5.Location = new Point(586, 92);
            label5.Name = "label5";
            label5.Size = new Size(1, 395);
            label5.TabIndex = 1;
            label5.Text = "Ready to Login";
            // 
            // label6
            // 
            label6.BackColor = Color.Gainsboro;
            label6.Font = new Font("Century Gothic", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.Black;
            label6.Location = new Point(637, 220);
            label6.Name = "label6";
            label6.Size = new Size(249, 99);
            label6.TabIndex = 1;
            label6.Text = "Do you not have an Account ?";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(235, 197);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(54, 47);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(235, 315);
            pictureBox2.Margin = new Padding(3, 4, 3, 4);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(54, 47);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 7;
            pictureBox2.TabStop = false;
            // 
            // label7
            // 
            label7.BackColor = Color.White;
            label7.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = Color.Gainsboro;
            label7.Location = new Point(351, 123);
            label7.Name = "label7";
            label7.Size = new Size(151, 1);
            label7.TabIndex = 8;
            label7.Text = "Ready to Login";
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.closeicon_removebg_preview;
            pictureBox3.Location = new Point(865, 0);
            pictureBox3.Margin = new Padding(3, 4, 3, 4);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(54, 43);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 9;
            pictureBox3.TabStop = false;
            pictureBox3.Click += pictureBox3_Click;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(394, 391);
            checkBox1.Margin = new Padding(3, 4, 3, 4);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(18, 17);
            checkBox1.TabIndex = 10;
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(849, 551);
            pictureBox4.Margin = new Padding(3, 4, 3, 4);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(51, 49);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 12;
            pictureBox4.TabStop = false;
            pictureBox4.Click += pictureBox4_Click;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(791, 551);
            pictureBox5.Margin = new Padding(3, 4, 3, 4);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(51, 49);
            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox5.TabIndex = 12;
            pictureBox5.TabStop = false;
            pictureBox5.Click += pictureBox5_Click;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(26, 26, 26);
            ClientSize = new Size(914, 600);
            Controls.Add(pictureBox5);
            Controls.Add(pictureBox4);
            Controls.Add(checkBox1);
            Controls.Add(pictureBox3);
            Controls.Add(label7);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(panel1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(txtPassword);
            Controls.Add(txtUserNameOrEMail);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label5);
            Controls.Add(lblilk);
            Controls.Add(label6);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pctCatPicture).EndInit();
            ((System.ComponentModel.ISupportInitialize)pctLogo).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblilk;
        private Label label2;
        private TextBox txtUserNameOrEMail;
        private Button button1;
        private Label label3;
        private Label label4;
        private TextBox txtPassword;
        private Button button2;
        private Panel panel1;
        private Label label5;
        private Label label6;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Label label7;
        private PictureBox pictureBox3;
        private CheckBox checkBox1;
        private PictureBox pictureBox4;
        private PictureBox pictureBox5;
        private PictureBox pctLogo;
        private Label label1;
        private PictureBox pctCatPicture;
    }
}