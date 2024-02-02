Album album = new Album();
album.Nome = "Camisa 10 joga bola até na chuva";
Musica musica1 = new Musica();
musica1.Nome = "Só os loucos sabem";

Banda banda = new Banda();
album.AdicionarMusica(musica1);
album.ExibirMusicaDoAlbum();

Banda queen = new Banda();
queen.Nome = "Queen";
queen.AdicionarAlbum(album);
queen.ExibirDiscografia();