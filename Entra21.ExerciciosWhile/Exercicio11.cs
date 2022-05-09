using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.ExerciciosWhile
{
    internal class Exercicio11
    {
        public void Executar()
        {
            int operacao = 0;
            double resultado = 0;

            while(operacao != 5)
            {
                Console.WriteLine(" ______________________________________");
                Console.WriteLine("|                MENU                  |");
                Console.WriteLine("|--------------------------------------|");
                Console.WriteLine("| 1               | Somar              |");
                Console.WriteLine("|-----------------|--------------------|");
                Console.WriteLine("| 2               | Subtrair           |");
                Console.WriteLine("|-----------------|--------------------|");
                Console.WriteLine("| 3               | Multiplicar        |");
                Console.WriteLine("|-----------------|--------------------|");
                Console.WriteLine("| 4               | Dividir            |");
                Console.WriteLine("|-----------------|--------------------|");
                Console.WriteLine("| 5               | Sair               |");
                Console.WriteLine(" --------------------------------------");

                Console.Write("Digite o primeiro número: ");
                double numero1 = Convert.ToDouble(Console.ReadLine());

                Console.Write("Digite o segundo número: ");
                double numero2 = Convert.ToDouble(Console.ReadLine());

                Console.Write("Escolha a operação:");
                operacao = Convert.ToInt32(Console.ReadLine());

                Console.Clear();

                if(operacao == 1)
                {
                    resultado = numero1 + numero2;
                    Console.WriteLine(numero1 + " + " + numero2 + " = " + resultado);
                }
                else if(operacao == 2)
                {
                    resultado = numero1 - numero2;
                    Console.WriteLine(numero1 + " - " + numero2 + " = " + resultado);
                }
                else if(operacao == 3)
                {
                    resultado = numero1 * numero2;
                    Console.WriteLine(numero1 + " x " + numero2 + " = " + resultado);
                }
                else if(operacao == 4)
                {
                    resultado = numero1 / numero2;
                    Console.WriteLine(numero1 + " / " + numero2 + " = " + resultado);
                }
                else if(operacao == 5){
                    Console.WriteLine("Fim de operação");
                }
                else
                {
                    Console.WriteLine("Operação inesistente");
                }
            }
        }
    }
}
