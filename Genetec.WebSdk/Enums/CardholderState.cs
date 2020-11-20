using System;
using System.Collections.Generic;
using System.Text;

namespace Genetec.WebSdk
{

    //
    // Resumen:
    //     Represent the available Synergis cardholder states
    public enum CardholderState
    {
        //
        // Resumen:
        //     Cardholder is active.
        Active = 0,
        //
        // Resumen:
        //     Cardholder is inactive.
        Inactive = 1,
        //
        // Resumen:
        //     Cardholder is expired.
        Expired = 2,
        //
        // Resumen:
        //     Cardholder is lost. This state does not apply to a cardholder.
        Lost = 3,
        //
        // Resumen:
        //     Cardholder is stolen. This state does not apply to a cardholder.
        Stolen = 4
    }
}
