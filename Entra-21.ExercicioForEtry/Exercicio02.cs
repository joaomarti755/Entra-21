using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.ExercicioForEtry
{
    internal class Exercicio02
    {
        public void Executar()
        {
            var quantidadeCarros = 0;
            var valorValido = false;
            var somaValorCarro = 0.0;
            var somaAnoCarro = 0;
            var carrosLetraG = 0;
            var carrosLetraA = 0;
            while(valorValido == false)
            {
                try
                {
                    Console.Write("Digite a quantidade de carros: ");
                    quantidadeCarros = Convert.ToInt32(Console.ReadLine());

                    if (quantidadeCarros < 0)
                    {
                        Console.WriteLine("Valor invalido");
                    }
                    else
                    {
                        valorValido = true;
                    }
                }
                catch(Exception ex)
                {
                    Console.WriteLine("Valor invalido");
                }
            }
            for(var i = 0; i < quantidadeCarros; i++)
            {
                Console.Write("Digite o modelo do carro: ");
                var modeloCarro = Console.ReadLine().ToLower().Trim();
                var ValorCarro = 0.0;
                var anoCarro = 0;
                valorValido = false;
                while (valorValido == false)
                {
                    try
                    {
                        Console.Write("Digite o valor do carro: ");
                        ValorCarro = Convert.ToDouble(Console.ReadLine());
                        if( ValorCarro < 0)
                        {
                            Console.WriteLine("Valor invalido");
                        }
                        else
                        {
                            valorValido = true;
                        }
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
                        Console.Write("Digite o ano do carro: ");
                        anoCarro = Convert.ToInt32(Console.ReadLine());
                        if(anoCarro < 0)
                        {
                            Console.WriteLine("Valor invalido");
                        }
                        else
                        {
                            valorValido = true;
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Valor invalido");
                    }
                }
                valorValido = false;
                if (modeloCarro.StartsWith("a"))
                {
                    carrosLetraA = carrosLetraA + 1;
                }
                else if (modeloCarro.StartsWith("g"))
                {
                    carrosLetraG = carrosLetraG + 1;
                }
                somaAnoCarro = somaAnoCarro + anoCarro;
                somaValorCarro = somaValorCarro + ValorCarro;
            
            }
            var mediaAnoCarro = somaAnoCarro / quantidadeCarros;
            var mediaValorCarro = somaValorCarro / quantidadeCarros;
            Console.WriteLine("A média dos anos dos carros é: " + mediaAnoCarro);
            Console.WriteLine("A média dos valores dos carros é: " + mediaValorCarro);
            Console.WriteLine("A quantidade de carros com a letra G é: " + carrosLetraG);
            Console.WriteLine("A quantidade de carros com a letra A é: " + carrosLetraA);
        }
    }
}

