using System.ComponentModel.DataAnnotations.Schema;
using TECBank.Backend.Domain.Enum;
using TECBank.Backend.Domain.Model;

namespace TECBank.Backend.Domain.Interface;

public interface ITransacaoContaOrigem
{ 
    public ContaCorrente ContaOrigem { get; set; }
    public long ContaOrigemId { get; set; }
}
