using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using TECBank.Backend.Domain.Model;

namespace TECBank.Backend.Domain.DTO.Request;

public class TransacaoDepositoRequestDto
{
    public string? Descrição { get; set; }

    [Required]
    public decimal Valor { get; set; }


    [ForeignKey(nameof(ContaDestinoId))]
    public ContaCorrente ContaDestino { get; set; } = null!;
    public long ContaDestinoId { get; set; }
}
