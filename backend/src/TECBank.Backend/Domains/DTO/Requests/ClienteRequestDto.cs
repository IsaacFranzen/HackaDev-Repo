using System.ComponentModel.DataAnnotations;
using TECBank.Backend.Domains.DTO.Requests;
using TECBank.Backend.Domains.DTO.Responses;
using TECBank.Backend.Domains.Enums;
using TECBank.Backend.Domains.Models;

namespace TECBank.Backend.Domains.DTO.Requests;

public class ClienteRequestDto
{
    [Required(ErrorMessage = "Deve ser informado.")]
    public string Nome { get; set; } = null!;

    [Required(ErrorMessage = "Deve ser informado.")]
    public string Email { get; set; } = null!;

    public string? TelefoneResidencial { get; set; }

    [Required(ErrorMessage = "Deve ser informado.")]
    public string TelefoneCelular { get; set; } = null!;

    [Required(ErrorMessage = "Deve ser informado.")]
    public EnumSexo Sexo { get; set; }

    [Required(ErrorMessage = "Deve ser informado.")]
    public EnumEstadoCivil EstadoCivil { get; set; }

    [Required(ErrorMessage = "Deve ser informado.")]
    public string RgNumero { get; set; } = null!;

    [Required(ErrorMessage = "Deve ser informado.")]
    public DateTime RgDataEmissao { get; set; }

    [Required(ErrorMessage = "Deve ser informado.")]
    public string RgOrgaoExpedidor { get; set; } = null!;

    [Required(ErrorMessage = "Deve ser informado.")]
    public string RgEstado { get; set; } = null!;

    [Required(ErrorMessage = "Deve ser informado.")]
    public string Cpf { get; set; } = null!;

    [Required(ErrorMessage = "Deve ser informado.")]
    public string NomePai { get; set; } = null!;

    [Required(ErrorMessage = "Deve ser informado.")]
    public string NomeMae { get; set; } = null!;

    [Required(ErrorMessage = "Deve ser informado.")]
    public string Naturalidade { get; set; } = null!;

    [Required(ErrorMessage = "Deve ser informado.")]
    public string Nacionalidade { get; set; } = null!;

    public string? Profissao { get; set; }

    public string? NomeEmpresa { get; set; }

    public string? TelefoneEmpresa { get; set; }

    [Required(ErrorMessage = "Deve ser informado.")]
    [DataType(DataType.Currency)]
    public double RendaMensal { get; set; }

    [Required(ErrorMessage = "Deve ser informado.")]
    public double Patrimonio { get; set; }

    [Required(ErrorMessage = "Deve ser informado.")]
    public EnderecoDtoRequest Endereco { get; set; } = null!;
    public ContaRequestDto Conta { get; set; } = null!;
}
