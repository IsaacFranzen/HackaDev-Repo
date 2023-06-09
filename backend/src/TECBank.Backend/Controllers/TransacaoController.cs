using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Net;
using TECBank.Backend.Domains.DTO.Requests;
using TECBank.Backend.Domains.DTO.Responses;
using TECBank.Backend.Domains.Enums;
using TECBank.Backend.Domains.Models;
using TECBank.Backend.Repository.DataContext;
using TECBank.Backend.Shared;

namespace TECBank.Backend.Controllers;
[Route("api/transacoes")]
[ApiController]
[Authorize]
public class TransacaoController : ControllerBase
{
    private readonly TecBankContext _context;
    private readonly IMapper _mapper;

    public TransacaoController(TecBankContext context, IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }

    /// <summary>
    /// Retorna uma Lista de transações
    /// </summary>
    [HttpGet]
    public ActionResult<List<TransacaoDtoResponse>> Historico()
    {
        var id = long.Parse(User.Claims.First(x => x.Type == "Id").Value);
        var conta = _context.Contas.First(c => c.Id == id);

        var transacoes = _context.Transacoes
            .Where(t => t.ContaId == conta.Id).ToList();

        var transacoesResponse = transacoes
            .Select(t => _mapper.Map<TransacaoDtoResponse>(t))
            .OrderBy(t => t.MomentoOperacao);

        return Ok(transacoesResponse);
    }

    /// <summary>
    /// Operação de Depósito
    /// </summary>
    [HttpPost]
    [Route("deposito")]
    public ActionResult<MessageResponse> Deposito(
        [FromBody] TransacaoDepositoRequestDto requisicao)
    {
        var depositoAdd = _mapper.Map<Transacao>(requisicao);

        var id = long.Parse(User.Claims.First(x => x.Type == "Id").Value);
        var contaADepositar = _context.Contas.First(c => c.Id == id);

        depositoAdd.ContaId = contaADepositar!.Id;
        depositoAdd.Historico = "Depósito em conta";
        contaADepositar!.Saldo += requisicao.Valor;

        _context.Transacoes.Add(depositoAdd);
        _context.SaveChanges();

        var returnMessage = new MessageResponse(
            "Depósito realizado com sucesso.",
            depositoAdd.CriadoEm);

        return Ok(returnMessage);
    }

    /// <summary>
    /// Operação de Transferência por meio de PIX
    /// </summary>
    [HttpPost]
    [Route("pix")]
    public ActionResult<MessageResponse> Pix(
        [FromBody] TransacaoPixRequestDto requisicao)
    {
        var id = long.Parse(User.Claims.First(x => x.Type == "Id").Value);
        var contaOrigem = _context.Contas.Include(c => c.Cliente)
            .First(c => c.Id == id);
        var contaDestino = _context.Contas.Include(c => c.Cliente)
            .FirstOrDefault(c => c.NumeroConta == requisicao.NumeroContaDestino);

        if (contaDestino == null) ModelState.AddModelError(
            "Conta de Destino",
            "A conta de destino fornecida não existe");

        if (contaOrigem == contaDestino) ModelState.AddModelError(
            "Contas Correntes", 
            "As contas de origem e destino não podem ser iguais");

        if (!ModelState.IsValid) return ValidationProblem(
            statusCode: (int)HttpStatusCode.NotAcceptable);

        if (contaOrigem!.Saldo < requisicao.Valor)
        {
            ModelState.AddModelError(
                "Saldo insulficiente",
                "O saldo disponível na conta de origem é inferior ao valor" +
                " a ser transferido.");
            return ValidationProblem(
                statusCode: (int)HttpStatusCode.NotAcceptable);
        }

        var transacaoContaOrigem = new Transacao
        {
            Descricao = requisicao.Descricao,
            Historico = $"Transferência PIX enviada para {contaDestino!.Cliente.Nome}",
            Valor = requisicao.Valor,
            TipoTransacao = EnumTipoTransacao.PIX,
            TipoOperacao = EnumTipoOperacao.Debito,
            ContaId = contaOrigem!.Id
        };

        var transacaoContaDestino = new Transacao
        {
            Historico = $"Transferência PIX recebida de {contaOrigem!.Cliente.Nome}",
            Valor = requisicao.Valor,
            TipoTransacao = EnumTipoTransacao.PIX,
            TipoOperacao = EnumTipoOperacao.Credito,
            ContaId = contaDestino!.Id
        };

        contaOrigem.Saldo -= requisicao.Valor;
        _context.Transacoes.Add(transacaoContaOrigem);
        
        contaDestino.Saldo += requisicao.Valor;
        _context.Transacoes.Add(transacaoContaDestino);

        _context.SaveChanges();

        return Ok(new MessageResponse(
            "Operação de Transferência PIX concluída com sucesso"));
    }

}
