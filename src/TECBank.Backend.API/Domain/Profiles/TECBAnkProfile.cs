using AutoMapper;
using Domain.Model;
using TECBank.Backend.Domain.DTO;

namespace TECBank.Backend.Domain.Profiles;

public class TECBAnkProfile : Profile
{
	public TECBAnkProfile()
	{
		CreateMap<Cliente, ClienteDTO>();
	}
}