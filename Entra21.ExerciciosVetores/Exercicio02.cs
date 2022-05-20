using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.ExerciciosVetores
{
    internal class Exercicio02
    {
        public void Executar()
        {
            string[] nomes = new string[10];
            for(var i = 0; i < nomes.Length; i++)
            {
                Console.Write("Digite um nome: ");
                nomes[i] = Console.ReadLine().Trim();
            }
            Console.Clear();
            for(var i = 0; i < 10; i++)
            {
                Console.WriteLine(nomes[i]);
            }
        }
    }
}
