using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListasClasse
{
    public class MinhaMae
    {
        public string Nome { get; set; }
        public int Idade { get; set; }
        // public Filho MeuFilho = new Filho(); //Associacao de classe
        //sempre instanciar a lista antes do Metodo Construtor
        public List<Filho> MeusFilhos = new List<Filho>();

        public MinhaMae()
        {
        }

        public MinhaMae(string nome, int idade) //é uma boa pratica não colocar ela no metodo construtor
        {
            Nome = nome;
            Idade = idade;
        }
    }
}
