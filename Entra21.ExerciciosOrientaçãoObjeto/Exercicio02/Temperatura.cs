using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.ExerciciosOrientacaoObjeto.Exercicio02
{
    public class Temperatura
    {
        public string TemperaturaOrigem;
        public string TemperaturaDestino;
        public double TemperaturaValor;

        public double CalculoCelsiusParaKelvin()
        {
            var calcularCelsiusParaKelvin = TemperaturaValor + 273.15;

            return calcularCelsiusParaKelvin;
        }   
        
        public double CalculoCelsiusParaFahrenheit()
        {
            var calcularCelsiusParaFahrenheit = (TemperaturaValor * 9 / 5) + 32;

            return calcularCelsiusParaFahrenheit;
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
            var calcularFahrenheitParaCelsius = (TemperaturaValor - 32) * 5 / 9;

            return calcularFahrenheitParaCelsius;
        }

        public double CalculoFahrenheitParaKelvin()
        {
            var calcularFahrenheitParaKelvin = (TemperaturaValor - 32) * 5 / 9 + 273.15;

            return calcularFahrenheitParaKelvin;
        }

    }
}
