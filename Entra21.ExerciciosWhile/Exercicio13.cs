using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.ExerciciosWhile
{
    internal class Exercicio13
    {
        public void Executar()
        {
            int jogadores = 0;

            while(jogadores < 22)
            {
                Console.Write("Digite o nome: ");
                string nome = Console.ReadLine();

                Console.Write("Digite a idade: ");
                int idade = Convert.ToInt32(Console.ReadLine());

                jogadores = jogadores + 1;
            }
        }
    }
}
