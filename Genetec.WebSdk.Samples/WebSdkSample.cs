using Genetec.WebSdk.Entities;
using Genetec.WebSdk.Queries;
using Microsoft.Extensions.Configuration;
using System;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;

namespace Genetec.WebSdk.Samples
{
    public class WebSdkSample
    {
        private static WebSdk _webSdk;
        private IConfiguration _configuration;
        public WebSdkSample(IConfiguration configuration)
        {
            _configuration = configuration;

            var options = new WebSdkConfiguration();
            configuration.GetSection("WebSdk")
                             .Bind(options);

            Console.WriteLine(options.Port);
        }

        public async Task Run()
        {
            var server = "http://192.168.50.7";
            var port = 4590;
            var username = "lucas";
            var password = "Alsina911";
            var applicationId = "YkyMaKWncS9PKgwrp/2bnMRKmtrJdOcOV0kUxK+YjGCI/6P7tQ/k5R7tVG5H6rNS";
            var baseUri = "WebSdk";

            HttpClientHandler handler = new HttpClientHandler();
            handler.Credentials = new NetworkCredential($"{username};{applicationId}", password);

            var client = new HttpClient(handler);
            client.BaseAddress = new Uri($"{server}:{port}/{baseUri}/");

            _webSdk = new WebSdk(client);


            //await CreateEntitySample();
            //await GetEntitySample();
            //await GetCardholderSample();
            //await GetCredentialSample();
            //await EntityConfigurationQuerySample();
        }
    }
}
