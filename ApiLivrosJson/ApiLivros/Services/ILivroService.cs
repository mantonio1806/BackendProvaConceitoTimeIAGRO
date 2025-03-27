using ApiLivros.Models;

namespace ApiLivros.Services
{
    public interface ILivroService
    {
        Task<List<Livro>> BuscaLivros(string? search, string sortOrder);
        Task<double> CalculaFrete(int id);
    }
}
