using System;
using Taxas.Application.Shared;

namespace Taxas.Application.Taxas
{
    public class TaxasApplication : ITaxasApplication
    {
        public double ObterTaxa()
        {
            return TaxasRetorno.ObterTaxa();
        }
    }
}
