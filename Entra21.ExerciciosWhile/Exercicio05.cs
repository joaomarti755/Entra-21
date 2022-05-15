using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.ExerciciosWhile
{
    internal class Exercicio05
    {
        public void Executar()
        {
            Console.Write("Digite a quantidade de carros que deseja cadastrar: ");
            int quantidadeCarros = Convert.ToInt32(Console.ReadLine());
            int indice = 0;
            int somaAnoCarro = 0;
            double somaValorCarro = 0;
            int carrosComLetraA = 0;
            int carrosComLetraG = 0;

            while (indice < quantidadeCarros)
            {
                Console.Write("Digite o modelo do carro: ");
                string modeloCarro = Console.ReadLine().ToLower().Trim();

                Console.Write("Digite o valor do carro: ");
                double valorCarro = Convert.ToDouble(Console.ReadLine());

                Console.Write("Digite o ano do carro: ");
                int anoCarro = Convert.ToInt32(Console.ReadLine());

                if(modeloCarro.StartsWith("a"))
                {
                    carrosComLetraA = carrosComLetraA + 1;
                }
                else if(modeloCarro.StartsWith("g"))
                {
                    carrosComLetraG = carrosComLetraG + 1;
                }

                somaValorCarro = somaValorCarro + valorCarro;
                somaAnoCarro = somaAnoCarro + anoCarro;
                indice = indice + 1;
            }
            double mediaAnoCarro = somaAnoCarro / quantidadeCarros;
            double mediaValorCarro = somaValorCarro / quantidadeCarros;

            Console.WriteLine("A média do ano dos carros é: " + mediaAnoCarro);
            Console.WriteLine("A média do valor dos carros é: " + mediaValorCarro);
            Console.WriteLine("A quantidade de carros que começam com a letra G é: " + carrosComLetraG);
            Console.WriteLine("A quantidade de carros que começam com a letra A é: " + carrosComLetraA);
            


        }
    }
}
