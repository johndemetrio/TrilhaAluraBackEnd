using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Desafio_2.Modelos
{
    public class Corrida
    {
        [JsonPropertyName("season")]
        public string? AnoDaTemporada {get;set;}
        [JsonPropertyName("round")]
        public string? Rodada{get; set;}
        [JsonPropertyName("raceName")]
        public string? NomeDaCorrida{get;set;}
        [JsonPropertyName("date")]
        public string? Data{get;set;}
        public void ExibirInformacoesDaCorrida()
        {
            System.Console.WriteLine($"Temporada: {AnoDaTemporada}");
            System.Console.WriteLine($"Rodada: {Rodada}");
            System.Console.WriteLine($"Nome da corrida: {NomeDaCorrida}");
            System.Console.WriteLine($"Data: {Data}");
        }
    }
}