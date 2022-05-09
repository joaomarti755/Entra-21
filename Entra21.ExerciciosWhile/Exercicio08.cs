using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.ExerciciosWhile
{
    internal class Exercicio08
    {
        public void Executar()
        {
            Console.Write("Digite um número: ");
            int numero = Convert.ToInt32(Console.ReadLine());

            int valorTabuada = 0;
            int numeroTabuada = 0;
            string textoTabuada = "";

            int indice = 0;

            while(indice < 1000)
            {
                numeroTabuada = numeroTabuada + 1;
                valorTabuada = numeroTabuada * numero;
                textoTabuada = textoTabuada + numeroTabuada + " x " + numero + " = " + valorTabuada + "\n"; 

                indice = indice + 1;
            }

            Console.WriteLine(textoTabuada);
        }
    }
}
