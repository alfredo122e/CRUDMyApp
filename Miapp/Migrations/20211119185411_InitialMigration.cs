using Microsoft.EntityFrameworkCore.Migrations;
using MySql.EntityFrameworkCore.Metadata;

namespace Miapp.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Consultory",
                columns: table => new
                {
                    ConsultoryID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    nombre  = table.Column<string>(type: "text", nullable: false),
                    enfermedad = table.Column<string>(type: "text", nullable: false),
                    medicina = table.Column<string>(type: "text", nullable: false),
                   
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Consultory", x => x.ConsultoryID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Consultory");
        }
    }
}
