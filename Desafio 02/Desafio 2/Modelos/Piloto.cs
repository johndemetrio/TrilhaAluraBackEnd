using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Desafio_2.Modelos
{
    public interface IPiloto
    {
        void ExibirInformacoesDoPiloto();
    }
    public class Piloto : IPiloto
    {
        [JsonPropertyName("driverId")]
        public string? DriverId { get; set; }

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
            System.Console.WriteLine($"Nome: {GivenName} {FamilyName}");
            System.Console.WriteLine($"Nacionalidade: {Nationality}");
            System.Console.WriteLine($"Biografia no Wikipedia: {Url}");
        }
    }
}