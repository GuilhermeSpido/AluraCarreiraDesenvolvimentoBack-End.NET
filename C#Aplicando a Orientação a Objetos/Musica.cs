using ScreenSound;

public class Musica
{
    public Musica(Artista artista,string nome)
    {
        this.Artista = artista;
        this.Nome = nome;
    }

    public string Nome { get; set; }
    public Artista Artista { get; set; }
    public int Duracao { get; set; }
    public bool Disponivel { get; set; }
    public string DescricaoResumida => //lambda
        $"A musica {Nome} pertence a banda {Artista}";
    public void ExibirFichaTecnica()
    {
        Console.WriteLine($"Nome: {Nome}");
        Console.WriteLine($"Artista: {Artista}");
        Console.WriteLine($"Duração: {Duracao}");
        if (Disponivel)
        {
            Console.WriteLine("Disponível no plano.");
        }
        else
        {
            Console.WriteLine("Adquira o plano Plus+");
        }
    }
    public int Somar(int a,int b)=> a+b;

}