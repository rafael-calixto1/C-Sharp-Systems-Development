using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulamento2
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa pessoa = new Pessoa();
            //pessoa.nome --> não aparece por ser privado
            pessoa.SetNome("Etec");

            Console.WriteLine($"Nome: {pessoa.GetNome()}");

            pessoa.Idade = 16; //através da propriedade criada na classe pessoa, pessoa recebe o VALOR inteiro 
            Console.WriteLine($"Idade: {pessoa.Idade}"); //Propriedade é algo especial vindo do C#
           
        }
    }
}
