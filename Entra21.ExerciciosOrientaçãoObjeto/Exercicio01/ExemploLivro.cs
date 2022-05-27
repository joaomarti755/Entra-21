using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.ExerciciosOrientacaoObjeto.Exercicio01
{
    public class ExemploLivro
    {
        public void Executar()
        {
            Livro livro = new Livro();
            Console.WriteLine("Digite o título do livro: ");
            livro.Titulo = Console.ReadLine().Trim();
            Console.WriteLine("Digite o autor do livro: ");
            livro.Autor = Console.ReadLine().Trim();
            Console.WriteLine("Digite o idioma original: ");
            livro.IdiomaOriginal = Console.ReadLine().Trim();
            Console.WriteLine("Digite a data de lançamento: ");
            livro.DataLancamento = Convert.ToDateTime(Console.ReadLine());
            Console.WriteLine("Digite a quantidade de de páginas: ");
            livro.QuantidadePaginas = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite a quantidade de paginas lidas: ");
            livro.QuantidadePaginasLidas = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite a quantidade de releituras: ");
            livro.QuantidadeReleitura = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(@$"O Titulo e o autor é: {livro.TituloComAutor()}
A quantidade de paginas que faltam ler é: {livro.QuantidadePaginasParaLer()}
");
        }
    }
}
