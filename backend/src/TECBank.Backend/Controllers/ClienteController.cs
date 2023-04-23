using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TECBank.Backend.Domains.DTO.Requests;
using TECBank.Backend.Domains.DTO.Responses;
using TECBank.Backend.Domains.Models;
using TECBank.Backend.Repository.DataContext;
using TECBank.Backend.Services;
using TECBank.Backend.Shared;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TECBank.Backend.Controllers;
[Route("api/clientes")]
[ApiController]
public class ClienteController : ControllerBase
{
    private readonly IMapper _mapper;
    private readonly TecBankContext _context;

    public ClienteController(IMapper mapper, TecBankContext context)
    {
        _mapper = mapper;
        _context = context;
    }

    /// <summary>
    /// Retorna o cliente logado
    /// </summary>
    [HttpGet]
    [Authorize]
    public ActionResult<ClienteResponseDto> Get()
    {
        var id = long.Parse(User.Claims.First(x => x.Type == "Id").Value);
        var cliente = _context.Clientes
            .Include(c => c.Conta).FirstOrDefault(u => u.Id == id);

        return Ok(_mapper.Map<ClienteResponseDto>(cliente));
    }

    /// <summary>
    /// Cadastra um cliente (rota anônima)
    /// </summary>
    [HttpPost]
    public ActionResult<ClienteResponseDto> Post(ClienteRequestDto model)
    {
        var customerExists = _context.Clientes.Any(c => c.Cpf == model.Cpf);

        if (customerExists) ModelState.AddModelError(
            nameof(model.Cpf),
            "Já existe um cliente para o CPF informado");
        
        if (model.Conta.Senha != model.Conta.ConfirmarSenha)
            ModelState.AddModelError(
                "Senhas", "As senhas devem ser iguais");

        if (!ModelState.IsValid) return ValidationProblem(
            statusCode: StatusCodes.Status406NotAcceptable);

        model.Conta.Senha = PasswordService.Hash(model.Conta.Senha);
        
        var cliente = _mapper.Map<Cliente>(model);

        _context.Clientes.Add(cliente);
        _context.SaveChanges();

        var clienteARetornar = _mapper.Map<ClienteResponseDto>(cliente);

        return Ok(new
        {
            Messagem = new MessageResponse("Cliente criado com sucesso"),
            Cliente = clienteARetornar
        });
    }

    /// <summary>
    /// Edita o cliente logado
    /// </summary>
    [HttpPut]
    [Authorize]
    public ActionResult<MessageResponse> Put(ClienteRequestDto model)
    {
        var id = long.Parse(User.Claims.First(x => x.Type == "Id").Value);
        var cliente = _context.Clientes.FirstOrDefault(c => c.Id == id);

        if (cliente == null) ModelState.AddModelError(
            "Id",
            "Nenhum cliente encontrado para o Id informado");

        if (!ModelState.IsValid) return ValidationProblem();

        var clienteAAlterar = _mapper.Map<Cliente>(model);
        clienteAAlterar.Id = id;

        _context.Clientes.Update(clienteAAlterar);
        _context.SaveChanges();

        return Ok(new MessageResponse("Cliente atualizado com sucesso"));
    }

    /// <summary>
    /// Deleta o cliente logado.
    /// </summary>
    [HttpDelete]
    public ActionResult<MessageResponse> Delete()
    {
        var id = long.Parse(User.Claims.First(x => x.Type == "Id").Value);
        var cliente = _context.Clientes.First(c => c.Id == id);

        _context.Clientes.Remove(cliente);
        _context.SaveChanges();
        
        return Ok(new MessageResponse("Cliente deletado com sucesso"));
    }
}