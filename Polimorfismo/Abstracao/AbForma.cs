using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstracao
{
    //Criando classes Abstratas
    //usar a palvara reservada 'abstract' antes de class

    public abstract class AbForma
    {
        //Nao se instancia objeto de classe abstrata
        public string Cor { get; set; }

        public virtual double Area()
        {
            return 0;
        }

        //Criar assinaturas
        //todas as classe que herdarem da classe abstratas são OBRIGADAS a implementarem o que esta na assinatura
        public abstract double Perimetro(); // a classe abstrata nao sabe como calcular o perimetro, mas aquela que deve saber


    }
}
