using Genetec.WebSdk;
using Genetec.WebSdk.Entities;
using Genetec.WebSdk.Queries;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Reflection.Metadata.Ecma335;
using System.Threading.Tasks;

namespace UADETotemApp
{
    class Program
    {
        private static WebSdk _webSdk;
        private static readonly Guid UADE40BitsFormatId = new Guid("c74dbca83bca4b548e1181d8d4bfa28e");
        private static readonly int UADE40BitsFormatBitLength = 40;
        private static readonly Guid group1Guid = new Guid("2e2d2f1c340b4d0fbb55068783a362ed");
        private static readonly Guid group2Guid = new Guid("62c73da6e16e4acd8a4cb9fbdd68fe32");

        static async Task Main(string[] args)
        {
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
                await UADESample();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        private static async Task UADESample()
        {
            string legajo = "1234561";

            Console.WriteLine($"Buscando cardholder con legajo: {legajo}...");

            var cardholder = await GetCardholder(legajo);

            if (cardholder == null)
            {
                Console.WriteLine("No se encontró cardholder.");
                return;
            }

            if (cardholder.Status.State != CardholderState.Active)
            {
                Console.WriteLine("Cardholder no activo.");
                return;
            }

            if (cardholder.Credentials.Collection.Count() < 1)
            {
                Console.WriteLine("Cardholder no posee credenciales");
                return;
            }

            var idUsuario = GetIdUsuario(cardholder);

            Console.WriteLine($"IdUsuario:{idUsuario}");

            var credentials = await GetCredentials(cardholder);

            var credentialsUADE = GetUADECredentials(credentials);

            if (credentialsUADE.Count() < 1)
            {
                Console.WriteLine("Cardholder no posee credenciales UADE");
                return;
            }

            string credentialQRName = $"QR-{idUsuario}";
            string credentialFPName = $"FP-{idUsuario}";

            var credentialMain = credentialsUADE.FirstOrDefault(x => x.Name != credentialFPName && x.Name != credentialQRName);
            var credentialQR = credentialsUADE.FirstOrDefault(x => x.Name == credentialQRName);

            if (credentialMain == null)
            {
                Console.WriteLine("Cardholder no posee credencial principal");
                return;
            }
            
            if (credentialMain.Status.State != CredentialState.Active)
            {
                Console.WriteLine("Cardholder no posee credencial principal activa");
                return;
            }

            var mustCardholderValidateAccess = MustCardholderValidateAccess(cardholder);

            if (mustCardholderValidateAccess)
            {
                var credentialUsedToday = CredentialUsedToday(credentialMain);

                if (credentialUsedToday)
                {
                    Console.WriteLine("Cardholder utilizó la credencial principal el día de hoy");
                    return;
                }
            }

            if (credentialQR == null)
            {
                var qrCodeCreated = DateTime.UtcNow.ToString("HHmmssyyMMdd");

                var format = GetCustomCredentialFormat(qrCodeCreated);

                var guid = await _webSdk.CreateEntityAsync(credentialQRName, EntityType.Credential, $"Format={format}");

                Console.WriteLine($"Creada nueva credencial guid: {guid} | QRCode: {qrCodeCreated}");
                return;
            }

            if (credentialQR.Status.State != CredentialState.Active)
            {
                Console.WriteLine("Cardholder posee credencial QR, pero no está activa");
                return;
            }

            var qrCode = credentialQR.Format.Values.Collection.FirstOrDefault(x => x.KeyValuePair.Key == "ID").KeyValuePair.Value;

            if (!string.IsNullOrWhiteSpace(qrCode))
            {
                Console.WriteLine($"Obtenido QRCode: {qrCode}");
                return;
            }
            
            Console.WriteLine("Cardholder no cumple los requisitos para generar una credencial QR");
            return;
        }
        private static bool CredentialUsedToday(Credential credentialMain)
        {
            DateTime Now = DateTime.UtcNow;
            var dateFrom = new DateTime(Now.Year, Now.Month, Now.Day, 0, 0, 1).ToString("yyyy-MM-ddTHH:mm:ss");
            var dateTo = DateTime.UtcNow.ToString("yyyy-MM-ddTHH:mm:ss");

            var query = $"report/CredentialActivity?q=Credentials@{credentialMain.Guid},TimeRange.SetTimeRange({dateFrom}-3:00,{dateTo}-3:00)";

            throw new NotImplementedException();
        }
        private static bool MustCardholderValidateAccess(Cardholder cardholder)
        {
            foreach (var group in cardholder.Groups.Collection)
            {
                if (group.Guid == group1Guid || group.Guid == group2Guid)
                {
                    return false;
                }
            }
            
            return true;
        }
        private static async Task<IEnumerable<Credential>> GetCredentials(Cardholder cardholder)
        {
            List<Credential> credentials = new List<Credential>();

            foreach (var credentialGuid in cardholder.Credentials.Collection)
            {
                Credential credential = await _webSdk.GetEntityAsync<Credential>(credentialGuid.Guid);
                credentials.Add(credential);
            }

            return credentials;
        }
        private static async Task<Cardholder> GetCardholder(string legajo)
        {
            //Busco cardholder por legajo
            var entityConfigurationQuery = _webSdk.ReportManager.CreateReportQuery(ReportType.EntityConfiguration) as EntityConfigurationQuery;
            entityConfigurationQuery.EntityTypes.Add(EntityType.Cardholder);
            entityConfigurationQuery.Description = legajo;
            var guids = await entityConfigurationQuery.QueryAsync();

            if (guids.Count() < 1)
            {
                return null;
            }

            foreach (var guid in guids)
            {
                var cardholder = await _webSdk.GetEntityAsync<Cardholder>(guid);

                if (cardholder.Description == legajo)
                {
                    return cardholder;
                }
            }

            return null;
        }
        private static string ConvertToRawData(string id)
        {
            String ceros = "00000000000000000000000000000000000000";

            String binarioDecimalExcel = Convert.ToString(long.Parse(id), 2);

            if (binarioDecimalExcel.Length < 38)
            {
                binarioDecimalExcel = ceros.Substring(0, 38 - binarioDecimalExcel.Length) + binarioDecimalExcel;
            }

            // La parte Even debe medirse en los primeros 20
            int totalUnos = binarioDecimalExcel.Substring(0, 19).Count(c => c == '1');

            if (totalUnos % 2 == 0)
            {
                //  La cantidad es par (even)
                binarioDecimalExcel = "0" + binarioDecimalExcel;
            }
            else
            {   // La cantidad es impar (odd)
                binarioDecimalExcel = "1" + binarioDecimalExcel;
            }

            totalUnos = binarioDecimalExcel.Count(c => c == '1');
            if (totalUnos % 2 == 0)
            {
                //  La cantidad es par (even)
                binarioDecimalExcel = binarioDecimalExcel + "1";
            }
            else
            {   // La cantidad es impar (odd)
                binarioDecimalExcel = binarioDecimalExcel + "0";
            }

            String rawHexaCredential = Convert.ToInt64(binarioDecimalExcel, 2).ToString("X");

            if (rawHexaCredential.Length < 10)
            {
                rawHexaCredential = ceros.Substring(0, 10 - rawHexaCredential.Length) + rawHexaCredential;
            }

            return rawHexaCredential;
        }
        private static string GetCustomCredentialFormat(string credentialId)
        {
            int bitLength = UADE40BitsFormatBitLength;
            Guid formatId = UADE40BitsFormatId;
            string rawData = ConvertToRawData(credentialId);

            string format = $"<UndecodedWiegand><BitLength>{bitLength}</BitLength>" +
                            $"<FormatType>{formatId}</FormatType>" +
                            $"<Raw>{rawData}</Raw></UndecodedWiegand>";

            return format;
        }
        private static string GetIdUsuario(Cardholder cardholder)
        {
            return (string)cardholder.CustomFields.Collection.First(x => x.CustomFieldValue.Name == "IDUsuario").CustomFieldValue.Value;
        }
        private static IEnumerable<Credential> GetUADECredentials(IEnumerable<Credential> credentials)
        {
            return credentials.Where(x => x.Format.FormatId == UADE40BitsFormatId);
        }
    }
}
