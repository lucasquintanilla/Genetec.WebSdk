using Genetec.WebSdk.Entities;
using Genetec.WebSdk.Queries;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using System;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;

namespace Genetec.WebSdk.Samples
{
    class Program
    {
        private static WebSdk _webSdk;

        static async Task Main(string[] args)
        {
            //CreateHostBuilder(args).Build().RunAsync();

            //var server = "http://192.168.50.7";
            var server = "http://190.190.249.152";
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

            try
            {
                //await CreateEntitySample(); //Si se crea una entidad ya existente dara error
                //await GetEntitySample();
                //await GetEntityByLogicalIdSample();
                await GetCardholderSample();
                //await GetCredentialSample();
                //await EntityConfigurationQuerySample();
                //await PingWebSdk();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }
        static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureAppConfiguration((hostingContext, configuration) =>
                {
                    configuration.Sources.Clear();

                    IHostEnvironment env = hostingContext.HostingEnvironment;

                    configuration
                        .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true)
                        .AddJsonFile($"appsettings.{env.EnvironmentName}.json", true, true);

                    IConfigurationRoot configurationRoot = configuration.Build();

                    var options = new WebSdkConfiguration();
                    configurationRoot.GetSection("WebSdk")
                                     .Bind(options);

                    
                    Console.WriteLine(options.Server);
                });

        private static async Task PingWebSdk()
        {
            bool success = await _webSdk.GetPingAsync();

            Console.WriteLine($"Success: {success}");
        }
        private static async Task CreateEntitySample()
        {
            var guid = await _webSdk.CreateEntityAsync("Test webSdk", EntityType.Cardholder, "LogicalId=6690,Description=Hola,EmailAddress=lquintanilla@a1-tec.com,State=Inactive");

            Console.WriteLine($"Created new entity guid: {guid}");
        }
        private static async Task EntityConfigurationQuerySample()
        {
            var entityConfigurationQuery = _webSdk.ReportManager.CreateReportQuery(ReportType.EntityConfiguration) as EntityConfigurationQuery;
            //entityConfigurationQuery.EntityTypes.Add(EntityType.User);
            entityConfigurationQuery.EntityTypes.Add(EntityType.Cardholder);
            entityConfigurationQuery.Name = "tanilla";
            entityConfigurationQuery.NameSearchMode = StringSearchMode.Contains; // Websdk default StartsWith
            //entityConfigurationQuery.Description = "";
            entityConfigurationQuery.DownloadAllRelatedData = true;
            entityConfigurationQuery.PageSize = 2; // Websdk returns x + 1 values
            //entityConfigurationQuery.LogicalId = 222221;

            var guids = await entityConfigurationQuery.QueryAsync();

            if (guids.Count() < 1)
            {
                Console.WriteLine("No se encontraron coincidencias");
                return;
            }

            foreach (var guid in guids)
            {
                Console.WriteLine(guid);
            }
        }
        private static async Task GetEntitySample()
        {
            Entity entity = await _webSdk.GetEntityAsync<Entity>(new Guid("f75bf92b-6905-4d3b-8668-1d7f10397bcd"));

            Console.WriteLine();
            Console.WriteLine("ENTITY");
            Console.WriteLine();

            Console.WriteLine($"Name:                   {entity.Name}");
            Console.WriteLine($"Guid:                   {entity.Guid}");
            Console.WriteLine($"EntityType:             {entity.EntityType}");
            Console.WriteLine($"Description:            {entity.Description}");
            Console.WriteLine($"CreatedOn:              {entity.CreatedOn}");
            Console.WriteLine($"Application:            {entity.Application}");
            Console.WriteLine($"EntitySubType:          {entity.EntitySubType}");
            Console.WriteLine($"HiddenFromUI:           {entity.HiddenFromUI}");
            Console.WriteLine($"IsDisposed:             {entity.IsDisposed}");
            Console.WriteLine($"IsInMaintenance:        {entity.IsInMaintenance}");
            Console.WriteLine($"IsMaintenanceSupported: {entity.IsMaintenanceSupported}");
            Console.WriteLine($"OwnerRole:              {entity.OwnerRole}");
            Console.WriteLine($"ModifiedOn:             {entity.ModifiedOn}");
            Console.WriteLine($"LogicalId:              {entity.LogicalId}");

            foreach (var behavior in entity.Behaviors.Collection)
            {
                Console.WriteLine($"Behavior Active:        {behavior.Behavior.Active}");
            }

            foreach (var hierarchicalChildren in entity.HierarchicalChildren.Collection)
            {
                Console.WriteLine($"HierarchicalChildren Guid: {hierarchicalChildren.Guid}");
            }

            Console.WriteLine();
            Console.WriteLine("CUSTOMFIELDS");
            Console.WriteLine();

            Console.WriteLine($"Obsolete:       {entity.CustomFields.Obsoleted}");

            foreach (var customField in entity.CustomFields.Collection)
            {
                Console.WriteLine($"Name:           {customField.CustomFieldValue.Name}");
                Console.WriteLine($"Guid:           {customField.CustomFieldValue.CustomField.Guid}");
                Console.WriteLine($"ValueType:      {customField.CustomFieldValue.ValueType}");
            }

            Console.WriteLine();
            Console.WriteLine("EVENT TO ACTIONS");
            Console.WriteLine();

            foreach (var eventToAction in entity.EventToActions.Collection)
            {
                Console.WriteLine($"Id:             {eventToAction.EventToAction.Id}");
            }

            Console.WriteLine();
            Console.WriteLine("SUPPORTTED CUSTOM EVENTS");
            Console.WriteLine();

            foreach (var customEvent in entity.SupportedCustomEvents.Collection)
            {
                Console.WriteLine($"Id:                 {customEvent.CustomEvent.Id}");
                Console.WriteLine($"Name:               {customEvent.CustomEvent.Name}");
                Console.WriteLine($"LocalCustomEvent:   {customEvent.CustomEvent.LocalCustomEvent}");
                Console.WriteLine($"Owner:              {customEvent.CustomEvent.Owner}");
                Console.WriteLine($"SourceEntityType:   {customEvent.CustomEvent.SourceEntityType}");
            }

            Console.WriteLine();
            Console.WriteLine("SUPPORTTED EVENTS");
            Console.WriteLine();

            foreach (var supportedEvents in entity.SupportedEvents.Collection)
            {
                Console.WriteLine($"Event Type:     {supportedEvents.EventType}");
            }
        }
        private static async Task GetCardholderSample()
        {
            //Guid cardholderGuid = new Guid("40a198a3-5ab4-4b76-9829-615263b70cc7"); //Lucas
            Guid cardholderGuid = new Guid("28654aac-b1db-421b-8df8-53ffc0c18df1"); //Sebas
            Cardholder cardholder = await _webSdk.GetEntityAsync<Cardholder>(cardholderGuid);

            Console.WriteLine();
            Console.WriteLine("CARDHOLDER");
            Console.WriteLine();

            Console.WriteLine($"FirstName:      {cardholder.FirstName}");
            Console.WriteLine($"LastName:       {cardholder.LastName}");
            Console.WriteLine($"State:          {cardholder.Status.State}");
            Console.WriteLine($"EmailAddress:   {cardholder.EmailAddress}");
            Console.WriteLine($"Description:    {cardholder.Description}");

            if (cardholder.Status.State == CardholderState.Active)
            {
                Console.WriteLine("Cardholder activo");
            }

            Console.WriteLine();
            Console.WriteLine("CREDENTIALS");
            Console.WriteLine();

            if (cardholder.Credentials.Collection.Count() < 1)
            {
                Console.WriteLine("Cardholder no posee credenciales");
            }

            foreach (var credential in cardholder.Credentials.Collection)
            {
                Console.WriteLine($"Credential Guid:    {credential.Guid}");
            }

            Console.WriteLine();
            Console.WriteLine("GROUPS");
            Console.WriteLine();

            if (cardholder.Groups.Collection.Count() < 1)
            {
                Console.WriteLine("Cardholder no pertenece a ningun Cardholder Group");
            }

            foreach (var group in cardholder.Groups.Collection)
            {
                Console.WriteLine($"Group Guid:         {group.Guid}");
            }

            var picture = cardholder.GetPicture();

            if (picture == null)
            {
                Console.WriteLine("Cardholder no posee foto.");
            }
            else
            {
                picture.Save("picture2.jpeg");
            }
        }
        private static async Task GetCredentialSample()
        {
            Credential credential = await _webSdk.GetEntityAsync<Credential>(new Guid("4f52839e-14ed-4d8e-9554-b671a586ff82"));

            Console.WriteLine();
            Console.WriteLine("CREDENTIAL");
            Console.WriteLine();

            Console.WriteLine($"State:          {credential.Cardholder.Status.State}");

            Console.WriteLine($"HasAccess:      {await credential.HasAccess(new Guid("aa59c96e03704b51a477c5e09355e414"), DateTime.Now.ToUniversalTime())}");

            Console.WriteLine();
            Console.WriteLine("CREDENTIAL FORMAT");
            Console.WriteLine();

            Console.WriteLine($"RawData:        {credential.Format.RawData}");
            Console.WriteLine($"FormatId:       {credential.Format.FormatId}");
            Console.WriteLine($"BitLength:      {credential.Format.BitLength}");
            Console.WriteLine($"IsCustomFormat: {credential.Format.IsCustomFormat}");
            Console.WriteLine($"Name:           {credential.Format.Name}");
            Console.WriteLine($"Type:           {credential.Format.Type}");
            Console.WriteLine($"UniqueId:       {credential.Format.UniqueId}");
            Console.WriteLine($"CardId:         {credential.Format.CardId}");
            Console.WriteLine($"MaximumCardId:  {credential.Format.MaximumCardId}");
            Console.WriteLine();

            foreach (var item in credential.Format.UnfixedFields.Collection)
            {
                Console.WriteLine(item.Name);
            }

            Console.WriteLine();

            foreach (var item in credential.Format.Values.Collection)
            {
                Console.WriteLine(item.KeyValuePair.Key);
                Console.WriteLine(item.KeyValuePair.Value);
            }
        }        
        private static async Task GetEntityByLogicalIdSample()
        {
            var cardholder = await _webSdk.GetEntityAsync<Cardholder>(6690, EntityType.Cardholder);

            Console.WriteLine($"Name: {cardholder.Name}");
        }
    }
}
