namespace TECBank.Backend.Domains.DTO.Responses;

public class ContaResponseDto
{
    public int Id { get; set; }
    public string NumeroConta { get; set; } = null!;
    public int Agencia { get; set; }
    public decimal Saldo { get; set; }
}
