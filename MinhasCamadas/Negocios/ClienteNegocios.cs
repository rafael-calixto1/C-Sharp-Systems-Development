using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Importar as bibliotecas
using System.Data;
using AcessoBancoDados;
using ObjetoTransferencia;

namespace Negocios
{
    public class ClienteNegocios
    {
        //instanciar um objeto do tipo AcessoSQLServer
        AcessoDadosSQLServer acessoDadosSQLServer = new AcessoDadosSQLServer();

        public string InserirCliente(Cliente cliente)
        {
            try
            {
                //limpar a coleção de parâmetros
                acessoDadosSQLServer.LimparParametros();
                //adicionar os parâmetros que irão até o BD
                acessoDadosSQLServer.AdicionarParametros("@Nome", cliente.Nome);
                acessoDadosSQLServer.AdicionarParametros("@CPF", cliente.CPF);
                acessoDadosSQLServer.AdicionarParametros("@Nascimento", cliente.Nascimento);
                //Determinar qual é a Stored Procedure
                string codCliente = acessoDadosSQLServer.ManipulaDados(
                                                    CommandType.StoredProcedure,
                                                    "uspInserirCliente").ToString();
                //Retorno do BD
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

        //Para cada consulta deverá haver um método que o represente
        //Consulta por nome
        public ClienteColecao ConsultaClienteNome(string nome)
        {
            try
            {
                //Cria uma coleção do objeto esperado no retorno
                ClienteColecao clienteColecao = new ClienteColecao();
                //Limpar os parâmetros
                acessoDadosSQLServer.LimparParametros();
                //Adicionar os parâmetros
                acessoDadosSQLServer.AdicionarParametros("@Nome", nome);
                //Criar um DataTable para receber os valores da consulta
                DataTable dataTableCliente = acessoDadosSQLServer.ExecutaConsulta(
                    CommandType.StoredProcedure, "uspConsultaClienteNome");
                //Para cada linha do DataTable cria-se um objeto para povoar
                foreach (DataRow linha in dataTableCliente.Rows)
                {
                    Cliente cliente = new Cliente();
                    cliente.CodCliente = Convert.ToInt32(linha["CodCliente"]);
                    cliente.Nome = Convert.ToString(linha["Nome"]);
                    cliente.CPF = Convert.ToString(linha["CPF"]);
                    cliente.Nascimento = Convert.ToDateTime(linha["Nascimento"]);
                    //Adicionar o objeto na coleção
                    clienteColecao.Add(cliente);
                }
                //retornando a coleção de clientes
                return clienteColecao;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
     
    }
}
