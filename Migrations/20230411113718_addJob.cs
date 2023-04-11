using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace BossAzAPI.Migrations
{
    /// <inheritdoc />
    public partial class addJob : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Jobs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Email = table.Column<string>(type: "text", nullable: true),
                    CategoryId = table.Column<int>(type: "integer", nullable: false),
                    Position = table.Column<string>(type: "text", nullable: true),
                    CityId = table.Column<int>(type: "integer", nullable: false),
                    MinSalary = table.Column<int>(type: "integer", nullable: false),
                    MaxSalary = table.Column<int>(type: "integer", nullable: false),
                    MinAge = table.Column<int>(type: "integer", nullable: false),
                    MaxAge = table.Column<int>(type: "integer", nullable: false),
                    EducationId = table.Column<int>(type: "integer", nullable: false),
                    ExperienceId = table.Column<int>(type: "integer", nullable: false),
                    Requirements = table.Column<string>(type: "text", nullable: true),
                    JobInfo = table.Column<string>(type: "text", nullable: true),
                    CompanyName = table.Column<string>(type: "text", nullable: true),
                    RelevantPerson = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Jobs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Jobs_EnumValues_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "EnumValues",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Jobs_EnumValues_CityId",
                        column: x => x.CityId,
                        principalTable: "EnumValues",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Jobs_EnumValues_EducationId",
                        column: x => x.EducationId,
                        principalTable: "EnumValues",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Jobs_EnumValues_ExperienceId",
                        column: x => x.ExperienceId,
                        principalTable: "EnumValues",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Jobs_CategoryId",
                table: "Jobs",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Jobs_CityId",
                table: "Jobs",
                column: "CityId");

            migrationBuilder.CreateIndex(
                name: "IX_Jobs_EducationId",
                table: "Jobs",
                column: "EducationId");

            migrationBuilder.CreateIndex(
                name: "IX_Jobs_ExperienceId",
                table: "Jobs",
                column: "ExperienceId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Jobs");
        }
    }
}
