using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjetoTransferencia
{
    public class Cliente
    {
        //Definir as Propriedades (encapsulamento)
        public int CodCliente { get; set; }
        public string Nome { get; set; }
        public string CPF { get; set; }
        public DateTime Nascimento { get; set; }

        //Criar os métodos contrutores
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

        //Criar os métodos de classe

    }
}
