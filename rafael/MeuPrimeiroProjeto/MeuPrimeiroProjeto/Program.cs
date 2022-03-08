using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeuPrimeiroProjeto
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa pessoa1 = new Pessoa();
            pessoa1.nome = "Rafael";
            pessoa1.idade = 42;
            pessoa1.altura = 1.71;
            pessoa1.corOlhos = ECorOlhos.Castanho;


            Pessoa pessoa2 = new Pessoa();
            pessoa2.nome = "Etec";
            pessoa2.idade = 13;
            pessoa2.altura = 2.15;
            pessoa2.corOlhos = ECorOlhos.Verde;

            Console.WriteLine(pessoa1.nome);

            Console.WriteLine(pessoa2.nome);


            pessoa1.MeuNome();
            pessoa2.MeuNome();


            Console.WriteLine("------------");




            //cachorros

            Cachorro cachorro1 = new Cachorro();
            cachorro1.nome = "Troia";
            cachorro1.peso = 20.00;
           


            Console.WriteLine(cachorro1.nome);
            Console.WriteLine(cachorro1.peso);
            cachorro1.Latir();
            cachorro1.porte = EnumPorte.Grande;


        }

    }
}
