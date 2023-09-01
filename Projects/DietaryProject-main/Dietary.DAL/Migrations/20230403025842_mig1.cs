using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Dietary.DAL.Migrations
{
    /// <inheritdoc />
    public partial class mig1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ActivityLevels",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ActivityLevels", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Diets",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Diets", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Foods",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CaloryPerGram = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    PhotoPath = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Photo = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Foods", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "FoodTimes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FoodTimes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "FoodTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FoodTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Genders",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Genders", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Goals",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Goals", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "FoodFeatures",
                columns: table => new
                {
                    FoodId = table.Column<int>(type: "int", nullable: false),
                    DietId = table.Column<int>(type: "int", nullable: false),
                    FoodTypeId = table.Column<int>(type: "int", nullable: false),
                    FoodTimeId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FoodFeatures", x => new { x.DietId, x.FoodId, x.FoodTypeId, x.FoodTimeId });
                    table.ForeignKey(
                        name: "FK_FoodFeatures_Diets_DietId",
                        column: x => x.DietId,
                        principalTable: "Diets",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FoodFeatures_FoodTimes_FoodTimeId",
                        column: x => x.FoodTimeId,
                        principalTable: "FoodTimes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FoodFeatures_FoodTypes_FoodTypeId",
                        column: x => x.FoodTypeId,
                        principalTable: "FoodTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FoodFeatures_Foods_FoodId",
                        column: x => x.FoodId,
                        principalTable: "Foods",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserDetails",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "int", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BirthDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Weigth = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Height = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ActivityLevelId = table.Column<int>(type: "int", nullable: false),
                    PhotoPath = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Photo = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    DietId = table.Column<int>(type: "int", nullable: false),
                    GoalId = table.Column<int>(type: "int", nullable: false),
                    GenderId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserDetails", x => x.UserId);
                    table.ForeignKey(
                        name: "FK_UserDetails_ActivityLevels_ActivityLevelId",
                        column: x => x.ActivityLevelId,
                        principalTable: "ActivityLevels",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserDetails_Diets_DietId",
                        column: x => x.DietId,
                        principalTable: "Diets",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserDetails_Genders_GenderId",
                        column: x => x.GenderId,
                        principalTable: "Genders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserDetails_Goals_GoalId",
                        column: x => x.GoalId,
                        principalTable: "Goals",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserDetails_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Meals",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserDetailId = table.Column<int>(type: "int", nullable: false),
                    FoodTimeId = table.Column<int>(type: "int", nullable: false),
                    MealTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CaloriesTaken = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Meals", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Meals_FoodTimes_FoodTimeId",
                        column: x => x.FoodTimeId,
                        principalTable: "FoodTimes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Meals_UserDetails_UserDetailId",
                        column: x => x.UserDetailId,
                        principalTable: "UserDetails",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MealDetails",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MealId = table.Column<int>(type: "int", nullable: false),
                    FoodId = table.Column<int>(type: "int", nullable: false),
                    Gram = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MealDetails", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MealDetails_Foods_FoodId",
                        column: x => x.FoodId,
                        principalTable: "Foods",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MealDetails_Meals_MealId",
                        column: x => x.MealId,
                        principalTable: "Meals",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "ActivityLevels",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Sedentary" },
                    { 2, "LightlyActive" },
                    { 3, "ModeratelyActive" },
                    { 4, "Active" },
                    { 5, "VeryActive" }
                });

            migrationBuilder.InsertData(
                table: "Diets",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Vegan" },
                    { 2, "Vegetarian" },
                    { 3, "Normal" }
                });

            migrationBuilder.InsertData(
                table: "FoodTimes",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Breakfast" },
                    { 2, "Lunch" },
                    { 3, "Dinner" },
                    { 4, "Snack" }
                });

            migrationBuilder.InsertData(
                table: "FoodTypes",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "MainCourse" },
                    { 2, "SideMeal" },
                    { 3, "Soup" },
                    { 4, "grain" },
                    { 5, "ForBreakfast" },
                    { 6, "Snack" },
                    { 7, "Drink" },
                    { 8, "Salad" },
                    { 9, "Desert" },
                    { 10, "Fruit" }
                });

            migrationBuilder.InsertData(
                table: "Foods",
                columns: new[] { "Id", "CaloryPerGram", "Name", "Photo", "PhotoPath" },
                values: new object[,]
                {
                    { 1, 1.19m, "Grilled chicken", null, ".\\Grilled Chicken.jpg" },
                    { 2, 2.89m, "Steak", null, ".\\Steak.jpg" },
                    { 3, 2.19m, "Salmon", null, ".\\Salmon.jpg" },
                    { 4, 1.29m, "Tuna", null, ".\\Tuna.jpg" },
                    { 5, 0.89m, "Cod", null, ".\\Cod.jpg" },
                    { 6, 1.99m, "Shrimp", null, ".\\Shrimp.jpg" },
                    { 7, 1.79m, "Beef stir-fry", null, ".\\Beef stir-fry.jpg" },
                    { 8, 1.39m, "Chicken fajitas", null, ".\\Chicken fajitas.jpg" },
                    { 9, 2.09m, "Meatloaf", null, ".\\Meatloaf.jpg" },
                    { 10, 1.59m, "Grilled fish", null, ".\\Grilled fish.jpg" },
                    { 11, 2.49m, "Pork chops", null, ".\\Pork chops.jpg" },
                    { 12, 2.29m, "Chicken parmesan", null, ".\\Chicken parmesan.jpg" },
                    { 13, 1.89m, "Beef stew", null, ".\\Beef stew.jpg" },
                    { 14, 1.69m, "Pasta with meat sauce", null, ".\\Bacon.jpg" },
                    { 15, 1.49m, "Meatballs", null, ".\\Meatballs.jpg" },
                    { 16, 1.59m, "Turkey chili", null, ".\\Turkey chili.jpg" },
                    { 17, 2.79m, "Beef burgers", null, ".\\Beef burgers.jpg" },
                    { 18, 1.99m, "Chicken curry", null, ".\\Chicken curry.jpg" },
                    { 19, 1.79m, "Spaghetti Bolognese", null, ".\\Spaghetti bolognese.jpg" },
                    { 20, 2.39m, "Roasted pork loin", null, ".\\Roasted pork loin.jpg" },
                    { 21, 0.25m, "Grilled Eggplant", null, ".\\Grilled Eggplant.jpg" },
                    { 22, 0.39m, "Stuffed Zucchini", null, ".\\Stuffed Zucchini.jpg" },
                    { 23, 0.43m, "Roasted Brussels Sprouts", null, ".\\Roasted brussel sprouts.jpg" },
                    { 24, 0.4m, "Cauliflower Fried Rice", null, ".\\Fried rice.jpg" },
                    { 25, 0.27m, "Sautéed Kale", null, ".\\Sautéed Kale.jpg" },
                    { 26, 0.76m, "Roasted Sweet Potatoes", null, ".\\Roasted sweet potatoes.jpg" },
                    { 27, 0.12m, "Stir-Fried Bok Choy", null, ".\\Stir-fried bok choy.jpg" },
                    { 28, 0.2m, "Grilled Asparagus", null, ".\\Grilled Asparagus.jpg" },
                    { 29, 0.41m, "Roasted Carrots", null, ".\\Roasted Carrots.jpg" },
                    { 30, 0.34m, "Mushroom Risotto", null, ".\\Mushroom Risotto.jpg" },
                    { 31, 0.35m, "Steamed broccoli", null, ".\\Steamed broccoli.jpg" },
                    { 32, 0.27m, "Roasted asparagus", null, ".\\Roasted asparagus.jpg" },
                    { 33, 0.86m, "Mashed potatoes", null, ".\\Mashed potatoes.jpg" },
                    { 34, 0.33m, "Garlic green beans", null, ".\\Garlic green beans.jpg" },
                    { 35, 0.17m, "Grilled zucchini", null, ".\\Grilled zucchini.jpg" },
                    { 36, 0.69m, "Creamed spinach", null, ".\\Creamed spinach.jpg" },
                    { 37, 1.05m, "Fried rice", null, ".\\Fried rice.jpg" },
                    { 38, 1.3m, "Sweet potato fries", null, ".\\Sweet potato fries.jpg" },
                    { 39, 0.86m, "Baked beans", null, ".\\Bakedbeans.jpg" },
                    { 40, 0.35m, "Tomato soup", null, ".\\Tomato soup.jpg" },
                    { 41, 0.25m, "Pumpkin soup", null, ".\\Pumpkin soup.jpg" },
                    { 42, 0.4m, "Mushroom soup", null, ".\\Mushroom soup.jpg" },
                    { 43, 0.45m, "Chicken noodle soup", null, ".\\Chicken noodle soup.jpg" },
                    { 44, 0.4m, "Beef soup", null, ".\\Beef soup.jpg" },
                    { 45, 0.35m, "Corn soup", null, ".\\Corn soup.jpg" },
                    { 46, 0.3m, "Minestrone soup", null, ".\\Minestrone soup.jpg" },
                    { 47, 0.25m, "Vegetable soup", null, ".\\Vegetable soup.jpg" },
                    { 48, 0.5m, "Clam chowder", null, ".\\Clam chowder.jpg" },
                    { 49, 0.3m, "Lentil soup", null, ".\\Lentil soup.jpg" },
                    { 50, 3.75m, "Rice", null, ".\\Rice.jpg" },
                    { 51, 2.64m, "Bread", null, ".\\Bread.jpg" },
                    { 52, 3.38m, "Pasta", null, ".\\Pasta.jpg" },
                    { 53, 3.68m, "Quinoa", null, ".\\Quinoa.jpg" },
                    { 54, 3.33m, "Bulgur", null, ".\\Bulgur.jpg" },
                    { 55, 3.81m, "Couscous", null, ".\\Couscous.jpg" },
                    { 56, 3.37m, "Oats", null, ".\\Oats.jpg" },
                    { 57, 3.44m, "Barley", null, ".\\Barley.jpg" },
                    { 58, 3.3m, "Wheat berries", null, ".\\Wheat berries.jpg" },
                    { 59, 3.72m, "Wild rice", null, ".\\Wild rice.jpg" },
                    { 60, 0.68m, "Oatmeal", null, ".\\Oatmeal.jpg" },
                    { 61, 1.34m, "Scrambled Eggs", null, ".\\Scrambled eggs.jpg" },
                    { 62, 5.42m, "Bacon", null, ".\\Bacon.jpg" },
                    { 63, 4.85m, "Sausage", null, ".\\Sausage.jpg" },
                    { 64, 2.92m, "French Toast", null, ".\\French toast.jpg" },
                    { 65, 2.86m, "Waffles", null, ".\\Waffles.jpg" },
                    { 66, 2.52m, "Pancakes", null, ".\\Pancakes.jpg" },
                    { 67, 2.71m, "Bagel", null, ".\\Bagel.jpg" },
                    { 68, 3.79m, "Cream Cheese", null, ".\\Cream Cheese.jpg" },
                    { 69, 0.67m, "Fruit Salad", null, ".\\Bacon.jpg" },
                    { 70, 5.85m, "Popcorn", null, ".\\Popcorn.jpg" },
                    { 71, 4.2m, "Trail Mix", null, ".\\Tail mix.jpg" },
                    { 72, 4.0m, "Energy Bars", null, ".\\Energy Bars.jpg" },
                    { 73, 0.73m, "Fruit Cups", null, ".\\Fruit cups.jpg" },
                    { 74, 0.75m, "Yogurt Cups", null, ".\\Yogurt cups.jpg" },
                    { 75, 6.0m, "Nuts", null, ".\\Nuts.jpg" },
                    { 76, 3.0m, "Cheese and Crackers", null, ".\\Cheese and Crackers.jpg" },
                    { 77, 3.17m, "Pretzels", null, ".\\Pretzels.jpg" },
                    { 78, 1.0m, "Hummus", null, ".\\Hummus.jpg" },
                    { 79, 5.0m, "Dark Chocolate", null, ".\\Dark chocolate.jpg" },
                    { 80, 0m, "Water", null, ".\\Water.jpg" },
                    { 81, 0.16m, "Tea", null, ".\\Tea.jpg" },
                    { 82, 0.1m, "Coffee", null, ".\\Coffee.jpg" },
                    { 83, 0.44m, "Juice", null, ".\\Juice.jpg" },
                    { 84, 0.67m, "Milk", null, ".\\Milk.jpg" },
                    { 85, 0.41m, "Soda", null, ".\\Soda.jpg" },
                    { 86, 0m, "Mineral Water", null, ".\\Mineral Water.jpg" },
                    { 87, 0.1m, "Turkhis Coffee", null, ".\\Bacon.jpg" },
                    { 88, 0.4m, "Lemonade", null, ".\\Lemonade.jpg" },
                    { 89, 0.56m, "Smoothie", null, ".\\Smoothie.jpg" },
                    { 90, 1.13m, "Caesar Salad", null, ".\\Caesar salad.jpg" },
                    { 91, 1.05m, "Cobb Salad", null, ".\\Cobb salad.jpg" },
                    { 92, 0.96m, "Greek Salad", null, ".\\Greek salad.jpg" },
                    { 93, 0.89m, "Caprese Salad", null, ".\\Caprese salad.jpg" },
                    { 94, 0.81m, "Spinach Salad", null, ".\\Spinach salad.jpg" },
                    { 95, 0.76m, "Coleslaw", null, ".\\Coleslaw.jpg" },
                    { 96, 0.92m, "Waldorf Salad", null, ".\\Waldorf salad.jpg" },
                    { 97, 0.78m, "Beetroot Salad", null, ".\\Beetroot salad.jpg" },
                    { 98, 0.88m, "Pasta Salad", null, ".\\Pasta Salad.jpg" },
                    { 99, 0.98m, "Tuna Salad", null, ".\\Tuna salad.jpg" },
                    { 100, 3.87m, "Chocolate cake", null, ".\\Chocolate Cake.jpg" },
                    { 101, 2.8m, "Apple pie", null, ".\\Applepie.jpg" },
                    { 102, 3.0m, "Pumpkin pie", null, ".\\Pumpkin pie.jpg" },
                    { 103, 3.2m, "Cheesecake", null, ".\\Cheesecake.jpg" },
                    { 104, 2.89m, "Strawberry shortcake", null, ".\\Strawberry Shortcake.jpg" },
                    { 105, 1.5m, "Ice cream", null, ".\\Ice Cream.jpg" },
                    { 106, 3.6m, "Brownie", null, ".\\Brownie.jpg" },
                    { 107, 1.08m, "Fruit salad", null, ".\\Fruit Salad.jpg" },
                    { 108, 1.83m, "Banana pudding", null, ".\\Bananapudding.jpg" },
                    { 109, 3.1m, "Tiramisu", null, ".\\Tiramisu.jpg" },
                    { 110, 0.52m, "Apple", null, ".\\Apple.jpg" },
                    { 111, 0.89m, "Banana", null, ".\\Bacon.jpg" },
                    { 112, 0.47m, "Orange", null, ".\\Orange.jpg" },
                    { 113, 0.32m, "Strawberry", null, ".\\Strawberry.jpg" },
                    { 114, 0.3m, "Watermelon", null, ".\\Watermelon.jpg" },
                    { 115, 0.69m, "Grape", null, ".\\Grape.jpg" },
                    { 116, 0.5m, "Pineapple", null, ".\\Pineapple.jpg" },
                    { 117, 0.61m, "Kiwi", null, ".\\Kiwi.jpg" },
                    { 118, 0.5m, "Cherry", null, ".\\Cherry.jpg" },
                    { 119, 0.6m, "Mango", null, ".\\Mango.jpg" }
                });

            migrationBuilder.InsertData(
                table: "Genders",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "NoResponse" },
                    { 2, "Male" },
                    { 3, "Female" }
                });

            migrationBuilder.InsertData(
                table: "Goals",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "GainWeight" },
                    { 2, "LoseWeight" },
                    { 3, "MaintainWeight" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "CreateDate", "Email", "Password", "UserName" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 4, 3, 5, 58, 42, 73, DateTimeKind.Local).AddTicks(5998), "oguzhan.karaguzel@gmail.com", "101A19E400B05DAFB96DB3ABE22913481CAA196114C6D223D0E23706B5548C67", "Oguzhankrgzl" },
                    { 2, new DateTime(2023, 4, 3, 5, 58, 42, 73, DateTimeKind.Local).AddTicks(6460), "zcn.ege@hotmail.com", "64A14A461763E01C7772E8D0F8E4C2458AE09C56A599E8E5B8BF43E2833141B5", "Egezcn" },
                    { 3, new DateTime(2023, 4, 3, 5, 58, 42, 74, DateTimeKind.Local).AddTicks(6727), "aykut.terzi@gmail.com", "7462C097726FC2AEC0E7C6A53B9B58B8CB86D459B23630D675FBF3B2B959F1BD", "Aykuttrz" },
                    { 4, new DateTime(2023, 4, 3, 5, 58, 42, 74, DateTimeKind.Local).AddTicks(8512), "ali.ozan@gmail.com", "B7A3CAE3E457415E9EDC48860F338070DB246CB4073577064BE718B075A11D9D", "Alizn" }
                });

            migrationBuilder.InsertData(
                table: "FoodFeatures",
                columns: new[] { "DietId", "FoodId", "FoodTimeId", "FoodTypeId" },
                values: new object[,]
                {
                    { 1, 21, 2, 1 },
                    { 1, 21, 3, 1 },
                    { 1, 23, 2, 1 },
                    { 1, 23, 3, 1 },
                    { 1, 24, 2, 1 },
                    { 1, 24, 3, 1 },
                    { 1, 25, 2, 1 },
                    { 1, 25, 3, 1 },
                    { 1, 26, 2, 1 },
                    { 1, 26, 3, 1 },
                    { 1, 27, 2, 1 },
                    { 1, 27, 3, 1 },
                    { 1, 28, 2, 1 },
                    { 1, 28, 3, 1 },
                    { 1, 29, 2, 1 },
                    { 1, 29, 3, 1 },
                    { 1, 30, 2, 1 },
                    { 1, 30, 3, 1 },
                    { 1, 31, 2, 2 },
                    { 1, 31, 3, 2 },
                    { 1, 32, 2, 2 },
                    { 1, 32, 3, 2 },
                    { 1, 33, 2, 2 },
                    { 1, 33, 3, 2 },
                    { 1, 34, 2, 2 },
                    { 1, 34, 3, 2 },
                    { 1, 35, 2, 2 },
                    { 1, 35, 3, 2 },
                    { 1, 36, 2, 2 },
                    { 1, 36, 3, 2 },
                    { 1, 37, 2, 2 },
                    { 1, 37, 3, 2 },
                    { 1, 38, 2, 2 },
                    { 1, 38, 3, 2 },
                    { 1, 39, 2, 2 },
                    { 1, 39, 3, 2 },
                    { 1, 40, 2, 3 },
                    { 1, 40, 3, 3 },
                    { 1, 41, 2, 3 },
                    { 1, 41, 3, 3 },
                    { 1, 42, 2, 3 },
                    { 1, 42, 3, 3 },
                    { 1, 45, 2, 3 },
                    { 1, 45, 3, 3 },
                    { 1, 46, 2, 3 },
                    { 1, 46, 3, 3 },
                    { 1, 47, 2, 3 },
                    { 1, 47, 3, 3 },
                    { 1, 49, 2, 3 },
                    { 1, 49, 3, 3 },
                    { 1, 50, 2, 4 },
                    { 1, 50, 3, 4 },
                    { 1, 51, 1, 4 },
                    { 1, 51, 2, 4 },
                    { 1, 51, 3, 4 },
                    { 1, 51, 4, 4 },
                    { 1, 52, 2, 4 },
                    { 1, 52, 3, 4 },
                    { 1, 53, 2, 4 },
                    { 1, 53, 3, 4 },
                    { 1, 54, 2, 4 },
                    { 1, 54, 3, 4 },
                    { 1, 55, 2, 4 },
                    { 1, 55, 3, 4 },
                    { 1, 56, 1, 4 },
                    { 1, 56, 2, 4 },
                    { 1, 56, 3, 4 },
                    { 1, 56, 4, 4 },
                    { 1, 57, 1, 4 },
                    { 1, 57, 2, 4 },
                    { 1, 57, 3, 4 },
                    { 1, 58, 1, 4 },
                    { 1, 58, 2, 4 },
                    { 1, 58, 3, 4 },
                    { 1, 58, 4, 4 },
                    { 1, 59, 1, 4 },
                    { 1, 59, 2, 4 },
                    { 1, 59, 3, 4 },
                    { 1, 59, 4, 4 },
                    { 1, 60, 1, 5 },
                    { 1, 65, 1, 5 },
                    { 1, 65, 4, 5 },
                    { 1, 66, 1, 5 },
                    { 1, 66, 4, 6 },
                    { 1, 67, 1, 5 },
                    { 1, 67, 4, 5 },
                    { 1, 69, 4, 5 },
                    { 1, 69, 1, 8 },
                    { 1, 70, 4, 6 },
                    { 1, 71, 4, 6 },
                    { 1, 72, 4, 6 },
                    { 1, 73, 4, 10 },
                    { 1, 75, 4, 6 },
                    { 1, 77, 4, 6 },
                    { 1, 78, 4, 6 },
                    { 1, 79, 4, 6 },
                    { 1, 80, 1, 7 },
                    { 1, 80, 2, 7 },
                    { 1, 80, 3, 7 },
                    { 1, 80, 4, 7 },
                    { 1, 81, 1, 7 },
                    { 1, 81, 4, 7 },
                    { 1, 82, 1, 7 },
                    { 1, 82, 4, 7 },
                    { 1, 83, 1, 7 },
                    { 1, 83, 4, 7 },
                    { 1, 85, 2, 7 },
                    { 1, 85, 3, 7 },
                    { 1, 85, 4, 7 },
                    { 1, 86, 2, 7 },
                    { 1, 86, 3, 7 },
                    { 1, 86, 4, 7 },
                    { 1, 87, 1, 7 },
                    { 1, 87, 4, 7 },
                    { 1, 88, 1, 7 },
                    { 1, 88, 2, 7 },
                    { 1, 88, 3, 7 },
                    { 1, 88, 4, 7 },
                    { 1, 89, 1, 7 },
                    { 1, 89, 2, 7 },
                    { 1, 89, 3, 7 },
                    { 1, 89, 4, 7 },
                    { 1, 94, 1, 8 },
                    { 1, 94, 2, 8 },
                    { 1, 94, 3, 8 },
                    { 1, 94, 4, 8 },
                    { 1, 97, 1, 8 },
                    { 1, 97, 2, 8 },
                    { 1, 97, 3, 8 },
                    { 1, 97, 4, 8 },
                    { 1, 98, 1, 8 },
                    { 1, 98, 2, 8 },
                    { 1, 98, 3, 8 },
                    { 1, 98, 4, 8 },
                    { 1, 102, 2, 9 },
                    { 1, 102, 3, 9 },
                    { 1, 102, 4, 9 },
                    { 1, 107, 1, 8 },
                    { 1, 107, 2, 8 },
                    { 1, 107, 3, 8 },
                    { 1, 107, 4, 8 },
                    { 1, 110, 1, 10 },
                    { 1, 110, 2, 10 },
                    { 1, 110, 3, 10 },
                    { 1, 110, 4, 10 },
                    { 1, 111, 1, 10 },
                    { 1, 111, 2, 10 },
                    { 1, 111, 3, 10 },
                    { 1, 111, 4, 10 },
                    { 1, 112, 1, 10 },
                    { 1, 112, 2, 10 },
                    { 1, 112, 3, 10 },
                    { 1, 112, 4, 10 },
                    { 1, 113, 1, 10 },
                    { 1, 113, 2, 10 },
                    { 1, 113, 3, 10 },
                    { 1, 113, 4, 10 },
                    { 1, 114, 1, 10 },
                    { 1, 114, 2, 10 },
                    { 1, 114, 3, 10 },
                    { 1, 114, 4, 10 },
                    { 1, 115, 1, 10 },
                    { 1, 115, 2, 10 },
                    { 1, 115, 3, 10 },
                    { 1, 115, 4, 10 },
                    { 1, 116, 1, 10 },
                    { 1, 116, 2, 10 },
                    { 1, 116, 3, 10 },
                    { 1, 116, 4, 10 },
                    { 1, 117, 1, 10 },
                    { 1, 117, 2, 10 },
                    { 1, 117, 3, 10 },
                    { 1, 117, 4, 10 },
                    { 1, 118, 1, 10 },
                    { 1, 118, 2, 10 },
                    { 1, 118, 3, 10 },
                    { 1, 118, 4, 10 },
                    { 1, 119, 1, 10 },
                    { 1, 119, 2, 10 },
                    { 1, 119, 3, 10 },
                    { 1, 119, 4, 10 },
                    { 2, 61, 1, 5 },
                    { 2, 64, 1, 5 },
                    { 2, 68, 1, 5 },
                    { 2, 74, 4, 6 },
                    { 2, 76, 4, 6 },
                    { 2, 84, 1, 7 },
                    { 2, 84, 4, 7 },
                    { 2, 92, 1, 8 },
                    { 2, 92, 2, 8 },
                    { 2, 92, 3, 8 },
                    { 2, 92, 4, 8 },
                    { 2, 93, 1, 8 },
                    { 2, 93, 2, 8 },
                    { 2, 93, 3, 8 },
                    { 2, 93, 4, 8 },
                    { 2, 95, 1, 8 },
                    { 2, 95, 2, 8 },
                    { 2, 95, 3, 8 },
                    { 2, 95, 4, 8 },
                    { 2, 96, 1, 8 },
                    { 2, 96, 2, 8 },
                    { 2, 96, 3, 8 },
                    { 2, 96, 4, 8 },
                    { 2, 100, 2, 9 },
                    { 2, 100, 3, 9 },
                    { 2, 100, 4, 9 },
                    { 2, 101, 2, 9 },
                    { 2, 101, 3, 9 },
                    { 2, 101, 4, 9 },
                    { 2, 103, 2, 9 },
                    { 2, 103, 3, 9 },
                    { 2, 103, 4, 9 },
                    { 2, 104, 1, 9 },
                    { 2, 104, 2, 9 },
                    { 2, 104, 3, 9 },
                    { 2, 104, 4, 9 },
                    { 2, 105, 2, 9 },
                    { 2, 105, 3, 9 },
                    { 2, 105, 4, 9 },
                    { 2, 106, 2, 9 },
                    { 2, 106, 3, 9 },
                    { 2, 106, 4, 9 },
                    { 2, 108, 1, 9 },
                    { 2, 108, 2, 9 },
                    { 2, 108, 3, 9 },
                    { 2, 108, 4, 9 },
                    { 2, 109, 2, 9 },
                    { 2, 109, 3, 9 },
                    { 2, 109, 4, 9 },
                    { 3, 1, 2, 1 },
                    { 3, 1, 3, 1 },
                    { 3, 2, 2, 1 },
                    { 3, 2, 3, 1 },
                    { 3, 3, 2, 1 },
                    { 3, 3, 3, 1 },
                    { 3, 4, 2, 1 },
                    { 3, 4, 3, 1 },
                    { 3, 5, 2, 1 },
                    { 3, 5, 3, 1 },
                    { 3, 6, 2, 1 },
                    { 3, 6, 3, 1 },
                    { 3, 7, 2, 1 },
                    { 3, 7, 3, 1 },
                    { 3, 8, 2, 1 },
                    { 3, 8, 3, 1 },
                    { 3, 9, 2, 1 },
                    { 3, 9, 3, 1 },
                    { 3, 10, 2, 1 },
                    { 3, 10, 3, 1 },
                    { 3, 11, 2, 1 },
                    { 3, 11, 3, 1 },
                    { 3, 12, 2, 1 },
                    { 3, 12, 3, 1 },
                    { 3, 13, 2, 1 },
                    { 3, 13, 3, 1 },
                    { 3, 14, 2, 1 },
                    { 3, 14, 3, 1 },
                    { 3, 15, 2, 1 },
                    { 3, 15, 3, 1 },
                    { 3, 16, 2, 1 },
                    { 3, 16, 3, 1 },
                    { 3, 17, 2, 1 },
                    { 3, 17, 3, 1 },
                    { 3, 18, 2, 1 },
                    { 3, 18, 3, 1 },
                    { 3, 19, 2, 1 },
                    { 3, 19, 3, 1 },
                    { 3, 20, 2, 1 },
                    { 3, 20, 3, 1 },
                    { 3, 22, 2, 1 },
                    { 3, 22, 3, 1 },
                    { 3, 43, 2, 3 },
                    { 3, 43, 3, 3 },
                    { 3, 44, 2, 3 },
                    { 3, 44, 3, 3 },
                    { 3, 48, 2, 3 },
                    { 3, 48, 3, 3 },
                    { 3, 62, 1, 5 },
                    { 3, 63, 1, 5 },
                    { 3, 63, 2, 5 },
                    { 3, 63, 3, 5 },
                    { 3, 63, 4, 5 },
                    { 3, 90, 1, 8 },
                    { 3, 90, 2, 8 },
                    { 3, 90, 3, 8 },
                    { 3, 90, 4, 8 },
                    { 3, 91, 2, 8 },
                    { 3, 91, 3, 8 },
                    { 3, 99, 1, 8 },
                    { 3, 99, 2, 8 },
                    { 3, 99, 3, 8 },
                    { 3, 99, 4, 8 }
                });

            migrationBuilder.InsertData(
                table: "UserDetails",
                columns: new[] { "UserId", "ActivityLevelId", "BirthDate", "DietId", "FirstName", "GenderId", "GoalId", "Height", "LastName", "Photo", "PhotoPath", "Weigth" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(1994, 4, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "Oğuzhan", 2, 3, 178m, "Karagüzel", null, ".\\CatPhoto", 75m },
                    { 2, 4, new DateTime(1996, 8, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Ege", 2, 1, 179m, "Özcan", null, ".\\CatPhoto", 60m },
                    { 3, 3, new DateTime(1988, 7, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "Aykut", 2, 2, 174m, "Terzi", null, ".\\CatPhoto", 90m },
                    { 4, 2, new DateTime(1996, 1, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "Ali Ozan", 2, 3, 188m, "Özkul", null, ".\\CatPhoto", 88m }
                });

            migrationBuilder.InsertData(
                table: "Meals",
                columns: new[] { "Id", "CaloriesTaken", "FoodTimeId", "MealTime", "UserDetailId" },
                values: new object[,]
                {
                    { 1, 0m, 1, new DateTime(2023, 3, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 2, 0m, 2, new DateTime(2023, 3, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 3, 0m, 4, new DateTime(2023, 3, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 4, 0m, 4, new DateTime(2023, 3, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 5, 0m, 4, new DateTime(2023, 3, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 6, 0m, 4, new DateTime(2023, 3, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 7, 0m, 3, new DateTime(2023, 3, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 8, 0m, 1, new DateTime(2023, 3, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 9, 0m, 4, new DateTime(2023, 2, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 10, 0m, 2, new DateTime(2023, 2, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 11, 0m, 1, new DateTime(2023, 2, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 12, 0m, 2, new DateTime(2023, 2, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 13, 0m, 3, new DateTime(2023, 2, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 14, 0m, 4, new DateTime(2023, 2, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 4 }
                });

            migrationBuilder.InsertData(
                table: "MealDetails",
                columns: new[] { "Id", "FoodId", "Gram", "MealId" },
                values: new object[,]
                {
                    { 1, 51, 100m, 1 },
                    { 2, 72, 20m, 1 },
                    { 3, 81, 100m, 1 },
                    { 4, 90, 100m, 1 },
                    { 5, 51, 100m, 2 },
                    { 6, 99, 150m, 2 },
                    { 7, 85, 100m, 2 },
                    { 8, 100, 50m, 2 },
                    { 9, 105, 50m, 3 },
                    { 10, 1, 150m, 3 },
                    { 11, 22, 100m, 3 },
                    { 12, 50, 50m, 3 },
                    { 13, 88, 100m, 4 },
                    { 14, 86, 100m, 5 },
                    { 15, 95, 120m, 6 },
                    { 16, 5, 150m, 7 },
                    { 17, 51, 100m, 7 },
                    { 18, 109, 70m, 7 },
                    { 19, 110, 112m, 8 },
                    { 20, 76, 150m, 8 },
                    { 21, 64, 150m, 9 },
                    { 22, 80, 85m, 9 },
                    { 23, 82, 100m, 10 },
                    { 24, 52, 150m, 10 },
                    { 25, 13, 150m, 10 },
                    { 26, 93, 200m, 10 },
                    { 27, 84, 100m, 11 },
                    { 28, 71, 80m, 11 },
                    { 29, 54, 187m, 11 },
                    { 30, 117, 50m, 12 },
                    { 31, 104, 200m, 12 },
                    { 32, 53, 250m, 12 },
                    { 33, 3, 137m, 13 },
                    { 34, 10, 156m, 13 },
                    { 35, 99, 191m, 13 },
                    { 36, 74, 200m, 14 },
                    { 37, 59, 200m, 14 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_FoodFeatures_FoodId",
                table: "FoodFeatures",
                column: "FoodId");

            migrationBuilder.CreateIndex(
                name: "IX_FoodFeatures_FoodTimeId",
                table: "FoodFeatures",
                column: "FoodTimeId");

            migrationBuilder.CreateIndex(
                name: "IX_FoodFeatures_FoodTypeId",
                table: "FoodFeatures",
                column: "FoodTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_MealDetails_FoodId",
                table: "MealDetails",
                column: "FoodId");

            migrationBuilder.CreateIndex(
                name: "IX_MealDetails_MealId",
                table: "MealDetails",
                column: "MealId");

            migrationBuilder.CreateIndex(
                name: "IX_Meals_FoodTimeId",
                table: "Meals",
                column: "FoodTimeId");

            migrationBuilder.CreateIndex(
                name: "IX_Meals_UserDetailId",
                table: "Meals",
                column: "UserDetailId");

            migrationBuilder.CreateIndex(
                name: "IX_UserDetails_ActivityLevelId",
                table: "UserDetails",
                column: "ActivityLevelId");

            migrationBuilder.CreateIndex(
                name: "IX_UserDetails_DietId",
                table: "UserDetails",
                column: "DietId");

            migrationBuilder.CreateIndex(
                name: "IX_UserDetails_GenderId",
                table: "UserDetails",
                column: "GenderId");

            migrationBuilder.CreateIndex(
                name: "IX_UserDetails_GoalId",
                table: "UserDetails",
                column: "GoalId");

            migrationBuilder.CreateIndex(
                name: "IX_Users_Email",
                table: "Users",
                column: "Email",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FoodFeatures");

            migrationBuilder.DropTable(
                name: "MealDetails");

            migrationBuilder.DropTable(
                name: "FoodTypes");

            migrationBuilder.DropTable(
                name: "Foods");

            migrationBuilder.DropTable(
                name: "Meals");

            migrationBuilder.DropTable(
                name: "FoodTimes");

            migrationBuilder.DropTable(
                name: "UserDetails");

            migrationBuilder.DropTable(
                name: "ActivityLevels");

            migrationBuilder.DropTable(
                name: "Diets");

            migrationBuilder.DropTable(
                name: "Genders");

            migrationBuilder.DropTable(
                name: "Goals");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
