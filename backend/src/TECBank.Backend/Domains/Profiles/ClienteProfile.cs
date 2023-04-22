using AutoMapper;
using TECBank.Backend.Domains.DTO.Requests;
using TECBank.Backend.Domains.DTO.Responses;
using TECBank.Backend.Domains.Models;

namespace TECBank.Backend.Domains.Profiles;

public class ClienteProfile : Profile
{
    public ClienteProfile()
    {
        CreateMap<ClienteRequestDto, Cliente>();
        CreateMap<Cliente, ClienteResponseDto>();
    }
}
