using System.Text.Json.Serialization;

namespace ApiLivros.Models
{
    public class Livro
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }
        [JsonPropertyName("name")]
        public string Name { get; set; }
        [JsonPropertyName("price")]
        public double Price { get; set; }
        [JsonPropertyName("specifications")]
        public Dictionary<string, object> Specifications { get; set; }
    }
}
