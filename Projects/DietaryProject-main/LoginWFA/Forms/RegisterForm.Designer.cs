namespace LoginWFA.Forms
{
    partial class RegisterForm
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
            components = new System.ComponentModel.Container();
            txtCode = new TextBox();
            btnOk = new Button();
            timer1 = new System.Windows.Forms.Timer(components);
            lblCounter = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // txtCode
            // 
            txtCode.BackColor = Color.LightGray;
            txtCode.BorderStyle = BorderStyle.None;
            txtCode.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtCode.ForeColor = Color.Gray;
            txtCode.Location = new Point(138, 99);
            txtCode.Margin = new Padding(3, 4, 3, 4);
            txtCode.Multiline = true;
            txtCode.Name = "txtCode";
            txtCode.Size = new Size(206, 47);
            txtCode.TabIndex = 31;
            // 
            // btnOk
            // 
            btnOk.BackColor = Color.Black;
            btnOk.FlatStyle = FlatStyle.Popup;
            btnOk.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnOk.ForeColor = Color.White;
            btnOk.Location = new Point(138, 188);
            btnOk.Margin = new Padding(3, 4, 3, 4);
            btnOk.Name = "btnOk";
            btnOk.Size = new Size(206, 51);
            btnOk.TabIndex = 32;
            btnOk.Text = "Ok";
            btnOk.UseVisualStyleBackColor = false;
            btnOk.Click += btnOk_Click;
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // lblCounter
            // 
            lblCounter.AutoSize = true;
            lblCounter.Font = new Font("Century Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lblCounter.ForeColor = Color.Gainsboro;
            lblCounter.Location = new Point(215, 243);
            lblCounter.Name = "lblCounter";
            lblCounter.Size = new Size(68, 37);
            lblCounter.TabIndex = 33;
            lblCounter.Text = "180";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.Gainsboro;
            label1.Location = new Point(141, 35);
            label1.Name = "label1";
            label1.Size = new Size(203, 28);
            label1.TabIndex = 34;
            label1.Text = "Please Enter The Code";
            // 
            // RegisterForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(56, 16, 10);
            ClientSize = new Size(482, 295);
            Controls.Add(label1);
            Controls.Add(lblCounter);
            Controls.Add(btnOk);
            Controls.Add(txtCode);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "RegisterForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "RegistroForm";
            Load += RegistroForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtCode;
        private Button btnOk;
        private System.Windows.Forms.Timer timer1;
        private Label lblCounter;
        private Label label1;
    }
}