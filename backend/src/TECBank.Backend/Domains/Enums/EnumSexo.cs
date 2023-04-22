using System.Text.Json.Serialization;

namespace TECBank.Backend.Domains.Enums;

[JsonConverter(typeof(JsonStringEnumConverter))]
public enum EnumSexo
{
    PrefiroNaoInformar = 0,
    Masculino = 1,
    Feminino = 2
}
