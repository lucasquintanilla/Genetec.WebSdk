using Genetec.WebSdk.Credentials;
using Genetec.WebSdk.Entities.AccessControl;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Genetec.WebSdk.Entities
{
    public class Credential : Entity
    {
        private HttpClient _client;

        //
        // Resumen:
        //     Gets the expiration date for this credential.
        //
        // Comentarios:
        //     Activation date can be set using ActivationMode.
        [Obsolete("Use Status.ActivationDate instead.")]
        public DateTime ActivationDate { get; set; }
        //
        // Resumen:
        //     Gets or sets the state of the credential.
        [Obsolete("Use Status.State instead.")]
        public CredentialState State { get; set; }
        //
        // Resumen:
        //     Gets or sets the format of the credential.
        public CredentialFormat Format { get; set; }
        //
        // Resumen:
        //     Gets the expiration duration for this credential.
        //
        // Comentarios:
        //     Expiration duration is in days.
        [Obsolete("Use Status.ExpirationDuration instead.")]
        public int ExpirationDuration { get; set; }
        //
        // Resumen:
        //     Gets the expiration date for this credential.
        //
        // Comentarios:
        //     Expiration date can be set using ActivationMode. If the ExpirationDate is DateTime.MinValue,
        //     it means that the entity will never expire.
        [Obsolete("Use Status.ExpirationDate instead.")]
        public DateTime ExpirationDate { get; set; }
        //
        // Resumen:
        //     Gets or Sets the Badge Template System.Guid attached to the credential. Note
        //     that the Getter and Setter will Get/Set the last selected badge template for
        //     this credential.
        public Guid BadgeTemplate { get; set; }
        //
        // Resumen:
        //     Gets or sets the cardholder guid attached to the credential.
        public Guid CardholderGuid { get; set; }
        //
        // Resumen:
        //     Gets or Sets the cardholder entity attached to the credential.
        public Cardholder Cardholder { get; set; }
        //
        // Resumen:
        //     Gets or sets the activation mode for this credential.
        [Obsolete("Use Status property instead.")]
        public ActivationMode ActivationMode { get; set; }
        //
        // Resumen:
        //     Gets the credential's access status.
        public CredentialAccessStatus Status { get; set; }
        //
        // Resumen:
        //     Gets the credential's type.
        public CredentialType Type { get; set; }

        public async Task<AccessResult> HasAccess(Guid doorSide, DateTime timestamp)
        {
            var server = "http://190.190.249.152";
            var port = 4590;
            var username = "lucas";
            var password = "Alsina911";
            var applicationId = "YkyMaKWncS9PKgwrp/2bnMRKmtrJdOcOV0kUxK+YjGCI/6P7tQ/k5R7tVG5H6rNS";
            var baseUri = "WebSdk";

            HttpClientHandler handler = new HttpClientHandler();
            handler.Credentials = new NetworkCredential($"{username};{applicationId}", password);

            _client = new HttpClient(handler);
            _client.BaseAddress = new Uri($"{server}:{port}/{baseUri}/");

            _client.DefaultRequestHeaders.Accept.Clear();
            _client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/jsonrequest"));

            //"entity?q=entity=" + CredentialGuid + ",HasAccess(" + doorSideGuid + "," + Now.ToString("yyyy-MM-ddTHH:mm:ss") + ")"
            var content = await _client.GetStringAsync($"entity?q=entity={Guid},HasAccess({doorSide},{timestamp:yyyy-MM-ddTHH:mm:ss.fff})");
            dynamic jsonObject = JsonConvert.DeserializeObject<dynamic>(content);

            if (jsonObject["rsp"]["status"].ToString() == "ok")
            {
                return jsonObject["rsp"]["HasAccess"].ToObject<AccessResult>();
            }

            if (jsonObject["rsp"]["status"] == "fail")
            {
                var error = (Error)jsonObject["rsp"]["error"].ToObject<Error>();

                throw new Exception($"WebSdk Response Status: fail | Code: {error.Code} | Message: {error.Message}");
            }

            throw new Exception($"Error on WebSdk Response. Content: {content}");
        }
    }
}
