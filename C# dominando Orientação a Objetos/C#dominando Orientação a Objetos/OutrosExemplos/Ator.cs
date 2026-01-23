using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dominandoOrientaçãoaObjetos.OutrosExemplos;

public class Ator
{
    public Ator(string nome)
    {
        Nome = nome;
    }
    public string Nome { get; set; }
    public string Exibir => $"{Nome}";
}
