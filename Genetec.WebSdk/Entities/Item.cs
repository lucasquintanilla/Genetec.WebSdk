using Genetec.WebSdk.Actions;
using Genetec.WebSdk.Entities.Collections;
using Genetec.WebSdk.Entities.CustomEvents;
using Genetec.WebSdk.Entities.CustomFields;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace Genetec.WebSdk.Entities
{
    public class SupportedEventsCollection
    {
        [JsonProperty("item")]
        public IEnumerable<Item3> Collection { get; set; }
    }

    public class SupportedCustomEventsCollection
    {
        [JsonProperty("item")]
        public IEnumerable<Item10> Collection { get; set; }
    }

    public class Item10
    {
        public CustomEvent CustomEvent { get; set; }
    }

    public class Item3
    {
        public EventType EventType { get; set; }
    }

    public class EventToActionCollection
    {
        [JsonProperty("item")]
        public IEnumerable<Items7> Collection { get; set; }
    }

    public class CustomFieldValueCollection
    {
        [JsonProperty("item")]
        public IEnumerable<Items> Collection { get; set; }

        public bool Obsoleted { get; set; }
    }

    public class Items
    {
        public CustomFieldValue CustomFieldValue { get; set; }
    }

    public class Items7
    {
        public EventToAction EventToAction { get; set; }
    }
}
