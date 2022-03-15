using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cadastro
{
    class Program
    {
        static void Main(string[] args)
        {
            //Criar a classe Pessoa
            //Atributos nome, idade, sexo {Masc ou Fem}
            //Método .ToString

            //Cadastrar 3 pesspas a exibir no final


            List<Pessoa> pessoas = new List<Pessoa>();

            for (int i = 0; i < 1; i++)
            {
                Pessoa pessoa = new Pessoa();

                Console.WriteLine($">>>>>Digite as informações da {i + 1}a pessoa<<<<<<");
                Console.WriteLine("digite o nome da pessoa");
                Console.WriteLine();
                pessoa.nome = Console.ReadLine();
                Console.WriteLine("Digite a idade:");
                pessoa.idade = int.Parse(Console.ReadLine());
                Console.WriteLine("Digite a altura:");
                pessoa.altura = float.Parse(Console.ReadLine());
                Console.WriteLine("Digite (1) - Fem | (2) - Masc");
                int resosta = int.Parse(Console.ReadLine());
                if (resosta == 1)
                {
                    pessoa.sexo = EnumSexo.Fem;
                }
                else
                if (resosta == 2)
                {
                    pessoa.sexo = EnumSexo.Masc;
                }


                Console.WriteLine("\n\n >>>>> Exibindo os dados da lista \n\n\n");
                foreach (Pessoa item in pessoas)
                {
                    Console.WriteLine(item.ToString());
                    Console.WriteLine();
                }




            }
            //metodos

        }
    }
}
