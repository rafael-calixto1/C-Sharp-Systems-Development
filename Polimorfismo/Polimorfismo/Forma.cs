using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfismo
{
    public class Forma
    {
        public string Cor { get; set; }

        public Forma(string cor)
        {
            Cor = cor;
        }

        //Sobrescrever metodo na heranca
        //usar a palavra reservada 'virtual'

        public virtual double Area()
        {
            return 0;
        }
         
        public virtual double Perimetro()
        {
            return 0;
        }
    }
}
