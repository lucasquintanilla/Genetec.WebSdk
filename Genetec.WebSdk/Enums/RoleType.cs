using System;
using System.Collections.Generic;
using System.Text;

namespace Genetec.WebSdk
{
    //
    // Resumen:
    //     Represent the available Security Center role types
    public enum RoleType : byte
    {
        //
        // Resumen:
        //     Role type not specified.
        None = 0,
        //
        // Resumen:
        //     Users/Cardholders authentication external system through ActiveDirectory.
        ActiveDirectory = 1,
        //
        // Resumen:
        //     Video management integration of Omnicast (Omnicast 4.x platform).
        Omnicast = 2,
        //
        // Resumen:
        //     Federation of Security Center.
        SecurityCenter = 3,
        //
        // Resumen:
        //     Video streaming management of Security Center.
        MediaRouter = 4,
        //
        // Resumen:
        //     Video management of Security Center.
        Archiver = 5,
        //
        // Resumen:
        //     Web Sdk Role of Security Center.
        WebSdk = 6,
        //
        // Resumen:
        //     Plugin management of Security Center.
        Plugin = 7,
        //
        // Resumen:
        //     License plate management
        LicensePlateManagement = 8,
        //
        // Resumen:
        //     Intrusion detection (Alarm panels)
        IntrusionDetection = 9,
        //
        // Resumen:
        //     Access manager role.
        AccessManager = 10,
        //
        // Resumen:
        //     Point of Sale role
        PointOfSale = 11,
        //
        // Resumen:
        //     Zone management
        ZoneManagement = 12,
        //
        // Resumen:
        //     Task automation role ( for emailing and printing tasks )
        TaskAutomation = 13,
        //
        // Resumen:
        //     Audit ( for Audit trail and Activity trail )
        Audit = 14,
        //
        // Resumen:
        //     Health monitoring role
        HealthMonitoring = 15,
        //
        // Resumen:
        //     Auxiliary Archiver. Role that archives without controlling cameras. It requests
        //     the streams as an client application does.
        AuxiliaryArchiver = 16,
        //
        // Resumen:
        //     Directory failover role
        DirectoryFailover = 17,
        //
        // Resumen:
        //     Role used for duplex synchronization
        SharingManager = 18,
        //
        // Resumen:
        //     Role that acts as a proxy to get media through the cloud
        MediaProxy = 19,
        //
        // Resumen:
        //     Manages cloud unit extensions PortalCoordinator has been renamed to StratocastCoordinator
        //     in 5.8 although it's the same role
        PortalCoordinator = 20,
        //
        // Resumen:
        //     Standard RTSP and HTTP interface to stream outisde of the Security Center system.
        RtspMediaRouter = 22,
        //
        // Resumen:
        //     Manages Mission Control incidents
        IncidentManager = 23,
        //
        // Resumen:
        //     Does analytic operations on the streams
        PrivacyProtector = 24,
        //
        // Resumen:
        //     Provides functionalities to help manage the unit inventory.
        UnitAssistant = 25
    }
}
