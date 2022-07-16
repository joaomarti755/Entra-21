using Entra21.BancoDeDados01.Ado.Net.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.BancoDeDados01.Ado.Net.Services
{
    internal interface ITipoPersonagemService
    {
        void Cadastrar(TipoPersonagem tipoPersonagem);
        List<TipoPersonagem> ObterTodos();
        void Apagar(int id);
        TipoPersonagem ObterPorId(int id);
        void Editar(TipoPersonagem tipoPersonagem);
    }
}
