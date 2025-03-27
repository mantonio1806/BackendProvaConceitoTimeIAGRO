using ApiLivros.Services;


namespace ApiLivros.Tests
{
    public class LivroControllerTests
    {
        private readonly ILivroService _livroService = new LivroService();

        [Fact]
        public async Task CalculaFrete_RetornaCustoFrete()
        {
            double freteEsperado = 2.0;
            double freteGerado = await _livroService.CalculaFrete(1);
            Assert.Equal(freteEsperado, freteGerado);
        }

        [Fact]
        public async Task BuscaLivros_RetornaResultadosFiltrados()
        {
            var result = await _livroService.BuscaLivros("Journey to the Center of the Earth", "asc");
            Assert.NotEmpty(result);
            Assert.Contains(result, b => b.Name.Contains("Journey to the Center of the Earth"));
        }

    }
}
