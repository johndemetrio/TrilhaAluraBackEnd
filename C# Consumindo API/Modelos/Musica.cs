using System.Text.Json.Serialization;

namespace C__Consumindo_API.Modelos
{
    public class Musica
    {
        [JsonPropertyName("song")]
        public string? Nome { get; set; }
        [JsonPropertyName("artist")]
        public string? Artista { get; set; }
        [JsonPropertyName("duration_ms")]
        public int Duracao { get; set; }
        [JsonPropertyName("genre")]
        public string? Genero { get; set; }
        private List<Musica> musicas = new List<Musica>();
        private List<Musica> Generos = new List<Musica>();
        

        public void ExibirDetalhesDaMusica(){
        System.Console.WriteLine($"Artista: {Artista}");
        System.Console.WriteLine($"Música: {Nome}");
        System.Console.WriteLine($"Duração: {Duracao / 1000 }");
        System.Console.WriteLine($"Genero: {Genero}");
        }
    }
}