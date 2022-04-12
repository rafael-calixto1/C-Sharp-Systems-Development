using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco
{
    //public class Poupanca : Conta
    public class Poupanca : Conta
    {
        public Poupanca(int idConta, Pessoa titular, double saldo) : base(idConta, titular, saldo)
        {
        } //: METODO CONSTRUTOR IMPORTANTE

        public override double Deposito()
        {
            return _saldo;
        }
        public override double Saque()
        {
            return _saldo;
        }
    }
}
