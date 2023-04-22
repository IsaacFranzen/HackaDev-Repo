using System.ComponentModel.DataAnnotations;

namespace TECBank.Backend.Domains.DTO.Requests;

public class TransacaoDepositoRequestDto
{
    public string? Descricao { get; set; }

    [Required]
    [Range(
        0.01, double.MaxValue,
        ErrorMessage = "Você deve fornecer um valor a depositar"
    )]
    public decimal Valor { get; set; }
}
