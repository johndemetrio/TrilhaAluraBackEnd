using C__Consumindo_API.Modelos;

namespace C__Consumindo_API.Filtros
{
    public class LinqFilter
    {
        public static void FiltrarTodosOsGenerosMusicais(List<Musica> musicas){
            var todosOsGenerosMusicais = musicas.Select(generos => generos.Genero).Distinct().ToList();
            foreach (var genero in todosOsGenerosMusicais)
            {
                System.Console.WriteLine($"-> {genero}");
            }
        }
        public static void FiltrarArtistasPorGeneroMusical(List<Musica> musicas, string genero)
        {
            var artistasPorGeneroMusical = musicas.Where(musica =>
            musica.Genero!.Contains(genero)).Select(musica => musica.Artista).Distinct().ToList();
            System.Console.WriteLine($"Exibindo artistas por gênero musical -> {genero}");
            foreach (var artista in artistasPorGeneroMusical)
            {
                System.Console.WriteLine($"-> {artista}");
            }
        }
        public static void FiltrarMusicasPorArtistas(List<Musica> musicas, string artista)
        {
            var musicasDoArtista = musicas.Where(musica => musica.Artista!.Equals(artista)).ToList();
            System.Console.WriteLine(artista);
            foreach (var musica in musicasDoArtista)
            {
                System.Console.WriteLine($"-> {musica.Nome}");
            }
        }
    }
}