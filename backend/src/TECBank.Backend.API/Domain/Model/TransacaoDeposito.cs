using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using TECBank.Backend.Domain.Enum;
using TECBank.Backend.Domain.Interface;

namespace TECBank.Backend.Domain.Model;

public class TransacaoDeposito : EntidadeBase, ITransacao
{
    public string? Descrição { get; set; }

    [Required]
    public string Historico { get; set; } = null!;

    [Required]
    [Range(0.01, double.MaxValue)]
    public decimal Valor { get; set; }

    [Required]
    public EnumTipoOperacao OperationType { get; set; } = EnumTipoOperacao.Credito;

    [ForeignKey(nameof(ContaDestino))]
    public long ContaDestinoId { get; set; }

    [Required]
    public ContaCorrente ContaDestino { get; set; } = null!;
}
