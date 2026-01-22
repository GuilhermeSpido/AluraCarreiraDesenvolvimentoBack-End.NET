using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScreenSound
{
    public class Banco
    {
        public string Nome { get; set; }
        private List<Conta> contas = new();

        public void AdicionarContas(Conta conta) => contas.Add(conta);
        public void MostrarContasBanco()
        {
            Console.WriteLine(Nome);
            foreach (Conta conta in contas)
            {
                Console.WriteLine(conta.MostrarDetalhe);
            }
        }


    }
}
