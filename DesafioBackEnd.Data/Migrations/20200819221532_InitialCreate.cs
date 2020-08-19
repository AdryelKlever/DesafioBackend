using Microsoft.EntityFrameworkCore.Migrations;

namespace DesafioBackEnd.Data.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Especialidade",
                columns: table => new
                {
                    IdEspecialidade = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NomeEspecialidade = table.Column<string>(maxLength: 150, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("IdEspecialidade", x => x.IdEspecialidade);
                });

            migrationBuilder.CreateTable(
                name: "Medico",
                columns: table => new
                {
                    IdMedico = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NomeMedico = table.Column<string>(maxLength: 150, nullable: false),
                    CPF = table.Column<string>(maxLength: 14, nullable: false),
                    CRM = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("IdMedico", x => x.IdMedico);
                });

            migrationBuilder.CreateTable(
                name: "EspecialidadeMedico",
                columns: table => new
                {
                    IdMedico = table.Column<int>(nullable: false),
                    IdEspecialidade = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PFK_EspecialidadeMedico", x => new { x.IdMedico, x.IdEspecialidade });
                    table.ForeignKey(
                        name: "FK_EspecialidadeEspecialidadeMedico",
                        column: x => x.IdEspecialidade,
                        principalTable: "Especialidade",
                        principalColumn: "IdEspecialidade",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_MedicoEspecialidadeMedico",
                        column: x => x.IdMedico,
                        principalTable: "Medico",
                        principalColumn: "IdMedico",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_EspecialidadeMedico_IdEspecialidade",
                table: "EspecialidadeMedico",
                column: "IdEspecialidade");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EspecialidadeMedico");

            migrationBuilder.DropTable(
                name: "Especialidade");

            migrationBuilder.DropTable(
                name: "Medico");
        }
    }
}
