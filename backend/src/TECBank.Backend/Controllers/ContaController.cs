using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using TECBank.Backend.Domains.DTO.Requests;
using TECBank.Backend.Domains.DTO.Responses;
using TECBank.Backend.Repository.DataContext;
using TECBank.Backend.Services;
using TECBank.Backend.Shared;

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
        var conta = _context.Contas.FirstOrDefault(u => u.Id == id);

        var contaProfile = _mapper.Map<ContaResponseDto>(conta);
        return Ok(contaProfile);
    }

    [HttpPost]
    [Route("alterarSenha")]
    public IActionResult AlterarSenha(
        [FromBody] AlterarSenhaRequestDto requisicao)
    {
        var id = long.Parse(User.Claims.First(x => x.Type == "Id").Value);
        var conta = _context.Contas.First(u => u.Id == id);

        if (!PasswordService.Verify(requisicao.SenhaAtual, conta.SenhaHash))
            ModelState.AddModelError(
                nameof(requisicao.SenhaAtual),
                "A senha atual informada é inválida");

        if (!ModelState.IsValid) return ValidationProblem(
            statusCode: StatusCodes.Status406NotAcceptable);

        conta.SenhaHash = PasswordService.Hash(requisicao.NovaSenha);
        _context.SaveChanges();

        return Ok(new MessageResponse("Senha atualizada com sucesso!"));
    }
}
