using System;
using System.Collections.Generic;
using System.Text;

namespace Genetec.WebSdk
{
    public enum EntityType : byte
    {
        //
        // Resumen:
        //     Entity type is not defined.
        None = 0,
        //
        // Resumen:
        //     Entity is an access point.
        AccessPoint = 1,
        //
        // Resumen:
        //     Entity is an access rule.
        AccessRule = 2,
        //
        // Resumen:
        //     Entity is an alarm.
        Alarm = 3,
        //
        // Resumen:
        //     Entity is an application
        Application = 4,
        //
        // Resumen:
        //     Entity is an area.
        Area = 5,
        //
        // Resumen:
        //     Entity is a camera.
        Camera = 6,
        //
        // Resumen:
        //     Entity is a cardholder.
        Cardholder = 7,
        //
        // Resumen:
        //     Entity represents a cardholder group.
        CardholderGroup = 8,
        //
        // Resumen:
        //     Entity represents a credential.
        Credential = 9,
        //
        // Resumen:
        //     Entity represents a device.
        Device = 10,
        //
        // Resumen:
        //     Entity represents a door.
        Door = 11,
        //
        // Resumen:
        //     Entity represents an elevator.
        Elevator = 12,
        //
        // Resumen:
        //     Entity is a role.
        Role = 13,
        //
        // Resumen:
        //     Entity represents an output behavior.
        OutputBehavior = 14,
        //
        // Resumen:
        //     Entity represents a partition.
        Partition = 15,
        //
        // Resumen:
        //     Entity represents a system configuration.
        SystemConfiguration = 16,
        //
        // Resumen:
        //     Entity represents a schedule.
        Schedule = 18,
        //
        // Resumen:
        //     Entity represents an access control unit.
        Unit = 19,
        //
        // Resumen:
        //     Entity represents a user.
        User = 20,
        //
        // Resumen:
        //     Entity represents a user group.
        UserGroup = 21,
        //
        // Resumen:
        //     Entity represents a visitor.
        Visitor = 22,
        //
        // Resumen:
        //     Entity represents a zone.
        Zone = 23,
        //
        // Resumen:
        //     Entity represents a macro.
        Macro = 24,
        //
        // Resumen:
        //     Entity represents a cash register.
        CashRegister = 25,
        //
        // Resumen:
        //     Report templates are replaced by User tasks
        ReportTemplate = 26,
        //
        // Resumen:
        //     Entity represents a License Plate Recognition unit.
        LprUnit = 27,
        //
        // Resumen:
        //     Entity is a patroller.
        Patroller = 28,
        //
        // Resumen:
        //     Entity represents a permit.
        Permit = 29,
        //
        // Resumen:
        //     Entity represents a hot list rule.
        HotlistRule = 30,
        //
        // Resumen:
        //     Entity represents an overtime rule.
        OvertimeRule = 31,
        //
        // Resumen:
        //     Entity represents a permit rule.
        PermitRule = 32,
        //
        // Resumen:
        //     Entity represents a shared permit rule.
        SharedPermitRule = 33,
        //
        // Resumen:
        //     Entity represents a user task.
        UserTask = 34,
        //
        // Resumen:
        //     Entity represents an intrusion area.
        IntrusionArea = 35,
        //
        // Resumen:
        //     Entity represents an intrusion unit.
        IntrusionUnit = 36,
        //
        // Resumen:
        //     Entity represents a server.
        Server = 37,
        //
        // Resumen:
        //     Entity represents an Asset.
        Asset = 38,
        //
        // Resumen:
        //     Entity represents a video unit.
        VideoUnit = 39,
        //
        // Resumen:
        //     Entity represents a file (audio, picture, etc).
        File = 40,
        //
        // Resumen:
        //     Entity represents a Monitor in Security Desk.
        Monitor = 41,
        //
        // Resumen:
        //     Entity represents a threat level
        ThreatLevel = 43,
        //
        // Resumen:
        //     Entity represents a stream.
        Stream = 44,
        //
        // Resumen:
        //     Entity represents a network.
        Network = 45,
        //
        // Resumen:
        //     Entity represents an agent.
        Agent = 46,
        //
        // Resumen:
        //     Entity represents a route.
        Route = 47,
        //
        // Resumen:
        //     Entity represents an badge template.
        Badge = 48,
        //
        // Resumen:
        //     Entity represents an camera squence.
        Sequence = 49,
        //
        // Resumen:
        //     Entity represents a TilePlugin.
        TilePlugin = 50,
        //
        // Resumen:
        //     Entity represents an parking facility.
        LprMlpiRule = 51,
        //
        // Resumen:
        //     Entity represents an Scheduled task.
        ScheduledTask = 52,
        //
        // Resumen:
        //     Entity represents an Analog monitor.
        AnalogMonitor = 53,
        //
        // Resumen:
        //     Entity represents an Analog monitor group.
        AnalogMonitorGroup = 54,
        //
        // Resumen:
        //     Entity represents a Map.
        Map = 55,
        //
        // Resumen:
        //     Entity represents a parking zone for AutoVu parking management
        ParkingZone = 56,
        //
        // Resumen:
        //     Entity represents a parking rule for AutoVu parking management
        ParkingRule = 57,
        //
        // Resumen:
        //     Entity defined by a plugin
        CustomEntity = 58,
        //
        // Resumen:
        //     Entity represents a tile layout.
        TileLayout = 59,
        //
        // Resumen:
        //     Entity represents a Door Template
        DoorTemplate = 60,
        //
        // Resumen:
        //     Entity represents an Interface of device modules used to represent Device architectures
        //     (e.g. used for Door Template mappings)
        InterfaceModuleDeviceDefinition = 61,
        //
        // Resumen:
        //     Entity represents an access control interface module
        InterfaceModule = 62,
        //
        // Resumen:
        //     Entity represents a TransferGroup
        TransferGroup = 63
    }
}
