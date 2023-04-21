namespace TECBank.Backend.Domains.DTO.Responses;

public class ContaDtoView
{
    public int Id { get; set; }
    public string NumeroConta { get; set; }
    public int Agencia { get; set; }
    public decimal Saldo { get; set; }
}
