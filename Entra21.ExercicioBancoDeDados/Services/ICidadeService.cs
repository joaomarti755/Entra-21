using Entra21.ExercicioBancoDeDados.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.ExercicioBancoDeDados.Services
{
    internal interface ICidadeService
    {
        void Cadastrar(Cidade cidade);
        List<Cidade> ObterTodos(int id);
        void Apagar(int id);
        Cidade ObterPorId(int id);
        void Editar(Cidade cidade);
    }
}
