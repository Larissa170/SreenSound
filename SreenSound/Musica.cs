class Musica{

    public Musica(Banda artista, string nome) //construtor
    {
        Artista = artista;
        Nome = nome;
    }


    public string Nome {  get; } // propriedade
    public Banda Artista {  get;}
    public int Duracao {  get; set; }
    public bool Disponivel { get; set; }
    public string DescricaoResumida => $"A música {Nome} é de {Artista.Nome}."; // usado para representar um get customizado (lambda)
    public Genero Genero { get; set; }


    //public void  setDisponivel(bool valor){
    //    disponivel = valor;
    //}
    //public bool getDisponivel()
    //{
    //    return disponivel;
    //}
    public void ExibirFichaTecnica()
    {
        Console.WriteLine($"Nome da música: {Nome} ");
        Console.WriteLine($"Nome do artista:{Artista}");
        Console.WriteLine($"Duração:{Duracao}");
        if (Disponivel)
        {
            Console.WriteLine("Disponivel");
        }
        else
        {
            Console.WriteLine("Não disponivel");
        }
    }


    public void ExibirNomeEArtista()
    {
        Console.WriteLine($"Música - Artista: {Nome} - {Artista}");
    }

}
