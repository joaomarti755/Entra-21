using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.ExerciciosComplementaresDeVetor
{
    internal class Exercicio02
    {
        public void Executar()
        {
            string[] nomes01 = new string[10];
            string[] nomes02 = new string[2];
            var valorValido = false;
            for(var i = 0; i < nomes01.Length; i++)
            {
                while(valorValido == false)
                {
                    try
                    {
                        Console.Write("Digite um nome: ");
                        nomes01[i] = Console.ReadLine();
                        valorValido = true;
                    }
                    catch(Exception ex)
                    {
                        Console.WriteLine("Valor invalido");
                    }
                }
                valorValido = false;

            }
        }
    }
}
