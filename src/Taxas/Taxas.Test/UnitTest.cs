using NUnit.Framework;
using Taxas.Application.Shared;

namespace Taxas.Test
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [TestCase(0.01)]
        public void ValidaTaxaValida(double taxa)
        {
            Assert.IsTrue(TaxasRetorno.ObterTaxa() == taxa);
        }

        [TestCase(0.02)]
        public void ValidaTaxaInvalida(double taxa)
        {
            Assert.IsFalse(TaxasRetorno.ObterTaxa() == taxa);
        }
    }
}