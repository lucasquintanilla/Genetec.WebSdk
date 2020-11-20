using System;
using System.Collections.Generic;
using System.Text;

namespace Genetec.WebSdk.Entities.AccessControl
{

    //
    // Resumen:
    //     Expiration types.
    public enum ExpirationType
    {
        //
        // Resumen:
        //     Undefined expiration type.
        Undefined = 0,
        //
        // Resumen:
        //     Never expire.
        Never = 1,
        //
        // Resumen:
        //     Expire on a specific date.
        SpecificDate = 2,
        //
        // Resumen:
        //     Expire after a certain number of days after the first use.
        OnFirstUse = 3,
        //
        // Resumen:
        //     Expire after a certain number of days of not being used.
        WhenNotUsed = 4
    }
}
