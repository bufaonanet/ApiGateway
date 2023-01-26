using Microsoft.AspNetCore.Mvc;

namespace Cafetaria.Catalogo.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CatalogoController : ControllerBase
    {
        List<string> _catalogo = new() { "Latter", "Americado", "Expresso", "Mocha", "Chá" };

        [HttpGet]
        public List<string> Get()
        {
            return _catalogo;
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            if (id <= _catalogo.Count - 1 && id >= 0)
                return Ok(_catalogo[id]);

            return BadRequest($"Não existe café com Id:{id}"!);
        }
    }
}