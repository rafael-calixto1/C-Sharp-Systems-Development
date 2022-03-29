using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio2
{
    class Tutor
    {
        public string Nome { get; set; }
        public List<Animal> MeusAnimais = new List<Animal>();

        public Tutor()
        {
        }

        public Tutor(string nome)
        {
            Nome = nome;
        }
    }
}
