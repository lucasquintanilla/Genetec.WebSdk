using Genetec.WebSdk.XML;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace Genetec.WebSdk.Queries
{
    public class EntityConfigurationQuery : ReportQuery
    {
        //
        // Resumen:
        //     Get/Set the description. A value of null means the filter is not used.
        public string Description { get; set; }
        //
        // Resumen:
        //     Get/Set the search mode to use on the Description. Genetec.Sdk.StringSearchMode
        //public StringSearchMode DescriptionSearchMode { get; set; }
        //
        // Resumen:
        //     Downloads all related data corresponding to the entities returned by the query.
        //     Be aware that by setting this property to true, the query might take a longer
        //     time to process.
        //
        // Comentarios:
        //     If this property is set to true it is possible that results not matching the
        //     search criteria will be included in the dataset. If you wish to avoid this you
        //     must also set the Genetec.Sdk.Queries.EntityConfigurationQuery.StrictResults
        //     property to true. The guids of the related entities will still be downloaded
        //     but any extra things like their name won't be.
        public bool DownloadAllRelatedData { get; set; }
        //
        // Resumen:
        //     Get the collection of guids corresponding to entities queried.
        //public Collection<Guid> EntityGuids { get; }
        //
        // Resumen:
        //     Get the collection of entity types and subtypes queried.
        //public virtual EntityTypeCollection EntityTypeFilter { get; }
        //
        // Resumen:
        //     Used for Custom Entities, provide with list of Custom Entity Types to return.
        //public Collection<Guid> CustomEntityTypes { get; }
        //
        // Resumen:
        //     Get the IList of entity types queried. Genetec.Sdk.EntityType
        [Obsolete("Use EntityTypeFilter instead which allows you to filter on subtypes")]
        public virtual IList<EntityType> EntityTypes { get; } = new List<EntityType>();
        //
        // Resumen:
        //     Get/Set the logical Id of the entities queried. Can be Null.
        public int? LogicalId { get; set; }
        //
        // Resumen:
        //     Get/Set the maximum number of results in the query.
        //public override int MaximumResultCount { get; set; }
        //
        // Resumen:
        //     Get/Set the name of the entity in the query.
        public string Name { get; set; }
        //
        // Resumen:
        //     Get/Set the search mode to use on the Name. Genetec.Sdk.StringSearchMode
        public StringSearchMode NameSearchMode { get; set; }
        //
        // Resumen:
        //     Get/Set the guid of the owner of the entiy.
        public Guid Owner { get; set; }
        //
        // Resumen:
        //     Get/Set the page.
        public int Page { get; set; }
        //
        // Resumen:
        //     Get/Set the size of the page.
        public int PageSize { get; set; }
        //
        // Resumen:
        //     Gets or sets a value indicating if the resulting guids must match exactly the
        //     initial query. If set to false, additional guids could be returned even if they
        //     do not meet the criteria for performance reason. This is especially relevant
        //     when Genetec.Sdk.Queries.EntityConfigurationQuery.DownloadAllRelatedData is set
        //     to true.
        public bool StrictResults { get; set; }
        //
        // Resumen:
        //     Gets/set whether the query should return only the resulting guids or if it should
        //     return a full set of results. If set to true, the proxy will query only for guids,
        //     therefore reducing the load on the server but additional entity information will
        //     not be queried.
        public bool GuidsOnly { get; set; }


        public async Task<IEnumerable<Guid>> QueryAsync()
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

            var properties = GetProperties();

            var uri = $"report/EntityConfiguration?q={properties}";

            var content = await client.GetStringAsync(uri);

            XmlSerializer serializer = new XmlSerializer(typeof(RspCredentialConfiguration));
            StringReader stringReader = new StringReader(content);

            RspCredentialConfiguration rsp = (RspCredentialConfiguration)serializer.Deserialize(stringReader);

            if (rsp.Status == "ok")
            {
                var list = new List<Guid>();

                foreach (var item in rsp.QueryResult.Row)
                {
                    list.Add(new Guid(item.Cell.Value));
                }

                return list;
            }

            if (rsp.Status == "fail")
            {
                throw new Exception(XDocument.Parse(content).Root.Element("error").Element("message").Value);
            }

            throw new Exception($"Error on WebSdk Response. Content: {content}");
        }

        private string GetProperties()
        {
            List<string> properties = new List<string>();

            if (EntityTypes.Count() > 0)
            {
                StringBuilder entityTypes = new StringBuilder("EntityTypes");

                foreach (var entityType in EntityTypes)
                {
                    entityTypes.Append($"@{entityType}");
                }

                properties.Add(entityTypes.ToString());
            }

            if (!string.IsNullOrWhiteSpace(Name))
            {
                var name = $"Name={Name}";
                properties.Add(name);
            }

            if (!string.IsNullOrWhiteSpace(Description))
            {
                var description = $"Description={Description}";
                properties.Add(description);
            }

            if (PageSize > 0)
            {
                var pageSize = $"PageSize={PageSize}";
                properties.Add(pageSize);
            }

            if (LogicalId != null)
            {
                var logicalId = $"LogicalId={LogicalId}";
                properties.Add(logicalId);
            }

            if (NameSearchMode == StringSearchMode.Contains)
            {
                var nameSearchMode = $"NameSearchMode={NameSearchMode}";
                properties.Add(nameSearchMode);
            }

            if (DownloadAllRelatedData)
            {
                properties.Add("DownloadAllRelatedData");
            }

            var propertiesJoined = string.Join(",", properties);

            return propertiesJoined;
        }
    }
}
