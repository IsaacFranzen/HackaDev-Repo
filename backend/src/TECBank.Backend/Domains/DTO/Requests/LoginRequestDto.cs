using System.ComponentModel.DataAnnotations;

namespace TECBank.Backend.Domains.DTO.Requests;

public class LoginRequestDto
{
    [Required]
    public string NumeroConta { get; set; } = null!;

    [Required]
    public string Senha { get; set; } = null!;
}
