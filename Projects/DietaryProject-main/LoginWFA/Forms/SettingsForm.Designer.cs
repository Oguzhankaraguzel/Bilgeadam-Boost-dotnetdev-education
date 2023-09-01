namespace LoginWFA
{
    partial class SettingsForm
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
            ibSavePhoto = new FontAwesome.Sharp.IconButton();
            txtPassword1 = new TextBox();
            label2 = new Label();
            txtPassword2 = new TextBox();
            label7 = new Label();
            label3 = new Label();
            btnSaveThePassword = new Button();
            label4 = new Label();
            txtFoodName = new TextBox();
            label5 = new Label();
            grpDietType = new GroupBox();
            rdbNormal = new RadioButton();
            rdbVegetarian = new RadioButton();
            rdbVegan = new RadioButton();
            cblFoodType = new CheckedListBox();
            label6 = new Label();
            label8 = new Label();
            cblMealTime = new CheckedListBox();
            pctFoodPhoto = new PictureBox();
            linkLabel1 = new LinkLabel();
            label9 = new Label();
            cbxFoodNameList = new ComboBox();
            label10 = new Label();
            btnDeleteFood = new Button();
            nudCalorie = new NumericUpDown();
            label11 = new Label();
            btnAddFood = new Button();
            btnChangePersonelInformation = new Button();
            label12 = new Label();
            grpDietType.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pctFoodPhoto).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudCalorie).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Gainsboro;
            label1.Location = new Point(30, 9);
            label1.Name = "label1";
            label1.Size = new Size(244, 23);
            label1.TabIndex = 1;
            label1.Text = "Select Your Profil Photo :";
            // 
            // ibSavePhoto
            // 
            ibSavePhoto.IconChar = FontAwesome.Sharp.IconChar.None;
            ibSavePhoto.IconColor = Color.Black;
            ibSavePhoto.IconFont = FontAwesome.Sharp.IconFont.Auto;
            ibSavePhoto.Location = new Point(280, 7);
            ibSavePhoto.Margin = new Padding(3, 4, 3, 4);
            ibSavePhoto.Name = "ibSavePhoto";
            ibSavePhoto.Size = new Size(29, 31);
            ibSavePhoto.TabIndex = 2;
            ibSavePhoto.UseVisualStyleBackColor = true;
            ibSavePhoto.Click += ibSavePhoto_Click_1;
            // 
            // txtPassword1
            // 
            txtPassword1.BackColor = Color.LightGray;
            txtPassword1.BorderStyle = BorderStyle.None;
            txtPassword1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtPassword1.ForeColor = Color.Gray;
            txtPassword1.Location = new Point(30, 114);
            txtPassword1.Margin = new Padding(3, 4, 3, 4);
            txtPassword1.Multiline = true;
            txtPassword1.Name = "txtPassword1";
            txtPassword1.Size = new Size(249, 47);
            txtPassword1.TabIndex = 3;
            txtPassword1.Text = "Password";
            txtPassword1.TextChanged += txtPassword2_TextChanged_1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.Gainsboro;
            label2.Location = new Point(30, 76);
            label2.Name = "label2";
            label2.Size = new Size(240, 23);
            label2.TabIndex = 1;
            label2.Text = "Change Your Password ";
            // 
            // txtPassword2
            // 
            txtPassword2.BackColor = Color.LightGray;
            txtPassword2.BorderStyle = BorderStyle.None;
            txtPassword2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtPassword2.ForeColor = Color.Gray;
            txtPassword2.Location = new Point(30, 169);
            txtPassword2.Margin = new Padding(3, 4, 3, 4);
            txtPassword2.Multiline = true;
            txtPassword2.Name = "txtPassword2";
            txtPassword2.Size = new Size(249, 47);
            txtPassword2.TabIndex = 3;
            txtPassword2.Text = "Re-Password";
            txtPassword2.TextChanged += txtPassword1_TextChanged_1;
            // 
            // label7
            // 
            label7.BackColor = Color.White;
            label7.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = Color.Gainsboro;
            label7.Location = new Point(30, 54);
            label7.Name = "label7";
            label7.Size = new Size(822, 1);
            label7.TabIndex = 9;
            label7.Text = "Ready to Login";
            // 
            // label3
            // 
            label3.BackColor = Color.White;
            label3.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.Gainsboro;
            label3.Location = new Point(30, 292);
            label3.Name = "label3";
            label3.Size = new Size(822, 1);
            label3.TabIndex = 9;
            label3.Text = "Ready to Login";
            // 
            // btnSaveThePassword
            // 
            btnSaveThePassword.BackColor = Color.Gainsboro;
            btnSaveThePassword.FlatStyle = FlatStyle.Popup;
            btnSaveThePassword.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnSaveThePassword.ForeColor = Color.Black;
            btnSaveThePassword.Location = new Point(30, 224);
            btnSaveThePassword.Margin = new Padding(3, 4, 3, 4);
            btnSaveThePassword.Name = "btnSaveThePassword";
            btnSaveThePassword.Size = new Size(249, 51);
            btnSaveThePassword.TabIndex = 10;
            btnSaveThePassword.Text = "SAVE";
            btnSaveThePassword.UseVisualStyleBackColor = false;
            btnSaveThePassword.Click += btnSaveThePassword_Click_1;
            // 
            // label4
            // 
            label4.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.Gainsboro;
            label4.Location = new Point(280, 304);
            label4.Name = "label4";
            label4.Size = new Size(246, 23);
            label4.TabIndex = 1;
            label4.Text = "ADD A FOOD";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtFoodName
            // 
            txtFoodName.BackColor = Color.LightGray;
            txtFoodName.BorderStyle = BorderStyle.None;
            txtFoodName.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtFoodName.ForeColor = Color.Gray;
            txtFoodName.Location = new Point(30, 387);
            txtFoodName.Margin = new Padding(3, 4, 3, 4);
            txtFoodName.Name = "txtFoodName";
            txtFoodName.Size = new Size(249, 32);
            txtFoodName.TabIndex = 3;
            txtFoodName.TextChanged += txtPassword1_TextChanged_1;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.Gainsboro;
            label5.Location = new Point(28, 360);
            label5.Name = "label5";
            label5.Size = new Size(132, 23);
            label5.TabIndex = 1;
            label5.Text = "FOOD NAME";
            // 
            // grpDietType
            // 
            grpDietType.Controls.Add(rdbNormal);
            grpDietType.Controls.Add(rdbVegetarian);
            grpDietType.Controls.Add(rdbVegan);
            grpDietType.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            grpDietType.ForeColor = Color.Gainsboro;
            grpDietType.Location = new Point(285, 360);
            grpDietType.Name = "grpDietType";
            grpDietType.Size = new Size(204, 220);
            grpDietType.TabIndex = 11;
            grpDietType.TabStop = false;
            grpDietType.Text = "What diet is this dish suitable for?";
            // 
            // rdbNormal
            // 
            rdbNormal.AutoSize = true;
            rdbNormal.Location = new Point(6, 142);
            rdbNormal.Name = "rdbNormal";
            rdbNormal.Size = new Size(115, 32);
            rdbNormal.TabIndex = 0;
            rdbNormal.TabStop = true;
            rdbNormal.Text = "NORMAL";
            rdbNormal.UseVisualStyleBackColor = true;
            // 
            // rdbVegetarian
            // 
            rdbVegetarian.AutoSize = true;
            rdbVegetarian.Location = new Point(6, 104);
            rdbVegetarian.Name = "rdbVegetarian";
            rdbVegetarian.Size = new Size(146, 32);
            rdbVegetarian.TabIndex = 0;
            rdbVegetarian.TabStop = true;
            rdbVegetarian.Text = "VEGETARIAN";
            rdbVegetarian.UseVisualStyleBackColor = true;
            // 
            // rdbVegan
            // 
            rdbVegan.AutoSize = true;
            rdbVegan.Location = new Point(6, 66);
            rdbVegan.Name = "rdbVegan";
            rdbVegan.Size = new Size(97, 32);
            rdbVegan.TabIndex = 0;
            rdbVegan.TabStop = true;
            rdbVegan.Text = "VEGAN";
            rdbVegan.UseVisualStyleBackColor = true;
            // 
            // cblFoodType
            // 
            cblFoodType.BackColor = Color.FromArgb(26, 26, 26);
            cblFoodType.BorderStyle = BorderStyle.None;
            cblFoodType.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            cblFoodType.ForeColor = Color.Gainsboro;
            cblFoodType.FormattingEnabled = true;
            cblFoodType.Items.AddRange(new object[] { "MainCourse", "SideMeal", "Soup ", "grain", "ForBreakfast", "Snack", "Drink", "Salad", "Desert", "Fruit" });
            cblFoodType.Location = new Point(495, 387);
            cblFoodType.Name = "cblFoodType";
            cblFoodType.Size = new Size(209, 189);
            cblFoodType.TabIndex = 12;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.Gainsboro;
            label6.Location = new Point(495, 360);
            label6.Name = "label6";
            label6.Size = new Size(209, 23);
            label6.TabIndex = 1;
            label6.Text = "WHAT TYPE OF FOOD";
            // 
            // label8
            // 
            label8.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = Color.Gainsboro;
            label8.Location = new Point(710, 360);
            label8.Name = "label8";
            label8.Size = new Size(142, 76);
            label8.TabIndex = 1;
            label8.Text = "Which meals are suitable for?";
            label8.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // cblMealTime
            // 
            cblMealTime.BackColor = Color.FromArgb(26, 26, 26);
            cblMealTime.BorderStyle = BorderStyle.None;
            cblMealTime.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            cblMealTime.ForeColor = Color.Gainsboro;
            cblMealTime.FormattingEnabled = true;
            cblMealTime.Items.AddRange(new object[] { "Breakfast", "Lunch", "Dinner", "Snack" });
            cblMealTime.Location = new Point(710, 433);
            cblMealTime.Name = "cblMealTime";
            cblMealTime.Size = new Size(142, 135);
            cblMealTime.TabIndex = 12;
            // 
            // pctFoodPhoto
            // 
            pctFoodPhoto.Image = Properties.Resources.Food_illustration;
            pctFoodPhoto.Location = new Point(28, 426);
            pctFoodPhoto.Name = "pctFoodPhoto";
            pctFoodPhoto.Size = new Size(248, 105);
            pctFoodPhoto.SizeMode = PictureBoxSizeMode.Zoom;
            pctFoodPhoto.TabIndex = 13;
            pctFoodPhoto.TabStop = false;
            // 
            // linkLabel1
            // 
            linkLabel1.Location = new Point(28, 534);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(251, 46);
            linkLabel1.TabIndex = 14;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "you can choose a photo for the dish you will add";
            linkLabel1.TextAlign = ContentAlignment.MiddleCenter;
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // label9
            // 
            label9.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label9.ForeColor = Color.Gainsboro;
            label9.Location = new Point(28, 703);
            label9.Name = "label9";
            label9.Size = new Size(246, 23);
            label9.TabIndex = 1;
            label9.Text = "DELETE A FOOD";
            label9.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // cbxFoodNameList
            // 
            cbxFoodNameList.FormattingEnabled = true;
            cbxFoodNameList.Location = new Point(317, 698);
            cbxFoodNameList.Name = "cbxFoodNameList";
            cbxFoodNameList.Size = new Size(172, 28);
            cbxFoodNameList.TabIndex = 16;
            // 
            // label10
            // 
            label10.BackColor = Color.White;
            label10.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label10.ForeColor = Color.Gainsboro;
            label10.Location = new Point(30, 694);
            label10.Name = "label10";
            label10.Size = new Size(822, 1);
            label10.TabIndex = 9;
            label10.Text = "Ready to Login";
            // 
            // btnDeleteFood
            // 
            btnDeleteFood.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnDeleteFood.Location = new Point(495, 698);
            btnDeleteFood.Name = "btnDeleteFood";
            btnDeleteFood.Size = new Size(209, 28);
            btnDeleteFood.TabIndex = 17;
            btnDeleteFood.Text = "DELETE";
            btnDeleteFood.UseVisualStyleBackColor = true;
            btnDeleteFood.Click += btnDeleteFood_Click;
            // 
            // nudCalorie
            // 
            nudCalorie.DecimalPlaces = 1;
            nudCalorie.Location = new Point(317, 628);
            nudCalorie.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            nudCalorie.Name = "nudCalorie";
            nudCalorie.Size = new Size(172, 27);
            nudCalorie.TabIndex = 18;
            nudCalorie.TextAlign = HorizontalAlignment.Center;
            nudCalorie.ThousandsSeparator = true;
            nudCalorie.Value = new decimal(new int[] { 100, 0, 0, 0 });
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label11.ForeColor = Color.Gainsboro;
            label11.Location = new Point(30, 632);
            label11.Name = "label11";
            label11.Size = new Size(272, 23);
            label11.TabIndex = 1;
            label11.Text = "FOOD CALORIE PER 100 GR";
            // 
            // btnAddFood
            // 
            btnAddFood.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnAddFood.Location = new Point(495, 626);
            btnAddFood.Name = "btnAddFood";
            btnAddFood.Size = new Size(209, 29);
            btnAddFood.TabIndex = 19;
            btnAddFood.Text = "ADD";
            btnAddFood.UseVisualStyleBackColor = true;
            btnAddFood.Click += btnAddFood_Click;
            // 
            // btnChangePersonelInformation
            // 
            btnChangePersonelInformation.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnChangePersonelInformation.Location = new Point(538, 114);
            btnChangePersonelInformation.Name = "btnChangePersonelInformation";
            btnChangePersonelInformation.Size = new Size(249, 51);
            btnChangePersonelInformation.TabIndex = 20;
            btnChangePersonelInformation.Text = "CHANGE";
            btnChangePersonelInformation.UseVisualStyleBackColor = true;
            btnChangePersonelInformation.Click += btnChangePersonelInformation_Click;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label12.ForeColor = Color.Gainsboro;
            label12.Location = new Point(495, 76);
            label12.Name = "label12";
            label12.Size = new Size(343, 23);
            label12.TabIndex = 1;
            label12.Text = "Change Your Personel Information";
            // 
            // SettingsForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(26, 26, 26);
            ClientSize = new Size(914, 800);
            Controls.Add(btnChangePersonelInformation);
            Controls.Add(btnAddFood);
            Controls.Add(nudCalorie);
            Controls.Add(btnDeleteFood);
            Controls.Add(cbxFoodNameList);
            Controls.Add(linkLabel1);
            Controls.Add(pctFoodPhoto);
            Controls.Add(cblMealTime);
            Controls.Add(cblFoodType);
            Controls.Add(grpDietType);
            Controls.Add(btnSaveThePassword);
            Controls.Add(label10);
            Controls.Add(label3);
            Controls.Add(label7);
            Controls.Add(txtFoodName);
            Controls.Add(txtPassword2);
            Controls.Add(txtPassword1);
            Controls.Add(ibSavePhoto);
            Controls.Add(label9);
            Controls.Add(label4);
            Controls.Add(label8);
            Controls.Add(label11);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label12);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "SettingsForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "SettingsForm";
            Load += SettingsForm_Load;
            grpDietType.ResumeLayout(false);
            grpDietType.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pctFoodPhoto).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudCalorie).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private FontAwesome.Sharp.IconButton ibSavePhoto;
        private TextBox txtPassword1;
        private Label label2;
        private TextBox txtPassword2;
        private Label label7;
        private Label label3;
        private Button btnSaveThePassword;
        private Label label4;
        private TextBox txtFoodName;
        private Label label5;
        private GroupBox grpDietType;
        private CheckedListBox cblFoodType;
        private Label label6;
        private Label label8;
        private CheckedListBox cblMealTime;
        private PictureBox pctFoodPhoto;
        private LinkLabel linkLabel1;
        private Label label9;
        private ComboBox cbxFoodNameList;
        private Label label10;
        private Button btnDeleteFood;
        private NumericUpDown nudCalorie;
        private Label label11;
        private Button btnAddFood;
        private RadioButton rdbNormal;
        private RadioButton rdbVegetarian;
        private RadioButton rdbVegan;
        private Button btnChangePersonelInformation;
        private Label label12;
    }
}