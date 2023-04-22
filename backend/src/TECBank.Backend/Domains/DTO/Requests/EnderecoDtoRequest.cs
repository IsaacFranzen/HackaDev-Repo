using System.ComponentModel.DataAnnotations;
using TECBank.Backend.Domains.Models;

namespace TECBank.Backend.Domains.DTO.Requests;

public class EnderecoDtoRequest
{
    [Required(ErrorMessage = "Deve ser informado")]
    public string Logradouro { get; set; } = null!;

    [Required(ErrorMessage = "Deve ser informado")]
    public string Numero { get; set; } = null!;

    public string? Complemento { get; set; }

    [Required(ErrorMessage = "Deve ser informado")]
    public string Bairro { get; set; } = null!;

    [Required(ErrorMessage = "Deve ser informado")]
    public string Cidade { get; set; } = null!;

    [Required(ErrorMessage = "Deve ser informado")]
    public string Estado { get; set; } = null!;

    [Required(ErrorMessage = "Deve ser informado")]
    public string Cep { get; set; } = null!;
}
