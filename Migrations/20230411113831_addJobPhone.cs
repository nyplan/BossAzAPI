using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BossAzAPI.Migrations
{
    /// <inheritdoc />
    public partial class addJobPhone : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "JobPhone",
                columns: table => new
                {
                    JobsId = table.Column<int>(type: "integer", nullable: false),
                    TelephonesId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JobPhone", x => new { x.JobsId, x.TelephonesId });
                    table.ForeignKey(
                        name: "FK_JobPhone_Jobs_JobsId",
                        column: x => x.JobsId,
                        principalTable: "Jobs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_JobPhone_Phones_TelephonesId",
                        column: x => x.TelephonesId,
                        principalTable: "Phones",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_JobPhone_TelephonesId",
                table: "JobPhone",
                column: "TelephonesId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "JobPhone");
        }
    }
}
