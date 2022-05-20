using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.ExerciciosVetores
{
    internal class Exercicio07
    {
        public void Executar()
        {
            string[] animais = new string[4];
            double[] alturasAnimais = new double[4];
            string animalMenorAltura = "";
            double menorAltura = double.MaxValue;
            for(var i = 0; i < animais.Length; i++)
            {
                Console.Write("Digite o nome do animal: ");
                animais[i] = Console.ReadLine().Trim();

                Console.Write("Digite a altura do animal: ");
                alturasAnimais[i] = Convert.ToDouble(Console.ReadLine());

                if(alturasAnimais[i] < menorAltura)
                {
                    menorAltura = alturasAnimais[i];
                    animalMenorAltura = animais[i];
                }
            }
            Console.WriteLine("O animal com a menor altura é: " + animalMenorAltura + " com: " + menorAltura);
        }
    }
}
