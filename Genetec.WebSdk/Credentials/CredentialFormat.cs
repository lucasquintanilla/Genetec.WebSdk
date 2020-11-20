using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Genetec.WebSdk.Credentials
{
    public class CredentialFormat
    {
        //
        // Resumen:
        //     Gets the number of bits in this Genetec.Sdk.Credentials.CredentialFormat.
        public int BitLength { get; set; }
        //
        // Resumen:
        //     Gets the unique identifier associated with this Genetec.Sdk.Credentials.CredentialFormat.
        public Guid FormatId { get; set; }
        //
        // Resumen:
        //     Gets a value indicating if this credential format is custom.
        public bool IsCustomFormat { get; set; }
        //
        // Resumen:
        //     Gets the user friendly name of this Genetec.Sdk.Credentials.CredentialFormat.
        public string Name { get; set; }
        //
        // Resumen:
        //     Gets the encoded form of the values for this Genetec.Sdk.Credentials.CredentialFormat
        //     as a string.
        //
        // Excepciones:
        //   T:System.Runtime.Serialization.SerializationException:
        //     The credential could not be encoded using the format and values provided.
        public string RawData { get; set; }
        //
        // Resumen:
        //     Gets the type of credential format represented.
        public CredentialType Type { get; set; }
        //
        // Resumen:
        //     Gets a unique identifier for this Genetec.Sdk.Credentials.CredentialFormat encoding
        //     it's data and bit length separated by a bar.
        public string UniqueId { get; set; }

        public long? MaximumCardId { get; set; }

        public string CardId { get; set; }

        public UnfixedFields UnfixedFields { get; set; }

        public Values Values { get; set; }
    }

    public class Values
    {
        [JsonProperty("item")]
        public IEnumerable<ItemKeyValue> Collection { get; set; }
    }

    public class ItemKeyValue
    {
        [JsonProperty("KeyValuePairOfSystem.StringSystem.String")]
        public KeyValuePair<string, string> KeyValuePair { get; set; }
    }

    public class UnfixedFields 
    {
        [JsonProperty("item")]
        public IEnumerable<Items9> Collection { get; set; }
    }

    public class Items9
    {
        [JsonProperty("String")]
        public string Name { get; set; }
    }
}
