using System.Text.Json.Serialization;

namespace Domain.Model.Enums;

[JsonConverter(typeof(JsonStringEnumConverter))]
public enum EstadoCivil : int
{
    Casado = 0,
    Solteiro = 1,
    Divorciado = 2,
    Viuvo = 3
}
