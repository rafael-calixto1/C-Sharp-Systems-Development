using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjetoTransferencia
{
    public class TelefoneTipo
    {
        public int CodTelefoneTipo { get; set; }
        public string DescricaoTelefoneTipo { get; set; }

        public TelefoneTipo()
        {
        }

        public TelefoneTipo(int codTelefoneTipo, string descricaoTelefoneTipo)
        {
            CodTelefoneTipo = codTelefoneTipo;
            DescricaoTelefoneTipo = descricaoTelefoneTipo;
        }
    }
}
