using System;
using System.Net;
using System.Text;
using System.Net.Http;
using System.Threading.Tasks;
using System.Net.Http.Headers;

using Newtonsoft.Json;

using DemoAnomalyDetector.Model;
using DemoAnomalyDetector.Helpers;

namespace DemoAnomalyDetector.Services
{
    public static class AnomalyDetectorService
    {
        private static readonly HttpClient client = CreateHttpClient();

        private static HttpClient CreateHttpClient()
        {
            var httpClient = new HttpClient();
            httpClient.BaseAddress = new Uri(Constants.Endpoint);
            httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            httpClient.DefaultRequestHeaders.Add("Ocp-Apim-Subscription-Key", Constants.SubscriptionKey);
            return httpClient;
        }

        public async static Task<PriceResult> AnalyzeData(PriceInfo info)
        {
            try
            {
                ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12 
                    | SecurityProtocolType.Tls11 | SecurityProtocolType.Tls;

                var jsonInfo = JsonConvert.SerializeObject(info);
                var content = new StringContent(jsonInfo, Encoding.UTF8, "application/json");
                var response = await client.PostAsync(Constants.DetectAnomaliesServiceURL, content);

                if (response.IsSuccessStatusCode)
                {
                    var jsonResult = await response.Content.ReadAsStringAsync();
                    var priceResult = JsonConvert.DeserializeObject<PriceResult>(jsonResult);
                    return priceResult;
                }
            }
            catch (Exception ex)
            {
            }

            return new PriceResult();
        }
    }
}
