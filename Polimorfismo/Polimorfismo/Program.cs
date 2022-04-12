using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfismo
{
    class Program
    {
        static void Main(string[] args)
        {
            Quadrado quad = new Quadrado(5, "Azul");
            Retangulo ret = new Retangulo(2, 3, "Verde");


            Console.WriteLine(quad.Area());
            Console.WriteLine(ret.Area());
            Console.WriteLine(quad.Perimetro());
            Console.WriteLine(ret.Perimetro());
        }
    }
}
