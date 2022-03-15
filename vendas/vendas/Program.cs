using System;
using System.Collections.Generic;

namespace vendas
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Produto produto = new Produto();
            produto.marca = "Lenovo";
            produto.descricao = "Computador desktop";
            produto.preco = 3000;
            produto.estoque = 21;
            produto.tipo = EnumTipo.Unidade;


            produto.MostraEstoque("Rafael", 20);
           // Console.WriteLine(produto.MeuEstoque());
            double retorno = produto.MeuEstoque();
            Console.WriteLine(retorno.ToString("C2")); //exibe como valor de moeda
            */

            List<Produto> produtos = new List<Produto>();

            for (int i = 0; i <= 1; i++)
            {
                Produto produto = new Produto();

                Console.WriteLine($">>>>>>Digite as informações do {i + 1}o produto <<<<<<<");
                Console.WriteLine($"digite a marca do produto");
                Console.WriteLine();
                produto.marca = Console.ReadLine();
                Console.WriteLine("digite a descrica do produto");
                produto.descricao = Console.ReadLine();
                Console.WriteLine("Digite o valor de venda do produto");
                produto.preco = double.Parse(Console.ReadLine());
                Console.WriteLine("Digite a quantidade em estoque");
                produto.estoque = int.Parse(Console.ReadLine());
                Console.WriteLine("Digite (1) - Unidad | (2) - Kilo | (3) - Metro");
                int resposta = int.Parse(Console.ReadLine());
                if (resposta ==1)
                {
                    produto.tipo = EnumTipo.Unidade;
                } else if (resposta == 2)
                {
                    produto.tipo = EnumTipo.Kilo;
                }
                else
                {
                    produto.tipo = EnumTipo.Metro;
                }
                produtos.Add(produto);
            }


            Console.WriteLine("\n >>>>>exibindo os dados da lista<<<<<\n");
            foreach (Produto item in produtos) 
            {
                Console.WriteLine(item.ToString());
                Console.WriteLine();
            }
        }
    }
}


