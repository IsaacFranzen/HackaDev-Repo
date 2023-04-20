using AutoMapper;
using Microsoft.AspNetCore.Mvc;
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
public class TransactionController : ControllerBase
{
    private readonly TecBankContext _context;
    private readonly IMapper _mapper;

    public TransactionController(TecBankContext context, IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }

    /// <summary>
    /// Retorna uma Lista de transações
    /// </summary>
    [HttpGet("{id:int}")]
    public ActionResult<IEnumerable<TransacaoDtoResponse>> Historico(
        [FromRoute] long id)
    {
        var conta = _context.Contas.FirstOrDefault(c => c.Id == id);
        
        if (conta == null) ModelState.AddModelError(
            "id",
            "A conta de destino fornecida não existe");

        if (!ModelState.IsValid) return ValidationProblem();

        var transacoes = _context.Transacoes
            .Where(t => t.ContaCorrenteId == id).ToList();

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

        var contaADepositar = _context
            .Contas
            .FirstOrDefault(c => c.Id == requisicao.ContaDestinoId);

        if (contaADepositar == null) ModelState.AddModelError(
            nameof(requisicao.ContaDestinoId),
            "A conta de destino fornecida não existe");

        if (!ModelState.IsValid) return ValidationProblem();

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
        var contaOrigem = _context.Contas
            .FirstOrDefault(c => c.Id == requisicao.ContaOrigemId);
        var contaDestino = _context.Contas
            .FirstOrDefault(c => c.Id == requisicao.ContaDestinoId);

        if (contaOrigem == null) ModelState.AddModelError(
            "Conta de Origem",
            "A conta de origem fornecida não existe");

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
            //ToDo: Colocar nome do destinatário;
            Historico = "Transferência PIX enviada para XXXX",
            Valor = requisicao.Valor,
            TipoTransacao = EnumTipoTransacao.PIX,
            TipoOperacao = EnumTipoOperacao.Debito,
            ContaCorrenteId = contaOrigem!.Id
        };

        var transacaoContaDestino = new Transacao
        {
            //ToDo: Colocar nome do remetente;
            Historico = $"Transferência PIX recebida de XXXX",
            Valor = requisicao.Valor,
            TipoTransacao = EnumTipoTransacao.PIX,
            TipoOperacao = EnumTipoOperacao.Credito,
            ContaCorrenteId = contaDestino!.Id
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
