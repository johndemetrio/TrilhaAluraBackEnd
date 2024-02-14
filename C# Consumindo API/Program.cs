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
    LinqFilter.FiltrarMusicasEmCSharp(musicas);
    //LinqFilter.FiltrarTodosOsGenerosMusicais(musicas);    
    //LinqOrder.ExibirListaDeArtistasOrdenados(musicas);
    //LinqFilter.FiltrarArtistasPorGeneroMusical(musicas, "R&B");
    //LinqFilter.FiltrarMusicasPorArtistas(musicas, "The Weeknd");
    //musicas[1].ExibirDetalhesDaMusica();
    //var musicasPreferidas = new MusicasPreferidas("John");
    //musicasPreferidas.AdicionarMusicaFavoritas(musicas[3]);
    //musicasPreferidas.AdicionarMusicaFavoritas(musicas[10]);
    //musicasPreferidas.AdicionarMusicaFavoritas(musicas[25]);
    //musicasPreferidas.AdicionarMusicaFavoritas(musicas[489]);
    //musicasPreferidas.AdicionarMusicaFavoritas(musicas[777]);
    //musicasPreferidas.ExibirMusicasFavoritas();
    //musicasPreferidas.GerarArquivoJson();
    
    }catch(Exception ex){
        System.Console.WriteLine($"Ocorreu um erro {ex.Message}");
    }
}
