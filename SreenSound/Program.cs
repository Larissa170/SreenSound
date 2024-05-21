//Musica musica1 = new Musica();
//musica1.Nome = "lala";
//musica1.Artista = "lalala";
//musica1.Duracao = 256;
//musica1.Disponivel = true;

//musica1.ExibirFichaTecnica();
//Console.WriteLine(musica1.DescricaoResumida);


Banda banda = new Banda("testeBanda");
Album album = new Album("testeAlbum");

Musica musica = new Musica(banda, "teste de musica")
{
    Duracao = 213,
    Disponivel = true,
};// outra maneira de atribuir valores

Musica musica2 = new Musica(banda, "teste de musica");
musica2.Duracao = 254;
musica2.Disponivel = false;

album.AdicionarMusica(musica);
album.AdicionarMusica(musica2);
banda.AdicionarAlbum(album);

musica.ExibirFichaTecnica();
musica2.ExibirFichaTecnica();
album.ExibirMusicas();
banda.ExibirDiscografia();

