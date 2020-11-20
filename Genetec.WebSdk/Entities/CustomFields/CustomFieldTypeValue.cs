using System;
using System.Collections.Generic;
using System.Text;

namespace Genetec.WebSdk.Entities.CustomFields
{
    public class CustomFieldTypeValue
    {
        //
        // Resumen:
        //     Unique identifier of the value. Will be used for comparison during index / value
        //     edition.
        public Guid Guid { get; set; }
        //
        // Resumen:
        //     The index used to organize the available values
        public int Index { get; set; }
        //
        // Resumen:
        //     The value itself
        public string Value { get; set; }
    }
}
