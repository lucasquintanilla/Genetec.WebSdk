using System;
using System.Collections.Generic;
using System.Text;

namespace Genetec.WebSdk
{

    //
    // Resumen:
    //     Represent the result when checking if someone has access to a door, door side
    //     or elevator floor
    public enum AccessResult
    {
        //
        // Resumen:
        //     Can happen when the logged user does not have read right on entities involved
        //     in the access check
        Inconclusive = 0,
        //
        // Resumen:
        //     The access is denied
        Denied = 1,
        //
        // Resumen:
        //     The access is granted
        Granted = 2,
        //
        // Resumen:
        //     An error occured in the access evaluation
        Error = 3
    }
}
