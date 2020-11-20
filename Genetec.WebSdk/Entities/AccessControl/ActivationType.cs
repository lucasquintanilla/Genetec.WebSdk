using System;
using System.Collections.Generic;
using System.Text;

namespace Genetec.WebSdk.Entities.AccessControl
{

    //
    // Resumen:
    //     Activation types.
    public enum ActivationType
    {
        //
        // Resumen:
        //     Undefined activation type.
        Undefined = 0,
        //
        // Resumen:
        //     Never activate.
        Never = 1,
        //
        // Resumen:
        //     Activate as of a specific date.
        SpecificDate = 2
    }
}
