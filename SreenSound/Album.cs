class Album
{
    public Album(string nome)
    {
        Nome = nome;
    }
    private List<Musica> musicas = new List<Musica>();
    public string Nome { get;}
    public int DuracaoTotal => musicas.Sum(m => m.Duracao); // soma a duracao de todas as musicas

    public void AdicionarMusica(Musica musica)
    {
        musicas.Add(musica);
    }

    public void ExibirMusicas()
    {
        Console.WriteLine($"Listagem de musicas do album {Nome}");
        foreach (var musica in musicas)
        {
            Console.WriteLine(musica.Nome);
        }
        Console.WriteLine($"\nEste album tem {DuracaoTotal} de duracao");
    }
}