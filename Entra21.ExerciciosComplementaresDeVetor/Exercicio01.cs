using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.ExerciciosComplementaresDeVetor
{
    internal class Exercicio01
    {
        public void Executar()
        {
            int[] numeros = new int[10];
            var valorValido = false;
            for (var i = 0; i < numeros.Length; i++)
            {
                while (valorValido == false)
                {
                    try
                    {
                        Console.Write("Digite um numero par: ");
                        numeros[i] = Convert.ToInt32(Console.ReadLine());
                        if (numeros[i] % 2 == 0)
                        {
                            valorValido = true;
                        }
                        else
                        {
                            Console.WriteLine("Valor invalido");
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Valor Invalido");
                    }
                }
                valorValido = false;
            }
        }
    }
}
