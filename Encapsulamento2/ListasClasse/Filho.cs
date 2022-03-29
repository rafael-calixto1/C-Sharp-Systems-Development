using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListasClasse
{
    public class Filho
    {
        public string Nome { get; set; }
        public string Genero { get; set; }

        public Filho()
        {
        }

        public Filho(string nome, string genero)
        {
            Nome = nome;
            Genero = genero;
        }
    }
}
