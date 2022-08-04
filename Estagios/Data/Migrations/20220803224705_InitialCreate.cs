using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Estagios.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Estagios",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TipoEstagio = table.Column<bool>(type: "bit", nullable: false),
                    TipoConcedente = table.Column<bool>(type: "bit", nullable: false),
                    TipoRemuneracao = table.Column<bool>(type: "bit", nullable: false),
                    AgenteIntegracao = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DataInicioEstagio = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DataTerminoEstagio = table.Column<DateTime>(type: "datetime2", nullable: false),
                    SituacaoEstagio = table.Column<int>(type: "int", nullable: false),
                    NomeDiscente = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CPF = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Endereco = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DataNascimento = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Matricula = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Curso = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Formando = table.Column<bool>(type: "bit", nullable: false),
                    Ira = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Setor = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NomeEmpresa = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NomeResponsavelEmpresa = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NomeSupervisor = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FuncaoSupervisor = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FormacaoSupervisor = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EmailSupervisor = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Disciplina = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Orientador = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AtividadeText = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Estagios", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Estagios");
        }
    }
}
