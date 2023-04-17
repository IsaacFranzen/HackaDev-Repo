using System.Text.Json.Serialization;

namespace TECBank.Backend.Domains.Enums;

[JsonConverter(typeof(JsonStringEnumConverter))]
public enum EnumTipoOperacao
{
    Credito, Debito
}
