using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.ExerciciosVetores
{
    internal class Exercicio06
    {
        public void Executar()
        {
            int[] idades = new int[9];
            int maioridade = int.MinValue;
            for(var i = 0; i < idades.Length; i++)
            {
                Console.Write("Digite a idade: ");
                idades[i] = Convert.ToInt32(Console.ReadLine());

                if(idades[i] > maioridade)
                {
                    maioridade = idades[i];
                }
            }
            Console.WriteLine("A maior idade é: " + maioridade);
        }
    }
}
