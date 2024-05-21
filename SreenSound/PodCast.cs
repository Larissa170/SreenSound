class PodCast
{
    public PodCast(string nome, string host)
    {
        Nome = nome;
        Host = host;
    }

    private List<Episodio> episodios = new();
    public string Nome { get;}
    public string Host { get;}
    public int TotalEpisodios  => episodios.Count;


    public void AdicionarEpisodio(Episodio episodio)
    {
        episodios.Add(episodio);
    }

    public void ExibirDetalhes()
    {
        Console.WriteLine($"PodCast {Nome} apresentado por {Host}");
        foreach (Episodio e in episodios.OrderBy(e => e.Ordem)) // para forcar ordernar pela ordem
        {
            Console.WriteLine(e.Resumo);
        }
        Console.WriteLine($"Contém {TotalEpisodios} episodios");
    }
}