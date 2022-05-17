using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra_21.ExercicioForEtry
{
    internal class Exercicio04
    {
        public void Executar()
        {
            var valorValido = false;
            var numero = 0;
            var textoNumerosAntes = "";
            var textoNumerosDepois = "";
            var numeroAntes = numero;
            var numeroDepois = numero;
            while(valorValido == false)
            {
                try
                {
                    Console.Write("Digite um numero: ");
                    numero = Convert.ToInt32(Console.ReadLine());
                    if((numero == 0) || (numero != 0))
                    {

                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Valor invalido");
                }
            }
            for(var i = 0; i < 50; i++)
            {
                valorValido = false;
                while(valorValido == false)
                {
                    if(numeroDepois % 2 == 1)
                    {
                        textoNumerosDepois = textoNumerosDepois + numeroDepois + "\n";
                        valorValido = true;
                    }
                    else
                    {
                        ++numeroDepois;
                    }
                }
                ++numeroDepois;
            }
        }
    }
}
