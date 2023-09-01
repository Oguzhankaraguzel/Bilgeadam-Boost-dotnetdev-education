using Dietary.BLL.Exceptions;
using Dietary.BLL.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;
using LoginWFA.Forms;
using System.Globalization;

namespace LoginWFA
{
    public partial class SignupForm : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(
            int nleft, int nTop, int nRight, int nBottom, int nWidthEllipse, int nHeightEllipse);

        static Random rnd = new Random();
        public static string registro;
        public SignupForm()
        {
            InitializeComponent();
        }

        private void SignupForm_Load(object sender, EventArgs e)
        {
            if (LoginForm.trChanger == 1)
            {
                Language("");
            }
            TextBoxRegionSettings();
        }

        private void txtEMail_TextChanged(object sender, EventArgs e)
        {
            if (txtEMail.Text.Contains("name@gma"))
            {
                txtEMail.Text = "";
            }
        }

        private void txtUserName_TextChanged(object sender, EventArgs e)
        {
            if (txtUserName.Text.Contains("Usernam"))
            {
                txtUserName.Text = "";
            }
        }

        private void txtPassword1_TextChanged(object sender, EventArgs e)
        {
            if (txtPassword1.Text.Contains("Passwo"))
            {
                txtPassword1.Text = "";
            }
        }

        private void txtPassword2_TextChanged(object sender, EventArgs e)
        {
            if (txtPassword2.Text.Contains("Re-"))
            {
                txtPassword2.Text = "";
            }
        }

        private void pctExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pctReturn_Click(object sender, EventArgs e)
        {
            ReturnLoginForm();
        }

        private void btnSingUp_Click(object sender, EventArgs e)
        {
            SecurityService opt = new SecurityService();
            try
            {
                if (cbxAgree.Checked == true)
                {
                    opt.CheckTheEmail(txtEMail.Text);
                    opt.CheckTheUsername(txtUserName.Text);
                    opt.UserNameControl(txtUserName.Text);
                    opt.CheckThePassword(txtPassword1.Text, txtPassword2.Text);
                    //if (RegisterForm.control == false)
                    //{
                    //    RegisterForm registroForm = new RegisterForm();
                    //    MailSend();
                    //    registroForm.Show();
                    //}
                    //if (RegisterForm.control == true)
                    //{
                    opt.CreateNewUser(txtEMail.Text, txtPassword1.Text, txtPassword2.Text, txtUserName.Text);
                    ReturnLoginForm();
                    //    RegisterForm.control = false;
                    //}
                }
                else
                {
                    MessageBox.Show("To register for the program, you must accept the terms of use.", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


        public void MailSend()
        {

            SmtpClient smtp = new SmtpClient()
            {
                Host = "smtp.gmail.com",
                Port = 587,
                EnableSsl = true,
                DeliveryMethod = SmtpDeliveryMethod.Network,
                UseDefaultCredentials = false,
                Credentials = new NetworkCredential()
                {
                    UserName = "remember.me.diet@gmail.com",
                    Password = "acnuiewsgufmxcex"
                }
            };
            registro = rnd.Next(100000, 999999).ToString();
            MailAddress fromMail = new MailAddress("remember.me.diet@gmail.com");
            MailAddress toMail = new MailAddress(txtEMail.Text.Trim());
            MailMessage sms = new MailMessage()
            {
                From = fromMail,
                Subject = "Your registro password : ",
                Body = registro
            };
            
            sms.To.Add(toMail);
            smtp.Send(sms);

        }
        #region Procedurs


        public void Language(string culture)
        {
            Thread.CurrentThread.CurrentUICulture.ClearCachedData();
            Thread.CurrentThread.CurrentUICulture = new CultureInfo(culture);
            label1.Text = SignupLocalization.label1;
            label3.Text = SignupLocalization.label3;
            label4.Text = SignupLocalization.label4;
            label5.Text = SignupLocalization.label5;
            txtEMail.Text = SignupLocalization.txtEMail;
            txtUserName.Text = SignupLocalization.txtUserName;
            txtPassword2.Text = SignupLocalization.txtPassword2;
            txtPassword1.Text = SignupLocalization.txtPassword1;
            btnSingUp.Text = SignupLocalization.btnSingUp;
            cbxAgree.Text = SignupLocalization.cbxAgree;

        }



        private void ReturnLoginForm()
        {
            LoginForm fr = new LoginForm();
            this.Close();
            fr.Show();
        }

        private void TextBoxRegionSettings()
        {
            txtEMail.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, txtEMail.Width, txtEMail.Height, 30, 30));
            txtPassword1.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, txtPassword1.Width, txtPassword1.Height, 30, 30));
            txtUserName.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, txtPassword1.Width, txtUserName.Height, 30, 30));
            txtPassword2.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, txtPassword1.Width, txtPassword2.Height, 30, 30));
            btnSingUp.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btnSingUp.Width, btnSingUp.Height, 35, 35));
        }

        #endregion
    }
}
