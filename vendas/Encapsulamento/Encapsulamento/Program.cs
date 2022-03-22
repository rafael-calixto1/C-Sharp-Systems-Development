using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulamento
{
    class Program
    {
        static void Main(string[] args)
        {
            Conta conta = new Conta();
            Console.WriteLine("Digite o nome do titular");
            conta._titular = Console.ReadLine();
            Console.WriteLine("Digite o numero da agencia");
            conta._agencia = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor do primeiro deposito");
            double deposito = double.Parse(Console.ReadLine());
            conta.SetDeposito(deposito);

            //conta.GetSaldo() = 1000000;
            Console.WriteLine("\n" +
                $"Saldo: {conta.GetSaldo().ToString("C2")}");
        }
    }
}
