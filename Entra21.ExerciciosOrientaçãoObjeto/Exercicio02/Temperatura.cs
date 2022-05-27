using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.ExerciciosOrientacaoObjeto.Exercicio02
{
    internal class Temperatura
    {
        public double TemperaturaOrigem;
        public double TemperaturaDestino;
        public double TemperaturaValor;

        public double CalculoCelsiusParaKelvin()
        {
            var calcularCelsiusParaKelvin = TemperaturaValor + 273.15;

            return calcularCelsiusParaKelvin;
        }
        
        public double CalculoCelsiusParaFahrenheit()
        {
            var calcularCelasiusParaFahrenheit = (TemperaturaValor * 9 / 5) + 32;

            return calcularCelasiusParaFahrenheit;
        }

        public double CalculoKelvinParaCelsius()
        {
            var calcularKelvinParaCelsius = TemperaturaValor - 273.15;

            return calcularKelvinParaCelsius;
        }

        public double CalculoKelvinParaFahrenheit()
        {
            var calcularKelvinParaFahrenheit = (TemperaturaValor - 273.15) * 9 / 5 + 32;

            return calcularKelvinParaFahrenheit;
        }

        public double CalculoFahrenheitParaCelsius()
        {
            var calcularFahrenheitParaCelsius = (TemperaturaValor - 32)
        }

    }
}
