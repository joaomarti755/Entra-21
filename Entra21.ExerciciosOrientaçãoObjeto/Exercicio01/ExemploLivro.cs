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
            var opcaoValida = false;
            Livro livro = new Livro();
            Console.WriteLine("Digite o título do livro: ");
            livro.Titulo = Console.ReadLine().Trim();
            Console.WriteLine("Digite o autor do livro: ");
            livro.Autor = Console.ReadLine().Trim();
            Console.WriteLine("Digite o idioma original: ");
            livro.IdiomaOriginal = Console.ReadLine().Trim();
            while(opcaoValida == false)
            {
                try
                {
                    Console.WriteLine("Digite a data de lançamento: ");
                    livro.DataLancamento = Convert.ToDateTime(Console.ReadLine());

                    opcaoValida = true;
                }
                catch(Exception ex)
                {
                    Console.WriteLine("Data invalida");
                }
            }
            opcaoValida = false;
            while(opcaoValida == false)
            {
                try
                {
                    Console.WriteLine("Digite a quantidade de de páginas: ");
                    livro.QuantidadePaginas = Convert.ToInt32(Console.ReadLine());
                    if(livro.QuantidadePaginas <= 0)
                    {
                        Console.WriteLine("Numero invalido");
                    }
                    else
                    {
                        opcaoValida = true;
                    }
                }
                catch(Exception ex)
                {
                    Console.WriteLine("Numero invalido");
                }
            }
            opcaoValida = false;
            while(opcaoValida == false)
            {
                try 
                { 
                    Console.WriteLine("Digite a quantidade de paginas lidas: ");
                    livro.QuantidadePaginasLidas = Convert.ToInt32(Console.ReadLine());
                    
                    if((livro.QuantidadePaginasLidas < 0) || (livro.QuantidadePaginasLidas > livro.QuantidadePaginas))
                    {
                        Console.WriteLine("Numero invalido");
                    }
                    else
                    {
                        opcaoValida = true;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Numero invalido");
                }
            }
            opcaoValida = false;
            while(opcaoValida == false)
            {
                try
                {
                    Console.WriteLine("Digite a quantidade de releituras: ");
                    livro.QuantidadeReleitura = Convert.ToInt32(Console.ReadLine());
                    if(livro.QuantidadeReleitura < 0)
                    {
                        Console.WriteLine("Numero invalido");
                    }
                    else
                    {
                        opcaoValida = true;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Numero invalido");
                }
            }

            Console.WriteLine(@$"O Titulo e o autor é: {livro.TituloComAutor()}
A quantidade de paginas que faltam ler é: {livro.QuantidadePaginasParaLer()}
A quantidadede de paginas lidas no total é: {livro.QuantidadePaginasLidasNoTotal()}");
        }
    }
}
