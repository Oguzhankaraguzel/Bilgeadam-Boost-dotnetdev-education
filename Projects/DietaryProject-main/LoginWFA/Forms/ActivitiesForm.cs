using Dietary.BLL.Services;
using Dietary.Entities.Enums;
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
    public partial class ActivitiesForm : Form
    {
        UserDetailServis _uds = new();
        CaloryService _cs = new();
        public ActivitiesForm()
        {

            InitializeComponent();
        }

        private void ActivitiesForm_Load(object sender, EventArgs e)
        {
            if (LoginForm.trChanger == 1)
            {
                Language("");
            }
            RenderForm();
            WeightStatusAndSuggestion();
        }

        #region Procedurs

        public void Language(string culture)
        {
            Thread.CurrentThread.CurrentUICulture.ClearCachedData();
            Thread.CurrentThread.CurrentUICulture = new CultureInfo(culture);
            label3.Text = ActivityLocalization.label3;
            label5.Text = ActivityLocalization.label5;
            label13.Text = ActivityLocalization.label13;
            lbl1.Text = ActivityLocalization.lbl1;
            label10.Text = ActivityLocalization.label10;
            label8.Text = ActivityLocalization.label8;
            label6.Text = ActivityLocalization.label6;
            lblWeightStatus.Text = ActivityLocalization.lblWeightStatus;
            lblSuggestion.Text = ActivityLocalization.lblSuggestion;


        }

        private void RenderForm()
        {
            var ud = _uds.FindUserDetail(LoginForm.user);
            lblHeight.Text = ud.Height.ToString() + " cm";
            lblWeight.Text = ud.Weigth.ToString() + " kg";
            lblAMR.Text = Math.Round(ud.AMR).ToString() + " Calorie";
            lblGoal.Text = Enum.GetName(typeof(GoalEnum), ud.GoalId);
            lblVKI.Text = ud.BodyMassIndex.ToString();
            lblActivitieStatus.Text = Enum.GetName(typeof(ActivityLevelEnum), ud.ActivityLevelId);
            lblWeeklyCaloryAverage.Text = Math.Round(_cs.UserTakenCaloryWeeklyAvg(LoginForm.user)).ToString() + " Calorie";
        }

        private void WeightStatusAndSuggestion()
        {
            var ud = _uds.FindUserDetail(LoginForm.user);
            if (_cs.UserTakenCaloryWeeklyAvg(LoginForm.user) <= (ud.AMR * 0.95m))
            {
                lblWeightStatus.Text = "YOU ARE LOSING WEIGHT";
            }
            else if (_cs.UserTakenCaloryWeeklyAvg(LoginForm.user) >= (ud.AMR * 1.05m))
            {
                lblWeightStatus.Text = "YOU ARE GAINIG WEIGHT";
            }
            else
            {
                lblWeightStatus.Text = "YOU ARE MAINTAINING YOUR WEIGHT";
            }
            if (_cs.UserTakenCaloryWeeklyAvg(LoginForm.user) < (ud.BMR))
            {
                lblSuggestion.Text = "According to the information you have given us, it seems that you are not consuming the minimum amount of calories you need per day, this can lead to serious health problems. Please pay attention to your diet.";
            }
            else if (ud.BodyMassIndex < 18.5m)
            {
                lblSuggestion.Text = "Your body mass index is below 18.5! A healthy individual's body mass index should be between 18.5 and 25. Our advice is to maintain your body mass index between 18.5 and 25 for our health. We recommend that you consult your dietitian or doctor.";
            }
            else if (ud.BodyMassIndex >= 18.5m && ud.BodyMassIndex <= 25m)
            {
                lblSuggestion.Text = "You have the body mass index value of a healthy individual. For your health, it is good to keep our weight";
            }
            else
            {
                lblSuggestion.Text = "Your body mass index is above 25. For your health, please keep your BMI between 18.5 and 25. For this, our advice to you is to lose weight. please contact your dietitian and doctor";
            }

        }

        #endregion
    }
}
