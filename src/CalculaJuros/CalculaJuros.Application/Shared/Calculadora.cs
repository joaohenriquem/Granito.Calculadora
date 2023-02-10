using CalculaJuros.Core.Calculo;
using System;

namespace CalculaJuros.Application.Utils
{
    public static class Calculadora
    {
        public static double CalculaJurosCompostos(double taxa, JurosCompostos input)
        {
            double montante = input.valorInicial * Math.Pow((1 + taxa), input.meses);
            return Math.Round(montante, 2);
        }
    }
}
