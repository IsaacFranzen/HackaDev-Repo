namespace TECBank.Backend.Domains.Models;

public class Endereco : EntidadeBase
{
    public string Logradouro { get; set; } = null!;
    public string Numero { get; set; } = null!;
    public string? Complemento { get; set; }
    public string Bairro { get; set; } = null!;
    public string Cidade { get; set; } = null!;
    public string Estado { get; set; } = null!;
    public string Cep { get; set; } = null!;
    public long ClienteId { get; set; }
    public Cliente Cliente { get; set; } = null!;
}