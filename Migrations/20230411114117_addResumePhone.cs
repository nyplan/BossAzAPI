using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BossAzAPI.Migrations
{
    /// <inheritdoc />
    public partial class addResumePhone : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "PhoneResume",
                columns: table => new
                {
                    PhonesId = table.Column<int>(type: "integer", nullable: false),
                    ResumesId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PhoneResume", x => new { x.PhonesId, x.ResumesId });
                    table.ForeignKey(
                        name: "FK_PhoneResume_Phones_PhonesId",
                        column: x => x.PhonesId,
                        principalTable: "Phones",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PhoneResume_Resumes_ResumesId",
                        column: x => x.ResumesId,
                        principalTable: "Resumes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_PhoneResume_ResumesId",
                table: "PhoneResume",
                column: "ResumesId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PhoneResume");
        }
    }
}
