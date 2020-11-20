using System;
using System.Collections.Generic;
using System.Text;

namespace Genetec.WebSdk
{
    //
    // Resumen:
    //     Represent the available Synergis credential states
    public enum CredentialState
    {
        //
        // Resumen:
        //     Credential is active.
        Active = 0,
        //
        // Resumen:
        //     Credential is expired.
        Expired = 1,
        //
        // Resumen:
        //     Credential is inactive.
        Inactive = 2,
        //
        // Resumen:
        //     Credential is lost.
        Lost = 3,
        //
        // Resumen:
        //     Credential has been stolen.
        Stolen = 4,
        //
        // Resumen:
        //     Credential has been requested.
        Requested = 5
    }
}
