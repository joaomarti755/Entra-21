using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra_21.ExercicioForEtry
{
    internal class Exercicio06
    {
        public void Executar()
        {
            var valorValido = false;
            for(var i = 0; i < 22; i++)
            {
                Console.Write("Digite o nome: ");
                var nome = Console.ReadLine().ToLower().Trim();
                while(valorValido == false)
                {
                    try
                    {
                        Console.Write("Digite a idade: ");
                        var idade = Convert.ToInt32(Console.ReadLine());
                        valorValido = true;
                    }
                    catch(Exception ex)
                    {
                        Console.WriteLine("Valor invalido");
                    }
                }
                valorValido = false;
                while(valorValido == false)
                {
                    try{
                        Console.Write("Digite o peso: ");
                        var peso = Convert.ToDouble(Console.ReadLine());
                        valorValido = true;
                    }
                    catch(Exception ex)
                    {
                        Console.WriteLine("Valor invalido");
                    }
                }
                valorValido = false;
                while(valorValido == false)
                {
                    try
                    {
                        Console.Write("Digite o sexo( F ou M ): ");
                        var sexo = Console.ReadLine;
                        valorValido = true;
                    }
                    catch(Exception ex)
                    {
                        Console.WriteLine("Valor invalido");
                    }
                }
                valorValido = false;
                while(valorValido == false)
                {

                        Console.Write("Digite a altura: ");
                        var altura = Convert.ToDouble(Console.ReadLine());
                }
                while (valorValido == false)
                {
                        Console.Write("Digite a quantidade de gols marcados: ");
                        var quantidadeGols = Convert.ToInt32(Console.ReadLine());

                }
                while (valorValido == false)
                {
                        Console.Write("Digite a quantidade de cartões amarelos recebidos: ");
                        var quantidadeCartoesAmarelos = Convert.ToInt32(Console.ReadLine());

                }
                while (valorValido == false)
                {
                        Console.Write("Digite a quantidade de cartões vermelhos recebidos: ");
                        var quantidadeCartoesVermelhos = Convert.ToInt32(Console.ReadLine());

                }
                            
            }
        }
    }
}
