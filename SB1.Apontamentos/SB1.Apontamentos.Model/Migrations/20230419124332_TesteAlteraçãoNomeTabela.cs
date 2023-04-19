using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SB1.Apontamentos.Model.Migrations
{
    /// <inheritdoc />
    public partial class TesteAlteraçãoNomeTabela : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "TipoParc",
                schema: "dbo",
                table: "CadastroColaborador",
                newName: "TipoColaborador");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "TipoColaborador",
                schema: "dbo",
                table: "CadastroColaborador",
                newName: "TipoParc");
        }
    }
}
