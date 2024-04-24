using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IntroZadatakAlgotech.Migrations
{
    /// <inheritdoc />
    public partial class dodatoPoljeEmailUKandidate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "Kandidati",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Email",
                table: "Kandidati");
        }
    }
}
