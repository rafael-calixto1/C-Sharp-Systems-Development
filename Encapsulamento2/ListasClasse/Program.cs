using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListasClasse
{
    class Program
    {
        static void Main(string[] args)
        {
            MinhaMae mae = new MinhaMae();
            mae.Nome = "Celular";
            mae.Idade = 41;
            mae.MeusFilhos.Add(new Filho("tecladinho", "m"));
            mae.MeusFilhos.Add(new Filho("Mouse", "m"));
            mae.MeusFilhos.Add(new Filho("WebCam", "f"));

        }
    }
}
