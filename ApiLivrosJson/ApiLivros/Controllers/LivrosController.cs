using ApiLivros.Services;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace ApiLivros.Controllers
{
    [ApiController]
    [Route("api/livros")]
    public class LivrosController : ControllerBase
    {
        private readonly ILivroService _livroService;

        public LivrosController(ILivroService livroService)
        {
            _livroService = livroService;
        }

        [HttpGet]
        public async Task<IActionResult> BuscaLivros([FromQuery] string? search, [FromQuery] string sortOrder = "asc")
        {
            var livros = await _livroService.BuscaLivros(search, sortOrder);
            return livros.Count() > 0 ? Ok(livros) : NotFound("Livro não encontrado.");
        }

        [HttpGet("calcula-frete/{id}")]
        public async Task<IActionResult> CalculaFrete(int id)
        {
            var freteCalc = await _livroService.CalculaFrete(id);
            return freteCalc > 0 ? Ok(new { FreteCalc = freteCalc }) : NotFound("Livro não encontrado.");
        }

    }
}
