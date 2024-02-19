using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Desafio_2.Modelos
{
    public class Corrida
    {
        [JsonPropertyName("season")]
        public string? Temporada {get;set;}
        [JsonPropertyName("round")]
        public string? Rodada{get; set;}
        [JsonPropertyName("raceName")]
        public string? NomeDoCircuito{get;set;}

    }
}