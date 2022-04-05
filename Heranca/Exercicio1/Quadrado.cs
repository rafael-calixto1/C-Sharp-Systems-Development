using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio1
{
    public class Quadrado : Forma
    {
        public double lado { get; set; }


        public Quadrado(double lado, EnumCor cor, EnumCor tipo) : base(cor, tipo)
        {
            this.lado = lado;
        }
    }
}
