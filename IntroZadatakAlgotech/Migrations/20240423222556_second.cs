using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IntroZadatakAlgotech.Migrations
{
    /// <inheritdoc />
    public partial class second : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Prijave_KandidatID",
                table: "Prijave");

            migrationBuilder.CreateIndex(
                name: "IX_Prijave_KandidatID_PozicijaID",
                table: "Prijave",
                columns: new[] { "KandidatID", "PozicijaID" },
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Prijave_KandidatID_PozicijaID",
                table: "Prijave");

            migrationBuilder.CreateIndex(
                name: "IX_Prijave_KandidatID",
                table: "Prijave",
                column: "KandidatID");
        }
    }
}
