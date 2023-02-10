using RestSharp;
using System;

namespace CalculaJuros.Services.Taxas
{
    public class TaxaService : ITaxaService
    {
        public double ObterTaxa()
        {
            var client = new RestClient(Environment.GetEnvironmentVariable("UrlTaxa"));
            var request = new RestRequest("ObterTaxa");
            var response = client.Get<double>(request);
            return response;
        }
    }
}
