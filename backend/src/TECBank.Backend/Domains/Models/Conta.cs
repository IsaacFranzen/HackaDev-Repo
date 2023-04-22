using System.ComponentModel.DataAnnotations;

namespace TECBank.Backend.Domains.Models;

public class Conta : EntidadeBase
{
    private readonly Random rand = new Random();

    public Conta()
    {
        //generrate accountNumber for customer
        NumeroConta = Convert.ToString((long)Math.Floor(rand.NextDouble() * 9_000_000_000L + 1_000_000_000L));
    }

    [Required]
    public string NumeroConta { get; set; }

    [Required]
    public int Agencia { get; set; } = 00001;

    [Required]
    public string SenhaHash { get; set; } = null!;

    [DataType(DataType.Currency)]
    public decimal Saldo { get; set; }

    public ICollection<Transacao> Transacao { get; set; } = null!;
}