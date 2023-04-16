using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using TECBank.Backend.Domain.Enum;
using TECBank.Backend.Domain.Interface;

namespace TECBank.Backend.Domain.Model;

public class TransacaoPix : EntidadeBase, ITransacao
{
    public string? Descrição { get; set; }

    [Required]
    public string Historico { get; set; } = null!;

    [Required]
    public decimal Valor { get; set; }

    [Required]
    public EnumTipoOperacao OperationType { get; set; } = EnumTipoOperacao.Debito;

    public long ContaCorrenteId { get; set; }

    public ContaCorrente ContaCorrente { get; set; } = null!;
}
