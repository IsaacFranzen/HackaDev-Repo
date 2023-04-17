using TECBank.Backend.Domains.Enums;

namespace TECBank.Backend.Domains.DTO.Responses;

public class TransacaoDtoResponse
{
    public long Id { get; set; }
    public string? Descricao { get; set; }
    public string Historico { get; set; } = null!;
    public decimal Valor { get; set; }
    public EnumTipoTransacao TipoTransacao { get; set; }
    public EnumTipoOperacao TipoOperacao { get; set; }
    public DateTimeOffset MomentoOperacao { get; set; }
}
