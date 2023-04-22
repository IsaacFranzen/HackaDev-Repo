using AutoMapper;
using TECBank.Backend.Domains.DTO.Requests;
using TECBank.Backend.Domains.Models;

namespace TECBank.Backend.Domains.Profiles;

public class EnderecoProfile : Profile
{
    public EnderecoProfile()
    {
        CreateMap<EnderecoDtoRequest, Endereco>();
    }
}
