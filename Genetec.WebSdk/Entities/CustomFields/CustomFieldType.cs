using System;
using System.Collections.Generic;
using System.Text;

namespace Genetec.WebSdk.Entities.CustomFields
{
    public class CustomFieldType
    {
        //
        // Resumen:
        //     Gets or sets the type's description.
        public string Description { get; set; }
        //
        // Resumen:
        //     Gets or sets the type's name.
        public string Name { get; set; }
        //
        // Resumen:
        //     Gets or sets the list of possible values for this type.
        [Obsolete("This list doesn't allow you to edit properly the values. Use the CustomFieldTypeValues with proper objects instead.")]
        public List<string> Values { get; set; }
        //
        // Resumen:
        //     Gets or sets the available values for this custom field type.
        public List<CustomFieldTypeValue> CustomFieldTypeValues { get; set; }
        //
        // Resumen:
        //     Gets or Sets the tpye of the values
        public CustomFieldValueType ValueType { get; set; }
    }
}
