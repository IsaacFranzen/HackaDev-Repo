using AutoMapper;
using TECBank.Backend.Domains.DTO.Responses;
using TECBank.Backend.Domains.Models;

namespace TECBank.Backend.Domains.Profiles;

public class ContaProfile : Profile
{
    public ContaProfile()
    {
        CreateMap<Conta, ContaDtoView>();
    }
}
