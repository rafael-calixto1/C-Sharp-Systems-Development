using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Importar Bibliotecas de Banco de Dados
using System.Data;
using System.Data.SqlClient;
using AcessoBancoDados.Properties;

namespace AcessoBancoDados
{
    public class AcessoDadosSQLServer
    {
        //Criar a conexão com o BD
        private SqlConnection CriarConexao()
        {
            return new SqlConnection(Settings.Default.StringConnection);
        }

        //Parâmetros para o BD
        private SqlParameterCollection sqlParameterCollection = new SqlCommand().Parameters;

        public void LimparParametros()
        {
            sqlParameterCollection.Clear();
        }

        public void AdicionarParametros(string nomeParametro, object valorParametro)
        {
            sqlParameterCollection.Add(new SqlParameter(nomeParametro, valorParametro));
        }

        //Preencher os dados da SqlCommand - Manipulação
        private SqlCommand PreencherSqlCommand(CommandType commandType, string minhaUSP)
        {
            try
            {
                //Criar e abrir a conexão com o BD
                SqlConnection sqlConnection = CriarConexao();
                sqlConnection.Open();
                //Complementar os comandos da SqlCommand
                SqlCommand sqlCommand = sqlConnection.CreateCommand();
                sqlCommand.CommandType = commandType;
                sqlCommand.CommandText = minhaUSP;
                //Definir o tempo de excução desses comandos (segundos)
                sqlCommand.CommandTimeout = 3600;
                //Adicionar os parâmetros dentro da sqlcommand
                foreach (SqlParameter item in sqlParameterCollection)
                {
                    sqlCommand.Parameters.Add(new SqlParameter(item.ParameterName, item.Value));
                }

                return sqlCommand;
            }
            catch (Exception ex)
            {
                //Disparar um novo evento de exceção para ser utilizada na camada superior
                //O formato de saída é diferente
                throw new Exception(ex.Message);
            }
        }

        //Inserir, alterar e excluir
        public object ManipulaDados(CommandType commandType, string minhaUSP)
        {
            try
            {
                SqlCommand sqlCommand = new SqlCommand();
                //Chamando a função que preenche a linha de comando
                sqlCommand = PreencherSqlCommand(commandType, minhaUSP);
                //Excutar o comando e pegar o retorno do BD
                return sqlCommand.ExecuteScalar();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        //Consulta dos registros
        public DataTable ExecutaConsulta(CommandType commandType, string minhaUSP)
        {
            try
            {
                //Cria e chama a função que preenche a sqlcommand
                SqlCommand sqlCommand = PreencherSqlCommand(commandType, minhaUSP);
                //Criar um 'adaptador' que 'traduz' o retorno do BD
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
                //Criar uma tabela vazia
                DataTable dataTable = new DataTable();
                sqlDataAdapter.Fill(dataTable);
                //Retorno da Stored Procedure
                return dataTable;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
