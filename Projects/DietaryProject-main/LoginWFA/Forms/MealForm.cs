using Dietary.BLL.Exceptions;
using Dietary.BLL.Services;
using Dietary.DAL.Context;
using Dietary.Entities.Entities.EnumEntities;
using Dietary.Entities.Entities.UserEntities;
using Dietary.Entities.Enums;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginWFA
{
    public partial class MealForm : Form
    {
        #region RequiredInstance

        MealService _ms = new MealService();
        DietaryDbContext _db = new DietaryDbContext();
        FoodService _fs = new FoodService();
        UserDetailServis userDetail = new UserDetailServis();
        UserDetail _ud;
        List<Food> table;
        List<RadioButton> radioButtonList;
        List<PictureBox> picboxList;
        int count = 0;
        int mealId = 0;

        #endregion
        public MealForm()
        {
            InitializeComponent();
        }

        private void MealForm_Load(object sender, EventArgs e)
        {
            RenderForm();
        }

        private void btnAddMeal_Click(object sender, EventArgs e)
        {
            try
            {
                mealId = _ms.AddMeal(LoginForm.user, cbMealTime.SelectedIndex + 1, mcMealTime.SelectionRange.Start);
                ActivateAddingFood();
                btnAddMeal.Enabled = false;
                lblCaloryCount.Text = _ms.GetMealCalorie(mealId).ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "REMINDING", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        /*
         * txtFoodName = foodname
         * txtFoodCalory = foodcalory
         * lblCaloryCount.Text = CaloryCount
         */

        private void radioButton1_MouseClick(object sender, MouseEventArgs e)
        {
            FoodNameAndCalory(LoginForm.user, cbFoodType.SelectedIndex + 1);
        }

        private void btnDone_Click(object sender, EventArgs e)
        {
            DeactivateAddingFood();
        }

        private void cbFoodType_SelectedIndexChanged(object sender, EventArgs e)
        {
            panel2.Controls.Clear();
            GetThePhotos(LoginForm.user, cbFoodType.SelectedIndex + 1);
        }

        private void btnAddFood_Click(object sender, EventArgs e)
        {
            try
            {
                if (_ms.CheckAddingFood(txtFoodName.Text))
                {
                    _ms.AddFoodToMeal(mealId, txtFoodName.Text, nudGram.Value);
                    dgvAddingFood.DataSource = null;
                    dgvAddingFood.DataSource = _ms.AddingFoodList(mealId);
                    lblCaloryCount.Text = _ms.GetMealCalorie(mealId).ToString();
                }
                else
                {
                    MessageBox.Show("Cannot add the same meal twice. You can remove the meal from your list and add it again with a new gram amount if you wish.", "REMINDING", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }

            }
            catch (System.InvalidOperationException)
            {
                _ms.AddFoodToMeal(mealId, txtFoodName.Text, nudGram.Value);
                dgvAddingFood.DataSource = null;
                dgvAddingFood.DataSource = _ms.AddingFoodList(mealId);
                lblCaloryCount.Text = _ms.GetMealCalorie(mealId).ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                _ms.DeleteFoodToMeal(mealId, dgvAddingFood.SelectedRows[0].Cells[0].Value.ToString(), (decimal)dgvAddingFood.SelectedRows[0].Cells[1].Value);
                dgvAddingFood.DataSource = null;
                dgvAddingFood.DataSource = _ms.AddingFoodList(mealId);
                lblCaloryCount.Text = _ms.GetMealCalorie(mealId).ToString();
            }
            catch (InvalidFoodException)
            {
                MessageBox.Show("please select a meal to delete", "REMINDING", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void btnDeleteAll_Click(object sender, EventArgs e)
        {
            try
            {
                _ms.DeleteAllMealDetail(mealId);
                dgvAddingFood.DataSource = null;
                dgvAddingFood.DataSource = _ms.AddingFoodList(mealId);
                lblCaloryCount.Text = _ms.GetMealCalorie(mealId).ToString();
            }
            catch (InvalidMealException ex)
            {
                MessageBox.Show("Your meal is currently No food", "REMINDING", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        #region Procedurs

        /// <summary>
        /// Yemek bilgileri girişini aktif eder.
        /// </summary>
        private void ActivateAddingFood()
        {
            lblBonApetite.Text = "Bon Apetite";
            lblFoodType.Text = "Food Type";
            cbFoodType.DataSource = Enum.GetValues(typeof(FoodTypeEnum));
            cbFoodType.Visible = true;
            cbFoodType.SelectedIndex = 1;
            cbFoodType.SelectedIndex = 5;
            lblGram.Text = "How much grams";
            nudGram.Visible = true;
            btnAddFood.Visible = true;
            btnDone.Visible = true;
            txtFoodName.Visible = true;
            txtFoodCalory.Visible = true;
            lblFoodName.Text = "Food Name";
            lblFoodCalory.Text = "Calory Per 100gr";
            lblTotalcal.Text = "Total Calories";
            lblFoodName.Text = "Food Name";
            btnDelete.Visible = true;
            btnDeleteAll.Visible = true;
            dgvAddingFood.Visible = true;
            dgvAddingFood.DataSource = null;
        }

        /// <summary>
        /// yemek bilgileri girişini deaktive eder.
        /// </summary>
        private void DeactivateAddingFood()
        {
            lblBonApetite.Text = "";
            lblFoodType.Text = "";
            cbFoodType.DataSource = null;
            cbFoodType.Visible = false;
            lblGram.Text = "";
            nudGram.Visible = false;
            btnAddFood.Visible = false;
            txtFoodName.Visible = false;
            btnDone.Visible = false;
            txtFoodCalory.Visible = false;
            lblFoodName.Text = "";
            lblFoodCalory.Text = "";
            lblTotalcal.Text = "";
            lblFoodName.Text = "";
            btnAddMeal.Enabled = true;
            panel2.Controls.Clear();
            btnDelete.Visible = false;
            btnDeleteAll.Visible = false;
            dgvAddingFood.Visible = false;
            btnAddFood.Enabled = true;
            dgvAddingFood.DataSource = null;
        }

        /// <summary>
        /// Formdaki comboboxları doldurur.
        /// </summary>
        private void RenderForm()
        {
            cbMealTime.DataSource = Enum.GetValues(typeof(FoodTimeEnum));
            cbMealTime.SelectedIndex = 0;
            mcMealTime.SelectionStart = DateTime.Now;
        }

        /// <summary>
        /// Kullanıcının diyetine ve seçtiği türe göre yemeklerin fotoğraflarını getirir.
        /// </summary>
        /// <param name = "usr" ></ param >
        /// < param name="foodtype"></param>
        private void GetThePhotos(Dietary.Entities.Entities.UserEntities.User usr, int foodType)
        {
            _ud = userDetail.FindUserDetail(usr);
            table = _fs.GetFoodByType(_ud, foodType);
            radioButtonList = new();
            picboxList = new();

            int x = 120;
            int y = 10;
            for (int i = 0; i < table.Count; i++)
            {
                RadioButton radioButton = new RadioButton();
                radioButtonList.Add(radioButton);
                radioButton.MouseClick += new MouseEventHandler(radioButton1_MouseClick);
                radioButton.Name = "radioButton" + i.ToString();
                radioButton.AutoSize = true;
                radioButton.Location = new Point(x, y);
                radioButton.Text = table[i].Name;
                panel2.Controls.Add(radioButton);

                PictureBox pictureBox = new PictureBox();
                picboxList.Add(pictureBox);
                pictureBox.Name = "pictureBox" + i.ToString();
                pictureBox.Width = 200;
                pictureBox.Height = 200;
                pictureBox.Location = new Point(x, y);
                pictureBox.BackColor = Color.Red;
                pictureBox.BorderStyle = BorderStyle.FixedSingle;
                try
                {
                    pictureBox.Image = Image.FromFile(table[i].PhotoPath);
                }
                catch (Exception)
                {
                    pictureBox.ImageLocation = ".\\Food-illustration.png";
                }
                panel2.Controls.Add(pictureBox);
                y += pictureBox.Height + 10;
            }
        }

        /// <summary>
        /// Yemeklerin isimlerini ve kalorilerini ekrana yazdırır.
        /// </summary>
        /// <param name="usr"></param>
        /// <param name="foodType"></param>
        private void FoodNameAndCalory(Dietary.Entities.Entities.UserEntities.User usr, int foodType)
        {
            _ud = userDetail.FindUserDetail(usr);
            table = _fs.GetFoodByType(_ud, foodType);
            int count = 0;
            foreach (RadioButton item in radioButtonList)
            {
                if (item.Checked)
                {
                    break;
                }
                count++;
            }
            txtFoodName.Text = table[count].Name;
            txtFoodCalory.Text = (table[count].CaloryPerGram * 100).ToString();
        }



        #endregion

    }
}
