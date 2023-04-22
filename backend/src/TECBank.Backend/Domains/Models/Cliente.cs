using TECBank.Backend.Domains.Enums;

namespace TECBank.Backend.Domains.Models;

public class Cliente : EntidadeBase
{
    public string Nome { get; set; } = null!;
    public string Email { get; set; } = null!;
    public string? TelefoneResidencial { get; set; }
    public string TelefoneCelular { get; set; } = null!;
    public EnumSexo Sexo { get; set; }
    public EnumEstadoCivil EstadoCivil { get; set; }
    public string RgNumero { get; set; } = null!;
    public DateTime RgDataEmissao { get; set; }
    public string RgOrgaoExpedidor { get; set; } = null!;
    public string RgEstado { get; set; } = null!;
    public string Cpf { get; set; } = null!;
    public string NomePai { get; set; } = null!;
    public string NomeMae { get; set; } = null!;
    public string Naturalidade { get; set; } = null!;
    public string Nacionalidade { get; set; } = null!;
    public string? Profissao { get; set; }
    public string? NomeEmpresa { get; set; }
    public string? TelefoneEmpresa { get; set; }
    public double RendaMensal { get; set; }
    public double Patrimonio { get; set; }
    public Endereco Endereco { get; set; } = null!;
    public Conta Conta { get; set; } = null!;
}