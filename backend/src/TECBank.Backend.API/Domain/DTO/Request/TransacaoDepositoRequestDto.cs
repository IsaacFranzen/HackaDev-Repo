using System.ComponentModel.DataAnnotations;

namespace TECBank.Backend.Domain.DTO.Request;

public class TransacaoDepositoRequestDto
{
    public string? Descrição { get; set; }

    [Required]
    [Range(0.01, double.MaxValue, ErrorMessage = "Você deve fornecer um valor para depósito")]
    public decimal Valor { get; set; }

    [Required(ErrorMessage = "Você deve fornecer uma conta de destino para o depósito")]
    public long ContaDestinoId { get; set; }
}
