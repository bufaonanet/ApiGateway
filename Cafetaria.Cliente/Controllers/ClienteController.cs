using Microsoft.AspNetCore.Mvc;

namespace Cafetaria.Cliente.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ClienteController : ControllerBase
    {
        List<string> _clientes = new() { "Douglas", "Bufão", "Zezinho", "Maria", "Tonho" };

        [HttpGet]
        public List<string> Get()
        {
            return _clientes;
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            if (id <= _clientes.Count - 1 && id >= 0)
                return Ok(_clientes[id]);

            return BadRequest($"Não existe cliente com Id:{id}"!);
        }
    }
}