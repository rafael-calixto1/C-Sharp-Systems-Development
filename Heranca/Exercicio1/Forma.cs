using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio1
{
    public class Forma
    {
        public EnumCor Cor { get; set; }
        public EnumTipo Tipo { get; set; }

        public Forma(EnumCor cor, EnumCor tipo)
        {
        }

        public Forma(EnumCor cor, EnumTipo tipo)
        {

            Cor = cor;
            Tipo = tipo;
        }
    }
}
