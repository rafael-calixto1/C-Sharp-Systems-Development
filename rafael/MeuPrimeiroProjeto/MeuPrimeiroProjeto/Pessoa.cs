using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeuPrimeiroProjeto
{
    class Pessoa
    {
        //Atributos (Propriedades ou Variavel)

        // Metodos (comportamentos)

        public string nome;
        public int idade;
        public double peso;
        public double altura;
        public char sexo;
        public ECorOlhos corOlhos;

        //meTODOS (COMPORTAMNETOSS)

        public void MeuNome()
        {

            Console.WriteLine($"Meu nome é {nome.ToUpper()}");
        }
        
    }
}

