namespace TECBank.Backend.Domain.Model;

public abstract class BaseEntity
{
    public long Id { get; set; }
    public DateTimeOffset CriadoEm { get; set; }
    public DateTimeOffset AlteradoEm { get; set; }
    public DateTimeOffset ExcluidoEm { get; set; }

    public BaseEntity(long id, DateTimeOffset criadoEm, DateTimeOffset alteradoEm, DateTimeOffset excluidoEm)
    {
        Id = id;
        CriadoEm = criadoEm;
        AlteradoEm = alteradoEm;
        ExcluidoEm = excluidoEm;
    }
}
