using Domain.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TECBank.Backend.Repository.DataContext;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TECBank.Backend.Controllers;
[Route("api/[controller]")]
[ApiController]
public class ClientesController : ControllerBase
{
    private readonly TecBankContext _context;

    public ClientesController(TecBankContext context)
    {
        _context = context;
    }
    // GET: api/<ClientesController>
    [HttpGet]
    public IActionResult Get()
    {
        return Ok(_context.Clientes);
    }

    // GET api/<ClientesController>/5
    [HttpGet("{id}")]
    public IActionResult Get(int id)
    {
        var cliente = _context.Clientes.FirstOrDefault(c => c.Id == id);
        if (cliente == null) return BadRequest("Cliente não encontrado");
        return Ok(cliente);
    }

    // POST api/<ClientesController>
    [HttpPost]
    public IActionResult Post(Cliente cliente)
    {
        _context.Add(cliente);
        _context.SaveChanges();
        return Ok(cliente);
    }

    // PUT api/<ClientesController>/5
    [HttpPut("{id}")]
    public IActionResult Put(int id, Cliente cliente)
    {
        var client = _context.Clientes.AsNoTracking().FirstOrDefault(c => c.Id == id);
        if (client == null) return BadRequest("Cliente não encontrado");
        _context.Update(cliente);
        _context.SaveChanges();
        return Ok(cliente);
    }
    [HttpPatch("{id}")]
    public IActionResult Patch(int id, Cliente cliente)
    {
        var client = _context.Clientes.AsNoTracking().FirstOrDefault(c => c.Id == id);
        if (client == null) return BadRequest("Cliente não encontrado");
        _context.Update(cliente);
        _context.SaveChanges();
        return Ok(cliente);
    }

    // DELETE api/<ClientesController>/5
    [HttpDelete("{id}")]
    public IActionResult Delete(int id)
    {
        var cliente = _context.Clientes.FirstOrDefault(c => c.Id == id);
        if (cliente == null) return BadRequest("Cliente não encontrado");
        _context.Remove(cliente);
        _context.SaveChanges();
        return Ok(cliente);
    }
}
