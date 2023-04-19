using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TECBank.Backend.Migrations
{
    /// <inheritdoc />
    public partial class InitialMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Enderecos",
                columns: table => new
                {
                    Id = table.Column<long>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Logradouro = table.Column<string>(type: "TEXT", nullable: false),
                    Numero = table.Column<string>(type: "TEXT", nullable: false),
                    Cidade = table.Column<string>(type: "TEXT", nullable: false),
                    CriadoEm = table.Column<DateTimeOffset>(type: "TEXT", nullable: false),
                    AlteradoEm = table.Column<DateTimeOffset>(type: "TEXT", nullable: false),
                    ExcluidoEm = table.Column<DateTimeOffset>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Enderecos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Clientes",
                columns: table => new
                {
                    Id = table.Column<long>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nome = table.Column<string>(type: "TEXT", nullable: false),
                    Email = table.Column<string>(type: "TEXT", nullable: false),
                    EnderecoId = table.Column<long>(type: "INTEGER", nullable: false),
                    TelefoneResidencial = table.Column<string>(type: "TEXT", nullable: false),
                    TelefoneCelular = table.Column<string>(type: "TEXT", nullable: false),
                    Sexo = table.Column<int>(type: "INTEGER", nullable: false),
                    EstadoCivil = table.Column<int>(type: "INTEGER", nullable: false),
                    RgNumero = table.Column<string>(type: "TEXT", nullable: false),
                    RgDataEmissao = table.Column<DateTime>(type: "TEXT", nullable: false),
                    RgOrgaoExpedidor = table.Column<string>(type: "TEXT", nullable: false),
                    RgEstado = table.Column<string>(type: "TEXT", nullable: false),
                    Cpf = table.Column<string>(type: "TEXT", nullable: false),
                    NomePai = table.Column<string>(type: "TEXT", nullable: false),
                    NomeMae = table.Column<string>(type: "TEXT", nullable: false),
                    Naturalidade = table.Column<string>(type: "TEXT", nullable: false),
                    Nacionalidade = table.Column<string>(type: "TEXT", nullable: false),
                    Profissao = table.Column<string>(type: "TEXT", nullable: false),
                    NomeEmpresa = table.Column<string>(type: "TEXT", nullable: false),
                    TelefoneEmpresa = table.Column<string>(type: "TEXT", nullable: false),
                    RendaMensal = table.Column<double>(type: "REAL", nullable: false),
                    Patrimonio = table.Column<double>(type: "REAL", nullable: false),
                    CriadoEm = table.Column<DateTimeOffset>(type: "TEXT", nullable: false),
                    AlteradoEm = table.Column<DateTimeOffset>(type: "TEXT", nullable: false),
                    ExcluidoEm = table.Column<DateTimeOffset>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clientes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Clientes_Enderecos_EnderecoId",
                        column: x => x.EnderecoId,
                        principalTable: "Enderecos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Enderecos",
                columns: new[] { "Id", "AlteradoEm", "Cidade", "CriadoEm", "ExcluidoEm", "Logradouro", "Numero" },
                values: new object[] { 1L, new DateTimeOffset(new DateTime(2023, 2, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, -3, 0, 0, 0)), "Sao Paulo", new DateTimeOffset(new DateTime(2023, 2, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, -3, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 2, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, -3, 0, 0, 0)), "Rua Sao Paulo", "524" });

            migrationBuilder.InsertData(
                table: "Clientes",
                columns: new[] { "Id", "AlteradoEm", "Cpf", "CriadoEm", "Email", "EnderecoId", "EstadoCivil", "ExcluidoEm", "Nacionalidade", "Naturalidade", "Nome", "NomeEmpresa", "NomeMae", "NomePai", "Patrimonio", "Profissao", "RendaMensal", "RgDataEmissao", "RgEstado", "RgNumero", "RgOrgaoExpedidor", "Sexo", "TelefoneCelular", "TelefoneEmpresa", "TelefoneResidencial" },
                values: new object[] { 1L, new DateTimeOffset(new DateTime(2023, 2, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, -3, 0, 0, 0)), "12345678911", new DateTimeOffset(new DateTime(2023, 2, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, -3, 0, 0, 0)), "jackson@gmail.com", 1L, 0, new DateTimeOffset(new DateTime(2023, 2, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, -3, 0, 0, 0)), "brasileiro", "São Paulo", "Jackson", "TIOne", "Doraci", "Geraldo", 100000.0, "DEV", 5000.0, new DateTime(1995, 2, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "SP", "12345678", "SSP", 1, "991357585", "33224455", "39060697" });

            migrationBuilder.CreateIndex(
                name: "IX_Clientes_EnderecoId",
                table: "Clientes",
                column: "EnderecoId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Clientes");

            migrationBuilder.DropTable(
                name: "Enderecos");
        }
    }
}
