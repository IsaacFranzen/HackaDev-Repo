using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TECBank.Backend.Migrations
{
    /// <inheritdoc />
    public partial class todos_os_dados : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Estado",
                table: "Enderecos",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "Clientes",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "EstadoCivil",
                table: "Clientes",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Nacionalidade",
                table: "Clientes",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Naturalidade",
                table: "Clientes",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "NomeEmpresa",
                table: "Clientes",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "NomeMae",
                table: "Clientes",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "NomePai",
                table: "Clientes",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<double>(
                name: "Patrimonio",
                table: "Clientes",
                type: "REAL",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<string>(
                name: "Profissao",
                table: "Clientes",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<double>(
                name: "RendaMensal",
                table: "Clientes",
                type: "REAL",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<DateTime>(
                name: "RgDataEmissao",
                table: "Clientes",
                type: "TEXT",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "RgEstado",
                table: "Clientes",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "RgNumero",
                table: "Clientes",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "RgOrgaoExpedidor",
                table: "Clientes",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "Sexo",
                table: "Clientes",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "TelefoneCelular",
                table: "Clientes",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "TelefoneEmpresa",
                table: "Clientes",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "TelefoneResidencial",
                table: "Clientes",
                type: "TEXT",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Estado",
                table: "Enderecos");

            migrationBuilder.DropColumn(
                name: "Email",
                table: "Clientes");

            migrationBuilder.DropColumn(
                name: "EstadoCivil",
                table: "Clientes");

            migrationBuilder.DropColumn(
                name: "Nacionalidade",
                table: "Clientes");

            migrationBuilder.DropColumn(
                name: "Naturalidade",
                table: "Clientes");

            migrationBuilder.DropColumn(
                name: "NomeEmpresa",
                table: "Clientes");

            migrationBuilder.DropColumn(
                name: "NomeMae",
                table: "Clientes");

            migrationBuilder.DropColumn(
                name: "NomePai",
                table: "Clientes");

            migrationBuilder.DropColumn(
                name: "Patrimonio",
                table: "Clientes");

            migrationBuilder.DropColumn(
                name: "Profissao",
                table: "Clientes");

            migrationBuilder.DropColumn(
                name: "RendaMensal",
                table: "Clientes");

            migrationBuilder.DropColumn(
                name: "RgDataEmissao",
                table: "Clientes");

            migrationBuilder.DropColumn(
                name: "RgEstado",
                table: "Clientes");

            migrationBuilder.DropColumn(
                name: "RgNumero",
                table: "Clientes");

            migrationBuilder.DropColumn(
                name: "RgOrgaoExpedidor",
                table: "Clientes");

            migrationBuilder.DropColumn(
                name: "Sexo",
                table: "Clientes");

            migrationBuilder.DropColumn(
                name: "TelefoneCelular",
                table: "Clientes");

            migrationBuilder.DropColumn(
                name: "TelefoneEmpresa",
                table: "Clientes");

            migrationBuilder.DropColumn(
                name: "TelefoneResidencial",
                table: "Clientes");
        }
    }
}
