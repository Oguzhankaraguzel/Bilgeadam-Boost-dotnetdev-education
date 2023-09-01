using Dietary.BLL.Services;
using Dietary.DAL.Context;
using Dietary.Entities.Entities.UserEntities;
using FontAwesome.Sharp;
using LoginWFA.Resources;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Dynamic;
using System.Globalization;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginWFA
{
    public partial class SettingsForm : Form
    {
        #region RequiredInstance
        UserDetailServis _uds = new UserDetailServis();
        SecurityService _ss = new SecurityService();
        DietaryDbContext _db = new DietaryDbContext();
        FoodService _fs = new FoodService();
        string photoPath;
        #endregion

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(
            int nleft, int nTop, int nRight, int nBottom, int nWidthEllipse, int nHeightEllipse);
        public SettingsForm()
        {
            InitializeComponent();
        }
        private void SettingsForm_Load(object sender, EventArgs e)
        {
            TextBoxRegionSettings();
            FillTheComboBox();
            if (LoginForm.trChanger == 1)
            {
                Language("");
            }
        }

        private void ibSavePhoto_Click_1(object sender, EventArgs e)
        {
            UserDetail detail = _uds.FindUserDetail(LoginForm.user);
            detail.PhotoPath = ChoosePhotoPath();
            _db.UserDetails.Update(detail);
            _db.SaveChanges();
        }

        private void btnSaveThePassword_Click_1(object sender, EventArgs e)
        {
            try
            {
                bool control = _uds.ChangePassword(LoginForm.user, txtPassword2.Text, txtPassword1.Text);
                if (control)
                {
                    MessageBox.Show("Password changed");
                }
                else
                {
                    MessageBox.Show("Password could not be changed");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void txtPassword2_TextChanged_1(object sender, EventArgs e)
        {
            if (txtPassword1.Text.Contains("Passwo"))
            {
                txtPassword1.Text = "";
            }
        }

        private void txtPassword1_TextChanged_1(object sender, EventArgs e)
        {
            if (txtPassword2.Text.Contains("Re-"))
            {
                txtPassword2.Text = "";
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            photoPath = ChoosePhotoPath();
            pctFoodPhoto.ImageLocation = photoPath;
        }

        private void btnAddFood_Click(object sender, EventArgs e)
        {
            try
            {
                _fs.AddFood(txtFoodName.Text, nudCalorie.Value / 100m, photoPath, GetDietId(), GetFoodTypeIds(), GetFoodTimeIds());
                MessageBox.Show(txtFoodName.Text + " successfully added");
                FillTheComboBox();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "REMINDING", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnDeleteFood_Click(object sender, EventArgs e)
        {
            try
            {
                _fs.DeleteFood(cbxFoodNameList.SelectedItem.ToString());
                MessageBox.Show(cbxFoodNameList.SelectedItem.ToString() + " succesfully deleted", "INFORMATION", MessageBoxButtons.OK, MessageBoxIcon.Information);
                FillTheComboBox();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "REMINDING", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnChangePersonelInformation_Click(object sender, EventArgs e)
        {
            UserDetailForm _udf = new();
            _udf.Show();
            _udf.BringToFront();
            this.Close();
        }

        #region Procedurs

        public void Language(string culture)
        {
            Thread.CurrentThread.CurrentUICulture.ClearCachedData();
            Thread.CurrentThread.CurrentUICulture = new CultureInfo(culture);
            btnAddFood.Text = SettingsFormLocalization.btnAddFood;
            btnChangePersonelInformation.Text = SettingsFormLocalization.btnChangePersonelInformation;
            btnDeleteFood.Text = SettingsFormLocalization.btnDeleteFood;
            btnSaveThePassword.Text = SettingsFormLocalization.btnSaveThePassword;
            grpDietType.Text = SettingsFormLocalization.grpDietType;
            label1.Text = SettingsFormLocalization.label1;
            label11.Text = SettingsFormLocalization.label11;
            label12.Text = SettingsFormLocalization.label12;
            label2.Text = SettingsFormLocalization.label2;
            label4.Text = SettingsFormLocalization.label4;
            label5.Text = SettingsFormLocalization.label5;
            label6.Text = SettingsFormLocalization.label6;
            label8.Text = SettingsFormLocalization.label8;
            label9.Text = SettingsFormLocalization.label9;
            linkLabel1.Text = SettingsFormLocalization.linkLabel1;

        }

        private void FillTheComboBox()
        {
            foreach (string foodName in _fs.GetFoodName())
            {
                cbxFoodNameList.Items.Add(foodName);
            }
        }

        /// <summary>
        /// Kullanıcıya bilgisayardan fotograf seçtirten metot.
        /// </summary>
        /// <returns></returns>
        public string ChoosePhotoPath()
        {
            DialogResult dr = MessageBox.Show("Would you like to upload a photo", "Reminder", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);
            if (dr == DialogResult.Yes)
            {
                string filename;

                var loadDialog = new OpenFileDialog { Filter = "JPEG File|*.jpeg", InitialDirectory = @"C:\Your\Start\Directory" };

                if (loadDialog.ShowDialog() == DialogResult.OK)
                {
                    filename = loadDialog.FileName;
                    return filename;
                }

                else
                {
                    return null;
                }
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// textbox region ayarlarını düzenler
        /// </summary>
        private void TextBoxRegionSettings()
        {
            txtPassword2.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, txtPassword2.Width, txtPassword2.Height, 30, 30));
            txtPassword1.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, txtPassword1.Width, txtPassword1.Height, 30, 30));
            btnSaveThePassword.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btnSaveThePassword.Width, btnSaveThePassword.Height, 35, 35));
        }

        /// <summary>
        /// cblFoodType listesindeki seçilen yemek türlerinin indexlerini bir listeye alır.
        /// </summary>
        /// <returns>Listeyi döndürür</returns>
        private List<int> GetFoodTypeIds()
        {
            List<int> ids = new List<int>();

            foreach (int item in cblFoodType.CheckedIndices)
            {
                ids.Add(item + 1);
            }
            return ids;
        }



        /// <summary>
        /// cblMealTime seçilen yemek vakitlerinin indexlerini bir listeye ekler
        /// </summary>
        /// <returns>listeyi döndürür</returns>
        private List<int> GetFoodTimeIds()
        {
            List<int> ids = new List<int>();
            foreach (int item in cblMealTime.CheckedIndices)
            {
                ids.Add(item + 1);
            }
            return ids;
        }

        private int GetDietId()
        {
            if (rdbVegan.Checked == true)
            {
                return 1;
            }
            if (rdbVegetarian.Checked == true)
            {
                return 2;
            }
            if (rdbVegetarian.Checked == true)
            {
                return 3;
            }
            throw new ArgumentException("Please select a diet");
        }

        #endregion

    }
}
