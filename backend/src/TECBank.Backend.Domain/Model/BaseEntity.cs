namespace TECBank.Backend.Domain.Model;

public abstract class BaseEntity
{
    public long Id { get; set; }
    public DateTimeOffset CriadoEm { get; set; }
    public DateTimeOffset AlteradoEm { get; set; }
    public DateTimeOffset ExcluidoEm { get; set; }
}
