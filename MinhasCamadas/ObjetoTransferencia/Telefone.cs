using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjetoTransferencia
{
    public class Telefone
    {
        public int CodTelefone { get; set; }
        public string NumeroTelefone { get; set; }
        public int CodCliente { get; set; }
        public int CodTelefoneTipo { get; set; }

        public Telefone()
        {
        }

        public Telefone(int codTelefone, string numeroTelefone, int codCliente, int codTelefoneTipo)
        {
            CodTelefone = codTelefone;
            NumeroTelefone = numeroTelefone;
            CodCliente = codCliente;
            CodTelefoneTipo = codTelefoneTipo;
        }
    }
}
