using System;
using System.Collections.Generic;
using System.Text;

namespace Genetec.WebSdk.Entities.CustomFields
{
    public class CustomField
    {
        //
        // Resumen:
        //     Gets the entity type that this Genetec.Sdk.Entities.CustomFields.CustomField
        //     is for.
        public EntityType EntityType { get; set; }
        //
        // Resumen:
        //     Gets a value indicating whether this Genetec.Sdk.Entities.CustomFields.CustomField
        //     is unique.
        //
        // Valor:
        //     true if unique; otherwise, false.
        public bool Unique { get; set; }
        //
        // Resumen:
        //     Gets a value indicating if the custom field must be shown in reports' columns.
        public bool ShowInReports { get; set; }
        //
        // Resumen:
        //     Gets the owner guid of the custom field. Returns Guid.Empty if local.
        public Guid Owner { get; set; }
        //
        // Resumen:
        //     Gets the name of the Genetec.Sdk.Entities.CustomFields.CustomField.
        public string Name { get; set; }
        //
        // Resumen:
        //     Gets a value indicating whether this Genetec.Sdk.Entities.CustomFields.CustomField
        //     is mandatory.
        //
        // Valor:
        //     true if mandatory; otherwise, false.
        public bool Mandatory { get; set; }
        //
        // Resumen:
        //     Gets the Genetec.Sdk.Entities.CustomFields.CustomField instance Genetec.Sdk.Entities.CustomFields.CustomField.Guid.
        public Guid Guid { get; set; }
        //
        // Resumen:
        //     Represents the layout priority of the custom field in the group
        public int GroupPriority { get; set; }
        //
        // Resumen:
        //     Represents the group name to which the custom field belongs.
        public string GroupName { get; set; }
        //
        // Resumen:
        //     Gets the Genetec.Sdk.Entities.CustomFields.CustomField instance supported Genetec.Sdk.CustomFieldValueType.
        public CustomFieldValueType ValueType { get; set; }
        //
        // Resumen:
        //     Gets the custom data type associated with this custom field.
        //
        // Devuelve:
        //     null if the current custom field uses a native data type or if access to system
        //     configuration entity is denied.
        public CustomFieldType CustomDataType { get; set; }
        //
        // Resumen:
        //     Gets or sets the default value of the Genetec.Sdk.Entities.CustomFields.CustomField.
        public object DefaultValue { get; set; }
        //
        // Resumen:
        //     Gets the Genetec.Sdk.Entities.CustomEntityTypeDescriptor.Id that this Genetec.Sdk.Entities.CustomFields.CustomField
        //     is for.
        public Guid? CustomEntityTypeId { get; set; }
    }
}
