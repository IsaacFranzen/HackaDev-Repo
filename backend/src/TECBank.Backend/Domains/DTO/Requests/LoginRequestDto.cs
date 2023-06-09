using System.ComponentModel.DataAnnotations;

namespace TECBank.Backend.Domains.DTO.Requests;

public class LoginRequestDto
{
    [Required(ErrorMessage = "Você deve informar o número da conta")]
    public string NumeroConta { get; set; } = null!;

    [Required(ErrorMessage = "Você deve informar uma senha")]
    [MinLength(6, ErrorMessage = "A senha informada deve ter pelo menos 6 caractéres")]
    public string Senha { get; set; } = null!;
}
