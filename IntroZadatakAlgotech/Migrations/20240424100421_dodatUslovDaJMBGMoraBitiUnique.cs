using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IntroZadatakAlgotech.Migrations
{
    /// <inheritdoc />
    public partial class dodatUslovDaJMBGMoraBitiUnique : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Kandidati_JMBG",
                table: "Kandidati",
                column: "JMBG",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Kandidati_JMBG",
                table: "Kandidati");
        }
    }
}
