using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace _11.IdentityUygulama.Migrations
{
    public partial class v101_ADDROLES : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "785554cf-850a-4714-8bcf-a5cc01a3f54b", "e93c66e4-55e3-4ab7-8e9f-e1e3b20a055f", "Yönetici", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "be4a2be9-12d4-4e0c-95f1-ef8edecd38e9", "47fc042e-ea75-4d1e-ac82-06c594470f43", "Editör", "EDITOR" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "c6ef2b1e-f5de-424d-b864-899156fdcddd", "b9275945-8efa-4225-a81b-0845dbe7ec64", "Normal Kullanıcı", "USER" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "785554cf-850a-4714-8bcf-a5cc01a3f54b");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "be4a2be9-12d4-4e0c-95f1-ef8edecd38e9");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c6ef2b1e-f5de-424d-b864-899156fdcddd");
        }
    }
}
