using AutoMapper;
using Domain.Model;
using TECBank.Backend.Domain.DTO;

namespace TECBank.Backend.Domain.Profiles;

public class TECBankProfile : Profile
{
	public TECBankProfile()
	{
		CreateMap<Cliente, ClienteDTO>().ReverseMap();
	}
}