using System;
using System.Collections.Generic;
using System.Text;

namespace Genetec.WebSdk.Entities.Collections
{

    //
    // Resumen:
    //     Represents an event to action configuration
    public class EventToAction
    {
        //
        // Resumen:
        //     Action generated on event
        public Action Action { get; set; }
        //
        // Resumen:
        //     ID of the event to action
        public int Id { get; set; }
        //
        // Resumen:
        //     Type of the event
        public EventType EventType { get; set; }
        //
        // Resumen:
        //     Id of Custom Event
        public int? CustomEventId { get; set; }
        //
        // Resumen:
        //     The condition for a custom event
        public string CustomCondition { get; set; }
    }
}
