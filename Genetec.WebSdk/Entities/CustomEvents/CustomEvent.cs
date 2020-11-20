using System;
using System.Collections.Generic;
using System.Text;

namespace Genetec.WebSdk.Entities.CustomEvents
{
    public class CustomEvent
    {

        //
        // Resumen:
        //     Gets the unique Id of the custom event.
        //
        // Comentarios:
        //     If the Genetec.Sdk.Entities.CustomEvents.CustomEvent was built with Genetec.Sdk.Entities.CustomEvents.ICustomEventBuilder,
        //     the Id will be unassigned (0) until it is added with Genetec.Sdk.Entities.CustomEvents.ICustomEventService.Add(Genetec.Sdk.Entities.CustomEvents.CustomEvent).
        public int Id { get; set; }
        //
        // Resumen:
        //     Gets a value indicating if the Genetec.Sdk.Entities.CustomEvents.CustomEvent
        //     was created on the local system or on an external system.
        //
        // Valor:
        //     true if the Genetec.Sdk.Entities.CustomEvents.CustomEvent is local; otherwise,
        //     false.
        //
        // Comentarios:
        //     Only local and plugin custom events can be deleted.
        public bool LocalCustomEvent { get; set; }
        //
        // Resumen:
        //     Gets the name of the custom event.
        public string Name { get; set; }
        //
        // Resumen:
        //     Genetec.Sdk.EntityType for wich the event can be triggered from.
        //
        // Valor:
        //     The Genetec.Sdk.EntityType of the source entity.
        public EntityType SourceEntityType { get; set; }
        //
        // Resumen:
        //     Gets the owner (role) of the Genetec.Sdk.Entities.CustomEvents.CustomEvent. In
        //     the case of a plugin, it will return the Genetec.Sdk.Entities.Role.SubType.
        public Guid Owner { get; set; }
    }
}
