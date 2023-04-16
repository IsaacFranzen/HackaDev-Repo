using System.Text.Json.Serialization;

namespace TECBank.Backend.Domain.Enum;

[JsonConverter(typeof(JsonStringEnumConverter))]
public enum EnumTipoOperacao
{
    Credito, Debito
}
