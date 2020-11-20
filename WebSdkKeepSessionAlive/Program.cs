using Genetec.WebSdk;
using Genetec.WebSdk.Entities;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using System;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Threading.Tasks;

namespace WebSdkKeepSessionAlive
{
    class Program
    {
        static async Task Main(string[] args)
        {            
            Console.WriteLine($"{DateTime.Now} Start");

            var builder = new ConfigurationBuilder()
              .SetBasePath(Directory.GetCurrentDirectory())
              .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);
            IConfiguration configuration = builder.Build();

            var webSdkConfiguration = configuration.GetSection("WebSdk").Get<WebSdkConfiguration>();
            var entityGuid = configuration.GetSection("EntityGuid").Get<Guid>();
            var delay = configuration.GetSection("Delay").Get<int>();

            //var webSdk = new WebSdk(webSdkConfiguration.Server,
            //    new NetworkCredential($"{webSdkConfiguration.Username};{webSdkConfiguration.ApplicationId}",
            //    webSdkConfiguration.Password));

            WebSdk webSdk = new WebSdk();

            Stopwatch stopWatch = new Stopwatch();            

            while (true)
            {
                try
                {                    
                    stopWatch.Start();
                    Console.WriteLine();
                    Console.WriteLine($"{DateTime.Now} Consultando a WebSdk en {webSdkConfiguration.Server}...");

                    var entity = await webSdk.GetEntityBasicAsync<Entity>(entityGuid);

                    stopWatch.Stop();
                    TimeSpan ts = stopWatch.Elapsed;                    

                    string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
                        ts.Hours, ts.Minutes, ts.Seconds,
                        ts.Milliseconds / 10);

                    Console.WriteLine($"{DateTime.Now} Obtenido entity: {entity.Name} en {elapsedTime}");                    
                }
                catch (Exception e)
                {
                    Console.WriteLine($"{DateTime.Now} {e.Message}");
                }
                finally
                {
                    if (stopWatch.IsRunning)
                    {
                        stopWatch.Stop();
                    }

                    stopWatch.Reset();
                }

                Console.WriteLine($"{DateTime.Now} Esperando {delay}ms para la siguiente consulta...");
                await Task.Delay(delay);
            }
        }
    }
}
