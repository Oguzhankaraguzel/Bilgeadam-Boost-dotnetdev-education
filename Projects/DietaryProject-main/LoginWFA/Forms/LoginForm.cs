using Dietary.BLL.Services;
using Dietary.Entities.Entities;
using Dietary.Entities.Entities.UserEntities;
using System.Runtime.InteropServices;
using System.Globalization;
using System.Threading;


namespace LoginWFA
{
    public partial class LoginForm : Form
    {
        UserDetailServis _uds = new UserDetailServis();
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(
            int nleft, int nTop, int nRight, int nBottom, int nWidthEllipse, int nHeightEllipse);
        public LoginForm()
        {
            InitializeComponent();
        }

        public void Languages(string culture)
        {
            MainForm mainForm = new MainForm();
            Thread.CurrentThread.CurrentUICulture.ClearCachedData();
            Thread.CurrentThread.CurrentUICulture = new CultureInfo(culture);
            lblilk.Text = Localization.lblilk;
            label2.Text = Localization.label2;
            label3.Text = Localization.label3;
            label4.Text = Localization.label4;
            label6.Text = Localization.label6;
            txtUserNameOrEMail.Text = Localization.textBox1;
            txtPassword.Text = Localization.textBox2;
            button1.Text = Localization.button1;
            button2.Text = Localization.button2;
            label1.Text = Localization.label1;

        }

        private void Form1_Load(object sender, EventArgs e)
        {
          
            txtUserNameOrEMail.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, txtUserNameOrEMail.Width, txtUserNameOrEMail.Height, 30, 30));
            txtPassword.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, txtPassword.Width, txtPassword.Height, 30, 30));
            button1.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, button1.Width, button1.Height, 35, 35));
            button2.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, button2.Width, button2.Height, 35, 35));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SignupForm sf = new SignupForm();
            sf.Show();
            this.Hide();
        }

        private void txtUserNameOrEMail_TextChanged(object sender, EventArgs e)
        {
            if (txtUserNameOrEMail.Text.Contains("Usernam"))
            {
                txtUserNameOrEMail.Text = "";
            }
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            if (txtPassword.Text.Contains("Passwor"))
            {
                txtPassword.Text = "";
            }
            if (checkBox1.Checked == false)
            {
                txtPassword.PasswordChar = '*';
            }
            else
            {
                txtPassword.PasswordChar = default;
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == false)
            {
                txtPassword.PasswordChar = '*';
            }
            else
            {
                txtPassword.PasswordChar = default;
            }
        }
        public static User user;
        private void button1_Click(object sender, EventArgs e)
        {
            SecurityService opt = new SecurityService();
            if (opt.UserLogin(txtUserNameOrEMail.Text, txtPassword.Text))
            {
                user = _uds.FindUser(txtUserNameOrEMail.Text);
                if (_uds.ControlDetail(user))
                {
                    MainForm mainForm = new MainForm();
                    mainForm.Show();
                    this.Hide();
                }
                else
                {
                    UserDetailForm userDetailForm = new UserDetailForm();
                    userDetailForm.Show();
                    this.Hide();
                }

            }
            else
            {
                MessageBox.Show("Login Failed. Please try again or sign up");
            }
        }
        public static int trChanger = 0;

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            trChanger = 1;
            Languages("");
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

    }
}