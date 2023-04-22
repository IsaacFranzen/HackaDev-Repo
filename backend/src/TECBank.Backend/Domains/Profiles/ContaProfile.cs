using AutoMapper;
using TECBank.Backend.Domains.DTO.Requests;
using TECBank.Backend.Domains.DTO.Responses;
using TECBank.Backend.Domains.Models;

namespace TECBank.Backend.Domains.Profiles;

public class ContaProfile : Profile
{
    public ContaProfile()
    {
        CreateMap<ContaRequestDto, Conta>()
            .ForMember(
                conta => conta.SenhaHash,
                opt => opt.MapFrom(contaRequestDto => contaRequestDto.Senha));
        CreateMap<Conta, ContaResponseDto>();
    }
}
