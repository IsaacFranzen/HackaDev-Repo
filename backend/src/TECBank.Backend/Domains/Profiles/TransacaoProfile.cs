using AutoMapper;
using TECBank.Backend.Domains.DTO.Requests;
using TECBank.Backend.Domains.DTO.Responses;
using TECBank.Backend.Domains.Models;

namespace TECBank.Backend.Domains.Profiles;

public class TransacaoProfile : Profile
{
    public TransacaoProfile()
    {
        CreateMap<Transacao, TransacaoDtoResponse>()
            .ForMember(
                transacaoDto => transacaoDto.MomentoOperacao,
                opt => opt.MapFrom(transacao => transacao.CriadoEm));
        CreateMap<TransacaoDepositoRequestDto, Transacao>();
    }
}
