using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfismo
{
    public class Quadrado: Forma
    {
        public double Lado { get; set; }

        public Quadrado(double lado, string cor) : base(cor)  //referencia a base
        {
            Lado = lado;
        }

        public override double Area()
        {
            return Lado * Lado;
        }
        public override double Perimetro()
        {
            return Lado*4;
        }
    }
}
