using Domain.Model;
using Domain.Model.Enums;
using TECBank.Backend.Domain.Model;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;

namespace Domain.Model;

public class Cliente : BaseEntity
{
    
    public string Nome { get; set; }
    public string Email { get; set; }
    public string TelefoneResidencial { get; set; }
    public string TelefoneCelular { get; set; }
    public Sexo Sexo { get; set; }
    public EstadoCivil EstadoCivil { get; set; }
    public string RgNumero { get; set; }
    public DateTime RgDataEmissao { get; set; }
    public string RgOrgaoExpedidor { get; set; }
    public string RgEstado { get; set; }
    public string Cpf { get; set; }
    public string NomePai { get; set; }
    public string NomeMae { get; set; }
    public string Naturalidade { get; set; }
    public string Nacionalidade { get; set; }
    public string Profissao { get; set; }
    public string NomeEmpresa { get; set; }
    public string TelefoneEmpresa { get; set; }
    public double RendaMensal { get; set; }
    public double Patrimonio { get; set; }
    public Endereco Endereco { get; set; }


}
