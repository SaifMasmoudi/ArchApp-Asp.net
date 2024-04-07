using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ExamanApp.Migrations
{
    /// <inheritdoc />
    public partial class base2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Architecte",
                columns: table => new
                {
                    ArchitecteId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NomArchitecte = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    prenomArchitecte = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    telephone = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Architecte", x => x.ArchitecteId);
                });

            migrationBuilder.CreateTable(
                name: "Client",
                columns: table => new
                {
                    ClientId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NomClient = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    prenom = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    addresse = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    telephone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    emailClient = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ArchitecteId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Client", x => x.ClientId);
                    table.ForeignKey(
                        name: "FK_Client_Architecte_ArchitecteId",
                        column: x => x.ArchitecteId,
                        principalTable: "Architecte",
                        principalColumn: "ArchitecteId");
                });

            migrationBuilder.CreateTable(
                name: "Projet",
                columns: table => new
                {
                    ProjetId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NomProjet = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    addresseProjet = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StatutProjet = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ClientId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Projet", x => x.ProjetId);
                    table.ForeignKey(
                        name: "FK_Projet_Client_ClientId",
                        column: x => x.ClientId,
                        principalTable: "Client",
                        principalColumn: "ClientId");
                });

            migrationBuilder.CreateTable(
                name: "Facture",
                columns: table => new
                {
                    FactureId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Montant = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProjetId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Facture", x => x.FactureId);
                    table.ForeignKey(
                        name: "FK_Facture_Projet_ProjetId",
                        column: x => x.ProjetId,
                        principalTable: "Projet",
                        principalColumn: "ProjetId");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Client_ArchitecteId",
                table: "Client",
                column: "ArchitecteId");

            migrationBuilder.CreateIndex(
                name: "IX_Facture_ProjetId",
                table: "Facture",
                column: "ProjetId");

            migrationBuilder.CreateIndex(
                name: "IX_Projet_ClientId",
                table: "Projet",
                column: "ClientId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Facture");

            migrationBuilder.DropTable(
                name: "Projet");

            migrationBuilder.DropTable(
                name: "Client");

            migrationBuilder.DropTable(
                name: "Architecte");
        }
    }
}
