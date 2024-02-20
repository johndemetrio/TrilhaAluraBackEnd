using System.Text.Json.Serialization;

namespace Desafio_2.Modelos
{
    public class ClassificacaoPiloto
    {
        [JsonPropertyName("position")]
        public string? Posicao { get; set; }
        [JsonPropertyName("points")]
        public string? Pontos { get; set; }
        [JsonPropertyName("wins")]
        public string? Vitorias{ get; set; }
        [JsonPropertyName("Drivers")]
        public Piloto Piloto { get; set; }

        public void ExibirClassificacao()
        {
            System.Console.WriteLine($"Posição: {Posicao}");
            System.Console.WriteLine($"Pontos: {Pontos}");
            System.Console.WriteLine($"Vitórias: {Vitorias}");
            System.Console.WriteLine("");
        }
    }
}