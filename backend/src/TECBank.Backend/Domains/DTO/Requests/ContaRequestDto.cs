using System.ComponentModel.DataAnnotations;

namespace TECBank.Backend.Domains.DTO.Requests;

//ToDo: Colocar nome do correntista no response;
public class ContaRequestDto
{
    public decimal Saldo { get; set; }

    [Required(ErrorMessage = "Você deve informar uma senha")]
    [MinLength(6, ErrorMessage = "A senha informada deve ter pelo menos 6 caractéres")]
    public string Senha { get; set; } = null!;

    [Required(ErrorMessage = "Você deve confirmar a senha")]
    public string ConfirmarSenha { get; set; } = null!;
}
