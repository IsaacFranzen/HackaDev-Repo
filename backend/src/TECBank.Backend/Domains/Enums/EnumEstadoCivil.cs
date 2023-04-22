using System.Text.Json.Serialization;

namespace TECBank.Backend.Domains.Enums;

[JsonConverter(typeof(JsonStringEnumConverter))]
public enum EnumEstadoCivil
{
    Casado = 0,
    Solteiro = 1,
    Divorciado = 2,
    Viuvo = 3
}
