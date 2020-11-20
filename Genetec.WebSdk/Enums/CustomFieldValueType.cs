using System;
using System.Collections.Generic;
using System.Text;

namespace Genetec.WebSdk
{
    //
    // Resumen:
    //     Represent the different types of values supported by custom fields
    public enum CustomFieldValueType
    {
        //
        // Resumen:
        //     Custom field is text.
        Text = 0,
        //
        // Resumen:
        //     Custom field is numeric.
        Numeric = 1,
        //
        // Resumen:
        //     Custom field is true or false. Binary.
        Boolean = 2,
        //
        // Resumen:
        //     Custom field is a DateTime.
        DateTime = 3,
        //
        // Resumen:
        //     Custom field is a decimal value.
        Decimal = 4,
        //
        // Resumen:
        //     Custom field is an image
        Image = 5,
        //
        // Resumen:
        //     Custom field is a Security Center entity.
        Entity = 6,
        //
        // Resumen:
        //     Custom field is a Date.
        Date = 7
    }
}
