class Musica
{
    public string Nome {get ; set;}
    public string Artista {get ; set;}
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