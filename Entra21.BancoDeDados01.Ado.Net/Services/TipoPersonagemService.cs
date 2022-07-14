using Entra21.BancoDeDados01.Ado.Net.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.BancoDeDados01.Ado.Net.Services
{
    // Dois pontos seguido de uma interface, quer dizer que a classe
    // será obrigada a implementar os métodos(contratos) estabelecidos
    // na interface
    internal class TipoPersonagemService : ITipoPersonagemService
    {
        public void Cadastrar(TipoPersonagem tipoPersonagem)
        {
            // Instanciando um objeto da classe SqlConnection
            // que permitirá fazer selects, inserts, updates, deletes, etc...
            SqlConnection conexao = new SqlConnection();

            // string que contém o caminho para o banco de dados, o
            // que permitirá conetar ao banco de dados
            var connectionString = @"";

            // Definir o caminho da conexão para o Sqlconnection
            conexao.ConnectionString = connectionString;

            // Abrir a conexão com o banco de dados
            conexao.Open();
        }
    }
}
