using System;
using System.Collections.Generic;
using System.Text;

namespace Genetec.WebSdk.Entities.CustomFields
{
    public class CustomFieldValue
    {
        //
        // Resumen:
        //     Gets the custom field associated to this value.
        public CustomField CustomField { get; set; }
        //
        // Resumen:
        //     Gets the name of the custom field.
        public string Name { get; set; }
        //
        // Resumen:
        //     Gets the value type of the custom field.
        public CustomFieldValueType ValueType { get; set; }
        //
        // Resumen:
        //     Gets or sets the Genetec.Sdk.Entities.Entity custom field's value
        //
        // Comentarios:
        //     There are performance considerations when working with multiple custom fields
        //     on multiple entities (e.g. 25 custom fields on 10 000 entities). This property
        //     is optimized for reads. The write operation is slower. If your application requires
        //     writing to multiple custom fields, consider reading the custom field value, comparing
        //     with the value to set, writing the value only if there is a change. Has for everything
        //     related with transactions inside of the SDK, this should not be called inside
        //     of a async lambda. Otherwise, multiple transaction will be called.
        public object Value { get; set; }
    }
}
