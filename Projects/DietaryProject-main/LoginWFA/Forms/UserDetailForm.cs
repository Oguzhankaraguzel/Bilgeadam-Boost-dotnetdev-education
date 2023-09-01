using Dietary.BLL.Services;
using Dietary.Entities.Enums;
using Microsoft.VisualBasic;
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

namespace LoginWFA
{
    public partial class UserDetailForm : Form
    {
        UserDetailServis _uds = new UserDetailServis();
        public UserDetailForm()
        {
            InitializeComponent();
        }

        private void UserDetailForm_Load(object sender, EventArgs e)
        {
            if (LoginForm.trChanger == 1)
            {
                Language("");
            }
            cbGol.DataSource = Enum.GetValues(typeof(GoalEnum));
            cbActivityLevel.DataSource = Enum.GetValues(typeof(ActivityLevelEnum));
            cbGender.DataSource = Enum.GetValues(typeof(GenderEnum));
            cbDiet.DataSource = Enum.GetValues(typeof(DietEnum));

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime date = monthCalendar1.SelectionRange.Start;
            try
            {
                bool control = _uds.AddUserDetails(LoginForm.user, txtFirstName.Text, txtLastName.Text, Convert.ToDecimal(txtHeight.Text), Convert.ToDecimal(txtWeigth.Text), date, cbDiet.SelectedIndex + 1, cbGender.SelectedIndex + 1, cbGol.SelectedIndex + 1, cbActivityLevel.SelectedIndex + 1);

                if (control)
                {
                    MessageBox.Show("Detail saved");
                    RunTheMainForm();
                }
                else
                {
                    CloseOrContinue(MessageBox.Show("Sorry But You Have To Enter All The Information\nIf you want to exit, you can press the cancel button.", "WARNING", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning));
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Sorry, there was an error saving your information. Please try again.\nIf the error persists, please contact us.\nRemember.me@gmail.com", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        //Bu picture box hala programda yok. Eklenmesi gerek
        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Close();
            LoginForm form1 = new LoginForm();
            form1.Show();
        }

        #region Procedur



        public void Language(string culture)
        {
            Thread.CurrentThread.CurrentUICulture.ClearCachedData();
            Thread.CurrentThread.CurrentUICulture = new CultureInfo(culture);
            label10.Text = UserDetailsLocalization.label1;
            label2.Text = UserDetailsLocalization.label2;
            label3.Text = UserDetailsLocalization.label3;
            label4.Text = UserDetailsLocalization.label4;
            label5.Text = UserDetailsLocalization.label5;
            label6.Text = UserDetailsLocalization.label6;
            label9.Text = UserDetailsLocalization.label9;
            button1.Text = UserDetailsLocalization.button1;
            label11.Text = UserDetailsLocalization.label7;



        }


        /// <summary>
        /// iletişim sonucu iptal olarak dönerse programı kapatır.
        /// </summary>
        /// <param name="dr"></param>
        private void CloseOrContinue(DialogResult dr)
        {
            if (dr == DialogResult.OK)
            {

            }
            else
            {
                Application.Exit();
            }
        }

        /// <summary>
        /// mainform'a yönlendirir
        /// </summary>
        private void RunTheMainForm()
        {
            this.Close();
            MainForm mfr = new MainForm();
            mfr.Show();
        }
        #endregion
    }
}
