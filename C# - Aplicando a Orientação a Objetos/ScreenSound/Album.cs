class Album
{
    public Album(string nome)
    {
        Nome = nome;
    }

    private List<Musica> musicas = new List<Musica>();
    public string Nome { get;}
    public int DuracaoTotal => musicas.Sum(musicas => musicas.Duracao);

    public void AdicionarMusica(Musica musica){
        musicas.Add(musica);
    }

    public void ExibirMusicaDoAlbum(){
        System.Console.WriteLine($"Lista de músicas do álbum -> {Nome}: ");
        foreach (var musica in musicas)
        {
            System.Console.WriteLine(musica.Nome);
        }
    }
}