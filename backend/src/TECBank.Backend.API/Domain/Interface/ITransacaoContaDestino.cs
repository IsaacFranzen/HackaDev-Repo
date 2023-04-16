using System.ComponentModel.DataAnnotations.Schema;
using TECBank.Backend.Domain.Model;

namespace TECBank.Backend.Domain.Interface;

public interface ITransacaoContaDestino
{
    public ContaCorrente ContaDestino { get; set; }
    public long ContaDestinoId { get; set; }
}
