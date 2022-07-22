using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.ExercicioBancoDeDados.DataBase
{
    internal class Conexao
    {
        public SqlConnection Conectar()
        {
            SqlConnection conexao = new SqlConnection();

            var nomeBanco = "BancoDeDados";
            var caminhoCompleto = Directory.GetCurrentDirectory().Substring(0, AppContext.BaseDirectory.LastIndexOf("\\bin"));
            conexao.ConnectionString = $@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename={caminhoCompleto}\DataBase\{nomeBanco}.mdf;Integrated Security=True";

            conexao.Open();

            return conexao;
        }
    }
}
