using System.ComponentModel.DataAnnotations;

namespace TECBank.Backend.Domain.DTO.Request;

public class TransacoesRequestDto
{
    [Range(1, long.MaxValue, ErrorMessage="Você deve fornecer um Id para a consulta")]
    public long Id { get; set; }
}
