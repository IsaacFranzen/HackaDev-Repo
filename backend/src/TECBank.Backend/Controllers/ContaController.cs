using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using TECBank.Backend.Domains.DTO.Responses;
using TECBank.Backend.Repository.DataContext;

namespace TECBank.Backend.Controllers;

[Route("api/contas")]
[ApiController]
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
    public IActionResult GetAll()
    {
        var contas = _context.Contas.Select(conta => _mapper.Map<ContaDtoView>(conta)).ToList();

        if (contas.Count == 0)
        {
            return NotFound(new
            {
                Moment = DateTime.Now,
                Message = "A lista de contas está vazia."
            });
        }

        return Ok(contas);
    }

    [HttpGet]
    [Route("{id}")]
    public IActionResult GetById(int id)
    {
        var conta = _context.Contas.FirstOrDefault(u => u.Id == id);

        if (conta == null)
        {
            return NotFound(new
            {
                Moment = DateTime.Now,
                Message = $"Não é possível encontrar o conta com id = {id}."
            });
        }

        var contaProfile = _mapper.Map<ContaDtoView>(conta);
        return Ok(contaProfile);
    }
}
