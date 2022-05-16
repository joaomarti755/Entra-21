using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.ExercicioForEtry
{
    internal class Exercicio03
    {
        public void Executar()
        {
            Console.Write("Digite um numero: ");
            var numero = Convert.ToInt32(Console.ReadLine());
            var numeroTabuada = 0;
            var textoTabuada = "";
            for(var i = 0; i < 1000; i++)
            {
                ++numeroTabuada;
                var valorTabuada = numeroTabuada * numero;

                textoTabuada = textoTabuada + numeroTabuada + " x " + numero + " = " + valorTabuada + "\n";
            }
            Console.WriteLine(textoTabuada);
        }
    }
}
