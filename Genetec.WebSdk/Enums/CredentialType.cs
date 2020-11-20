using System;
using System.Collections.Generic;
using System.Text;

namespace Genetec.WebSdk
{

    //
    // Resumen:
    //     Represent the available Synergis credential types
    public enum CredentialType
    {
        //
        // Resumen:
        //     Credential Type not specified.
        None = 0,
        //
        // Resumen:
        //     Credential is input by keypad.
        Keypad = 1,
        //
        // Resumen:
        //     Credential is input using a undecoded Wiegand card.
        UndecodedWiegand = 2,
        //
        // Resumen:
        //     Credential is input by license plate recognition.
        LicensePlate = 3,
        //
        // Resumen:
        //     Credential is input by card request.
        CardRequest = 4
    }
}
