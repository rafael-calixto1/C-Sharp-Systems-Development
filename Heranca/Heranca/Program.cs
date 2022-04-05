using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heranca
{
    class Program
    {
        static void Main(string[] args)
        {
            Pai pai = new Pai();
            pai.Nome = "Garrafao";
            pai.Idade = 3;

            Filho filho = new Filho();
            filho.Nome = "garrafa";
            filho.Idade = 1;
            filho.Esporte = "Futebol";

            Neto neto = new Neto();
            
        }
    }
}
