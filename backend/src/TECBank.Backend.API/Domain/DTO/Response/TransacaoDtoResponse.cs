using TECBank.Backend.Domain.Enum;

namespace TECBank.Backend.Domain.DTO.Response;

public class TransacaoDtoResponse
{
    public long Id { get; set; }
    public string? Descrição { get; set; }
    public string Historico { get; set; } = null!;
    public decimal Valor { get; set; }
    public EnumTipoOperacao OperationType { get; set; }
    public DateTimeOffset MomentoOperacao { get; set; }
}
