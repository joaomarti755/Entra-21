using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.ExercicioListas
{
    public class Exercicio03
    {
        public void Executar()
        {
            Console.Write("Digite a primeira nota: ");
            var nota1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite a segunda nota: ");
            var nota2 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite a terceira nota: ");
            var nota3 = Convert.ToDouble(Console.ReadLine());

            List<double> notas = new List<double>();
            notas.Add(nota1);
            notas.Add(nota2);
            notas.Add(nota3);

            Console.WriteLine($"{notas[0]}\n{notas[1]}\n{notas[2]}");

            var media = (nota1 + nota2 + nota3) / 3;

            if (media >= 7)
            {
                Console.WriteLine($"Aprovado a média foi {media}");
            }
            else
            {
                Console.WriteLine($"Reprovado a média foi {media}");
            }
        }
    }
}
