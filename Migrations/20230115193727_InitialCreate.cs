using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Proiect_Optional_Palamarciuc_Dina_ECTS.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Angajat",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nume = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Prenume = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CNP = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Adresa = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Salariu = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Angajat", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Studii",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Gimnaziale = table.Column<int>(type: "int", nullable: false),
                    Liceale = table.Column<int>(type: "int", nullable: false),
                    Superioare = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Studii", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Angajat");

            migrationBuilder.DropTable(
                name: "Studii");
        }
    }
}
