using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Listass
{
    class Program
    {
        static void Main(string[] args)
        {
            //ARRAY
            int[] vetNumeros = new int[5];
            vetNumeros[0] = 100;
            vetNumeros[3] = 200;


            string[] nomes = new string[] { "teclado", "mouse", "monitor", "gabinete"};


            //Listas
            List<int> valores = new List<int>();

            valores.Add(4);
            valores.Add(13);
            valores.Add(11);
            valores.Add(70);

            for (int i = 0; i < valores.Count; i++)
            {
                Console.WriteLine(valores[i]);
            }
        }
    }
}
