namespace LoginWFA
{
    partial class MealForm
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
            cbMealTime = new ComboBox();
            btnAddMeal = new Button();
            mcMealTime = new MonthCalendar();
            groupBox1 = new GroupBox();
            dgvAddingFood = new DataGridView();
            btnDeleteAll = new Button();
            btnDelete = new Button();
            btnDone = new Button();
            btnAddFood = new Button();
            nudGram = new NumericUpDown();
            cbFoodType = new ComboBox();
            lblGram = new Label();
            lblFoodType = new Label();
            lblBonApetite = new Label();
            panel1 = new Panel();
            txtFoodCalory = new TextBox();
            lblCaloryCount = new Label();
            lblTotalcal = new Label();
            lblFoodCalory = new Label();
            txtFoodName = new TextBox();
            lblFoodName = new Label();
            panel2 = new Panel();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAddingFood).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudGram).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ButtonFace;
            label1.Location = new Point(10, 24);
            label1.Name = "label1";
            label1.Size = new Size(279, 21);
            label1.TabIndex = 0;
            label1.Text = "You can add by selecting the meal time";
            // 
            // cbMealTime
            // 
            cbMealTime.Location = new Point(10, 47);
            cbMealTime.Margin = new Padding(3, 2, 3, 2);
            cbMealTime.Name = "cbMealTime";
            cbMealTime.Size = new Size(155, 29);
            cbMealTime.TabIndex = 1;
            // 
            // btnAddMeal
            // 
            btnAddMeal.Location = new Point(171, 47);
            btnAddMeal.Margin = new Padding(3, 2, 3, 2);
            btnAddMeal.Name = "btnAddMeal";
            btnAddMeal.Size = new Size(147, 28);
            btnAddMeal.TabIndex = 2;
            btnAddMeal.Text = "Add a Meal";
            btnAddMeal.UseVisualStyleBackColor = true;
            btnAddMeal.Click += btnAddMeal_Click;
            // 
            // mcMealTime
            // 
            mcMealTime.Location = new Point(44, 84);
            mcMealTime.Margin = new Padding(8, 7, 8, 7);
            mcMealTime.Name = "mcMealTime";
            mcMealTime.TabIndex = 3;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dgvAddingFood);
            groupBox1.Controls.Add(btnDeleteAll);
            groupBox1.Controls.Add(btnDelete);
            groupBox1.Controls.Add(btnDone);
            groupBox1.Controls.Add(btnAddFood);
            groupBox1.Controls.Add(nudGram);
            groupBox1.Controls.Add(cbFoodType);
            groupBox1.Controls.Add(lblGram);
            groupBox1.Controls.Add(lblFoodType);
            groupBox1.Controls.Add(lblBonApetite);
            groupBox1.Controls.Add(mcMealTime);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(btnAddMeal);
            groupBox1.Controls.Add(cbMealTime);
            groupBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox1.ForeColor = SystemColors.ControlDark;
            groupBox1.Location = new Point(10, 9);
            groupBox1.Margin = new Padding(3, 2, 3, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 2, 3, 2);
            groupBox1.Size = new Size(329, 582);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "Manage Your Meal";
            // 
            // dgvAddingFood
            // 
            dgvAddingFood.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAddingFood.Location = new Point(89, 412);
            dgvAddingFood.Margin = new Padding(3, 2, 3, 2);
            dgvAddingFood.Name = "dgvAddingFood";
            dgvAddingFood.RowHeadersVisible = false;
            dgvAddingFood.RowHeadersWidth = 51;
            dgvAddingFood.RowTemplate.Height = 29;
            dgvAddingFood.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvAddingFood.Size = new Size(228, 161);
            dgvAddingFood.TabIndex = 11;
            dgvAddingFood.Visible = false;
            // 
            // btnDeleteAll
            // 
            btnDeleteAll.Location = new Point(5, 481);
            btnDeleteAll.Margin = new Padding(3, 2, 3, 2);
            btnDeleteAll.Name = "btnDeleteAll";
            btnDeleteAll.Size = new Size(79, 58);
            btnDeleteAll.TabIndex = 10;
            btnDeleteAll.Text = "DELETE ALL";
            btnDeleteAll.UseVisualStyleBackColor = true;
            btnDeleteAll.Visible = false;
            btnDeleteAll.Click += btnDeleteAll_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(5, 446);
            btnDelete.Margin = new Padding(3, 2, 3, 2);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(79, 30);
            btnDelete.TabIndex = 9;
            btnDelete.Text = "DELETE";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Visible = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnDone
            // 
            btnDone.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnDone.ForeColor = Color.IndianRed;
            btnDone.Location = new Point(5, 543);
            btnDone.Margin = new Padding(3, 2, 3, 2);
            btnDone.Name = "btnDone";
            btnDone.Size = new Size(79, 30);
            btnDone.TabIndex = 8;
            btnDone.Text = "DONE";
            btnDone.UseVisualStyleBackColor = true;
            btnDone.Visible = false;
            btnDone.Click += btnDone_Click;
            // 
            // btnAddFood
            // 
            btnAddFood.Location = new Point(5, 412);
            btnAddFood.Margin = new Padding(3, 2, 3, 2);
            btnAddFood.Name = "btnAddFood";
            btnAddFood.Size = new Size(79, 30);
            btnAddFood.TabIndex = 7;
            btnAddFood.Text = "ADD";
            btnAddFood.UseVisualStyleBackColor = true;
            btnAddFood.Visible = false;
            btnAddFood.Click += btnAddFood_Click;
            // 
            // nudGram
            // 
            nudGram.Location = new Point(10, 382);
            nudGram.Margin = new Padding(3, 2, 3, 2);
            nudGram.Maximum = new decimal(new int[] { 300, 0, 0, 0 });
            nudGram.Name = "nudGram";
            nudGram.Size = new Size(307, 29);
            nudGram.TabIndex = 6;
            nudGram.TextAlign = HorizontalAlignment.Center;
            nudGram.Value = new decimal(new int[] { 100, 0, 0, 0 });
            nudGram.Visible = false;
            // 
            // cbFoodType
            // 
            cbFoodType.FormattingEnabled = true;
            cbFoodType.Location = new Point(10, 316);
            cbFoodType.Margin = new Padding(3, 2, 3, 2);
            cbFoodType.Name = "cbFoodType";
            cbFoodType.Size = new Size(308, 29);
            cbFoodType.TabIndex = 5;
            cbFoodType.Visible = false;
            cbFoodType.SelectedIndexChanged += cbFoodType_SelectedIndexChanged;
            // 
            // lblGram
            // 
            lblGram.Location = new Point(5, 346);
            lblGram.Name = "lblGram";
            lblGram.Size = new Size(318, 34);
            lblGram.TabIndex = 4;
            lblGram.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblFoodType
            // 
            lblFoodType.Location = new Point(5, 280);
            lblFoodType.Name = "lblFoodType";
            lblFoodType.Size = new Size(318, 34);
            lblFoodType.TabIndex = 4;
            lblFoodType.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblBonApetite
            // 
            lblBonApetite.Location = new Point(5, 247);
            lblBonApetite.Name = "lblBonApetite";
            lblBonApetite.Size = new Size(312, 34);
            lblBonApetite.TabIndex = 4;
            lblBonApetite.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            panel1.Controls.Add(txtFoodCalory);
            panel1.Controls.Add(lblCaloryCount);
            panel1.Controls.Add(lblTotalcal);
            panel1.Controls.Add(lblFoodCalory);
            panel1.Controls.Add(txtFoodName);
            panel1.Controls.Add(lblFoodName);
            panel1.Location = new Point(345, 9);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(444, 129);
            panel1.TabIndex = 5;
            // 
            // txtFoodCalory
            // 
            txtFoodCalory.Location = new Point(3, 91);
            txtFoodCalory.Margin = new Padding(3, 2, 3, 2);
            txtFoodCalory.Name = "txtFoodCalory";
            txtFoodCalory.ReadOnly = true;
            txtFoodCalory.Size = new Size(205, 23);
            txtFoodCalory.TabIndex = 5;
            txtFoodCalory.Visible = false;
            // 
            // lblCaloryCount
            // 
            lblCaloryCount.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblCaloryCount.ForeColor = SystemColors.ControlDark;
            lblCaloryCount.Location = new Point(227, 61);
            lblCaloryCount.Name = "lblCaloryCount";
            lblCaloryCount.Size = new Size(205, 28);
            lblCaloryCount.TabIndex = 4;
            lblCaloryCount.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblTotalcal
            // 
            lblTotalcal.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblTotalcal.ForeColor = SystemColors.ControlDark;
            lblTotalcal.Location = new Point(227, 8);
            lblTotalcal.Name = "lblTotalcal";
            lblTotalcal.Size = new Size(205, 28);
            lblTotalcal.TabIndex = 4;
            lblTotalcal.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblFoodCalory
            // 
            lblFoodCalory.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblFoodCalory.ForeColor = SystemColors.ControlDark;
            lblFoodCalory.Location = new Point(3, 61);
            lblFoodCalory.Name = "lblFoodCalory";
            lblFoodCalory.Size = new Size(205, 28);
            lblFoodCalory.TabIndex = 4;
            lblFoodCalory.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtFoodName
            // 
            txtFoodName.Location = new Point(3, 38);
            txtFoodName.Margin = new Padding(3, 2, 3, 2);
            txtFoodName.Name = "txtFoodName";
            txtFoodName.ReadOnly = true;
            txtFoodName.Size = new Size(205, 23);
            txtFoodName.TabIndex = 5;
            txtFoodName.Visible = false;
            // 
            // lblFoodName
            // 
            lblFoodName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblFoodName.ForeColor = SystemColors.ControlDark;
            lblFoodName.Location = new Point(3, 8);
            lblFoodName.Name = "lblFoodName";
            lblFoodName.Size = new Size(205, 28);
            lblFoodName.TabIndex = 4;
            lblFoodName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            panel2.AutoScroll = true;
            panel2.Location = new Point(345, 143);
            panel2.Name = "panel2";
            panel2.Size = new Size(443, 448);
            panel2.TabIndex = 6;
            // 
            // MealForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = Color.FromArgb(26, 26, 26);
            ClientSize = new Size(800, 591);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "MealForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MealForm";
            Load += MealForm_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAddingFood).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudGram).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private ComboBox cbMealTime;
        private Button btnAddMeal;
        private MonthCalendar mcMealTime;
        private GroupBox groupBox1;
        private Label lblBonApetite;
        private Label lblFoodType;
        private ComboBox cbFoodType;
        private Label lblGram;
        private NumericUpDown nudGram;
        private Button btnAddFood;
        private Button btnDone;
        private Panel panel1;
        private Label lblFoodName;
        private TextBox txtFoodName;
        private TextBox txtFoodCalory;
        private Label lblFoodCalory;
        private Label lblCaloryCount;
        private Label lblTotalcal;
        private Panel panel2;
        private Button btnDeleteAll;
        private Button btnDelete;
        private DataGridView dgvAddingFood;
    }
}