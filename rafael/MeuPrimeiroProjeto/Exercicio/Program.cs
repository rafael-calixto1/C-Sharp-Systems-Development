using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto produto1 = new Produto();

            produto1.marca = "knor";
            produto1.descricao = "Tempero para arroz";
            produto1.preco = 3.99;
            produto1.estoque = 78;
            produto1.tipo = ETipo.Un;




            Console.WriteLine(produto1.marca);
            Console.WriteLine(produto1.descricao);
            Console.WriteLine(produto1.tipo);
            Console.WriteLine(produto1.preco);
            Console.WriteLine(produto1.estoque);
        }
    }
}



