using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Cinema.Migrations
{
    /// <inheritdoc />
    public partial class mig1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Popularity = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Films",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ReleaseDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Films", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "FilmCategory",
                columns: table => new
                {
                    FilmId = table.Column<int>(type: "int", nullable: false),
                    CategoryId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FilmCategory", x => new { x.FilmId, x.CategoryId });
                    table.ForeignKey(
                        name: "FK_FilmCategory_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FilmCategory_Films_FilmId",
                        column: x => x.FilmId,
                        principalTable: "Films",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name", "Popularity" },
                values: new object[,]
                {
                    { 1, "Aksiyon", 10 },
                    { 2, "Macera", 8 },
                    { 3, "Fantastik", 9 },
                    { 4, "Bilim Kurgu", 10 },
                    { 5, "Suç", 5 },
                    { 6, "Drama", 6 },
                    { 7, "Komedi", 10 },
                    { 8, "Romantik", 4 }
                });

            migrationBuilder.InsertData(
                table: "Films",
                columns: new[] { "Id", "Name", "ReleaseDate" },
                values: new object[,]
                {
                    { 1, "Pirates of the Caribbean: The Curse of the Black Pearl", new DateTime(2003, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, "The Matrix", new DateTime(2003, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3, "The Godfather", new DateTime(1972, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 4, "Yes Man", new DateTime(2008, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 5, "Deadpool", new DateTime(2016, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 6, "Pride & Prejudice", new DateTime(2008, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "FilmCategory",
                columns: new[] { "CategoryId", "FilmId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 2, 1 },
                    { 3, 1 },
                    { 1, 2 },
                    { 2, 2 },
                    { 4, 2 },
                    { 1, 3 },
                    { 5, 3 },
                    { 6, 3 },
                    { 3, 4 },
                    { 7, 4 },
                    { 1, 5 },
                    { 3, 5 },
                    { 7, 5 },
                    { 6, 6 },
                    { 8, 6 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_FilmCategory_CategoryId",
                table: "FilmCategory",
                column: "CategoryId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FilmCategory");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "Films");
        }
    }
}
