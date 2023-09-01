using Dietary.BLL.Services;
using FontAwesome.Sharp;
using Microsoft.Identity.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginWFA.Forms
{
    public partial class RegisterForm : Form
    {
        UserDetailServis _uds = new UserDetailServis();
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(
            int nleft, int nTop, int nRight, int nBottom, int nWidthEllipse, int nHeightEllipse);
        public static bool control = false;
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void RegistroForm_Load(object sender, EventArgs e)
        {
            timer1.Interval = 1000;
            timer1.Start();

            txtCode.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, txtCode.Width, txtCode.Height, 30, 30));

            btnOk.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btnOk.Width, btnOk.Height, 35, 35));

            if (LoginForm.trChanger == 1)
            {
                Language("");
            }

        }

        public void Language(string culture)
        {
            Thread.CurrentThread.CurrentUICulture.ClearCachedData();
            Thread.CurrentThread.CurrentUICulture = new CultureInfo(culture);
            label1.Text = RegisterFormLocalization.label1;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (Convert.ToInt32(lblCounter.Text) <= 0)
            {
                timer1.Stop();

            }
            lblCounter.Text = (Convert.ToInt32(lblCounter.Text) - 1).ToString();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (txtCode.Text != SignupForm.registro)
            {
                MessageBox.Show("Wrong registro");
            }
            else
            {
                control = true;
                this.Close();
            }
        }


    }
}
