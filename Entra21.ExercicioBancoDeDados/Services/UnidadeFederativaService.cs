using Entra21.ExercicioBancoDeDados.DataBase;
using Entra21.ExercicioBancoDeDados.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.ExercicioBancoDeDados.Services
{
    internal class UnidadeFederativaService : IUnidadeFederativaService
    {
        public void Apagar(int id)
        {
            var conexao = new Conexao().Conectar();

            var comando = conexao.CreateCommand();

            comando.CommandText = "DELETE FROM unidades_federativas WHERE id = @ID";
            comando.Parameters.AddWithValue("@ID", id);

            comando.ExecuteNonQuery();

            comando.Connection.Close();
        }

        public void Cadastrar(UnidadeFederativa unidadeFederativa)
        {
            var conexao = new Conexao().Conectar();

            SqlCommand comando = conexao.CreateCommand();

            comando.CommandText =
                "INSERT INTO unidades_federativas (nome, sigla) VALUES (@NOME, @SIGLA);";
            comando.Parameters.AddWithValue("@NOME", unidadeFederativa.Nome);
            comando.Parameters.AddWithValue("@SIGLA", unidadeFederativa.Sigla);

            comando.ExecuteNonQuery();

            conexao.Close();
        }

        public void Editar(UnidadeFederativa unidadeFederativa)
        {
            var conexao = new Conexao().Conectar();

            var comando = conexao.CreateCommand();
            comando.CommandText =
                "UPDATE unidades_federativas SET nome = @NOME, sigla = @SIGLA WHERE id = @ID";
            comando.Parameters.AddWithValue("@NOME", unidadeFederativa.Nome);
            comando.Parameters.AddWithValue("@SIGLA", unidadeFederativa.Sigla);
            comando.Parameters.AddWithValue("@ID", unidadeFederativa.Id);

            comando.ExecuteNonQuery();

            comando.Connection.Close();
        }

        public UnidadeFederativa ObterPorId(int id)
        {
            var conexao = new Conexao().Conectar();

            var comando = conexao.CreateCommand();
            comando.CommandText =
                "SELECT id, nome, sigla FROM unidades_federativas WHERE id = @ID";
            comando.Parameters.AddWithValue("@ID", id);

            var tabelaEmMemoria = new DataTable();

            tabelaEmMemoria.Load(comando.ExecuteReader());

            if (tabelaEmMemoria.Rows.Count == 0)
                return null;

            var primeiroRegistro = tabelaEmMemoria.Rows[0];

            var unidadeFederativa = new UnidadeFederativa();
            unidadeFederativa.Id = Convert.ToInt32(primeiroRegistro["id"]);
            unidadeFederativa.Nome = primeiroRegistro["nome"].ToString();

        }

        public List<UnidadeFederativa> ObterTodos()
        {
            throw new NotImplementedException();
        }
    }
}
