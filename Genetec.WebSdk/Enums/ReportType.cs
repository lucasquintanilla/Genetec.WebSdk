using System;
using System.Collections.Generic;
using System.Text;

namespace Genetec.WebSdk
{

    //
    // Resumen:
    //     Enumeration representing the different report types.
    //
    // Comentarios:
    //     Use this enumeration when calling the Genetec.Sdk.Workflows.ReportManager.CreateReportQuery(Genetec.Sdk.ReportType)
    //     method to create a new report.
    public enum ReportType
    {
        //
        // Resumen:
        //     Entity Configuration Report
        EntityConfiguration = 0,
        //
        // Resumen:
        //     Cardholder configuration report.
        CardholderConfiguration = 1,
        //
        // Resumen:
        //     Door activity report.
        DoorActivity = 2,
        //
        // Resumen:
        //     Area activity report.
        AreaActivity = 3,
        //
        // Resumen:
        //     Zone activity report.
        ZoneActivity = 4,
        //
        // Resumen:
        //     Cardholder activity report.
        CardholderActivity = 5,
        //
        // Resumen:
        //     Credential activity report.
        CredentialActivity = 6,
        //
        // Resumen:
        //     Alarm activity report.
        AlarmActivity = 7,
        //
        // Resumen:
        //     Visitor report.
        Visitor = 8,
        //
        // Resumen:
        //     Time attendance activity report.
        TimeAttendanceActivity = 9,
        //
        // Resumen:
        //     Credential configuration report.
        CredentialConfiguration = 10,
        //
        // Resumen:
        //     Video sequence report.
        VideoSequence = 11,
        //
        // Resumen:
        //     Video file report.
        VideoFile = 12,
        //
        // Resumen:
        //     Video motion report.
        VideoMotion = 13,
        //
        // Resumen:
        //     Bookmark report.
        Bookmark = 14,
        //
        // Resumen:
        //     File deletion event report.
        FileDeletionEvent = 15,
        //
        // Resumen:
        //     Report on Motion events
        MotionEvent = 16,
        //
        // Resumen:
        //     Report on recording events.
        RecordingEvent = 17,
        //
        // Resumen:
        //     Point of sale Transaction report.
        Transactions = 18,
        //
        // Resumen:
        //     Point of sale Transaction details report.
        TransactionDetails = 19,
        //
        // Resumen:
        //     License plate recognition read report.
        LprRead = 20,
        //
        // Resumen:
        //     License plate recognition hit report.
        LprHit = 21,
        //
        // Resumen:
        //     Patroller position report.
        PatrollerPositions = 22,
        //
        // Resumen:
        //     Intrusion area activity report.
        IntrusionAreaActivity = 23,
        //
        // Resumen:
        //     Incident report.
        Incident = 24,
        //
        // Resumen:
        //     Custom report.
        Custom = 25,
        //
        // Resumen:
        //     Report on Camera events.
        CameraEvent = 26,
        //
        // Resumen:
        //     Report on Asset events.
        AssetEvent = 27,
        //
        // Resumen:
        //     Report on Asset area presence.
        AssetAreaPresence = 28,
        //
        // Resumen:
        //     Audit report on entity.
        AuditTrail = 29,
        //
        // Resumen:
        //     Report on patroller daily usage.
        LpmDailyUsage = 30,
        //
        // Resumen:
        //     Report on logins for a patroller.
        LpmLoginRecorderPerPatroller = 31,
        //
        // Resumen:
        //     Report on statistics for reads/hits per day.
        LpmReadsHitsStatsPerDay = 32,
        //
        // Resumen:
        //     Report on System Health Events.
        HealthEvents = 33,
        //
        // Resumen:
        //     Visitor activity report.
        VisitorActivity = 34,
        //
        // Resumen:
        //     Report on System Health statistics.
        HealthStatistics = 35,
        //
        // Resumen:
        //     Activity trails report.
        ActivityTrails = 36,
        //
        // Resumen:
        //     License plate recognition read report.
        LprReadById = 40,
        //
        // Resumen:
        //     License plate recognition hit report.
        LprHitById = 41,
        //
        // Resumen:
        //     Elevator activity report.
        ElevatorActivity = 50,
        //
        // Resumen:
        //     Blocking video event report.
        BlockingVideoEvent = 51,
        //
        // Resumen:
        //     Video Thumbnail report.
        Thumbnail = 52,
        //
        // Resumen:
        //     Camera configuration report.
        CameraConfiguration = 53,
        //
        // Resumen:
        //     Access control unit activity report.
        AccessControlUnitActivity = 54,
        //
        // Resumen:
        //     Intrusion unit activity report.
        IntrusionUnitActivity = 55,
        //
        // Resumen:
        //     License plate recognition parking zone report.
        ParkingZoneOccupancy = 56,
        //
        // Resumen:
        //     Unused cardholder report.
        UnusedCardholders = 57,
        //
        // Resumen:
        //     Unused credential report.
        UnusedCredentials = 58,
        //
        // Resumen:
        //     Custom entity query
        CustomEntityConfiguration = 59,
        //
        // Resumen:
        //     Inventory Report.
        Inventory = 60,
        //
        // Resumen:
        //     Parking sessions report.
        ParkingSession = 61,
        //
        // Resumen:
        //     Parking session by id report.
        ParkingSessionById = 62,
        //
        // Resumen:
        //     Streamed audit trails report, allows queries to go over federations.
        AuditTrailsReport = 63,
        //
        // Resumen:
        //     Streamed audit trails report, allows queries to go over federations.
        ActivityTrailsReport = 64,
        //
        // Resumen:
        //     Parking Zone Activities
        ParkingZoneActivity = 65,
        //
        // Resumen:
        //     Archiver Statistics
        ArchiverStatisticsReport = 66,
        //
        // Resumen:
        //     Archiver transfer/transfergroup reports.
        ArchiveTransferReport = 67
    }
}
