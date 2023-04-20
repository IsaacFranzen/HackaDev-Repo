using System.ComponentModel.DataAnnotations;

namespace TECBank.Backend.Domains.Models;

public class Conta : EntidadeBase
{
    [Required]
    public string NumeroConta { get; set; }

    [Required]
    public int Agencia { get; set; } = 00001;

    [DataType(DataType.Currency)]
    public decimal Saldo { get; set; }

    public ICollection<Transacao> Transacao { get; set; }

    Random rand = new Random();

    public Conta()
    {
        //generrate accountNumber for customer
        NumeroConta = Convert.ToString((long)Math.Floor(rand.NextDouble() * 9_000_000_000L + 1_000_000_000L));
    }
}