namespace TECBank.Backend.Domain.Model;

public abstract class BaseEntity
{
    public int Id { get; set; }
    public DateTimeOffset CriadoEm { get; set; }
    public DateTimeOffset AlteradoEm { get; set; }
    public DateTimeOffset ExcluidoEm { get; set; }


}
