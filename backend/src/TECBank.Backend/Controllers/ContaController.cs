using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using TECBank.Backend.Domains.DTO.Responses;
using TECBank.Backend.Repository.DataContext;

namespace TECBank.Backend.Controllers;

[Route("api/contas")]
[ApiController]
[Authorize]
public class ContaController : ControllerBase
{
    private readonly TecBankContext _context;
    private readonly IMapper _mapper;

    public ContaController(TecBankContext context, IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }

    [HttpGet]
    public IActionResult Get()
    {
        var id = long.Parse(User.Claims.First(x => x.Type == "Id").Value);
        var conta = _context.Contas.First(u => u.Id == id);

        var contaProfile = _mapper.Map<ContaDtoView>(conta);
        return Ok(contaProfile);
    }
}
