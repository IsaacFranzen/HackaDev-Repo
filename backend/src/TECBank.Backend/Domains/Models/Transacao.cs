using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using TECBank.Backend.Domains.Enums;

namespace TECBank.Backend.Domains.Models;

public class Transacao : EntidadeBase
{
    public string? Descricao { get; set; }

    [Required]
    public string Historico { get; set; } = null!;

    [Required]
    public decimal Valor { get; set; }

    [Required]
    public EnumTipoTransacao TipoTransacao { get; set; }

    [Required]
    public EnumTipoOperacao TipoOperacao { get; set; }

    public long ContaCorrenteId { get; set; }

    public Conta Conta { get; set; }
}
