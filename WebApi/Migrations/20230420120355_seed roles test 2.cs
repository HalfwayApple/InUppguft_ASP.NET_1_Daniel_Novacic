using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace WebApi.Migrations
{
    /// <inheritdoc />
    public partial class seedrolestest2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d18c6fd6-33ec-4613-8ded-99d05eb9d1ec");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "da0ea8ff-cee2-480f-8834-9d30b21d02e0");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "832ac1c0-1eb8-44b1-acab-9a5d4aba797d", "fa08be56-9691-467c-9a68-cd2b2c101e0d", "User", "USER" },
                    { "c3548dbe-2965-4bc5-ac66-227e9907f922", "125e1b87-0b5d-48fc-b66f-3ce49bafc019", "Admin", "ADMIN" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "832ac1c0-1eb8-44b1-acab-9a5d4aba797d");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c3548dbe-2965-4bc5-ac66-227e9907f922");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "d18c6fd6-33ec-4613-8ded-99d05eb9d1ec", null, "Admin", null },
                    { "da0ea8ff-cee2-480f-8834-9d30b21d02e0", null, "User", null }
                });
        }
    }
}
