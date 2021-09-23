//escreva um programa que armazene em variaveis seu nome sua idade e cidade onde reside. Na sequencia exiba o conteudo destas variaveis na tela
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
            Console.WriteLine("Digite o seu nome: ");
            string nome = Console.ReadLine();


            Console.WriteLine("Digite sua idade: ")
            int idade = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite a cidade em que você reside")
            string cidade = Console.ReadLine();

            Console.WriteLine(nome);
            Console.WriteLine(idade);
            Console.WriteLine(cidade);


            Console.ReadLine();
        }
    }
} 