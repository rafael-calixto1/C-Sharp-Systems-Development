using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstracao
{
    public class AbQuadrado : AbForma
    {
        public double Lado { get; set; }
        //Area é virtual, pode ou nãp ser sobrescrita
        public override double Area()
        {
            return Lado * Lado;
        }


        //Perimetro é abstract, DEVE sobrescrever o método
        public override double Perimetro()
        {
            return Lado * 4;
        }
    }
}
