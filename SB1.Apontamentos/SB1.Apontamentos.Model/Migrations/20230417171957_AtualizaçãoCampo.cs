using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SB1.Apontamentos.Model.Migrations
{
    /// <inheritdoc />
    public partial class AtualizaçãoCampo : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Ativo",
                schema: "dbo",
                table: "CadastroColaborador",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Ativo",
                schema: "dbo",
                table: "CadastroColaborador");
        }
    }
}
