using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Importat Bibliotecas de Banco de Dados
using System.Data;
using System.Data.SqlClient;
using AcessoBancoDados.Properties;



namespace AcessoBancoDados
{
    public class AcessoDadosSQLServer
    {
        //Cliar a conexão com o BD
        private SqlConnection CriarConexao()
        {
            return new SqlConnection(Settings.Default.StringConection);
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
        private SqlCommand PreencherSqlCommad(CommandType commandType, string minhaUSP)
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
                //Definir o tempo de excução deses comandos(segidos)
                sqlCommand.CommandTimeout = 3600;
                //Adicionar os parâmetros dentro da sqlCommand
                foreach(SqlParameter item in sqlParameterCollection)
                {
                    sqlCommand.Parameters.Add(new SqlParameter(item.ParameterName, item.Value));
                }
                return sqlCommand;

            }
            catch (Exception ex)
            {
                //Disparar um novo evendto de exeção para ser utilizada na camada superior
                //O formato de saída é diferente
                throw new Exception(ex.Message);
            }
        }

        //Inserir, Aterar e ecluir
        public object ManipulaDados(CommandType commandType, string minhaUSP)
        {
            try
            {
                SqlCommand sqlCommand = new SqlCommand();
                //Chamando a função que preenche a linha de comado
                sqlCommand = PreencherSqlCommad(commandType, minhaUSP);
                //Excutar o comando e pegar o retorno do BD
                return sqlCommand.ExecuteScalar();

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }

        //Consulta dos registros
        public DataTable  ExecutaConsulta(CommandType commandType, string minhaUSP)
        {
            try
            {
                //Criar e chamar a função que preenche a sqlcommand
                SqlCommand sqlCommand = PreencherSqlCommad(commandType, minhaUSP);
                //Criar um 'adaptador' que 'traduz' o retorno do BD
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
                //Criar uma tabela vazia
                DataTable dataTable = new DataTable();
                sqlDataAdapter.Fill(dataTable);
                //Retorno da Stored procedure
                return dataTable;


            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }
    }
}
