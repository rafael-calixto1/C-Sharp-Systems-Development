using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjetoTranferencia
{
    public class Cliente
    {
        //definir as propriedades
        public int CodCliente { get; set; }
        public String Nome { get; set; }
        public String CPF { get; set; }
        public DateTime Nascimento { get; set; }
        //criar os metodos construtores

        public Cliente() 
        {
        
        }

        public Cliente(int codCliente, string nome, string cPF, DateTime nascimento)
        {
            CodCliente = codCliente;
            Nome = nome;
            CPF = cPF;
            Nascimento = nascimento;
        }

        //criar os metodos da classe

    }
}
