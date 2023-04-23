using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TECBank.Backend.Domains.DTO.Requests;
using TECBank.Backend.Domains.DTO.Responses;
using TECBank.Backend.Repository.DataContext;
using TECBank.Backend.Services;

namespace TECBank.Backend.Controllers;

[ApiController]
[Route("api")]
public class LoginController : ControllerBase
{
    private readonly TecBankContext _context;
    private readonly IConfiguration _configuration;
    private readonly IMapper _mapper;

    public LoginController(
        TecBankContext context, IConfiguration configuration, IMapper mapper)
    {
        _context = context;
        _configuration = configuration;
        _mapper = mapper;
    }

    /// <summary>
    /// Loga um usuário (rota anônima)
    /// </summary>
    [HttpPost]
    [Route("login")]
    public ActionResult<LoginResponseDto> Authenticate([FromBody] LoginRequestDto requisicao)
    {
        var contaALogar = _context.Contas.Include(c => c.Cliente)
            .FirstOrDefault(c => c.NumeroConta == requisicao.NumeroConta);

        var checaSenha = PasswordService
            .Verify(requisicao.Senha, contaALogar?.SenhaHash ?? "");

        if (contaALogar == null || !checaSenha) ModelState.AddModelError(
            "Dados não conferem",
            "O número da conta ou a senha fornecida não conferem.");

        if (!ModelState.IsValid)
            return ValidationProblem(statusCode: StatusCodes.Status403Forbidden);

        var clienteARetornar = _mapper.Map<ClienteResponseDto>(contaALogar!.Cliente);
        string jwtSecret = _configuration.GetSection("JwtSecret").Value;
        var token = TokenJwtService.GerarToken(contaALogar!, jwtSecret);

        var resposta = new LoginResponseDto
        {
            Cliente = clienteARetornar,
            Token = token
        };

        return Ok(resposta);
    }
}
