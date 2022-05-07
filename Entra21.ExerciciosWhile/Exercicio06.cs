using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.ExerciciosWhile
{
    internal class Exercicio06
    {
        public void Executar()
        {
            string nomeProduto = "";
            int quantidadeProdutos = 0;
            double valorProduto = 0;
            double somaValorProduto = 0;
            double somaValorQuantidadeProduto = 0;
            double valorDesconto = 0;
            double valorFinal = 0;

            while (nomeProduto != "sair")
            {
                Console.Write("Digite o nome do produto: ");
                nomeProduto = Console.ReadLine();

                Console.Write("Digite o valor do produto: ");
                valorProduto = Convert.ToDouble(Console.ReadLine());

                Console.Write("Digite a quantidade do produto: ");
                quantidadeProdutos = Convert.ToInt32(Console.ReadLine());

                somaValorProduto = somaValorProduto + valorProduto;
                somaValorQuantidadeProduto = somaValorProduto * quantidadeProdutos;
                valorDesconto = somaValorQuantidadeProduto * 0.05;
                valorFinal = somaValorQuantidadeProduto - valorDesconto;

                Console.WriteLine("O valor foi de: " + valorFinal);
            }
        }
    }
}
