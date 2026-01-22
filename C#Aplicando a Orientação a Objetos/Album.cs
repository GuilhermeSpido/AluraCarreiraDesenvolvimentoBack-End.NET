
public class Album
{
    public string Nome { get; set; }
    public int DuracaoTotal { get; set; }
    private List<Musica> musicas = new List<Musica>();

    public void AdicionarMusica(Musica musica)
    {
        musicas.Add(musica);
    }

    public int SomarDuracao => musicas.Sum(m => m.Duracao);
    public void mostrarMusicar()
    {
        foreach(Musica musica in musicas)
        {
            Console.WriteLine($"{musica.Nome}, {musica.Artista}");
        }
        Console.WriteLine(SomarDuracao);
    }
}
