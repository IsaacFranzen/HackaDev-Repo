using TECBank.Backend.Domains.DTO.Responses;
using TECBank.Backend.Domains.Enums;

namespace TECBank.Backend.Domains.DTO.Responses;

public class ClienteResponseDto
{
    public string Nome { get; set; } = null!;
    public string Email { get; set; } = null!;
    public EnumSexo Sexo { get; set; }
    public EnumEstadoCivil EstadoCivil { get; set; }
    public string RgNumero { get; set; } = null!;
    public string Cpf { get; set; } = null!;
    public ContaResponseDto Conta { get; set; } = null!;
}
