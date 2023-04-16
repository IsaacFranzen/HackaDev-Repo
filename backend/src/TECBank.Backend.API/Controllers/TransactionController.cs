using Microsoft.AspNetCore.Mvc;
using TECBank.Backend.Domain.DTO.Request;
using TECBank.Backend.Domain.DTO.Response;
using TECBank.Backend.Domain.Enum;
using TECBank.Backend.Domain.Interface;
using TECBank.Backend.Domain.Model;
using TECBank.Backend.Repository.DataContext;

namespace TECBank.Backend.Controllers;
[Route("api/transacoes")]
[ApiController]
public class TransactionController : ControllerBase
{
    private readonly TecBankContext _context;

    public TransactionController(TecBankContext context)
    {
        _context = context;
    }

    /// <summary>
    /// Retorna uma Lista de transações
    /// </summary>
    [HttpGet("{id:int}")]
    public ActionResult<List<TransacaoDtoResponse>> Historico(
        [FromRoute] long id)
    {
        var conta = _context.ContasCorrentes.FirstOrDefault(c => c.Id == id);
        
        if (conta == null)
        {
            ModelState.AddModelError(
                "Conta Corrente",
                "A conta de destino fornecida não existe");
            return ValidationProblem();
        }

        var transacoesPix = _context.TransacoesPix
            .Where(t => t.ContaCorrenteId == id).ToList();
        var transacoesDepositos = _context.TransacoesDepositos
            .Where(t => t.ContaDestinoId == id).ToList();

        var transacoes = new List<ITransacao>(
            transacoesPix.Count + transacoesDepositos.Count);

        transacoes.AddRange(transacoesPix);
        transacoes.AddRange(transacoesDepositos);

        var transacoesResponse = transacoes.Select(t => new TransacaoDtoResponse
        {
            Id = t.Id,
            Descrição = t.Descrição,
            Historico = t.Historico,
            Valor = t.Valor,
            OperationType = t.OperationType,
            MomentoOperacao = t.CriadoEm,
        }).OrderBy(t => t.MomentoOperacao);

        return Ok(transacoesResponse);
    }

    /// <summary>
    /// Operação de Depósito
    /// </summary>
    [HttpPost]
    [Route("deposito")]
    public ActionResult Deposito(
        [FromBody] TransacaoDepositoRequestDto requisicaoDeposito)
    {
        var depositoAdd = new TransacaoDeposito
        {
            Descrição = requisicaoDeposito.Descrição,
            Historico = "Depósito em conta corrente",
            Valor = requisicaoDeposito.Valor,
            OperationType = EnumTipoOperacao.Credito,
            ContaDestinoId = requisicaoDeposito.ContaDestinoId
        };

        var contaADepositar = _context
            .ContasCorrentes
            .FirstOrDefault(c => c.Id == requisicaoDeposito.ContaDestinoId);

        if (contaADepositar == null)
        {
            ModelState.AddModelError(
                nameof(requisicaoDeposito.ContaDestinoId),
                "A conta de destino fornecida não existe");
            return ValidationProblem();
        }

        _context.TransacoesDepositos.Add(depositoAdd);
        decimal novoSaldo = contaADepositar.Saldo + requisicaoDeposito.Valor;
        contaADepositar.Saldo = novoSaldo;
        _context.SaveChanges();

        return Ok(new {
            Message = "Depósito realizado com sucesso.",
            Moment = depositoAdd.CriadoEm
        });
    }
}
