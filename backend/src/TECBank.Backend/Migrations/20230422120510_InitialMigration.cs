using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TECBank.Backend.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Contas",
                columns: table => new
                {
                    Id = table.Column<long>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    NumeroConta = table.Column<string>(type: "TEXT", nullable: false),
                    Agencia = table.Column<int>(type: "INTEGER", nullable: false),
                    SenhaHash = table.Column<string>(type: "TEXT", nullable: false),
                    Saldo = table.Column<decimal>(type: "TEXT", nullable: false),
                    CriadoEm = table.Column<DateTimeOffset>(type: "TEXT", nullable: false),
                    AtualizadoEm = table.Column<DateTimeOffset>(type: "TEXT", nullable: true),
                    ExcluidoEm = table.Column<DateTimeOffset>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contas", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Transacoes",
                columns: table => new
                {
                    Id = table.Column<long>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Descricao = table.Column<string>(type: "TEXT", nullable: true),
                    Historico = table.Column<string>(type: "TEXT", nullable: false),
                    Valor = table.Column<decimal>(type: "TEXT", nullable: false),
                    TipoTransacao = table.Column<int>(type: "INTEGER", nullable: false),
                    TipoOperacao = table.Column<int>(type: "INTEGER", nullable: false),
                    ContaId = table.Column<long>(type: "INTEGER", nullable: false),
                    CriadoEm = table.Column<DateTimeOffset>(type: "TEXT", nullable: false),
                    AtualizadoEm = table.Column<DateTimeOffset>(type: "TEXT", nullable: true),
                    ExcluidoEm = table.Column<DateTimeOffset>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Transacoes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Transacoes_Contas_ContaId",
                        column: x => x.ContaId,
                        principalTable: "Contas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Contas",
                columns: new[] { "Id", "Agencia", "AtualizadoEm", "CriadoEm", "ExcluidoEm", "NumeroConta", "Saldo", "SenhaHash" },
                values: new object[] { 1L, 1, null, new DateTimeOffset(new DateTime(2023, 4, 22, 9, 5, 10, 229, DateTimeKind.Unspecified).AddTicks(3688), new TimeSpan(0, -3, 0, 0, 0)), null, "001", 0m, "$2a$12$RI.nqkMYyLAFOtPUEWXnCupCmzg68O5h0iw0P7bWGzR7eqR0mnkty" });

            migrationBuilder.InsertData(
                table: "Contas",
                columns: new[] { "Id", "Agencia", "AtualizadoEm", "CriadoEm", "ExcluidoEm", "NumeroConta", "Saldo", "SenhaHash" },
                values: new object[] { 2L, 1, null, new DateTimeOffset(new DateTime(2023, 4, 22, 9, 5, 10, 693, DateTimeKind.Unspecified).AddTicks(6200), new TimeSpan(0, -3, 0, 0, 0)), null, "002", 0m, "$2a$12$D13x6jEOHRNM9ZE8hrmgbO8niED2rclFwCJCSVpUj7YDNwsEVKXgW" });

            migrationBuilder.CreateIndex(
                name: "IX_Transacoes_ContaId",
                table: "Transacoes",
                column: "ContaId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Transacoes");

            migrationBuilder.DropTable(
                name: "Contas");
        }
    }
}
