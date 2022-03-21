using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Execicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Defina uma classe chamada Curso 
            //Crie os atributos:
            //string titulo
            //stromg descricao
            //string perioso
            //Crie seus metodos contructores
            //Crie o meto ToString()
            //titulo - Periodo
            //Descricao

            List<Curso> cursos = new List<Curso>();


            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine($">>>>Dados da {i + 1} Curso<<<<");


                Console.WriteLine("o nome do curso");
                string titulo = Console.ReadLine();
                Console.WriteLine("Digite a descricao do curso");
                string descricao = Console.ReadLine();
                Console.WriteLine("Digite o periodo do curso");
                string periodo = Console.ReadLine();

                cursos.Add(new Curso(titulo, descricao, periodo));

                foreach (Curso item in cursos)
                {
                    Console.WriteLine(item.ToString());
                }
            }
        }
    }
}
