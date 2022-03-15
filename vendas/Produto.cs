using System;
using System.Collections.Generic;
using System.Text;

namespace vendas
{
    public class Produto
    {
        public string marca;
        public string descricao;
        public int estoque;
        public double preco;
        public EnumTipo tipo;


        //metodos
        //void e retornavel

 /*       public void MostraEstoque(string nome, int idade)
        {

            Console.WriteLine($"Esse valor veio com os parametro ----->>   {nome}  & {idade}   <-------");

            Console.WriteLine($"O produto {descricao} da marca {marca}, tem ");
            Console.WriteLine($"O valor total em estque é {estoque * preco}");

            
        }

 */           //configurar uma saida de dados (entra no lugar do void)

            public double MeuEstoque()
            {
                double conta = estoque * preco;
                return conta;

            
            }

        //Definindo o metodo ToString()
        public override string ToString()
        {
            return ($"Marca: {marca}\n" +
                $"Descrição: {descricao}\n" +
                $"Itens no Estoque: {estoque}\n" +
                $"Valor em estoque: {MeuEstoque().ToString("C2")}");
        }

    }

}

