using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScreenSound
{
    internal class Carro
    {
            public string Nome { get; set; }
            public string Marca { get; set; }
            private int _anoDeFabricacao;
            public int AnoFabricacao
            {
                get => _anoDeFabricacao;
                set
                {
                    if (value >= 1960 && value <= 2026)
                        _anoDeFabricacao = value;
                    else
                        throw new Exception("ANO DE FABRICACAO INVALIDO");
                }
            }
            public string Descricao { get => $"Carro {Nome} da marca {Marca} fabricado no ano de {AnoFabricacao}"; }
            public void teste(int ano)
            {
                switch (ano)
                {
                    case 1:
                        Console.WriteLine("teste");
                        break;
                    case 2:
                        Console.WriteLine("teste2");
                        break;
                    default:
                        Console.WriteLine("invalido");
                        break;
                }

            }
    }
}
