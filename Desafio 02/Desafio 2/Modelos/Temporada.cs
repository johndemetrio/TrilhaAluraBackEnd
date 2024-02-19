using System.Globalization;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Desafio_2.Modelos
{
    public class Temporada
    {
        [JsonPropertyName("season")]
        public string? AnoDaTemporada {get;set;}

        [JsonPropertyName("url")]
        public Uri? Url { get;set;}
        public void MostrarTemporada(){
            System.Console.WriteLine($"Ano: {AnoDaTemporada}");
            System.Console.WriteLine($"Wikipedia: {Url}");
        }
    }
}