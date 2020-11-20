using Genetec.WebSdk.Entities.Behaviors;
using System;

namespace Genetec.WebSdk.Entities
{
    public interface IEntity
    {
        Guid Application { get; set; }
        BehaviorCollection Behaviors { get; set; }
        DateTime CreatedOn { get; set; }
        CustomFieldValueCollection CustomFields { get; set; }
        string Description { get; set; }
        byte EntitySubType { get; set; }
        EntityType EntityType { get; set; }
        EventToActionCollection EventToActions { get; set; }
        Guid Guid { get; set; }
        bool HiddenFromUI { get; set; }
        EntityCollection HierarchicalChildren { get; set; }
        EntityCollection HierarchicalParents { get; set; }
        bool IsDisposed { get; set; }
        bool IsInMaintenance { get; set; }
        bool IsMaintenanceSupported { get; set; }
        bool IsOnline { get; set; }
        EntityCollection LinkedMaps { get; set; }
        int? LogicalId { get; set; }
        DateTime? MaintenanceEndTime { get; set; }
        string MaintenanceReason { get; set; }
        DateTime ModifiedOn { get; set; }
        string Name { get; set; }
        Guid OwnerRole { get; set; }
        RoleType OwnerRoleType { get; set; }
        State RunningState { get; set; }
        SupportedCustomEventsCollection SupportedCustomEvents { get; set; }
        SupportedEventsCollection SupportedEvents { get; set; }
        bool Synchronised { get; set; }
    }
}