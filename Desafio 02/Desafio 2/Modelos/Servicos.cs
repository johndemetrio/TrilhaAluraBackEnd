using System.Text.Json;

public class Servicos
{
    public static async Task dataAsync()
    {
        ObjetoJson data = new ObjetoJson();
        using (HttpClient client = new HttpClient())
        {
            //string parametro = Console.ReadLine();
            string response = await client.GetStringAsync($"https://ergast.com/api/f1/seasons.json?limit=75");
            //System.Console.WriteLine(response);
            data = JsonSerializer.Deserialize<ObjetoJson>(response)!;
            data.MRData.SeasonTable.Temporadas[0].MostrarTemporada();
        }
    }
}