using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;
using RestSharp;
using System;

namespace juros.api.Services
{
    public static class ServiceTaxaJuros
    {
        public static double BuscaTaxaJuros()
        {
            double resp;

            try
            {
                var client = new RestClient($"{Environment.GetEnvironmentVariable("APITAXAS")}/taxaJuros");
                client.Timeout = -1;
                var request = new RestRequest(Method.GET);
                IRestResponse response = client.Execute(request);

                resp = Convert.ToDouble(response.Content.Replace(".", ","));
            }
            catch (Exception)
            {
                throw new Exception();
            }

            return resp;

        }
    }
}
