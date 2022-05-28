using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.ExerciciosOrientacaoObjeto.Exercicio02
{
    internal class ExemploTemperatura
    {
        public void Executar()
        {
            var valorValido = false;
            Temperatura temperatura = new Temperatura();
            Console.Write("Digite o tipo de temperatura de origem: ");
            temperatura.TemperaturaOrigem = Console.ReadLine().ToLower().Trim();
            Console.Write("Digite o tipo de temperatura de destino: ");
            temperatura.TemperaturaDestino = Console.ReadLine().ToLower().Trim();
            while(valorValido == false)
            {
                try
                {
                    Console.Write("Digite o valor da temperatura: ");
                    temperatura.TemperaturaValor = Convert.ToDouble(Console.ReadLine());

                    valorValido = true;
                }
                catch(Exception ex)
                {
                    Console.WriteLine("Valor invalido");
                }
            }

            if((temperatura.TemperaturaOrigem == "celsius") && (temperatura.TemperaturaDestino == "kelvin"))
            {
                Console.WriteLine($"{temperatura.CalculoCelsiusParaKelvin()} K");
            }
            else if((temperatura.TemperaturaOrigem == "celsius") && (temperatura.TemperaturaDestino == "fahrenheit"))
            {
                Console.WriteLine($"{temperatura.CalculoCelsiusParaFahrenheit()} °F");
            }
            else if ((temperatura.TemperaturaOrigem == "kelvin") && (temperatura.TemperaturaDestino == "celsius"))
            {
                Console.WriteLine($"{temperatura.CalculoKelvinParaCelsius()} °C");
            }
            else if ((temperatura.TemperaturaOrigem == "kelvin") && (temperatura.TemperaturaDestino == "fahrenheit"))
            {
                Console.WriteLine($"{temperatura.CalculoKelvinParaFahrenheit()} °F");
            }
            else if ((temperatura.TemperaturaOrigem == "fahrenheit") && (temperatura.TemperaturaDestino == "celsius"))
            {
                Console.WriteLine($"{temperatura.CalculoFahrenheitParaCelsius()} °C");
            }
            else if ((temperatura.TemperaturaOrigem == "fahrenheit") && (temperatura.TemperaturaDestino == "kelvin"))
            {
                Console.WriteLine($"{temperatura.CalculoFahrenheitParaKelvin()} °K");
            }
            else
            {
                Console.WriteLine("Operação invalida");
            }

        }
    }
}
