using Dietary.BLL.Services;
using Dietary.DAL.Context;
using Dietary.Entities.Entities.UserEntities;
using Dietary.Entities.Enums;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginWFA.Forms
{
    public partial class SummaryForm : Form
    {
        #region Required Instance

        DietaryDbContext _db = new DietaryDbContext();
        CaloryService _cs = new CaloryService();
        UserDetailServis _uds = new UserDetailServis();
        MealService _ms = new MealService();
        int forDate = 0;
        int foodtypeId = 1;
        UserDetail userdetail;
        string datetime;
        string foodtime;
        decimal calorie;
        int mealId;

        #endregion

        public SummaryForm()
        {
            InitializeComponent();
        }

        private void SummaryForm_Load(object sender, EventArgs e)
        {
            if (LoginForm.trChanger == 1)
            {
                Language("");
            }
            userdetail = _uds.FindUserDetail(LoginForm.user);
            RenderForm();
        }

        private void btnDeleteMeal_Click(object sender, EventArgs e)
        {
            try
            {
                _ms.DeleteMeal(mealId);
                GetMealsBySelection(userdetail, forDate, foodtypeId);
                GetMealDetails(mealId);

            }
            catch (Exception)
            {
                MessageBox.Show("Please select a meal", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnDeleteFood_Click(object sender, EventArgs e)
        {
            try
            {
                _ms.DeleteFoodToMeal
                        (
                        mealId,
                        dgvMealDetails.SelectedRows[0].Cells[0].Value.ToString(),
                        (decimal)dgvMealDetails.SelectedRows[0].Cells[1].Value
                        );
                GetMealsBySelection(userdetail, forDate, foodtypeId);
                GetMealDetails(mealId);
            }
            catch (Exception)
            {
                MessageBox.Show("Please select a food", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


        private void rdbBreakFast_CheckedChanged(object sender, EventArgs e)
        {
            foodtypeId = 1;
            GetMealsBySelection(userdetail, forDate, foodtypeId);
        }

        private void rdbLunch_CheckedChanged(object sender, EventArgs e)
        {
            foodtypeId = 2;
            GetMealsBySelection(userdetail, forDate, foodtypeId);
        }

        private void rdbDinner_CheckedChanged(object sender, EventArgs e)
        {
            foodtypeId = 3;
            GetMealsBySelection(userdetail, forDate, foodtypeId);
        }

        private void rdbSnack_CheckedChanged(object sender, EventArgs e)
        {
            foodtypeId = 4;
            GetMealsBySelection(userdetail, forDate, foodtypeId);
        }
        private void rdbAllMealTime_CheckedChanged(object sender, EventArgs e)
        {
            foodtypeId = 5;
            GetMealsBySelection(userdetail, forDate, foodtypeId);
        }

        private void rdbLastDay_CheckedChanged(object sender, EventArgs e)
        {
            forDate = 0;
            GetMealsBySelection(userdetail, forDate, foodtypeId);
        }

        private void rdbLastWeek_CheckedChanged(object sender, EventArgs e)
        {
            forDate = 6;
            GetMealsBySelection(userdetail, forDate, foodtypeId);
        }

        private void rdbLastMonth_CheckedChanged(object sender, EventArgs e)
        {
            forDate = 29;
            GetMealsBySelection(userdetail, forDate, foodtypeId);
        }

        private void rdbAll_CheckedChanged(object sender, EventArgs e)
        {
            forDate = 30;
            GetMealsBySelection(userdetail, forDate, foodtypeId);
        }


        private void dgvMeals_MouseClick(object sender, MouseEventArgs e)
        {
            updateData();
            GetMealDetails(mealId);
        }

        #region Procedurs




        /// <summary>
        /// Gelen dil bilgisine göre formun dilini ayarlar
        /// </summary>
        /// <param name="culture"></param>
        public void Language(string culture)
        {
            Thread.CurrentThread.CurrentUICulture.ClearCachedData();
            Thread.CurrentThread.CurrentUICulture = new CultureInfo(culture);
            label1.Text = SummaryLocalization.label1;
            label2.Text = SummaryLocalization.label2;
            label4.Text = SummaryLocalization.label4;
            rdbAll.Text = SummaryLocalization.rdbAll;
            rdbLastDay.Text = SummaryLocalization.rdbLastDay;
            rdbLastWeek.Text = SummaryLocalization.rdbLastWeek;
            rdbLastMonth.Text = SummaryLocalization.rdbLastMonth;
            rdbBreakFast.Text = SummaryLocalization.rdbBreakFast;
            rdbLunch.Text = SummaryLocalization.rdbLunch;
            rdbDinner.Text = SummaryLocalization.rdbDinner;
            rdbSnack.Text = SummaryLocalization.rdbSnack;
            rdbAllMealTime.Text = SummaryLocalization.rdbAllMealTime;
            label9.Text = SummaryLocalization.label9;
            label13.Text = SummaryLocalization.label13;
            lblToday.Text = SummaryLocalization.lblToday;
            lblWeekAverage.Text = SummaryLocalization.lblWeekAverage;
            btnDeleteFood.Text = SummaryLocalization.btnDeleteFood;
            btnDeleteMeal.Text = SummaryLocalization.btnDeleteMeal;
            label10.Text = SummaryLocalization.label10;
            lblLastMeals.Text = SummaryLocalization.lblLastMeals;
            label11.Text = SummaryLocalization.label11;
            lblMeals.Text = SummaryLocalization.lblMeals;
            lbl.Text = SummaryLocalization.lbl;


        }
        private void updateData()
        {

            try
            {
                datetime = dgvMeals.SelectedRows[0].Cells[0].Value.ToString();
                foodtime = dgvMeals.SelectedRows[0].Cells[1].Value.ToString();
                calorie = (decimal)dgvMeals.SelectedRows[0].Cells[2].Value;
                mealId = _ms.FindMealId
                           (
                               datetime,
                               foodtime,
                               calorie
                               );
            }
            catch (Exception)
            {

                MessageBox.Show("You must select a meal");
            }
        }

        /// <summary>
        /// Formda gerekli alanları doldurur.
        /// </summary>
        private void RenderForm()
        {

            lblDailyAverage.Text = Math.Round(_cs.UserTakenCaloryDaily(LoginForm.user)).ToString() + " calorie";
            lblWeeklyAverage.Text = Math.Round(_cs.UserTakenCaloryWeeklyAvg(LoginForm.user)).ToString() + " calorie";
            lblMonthlyAverage.Text = Math.Round(_cs.UserTakenMonthlyAvg(LoginForm.user)).ToString() + " calorie";
            lblDiet.Text = Enum.GetName(typeof(DietEnum), userdetail.DietId);
            lblGoal.Text = Enum.GetName(typeof(GoalEnum), userdetail.GoalId);
            lblAmr.Text = Math.Round(userdetail.AMR).ToString();
            lblBmr.Text = Math.Round(userdetail.BMR).ToString();
            rdbAll.Checked = true;
            rdbAllMealTime.Checked = true;
        }
        /// <summary>
        /// Seçilen meal'ı getirir.
        /// </summary>
        /// <param name="ud"></param>
        /// <param name="date"></param>
        /// <param name="foodtypeId"></param>
        private void GetMealsBySelection(UserDetail ud, int date, int foodtypeId)
        {
            if (date > 29 && foodtypeId > 4)
            {
                dgvMeals.DataSource = _db.Meals
                    .Where(ml => ml.UserDetailId == ud.UserId)
                    .Select
                    (
                    ml => new
                    {
                        TIME = ml.MealTime,
                        MEALTIME = ml.FoodTime.Name,
                        CALORIE = ml.CaloriesTaken,
                    }
                    ).ToList();
            }
            else if (date <= 29 && foodtypeId > 4)
            {
                dgvMeals.DataSource = _db.Meals
                .Where(ml => ml.MealTime >= DateTime.Today.AddDays(-date) && ml.UserDetailId == ud.UserId)
                .Select
                (
                ml => new
                {
                    TIME = ml.MealTime,
                    MEALTIME = ml.FoodTime.Name,
                    CALORIE = ml.CaloriesTaken,
                }
                ).ToList();
            }
            else if (date > 29 && foodtypeId <= 4)
            {
                dgvMeals.DataSource = _db.Meals
                .Where(ml => ml.UserDetailId == ud.UserId && ml.FoodTimeId == foodtypeId)
                .Select
                (
                ml => new
                {
                    TIME = ml.MealTime,
                    MEALTIME = ml.FoodTime.Name,
                    CALORIE = ml.CaloriesTaken,
                }
                ).ToList();
            }
            else
            {
                dgvMeals.DataSource = _db.Meals
                    .Where(ml => ml.MealTime >= DateTime.Today.AddDays(-date) && ml.UserDetailId == ud.UserId && ml.FoodTimeId == foodtypeId)
                    .Select
                    (
                    ml => new
                    {
                        TIME = ml.MealTime,
                        MEALTIME = ml.FoodTime.Name,
                        CALORIE = ml.CaloriesTaken,
                    }
                    ).ToList();
            }

        }
        /// <summary>
        /// Meal id'sini kullanarak meal details'e ulaşılır.
        /// </summary>
        /// <param name="mealId"></param>
        private void GetMealDetails(int mealId)
        {
            dgvMealDetails.DataSource = _db.MealDetails.Where(md => md.MealId == mealId)
                .Select
                (
                x => new
                {
                    FOODNAME = x.Food.Name,
                    GRAM = x.Gram,
                    CALORIE = (x.Gram * x.Food.CaloryPerGram)
                }
                ).ToList();
        }

        #endregion

    }
}
