using TECBank.Backend.Domain.Model;

namespace Domain.Model;

public class Endereco : BaseEntity
{
    public string Logradouro  { get; set; }
    public string Numero {  get; set; }
    public string Cidade { get; set; }
    //public Cliente Cliente { get; set; }

    
}
