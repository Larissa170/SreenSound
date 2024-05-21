class Episodio
{
    public Episodio(int ordem, string titulo, int duracao)
    {
        Ordem = ordem;
        Titulo = titulo;
        Duracao = duracao;
    }

    List<string> convidados = new();
    public int Duracao { get; }
    public int Ordem { get;}
    public string Resumo => $"{Ordem}. {Titulo} ({Duracao} min) - {string.Join(", ",convidados)}";// join junta a string com o argumeto passado
    public string Titulo { get;}


    public void AdicionarConvidados(string convidado)
    {
        convidados.Add(convidado);
    }
}