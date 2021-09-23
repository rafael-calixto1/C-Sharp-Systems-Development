using System;
using System.Collection.Generic;
using System.Ling;
using System.Threading.Tasks;

namespace currency
{
    class program
    {

        static void Main(string[] args)
        {
            PConsole.Write("Digite o valor em reais");
            float real = float.Parse((Console.ReadLine());
            Console.Write("Qual o valor de um dóllar em reais");
            float dollar = float.Parse(Console.ReadLine());

            float resultado = (real / dollar);
            Console.WriteLine("O valor é: U$" + resultado);
            Console.ReadLine;
        }   
    }
}