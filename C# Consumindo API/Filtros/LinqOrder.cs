using C__Consumindo_API.Modelos;

namespace C__Consumindo_API.Filtros
{
    public class LinqOrder
    {
        public static void ExibirListaDeArtistasOrdenados(List<Musica> musicas)
        {
            var artistasOrdenados = musicas.OrderBy(musica => musica.Artista).Select
            (musica => musica.Artista).Distinct().ToList();
            System.Console.WriteLine("Lista de artistas Ordenados:");
            foreach (var artista in artistasOrdenados)
            {
                System.Console.WriteLine($"-> {artista}");
            }
        }
    }
}