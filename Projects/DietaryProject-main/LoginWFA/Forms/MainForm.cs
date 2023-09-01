using Dietary.BLL.Services;
using FontAwesome.Sharp;
using LoginWFA.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Interop;

namespace LoginWFA
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            if (LoginForm.trChanger == 1)
            {
                Language("");
            }
            pctCatPicture.ImageLocation = ".\\CatPhoto.png";
            lblUserName.Text = LoginForm.user.UserName;
        }

        public void Language(string culture)
        {
            Thread.CurrentThread.CurrentUICulture.ClearCachedData();
            Thread.CurrentThread.CurrentUICulture = new CultureInfo(culture);
            ıconButton2.Text = MainFormLocalization.ıconButton2;
            ıconButton2.Text = MainFormLocalization.ıconButton3;
            ıconButton4.Text = MainFormLocalization.ıconButton4;
            ıconButton5.Text = MainFormLocalization.ıconButton5;
        }

        private void ıconButton1_Click(object sender, EventArgs e)
        {
            CloseMdiChild();
            ProfilForm frm = new ProfilForm();
            frm.MdiParent = this;
            frm.Show();
            frm.Dock = DockStyle.Fill;
        }

        private void ıconButton2_Click(object sender, EventArgs e)
        {
            CloseMdiChild();
            SummaryForm summaryForm = new SummaryForm();
            summaryForm.MdiParent = this;
            summaryForm.Show();
            summaryForm.Dock = DockStyle.Fill;
        }

        private void ıconButton3_Click(object sender, EventArgs e)
        {
            CloseMdiChild();
            MealForm mealForm = new MealForm();
            mealForm.MdiParent = this;
            mealForm.Show();
            mealForm.Dock = DockStyle.Fill;
        }

        private void ıconButton4_Click(object sender, EventArgs e)
        {
            CloseMdiChild();
            CaloryForm caloryForm = new CaloryForm();
            caloryForm.MdiParent = this;
            caloryForm.Show();
            caloryForm.Dock = DockStyle.Fill;
        }

        private void ıconButton5_Click(object sender, EventArgs e)
        {
            CloseMdiChild();
            ActivitiesForm activitiesForm = new ActivitiesForm();
            activitiesForm.MdiParent = this;
            activitiesForm.Show();
            activitiesForm.Dock = DockStyle.Fill;
        }

        private void ıconButton6_Click(object sender, EventArgs e)
        {

            if (DialogResult.Yes == MessageBox.Show("Do you want to exit ?", "Exit", MessageBoxButtons.YesNo))
            {
                Application.Exit();

            }
        }

        private void ıconButton7_Click(object sender, EventArgs e)
        {
            CloseMdiChild();
            SettingsForm settingsForm = new SettingsForm();
            settingsForm.MdiParent = this;
            settingsForm.Show();
            settingsForm.Dock = DockStyle.Fill;
        }

        private void pctHomeİcon_Click(object sender, EventArgs e)
        {
            CloseMdiChild();
        }

        private void pctHomeİcon_MouseEnter(object sender, EventArgs e)
        {
            pctHomeİcon.BackColor = Color.Gainsboro;
        }

        private void pctHomeİcon_MouseLeave(object sender, EventArgs e)
        {
            pctHomeİcon.BackColor = Color.Transparent;
        }

        #region Procedurs

        private void CloseMdiChild()
        {
            if (this.ActiveMdiChild != null)
            {
                this.ActiveMdiChild.Close();
            }
        }

        #endregion


    }
}
