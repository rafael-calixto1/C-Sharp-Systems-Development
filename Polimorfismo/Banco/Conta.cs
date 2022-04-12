using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco
{
    public abstract class Conta
    {
        public int IdConta { get; set; }
        public Pessoa Titular;
        public double _saldo;

        public Conta(int idConta, Pessoa titular, double saldo)
        {
            IdConta = idConta;
            Titular = titular;
            _saldo = saldo;
        }

        public abstract double Deposito();


        public abstract double Saque();
       
    }
}
