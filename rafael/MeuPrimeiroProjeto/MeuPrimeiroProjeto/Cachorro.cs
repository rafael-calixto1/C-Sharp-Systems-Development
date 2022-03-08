using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeuPrimeiroProjeto
{
    class Cachorro
    {
        public string nome;
        public int idade;
        public EnumPorte porte;
        public double peso;
        public char sexo;

        public void Latir()
        {

            Console.WriteLine($"AU AU");
        }
    }
}
