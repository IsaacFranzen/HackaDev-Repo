using TECBank.Backend.Domain.Enum;

namespace TECBank.Backend.Domain.Interface;

public interface ITransacao
{
    public string? Descrição { get; set; }
    public string Histórico { get; }
    public decimal Valor { get; set; }
    public EnumTipoOperacao OperationType { get; set; }
}
