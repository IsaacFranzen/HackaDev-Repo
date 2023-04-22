using Microsoft.EntityFrameworkCore;
using TECBank.Backend.Domains.Models;
using TECBank.Backend.Services;

namespace TECBank.Backend.Repository.DataContext;

public class TecBankContext : DbContext
{
    public TecBankContext(DbContextOptions<TecBankContext> options) : base(options) { }

    public DbSet<Transacao> Transacoes { get; set; } = null!;
    public DbSet<Conta> Contas { get; set; } = null!;
    public DbSet<Cliente> Clientes { get; set; } = null!;

    //protected override void OnModelCreating(ModelBuilder modelBuilder)
    //{
    //    modelBuilder.Entity<Conta>().HasData(new List<Conta>()
    //    {
    //        new Conta() { 
    //            Id = 1,
    //            SenhaHash = PasswordService.Hash("123456"),
    //            NumeroConta = "001",
    //            CriadoEm = DateTimeOffset.Now 
    //        },
    //        new Conta() { 
    //            Id = 2, 
    //            SenhaHash = PasswordService.Hash("123456"), 
    //            NumeroConta = "002", 
    //            CriadoEm = DateTimeOffset.Now 
    //        }
    //    });
    //}

    public override int SaveChanges(
        bool acceptAllChangesOnSuccess)
    {
        var entradas = ChangeTracker
            .Entries()
            .Where(e => e.Entity is EntidadeBase &&
                (e.State == EntityState.Added || 
                 e.State == EntityState.Modified));

        foreach (var entrada in entradas)
        {
            DateTimeOffset dataHora = DateTimeOffset.Now;

            if (entrada.State == EntityState.Added)
                ((EntidadeBase)entrada.Entity).CriadoEm = dataHora;

            if (entrada.State == EntityState.Modified)
                ((EntidadeBase)entrada.Entity).AtualizadoEm = dataHora;
        }

        return base.SaveChanges(acceptAllChangesOnSuccess);
    }
}
