using Microsoft.EntityFrameworkCore.Migrations;

namespace DesafioBackEnd.Data.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Medico",
                columns: table => new
                {
                    IdMedico = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdEspecialidade = table.Column<int>(nullable: false),
                    NomeMedico = table.Column<string>(maxLength: 255, nullable: false),
                    CPF = table.Column<string>(maxLength: 14, nullable: false),
                    CRM = table.Column<string>(nullable: false),
                    Especialidade = table.Column<string>(maxLength: 150, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("IdMedico", x => x.IdMedico);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Medico");
        }
    }
}
