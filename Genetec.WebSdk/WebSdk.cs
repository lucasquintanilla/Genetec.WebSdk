using Genetec.WebSdk.Entities;
using Genetec.WebSdk.Queries;
using Genetec.WebSdk.Workflows;
using Genetec.WebSdk.XML;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace Genetec.WebSdk
{
    public class WebSdk
    {
        private readonly HttpClient _client;

        public WebSdk() { }

        public WebSdk(HttpClient client)
        {
            _client = client;
        }

        public ReportManager ReportManager { get => new ReportManager(); }

        public async Task<bool> GetPingAsync()
        {
            _client.DefaultRequestHeaders.Accept.Clear();
            _client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/jsonrequest"));

            var content = await _client.GetStringAsync(string.Empty);
            dynamic jsonObject = JsonConvert.DeserializeObject<dynamic>(content);

            if (jsonObject["rsp"]["status"].ToString() == "ok")
            {
                return true;
            }

            if (jsonObject["rsp"]["status"] == "fail")
            {
                var error = (Error)jsonObject["rsp"]["error"].ToObject<Error>();

                throw new Exception($"WebSdk Response Status: fail | Code: {error.Code} | Message: {error.Message}");
            }

            throw new Exception($"Error on WebSdk Response. Content: {content}");
        }

        public async Task<TEntity> GetEntityAsync<TEntity>(Guid guid) where TEntity : Entity
        {
            var uri = $"entity/{guid}";

            return await GetEntityAsync<TEntity>(uri);
        }

        public async Task<TEntity> GetEntityAsync<TEntity>(int logicalId, EntityType entityType) where TEntity : Entity
        {

            if (logicalId > 9999999 || logicalId < 1)
            {
                throw new ArgumentOutOfRangeException(nameof(logicalId));
            }

            var uri = $"entity/LogicalID({entityType},{logicalId})";

            return await GetEntityAsync<TEntity>(uri);
        }

        public async Task<TEntity> GetEntityBasicAsync<TEntity>(Guid guid) where TEntity : Entity
        {
            var uri = $"entity/basic/{guid}";

            return await GetEntityAsync<TEntity>(uri);
        }        

        public async Task<Guid> CreateEntityAsync(string name, EntityType entityType)
        {
            var uri = $"entity?q=entity=NewEntity({entityType}),Name={name},guid";

            return await CreateEntityAsync(uri);            
        }

        public async Task<Guid> CreateEntityAsync(string name, EntityType entityType, string properties)
        {
            var uri = $"entity?q=entity=NewEntity({entityType}),Name={name},{properties},guid";

            return await CreateEntityAsync(uri);
        }

        public async Task DeleteEntityAsync(Guid guid)
        {
            _client.DefaultRequestHeaders.Accept.Clear();
            _client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/jsonrequest"));

            var response = await _client.DeleteAsync($"entity/{guid}");

            var content = await response.Content.ReadAsStringAsync();

            dynamic jsonObject = JsonConvert.DeserializeObject<dynamic>(content);

            if (jsonObject["rsp"]["status"] == "ok")
            {
                return;
            }

            if (jsonObject["rsp"]["status"] == "fail")
            {
                var error = (Error)jsonObject["rsp"]["error"].ToObject<Error>();

                throw new Exception($"WebSdk Response Status: fail | Code: {error.Code} | Message: {error.Message}");
            }

            throw new Exception($"Error on WebSdk Response. Content: {content}");
        }

        public async Task DeleteEntityAsync(IEntity entity)
        {
            _client.DefaultRequestHeaders.Accept.Clear();
            _client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/jsonrequest"));

            var response = await _client.DeleteAsync($"entity/{entity.Guid}");

            var content = await response.Content.ReadAsStringAsync();

            dynamic jsonObject = JsonConvert.DeserializeObject<dynamic>(content);

            if (jsonObject["rsp"]["status"] == "ok")
            {
                return;
            }

            if (jsonObject["rsp"]["status"] == "fail")
            {
                var error = (Error)jsonObject["rsp"]["error"].ToObject<Error>();

                throw new Exception($"WebSdk Response Status: fail | Code: {error.Code} | Message: {error.Message}");
            }

            throw new Exception($"Error on WebSdk Response. Content: {content}");
        }

        private async Task<TEntity> GetEntityAsync<TEntity>(string uri) where TEntity : Entity
        {
            _client.DefaultRequestHeaders.Accept.Clear();
            _client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/jsonrequest"));

            var content = await _client.GetStringAsync(uri);
            dynamic jsonObject = JsonConvert.DeserializeObject<dynamic>(content);

            if (jsonObject["rsp"]["status"].ToString() == "ok")
            {
                return jsonObject["rsp"]["entity"].ToObject<TEntity>();
            }

            if (jsonObject["rsp"]["status"] == "fail")
            {
                var error = (Error)jsonObject["rsp"]["error"].ToObject<Error>();

                throw new Exception($"WebSdk Response Status: fail | Code: {error.Code} | Message: {error.Message}");
            }

            throw new Exception($"Error on WebSdk Response. Content: {content}");
        }

        private async Task<Guid> CreateEntityAsync(string uri)
        {
            _client.DefaultRequestHeaders.Accept.Clear();
            _client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/jsonrequest"));

            var response = await _client.PostAsync(uri, null);

            var content = await response.Content.ReadAsStringAsync();

            dynamic jsonObject = JsonConvert.DeserializeObject<dynamic>(content);

            if (jsonObject["rsp"]["status"] == "ok")
            {
                return jsonObject["rsp"]["Guid"].ToObject<Guid>();
            }

            if (jsonObject["rsp"]["status"] == "fail")
            {
                var error = (Error)jsonObject["rsp"]["error"].ToObject<Error>();

                throw new Exception($"WebSdk Response Status: fail | Code: {error.Code} | Message: {error.Message}");
            }

            throw new Exception($"Error on WebSdk Response. Content: {content}");
        }
    }

    internal class Error
    {
        public string Code { get; set; }
        public string Message { get; set; }
    }
}
