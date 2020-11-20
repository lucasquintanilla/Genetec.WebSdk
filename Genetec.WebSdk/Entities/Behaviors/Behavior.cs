using System;
using System.Collections.Generic;
using System.Text;

namespace Genetec.WebSdk.Entities.Behaviors
{
    //
    // Resumen:
    //     Class used to retrieve information about an entity behavior.
    public class Behavior
    {
        //
        // Resumen:
        //     Gets the active state of the behavior.
        public bool Active { get; set; }
        //
        // Resumen:
        //     Gets the behavior type.
        public BehaviorType Type { get; set; }
    }
}
