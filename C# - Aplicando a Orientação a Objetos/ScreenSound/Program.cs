Banda queen = new Banda("Queen");

Album album = new Album("A night at the opera");
Musica musica1 = new Musica(queen, "Love of my life")
{
    Duracao = 213,
    Disponivel = true,
};

album.AdicionarMusica(musica1);
album.ExibirMusicaDoAlbum();
queen.AdicionarAlbum(album);
queen.ExibirDiscografia();