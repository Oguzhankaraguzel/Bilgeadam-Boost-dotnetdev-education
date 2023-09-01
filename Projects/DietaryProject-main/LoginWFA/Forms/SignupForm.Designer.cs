namespace LoginWFA
{
    partial class SignupForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SignupForm));
            label7 = new Label();
            panel1 = new Panel();
            cbxAgree = new CheckBox();
            richTextBox1 = new RichTextBox();
            pctLogo = new PictureBox();
            btnSingUp = new Button();
            txtPassword1 = new TextBox();
            txtEMail = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtUserName = new TextBox();
            txtPassword2 = new TextBox();
            pctExit = new PictureBox();
            pctReturn = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pctLogo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pctExit).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pctReturn).BeginInit();
            SuspendLayout();
            // 
            // label7
            // 
            label7.BackColor = Color.White;
            label7.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = Color.Gainsboro;
            label7.Location = new Point(475, 52);
            label7.Name = "label7";
            label7.Size = new Size(166, 1);
            label7.TabIndex = 19;
            label7.Text = "Ready to Login";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(128, 64, 64);
            panel1.Controls.Add(cbxAgree);
            panel1.Controls.Add(richTextBox1);
            panel1.Controls.Add(pctLogo);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(229, 600);
            panel1.TabIndex = 16;
            // 
            // cbxAgree
            // 
            cbxAgree.Dock = DockStyle.Top;
            cbxAgree.ForeColor = SystemColors.ActiveCaptionText;
            cbxAgree.Location = new Point(0, 559);
            cbxAgree.Name = "cbxAgree";
            cbxAgree.Size = new Size(229, 41);
            cbxAgree.TabIndex = 2;
            cbxAgree.Text = "I agree to the terms of use";
            cbxAgree.UseVisualStyleBackColor = true;
            // 
            // richTextBox1
            // 
            richTextBox1.BackColor = Color.FromArgb(128, 64, 64);
            richTextBox1.BorderStyle = BorderStyle.None;
            richTextBox1.Dock = DockStyle.Top;
            richTextBox1.ForeColor = SystemColors.GradientActiveCaption;
            richTextBox1.Location = new Point(0, 128);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.ReadOnly = true;
            richTextBox1.Size = new Size(229, 431);
            richTextBox1.TabIndex = 1;
            richTextBox1.Text = resources.GetString("richTextBox1.Text");
            // 
            // pctLogo
            // 
            pctLogo.Dock = DockStyle.Top;
            pctLogo.Image = Properties.Resources.Logo;
            pctLogo.Location = new Point(0, 0);
            pctLogo.Name = "pctLogo";
            pctLogo.Size = new Size(229, 128);
            pctLogo.SizeMode = PictureBoxSizeMode.Zoom;
            pctLogo.TabIndex = 0;
            pctLogo.TabStop = false;
            // 
            // btnSingUp
            // 
            btnSingUp.BackColor = Color.Black;
            btnSingUp.FlatStyle = FlatStyle.Popup;
            btnSingUp.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnSingUp.ForeColor = Color.White;
            btnSingUp.Location = new Point(432, 536);
            btnSingUp.Margin = new Padding(3, 4, 3, 4);
            btnSingUp.Name = "btnSingUp";
            btnSingUp.Size = new Size(249, 51);
            btnSingUp.TabIndex = 5;
            btnSingUp.Text = "Sign Up";
            btnSingUp.UseVisualStyleBackColor = false;
            btnSingUp.Click += btnSingUp_Click;
            // 
            // txtPassword1
            // 
            txtPassword1.BackColor = Color.LightGray;
            txtPassword1.BorderStyle = BorderStyle.None;
            txtPassword1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtPassword1.ForeColor = Color.Gray;
            txtPassword1.Location = new Point(432, 352);
            txtPassword1.Margin = new Padding(3, 4, 3, 4);
            txtPassword1.Multiline = true;
            txtPassword1.Name = "txtPassword1";
            txtPassword1.Size = new Size(249, 47);
            txtPassword1.TabIndex = 3;
            txtPassword1.Text = "Password";
            txtPassword1.TextChanged += txtPassword1_TextChanged;
            // 
            // txtEMail
            // 
            txtEMail.BackColor = Color.LightGray;
            txtEMail.BorderStyle = BorderStyle.None;
            txtEMail.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtEMail.ForeColor = Color.Gray;
            txtEMail.Location = new Point(432, 126);
            txtEMail.Margin = new Padding(3, 4, 3, 4);
            txtEMail.Multiline = true;
            txtEMail.Name = "txtEMail";
            txtEMail.Size = new Size(249, 47);
            txtEMail.TabIndex = 1;
            txtEMail.Text = "name@gmail.com";
            txtEMail.TextChanged += txtEMail_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.Gainsboro;
            label3.Location = new Point(432, 308);
            label3.Name = "label3";
            label3.Size = new Size(87, 19);
            label3.TabIndex = 10;
            label3.Text = "Password";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.Gainsboro;
            label2.Location = new Point(432, 82);
            label2.Name = "label2";
            label2.Size = new Size(59, 19);
            label2.TabIndex = 11;
            label2.Text = "E-Mail";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Gainsboro;
            label1.Location = new Point(475, 9);
            label1.Name = "label1";
            label1.Size = new Size(175, 23);
            label1.TabIndex = 12;
            label1.Text = "Ready to Sign up";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.Gainsboro;
            label4.Location = new Point(432, 195);
            label4.Name = "label4";
            label4.Size = new Size(99, 19);
            label4.TabIndex = 11;
            label4.Text = "User Name";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.Gainsboro;
            label5.Location = new Point(432, 422);
            label5.Name = "label5";
            label5.Size = new Size(115, 19);
            label5.TabIndex = 10;
            label5.Text = "Re-Password";
            // 
            // txtUserName
            // 
            txtUserName.BackColor = Color.LightGray;
            txtUserName.BorderStyle = BorderStyle.None;
            txtUserName.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtUserName.ForeColor = Color.Gray;
            txtUserName.Location = new Point(432, 239);
            txtUserName.Margin = new Padding(3, 4, 3, 4);
            txtUserName.Multiline = true;
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(249, 47);
            txtUserName.TabIndex = 2;
            txtUserName.Text = "Username";
            txtUserName.TextChanged += txtUserName_TextChanged;
            // 
            // txtPassword2
            // 
            txtPassword2.BackColor = Color.LightGray;
            txtPassword2.BorderStyle = BorderStyle.None;
            txtPassword2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtPassword2.ForeColor = Color.Gray;
            txtPassword2.Location = new Point(432, 466);
            txtPassword2.Margin = new Padding(3, 4, 3, 4);
            txtPassword2.Multiline = true;
            txtPassword2.Name = "txtPassword2";
            txtPassword2.Size = new Size(249, 47);
            txtPassword2.TabIndex = 4;
            txtPassword2.Text = "Re-Password";
            txtPassword2.TextChanged += txtPassword2_TextChanged;
            // 
            // pctExit
            // 
            pctExit.Image = Properties.Resources.closeicon_removebg_preview;
            pctExit.Location = new Point(863, 0);
            pctExit.Margin = new Padding(3, 4, 3, 4);
            pctExit.Name = "pctExit";
            pctExit.Size = new Size(54, 43);
            pctExit.SizeMode = PictureBoxSizeMode.StretchImage;
            pctExit.TabIndex = 20;
            pctExit.TabStop = false;
            pctExit.Click += pctExit_Click;
            // 
            // pctReturn
            // 
            pctReturn.Image = (Image)resources.GetObject("pctReturn.Image");
            pctReturn.Location = new Point(235, 0);
            pctReturn.Margin = new Padding(3, 4, 3, 4);
            pctReturn.Name = "pctReturn";
            pctReturn.Size = new Size(54, 43);
            pctReturn.SizeMode = PictureBoxSizeMode.StretchImage;
            pctReturn.TabIndex = 20;
            pctReturn.TabStop = false;
            pctReturn.Click += pctReturn_Click;
            // 
            // SignupForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(26, 26, 26);
            ClientSize = new Size(914, 600);
            Controls.Add(pctReturn);
            Controls.Add(pctExit);
            Controls.Add(label7);
            Controls.Add(panel1);
            Controls.Add(btnSingUp);
            Controls.Add(txtPassword2);
            Controls.Add(txtUserName);
            Controls.Add(txtPassword1);
            Controls.Add(label5);
            Controls.Add(txtEMail);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "SignupForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SignupForm";
            Load += SignupForm_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pctLogo).EndInit();
            ((System.ComponentModel.ISupportInitialize)pctExit).EndInit();
            ((System.ComponentModel.ISupportInitialize)pctReturn).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label7;
        private Panel panel1;
        private Button btnSingUp;
        private TextBox txtPassword1;
        private TextBox txtEMail;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label label4;
        private Label label5;
        private TextBox txtUserName;
        private TextBox txtPassword2;
        private PictureBox pctExit;
        private PictureBox pctReturn;
        private CheckBox cbxAgree;
        private RichTextBox richTextBox1;
        private PictureBox pctLogo;
    }
}