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
    }
}