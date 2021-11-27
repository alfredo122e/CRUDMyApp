using Microsoft.EntityFrameworkCore.Migrations;
using MySql.EntityFrameworkCore.Metadata;

namespace primeraAplicacion.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Owner",
                columns: table => new
                {
                    OwnerID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    firsName = table.Column<string>(type: "text", nullable: false),
                    lastName = table.Column<string>(type: "text", nullable: false),
                    email = table.Column<string>(type: "text", nullable: false),
                    gender = table.Column<string>(type: "text", nullable: false),
                    address = table.Column<string>(type: "varchar(150)", maxLength: 150, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Owner", x => x.OwnerID);
                });

            migrationBuilder.CreateTable(
                name: "Perro",
                columns: table => new
                {
                    perroID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    nama = table.Column<string>(type: "text", nullable: false),
                    raza = table.Column<string>(type: "text", nullable: false),
                    age = table.Column<int>(type: "int", nullable: false),
                    vaccine = table.Column<string>(type: "text", nullable: false),
                    ownerName = table.Column<string>(type: "text", nullable: false),
                    telephone = table.Column<string>(type: "text", nullable: false),
                    OwnerID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Perro", x => x.perroID);
                    table.ForeignKey(
                        name: "FK_Perro_Owner_OwnerID",
                        column: x => x.OwnerID,
                        principalTable: "Owner",
                        principalColumn: "OwnerID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Perro_OwnerID",
                table: "Perro",
                column: "OwnerID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Perro");

            migrationBuilder.DropTable(
                name: "Owner");
        }
    }
}
