using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulamento2
{
    public class Pessoa
    {
        private string _nome;
        private int _idade;
        //private double _altura;
        //Propriedade reduzida prop + Tab(2x)
        public double Altura { get; set; } //cria internamente um elemneto privado tipo _altura
        public Pessoa()
        {
        }

        public Pessoa(string nome, int idade, double altura)
        {
            _nome = nome;
            _idade = idade;
            Altura = altura;
        }

        //Encapsulamento get (buscar)/ set (colocar)
        public string GetNome()
        {
            return _nome;
        }
        public void SetNome(string nome)
        {
            _nome = nome;

        }//Geralmente void é void e, geralmente, recebe um parametro


        //Propredades em C# -Encapsulamento
        //Propriedade é publica e se inica com letra maiuscula
        //GET e SET no mesmo lugar
        //Não existe propriedade VOID, logo, toda propriedade possui um

        public int Idade
        {
            get { return _idade; }
            set
            {
                if (value > 0)
                {
                    _idade = value;
                }
            }
        }
       
    }
}
