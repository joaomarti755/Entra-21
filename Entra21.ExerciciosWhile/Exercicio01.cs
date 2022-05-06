using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.ExerciciosWhile
{
    internal class Exercicio01
    {
        public void Executar()
        {
            int indice = 0;

            while (indice <= 12)
            {

                Console.Write("Digite o nome da peça: ");
                string nomePeca = Console.ReadLine();

                Console.Write("Digite o valor da peça: ");
                double valorPeca = Convert.ToDouble(Console.ReadLine());

                indice = indice + 1;

            }
        }
    }
}
