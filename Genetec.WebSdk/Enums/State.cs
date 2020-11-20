using System;
using System.Collections.Generic;
using System.Text;

namespace Genetec.WebSdk
{
    //
    // Resumen:
    //     Represent the available Synergis running states of entities
    public enum State
    {
        //
        // Resumen:
        //     Represents a running entity.
        Running = 0,
        //
        // Resumen:
        //     Represents a not running entity.
        NotRunning = 1,
        //
        // Resumen:
        //     Represents an entity which is in warning.
        Warning = 2
    }
}
