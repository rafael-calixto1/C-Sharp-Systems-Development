using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfismo
{
    public class Retangulo : Forma
    {
        //double altura, largura e construtor chamando cconstrutor da base

        public double Altura { get; set; } //atributos com seus metodos especiais
        public double Largura { get; set; }

        public Retangulo(double altura, double largura, string cor) : base(cor)
        {
            Altura = altura;
            Largura = largura;
        }
        public override double Area()
        {
            return Largura * Altura;
        }

        public override double Perimetro()
        {
            return Largura*2 + Altura*2;
        }
    }
}
