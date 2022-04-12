using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstracao
{
    public class AbRetengulo: AbForma //impossivel de criar sem o metodo Perimetro  
    {
        public double Altura { get; set; }
        public double Largura { get; set; }


        public override double Area()
        {
            return Altura * Largura;
        }


        public override double Perimetro()
        {
            return Altura *2 + Largura*2;
        }
       

    }
}
