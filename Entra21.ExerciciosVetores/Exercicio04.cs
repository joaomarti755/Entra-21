using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.ExerciciosVetores
{
    internal class Exercicio04
    {
        public void Executar()
        {
            double[] notas = new double[4];
            double soma = 0;
            Console.Write("Digite o nome: ");
            string nome = Console.ReadLine().Trim();
            for(var i = 0; i < 4; i++)
            {
                Console.Write("Digite a nota: ");
                notas[i] = Convert.ToDouble(Console.ReadLine());

                soma = soma + notas[i];
            }
            double media = soma / 4;
            Console.WriteLine("A média é:" + media);
        }
    }
}
