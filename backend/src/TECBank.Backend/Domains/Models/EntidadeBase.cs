using System.ComponentModel.DataAnnotations;

namespace TECBank.Backend.Domains.Models;

public interface IEntidadeBase
{
    [Key]
    [Required]
    public long Id { get; set; }

    [Required]
    public DateTimeOffset CriadoEm { get; set; }
    public DateTimeOffset? AtualizadoEm { get; set; }
    public DateTimeOffset? ExcluidoEm { get; set; }
}

public abstract class EntidadeBase : IEntidadeBase
{
    [Key]
    [Required]
    public long Id { get; set; }

    [Required]
    public DateTimeOffset CriadoEm { get; set; }

    public DateTimeOffset? AtualizadoEm { get; set; }

    public DateTimeOffset? ExcluidoEm { get; set; }
}
