using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Construtores
{
    class Program
    {
        static void Main(string[] args)
        {
            //Construtores

            List<Pessoa> pessoas = new List<Pessoa>();

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine($">>>>Dados da {i+1} pessoa<<<<");



                //Pessoa pessoa = new Pessoa();//pesssoa no singular é um objeto, ´pessoas é a lista

                // só é possivel rodar desta forma graças ao contructor
                Console.WriteLine("Digite o seu nome");
                string nome = Console.ReadLine();
                Console.WriteLine("Digite a sua idade");
                int idade= int.Parse(Console.ReadLine());
                pessoas.Add(new Pessoa(nome, idade));

                foreach (Pessoa item in pessoas)
                {
                    Console.WriteLine(item.ToString());
                }

                //Encapsulamento
            }
        }
    }
}
