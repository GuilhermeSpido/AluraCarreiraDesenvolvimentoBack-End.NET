using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScreenSound
{
    public class Conta
    {
        public Conta(Banco _banco)
        {
            Banco = _banco;
        }
        private int _id;
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public int Id
        {
            get => _id;
            set
            {
                if (value != 0)
                    _id = value;
                else
                    _id = 99;
            }
        }
        public string MostrarDetalhe => $"{Nome} - {Cpf}";
        public Banco Banco { get; set; }

    }


}
