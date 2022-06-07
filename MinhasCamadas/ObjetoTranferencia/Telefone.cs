using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjetoTranferencia
{
    public class Telefone
    {
        public int CodCliente { get; set; }
        public String Numerotelefone { get; set; }
        public String TelefoneTipo { get; set; }
        public int CodTelefone { get; set; }

        public Telefone()
        {
        }

        public Telefone(int codTelefone, int codCliente, string numerotelefone, string telefoneTipo)
        {
            CodTelefone = codTelefone;
            CodCliente = codCliente;
            Numerotelefone = numerotelefone;
            TelefoneTipo = telefoneTipo;
        }
    }

}
