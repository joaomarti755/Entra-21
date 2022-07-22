using Entra21.ExercicioBancoDeDados.DataBase;
using Entra21.ExercicioBancoDeDados.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.ExercicioBancoDeDados.Services
{
    internal class CidadeService : ICidadeService
    {
        public void Apagar(int id)
        {
            var conexao = new Conexao().Conectar();
            var comando = conexao.CreateCommand();
            comando.CommandText = "DELETE FROM cidades WHERE id = @ID";

            comando.Parameters.AddWithValue("@ID", id);

            comando.ExecuteNonQuery();

            comando.Connection.Close();
        }

        public void Cadastrar(Cidade cidade)
        {
            var conexao = new Conexao().Conectar();
            var comando = conexao.CreateCommand();
            comando.CommandText = @"INSET INTO cidades 
(id_unidades_federativas, nome, quantidade_habitantes, data_hora_fundacao, pib) 
VALUES (@ID_UNIDADES_FEDERATIVAS, @NOME, @QUANTIDADE_HABITANTES, @DATA_HORA_FUNDACAO, @PIB);";

            comando.ExecuteNonQuery();

            comando.Connection.Close();
        }

        public void Editar(Cidade cidade)
        {
            var conexao = new Conexao().Conectar();
            var comando = conexao.CreateCommand();
            comando.CommandText =
                @"UPDATE cidades SET 
id_unidades_federativas = @ID_UNIDADES_FEDERATIVAS,
nome = @NOME,
quantidade_habitantes = @QUANTIDADE_HABITANTES,
data_hora_fundacao = @DATA_HORA_FUNDACAO,
pib = @PIB WHERE id = @ID";

            comando.Parameters.AddWithValue("@ID_UNIDADES_FEDERATIVAS",
                cidade.UnidadeFederativa.Id);
            comando.Parameters.AddWithValue("@NOME", cidade.Nome);
            comando.Parameters.AddWithValue("@QUANTIDADE_HABITANTES", cidade.QuantidadeHabitantes);
            comando.Parameters.AddWithValue("@DATA_HORA_FUNDACAO", cidade.DataHoraFundacao);
            comando.Parameters.AddWithValue("@PIB", cidade.Pib);
            comando.Parameters.AddWithValue("@ID", cidade.Id);

            comando.ExecuteNonQuery();

            comando.Connection.Close();
        }

        public Cidade ObterPorId(int id)
        {
            var conexao = new Conexao().Conectar();
            var comando = conexao.CreateCommand();
            comando.CommandText = "SELECT id, id_unidades_federativas, quantidade_habitantes, data_hora_fundacao, pib FROM cidades WHERE id = @ID";
            comando.Parameters.AddWithValue("@ID", id);

            var dataTable = new DataTable();
            dataTable.Load(comando.ExecuteReader());
            if(dataTable.Rows.Count == 0)
                return null;

            var registro = dataTable.Rows[0];
            var cidade = new Cidade();
            cidade.Id = Convert.ToInt32(registro["id"]);

            cidade.UnidadeFederativa = new UnidadeFederativa();
            cidade.UnidadeFederativa.Id = Convert.ToInt32(registro["id_unidade_federativa"]);

            cidade.Nome = registro["nome"].ToString();
            cidade.QuantidadeHabitantes = Convert.ToInt32(registro["quantidade_habitantes"]);
            cidade.DataHoraFundacao = Convert.ToDateTime(registro["data_hora_fundacao"]);
            cidade.Pib = Convert.ToDecimal(registro["pib"]);

            conexao.Close();

            return cidade;
        }

        public List<Cidade> ObterTodos(int id)
        {
            var conexao = new Conexao().Conectar();
            var comando = conexao.CreateCommand();

            comando.CommandText = @"SELECT
c.id AS 'id',
c.nome AS 'nome',
uf.id AS 'unidade_federativa_id',
uf.nome AS 'unidade_federativa_nome',
uf.sigla AS 'unidade_federativa_sigla'
c.quantidade_habitantes AS 'quantidade_habitantes',        "
        }
    }
}
