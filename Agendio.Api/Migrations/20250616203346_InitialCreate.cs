using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Agendio.Api.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Donos",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Nome_Dono = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email_Dono = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Tel_Dono = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Senha_Dono = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DonoId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Donos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Donos_Donos_DonoId",
                        column: x => x.DonoId,
                        principalTable: "Donos",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Negocios",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Nome_Negocio = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Desc_Negocio = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    End_negocio = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Tel_Negocio = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Negocios", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Clientes",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Nome_Cliente = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Tel_cliente = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email_cliente = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BusinessId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clientes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Clientes_Negocios_BusinessId",
                        column: x => x.BusinessId,
                        principalTable: "Negocios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Funcionarios",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Nome_Func = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email_Func = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Senha_Func = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Tel_Func = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Espec_Func = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BusinessId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Funcionarios", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Funcionarios_Negocios_BusinessId",
                        column: x => x.BusinessId,
                        principalTable: "Negocios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Servicos",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Nome_Serv = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Duracao_Serv = table.Column<int>(type: "int", nullable: false),
                    Preco_Serv = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    BusinessId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Servicos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Servicos_Negocios_BusinessId",
                        column: x => x.BusinessId,
                        principalTable: "Negocios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Marcacoes",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false),
                    ClienteId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    FuncionarioId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Marcacoes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Marcacoes_Clientes_ClienteId",
                        column: x => x.ClienteId,
                        principalTable: "Clientes",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Marcacoes_Funcionarios_FuncionarioId",
                        column: x => x.FuncionarioId,
                        principalTable: "Funcionarios",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Clientes_BusinessId",
                table: "Clientes",
                column: "BusinessId");

            migrationBuilder.CreateIndex(
                name: "IX_Donos_DonoId",
                table: "Donos",
                column: "DonoId");

            migrationBuilder.CreateIndex(
                name: "IX_Funcionarios_BusinessId",
                table: "Funcionarios",
                column: "BusinessId");

            migrationBuilder.CreateIndex(
                name: "IX_Marcacoes_ClienteId",
                table: "Marcacoes",
                column: "ClienteId");

            migrationBuilder.CreateIndex(
                name: "IX_Marcacoes_FuncionarioId",
                table: "Marcacoes",
                column: "FuncionarioId");

            migrationBuilder.CreateIndex(
                name: "IX_Servicos_BusinessId",
                table: "Servicos",
                column: "BusinessId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Donos");

            migrationBuilder.DropTable(
                name: "Marcacoes");

            migrationBuilder.DropTable(
                name: "Servicos");

            migrationBuilder.DropTable(
                name: "Clientes");

            migrationBuilder.DropTable(
                name: "Funcionarios");

            migrationBuilder.DropTable(
                name: "Negocios");
        }
    }
}
