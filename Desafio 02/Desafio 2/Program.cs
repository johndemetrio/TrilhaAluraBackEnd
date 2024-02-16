using System.Text.Json;
using System.Text.Json.Nodes;
using Desafio_2.Modelos;

using (HttpClient client = new HttpClient())
{
    try
    {
        //Menu();
        string response = await client.GetStringAsync($"https://ergast.com/api/f1/drivers.json");
        //System.Console.WriteLine(response);
        JsonObject data = new JsonObject();
        data = JsonSerializer.Deserialize<JsonObject>(response)!;
        data.MRData.DriverTable.Drivers[0].ShowDriverInformation();
    }
    catch (System.Exception)
    {
        throw;
    }
}

void Menu()
{
    ///Console.Clear();
    System.Console.WriteLine("1 -> Lista de Temporadas");
    System.Console.WriteLine("2 -> Calendário de corridas");
    System.Console.WriteLine("3 -> Temporada atual");
    System.Console.WriteLine("4 -> Pilotos");
    System.Console.WriteLine("5 -> Equipes");
    System.Console.Write("Digite a opção ");
    string opcao = Console.ReadLine()!;
    switch (opcao)
    {
        case "1":
            
            break;
        default:
            System.Console.WriteLine("Opçao incorreta. Digite novamente");
            Menu();
            break;
    }
}
