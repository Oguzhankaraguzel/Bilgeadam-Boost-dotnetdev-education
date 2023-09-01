namespace LoginWFA.Forms
{
    partial class SummaryForm
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
            lblSummary = new Label();
            lblDiet = new Label();
            lblMeals = new Label();
            lblToday = new Label();
            lblWeekAverage = new Label();
            lbl = new Label();
            lblGoal = new Label();
            lblDailyAverage = new Label();
            lblWeeklyAverage = new Label();
            lblMonthlyAverage = new Label();
            groupBox1 = new GroupBox();
            label10 = new Label();
            lblLastMeals = new Label();
            dgvMeals = new DataGridView();
            label9 = new Label();
            label13 = new Label();
            dgvMealDetails = new DataGridView();
            label11 = new Label();
            btnDeleteMeal = new Button();
            btnDeleteFood = new Button();
            groupBox2 = new GroupBox();
            rdbAll = new RadioButton();
            rdbLastMonth = new RadioButton();
            rdbLastWeek = new RadioButton();
            rdbLastDay = new RadioButton();
            groupBox3 = new GroupBox();
            rdbAllMealTime = new RadioButton();
            rdbSnack = new RadioButton();
            rdbDinner = new RadioButton();
            rdbLunch = new RadioButton();
            rdbBreakFast = new RadioButton();
            label1 = new Label();
            label2 = new Label();
            label4 = new Label();
            lblAmr = new Label();
            lblBmr = new Label();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvMeals).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvMealDetails).BeginInit();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // lblSummary
            // 
            lblSummary.AutoSize = true;
            lblSummary.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            lblSummary.ForeColor = SystemColors.Control;
            lblSummary.Location = new Point(24, 32);
            lblSummary.Margin = new Padding(2, 0, 2, 0);
            lblSummary.Name = "lblSummary";
            lblSummary.Size = new Size(153, 45);
            lblSummary.TabIndex = 1;
            lblSummary.Text = "Summary";
            // 
            // lblDiet
            // 
            lblDiet.AutoSize = true;
            lblDiet.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            lblDiet.ForeColor = SystemColors.Control;
            lblDiet.Location = new Point(104, 83);
            lblDiet.Margin = new Padding(2, 0, 2, 0);
            lblDiet.Name = "lblDiet";
            lblDiet.Size = new Size(48, 28);
            lblDiet.TabIndex = 3;
            lblDiet.Text = "Diet";
            // 
            // lblMeals
            // 
            lblMeals.AutoSize = true;
            lblMeals.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            lblMeals.ForeColor = SystemColors.Control;
            lblMeals.Location = new Point(16, 21);
            lblMeals.Margin = new Padding(2, 0, 2, 0);
            lblMeals.Name = "lblMeals";
            lblMeals.Size = new Size(77, 32);
            lblMeals.TabIndex = 4;
            lblMeals.Text = "Meals";
            // 
            // lblToday
            // 
            lblToday.AutoSize = true;
            lblToday.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblToday.ForeColor = SystemColors.Control;
            lblToday.Location = new Point(57, 68);
            lblToday.Margin = new Padding(2, 0, 2, 0);
            lblToday.Name = "lblToday";
            lblToday.Size = new Size(53, 21);
            lblToday.TabIndex = 7;
            lblToday.Text = "Today:";
            // 
            // lblWeekAverage
            // 
            lblWeekAverage.AutoSize = true;
            lblWeekAverage.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblWeekAverage.ForeColor = SystemColors.Control;
            lblWeekAverage.Location = new Point(25, 103);
            lblWeekAverage.Margin = new Padding(2, 0, 2, 0);
            lblWeekAverage.Name = "lblWeekAverage";
            lblWeekAverage.Size = new Size(82, 21);
            lblWeekAverage.TabIndex = 8;
            lblWeekAverage.Text = "Week Avg:";
            // 
            // lbl
            // 
            lbl.AutoSize = true;
            lbl.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbl.ForeColor = SystemColors.Control;
            lbl.Location = new Point(16, 142);
            lbl.Margin = new Padding(2, 0, 2, 0);
            lbl.Name = "lbl";
            lbl.Size = new Size(90, 21);
            lbl.TabIndex = 9;
            lbl.Text = "Month Avg:";
            // 
            // lblGoal
            // 
            lblGoal.AutoSize = true;
            lblGoal.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            lblGoal.ForeColor = SystemColors.Control;
            lblGoal.Location = new Point(104, 124);
            lblGoal.Margin = new Padding(2, 0, 2, 0);
            lblGoal.Name = "lblGoal";
            lblGoal.Size = new Size(53, 28);
            lblGoal.TabIndex = 13;
            lblGoal.Text = "Goal";
            // 
            // lblDailyAverage
            // 
            lblDailyAverage.AutoSize = true;
            lblDailyAverage.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblDailyAverage.ForeColor = SystemColors.Control;
            lblDailyAverage.Location = new Point(120, 68);
            lblDailyAverage.Margin = new Padding(2, 0, 2, 0);
            lblDailyAverage.Name = "lblDailyAverage";
            lblDailyAverage.Size = new Size(78, 21);
            lblDailyAverage.TabIndex = 14;
            lblDailyAverage.Text = "1500 Kcal";
            // 
            // lblWeeklyAverage
            // 
            lblWeeklyAverage.AutoSize = true;
            lblWeeklyAverage.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblWeeklyAverage.ForeColor = SystemColors.Control;
            lblWeeklyAverage.Location = new Point(120, 103);
            lblWeeklyAverage.Margin = new Padding(2, 0, 2, 0);
            lblWeeklyAverage.Name = "lblWeeklyAverage";
            lblWeeklyAverage.Size = new Size(78, 21);
            lblWeeklyAverage.TabIndex = 15;
            lblWeeklyAverage.Text = "1500 Kcal";
            // 
            // lblMonthlyAverage
            // 
            lblMonthlyAverage.AutoSize = true;
            lblMonthlyAverage.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblMonthlyAverage.ForeColor = SystemColors.Control;
            lblMonthlyAverage.Location = new Point(120, 142);
            lblMonthlyAverage.Margin = new Padding(2, 0, 2, 0);
            lblMonthlyAverage.Name = "lblMonthlyAverage";
            lblMonthlyAverage.Size = new Size(78, 21);
            lblMonthlyAverage.TabIndex = 16;
            lblMonthlyAverage.Text = "1500 Kcal";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(lblMeals);
            groupBox1.Controls.Add(lblToday);
            groupBox1.Controls.Add(lblMonthlyAverage);
            groupBox1.Controls.Add(lblWeekAverage);
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(lblWeeklyAverage);
            groupBox1.Controls.Add(lbl);
            groupBox1.Controls.Add(lblDailyAverage);
            groupBox1.ForeColor = SystemColors.Control;
            groupBox1.Location = new Point(372, 21);
            groupBox1.Margin = new Padding(2, 2, 2, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(2, 2, 2, 2);
            groupBox1.Size = new Size(418, 180);
            groupBox1.TabIndex = 20;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // label10
            // 
            label10.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label10.ForeColor = SystemColors.Control;
            label10.Location = new Point(250, 74);
            label10.Margin = new Padding(2, 0, 2, 0);
            label10.Name = "label10";
            label10.Size = new Size(151, 80);
            label10.TabIndex = 15;
            label10.Text = "Calorie On a daily basis, on average";
            label10.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblLastMeals
            // 
            lblLastMeals.AutoSize = true;
            lblLastMeals.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            lblLastMeals.ForeColor = SystemColors.Control;
            lblLastMeals.Location = new Point(24, 175);
            lblLastMeals.Margin = new Padding(2, 0, 2, 0);
            lblLastMeals.Name = "lblLastMeals";
            lblLastMeals.Size = new Size(82, 28);
            lblLastMeals.TabIndex = 25;
            lblLastMeals.Text = "MEALS :";
            // 
            // dgvMeals
            // 
            dgvMeals.AllowUserToAddRows = false;
            dgvMeals.AllowUserToDeleteRows = false;
            dgvMeals.BorderStyle = BorderStyle.Fixed3D;
            dgvMeals.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMeals.Location = new Point(10, 412);
            dgvMeals.MultiSelect = false;
            dgvMeals.Name = "dgvMeals";
            dgvMeals.ReadOnly = true;
            dgvMeals.RowHeadersVisible = false;
            dgvMeals.RowHeadersWidth = 51;
            dgvMeals.RowTemplate.Height = 25;
            dgvMeals.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvMeals.Size = new Size(345, 143);
            dgvMeals.TabIndex = 27;
            dgvMeals.MouseClick += dgvMeals_MouseClick;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label9.ForeColor = SystemColors.Control;
            label9.Location = new Point(29, 83);
            label9.Margin = new Padding(2, 0, 2, 0);
            label9.Name = "label9";
            label9.Size = new Size(48, 28);
            label9.TabIndex = 3;
            label9.Text = "Diet";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label13.ForeColor = SystemColors.Control;
            label13.Location = new Point(29, 124);
            label13.Margin = new Padding(2, 0, 2, 0);
            label13.Name = "label13";
            label13.Size = new Size(53, 28);
            label13.TabIndex = 13;
            label13.Text = "Goal";
            // 
            // dgvMealDetails
            // 
            dgvMealDetails.AllowUserToAddRows = false;
            dgvMealDetails.AllowUserToDeleteRows = false;
            dgvMealDetails.BorderStyle = BorderStyle.Fixed3D;
            dgvMealDetails.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMealDetails.Location = new Point(434, 412);
            dgvMealDetails.MultiSelect = false;
            dgvMealDetails.Name = "dgvMealDetails";
            dgvMealDetails.ReadOnly = true;
            dgvMealDetails.RowHeadersVisible = false;
            dgvMealDetails.RowHeadersWidth = 51;
            dgvMealDetails.RowTemplate.Height = 25;
            dgvMealDetails.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvMealDetails.Size = new Size(356, 143);
            dgvMealDetails.TabIndex = 27;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label11.ForeColor = SystemColors.Control;
            label11.Location = new Point(434, 382);
            label11.Margin = new Padding(2, 0, 2, 0);
            label11.Name = "label11";
            label11.Size = new Size(136, 28);
            label11.TabIndex = 25;
            label11.Text = "MEAL DETAIL :";
            // 
            // btnDeleteMeal
            // 
            btnDeleteMeal.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnDeleteMeal.Location = new Point(360, 412);
            btnDeleteMeal.Margin = new Padding(3, 2, 3, 2);
            btnDeleteMeal.Name = "btnDeleteMeal";
            btnDeleteMeal.Size = new Size(68, 42);
            btnDeleteMeal.TabIndex = 28;
            btnDeleteMeal.Text = "DELETE MEAL";
            btnDeleteMeal.UseVisualStyleBackColor = true;
            btnDeleteMeal.Click += btnDeleteMeal_Click;
            // 
            // btnDeleteFood
            // 
            btnDeleteFood.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnDeleteFood.Location = new Point(360, 513);
            btnDeleteFood.Margin = new Padding(3, 2, 3, 2);
            btnDeleteFood.Name = "btnDeleteFood";
            btnDeleteFood.Size = new Size(68, 42);
            btnDeleteFood.TabIndex = 28;
            btnDeleteFood.Text = "DELETE FOOD";
            btnDeleteFood.UseVisualStyleBackColor = true;
            btnDeleteFood.Click += btnDeleteFood_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(rdbAll);
            groupBox2.Controls.Add(rdbLastMonth);
            groupBox2.Controls.Add(rdbLastWeek);
            groupBox2.Controls.Add(rdbLastDay);
            groupBox2.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox2.ForeColor = SystemColors.Control;
            groupBox2.Location = new Point(10, 203);
            groupBox2.Margin = new Padding(3, 2, 3, 2);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(3, 2, 3, 2);
            groupBox2.Size = new Size(162, 203);
            groupBox2.TabIndex = 29;
            groupBox2.TabStop = false;
            groupBox2.Text = "FILTER BY";
            // 
            // rdbAll
            // 
            rdbAll.AutoSize = true;
            rdbAll.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            rdbAll.Location = new Point(13, 116);
            rdbAll.Margin = new Padding(3, 2, 3, 2);
            rdbAll.Name = "rdbAll";
            rdbAll.Size = new Size(54, 25);
            rdbAll.TabIndex = 0;
            rdbAll.TabStop = true;
            rdbAll.Text = "ALL";
            rdbAll.UseVisualStyleBackColor = true;
            rdbAll.CheckedChanged += rdbAll_CheckedChanged;
            // 
            // rdbLastMonth
            // 
            rdbLastMonth.AutoSize = true;
            rdbLastMonth.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            rdbLastMonth.Location = new Point(13, 87);
            rdbLastMonth.Margin = new Padding(3, 2, 3, 2);
            rdbLastMonth.Name = "rdbLastMonth";
            rdbLastMonth.Size = new Size(124, 25);
            rdbLastMonth.TabIndex = 0;
            rdbLastMonth.TabStop = true;
            rdbLastMonth.Text = "LAST MONTH";
            rdbLastMonth.UseVisualStyleBackColor = true;
            rdbLastMonth.CheckedChanged += rdbLastMonth_CheckedChanged;
            // 
            // rdbLastWeek
            // 
            rdbLastWeek.AutoSize = true;
            rdbLastWeek.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            rdbLastWeek.Location = new Point(13, 58);
            rdbLastWeek.Margin = new Padding(3, 2, 3, 2);
            rdbLastWeek.Name = "rdbLastWeek";
            rdbLastWeek.Size = new Size(107, 25);
            rdbLastWeek.TabIndex = 0;
            rdbLastWeek.TabStop = true;
            rdbLastWeek.Text = "LAST WEEK";
            rdbLastWeek.UseVisualStyleBackColor = true;
            rdbLastWeek.CheckedChanged += rdbLastWeek_CheckedChanged;
            // 
            // rdbLastDay
            // 
            rdbLastDay.AutoSize = true;
            rdbLastDay.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            rdbLastDay.Location = new Point(13, 30);
            rdbLastDay.Margin = new Padding(3, 2, 3, 2);
            rdbLastDay.Name = "rdbLastDay";
            rdbLastDay.Size = new Size(76, 25);
            rdbLastDay.TabIndex = 0;
            rdbLastDay.TabStop = true;
            rdbLastDay.Text = "TODAY";
            rdbLastDay.UseVisualStyleBackColor = true;
            rdbLastDay.CheckedChanged += rdbLastDay_CheckedChanged;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(rdbAllMealTime);
            groupBox3.Controls.Add(rdbSnack);
            groupBox3.Controls.Add(rdbDinner);
            groupBox3.Controls.Add(rdbLunch);
            groupBox3.Controls.Add(rdbBreakFast);
            groupBox3.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox3.ForeColor = SystemColors.Control;
            groupBox3.Location = new Point(193, 203);
            groupBox3.Margin = new Padding(3, 2, 3, 2);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new Padding(3, 2, 3, 2);
            groupBox3.Size = new Size(162, 203);
            groupBox3.TabIndex = 29;
            groupBox3.TabStop = false;
            groupBox3.Text = "FILTER BY";
            // 
            // rdbAllMealTime
            // 
            rdbAllMealTime.AutoSize = true;
            rdbAllMealTime.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            rdbAllMealTime.Location = new Point(16, 144);
            rdbAllMealTime.Margin = new Padding(3, 2, 3, 2);
            rdbAllMealTime.Name = "rdbAllMealTime";
            rdbAllMealTime.Size = new Size(54, 25);
            rdbAllMealTime.TabIndex = 0;
            rdbAllMealTime.TabStop = true;
            rdbAllMealTime.Text = "ALL";
            rdbAllMealTime.UseVisualStyleBackColor = true;
            rdbAllMealTime.CheckedChanged += rdbAllMealTime_CheckedChanged;
            // 
            // rdbSnack
            // 
            rdbSnack.AutoSize = true;
            rdbSnack.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            rdbSnack.Location = new Point(16, 116);
            rdbSnack.Margin = new Padding(3, 2, 3, 2);
            rdbSnack.Name = "rdbSnack";
            rdbSnack.Size = new Size(78, 25);
            rdbSnack.TabIndex = 0;
            rdbSnack.TabStop = true;
            rdbSnack.Text = "SNACK";
            rdbSnack.UseVisualStyleBackColor = true;
            rdbSnack.CheckedChanged += rdbSnack_CheckedChanged;
            // 
            // rdbDinner
            // 
            rdbDinner.AutoSize = true;
            rdbDinner.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            rdbDinner.Location = new Point(16, 87);
            rdbDinner.Margin = new Padding(3, 2, 3, 2);
            rdbDinner.Name = "rdbDinner";
            rdbDinner.Size = new Size(85, 25);
            rdbDinner.TabIndex = 0;
            rdbDinner.TabStop = true;
            rdbDinner.Text = "DINNER";
            rdbDinner.UseVisualStyleBackColor = true;
            rdbDinner.CheckedChanged += rdbDinner_CheckedChanged;
            // 
            // rdbLunch
            // 
            rdbLunch.AutoSize = true;
            rdbLunch.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            rdbLunch.Location = new Point(16, 58);
            rdbLunch.Margin = new Padding(3, 2, 3, 2);
            rdbLunch.Name = "rdbLunch";
            rdbLunch.Size = new Size(80, 25);
            rdbLunch.TabIndex = 0;
            rdbLunch.TabStop = true;
            rdbLunch.Text = "LUNCH";
            rdbLunch.UseVisualStyleBackColor = true;
            rdbLunch.CheckedChanged += rdbLunch_CheckedChanged;
            // 
            // rdbBreakFast
            // 
            rdbBreakFast.AutoSize = true;
            rdbBreakFast.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            rdbBreakFast.Location = new Point(16, 30);
            rdbBreakFast.Margin = new Padding(3, 2, 3, 2);
            rdbBreakFast.Name = "rdbBreakFast";
            rdbBreakFast.Size = new Size(108, 25);
            rdbBreakFast.TabIndex = 0;
            rdbBreakFast.TabStop = true;
            rdbBreakFast.Text = "BREAKFAST";
            rdbBreakFast.UseVisualStyleBackColor = true;
            rdbBreakFast.CheckedChanged += rdbBreakFast_CheckedChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(209, 175);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(82, 28);
            label1.TabIndex = 25;
            label1.Text = "MEALS :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.Control;
            label2.Location = new Point(434, 203);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(281, 28);
            label2.TabIndex = 25;
            label2.Text = "YOUR BASAL METABOLIC RATE";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.Control;
            label4.Location = new Point(459, 262);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(219, 28);
            label4.TabIndex = 25;
            label4.Text = "YOUR METABOLIC RATE";
            // 
            // lblAmr
            // 
            lblAmr.AutoSize = true;
            lblAmr.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            lblAmr.ForeColor = SystemColors.Control;
            lblAmr.Location = new Point(506, 290);
            lblAmr.Margin = new Padding(2, 0, 2, 0);
            lblAmr.Name = "lblAmr";
            lblAmr.Size = new Size(145, 28);
            lblAmr.TabIndex = 25;
            lblAmr.Text = "1700,00 calorie";
            // 
            // lblBmr
            // 
            lblBmr.AutoSize = true;
            lblBmr.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            lblBmr.ForeColor = SystemColors.Control;
            lblBmr.Location = new Point(506, 233);
            lblBmr.Margin = new Padding(2, 0, 2, 0);
            lblBmr.Name = "lblBmr";
            lblBmr.Size = new Size(145, 28);
            lblBmr.TabIndex = 25;
            lblBmr.Text = "1700,00 calorie";
            // 
            // SummaryForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(26, 26, 26);
            ClientSize = new Size(800, 565);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(btnDeleteFood);
            Controls.Add(btnDeleteMeal);
            Controls.Add(dgvMealDetails);
            Controls.Add(dgvMeals);
            Controls.Add(lblBmr);
            Controls.Add(lblAmr);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label11);
            Controls.Add(label1);
            Controls.Add(lblLastMeals);
            Controls.Add(groupBox1);
            Controls.Add(label13);
            Controls.Add(label9);
            Controls.Add(lblGoal);
            Controls.Add(lblDiet);
            Controls.Add(lblSummary);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(2, 2, 2, 2);
            Name = "SummaryForm";
            Text = "Summarycs";
            Load += SummaryForm_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvMeals).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvMealDetails).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblSummary;
        private Label lblDiet;
        private Label lblMeals;
        private Label lblWeekAverage;
        private Label lbl;
        private Label lblDailyCaloryValue;
        private Label label1;
        private Label label3;
        private Label lblToday;
        private Label label4;
        private Label lblAmr;
        private Label label6;
        private Microsoft.Data.SqlClient.SqlCommandBuilder sqlCommandBuilder1;
        private Label label7;
        private Label label8;
        private Label lblGoal;
        private Label lblDailyAverage;
        private Label lblWeeklyAverage;
        private Label lblMonthlyAverage;
        private GroupBox groupBox1;
        private Label lblLastMeals;
        private DataGridView dgvMeals;
        private Label label9;
        private Label label13;
        private DataGridView dgvMealDetails;
        private Label label10;
        private Label label11;
        private Button btnDeleteMeal;
        private Button btnDeleteFood;
        private GroupBox groupBox2;
        private RadioButton rdbAll;
        private RadioButton rdbLastMonth;
        private RadioButton rdbLastWeek;
        private RadioButton rdbLastDay;
        private GroupBox groupBox3;
        private RadioButton rdbSnack;
        private RadioButton rdbDinner;
        private RadioButton rdbLunch;
        private RadioButton rdbBreakFast;
        private Label label2;
        private Label lblBmr;
        private RadioButton rdbAllMealTime;
    }
}