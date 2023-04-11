using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BossAzAPI.Migrations
{
    /// <inheritdoc />
    public partial class DataSeedToEnumKey : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "EnumKeys",
                columns: new[] { "Id", "Key" },
                values: new object[,]
                {
                    { 1, "gender" },
                    { 2, "city" },
                    { 3, "category" },
                    { 4, "experience" },
                    { 5, "education" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "EnumKeys",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "EnumKeys",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "EnumKeys",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "EnumKeys",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "EnumKeys",
                keyColumn: "Id",
                keyValue: 5);
        }
    }
}
