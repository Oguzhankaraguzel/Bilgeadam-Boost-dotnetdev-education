using Dietary.BLL.Services;
using Dietary.DAL.Context;
using Dietary.Entities.Entities.EnumEntities;
using Dietary.Entities.Entities.UserEntities;
using LoginWFA.Properties;
using Microsoft.VisualBasic.ApplicationServices;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace LoginWFA
{

    public partial class CaloryForm : Form
    {
        #region RequiredInstance
        MealService _ms = new MealService();
        DietaryDbContext _db = new DietaryDbContext();
        UserDetailServis userDetailServis = new UserDetailServis();
        FoodService _foodService = new FoodService();
        List<RadioButton> rbList = new List<RadioButton>();
        #endregion

        public CaloryForm()
        {
            InitializeComponent();

        }

        private void CaloryForm_Load(object sender, EventArgs e)
        {
            if (LoginForm.trChanger == 1)
            {
                Languages("");
            }
            GetThePhoto(LoginForm.user);
        }
        private void radioButton1_MouseClick(object sender, MouseEventArgs e)
        {
            FoodNameAndCalory(LoginForm.user);
        }

        #region Procedurs



        public void Languages(string culture)
        {
            
            Thread.CurrentThread.CurrentUICulture.ClearCachedData();
            Thread.CurrentThread.CurrentUICulture = new CultureInfo(culture);
            label5.Text = CalorieLocalization.label5;
            label4.Text = CalorieLocalization.label4;
        }



        /// <summary>
        /// Seçilen radiobutton'un temsil ettiği yemeğim adı ve kalori bilgisi textboxlara yazdırılır.
        /// </summary>
        /// <param name="usr"></param>
        private void FoodNameAndCalory(Dietary.Entities.Entities.UserEntities.User usr)
        {
            var detail = userDetailServis.FindUserDetail(usr);
            var table = _foodService.GetTableFood(detail);

            var table2 = table.GroupBy(x => new { x.Name, x.Id, x.CaloryPerGram }).Where(grp => grp.Count() > 1).Select(grp => grp.Key).ToList();
            int count = 0;
            foreach (RadioButton item in rbList)
            {
                if (item.Checked)
                {
                    break;
                }
                count++;
            }
            var food = _db.Foods.FirstOrDefault(f => f.Id == count);
            txtFoodName.Text = table2[count].Name;
            txtFoodCalory.Text = (table2[count].CaloryPerGram * 100).ToString();
        }



        /// <summary>
        /// kullanıcıya göre yemeklerin resimlerini ekrana radio buttonlar ile geririr
        /// </summary>
        /// <param name="usr"></param>
        private void GetThePhoto(Dietary.Entities.Entities.UserEntities.User usr)
        {
            var detail = userDetailServis.FindUserDetail(usr);
            // kullanıcının tercih edebileceği tüm yemeklerin resimleri 
            var table = _foodService.GetTableFood(detail);
            var table2 = table.GroupBy(x => new { x.Id, x.Name, x.CaloryPerGram, x.PhotoPath }).Where(grp => grp.Count() > 1).Select(grp => grp.Key).ToList();

            int y = 250;
            int x = 75;
            int count = 1;
            List<Label> lbList = new List<Label>();

            for (int i = 0; i < table2.Count; i++)
            {
                Label lbl = new Label();
                lbList.Add(lbl);
                if (count < 2)
                {
                    lbl.Text = table2[i].Name.ToString();
                    lbl.Location = new Point(x, y);
                    lbl.Font = new Font("Century Gothic", 11);
                    lbl.ForeColor = Color.Gainsboro;
                    panel1.Controls.Add(lbl);
                    x += 400;
                    count++;
                }
                else
                {
                    lbl.Text = table2[i].Name.ToString();
                    lbl.Location = new Point(x, y);
                    lbl.Font = new Font("Century Gothic", 11);
                    lbl.ForeColor = Color.Gainsboro;

                    panel1.Controls.Add(lbl);
                    y += 300;
                    x = 75;
                    count = 1;
                }
            }
            y = 0;
            x = 75;
            count = 1;
            for (int i = 0; i < table2.Count; i++)
            {
                RadioButton rb = new RadioButton();
                rb.MouseClick += new MouseEventHandler(radioButton1_MouseClick);
                rbList.Add(rb);
                if (count < 2)
                {
                    rb.Name = i.ToString();
                    rb.Location = new Point(x, y);
                    // formun üzerine PictureBox denetimini ekleyin
                    panel1.Controls.Add(rb);
                    x += 400;
                    count++;
                }
                else
                {
                    rb.Location = new Point(x, y);
                    // formun üzerine PictureBox denetimini ekleyin
                    panel1.Controls.Add(rb);
                    y += 300;
                    x = 75;
                    count = 1;
                }
            }
            y = 0;
            x = 75;
            List<PictureBox> picBoxList = new List<PictureBox>();
            int totalMeals = _ms.CountMeals();
            count = 1;
            // yeni bir PictureBox oluşturun
            for (int i = 0; i < table2.Count; i++)
            {
                PictureBox pictureBox1 = new PictureBox();
                picBoxList.Add(pictureBox1);
                if (count < 2)
                {
                    pictureBox1.Width = 250;
                    pictureBox1.Height = 250;
                    pictureBox1.Location = new Point(x, y);
                    pictureBox1.BackColor = Color.Red;
                    pictureBox1.BorderStyle = BorderStyle.FixedSingle;
                    try
                    {
                        pictureBox1.Image = Image.FromFile(table2[i].PhotoPath);
                    }
                    catch (Exception)
                    {
                        pictureBox1.ImageLocation = ".\\Food-illustration.png";
                    }
                    pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                    // formun üzerine PictureBox denetimini ekleyin
                    panel1.Controls.Add(pictureBox1);
                    x += 400;
                    count++;
                }


                else
                {
                    pictureBox1.Width = 250;
                    pictureBox1.Height = 250;
                    pictureBox1.Location = new Point(x, y);
                    pictureBox1.BackColor = Color.Red;
                    pictureBox1.BorderStyle = BorderStyle.FixedSingle;
                    try
                    {
                        pictureBox1.Image = Image.FromFile(table2[i].PhotoPath);
                    }
                    catch (Exception)
                    {
                        pictureBox1.ImageLocation = ".\\Food-illustration.png";
                    }
                    pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                    // formun üzerine PictureBox denetimini ekleyin
                    panel1.Controls.Add(pictureBox1);
                    y += 300;
                    x = 75;
                    count = 1;
                }
            }


        }

        #endregion

    }
}
