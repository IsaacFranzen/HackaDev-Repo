using TECBank.Backend.Domain.Model;

namespace Domain.Model;

public class Endereco : BaseEntity
{
    public string Logradouro  { get; set; }
    public string Numero {  get; set; }
    public string Cidade { get; set; }

    public Endereco(long id, DateTimeOffset criadoEm, DateTimeOffset alteradoEm, 
        DateTimeOffset excluidoEm,
        string logradouro, string numero, string cidade) 
        : base(id, criadoEm, alteradoEm, excluidoEm)
    {
        Logradouro = logradouro;
        Numero = numero;
        Cidade = cidade;
    }
}
