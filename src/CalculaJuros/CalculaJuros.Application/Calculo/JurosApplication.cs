using CalculaJuros.Application.Utils;
using CalculaJuros.Core.Calculo;
using CalculaJuros.Services.Taxas;
using System;

namespace CalculaJuros.Application.Calculo
{
    public class JurosService : IJurosApplication
    {
        private readonly ITaxaService _taxaService;

        public JurosService(ITaxaService taxaService)
        {
            _taxaService = taxaService;
        }

        /// <summary>
        /// Calculo de Juros
        /// </summary>
        /// <param name="input"></param>
        /// <returns>double</returns>
        public double CalculaJurosCompostos(JurosCompostos input)
        {
            double taxa = _taxaService.ObterTaxa();
            return Math.Round(Calculadora.CalculaJurosCompostos(taxa, input), 2);
        }
    }
}
