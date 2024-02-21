using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;

namespace Desafio_2.Modelos
{
    public class Filtros
    {
        public static async Task<ObjetoJson> GetDataFromUrlAsync(string url)
        {
            ObjetoJson data = new ObjetoJson();
            using (HttpClient client = new HttpClient())
            {
                string response = await client.GetStringAsync(url);
                data = JsonSerializer.Deserialize<ObjetoJson>(response)!;
            }
            return data;
        }
        public async Task<ObjetoJson> ExibirTemporadas()
        {
            ObjetoJson data = new ObjetoJson();
            System.Console.WriteLine("1 - Exibir classificação de uma temporada específica | 2 - Exibir todas as temporadas");
            System.Console.WriteLine("Digite a opção desejada");
            int opcao = int.Parse(Console.ReadLine()!);
            switch(opcao)
            {
                case 1:
                    System.Console.Write("Digite o ano da temporada:");
                    string AnoDaTemporada = Console.ReadLine()!;
                    data = GetDataFromUrlAsync($"https://ergast.com/api/f1/{AnoDaTemporada}/driverStandings.json").Result;
                    //data.MRData.StandingsTable.StandingsLists[0].ClassificacaoPilotos[0].ExibirClassificacao();
                    foreach(var corrida in data.MRData.StandingsTable.StandingsLists[0].ClassificacaoPilotos){
                        corrida.ExibirClassificacao();
                    }
                    break;
                
                case 2:
                    data = GetDataFromUrlAsync($"https://ergast.com/api/f1/seasons.json?limit=75").Result;
                    foreach(var temporada in data.MRData.SeasonTable.Temporadas)
                    {
                        temporada.MostrarTemporada();
                        System.Console.WriteLine("");
                    }
                    break;
            }
            return data;
        }
        public async Task<ObjetoJson> ExibirCalendario()
        {
            ObjetoJson data = new ObjetoJson();
            System.Console.WriteLine("Digite o ano da temporada para mostrar o calendário: ");
            string AnoDaTemporada = Console.ReadLine()!;
            using (HttpClient client = new HttpClient())
            {
                string response = await client.GetStringAsync($"https://ergast.com/api/f1/{AnoDaTemporada}.json");
                data = JsonSerializer.Deserialize<ObjetoJson>(response)!;
                foreach(var corrida in data.MRData.RaceTable.Corridas)
                {
                    corrida.ExibirInformacoesDaCorrida();
                    System.Console.WriteLine("");
                }
            }
            return data;
        }
        public async Task<ObjetoJson> ExibirCalendarioAtual()
        {
            ObjetoJson data = new ObjetoJson();
            using (HttpClient client = new HttpClient())
            {
                string response = await client.GetStringAsync($"https://ergast.com/api/f1/2024.json");
                data = JsonSerializer.Deserialize<ObjetoJson>(response)!;
                foreach(var corrida in data.MRData.RaceTable.Corridas)
                {
                    corrida.ExibirInformacoesDaCorrida();
                    System.Console.WriteLine("");
                }
            }
            return data;
        }
        public async Task<ObjetoJson> ExibirPilotos()
        {
            System.Console.WriteLine("1 -> Exibir todos os pilotos");
            System.Console.WriteLine("2 -> Exibir todos os campeões");
            System.Console.WriteLine("3 -> Exibir pilotos por temporada");
            System.Console.WriteLine("4 -> Exibir ");
            ObjetoJson data = new ObjetoJson();
            using (HttpClient client = new HttpClient())
            {
                string response = await client.GetStringAsync($"https://ergast.com/api/f1/2024.json");
                data = JsonSerializer.Deserialize<ObjetoJson>(response)!;
            }
            return data;
        }
    }
}