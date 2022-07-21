using Entra21.ExercicioBancoDeDados.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.ExercicioBancoDeDados.Services
{
    internal interface IUnidadeFederativaService
    {
        void Cadastrar(UnidadeFederativa unidadeFederativa);
        List<UnidadeFederativa> ObterTodos();
        void Apagar(int id);
        UnidadeFederativa ObterPorId(int id);
        void Editar(UnidadeFederativa unidadeFederativa);
    }
}
