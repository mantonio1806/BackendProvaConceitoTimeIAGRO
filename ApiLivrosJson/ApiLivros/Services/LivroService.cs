using ApiLivros.Models;
using System.Text.Json;

namespace ApiLivros.Services
{
    public class LivroService : ILivroService
    {
        private const string JsonUrl = "https://raw.githubusercontent.com/timeiagro/BackendProvaConceitoTimeIAGRO/main/books.json";

        private async Task<List<Livro>> CarregaLivros()
        {
            try
            {
                using var httpClient = new HttpClient();
                string jsonData = await httpClient.GetStringAsync(JsonUrl);
                return JsonSerializer.Deserialize<List<Livro>>(jsonData) ?? new List<Livro>();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro ao carregar JSON: {ex.Message}");
                return new List<Livro>();
            }
        }

        public async Task<List<Livro>> BuscaLivros(string search, string sortOrder)
        {
            var livros = await CarregaLivros();
            var query = string.IsNullOrWhiteSpace(search)
                ? livros
                : livros.Where(b => b.Name.Contains(search, StringComparison.OrdinalIgnoreCase) ||
                                   b.Specifications.Any(spec => spec.Value.ToString().Contains(search, StringComparison.OrdinalIgnoreCase)));

            return sortOrder.ToLower() == "desc" ? query.OrderByDescending(b => b.Price).ToList() : query.OrderBy(b => b.Price).ToList();
        }

        public async Task<double> CalculaFrete(int id)
        {
            var livros = await CarregaLivros();
            var livro = livros.FirstOrDefault(b => b.Id == id);
            return livro != null ? livro.Price * 0.2 : 0;
        }
    }
}
