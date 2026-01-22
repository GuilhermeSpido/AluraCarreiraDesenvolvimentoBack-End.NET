using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScreenSound
{
    public class Banda
    {
        public Banda(string _nome)
        {
            this.Nome = _nome;
        }
        private List<Album> albuns = new();
        public string Nome { get; }
        
        public void AdicionarAlbum(Album album)
        {
            albuns.Add(album);
        }

        public string ExibirDiscografia => $"Banda {Nome}";
    }
}
