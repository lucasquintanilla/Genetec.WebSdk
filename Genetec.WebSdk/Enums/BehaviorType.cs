using System;
using System.Collections.Generic;
using System.Text;

namespace Genetec.WebSdk
{
    //
    // Resumen:
    //     Represent the available door behavior types
    public enum BehaviorType
    {
        //
        // Resumen:
        //     Behavior type is not defined.
        None = 0,
        //
        // Resumen:
        //     Door opened for too long.
        DoorOpenedForTooLong = 1,
        //
        // Resumen:
        //     Door forced open.
        DoorForcedOpen = 2,
        //
        // Resumen:
        //     Door request to exit enabled.
        DoorRexEnabled = 3,
        //
        // Resumen:
        //     Door maintenance mode.
        DoorMaintenanceMode = 4
    }
}
