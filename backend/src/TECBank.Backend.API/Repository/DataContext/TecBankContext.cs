using Microsoft.EntityFrameworkCore;


namespace TECBank.Backend.Repository.DataContext;

public class TecBankContext : DbContext
{
    public TecBankContext(DbContextOptions<TecBankContext> options) { }
    public DbSet<Endereco> Enderecos { get; set; }  

}
