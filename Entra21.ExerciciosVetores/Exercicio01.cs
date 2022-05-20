using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.ExerciciosVetores
{
    internal class Exercicio01
    {
        public void Executar()
        {
            int soma = 0;
            int[] numeros = new int[16];
            for(var i = 0; i < numeros.Length; i++)
            {
                Console.Write("Digite um numero: ");
                numeros[i] = Convert.ToInt32(Console.ReadLine());

            }
            for(var i = 0; i < numeros.Length; i++)
            {
                soma = soma + numeros[i];
            }
            Console.WriteLine("A soma dos números é: " + soma);
        }
    }
}
