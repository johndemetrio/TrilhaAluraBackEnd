using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;

namespace C__Consumindo_API.Modelos
{
    public class MusicasPreferidas
    {
        public string? Nome { get; set; }
        public List<Musica> ListaDeMusicasFavoritas;

        public MusicasPreferidas(string nome)
        {
            Nome = nome;
            ListaDeMusicasFavoritas = new List<Musica>();
        }
        public void AdicionarMusicaFavoritas(Musica musica)
        {
            ListaDeMusicasFavoritas.Add(musica);
        }
        public void ExibirMusicasFavoritas()
        {
            System.Console.WriteLine($"Essas são as músicas favoritas -> {Nome}");
            foreach (var musica in ListaDeMusicasFavoritas)
            {
                System.Console.WriteLine($"-> {musica.Nome} | {musica.Artista}");
            }
        }
        public void GerarArquivoJson(){
            string json = JsonSerializer.Serialize( new 
            {
                nome = Nome,
                musicas = ListaDeMusicasFavoritas
            });
            string nomeDoArquivo = $"musicas-favoritas-{Nome}.json";
            File.WriteAllText(nomeDoArquivo, json);
            System.Console.WriteLine($"O arquivo json foi criado com sucesso - {Path.GetFullPath(nomeDoArquivo)}");
        }
    }
}