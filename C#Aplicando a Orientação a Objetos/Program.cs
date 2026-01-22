using ScreenSound;

public class Program
{
    public static void Main()
    {



        //Artista jonas = new()
        //{
        //    Nome = "spido",
        //    GeneroMusical = "Rock",
        //};


        //Musica musica1 = new Musica(jonas, "Roxane")
        //{
        //    Duracao = 199,
        //    Disponivel = true,
        //};

        //Console.WriteLine($"{musica1.DescricaoResumida}");


        //Musica musica2 = new Musica(jonas, "Vertigo")
        //{
        //    Duracao = 367,
        //    Disponivel = false,
        //};

        //Console.WriteLine($"{musica2.DescricaoResumida}");

        //Album album = new()
        //{
        //    Nome = "Album",
        //};

        //album.AdicionarMusica(musica1);

        //musica1.ExibirFichaTecnica();
        //musica2.ExibirFichaTecnica();
        //Console.WriteLine();

        ////lambda
        ////List<int> numeros = new List<int> { 1,2,3,4,5,6,7,8,9,10 };
        ////List<int> numerosPares = numeros.FindAll( n => n % 2 == 0 );

        ////foreach (int n in numerosPares)
        ////{
        ////    Console.WriteLine(n);
        ////}


        //Carro carro = new();
        //carro.Nome = "civic";
        //carro.Marca = "honda";
        //carro.AnoFabricacao = 2000;
        //Console.WriteLine($"{carro.Nome},{carro.Marca},{carro.AnoFabricacao}");
        //Console.WriteLine($"{carro.Descricao}");
        //carro.teste(carro.AnoFabricacao);

        ////Musica musica = new();
        ////var valor = musica.Somar(1, 2);
        ////Console.WriteLine(valor);


        //Album album = new Album();
        //album.Nome = "TEste";
        //album.DuracaoTotal = 30;
        //album.AdicionarMusica(musica1);
        //album.AdicionarMusica(musica2);

        //album.mostrarMusicar();

        //

        //Banco banco = new();
        //banco.Nome = "ITAU";

        //Conta conta = new(banco);
        //conta.Nome = "Guilherme";
        //conta.Cpf = "03234587047";

        //Conta conta1 = new(banco);
        //conta1.Nome = "Guilherme";
        //conta1.Cpf = "03234587047";

        //Conta conta2 = new(banco);
        //conta2.Nome = "Guilherme";
        //conta2.Cpf = "03234587047";

        //banco.AdicionarContas(conta);
        //banco.AdicionarContas(conta1);
        //banco.AdicionarContas(conta2);

        //banco.MostrarContasBanco();

        Convidado convidado = new("Gui");
        Convidado convidado1 = new("Gui1");

        Episodio ep1 = new Episodio("Titulo", 2, 10);
        ep1.AdicionarConvidado(convidado);
        ep1.AdicionarConvidado(convidado1);


        Episodio ep2 = new Episodio("Titulo2", 1, 20);


        Episodio ep3 = new Episodio("Titulo3", 5, 60);


        Episodio ep4 = new Episodio("Titulo4", 0, 20);


        Podcast podcast = new Podcast("host", "nome");
        podcast.AdicionarEpisodio(ep1);
        podcast.AdicionarEpisodio(ep2);
        podcast.AdicionarEpisodio(ep3);
        podcast.AdicionarEpisodio(ep4);
        podcast.ExibirDetalhes();


    }
}
