class Musica
{
    public Musica(Banda artista, string nome)
    {
        Artista = artista;
        Nome = nome;
    }
    public string Nome {get ;}
    public Banda Artista {get;}
    public int Duracao {get ; set;}
    public bool Disponivel {get ; set;}
    public string DescricaoResumida => $"A música {Nome} pertence ao {Artista}";
    public Genero Genero { get; set;}

    public void ExibirFichaTecnica(){
        System.Console.WriteLine($"Nome: {Nome}");
        System.Console.WriteLine($"Artista: {Artista}");
        System.Console.WriteLine($"Duração: {Duracao}");
        System.Console.WriteLine(Disponivel ? $"Música disponível" : "Música indisponível");
    }
}