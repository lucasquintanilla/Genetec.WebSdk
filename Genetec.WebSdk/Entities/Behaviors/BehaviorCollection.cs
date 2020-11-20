using Newtonsoft.Json;
using System.Collections.Generic;

namespace Genetec.WebSdk.Entities.Behaviors
{
    public class BehaviorCollection
    {
        [JsonProperty("item")]
        public IEnumerable<Items8> Collection { get; set; }
    }

    public class Items8
    {
        public Behavior Behavior { get; set; }
    }
}