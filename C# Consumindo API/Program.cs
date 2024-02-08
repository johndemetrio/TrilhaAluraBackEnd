using System.Linq;
using System.Text.Json;
using C__Consumindo_API.Filtros;
using C__Consumindo_API.Modelos;

using (HttpClient client = new HttpClient())
{
    try
    {
    string resposta = await client.GetStringAsync($"https://guilhermeonrails.github.io/api-csharp-songs/songs.json");
    var musicas = JsonSerializer.Deserialize<List <Musica>>(resposta)!;
    LinqFilter.FiltrarTodosOsGenerosMusicais(musicas);    
    }catch(Exception ex){
        System.Console.WriteLine($"Ocorreu um erro {ex.Message}");
    }
}
