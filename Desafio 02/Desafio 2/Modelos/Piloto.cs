using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Desafio_2.Modelos
{
    public class Piloto
    {
        [JsonPropertyName("driverId")]
        public string? DriverId { get; set; }

        [JsonPropertyName("permanentNumber")]
        public string? PermanentNumber { get; set; }

        [JsonPropertyName("code")]
        public string? Code { get; set; }

        [JsonPropertyName("url")]
        public string? Url { get; set; }

        [JsonPropertyName("givenName")]
        public string? GivenName { get; set; }

        [JsonPropertyName("familyName")]
        public string? FamilyName { get; set; }
        [JsonPropertyName("nationality")]
        public string? Nationality { get; set; }

        public void ExibirInformacoesDoPiloto()
        {
            System.Console.WriteLine($"Nome: {GivenName + FamilyName}");
            System.Console.WriteLine($"Abreviação e número do carro: {Code} | {PermanentNumber}");
            System.Console.WriteLine($"Nacionalidade: {Nationality}");
            System.Console.WriteLine($"Biografia no Wikipedia: {Url}");
        }
    }
}