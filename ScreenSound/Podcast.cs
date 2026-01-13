using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScreenSound
{
    public class Podcast
    {
        public Podcast(string host, string nome)
        {
            Host = host;
            Nome = nome;
        }

        private List<Episodio> episodios = new();
        public string Host { get; set; }
        public string Nome { get; set; }
        public int TotalEpisodios => episodios.Count;

        public void AdicionarEpisodio(Episodio episodio)
        {
            episodios.Add(episodio);
        }

        public void ExibirDetalhes()
        {
            Console.WriteLine($"{Host} - {Nome}");
            foreach (Episodio episodio in episodios.OrderByDescending(x => x.Ordem))
            {
                Console.WriteLine($"{episodio.Resumo}");
            }
            Console.WriteLine(TotalEpisodios);
        }


    }
}
