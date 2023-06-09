﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TECBank.Backend.Repository.DataContext;

#nullable disable

namespace TECBank.Backend.Migrations
{
    [DbContext(typeof(TecBankContext))]
    partial class TecBankContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.16")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("TECBank.Backend.Domains.Models.Cliente", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    b.Property<DateTimeOffset?>("AtualizadoEm")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Cpf")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<DateTimeOffset>("CriadoEm")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("EstadoCivil")
                        .HasColumnType("int");

                    b.Property<DateTimeOffset?>("ExcluidoEm")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Nacionalidade")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Naturalidade")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("NomeEmpresa")
                        .HasColumnType("longtext");

                    b.Property<string>("NomeMae")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("NomePai")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<double>("Patrimonio")
                        .HasColumnType("double");

                    b.Property<string>("Profissao")
                        .HasColumnType("longtext");

                    b.Property<double>("RendaMensal")
                        .HasColumnType("double");

                    b.Property<DateTime>("RgDataEmissao")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("RgEstado")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("RgNumero")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("RgOrgaoExpedidor")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("Sexo")
                        .HasColumnType("int");

                    b.Property<string>("TelefoneCelular")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("TelefoneEmpresa")
                        .HasColumnType("longtext");

                    b.Property<string>("TelefoneResidencial")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Clientes");
                });

            modelBuilder.Entity("TECBank.Backend.Domains.Models.Conta", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    b.Property<int>("Agencia")
                        .HasColumnType("int");

                    b.Property<DateTimeOffset?>("AtualizadoEm")
                        .HasColumnType("datetime(6)");

                    b.Property<long>("ClienteId")
                        .HasColumnType("bigint");

                    b.Property<DateTimeOffset>("CriadoEm")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTimeOffset?>("ExcluidoEm")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("NumeroConta")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<decimal>("Saldo")
                        .HasColumnType("decimal(65,30)");

                    b.Property<string>("SenhaHash")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.HasIndex("ClienteId")
                        .IsUnique();

                    b.ToTable("Contas");
                });

            modelBuilder.Entity("TECBank.Backend.Domains.Models.Endereco", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    b.Property<DateTimeOffset?>("AtualizadoEm")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Bairro")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Cep")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Cidade")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<long>("ClienteId")
                        .HasColumnType("bigint");

                    b.Property<string>("Complemento")
                        .HasColumnType("longtext");

                    b.Property<DateTimeOffset>("CriadoEm")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Estado")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<DateTimeOffset?>("ExcluidoEm")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Logradouro")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Numero")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.HasIndex("ClienteId")
                        .IsUnique();

                    b.ToTable("Endereco");
                });

            modelBuilder.Entity("TECBank.Backend.Domains.Models.Transacao", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    b.Property<DateTimeOffset?>("AtualizadoEm")
                        .HasColumnType("datetime(6)");

                    b.Property<long>("ContaId")
                        .HasColumnType("bigint");

                    b.Property<DateTimeOffset>("CriadoEm")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Descricao")
                        .HasColumnType("longtext");

                    b.Property<DateTimeOffset?>("ExcluidoEm")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Historico")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("TipoOperacao")
                        .HasColumnType("int");

                    b.Property<int>("TipoTransacao")
                        .HasColumnType("int");

                    b.Property<decimal>("Valor")
                        .HasColumnType("decimal(65,30)");

                    b.HasKey("Id");

                    b.HasIndex("ContaId");

                    b.ToTable("Transacoes");
                });

            modelBuilder.Entity("TECBank.Backend.Domains.Models.Conta", b =>
                {
                    b.HasOne("TECBank.Backend.Domains.Models.Cliente", "Cliente")
                        .WithOne("Conta")
                        .HasForeignKey("TECBank.Backend.Domains.Models.Conta", "ClienteId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Cliente");
                });

            modelBuilder.Entity("TECBank.Backend.Domains.Models.Endereco", b =>
                {
                    b.HasOne("TECBank.Backend.Domains.Models.Cliente", "Cliente")
                        .WithOne("Endereco")
                        .HasForeignKey("TECBank.Backend.Domains.Models.Endereco", "ClienteId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Cliente");
                });

            modelBuilder.Entity("TECBank.Backend.Domains.Models.Transacao", b =>
                {
                    b.HasOne("TECBank.Backend.Domains.Models.Conta", "Conta")
                        .WithMany("Transacao")
                        .HasForeignKey("ContaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Conta");
                });

            modelBuilder.Entity("TECBank.Backend.Domains.Models.Cliente", b =>
                {
                    b.Navigation("Conta")
                        .IsRequired();

                    b.Navigation("Endereco")
                        .IsRequired();
                });

            modelBuilder.Entity("TECBank.Backend.Domains.Models.Conta", b =>
                {
                    b.Navigation("Transacao");
                });
#pragma warning restore 612, 618
        }
    }
}
