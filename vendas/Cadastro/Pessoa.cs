using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cadastro
{
    public class Pessoa
    {
        public string nome;
        public double altura;
        public int idade;
        public EnumSexo sexo;

        
    }

    //ToString()
    public override string ToString()
    {
        return
            ($"Nome: {nome}\n "+
            $"altura: {altura}\n" +
            $"idade: {idade}\n"+
            $"Sexo: {");
    }
}
