using System.Text.Json.Serialization;

namespace C__Consumindo_API.Modelos
{
    public class Musica
    {
        private string[] tonalidades = { "C", "C#", "D", "Eb", "E", "F", "F#", "G",
        "Ab", "A", "Bb","B"};

        [JsonPropertyName("song")]
        public string? Nome { get; set; }
        [JsonPropertyName("artist")]
        public string? Artista { get; set; }
        [JsonPropertyName("duration_ms")]
        public int Duracao { get; set; }
        [JsonPropertyName("genre")]
        public string? Genero { get; set; }
        [JsonPropertyName ("key")]
        public int Key { get; set; }
        
        public string Tonalidade {
            get
            {
                return tonalidades[Key];
            }
        }
        public void ExibirDetalhesDaMusica(){
        System.Console.WriteLine($"Artista: {Artista}");
        System.Console.WriteLine($"Música: {Nome}");
        System.Console.WriteLine($"Duração: {Duracao / 1000 }");
        System.Console.WriteLine($"Genero: {Genero}");
        System.Console.WriteLine($"Tonalidade: {Tonalidade}");
        }
    }
}