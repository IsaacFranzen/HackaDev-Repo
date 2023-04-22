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

        return Ok(_mapper.Map<ClienteDTO>(cliente));
    }

    // GET api/<ClientesController>/5
    [HttpGet]
    public IActionResult Get()
    {
        var clientes = _repo.GetAllClientes();

        return Ok(_mapper.Map<IEnumerable<ClienteDTO>>(clientes));
    }

    // POST api/<ClientesController>
    [HttpPost]
    public IActionResult Post(ClienteDTO model)
    {
        var cliente = _mapper.Map<Cliente>(model);

        _repo.Add(cliente);
        if (_repo.SaveChanges())
        {
            return Created($"/api/clientes/{model.Id}",_mapper.Map<ClienteDTO>(cliente));
        }
        return BadRequest("Cliente não foi adicionado!!!");

    }

    // PUT api/<ClientesController>/5
    [HttpPut("{id}")]
    public IActionResult Put(int id, ClienteDTO model)
    {
        var cliente = _repo.GetClienteById(id);
            
        if (cliente == null) return BadRequest("Cliente não encontrado");

        _mapper.Map(model,cliente);

        _repo.Update(cliente);
        if (_repo.SaveChanges())
        {
            return Created($"/api/clientes/{model.Id}",_mapper.Map<ClienteDTO>(cliente));
        }
        return BadRequest("Cliente não encontrado!!!");
    }
    [HttpPatch("{id}")]
    public IActionResult Patch(int id, ClienteDTO model)
    {
        var cliente = _repo.GetClienteById(id);
            
        if (cliente == null) return BadRequest("Cliente não encontrado");

        _mapper.Map(model, cliente);

        _repo.Update(cliente);
        if (_repo.SaveChanges())
        {
            return Created($"/api/lientes/{model.Id}", _mapper.Map<ClienteDTO>(cliente));
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
