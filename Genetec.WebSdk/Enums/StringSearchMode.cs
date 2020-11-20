using System;
using System.Collections.Generic;
using System.Text;

namespace Genetec.WebSdk
{

    //
    // Resumen:
    //     Enumeration to indicate the operation used to search a string.
    public enum StringSearchMode
    {
        //
        // Resumen:
        //     A string match must start with the supplied string.
        StartsWith = 0,
        //
        // Resumen:
        //     A string match must contain the supplied string.
        Contains = 1
    }
}
