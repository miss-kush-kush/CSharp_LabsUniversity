using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DBUsage.Migrations
{
    /// <inheritdoc />
    public partial class First : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Faktury",
                columns: table => new
                {
                    FakturaId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Numer = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Wartosc = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Faktury", x => x.FakturaId);
                });

            migrationBuilder.CreateTable(
                name: "Pozycje",
                columns: table => new
                {
                    PozycjaId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FakturaId = table.Column<int>(type: "int", nullable: false),
                    Nazwa = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Wartosc = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pozycje", x => x.PozycjaId);
                    table.ForeignKey(
                        name: "FK_Pozycje_Faktury_FakturaId",
                        column: x => x.FakturaId,
                        principalTable: "Faktury",
                        principalColumn: "FakturaId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Pozycje_FakturaId",
                table: "Pozycje",
                column: "FakturaId");

            migrationBuilder.InsertData(
                table: "Faktury",
                columns: new[] { "Numer", "Wartosc" },
                values: new object[,]
                {
                    { "Faktura001", 100.00m },
                    { "Faktura002", 200.00m }
                });

            // Insert data into Pozycje
            migrationBuilder.InsertData(
                table: "Pozycje",
                columns: new[] { "FakturaId", "Nazwa", "Wartosc" },
                values: new object[,]
                {
                    { 1, "Pozycja001", 50.00m },
                    { 1, "Pozycja002", 50.00m },
                    { 2, "Pozycja003", 100.00m },
                    { 2, "Pozycja004", 100.00m }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Pozycje");

            migrationBuilder.DropTable(
                name: "Faktury");
        }
    }
}
