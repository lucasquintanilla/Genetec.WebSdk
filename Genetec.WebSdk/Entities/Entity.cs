using Genetec.WebSdk.Entities.Behaviors;
using Genetec.WebSdk.Entities.CustomEvents;
using Genetec.WebSdk.Entities.CustomFields;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace Genetec.WebSdk.Entities
{
    public class Entity : IEntity
    {
        //
        // Resumen:
        //     Gets the behaviors collection of the entity.
        public BehaviorCollection Behaviors { get; set; }
        //
        // Resumen:
        //     Returns a copy of the collection of event to actions associated with the entity.
        //     If an up to date collection is required this property must be used again. A stored
        //     reference will not update dynamically.
        //
        // Valor:
        //     The event to actions.
        public EventToActionCollection EventToActions { get; set; }
        //
        // Resumen:
        //     Gets the date and time when the entity has been created.
        public DateTime CreatedOn { get; set; }
        //
        // Resumen:
        //     Gets the list of custom field's values saved for that entity only.
        //
        // Valor:
        //     The custom fields.
        //
        // Comentarios:
        //     This property does not return the Configuration of CustomFields defined in the
        //     system. It only returns the values of the CustomFields that belong to this entity.
        //     An entity may have CustomFields assosiated to it. This collection represents
        //     all the values.
        //     To get the configuration of the Custom Field itself, use the property Genetec.Sdk.Entities.SystemConfiguration.CustomFields
        [Obsolete("Please use the CustomFieldsAsync and/or the CustomFieldService")]
        public CustomFieldValueCollection CustomFields { get; set; }
        //
        // Resumen:
        //     Gets the entity description.
        public string Description { get; set; }
        //
        // Resumen:
        //     Get the entity subtype (if any)
        //
        // Comentarios:
        //     The subtype byte value matches a different enum depending on the Genetec.Sdk.Entities.Entity.EntityType.
        //     Genetec.Sdk.EntityType.AccessPoint: Genetec.Sdk.AccessPointType, Genetec.Sdk.EntityType.Camera:
        //     Genetec.Sdk.CameraSubType, Genetec.Sdk.EntityType.Device: Genetec.Sdk.DeviceType,
        //     Genetec.Sdk.EntityType.File: Genetec.Sdk.FileType, Genetec.Sdk.EntityType.LprUnit:
        //     Genetec.Sdk.LprUnitType, Genetec.Sdk.EntityType.OvertimeRule: Genetec.Sdk.OvertimeType,
        //     Genetec.Sdk.EntityType.Patroller: Genetec.Sdk.PatrollerType, Genetec.Sdk.EntityType.Stream:
        //     Genetec.Sdk.StreamType
        public byte EntitySubType { get; set; }
        //
        // Resumen:
        //     Gets the entity type.
        public EntityType EntityType { get; set; }
        //
        // Resumen:
        //     Gets the entity guid.
        public Guid Guid { get; set; }
        //
        // Resumen:
        //     Gets (or sets for owned entities) a value indicating if this entity should be
        //     hidden from the user interface.
        public bool HiddenFromUI { get; set; }
        //
        // Resumen:
        //     Gets the logical child entities of this entity.
        //
        // Comentarios:
        //     Returns an empty list for Partition entities. See Genetec.Sdk.Entities.Partition
        //     for details.
        public EntityCollection HierarchicalChildren { get; set; }
        //
        // Resumen:
        //     Gets the logical parent entities for this entity.
        //
        // Comentarios:
        //     Returns an empty list for Partition entities. See Genetec.Sdk.Entities.Partition
        //     for details.
        public EntityCollection HierarchicalParents { get; set; }
        //
        // Resumen:
        //     Gets a value indicating if the instance of the entity is disposed or not.
        public bool IsDisposed { get; set; }
        //
        // Resumen:
        //     Gets a value indicating if this entity is in maintenance mode.
        public bool IsInMaintenance { get; set; }
        //
        // Resumen:
        //     Gets a value indicating if maintenance mode is supported for this entity.
        public bool IsMaintenanceSupported { get; set; }
        //
        // Resumen:
        //     Gets a value indicating if the entity is online or not.
        //
        // Valor:
        //     true if this instance is online; otherwise, false.
        //
        // Comentarios:
        //     This property uses the running state of the entity to return true or false.
        //     When the Genetec.Sdk.Entities.Entity.RunningState is Running or Warning, this
        //     property will return true.
        //     When the Genetec.Sdk.Entities.Entity.RunningState is NotRunning, this property
        //     will return false.
        public bool IsOnline { get; set; }
        //
        // Resumen:
        //     Gets a read-only list of maps on which the entity is present.
        public EntityCollection LinkedMaps { get; set; }
        //
        // Resumen:
        //     Gets or Sets the unique ID of the entity. Can be null.
        public int? LogicalId { get; set; }
        //
        // Resumen:
        //     Gets the date and time when the entity was last modified.
        //
        // Comentarios:
        //     This property has been obsoleted. It only returns DateTime.Now.
        [Obsolete("Use an AuditTrailQuery instead.")]
        public DateTime ModifiedOn { get; set; }
        //
        // Resumen:
        //     Returns the DateTime in UTC, if there exists one, at which the entity's maintenance
        //     mode, if currently turned on, will be turned off.
        public DateTime? MaintenanceEndTime { get; set; }
        //
        // Resumen:
        //     Gets the user-specified reason why the entity is in maintenance mode.
        public string MaintenanceReason { get; set; }
        //
        // Resumen:
        //     Gets the entity name.
        public string Name { get; set; }
        //
        // Resumen:
        //     Gets the Guid of the Genetec.Sdk.Entities.Role that owns the entity.
        public Guid OwnerRole { get; set; }
        //
        // Resumen:
        //     Gets the Genetec.Sdk.RoleType of the Genetec.Sdk.Entities.Role that owns the
        //     entity.
        public RoleType OwnerRoleType { get; set; }
        //
        // Resumen:
        //     Gets or sets the running state of this entity.
        //
        // Valor:
        //     The state of the running.
        //
        // Comentarios:
        //     This property provides more information on the entity than the Genetec.Sdk.Entities.Entity.IsOnline
        //     property.
        public State RunningState { get; set; }
        //
        // Resumen:
        //     Gets the collection of CustomEvent specific to this entity type.
        //
        // Valor:
        //     The supported custom events ids.
        public SupportedCustomEventsCollection SupportedCustomEvents { get; set; }
        //
        // Resumen:
        //     Returns the supported event types for this entity.
        public SupportedEventsCollection SupportedEvents { get; set; }
        //
        // Resumen:
        //     Gets a flag indicating if the entity is synchronized. Synchronized entities are
        //     from a federation or a plugin. Synchronized entities can not be modified unless
        //     you are the owner.
        public bool Synchronised { get; set; }
        //
        // Resumen:
        //     Gets the Guid of the application that owns the entity.
        public Guid Application { get; set; }
    }
}
