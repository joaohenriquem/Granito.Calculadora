using CalculaJuros.Application.Calculo;
using CalculaJuros.Application.Utils;
using CalculaJuros.Core.Calculo;
using NUnit.Framework;
using System;

namespace CalculaJuros.Test
{
    public class Tests
    {

        [SetUp]
        public void Setup()
        {
        }

        [TestCase(100, 5)]
        public void ValidaCalculoJurosCompostosValido(double valorInicial, int meses)
        {
            var input = new JurosCompostos
            {
                meses = meses,
                valorInicial = valorInicial
            };

            double taxa = 0.01;

            Assert.IsTrue(Calculadora.CalculaJurosCompostos(taxa, input) == 105.1);
        }

        [TestCase(100, 6)]
        public void ValidaCalculoJurosCompostosInvalido(double valorInicial, int meses)
        {
            var input = new JurosCompostos
            {
                meses = meses,
                valorInicial = valorInicial
            };

            double taxa = 0.01;

            Assert.IsFalse(Calculadora.CalculaJurosCompostos(taxa, input) == 105.1);
        }
    }
}