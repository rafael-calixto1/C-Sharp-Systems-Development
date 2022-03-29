using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio1
{
    public class Conta
    {
        private double _saldo;
        public Conta()
        {

        }

        public int IdConta { get; set; }
        public string Titular { get; set; }

        public Conta(double saldo)
        {
            _saldo = saldo;
        }

        public double GetSaldo()
        {
            return _saldo;
        }
        public void SetSaldo(double saldo)
        {
            _saldo = saldo;

        }
    }
}
