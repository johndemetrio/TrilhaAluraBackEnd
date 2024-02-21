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
        [JsonPropertyName("Driver")]
        public Piloto? Piloto { get; set; }

        public void ExibirClassificacao()
        {
            System.Console.WriteLine("");
            System.Console.WriteLine($"Posição no campeonato: {Posicao}º");
            System.Console.WriteLine($"Pontos: {Pontos}");
            System.Console.WriteLine($"Vitórias: {Vitorias}");
            System.Console.WriteLine($"Nome: {Piloto!.GivenName} {Piloto.FamilyName}");
            System.Console.WriteLine($"Nacionalidade: {Piloto.Nationality}");
            System.Console.WriteLine("");
        }
    }
}