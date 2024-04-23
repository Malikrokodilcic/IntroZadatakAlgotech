using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IntroZadatakAlgotech.Migrations
{
    /// <inheritdoc />
    public partial class initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Kandidati",
                columns: table => new
                {
                    KandidatID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ime = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Prezime = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    JMBG = table.Column<string>(type: "nvarchar(13)", maxLength: 13, nullable: false),
                    Obrazovanje = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    BrojTelefona = table.Column<string>(type: "nvarchar(13)", maxLength: 13, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kandidati", x => x.KandidatID);
                });

            migrationBuilder.CreateTable(
                name: "Pozicije",
                columns: table => new
                {
                    PozicijaID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Naziv = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Opis = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: false),
                    Lokacija = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    NacinRada = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DatumObjave = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DatumKrajaPrijave = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pozicije", x => x.PozicijaID);
                });

            migrationBuilder.CreateTable(
                name: "Prijave",
                columns: table => new
                {
                    PrijavaID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    KandidatID = table.Column<int>(type: "int", nullable: false),
                    PozicijaID = table.Column<int>(type: "int", nullable: false),
                    DatumPrijave = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Prijave", x => x.PrijavaID);
                    table.ForeignKey(
                        name: "FK_Prijave_Kandidati_KandidatID",
                        column: x => x.KandidatID,
                        principalTable: "Kandidati",
                        principalColumn: "KandidatID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Prijave_Pozicije_PozicijaID",
                        column: x => x.PozicijaID,
                        principalTable: "Pozicije",
                        principalColumn: "PozicijaID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Prijave_KandidatID",
                table: "Prijave",
                column: "KandidatID");

            migrationBuilder.CreateIndex(
                name: "IX_Prijave_PozicijaID",
                table: "Prijave",
                column: "PozicijaID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Prijave");

            migrationBuilder.DropTable(
                name: "Kandidati");

            migrationBuilder.DropTable(
                name: "Pozicije");
        }
    }
}
