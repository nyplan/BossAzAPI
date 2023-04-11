using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace BossAzAPI.Migrations
{
    /// <inheritdoc />
    public partial class addResume : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Resumes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: true),
                    Surname = table.Column<string>(type: "text", nullable: true),
                    GenderId = table.Column<int>(type: "integer", nullable: false),
                    Image = table.Column<string>(type: "text", nullable: true),
                    EducationId = table.Column<int>(type: "integer", nullable: false),
                    MoreEduInfo = table.Column<string>(type: "text", nullable: true),
                    ExperienceId = table.Column<int>(type: "integer", nullable: false),
                    MoreExperienceInfo = table.Column<string>(type: "text", nullable: true),
                    CategoryId = table.Column<int>(type: "integer", nullable: false),
                    Position = table.Column<string>(type: "text", nullable: true),
                    CityId = table.Column<int>(type: "integer", nullable: false),
                    MinWage = table.Column<int>(type: "integer", nullable: false),
                    Skills = table.Column<string>(type: "text", nullable: true),
                    MoreInfo = table.Column<string>(type: "text", nullable: true),
                    Email = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Resumes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Resumes_EnumValues_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "EnumValues",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Resumes_EnumValues_CityId",
                        column: x => x.CityId,
                        principalTable: "EnumValues",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Resumes_EnumValues_EducationId",
                        column: x => x.EducationId,
                        principalTable: "EnumValues",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Resumes_EnumValues_ExperienceId",
                        column: x => x.ExperienceId,
                        principalTable: "EnumValues",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Resumes_EnumValues_GenderId",
                        column: x => x.GenderId,
                        principalTable: "EnumValues",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Resumes_CategoryId",
                table: "Resumes",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Resumes_CityId",
                table: "Resumes",
                column: "CityId");

            migrationBuilder.CreateIndex(
                name: "IX_Resumes_EducationId",
                table: "Resumes",
                column: "EducationId");

            migrationBuilder.CreateIndex(
                name: "IX_Resumes_ExperienceId",
                table: "Resumes",
                column: "ExperienceId");

            migrationBuilder.CreateIndex(
                name: "IX_Resumes_GenderId",
                table: "Resumes",
                column: "GenderId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Resumes");
        }
    }
}
