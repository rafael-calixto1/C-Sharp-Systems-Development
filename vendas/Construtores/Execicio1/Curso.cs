using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Execicio1
{
    public class Curso
    {
        //Atributos 
        public string _titulo;
        public string _descricao;
        public string _periodo;
        //public string periodo;

        public Curso()
        {

        }
        public Curso(string titulo, string descricao, string periodo)
        {
            _titulo = titulo;
            _descricao = descricao;
            _periodo = periodo;
        }


        public override string ToString()
        {
            return $"nome do Curso: {_titulo} \n" +
                   $"Descricao do Curso: {_descricao} \n" +
                   $"Periodo do Curso: {_periodo}";

        }

    }
}
