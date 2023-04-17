using System.ComponentModel.DataAnnotations;

namespace TECBank.Backend.Domains.DTO.Requests;

public class TransacaoPixRequestDto
{
    public string? Descricao { get; set; }

    [Required]
    [Range(0.01, double.MaxValue, ErrorMessage = "Você deve fornecer um valor a transferir")]
    public decimal Valor { get; set; }

    [Required(ErrorMessage = "Você deve fornecer uma conta de origem")]
    public long ContaOrigemId { get; set; }

    [Required(ErrorMessage = "Você deve fornecer uma conta de destino")]
    public long ContaDestinoId { get; set; }
}
