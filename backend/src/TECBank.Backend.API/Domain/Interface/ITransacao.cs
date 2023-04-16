using TECBank.Backend.Domain.Enum;
using TECBank.Backend.Domain.Model;

namespace TECBank.Backend.Domain.Interface;

public interface ITransacao : IEntidadeBase
{
    public string? Descrição { get; set; }
    public string Historico { get; set; }
    public decimal Valor { get; set; }
    public EnumTipoOperacao OperationType { get; set; }
}