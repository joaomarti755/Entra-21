using Entra21.ExerciciosOrientacaoObjeto.Exercicio02;
using FluentAssertions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Entra21.ExerciciosOrientacaoObjeto.Tests.Exercicio02
{
    public class TemperaturaTest
    {
        [Fact]
        public void Validar_CalculoCelsiusParaKelvin()
        {
            //Arranger
            var temperatura = new Temperatura();
            temperatura.TemperaturaValor = 32;

            //Act
            var valorCelsiusParaKelvin = temperatura.CalculoCelsiusParaKelvin();
            var valorEsperadoCelsiusParaKelvin = temperatura.TemperaturaValor + 273.15;

            //Assert
            valorCelsiusParaKelvin.Should().Be(valorEsperadoCelsiusParaKelvin);
        }

        [Fact]
        public void Validar_CalculoCelsiusParaFahrenheit()
        {
            //Arranger
            var temperatura = new Temperatura();
            temperatura.TemperaturaValor = 32;

            //Act
            var valorCelsiusParaFahrenheit = temperatura.CalculoCelsiusParaFahrenheit();
            var valorEsperadoCelsiusParaFahrenheit = (temperatura.TemperaturaValor * 9 / 5) + 32;

            //Assert
            valorCelsiusParaFahrenheit.Should().Be(valorEsperadoCelsiusParaFahrenheit);
        }

        [Fact]
        public void Validar_CalculoKelvinParaCelsius()
        {
            //Arranger
            var temperatura = new Temperatura();
            temperatura.TemperaturaValor = 32;

            //Act
            var valorKelvinParaCelsius = temperatura.CalculoKelvinParaCelsius();
            var valorEsperadoKelvinParaCelsius = temperatura.TemperaturaValor - 273.15;

            //Assert
            valorKelvinParaCelsius.Should().Be(valorEsperadoKelvinParaCelsius);
        }

        [Fact]
        public void Validar_CalculoKelvinParaFahrenheit()
        {
            //Arranger
            var temperatura = new Temperatura();
            temperatura.TemperaturaValor = 32;

            //Act
            var valorKelvinParaFahrenheit = temperatura.CalculoKelvinParaFahrenheit();
            var valorEsperadoKelvinParaFahrenheit = (temperatura.TemperaturaValor - 273.15) * 9 / 5 + 32;

            //Assert
            valorKelvinParaFahrenheit.Should().Be(valorEsperadoKelvinParaFahrenheit);
        }

        [Fact]
        public void Validar_CalculoFahrenheitParaCelsius()
        {
            //Arranger
            var temperatura = new Temperatura();
            temperatura.TemperaturaValor = 32;

            //Act
            var valorFahrenheitParaCelsius = temperatura.CalculoFahrenheitParaCelsius();
            var valorEsperadoFahrenheitParaCelsius = (temperatura.TemperaturaValor - 32) * 5 / 9;

            //Assert
            valorFahrenheitParaCelsius.Should().Be(valorEsperadoFahrenheitParaCelsius);
        }

        [Fact]
        public void Validar_CalculoFahrenheitParaKelvin()
        {
            //Arranger
            var temperatura = new Temperatura();
            temperatura.TemperaturaValor = 32;

            //Act
            var valorFahrenheitParaKelvin = temperatura.CalculoFahrenheitParaKelvin();
            var valorEsperadoFahrenheitParaKelvin = (temperatura.TemperaturaValor - 32) * 5 / 9 + 273.15;

            //Assert
            valorFahrenheitParaKelvin.Should().Be(valorEsperadoFahrenheitParaKelvin);
        }

    }
}
