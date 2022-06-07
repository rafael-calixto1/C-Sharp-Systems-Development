using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//importar as bibliotecas
using System.Data;
using AcessoBancoDados;
using ObjetoTranferencia;

namespace Negocios
{
    public class ClienteNegocios
    {
        //instanciar um objeto do tipo AcessoBancoDados
        AcessoDadosSQLServer acessoDadosSQLServer = new AcessoDadosSQLServer();
        public string InserirCliente(Cliente cliente)
        {
            try
            {
                //limpar a colecao de parametros
                acessoDadosSQLServer.LimparParametros();
                //adicionar os parametros que irao ate o bd
                acessoDadosSQLServer.AdicionarParametros("@Nome", cliente.Nome);
                acessoDadosSQLServer.AdicionarParametros("@CPF", cliente.CPF);
                acessoDadosSQLServer.AdicionarParametros("@Nascimento", cliente.Nascimento);
                //determinarnqual e a stored procedured
                string codCliente = codCliente = acessoDadosSQLServer.ManipulaDados(CommandType.StoredProcedure, "usoInserirCliente").ToString();
                //retorno do BD
                return codCliente;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
        public string AlterarCliente(Cliente cliente)
        {
            try
            {
                acessoDadosSQLServer.LimparParametros();
                acessoDadosSQLServer.AdicionarParametros("@CodCliente", cliente.CodCliente);
                acessoDadosSQLServer.AdicionarParametros("@Nome", cliente.Nome);
                acessoDadosSQLServer.AdicionarParametros("@CPF", cliente.CPF);
                acessoDadosSQLServer.AdicionarParametros("@Nascimento", cliente.Nascimento);
                string codCliente = acessoDadosSQLServer.ManipulaDados(
                    CommandType.StoredProcedure, "uspAlterarCliente").ToString();
                return codCliente;

            }
            catch (Exception ex)
            {

                return ex.Message;
            }
        }
        public string ExcluirCliente(Cliente cliente)
        {
            try
            {
                acessoDadosSQLServer.LimparParametros();
                acessoDadosSQLServer.AdicionarParametros("@CodCliente", cliente.CodCliente);

                string codCliente = acessoDadosSQLServer.ManipulaDados(
                    CommandType.StoredProcedure, "uspExcluirCliente").ToString();
                return codCliente;

            }
            catch (Exception ex)
            {

                return ex.Message;
            }
        }

        //Para cada consulta devera haver um metodo especifico
        public ClienteColecao ConsultaClienteColecao(string nome)
        {
            try
            {
                // criar um objeto do tipo Cliente Colecao
                ClienteColecao clienteColecao = new ClienteColecao();
                //Limpar os parametros
                acessoDadosSQLServer.LimparParametros();
                //Adoconar os Parametros
                acessoDadosSQLServer.AdicionarParametros("@Nome", nome);
                //criar um dataTable
                DataTable dataTableCliente = acessoDadosSQLServer.ExecutaConsulta(
                    CommandType.StoredProcedure, "uspConsultaClienteNome");
                //para cada dataTable, é criado um objeto do tipo cliente
                foreach (DataRow linha in dataTableCliente.Rows)
                {
                    //criacao de um novo cliente 
                    Cliente cliente = new Cliente();
                    //Preencher os dados (retorno do BD - Coluna)
                    cliente.CodCliente = Convert.ToInt32(linha["codCliente"]);
                    cliente.Nome = Convert.ToString(linha["Nome"]);
                    cliente.CPF = Convert.ToString(linha["CPF"]);
                    cliente.Nascimento = Convert.ToDateTime(linha["Nascimento"]);
                    clienteColecao.Add(cliente);
                }
                return clienteColecao;
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }
    }
}
  

    
