using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Criar uma classe que representa um filme, com dados como seu titulo, duração e elenco. Após isso, colocá-la no namespace Alura.Filmes.

namespace dominandoOrientaçãoaObjetos.OutrosExemplos;

public class Filme
{
    public Filme(string titulo)
    {
        this.Titulo = titulo;
    }
    public string Titulo { get; set; }
    public int Duracao { get; set; }
    private List<Ator> Elenco { get; set; } = new List<Ator>();
    public string Descricao => $"{Titulo} - {Duracao} - {PegarNomeElenco()} ";

    public void AdicionarAtor(Ator ator)
    {
        Elenco.Add(ator);
    }
    public string PegarNomeElenco()
    {
        if (!Elenco.Any()) return "Niguem no elenco";
        return string.Join(",",Elenco.Select(x => x.Nome));
    }

}


