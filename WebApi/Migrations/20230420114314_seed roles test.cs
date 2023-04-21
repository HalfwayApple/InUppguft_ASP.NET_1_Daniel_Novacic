using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace WebApi.Migrations
{
    /// <inheritdoc />
    public partial class seedrolestest : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1c55e419-57b9-490f-9f76-6e879803ba94");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d3ef9a0a-525e-4776-a701-b5a26ced32a5");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "d18c6fd6-33ec-4613-8ded-99d05eb9d1ec", null, "Admin", null },
                    { "da0ea8ff-cee2-480f-8834-9d30b21d02e0", null, "User", null }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
                    { "1c55e419-57b9-490f-9f76-6e879803ba94", null, "Admin", null },
                    { "d3ef9a0a-525e-4776-a701-b5a26ced32a5", null, "Admin", null }
                });
        }
    }
}
