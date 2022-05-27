using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.ExerciciosOrientacaoObjeto.Exercicio01
{
    public class Livro
    {
        public string Titulo;
        public string Autor;
        public string CodigoIsbn;
        public string IdiomaOriginal;
        public DateTime DataLancamento;
        public int QuantidadePaginas;
        public int QuantidadePaginasLidas;
        public int QuantidadeReleitura;

        public string TituloComAutor()
        {
            var tituloAutor = Titulo + " de: " + Autor;

            return tituloAutor;
        }
        
        public int QuantidadePaginasParaLer()
        {
            var paginasParaLer =  QuantidadePaginas - QuantidadePaginasLidas;

            return paginasParaLer;
        }

        public int QuantidadePaginasLidasNoTotal()
        {
            var paginasLidasNoTotal = QuantidadePaginasLidas * QuantidadeReleitura;

            return paginasLidasNoTotal;
        }
    }
}
