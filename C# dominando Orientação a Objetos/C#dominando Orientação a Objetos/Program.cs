using dominandoOrientaçãoaObjetos.OutrosExemplos;
//using ScreenSound.Models;

//Banda pops = new Banda("POPS");
//pops.AdicionarNota(10);
//pops.AdicionarNota(5);
//pops.AdicionarNota(2);

//Banda sed = new("sed");

//Dictionary<string, Banda> bandasRegistradas = new();
//bandasRegistradas.Add(pops.Nome, pops);
//bandasRegistradas.Add(sed.Nome, sed);

//void ExibirLogo()
//{
//    Console.WriteLine(@"

//░██████╗░█████╗░██████╗░███████╗███████╗███╗░░██╗  ░██████╗░█████╗░██╗░░░██╗███╗░░██╗██████╗░
//██╔════╝██╔══██╗██╔══██╗██╔════╝██╔════╝████╗░██║  ██╔════╝██╔══██╗██║░░░██║████╗░██║██╔══██╗
//╚█████╗░██║░░╚═╝██████╔╝█████╗░░█████╗░░██╔██╗██║  ╚█████╗░██║░░██║██║░░░██║██╔██╗██║██║░░██║
//░╚═══██╗██║░░██╗██╔══██╗██╔══╝░░██╔══╝░░██║╚████║  ░╚═══██╗██║░░██║██║░░░██║██║╚████║██║░░██║
//██████╔╝╚█████╔╝██║░░██║███████╗███████╗██║░╚███║  ██████╔╝╚█████╔╝╚██████╔╝██║░╚███║██████╔╝
//╚═════╝░░╚════╝░╚═╝░░╚═╝╚══════╝╚══════╝╚═╝░░╚══╝  ╚═════╝░░╚════╝░░╚═════╝░╚═╝░░╚══╝╚═════╝░
//");
//    Console.WriteLine("Boas vindas ao Screen Sound 2.0!");
//}

//void ExibirOpcoesDoMenu()
//{
//    ExibirLogo();
//    Console.WriteLine("\nDigite 1 para registrar uma banda");
//    Console.WriteLine("Digite 2 para registrar o álbum de uma banda");
//    Console.WriteLine("Digite 3 para mostrar todas as bandas");
//    Console.WriteLine("Digite 4 para avaliar uma banda");
//    Console.WriteLine("Digite 5 para exibir os detalhes de uma banda");
//    Console.WriteLine("Digite -1 para sair");

//    Console.Write("\nDigite a sua opção: ");
//    string opcaoEscolhida = Console.ReadLine()!;
//    int opcaoEscolhidaNumerica = int.Parse(opcaoEscolhida);

//    switch (opcaoEscolhidaNumerica)
//    {
//        case 1:
//            RegistrarBanda();
//            break;
//        case 2:
//            RegistrarAlbum();
//            break;
//        case 3:
//            MostrarBandasRegistradas();
//            break;
//        case 4:
//            AvaliarUmaBanda();
//            break;
//        case 5:
//            ExibirDetalhes();
//            break;
//        case -1:
//            Console.WriteLine("Tchau tchau :)");
//            break;
//        default:
//            Console.WriteLine("Opção inválida");
//            break;
//    }
//}

//void RegistrarAlbum()
//{
//    Console.Clear();
//    ExibirTituloDaOpcao("Registro de álbuns");
//    Console.Write("Digite a banda cujo álbum deseja registrar: ");
//    string nomeDaBanda = Console.ReadLine()!;
//    if (bandasRegistradas.ContainsKey(nomeDaBanda))
//    {
//        Console.Write("Agora digite o título do álbum: ");
//        string tituloAlbum = Console.ReadLine()!;
//        Banda banda = bandasRegistradas[nomeDaBanda];
//        banda.AdicionarAlbum(new Album(tituloAlbum));
//        /**
//         * ESPAÇO RESERVADO PARA COMPLETAR A FUNÇÃO
//         */
//        Console.WriteLine($"O álbum {tituloAlbum} de {nomeDaBanda} foi registrado com sucesso!");
//        Thread.Sleep(4000);
//        Console.Clear();
//    }
//    else
//    {
//        Console.WriteLine($"\nA banda {nomeDaBanda} não foi encontrada!");
//        Console.WriteLine("Digite uma tecla para voltar ao menu principal");
//        Console.ReadKey();
//        Console.Clear();
//    }
//    ExibirOpcoesDoMenu();
//}

//void RegistrarBanda()
//{
//    Console.Clear();
//    ExibirTituloDaOpcao("Registro das bandas");
//    Console.Write("Digite o nome da banda que deseja registrar: ");
//    string nomeDaBanda = Console.ReadLine()!;
//    Banda banda = new(nomeDaBanda);
//    bandasRegistradas.Add(nomeDaBanda, banda);
//    Console.WriteLine($"A banda {nomeDaBanda} foi registrada com sucesso!");
//    Thread.Sleep(4000);
//    Console.Clear();
//    ExibirOpcoesDoMenu();
//}

//void MostrarBandasRegistradas()
//{
//    Console.Clear();
//    ExibirTituloDaOpcao("Exibindo todas as bandas registradas na nossa aplicação");

//    foreach (string banda in bandasRegistradas.Keys)
//    {
//        Console.WriteLine($"Banda: {banda}");
//    }

//    Console.WriteLine("\nDigite uma tecla para voltar ao menu principal");
//    Console.ReadKey();
//    Console.Clear();
//    ExibirOpcoesDoMenu();

//}

//void ExibirTituloDaOpcao(string titulo)
//{
//    int quantidadeDeLetras = titulo.Length;
//    string asteriscos = string.Empty.PadLeft(quantidadeDeLetras, '*');
//    Console.WriteLine(asteriscos);
//    Console.WriteLine(titulo);
//    Console.WriteLine(asteriscos + "\n");
//}

//void AvaliarUmaBanda()
//{
//    Console.Clear();
//    ExibirTituloDaOpcao("Avaliar banda");
//    Console.Write("Digite o nome da banda que deseja avaliar: ");
//    string nomeDaBanda = Console.ReadLine()!;
//    if (bandasRegistradas.ContainsKey(nomeDaBanda))
//    {
//        Banda banda = bandasRegistradas[nomeDaBanda];
//        Console.Write($"Qual a nota que a banda {nomeDaBanda} merece: ");
//        int nota = int.Parse(Console.ReadLine()!);
//        banda.AdicionarNota(nota);
//        Console.WriteLine($"\nA nota {nota} foi registrada com sucesso para a banda {nomeDaBanda}");
//        Thread.Sleep(2000);
//        Console.Clear();
//        ExibirOpcoesDoMenu();
//    }
//    else
//    {
//        Console.WriteLine($"\nA banda {nomeDaBanda} não foi encontrada!");
//        Console.WriteLine("Digite uma tecla para voltar ao menu principal");
//        Console.ReadKey();
//        Console.Clear();
//        ExibirOpcoesDoMenu();
//    }

//}

//void ExibirDetalhes()
//{
//    Console.Clear();
//    ExibirTituloDaOpcao("Exibir detalhes da banda");
//    Console.Write("Digite o nome da banda que deseja conhecer melhor: ");
//    string nomeDaBanda = Console.ReadLine()!;
//    if (bandasRegistradas.ContainsKey(nomeDaBanda))
//    {
//        Banda banda = bandasRegistradas[nomeDaBanda];
//        Console.WriteLine($"\nA média da banda {nomeDaBanda} é {banda.Media}.");
//        /**
//        * ESPAÇO RESERVADO PARA COMPLETAR A FUNÇÃO
//        */
//        Console.WriteLine("Digite uma tecla para votar ao menu principal");
//        Console.ReadKey();
//        Console.Clear();
//        ExibirOpcoesDoMenu();

//    }
//    else
//    {
//        Console.WriteLine($"\nA banda {nomeDaBanda} não foi encontrada!");
//        Console.WriteLine("Digite uma tecla para voltar ao menu principal");
//        Console.ReadKey();
//        Console.Clear();
//        ExibirOpcoesDoMenu();
//    }
//}

//ExibirOpcoesDoMenu();



//Criar um programa Program.cs, instanciar seus 5 filmes favoritos, guardá-los em uma lista e mostrar as suas informações no console.

//Criar uma classe Artista, que representa uma pessoa que atua em filmes, no namespace Alura.Filmes.A classe deve conter atributos como o nome, idade e uma lista de filmes onde o artista atuou.

//Modificar as classes Artista e Filme do namespace Alura.Filmes para que elas sejam consistentes uma com a outra, ou seja, sempre que for adicionado um artista a um filme, terá de ser adicionado também o filme à lista de filmes do artista.

Filme legal = new("legal");
Filme filme2 = new("filme2");
Filme filme3 = new("filme3");
Filme filme4 = new("filme4");
Filme filme5 = new("filme5");

Ator ator = new("Guilherme");
Ator ator2 = new("Gui2");
legal.Duracao = 5;
legal.AdicionarAtor(ator);
legal.AdicionarAtor(ator2);

List<Filme> filmes = new();
filmes.Add(legal);
filmes.Add(filme2);
filmes.Add(filme3);
filmes.Add(filme4);
filmes.Add(filme5);

foreach(Filme filme in filmes)
{
    Console.WriteLine(filme.Descricao);
}



