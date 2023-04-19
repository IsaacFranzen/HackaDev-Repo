using System.Text.Json.Serialization;

namespace Domain.Model.Enums;

//[JsonConverter(typeof(JsonStringEnumConverter))]
public enum Sexo :int 
{
    Prefiro_Nao_Informar = 0,
    Masculino = 1 ,
    Feminino = 2
}
