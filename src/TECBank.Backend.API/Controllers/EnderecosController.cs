using Microsoft.AspNetCore.Mvc;
using TECBank.Backend.Repository.DataContext;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TECBank.Backend.Controllers;
[Route("api/[controller]")]
[ApiController]
public class EnderecosController : ControllerBase
{
    private readonly TecBankContext _context;

    public EnderecosController(TecBankContext context)
    {
        _context = context;
    }
    // GET: api/<EnderecosController>
    [HttpGet]
    public IActionResult Get()
    {
        return Ok(_context.Enderecos);
    }

    // GET api/<EnderecosController>/5
    [HttpGet("{id}")]
    public string Get(int id)
    {
        return "value";
    }

    // POST api/<EnderecosController>
    [HttpPost]
    public void Post([FromBody] string value)
    {
    }

    // PUT api/<EnderecosController>/5
    [HttpPut("{id}")]
    public void Put(int id, [FromBody] string value)
    {
    }

    // DELETE api/<EnderecosController>/5
    [HttpDelete("{id}")]
    public void Delete(int id)
    {
    }
}
