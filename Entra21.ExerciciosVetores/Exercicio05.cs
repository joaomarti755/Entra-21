using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.ExerciciosVetores
{
    internal class Exercicio05
    {
        public void Executar()
        {
            double[] pesos = new double[5];
            double somaPeso = 0;
            for(var i = 0; i < pesos.Length; i++)
            {
                Console.Write("Digite o peso: ");
                pesos[i] = Convert.ToDouble(Console.ReadLine());
            }
            for(var i = 0; i < pesos.Length; i++)
            {
                somaPeso = somaPeso + pesos[i];
            }
            double mediaPeso = somaPeso / 4;

            Console.WriteLine("A soma total dos pesos é: " + somaPeso);
            Console.WriteLine("A média dos pesos é: " + mediaPeso);
        }
    }
}
