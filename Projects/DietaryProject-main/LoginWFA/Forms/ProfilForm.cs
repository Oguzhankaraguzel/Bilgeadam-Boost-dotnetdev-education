using Dietary.BLL.Services;
using Dietary.Entities.Entities.EnumEntities;
using Dietary.Entities.Entities.UserEntities;
using Dietary.Entities.Enums;
using Microsoft.VisualBasic.ApplicationServices;
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

namespace LoginWFA
{
    public partial class ProfilForm : Form
    {
        #region Required Instance
        UserDetailServis _uds = new UserDetailServis();
        CaloryService _cs = new CaloryService();
        #endregion

        public ProfilForm()
        {
            InitializeComponent();
        }

        private void ProfilForm_Load(object sender, EventArgs e)
        {
            if (LoginForm.trChanger == 1)
            {
                Language("");
            }
            FillTheDetails(LoginForm.user);
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
            label1.Text = ProfilFormLocalization.label1;
            label2.Text = ProfilFormLocalization.label2;
            label3.Text = ProfilFormLocalization.label3;
            label5.Text = ProfilFormLocalization.label5;
            label6.Text = ProfilFormLocalization.label6;

        }

        /// <summary>
        /// Gelen kullanıcı bilgisine göre formdaki tüm alanları doldurur
        /// </summary>
        /// <param name="usr"></param>
        private void FillTheDetails(Dietary.Entities.Entities.UserEntities.User user)
        {
            var _ud = _uds.FindUserDetail(user);

            //bütün bilgilerin doldurulduğu alan
            lblName.Text = _ud.FirstName + " " + _ud.LastName;
            lblUserName.Text = LoginForm.user.UserName;
            lblEmail.Text = LoginForm.user.Email;
            lblAge.Text = _ud.Age.ToString();
            try
            {
                pictureBox1.ImageLocation = user.UserDetail.PhotoPath;
            }
            catch (Exception)
            {
                pictureBox1.Image = pictureBox1.ErrorImage;
            }
            if (_ud.BodyMassIndex < 18.5m)
            {
                lblStatus.Text = "It wouldn't hurt to have a snack";
            }
            if (_ud.BodyMassIndex > 25m)
            {
                lblStatus.Text = "Some exercise and diet can be beneficial";
            }
            else
            {
                lblStatus.Text = "You are quite fit";
            }

        }
        #endregion

    }
}
