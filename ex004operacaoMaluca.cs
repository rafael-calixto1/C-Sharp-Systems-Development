//(a*a)*5-C/(b-a%4)
using System;
using System.Collection.Generic;
using System.Ling;
using System.Threading.Tasks;

namespace HelloWorld
{
    class program  //inicio
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Manipulando A^2x5-C/(B-A%4)");
            Console.WriteLine("Digite o valor de A: ");
            float a = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o valor de B: ");
            float b = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o valor de C: ");
            float c = int.Parse(Console.ReadLine());

            float resultado = (a*a)*5-C/(b-a%4);

            Console.WriteLine("O resultado obtido com os valores inseridos é: ");
            Console.WriteLine(resultado);

            Console.ReadLine;
        }
    }   
}