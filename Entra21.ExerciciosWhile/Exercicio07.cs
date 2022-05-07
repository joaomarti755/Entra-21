using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.ExerciciosWhile
{
    internal class Exercicio07
    {
        public void Executar()
        {
            string nomeProduto = "";
            double valorProduto = 0;
            int quantidadeProduto = 0;
            double valorTotal = 0;

            while(quantidadeProduto < 5)
            {
                Console.Write("Digite o nome do produto: ");
                nomeProduto = Console.ReadLine();

                Console.Write("Digite o valor do produto: ");
                valorProduto = Convert.ToDouble(Console.ReadLine());

                Console.Write("Digite a quantidade de produtos: ");
                quantidadeProduto = Convert.ToInt32(Console.ReadLine());

                valorTotal = valorProduto * quantidadeProduto - 150;

                Console.WriteLine("O valor total é: " + valorTotal);
            }
        }
    }
}
