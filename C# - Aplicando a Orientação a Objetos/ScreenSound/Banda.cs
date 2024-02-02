class Banda
{
    public List<Album> albums = new List<Album>();
    public string Nome { get; set; }

    public void AdicionarAlbum(Album album){
        albums.Add(album);
    }

    public void ExibirDiscografia(){
        System.Console.WriteLine($"Discografia da banda {Nome}");
        foreach (var album in albums)
        {
            System.Console.WriteLine($"Album: {album} - ({album.DuracaoTotal})");
        }
    }
}