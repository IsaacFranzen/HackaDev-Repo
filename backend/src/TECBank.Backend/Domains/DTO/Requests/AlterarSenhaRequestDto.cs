using System.ComponentModel.DataAnnotations;

namespace TECBank.Backend.Domains.DTO.Requests;

public class AlterarSenhaRequestDto
{
    [Required(ErrorMessage = "Você deve informar uma senha")]
    [MinLength(6, ErrorMessage = "A senha informada deve ter pelo menos 6 caractéres")]
    public string SenhaAtual { get; set; } = null!;

    [Required(ErrorMessage = "Você deve informar uma senha")]
    [MinLength(6, ErrorMessage = "A senha informada deve ter pelo menos 6 caractéres")]
    public string NovaSenha { get; set; } = null!;

    [Required(ErrorMessage = "Você deve informar uma senha")]
    [MinLength(6, ErrorMessage = "A senha informada deve ter pelo menos 6 caractéres")]
    public string ConfirmarNovaSenha { get; set; } = null!;
}
