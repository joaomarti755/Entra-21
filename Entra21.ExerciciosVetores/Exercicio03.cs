using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.ExerciciosVetores
{
    internal class Exercicio03
    {
        public void Executar()
        {
            string[] nomesProdutos = new string[7];
            double[] valoresProdutos = new double[7];
            
            for(var i = 0; i < nomesProdutos.Length; i++)
            {
                Console.Write("Digite o nome do produto: ");
                nomesProdutos[i] = Console.ReadLine().Trim();

                Console.Write("Digte o valor do produto: ");
                valoresProdutos[i] = Convert.ToDouble(Console.ReadLine());
            }
            Console.Clear();
            for(var i = 0; i < 7; i++)
            {
                Console.WriteLine(nomesProdutos[i] + " : R$:" + valoresProdutos[i] + "\n");
            }
        }
    }
}
