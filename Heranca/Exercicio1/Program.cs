using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Crie uma classe chamada Forma;
            //Atributos
            //Enum Cor {Amarelo, Azul, Vermelho}
            //Enum Tipo {Quadrado, Retangulo}
            //Crie uma classe chamada Quadrado (Forma)
            //Atributos:
            //double Lado;
            //Crie uma classe chamada Retangulo(Forma)
            //Atributos:
            //double Altura;
            //double Base;


            Quadrado quad = new Quadrado();
            quad.Cor = EnumCor.Azul;
            quad.Tipo = EnumTipo.Quadrado;
        }
    }
}
