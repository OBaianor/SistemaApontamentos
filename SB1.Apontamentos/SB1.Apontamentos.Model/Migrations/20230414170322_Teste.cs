using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SB1.Apontamentos.Model.Migrations
{
    /// <inheritdoc />
    public partial class Teste : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ativo",
                schema: "dbo",
                table: "CadastroColaborador");

            migrationBuilder.AddColumn<string>(
                name: "Email",
                schema: "dbo",
                table: "CadastroColaborador",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Senha",
                schema: "dbo",
                table: "CadastroColaborador",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Usuario",
                schema: "dbo",
                table: "CadastroColaborador",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Email",
                schema: "dbo",
                table: "CadastroColaborador");

            migrationBuilder.DropColumn(
                name: "Senha",
                schema: "dbo",
                table: "CadastroColaborador");

            migrationBuilder.DropColumn(
                name: "Usuario",
                schema: "dbo",
                table: "CadastroColaborador");

            migrationBuilder.AddColumn<bool>(
                name: "ativo",
                schema: "dbo",
                table: "CadastroColaborador",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }
    }
}
