using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulamento
{
    public class Conta
    {
        public string _titular;
        private double _saldo;
        public int _agencia;


        //Metodos Construtores

        public Conta()
        {
        }

        public Conta(string titular, double saldo, int agencia)
        {
            _titular = titular;
            _saldo = saldo;
            _agencia = agencia;

        }



        //ENCAPSULAMENTO é um metodo que permite a segurança
        //GET - pegar / SET - colocar

        public double GetSaldo()
        {
            return _saldo;
        }

        public void SetDeposito(double valor)
        {
            _saldo += valor;
        }
            


    }
}
