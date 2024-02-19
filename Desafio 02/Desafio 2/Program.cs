using System.Text.Json;

ObjetoJson data = new ObjetoJson();
using (HttpClient client = new HttpClient())
{
    //string parametro = Console.ReadLine();
    string response = await client.GetStringAsync($"https://ergast.com/api/f1/seasons.json?limit=75");
    data = JsonSerializer.Deserialize<ObjetoJson>(response)!;
}
Menu();
void Menu()
{
    ///Console.Clear();
    System.Console.WriteLine("1 -> Lista de Temporadas");
    System.Console.WriteLine("2 -> Calendário de corridas");
    System.Console.WriteLine("3 -> Temporada atual");
    System.Console.WriteLine("4 -> Pilotos");
    System.Console.WriteLine("5 -> Equipes");
    System.Console.WriteLine("6 -> Sair da aplicação");
    System.Console.Write("Digite a opção desejada: ");
    string opcao = Console.ReadLine()!;
    switch (opcao)
    {
        case "1":
            for (int i = 0; i < 75; i++)
            {
                data.MRData.SeasonTable.Temporadas[i].MostrarTemporada();
            }
            break;
        case "2":
            
            break;
        case "3":
            
            break;
        case "4":
            
            break;
        case "5":
            
            break;
        case "6":
            Console.Clear();
            System.Console.WriteLine("Pressione qualquer tecla para sair da aplicação");
            Console.ReadKey();
            break;
        default:
            System.Console.WriteLine("Opçao incorreta. Digite novamente");
            break;
    }
}