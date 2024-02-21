using System.Globalization;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Desafio_2.Modelos
{
    public interface ITemporada
    {
        void ExibirInformacoesDaTemporada();
    }
    public class Temporada : ITemporada
    {
        [JsonPropertyName("season")]
        public string? AnoDaTemporada {get;set;}

        [JsonPropertyName("url")]
        public Uri? Url { get;set;}
        public void ExibirInformacoesDaTemporada(){
            System.Console.WriteLine($"Ano: {AnoDaTemporada}");
            System.Console.WriteLine($"Wikipedia: {Url}");
        }
    }
}