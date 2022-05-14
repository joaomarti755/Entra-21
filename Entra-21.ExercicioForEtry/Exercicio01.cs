using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.ExercicioForEtry
{
    internal class Exercicio01
    {
        public void Executar()
        {
            for(var i = 0; i < 13; i++)
            {
                Console.Write("Digite o nome da peça: ");
                var nomePeca = Console.ReadLine();
                var valorValido = false;
                while(valorValido == false)
                {
                    try
                    {
                        Console.Write("Digite o preço da peça: ");
                        var precoPeca = Convert.ToDouble(Console.ReadLine());

                        if(precoPeca < 0)
                        {
                            Console.WriteLine("Valor digitado é invalido");
                            valorValido = false;
                        }
                        else
                        {
                            valorValido = true;
                        }
                    }
                    catch(Exception ex)
                    {

                    }
                }
            }
        }
    }
}
