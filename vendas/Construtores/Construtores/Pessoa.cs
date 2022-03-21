using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Construtores
{
   public class Pessoa
    {
        //Atributos
        public string _nome;
        public int _idade;

        //Metodos Construtores
        //todo metodo construto leva o mesmo nome que a classe e é public
        //São passados os valores dos atributos por parametros

        public Pessoa()
        {

        }

        public Pessoa(string nome, int idade)
        {
            _nome = nome;
            _idade = idade;
        }

        //Metodos Gerais

        public override string ToString()
        {
            return $"Nome da pessoa {_nome} \n" +
              $"idade: {_idade} \n";
        }
    
    }
}
