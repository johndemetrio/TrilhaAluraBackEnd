using System.Text.Json;

namespace Desafio_2.Modelos
{
    public class Servicos
    {
        public readonly Excecoes excecoes;
        public Servicos(Excecoes excecoes)
        {
            this.excecoes = excecoes;
        }
        public async Task<ObjetoJson> GetData(string url)
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
            System.Console.Write("Digite a opção desejada: ");
            try
            {
                int opcao = int.Parse(Console.ReadLine()!);
                System.Console.WriteLine("");
                switch(opcao)
                {
                    case 1:
                        System.Console.Write("Digite o ano da temporada: ");
                        string AnoDaTemporada = Console.ReadLine()!;
                        data = GetData($"https://ergast.com/api/f1/{AnoDaTemporada}/driverStandings.json").Result;
                        foreach(var corrida in data.MRData!.StandingsTable!.StandingsLists![0].ClassificacaoPilotos!)
                        {
                            corrida.ExibirClassificacao();
                        }
                    break;

                    case 2:
                        data = GetData($"https://ergast.com/api/f1/seasons.json?limit=75").Result;
                        foreach(var temporada in data.MRData!.SeasonTable!.Temporadas!)
                        {
                            temporada.ExibirInformacoesDaTemporada();
                            System.Console.WriteLine("");
                        }
                    break;
                }
            } catch(Exception ex)
            {
                excecoes.TratamentoExcecoes(ex);
            }
            return data;
        }
        public async Task<ObjetoJson> ExibirCalendario()
        {
            ObjetoJson data = new ObjetoJson();
            System.Console.WriteLine("1 - Exibir calendário da temporada atual | 2 - Exibir calendário de uma temporada específica");
            System.Console.Write("Digite a opção desejada: ");
            try
            {
                int opcao = int.Parse(Console.ReadLine()!);
                System.Console.WriteLine("");
                switch (opcao)
                {
                    case 1:
                        System.Console.WriteLine("==== Calendário atual ====");
                        data = GetData($"https://ergast.com/api/f1/2024.json").Result;
                        foreach(var corrida in data.MRData!.RaceTable!.Corridas!)
                        {
                            corrida.ExibirInformacoesDaCorrida();
                            System.Console.WriteLine("");
                        }
                    break;

                    case 2:
                        System.Console.Write("Digite o ano da temporada para mostrar o calendário: ");
                        string AnoDaTemporada = Console.ReadLine()!;
                        data = GetData($"https://ergast.com/api/f1/{AnoDaTemporada}.json").Result;
                        foreach(var corrida in data.MRData!.RaceTable!.Corridas!)
                        {
                            corrida.ExibirInformacoesDaCorrida();
                            System.Console.WriteLine("");
                        }
                    break;

                    default:
                        System.Console.WriteLine("Opção inválida. Tente novamente.");
                    break;
                }
            } catch(Exception ex)
            {
                excecoes.TratamentoExcecoes(ex);
            }
            return data;
        }
        public async Task<ObjetoJson> ExibirPilotos()
        {
            ObjetoJson data = new ObjetoJson();
            System.Console.WriteLine("1 -> Exibir todos os pilotos (852 Pilotos)");
            System.Console.WriteLine("2 -> Exibir todos os pilotos que já foram campeões");
            System.Console.WriteLine("3 -> Exibir pilotos por temporada");
            System.Console.Write("Digite a opção desejada: ");
            try{
                int opcao = int.Parse(Console.ReadLine()!);
                System.Console.WriteLine("");
                switch (opcao)
                {
                    case 1:
                        data = GetData("https://ergast.com/api/f1/drivers.json?limit=858").Result;
                        foreach (var piloto in data.MRData!.DriverTable!.Pilotos!)
                        {
                            piloto.ExibirInformacoesDoPiloto();
                            System.Console.WriteLine("");
                        }
                    break;

                    case 2:
                        data = GetData("https://ergast.com/api/f1/driverStandings/1/drivers.json?limit=34").Result;
                        foreach (var piloto in data.MRData!.DriverTable!.Pilotos!)
                        {
                            piloto.ExibirInformacoesDoPiloto();
                            System.Console.WriteLine("");
                        }
                    break;

                    case 3:
                        System.Console.Write("Digite o ano da temporada: ");
                        string AnoDaTemporada = Console.ReadLine()!;
                        data = GetData($"https://ergast.com/api/f1/{AnoDaTemporada}/drivers.json").Result;
                        foreach(var piloto in data.MRData!.DriverTable!.Pilotos!)
                        {
                            piloto.ExibirInformacoesDoPiloto();
                            System.Console.WriteLine("");
                        }
                    break;

                    default:
                        System.Console.WriteLine("Opção Inválida. Tente novamente");
                    break;
                }
            } catch(Exception ex)
            {
                excecoes.TratamentoExcecoes(ex);
            }
            return data;
        }
        public async Task<ObjetoJson> ExibirConstrutores()
        {
            ObjetoJson data = new ObjetoJson();
            System.Console.WriteLine("1 -> Exibir todas as equipes");
            System.Console.WriteLine("2 -> Exibir todas as equipes que já foram campeãs");
            System.Console.WriteLine("3 -> Exibir equipes por temporada específica");
            System.Console.Write("Digite a opção desejada: ");
            try
            {
                int opcao = int.Parse(Console.ReadLine()!);
                System.Console.WriteLine("");
                switch (opcao)
                {
                    case 1:
                        data = GetData("https://ergast.com/api/f1/constructors.json?limit=211").Result;
                        foreach (var construtor in data.MRData!.ConstructorTable!.Constructors!)
                        {
                            construtor.ExibirConstrutor();
                            System.Console.WriteLine("");
                        }
                    break;
                    
                    case 2:
                        data = GetData("https://ergast.com/api/f1/constructorStandings/1/constructors.json").Result;
                        foreach (var construtor in data.MRData!.ConstructorTable!.Constructors!)
                        {
                            construtor.ExibirConstrutor();
                            System.Console.WriteLine("");
                        }
                    break;

                    case 3:
                        System.Console.Write("Digite o ano da temporada: ");
                        string AnoDaTemporada = Console.ReadLine()!;
                        data = GetData($"https://ergast.com/api/f1/{AnoDaTemporada}/constructors.json").Result;
                        foreach(var construtor in data.MRData!.ConstructorTable!.Constructors!)
                        {
                            construtor.ExibirConstrutor();
                            System.Console.WriteLine("");
                        }
                    break;
                    
                    default:
                        System.Console.WriteLine("Opção Inválida. Tente novamente");
                    break;
                }
            }
            catch (Exception ex)
            {
                excecoes.TratamentoExcecoes(ex);                
            }
            return data;
        }
    }
}