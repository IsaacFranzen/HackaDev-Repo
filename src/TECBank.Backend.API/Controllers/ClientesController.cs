using AutoMapper;
using Domain.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SQLitePCL;
using TECBank.Backend.Domain.DTO;
using TECBank.Backend.Repository;
using TECBank.Backend.Repository.DataContext;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TECBank.Backend.Controllers;
[Route("api/[controller]")]
[ApiController]
public class ClientesController : ControllerBase
{
    private readonly IMapper _mapper;
    private readonly IRepository _repo;

    public ClientesController( IMapper mapper, IRepository repo)
    { 
        _mapper = mapper;
        _repo = repo;
    }
    // GET: api/<ClientesController>
    [HttpGet("{id}")]
    public IActionResult GetById(int id)
    {
        var cliente = _repo.GetClienteById(id);
        if (cliente == null) return BadRequest("Cliente não encontrado!!!");

        return Ok(cliente);
    }

    // GET api/<ClientesController>/5
    [HttpGet]
    public IActionResult Get()
    {
        var result = _repo.GetAllClientes();

        return Ok(result);
    }

    // POST api/<ClientesController>
    [HttpPost]
    public IActionResult Post(Cliente cliente)
    {
        _repo.Add(cliente);
        if (_repo.SaveChanges())
        {
            return Ok(cliente);
        }
        return BadRequest("Cliente não foi adicionado!!!");

    }

    // PUT api/<ClientesController>/5
    [HttpPut("{id}")]
    public IActionResult Put(int id, Cliente cliente)
    {
        var cli = _repo.GetClienteById(id);
            
        if (cli == null) return BadRequest("Cliente não encontrado");

        _repo.Update(cliente);
        if (_repo.SaveChanges())
        {
            return Ok(cliente);
        }
        return BadRequest("Cliente não encontrado!!!");
    }
    [HttpPatch("{id}")]
    public IActionResult Patch(int id, Cliente cliente)
    {
        var cli = _repo.GetClienteById(id);
            
        if (cli == null) return BadRequest("Cliente não encontrado");

        _repo.Update(cliente);
        if (_repo.SaveChanges())
        {
            return Ok($"Cliente atualizado com sucesso!!!{cliente}");
        }
        return BadRequest("Cliente não encontrado!!!");
    }


    // DELETE api/<ClientesController>/5
    [HttpDelete("{id}")]
    public IActionResult Delete(int id)
    {
        var cliente = _repo.GetClienteById(id);
        if (cliente == null) return BadRequest("Cliente não encontrado");

        _repo.Delete(cliente);
        if (_repo.SaveChanges())
        {
            return Ok("Cliente deletado com sucesso!!!");
        }
        return BadRequest("Cliente não encontrado!!!");
    }
}
