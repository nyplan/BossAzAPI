using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BossAzAPI.Migrations
{
    /// <inheritdoc />
    public partial class DataSeedExperience : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "EnumValues",
                columns: new[] { "Id", "KeyId", "Value" },
                values: new object[,]
                {
                    { 1, 4, "Under 1 year" },
                    { 2, 4, "1 to 3 years" },
                    { 3, 4, "3 to 5 years" },
                    { 4, 4, "More than 5 years" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "EnumValues",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "EnumValues",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "EnumValues",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "EnumValues",
                keyColumn: "Id",
                keyValue: 4);
        }
    }
}
