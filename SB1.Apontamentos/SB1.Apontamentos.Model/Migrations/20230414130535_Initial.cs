using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SB1.Apontamentos.Model.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "dbo");

            migrationBuilder.CreateTable(
                name: "CadastroColaborador",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DtNascimento = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TipoDoc = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TipoParc = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Doc = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ativo = table.Column<bool>(type: "bit", nullable: false),
                    DtInsercao = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DtAtualizacao = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CadastroColaborador", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CadastroColaborador",
                schema: "dbo");
        }
    }
}
