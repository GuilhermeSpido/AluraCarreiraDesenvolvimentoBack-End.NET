using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScreenSound
{
    public class Episodio
    {
        public Episodio(string titulo, int ordem, int duracao)
        {
            this.Titulo = titulo;
            this.Ordem = ordem;
            this.Duracao = duracao;
        }

        public List<Convidado> convidados = new();
        public int Duracao { get; }
        public int Ordem { get; }
        public string Resumo => $"TITULO {Titulo} - ORDEM {Ordem} - DURACAO {Duracao} - {string.Join(", ", convidados)}";
        public string Titulo { get; }

        public void AdicionarConvidado(Convidado convidado)
        {
            convidados.Add(convidado);
        }
    }
}
