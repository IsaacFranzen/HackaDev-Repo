using Domain.Model;
using Domain.Model.Enums;
using Microsoft.EntityFrameworkCore;

namespace TECBank.Backend.Repository.DataContext;

public class TecBankContext : DbContext
{
    public TecBankContext(DbContextOptions<TecBankContext> options) : base(options) { }

    public DbSet<Cliente> Clientes { get; set; }
    public DbSet<Endereco> Enderecos { get; set; }


    protected override void OnModelCreating(ModelBuilder builder)
    {
        
        builder.Entity<Endereco>()
            .HasData(new Endereco(1, (DateTimeOffset.Parse("20/02/2023")),
                (DateTimeOffset.Parse("20/02/2023")), (DateTimeOffset.Parse("20/02/2023")),
                "Rua Sao Paulo", "524", "Sao Paulo"));

        builder.Entity<Cliente>()
                .HasData(new Cliente(1, (DateTimeOffset.Parse("20/02/2023")),
                (DateTimeOffset.Parse("20/02/2023")), (DateTimeOffset.Parse("20/02/2023")), "Jackson",
                "jackson@gmail.com",1, "39060697", "991357585", (Enum.Parse<Sexo>("1")),
                (Enum.Parse<EstadoCivil>("Casado")), "12345678", (DateTime.Parse("18/02/1995")), "SSP",
                "SP", "12345678911", "Geraldo", "Doraci", "São Paulo", "brasileiro", "DEV", "TIOne", "33224455",
                5000, 100000));
    }
}
