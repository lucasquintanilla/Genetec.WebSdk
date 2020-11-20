using System;
using System.Collections.Generic;
using System.Text;

namespace Genetec.WebSdk
{
    //
    // Resumen:
    //     Represent the available Synergis event types.
    public enum EventType
    {
        //
        // Resumen:
        //     Event type is not defined.
        None = 0,
        //
        // Resumen:
        //     Event is a manual action.
        ManualAction = 1,
        //
        // Resumen:
        //     Event is an alarm triggered event.
        AlarmTriggered = 2,
        //
        // Resumen:
        //     Event is an Alarm acknowledgment.
        AlarmAcknowledged = 3,
        //
        // Resumen:
        //     Event is an application connected.
        ApplicationConnected = 4,
        //
        // Resumen:
        //     Event is an application disconnected.
        ApplicationDisconnected = 5,
        //
        // Resumen:
        //     Event is a live camera bookmark added.
        CameraLiveBookmarkAdded = 6,
        //
        // Resumen:
        //     Event is a playback camera bookmark added.
        CameraPlaybackBookmarkAdded = 7,
        //
        // Resumen:
        //     Event signals a camera motion on.
        CameraMotionOn = 8,
        //
        // Resumen:
        //     Event signals a camera motion off.
        CameraMotionOff = 9,
        //
        // Resumen:
        //     Event is a cardholder access granted.
        CardholderAccessGranted = 10,
        //
        // Resumen:
        //     Event is a Cardholder Access Refused
        CardholderAccessRefused = 11,
        //
        // Resumen:
        //     Event is a Cardholder Walkthrough
        CardholderWalkthrough = 12,
        //
        // Resumen:
        //     Event is a Cardholder Inactive
        CardholderInactive = 13,
        //
        // Resumen:
        //     Cardholder anitpassback event.
        CardholderAntipassback = 14,
        //
        // Resumen:
        //     Custom Event
        CustomEvent = 15,
        //
        // Resumen:
        //     Unit Connected Event
        UnitConnected = 16,
        //
        // Resumen:
        //     Unit Disconnected Event
        UnitDisconnected = 17,
        //
        // Resumen:
        //     Unit AC Fail event.
        UnitACFail = 18,
        //
        // Resumen:
        //     Unit Battery Fail event.
        UnitBatFail = 19,
        //
        // Resumen:
        //     User Logged on Event.
        UserLoggedOn = 20,
        //
        // Resumen:
        //     User logged off event.
        UserLoggedOff = 21,
        //
        // Resumen:
        //     Door Request to Exit On Event
        DoorRexOn = 22,
        //
        // Resumen:
        //     Door Request to Exit Off Event.
        DoorRexOff = 23,
        //
        // Resumen:
        //     Door Opened for too Long event.
        DoorOpenedForTooLong = 24,
        //
        // Resumen:
        //     Door Pull Station Activated Event.
        DoorPullStationActivated = 25,
        //
        // Resumen:
        //     Door Pull Station set to Normal Event.
        DoorPullStationNormal = 26,
        //
        // Resumen:
        //     Door Open Event.
        DoorOpen = 27,
        //
        // Resumen:
        //     Door Close Event.
        DoorClose = 28,
        //
        // Resumen:
        //     Obsolete. Use DoorOpenWhileLockSecure.
        DoorForcedOpen = 29,
        //
        // Resumen:
        //     Door Locked Event.
        DoorLock = 30,
        //
        // Resumen:
        //     Door Unlock Event.
        DoorUnlock = 31,
        //
        // Resumen:
        //     Door Ope While Lock was secured evnt.
        DoorOpenWhileLockSecure = 32,
        //
        // Resumen:
        //     Access Unknow Credential event.
        AccessUnknownCredential = 33,
        //
        // Resumen:
        //     Access Unassigned Credential Event.
        AccessUnassignedCredential = 34,
        //
        // Resumen:
        //     Access Granted Event.
        AccessGranted = 35,
        //
        // Resumen:
        //     Access Refused Event.
        AccessRefused = 36,
        //
        // Resumen:
        //     Access for an Expired Credential Event.
        AccessExpiredCredential = 37,
        //
        // Resumen:
        //     Access for a stolen Credential event.
        AccessStolenCredential = 38,
        //
        // Resumen:
        //     Access for a lost credential event.
        AccessLostCredential = 39,
        //
        // Resumen:
        //     Access for an Inactive Credential event.
        AccessInactiveCredential = 40,
        //
        // Resumen:
        //     Access for Inactive Person Event.
        AccessInactivePerson = 41,
        //
        // Resumen:
        //     Door Tamper Event.
        DoorTamper = 42,
        //
        // Resumen:
        //     Input has occurred a short event.
        InputTroubleShort = 43,
        //
        // Resumen:
        //     Input had trouble to open event.
        InputTroubleOpen = 44,
        //
        // Resumen:
        //     First man to enter in an area event
        AreaFirstManIn = 45,
        //
        // Resumen:
        //     Last man to leave an area event.
        AreaLastManOut = 46,
        //
        // Resumen:
        //     An area Antipassback detected event.
        AreaAntipassbackDetected = 47,
        //
        // Resumen:
        //     An area antipassback is forgiven event.
        AreaAntipassbackForgiven = 48,
        //
        // Resumen:
        //     Credential Unassigned Event.
        CredentialUnassigned = 49,
        //
        // Resumen:
        //     Credential has expired event.
        CredentialExpired = 50,
        //
        // Resumen:
        //     Credential has been stolen event.
        CredentialStolen = 51,
        //
        // Resumen:
        //     Credential has been lost event.
        CredentialLost = 52,
        //
        // Resumen:
        //     Credential is inactive event.
        CredentialInactive = 53,
        //
        // Resumen:
        //     Glass has been broken in a zone event.
        ZoneGlassBreak = 54,
        //
        // Resumen:
        //     Window opened in a zone event.
        ZoneWindowOpened = 55,
        //
        // Resumen:
        //     Window closed in a zone event.
        ZoneWindowClosed = 56,
        //
        // Resumen:
        //     Dead bolt locked in a zone event.
        ZoneDeadBoltLocked = 57,
        //
        // Resumen:
        //     Dead bolt unlocked event.
        ZoneDeadBoltUnlocked = 58,
        //
        // Resumen:
        //     Zone knob in place event.
        ZoneKnobInplace = 59,
        //
        // Resumen:
        //     Zone knob rotated event.
        ZoneKnobRotated = 60,
        //
        // Resumen:
        //     Zone lock secured event.
        ZoneLockSecured = 61,
        //
        // Resumen:
        //     Lock released in a zone event.
        ZoneLockReleased = 62,
        //
        // Resumen:
        //     Macro started event.
        MacroStarted = 63,
        //
        // Resumen:
        //     Macro completed event.
        MacroCompleted = 64,
        //
        // Resumen:
        //     Macro was aborted event.
        MacroAborted = 65,
        //
        // Resumen:
        //     People count in an area is reset event.
        PeopleCountReset = 66,
        //
        // Resumen:
        //     Cardholder removed from area event.
        AreaCardholderRemoved = 68,
        //
        // Resumen:
        //     Maximum occupancy reached.
        AreaMaxOccupancyReached = 69,
        //
        // Resumen:
        //     Maximum occupancy exceeded.
        AreaMaxOccupancyExceeded = 70,
        //
        // Resumen:
        //     Below maximum occupancy .
        AreaBelowMaxOccupancy = 71,
        //
        // Resumen:
        //     Duress pin eneterd.
        AreaDuressPinEntered = 72,
        //
        // Resumen:
        //     cardholder duress pin eneterd event.
        CardholderDuressPinEntered = 73,
        //
        // Resumen:
        //     Cardholder removed from area event.
        AreaCardholderAdded = 80,
        //
        // Resumen:
        //     Event is an Alarm acknowledgment (alternate).
        AlarmAcknowledgedAlternate = 81,
        //
        // Resumen:
        //     Event is an Alarm Condition Cleared
        AlarmConditionCleared = 82,
        //
        // Resumen:
        //     Event is an Alarm Context Changed
        AlarmContextChanged = 83,
        //
        // Resumen:
        //     License plate recognition read event.
        LprRead = 256,
        //
        // Resumen:
        //     License plate recognition hit event.
        LprHit = 257,
        //
        // Resumen:
        //     Process Mlpi Results Result Event.
        ProcessMlpiResultsResultEvent = 258,
        //
        // Resumen:
        //     Patroller successfully offloaded data in LPR role's root folder.
        LprOffloadSucceeded = 259,
        //
        // Resumen:
        //     Patroller failed to offload data in LPR role's root folder.
        LprOffloadFailed = 260,
        //
        // Resumen:
        //     Patroller failed to offload data in LPR role's root folder.
        LprNoMatch = 261,
        //
        // Resumen:
        //     Hotlist has been modified.
        LprHotlistChanged = 262,
        //
        // Resumen:
        //     Intrusion Area Duress Event.
        IntrusionAreaDuress = 512,
        //
        // Resumen:
        //     Intrustion Area Entry Delay Event.
        IntrusionAreaEntryDelay = 513,
        //
        // Resumen:
        //     Intrusion Area Alarm Activated Event.
        IntrusionAreaAlarmActivated = 514,
        //
        // Resumen:
        //     Intrusion Area is Arming Event.
        IntrusionAreaArming = 515,
        //
        // Resumen:
        //     Intrusion Area Arming has been postponed event.
        IntrusionAreaArmingPostponed = 516,
        //
        // Resumen:
        //     Intrusion Area Masted Armed Event.
        IntrusionAreaMasterArmed = 517,
        //
        // Resumen:
        //     Intrusion Area Perimeter has been armed event.
        IntrusionAreaPerimeterArmed = 518,
        //
        // Resumen:
        //     Intrusion area has been disarmed event.
        IntrusionAreaDisarmed = 519,
        //
        // Resumen:
        //     Intrusion area has input trouble event.
        IntrusionAreaInputTrouble = 520,
        //
        // Resumen:
        //     Intrusion area input bypass activated event.
        IntrusionAreaInputBypassActivated = 521,
        //
        // Resumen:
        //     Intrusion area input bypass deactivated event.
        IntrusionAreaInputBypassDeactivated = 522,
        //
        // Resumen:
        //     Intrusion area forced arming event.
        IntrusionAreaForcedArming = 523,
        //
        // Resumen:
        //     Intrusion Area canceled alarm event.
        IntrusionAreaCanceledAlarm = 524,
        //
        // Resumen:
        //     Intrusion area master arm request event.
        IntrusionAreaMasterArmRequest = 525,
        //
        // Resumen:
        //     Intrusion area perimeter arm request event.
        IntrusionAreaPerimeterArmRequest = 526,
        //
        // Resumen:
        //     Intrusion area disarm request event.
        IntrusionAreaDisarmRequest = 527,
        //
        // Resumen:
        //     Intrusion area arming postponed request event.
        IntrusionAreaArmingPostponedRequest = 528,
        //
        // Resumen:
        //     Intrusion area canceled alarm request event.
        IntrusionAreaCanceledAlarmRequest = 529,
        //
        // Resumen:
        //     Intrusion area silenced alarm request event.
        IntrusionAreaAlarmSilenced = 530,
        //
        // Resumen:
        //     Zone has been armed event.
        ZoneArmed = 768,
        //
        // Resumen:
        //     Zone has been disarmed event.
        ZoneDisarmed = 769,
        //
        // Resumen:
        //     Zone Maintenance On event.
        ZoneMaintenanceOn = 770,
        //
        // Resumen:
        //     Zone Maintenance Off event.
        ZoneMaintenanceOff = 771,
        //
        // Resumen:
        //     The master unit controlling the zone is offline event.
        ZoneWarningUnitOffline = 772,
        //
        // Resumen:
        //     Door Maintenance Off event.
        DoorMaintenanceOff = 848,
        //
        // Resumen:
        //     Door Maintenance On Event.
        DoorMaintenanceOn = 849,
        //
        // Resumen:
        //     Door is scheduled to be locked event.
        DoorScheduledLock = 850,
        //
        // Resumen:
        //     Door is scheduled to be unlocked event.
        DoorScheduledUnlock = 851,
        //
        // Resumen:
        //     Door warning unit is offline event.
        DoorWarningUnitOffline = 852,
        //
        // Resumen:
        //     A Door is Manually Unlocked.
        DoorManuallyUnlocked = 853,
        //
        // Resumen:
        //     Double Swipe Unlock.
        DoorDoubleBadgeOn = 854,
        //
        // Resumen:
        //     Double Swipe Lock.
        DoorDoubleBadgeOff = 855,
        //
        // Resumen:
        //     Cardholder Double Swipe Unlock.
        CardholderDoubleBadgeOn = 856,
        //
        // Resumen:
        //     Cardholder Double Swipe Lock.
        CardholderDoubleBadgeOff = 857,
        //
        // Resumen:
        //     Credential Double Swipe Unlock.
        CredentialDoubleBadgeOn = 864,
        //
        // Resumen:
        //     Credential Double Swipe Lock.
        CredentialDoubleBadgeOff = 865,
        //
        // Resumen:
        //     Supervisor in access rule activated.
        SupervisorInAccessRuleActivated = 866,
        //
        // Resumen:
        //     Supervisor in unlocking schedule activated.
        SupervisorInUnlockingScheduleActivated = 867,
        //
        // Resumen:
        //     Video Analytics Audio Alarm event.
        VideoAnalyticsAudioAlarm = 1024,
        //
        // Resumen:
        //     Video Analytics license plate in sight event.
        VideoAnalyticsLicensePlateInSight = 1025,
        //
        // Resumen:
        //     Video analytics license plate no longer in sight event.
        VideoAnalyticsLicensePlateOutofSight = 1026,
        //
        // Resumen:
        //     Video analytics licence plate is being read event.
        VideoAnalyticsLicensePlateReading = 1027,
        //
        // Resumen:
        //     Video analytics object's condition has changed event.
        VideoAnalyticsObjectConditionChange = 1028,
        //
        // Resumen:
        //     Video Analytics object has crossed a set line event.
        VideoAnalyticsObjectCrossedLine = 1029,
        //
        // Resumen:
        //     Video analytics object has entered an area of intrest event.
        VideoAnalyticsObjectEntered = 1030,
        //
        // Resumen:
        //     Video analytics object has exited an area of intrest event.
        VideoAnalyticsObjectExited = 1031,
        //
        // Resumen:
        //     Video analytics object has fallen event.
        VideoAnalyticsObjectFall = 1032,
        //
        // Resumen:
        //     Video analytics object following a route event.
        VideoAnalyticsObjectFollowingRoute = 1033,
        //
        // Resumen:
        //     Video Analytics object is in field of view event.
        VideoAnalyticsObjectInField = 1034,
        //
        // Resumen:
        //     Video analytics object has left the area of interest event.
        VideoAnalyticsObjectLeft = 1035,
        //
        // Resumen:
        //     Video analytics object has remained in the area of interest for too long event.
        VideoAnalyticsObjectLoitering = 1036,
        //
        // Resumen:
        //     Video analytics object has merged with another object becoming on identifiable
        //     object event.
        VideoAnalyticsObjectMerged = 1037,
        //
        // Resumen:
        //     Video analytics object has been removed fro man area of interest event.
        VideoAnalyticsObjectRemoved = 1038,
        //
        // Resumen:
        //     Video analytics object is running event.
        VideoAnalyticsObjectRun = 1039,
        //
        // Resumen:
        //     video analytics object is sliding event.
        VideoAnalyticsObjectSlide = 1040,
        //
        // Resumen:
        //     Video analytics object have spit into more than one identifiable object event.
        VideoAnalyticsObjectSplit = 1041,
        //
        // Resumen:
        //     Video analytics object stopped moving event.
        VideoAnalyticsObjectStopped = 1042,
        //
        // Resumen:
        //     Video analytics tailgating discovered event.
        VideoAnalyticsTailgating = 1043,
        //
        // Resumen:
        //     Video analytics tampering has been detected event.
        VideoAnalyticsTampering = 1044,
        //
        // Resumen:
        //     Video analytics undefined event.
        VideoAnalyticsUndefined = 1045,
        //
        // Resumen:
        //     Video analytics face detected event.
        VideoAnalyticsFaceDetected = 1046,
        //
        // Resumen:
        //     Video Analytics Direction Alarm event.
        VideoAnalyticsDirectionAlarm = 1047,
        //
        // Resumen:
        //     Video Analytics Adaptive motion event.
        VideoAnalyticsAdaptiveMotion = 1048,
        //
        // Resumen:
        //     Video Analytics Object count reached event.
        VideoAnalyticsObjectCountReached = 1049,
        //
        // Resumen:
        //     Video Analytics Crowd detected event.
        VideoAnalyticsCrowdDetected = 1051,
        //
        // Resumen:
        //     Video analytics face recognized event.
        VideoAnalyticsFaceRecognized = 1052,
        //
        // Resumen:
        //     Video analytics object detected event.
        VideoAnalyticsObjectDetected = 1053,
        //
        // Resumen:
        //     Video analytics heat map changed event.
        VideoAnalyticsHeatMapChanged = 1054,
        //
        // Resumen:
        //     Video analytics object velocity changed event.
        VideoAnalyticsObjectVelocityChanged = 1055,
        //
        // Resumen:
        //     Video analytics object direction changed event.
        VideoAnalyticsObjectDirectionChanged = 1056,
        //
        // Resumen:
        //     Video analytics object count changed event.
        VideoAnalyticsObjectCountChanged = 1057,
        //
        // Resumen:
        //     Video analytics people counting event.
        VideoAnalyticsPeopleCounting = 1058,
        //
        // Resumen:
        //     Video analytics people counting alarm event.
        VideoAnalyticsPeopleCountingAlarm = 1059,
        //
        // Resumen:
        //     Video analytics tampering is off
        VideoAnalyticsTamperingOff = 1060,
        //
        // Resumen:
        //     Video analytics tampering is off
        VideoAnalyticsTemperatureDetectionOn = 1061,
        //
        // Resumen:
        //     Video analytics temperature detection is off
        VideoAnalyticsTemperatureDetectionOff = 1062,
        //
        // Resumen:
        //     Foor access granted event.
        FloorAccess = 1104,
        //
        // Resumen:
        //     Asset Moved Event
        AssetMoved = 1280,
        //
        // Resumen:
        //     Asset Low battery
        AssetLowBattery = 1281,
        //
        // Resumen:
        //     Asset Moved Event
        AssetOffline = 1282,
        //
        // Resumen:
        //     Asset Moved Event
        AssetOnline = 1283,
        //
        // Resumen:
        //     Video archiving started automatically (due to archiving schedule).
        ArchivingStartedAutomatically = 1360,
        //
        // Resumen:
        //     Video archiving stopped automatically (due to archiving schedule).
        ArchivingStoppedAutomatically = 1361,
        //
        // Resumen:
        //     Video archiving was started manually (due to start recording action in Security
        //     Desk).
        ArchivingStartedManually = 1362,
        //
        // Resumen:
        //     Video archiving was stopped manually (due to stop recording action in Security
        //     Desk).
        ArchivingStoppedManually = 1363,
        //
        // Resumen:
        //     Video archiving was started due to a motion threshold being exceeded.
        ArchivingStartedOnMotionEvent = 1364,
        //
        // Resumen:
        //     Video archiving was stopped after being started due to a motion threshold being
        //     exceeded.
        ArchivingStoppedOnMotionEvent = 1365,
        //
        // Resumen:
        //     Video archiving was started by an external source.
        ArchivingStartedByExternalSource = 1366,
        //
        // Resumen:
        //     Video archiving was stopped by an external source.
        ArchivingStoppedByExternalSource = 1367,
        //
        // Resumen:
        //     Video archiving was started due to an alarm being activated.
        ArchivingStartedByAlarm = 1368,
        //
        // Resumen:
        //     Video archiving was stopped after being started due to an alarm being activated.
        ArchivingStoppedByAlarm = 1369,
        //
        // Resumen:
        //     A video archive file was deleted by the Archiver.
        ArchiveFileDeleted = 1370,
        //
        // Resumen:
        //     The video signal for a camera was lost.
        CameraSignalLost = 1371,
        //
        // Resumen:
        //     The video signal for a camera was recovered.
        CameraSignalRecovered = 1372,
        //
        // Resumen:
        //     The archiving queue of an Archiver is full indicating a problem with the Archiver.
        ArchivingQueueFull = 1373,
        //
        // Resumen:
        //     The camera is not archiving.
        CameraNotArchiving = 1374,
        //
        // Resumen:
        //     Transmission between the camera and the archiver was lost.
        CameraTransmissionLost = 1375,
        //
        // Resumen:
        //     The camera stream lost RTP packets indicating a possible problem with video transmission.
        CameraRtpPacketsLost = 1376,
        //
        // Resumen:
        //     Multiple video sources were detected for the specified camera indicating a possible
        //     network conflict.
        CameraMultipleSourceDetected = 1377,
        //
        // Resumen:
        //     Camera blocking has started.
        CameraStartBlock = 1378,
        //
        // Resumen:
        //     Camera blocking has ended.
        CameraStopBlock = 1379,
        //
        // Resumen:
        //     Transmission between the camera and the archiver has been recovered.
        CameraTransmissionRecovered = 1380,
        //
        // Resumen:
        //     The unit did not respond to an edge playback command.
        CameraEdgeRecordingCommandTimeout = 1381,
        //
        // Resumen:
        //     The unit's edge storage medium failed or is corrupt.
        CameraEdgestorageFailure = 1382,
        //
        // Resumen:
        //     Event that indicates the motion level.
        CameraMotion = 1383,
        //
        // Resumen:
        //     The unit's edge storage state.
        CameraEdgestorageEnabled = 1384,
        //
        // Resumen:
        //     An error occurred while performing a disk action
        UnitDiskActionError = 1393,
        //
        // Resumen:
        //     Disk formatted
        UnitDiskFormatted = 1394,
        //
        // Resumen:
        //     Disk locked
        UnitDiskLocked = 1395,
        //
        // Resumen:
        //     Disk mounted
        UnitDiskMounted = 1396,
        //
        // Resumen:
        //     Disk unlocked
        UnitDiskUnlocked = 1397,
        //
        // Resumen:
        //     Disk unmounted
        UnitDiskUnmounted = 1398,
        //
        // Resumen:
        //     The PTZ of a camera was activated.
        PtzActivated = 1536,
        //
        // Resumen:
        //     The PTZ of a camera stopped moving.
        PtzStopped = 1537,
        //
        // Resumen:
        //     The zoom of a PTZ was activated by a user.
        PtzZoomByUserStarted = 1538,
        //
        // Resumen:
        //     The zoom of a PTZ activated by a user stopped.
        PtzZoomByUserStopped = 1539,
        //
        // Resumen:
        //     Ptz locked.
        PtzLocked = 1540,
        //
        // Resumen:
        //     Health monitoring event
        HealthMonitoringEvent = 1792,
        //
        // Resumen:
        //     Health monitoring event ActiveAlarms
        HealthMonitoringEventActiveAlarms = 1793,
        //
        // Resumen:
        //     Health monitoring event ActiveAlarmsRecovered
        HealthMonitoringEventActiveAlarmsRecovered = 1794,
        //
        // Resumen:
        //     Health monitoring event AgentStarted
        HealthMonitoringEventAgentStarted = 1795,
        //
        // Resumen:
        //     Health monitoring event AgentStopped
        HealthMonitoringEventAgentStopped = 1796,
        //
        // Resumen:
        //     Health monitoring event AgentStoppedUnexpectedly
        HealthMonitoringEventAgentStoppedUnexpectedly = 1797,
        //
        // Resumen:
        //     Health monitoring event AllArchivingRestarted
        HealthMonitoringEventAllArchivingRestarted = 1798,
        //
        // Resumen:
        //     Health monitoring event AllArchivingStopped
        HealthMonitoringEventAllArchivingStopped = 1799,
        //
        // Resumen:
        //     Health monitoring event ApplicationConnected
        HealthMonitoringEventApplicationConnected = 1800,
        //
        // Resumen:
        //     Health monitoring event VideoSignalLoss
        HealthMonitoringEventVideoSignalLoss = 1801,
        //
        // Resumen:
        //     Health monitoring event ApplicationDisconnectedByUser
        HealthMonitoringEventApplicationDisconnectedByUser = 1802,
        //
        // Resumen:
        //     Health monitoring event ApplicationDisconnectedUnexpectedly
        HealthMonitoringEventApplicationDisconnectedUnexpectedly = 1803,
        //
        // Resumen:
        //     Health monitoring event VideoSignalRecovered
        HealthMonitoringEventUnVideoSignalRecovered = 1804,
        //
        // Resumen:
        //     Health monitoring event ApplicationStarted
        HealthMonitoringEventApplicationStarted = 1805,
        //
        // Resumen:
        //     Health monitoring event ApplicationStoppedByUser
        HealthMonitoringEventApplicationStoppedByUser = 1806,
        //
        // Resumen:
        //     Health monitoring event ApplicationStoppedUnexpectedly
        HealthMonitoringEventApplicationStoppedUnexpectedly = 1807,
        //
        // Resumen:
        //     Health monitoring event ArchiveBackupFailure
        HealthMonitoringEventArchiveBackupFailure = 1808,
        //
        // Resumen:
        //     Health monitoring event ArchiveBackupSuccess
        HealthMonitoringEventArchiveBackupSuccess = 1809,
        //
        // Resumen:
        //     Health monitoring event ArchiveConsolidationFailure
        HealthMonitoringEventArchiveConsolidationFailure = 1810,
        //
        // Resumen:
        //     Health monitoring event ArchiveConsolidationPartialFailure
        HealthMonitoringEvenArchiveConsolidationPartialFailuret = 1811,
        //
        // Resumen:
        //     Health monitoring event ArchiveConsolidationSuccess
        HealthMonitoringEventArchiveConsolidationSuccess = 1812,
        //
        // Resumen:
        //     Health monitoring event ArchiverTricklingFailure
        HealthMonitoringEventArchiverTricklingFailure = 1813,
        //
        // Resumen:
        //     Health monitoring event ArchiverTricklingPartialFailure
        HealthMonitoringEventArchiverTricklingPartialFailure = 1814,
        //
        // Resumen:
        //     Health monitoring event ArchiverTricklingSuccess
        HealthMonitoringEventArchiverTricklingSuccess = 1815,
        //
        // Resumen:
        //     Health monitoring event CameraConnectionEstablished
        HealthMonitoringEventCameraConnectionEstablished = 1816,
        //
        // Resumen:
        //     Health monitoring event CameraConnectionStoppedByUser
        HealthMonitoringEventCameraConnectionStoppedByUser = 1817,
        //
        // Resumen:
        //     Health monitoring event CameraConnectionStoppedUnexpectedly
        HealthMonitoringEventCameraConnectionStoppedUnexpectedly = 1818,
        //
        // Resumen:
        //     Health monitoring event CameraRecordingProblem
        HealthMonitoringEventCameraRecordingProblem = 1819,
        //
        // Resumen:
        //     Health monitoring event CameraRecordingProblemRecovered
        HealthMonitoringEventCameraRecordingProblemRecovered = 1820,
        //
        // Resumen:
        //     Health monitoring event UnitTimeDrift
        HealthMonitoringEventUnitTimeDrift = 1821,
        //
        // Resumen:
        //     Health monitoring event UnitTimeDriftRecovered
        HealthMonitoringEventUnitTimeDriftRecovered = 1822,
        //
        // Resumen:
        //     Health monitoring event ConnectionFailed
        HealthMonitoringEventConnectionFailed = 1823,
        //
        // Resumen:
        //     Health monitoring event ConnectionRestored
        HealthMonitoringEventConnectionRestored = 1824,
        //
        // Resumen:
        //     Health monitoring event DatabaseAutomaticBackupFailed
        HealthMonitoringEventDatabaseAutomaticBackupFailed = 1825,
        //
        // Resumen:
        //     Health monitoring event DatabaseAutomaticBackupRecovered
        HealthMonitoringEventDatabaseAutomaticBackupRecovered = 1826,
        //
        // Resumen:
        //     Health monitoring event DatabaseFailoverMasterLost
        HealthMonitoringEventDatabaseFailoverMasterLost = 1827,
        //
        // Resumen:
        //     Health monitoring event DatabaseFailoverMasterRecovered
        HealthMonitoringEventDatabaseFailoverMasterRecovered = 1828,
        //
        // Resumen:
        //     Health monitoring event DatabaseLost
        HealthMonitoringEventDatabaseLost = 1829,
        //
        // Resumen:
        //     Health monitoring event DatabaseRecovered
        HealthMonitoringEventDatabaseRecovered = 1830,
        //
        // Resumen:
        //     Health monitoring event DatabaseRestoreFailure
        HealthMonitoringEventDatabaseRestoreFailure = 1831,
        //
        // Resumen:
        //     Health monitoring event DatabaseRestoreSuccess
        HealthMonitoringEventDatabaseRestoreSuccess = 1832,
        //
        // Resumen:
        //     Health monitoring event DirectoryStarted
        HealthMonitoringEventDirectoryStarted = 1833,
        //
        // Resumen:
        //     Health monitoring event DirectoryStoppedByUser
        HealthMonitoringEventDirectoryStoppedByUser = 1834,
        //
        // Resumen:
        //     Health monitoring event DirectoryStoppedUnexpectedly
        HealthMonitoringEventDirectoryStoppedUnexpectedly = 1835,
        //
        // Resumen:
        //     Health monitoring event HighCPUUsage
        HealthMonitoringEventHighCPUUsage = 1836,
        //
        // Resumen:
        //     Health monitoring event HighCPUUsageRecovered
        HealthMonitoringEventHighCPUUsageRecovered = 1837,
        //
        // Resumen:
        //     Health monitoring event HighMemoryUsage
        HealthMonitoringEventHighMemoryUsage = 1838,
        //
        // Resumen:
        //     Health monitoring event HighMemoryUsageRecovered
        HealthMonitoringEventHighMemoryUsageRecovered = 1839,
        //
        // Resumen:
        //     Health monitoring event LiveHealthMonitoringRecovered
        HealthMonitoringEventLiveHealthMonitoringRecovered = 1840,
        //
        // Resumen:
        //     Health monitoring event LiveHealthMonitoringStopped
        HealthMonitoringEventLiveHealthMonitoringStopped = 1841,
        //
        // Resumen:
        //     Health monitoring event LowArchiveSpace
        HealthMonitoringEventLowArchiveSpace = 1842,
        //
        // Resumen:
        //     Health monitoring event ApplicationConnecCameraTimeDriftted
        HealthMonitoringEventLowArchiveSpaceRecovered = 1843,
        //
        // Resumen:
        //     Health monitoring event LowDatabaseSpace
        HealthMonitoringEventLowDatabaseSpace = 1844,
        //
        // Resumen:
        //     Health monitoring event LowDatabaseSpaceRecovered
        HealthMonitoringEventLowDatabaseSpaceRecovered = 1845,
        //
        // Resumen:
        //     Health monitoring event OffloadFailed
        HealthMonitoringEventOffloadFailed = 1846,
        //
        // Resumen:
        //     Health monitoring event SynchronizationRecovered
        HealthMonitoringEventSynchronizationRecovered = 1847,
        //
        // Resumen:
        //     Health monitoring event OffloadRecovered
        HealthMonitoringEventOffloadRecovered = 1848,
        //
        // Resumen:
        //     Health monitoring event PatrollerOffline
        HealthMonitoringEventPatrollerOffline = 1849,
        //
        // Resumen:
        //     Health monitoring event PatrollerOnline
        HealthMonitoringEventPatrollerOnline = 1850,
        //
        // Resumen:
        //     Health monitoring event POSDatabaseLost
        HealthMonitoringEventPOSDatabaseLost = 1851,
        //
        // Resumen:
        //     Health monitoring event POSDatabaseRecovered
        HealthMonitoringEventPOSDatabaseRecovered = 1852,
        //
        // Resumen:
        //     Health monitoring event RoleStarted
        HealthMonitoringEventRoleStarted = 1853,
        //
        // Resumen:
        //     Health monitoring event RoleStoppedByUser
        HealthMonitoringEventRoleStoppedByUser = 1854,
        //
        // Resumen:
        //     Health monitoring event RoleStoppedUnexpectedly
        HealthMonitoringEventRoleStoppedUnexpectedly = 1855,
        //
        // Resumen:
        //     Health monitoring event RTPPacketLoss
        HealthMonitoringEventRTPPacketLoss = 1856,
        //
        // Resumen:
        //     Health monitoring event RTPPacketLossRecovered
        HealthMonitoringEventRTPPacketLossRecovered = 1857,
        //
        // Resumen:
        //     Health monitoring event ServiceStarted
        HealthMonitoringEventServiceStarted = 1858,
        //
        // Resumen:
        //     Health monitoring event ServiceStoppedByUser
        HealthMonitoringEventServiceStoppedByUser = 1859,
        //
        // Resumen:
        //     Health monitoring event ServiceStoppedUnexpectedly
        HealthMonitoringEventServiceStoppedUnexpectedly = 1860,
        //
        // Resumen:
        //     Health monitoring event SynchronizationFailed
        HealthMonitoringEventSynchronizationFailed = 1861,
        //
        // Resumen:
        //     Health monitoring event TransmissionLost
        HealthMonitoringEventTransmissionLost = 1862,
        //
        // Resumen:
        //     Health monitoring event TransmissionRecovered
        HealthMonitoringEventTransmissionRecovered = 1863,
        //
        // Resumen:
        //     Health monitoring event UnauthorizedDisk
        HealthMonitoringEventUnauthorizedDisk = 1864,
        //
        // Resumen:
        //     Health monitoring event UnauthorizedDiskRecovered
        HealthMonitoringEventUnauthorizedDiskRecovered = 1865,
        //
        // Resumen:
        //     Health monitoring event LowDatabaseSpaceRecovered
        HealthMonitoringEventUnitConnectionFailed = 1866,
        //
        // Resumen:
        //     Health monitoring event UnitConnectionRestored
        HealthMonitoringEventUnitConnectionRestored = 1867,
        //
        // Resumen:
        //     Health monitoring event UnitConnectionStopped
        HealthMonitoringEventUnitConnectionStopped = 1868,
        //
        // Resumen:
        //     Health monitoring event UnitTricklingFailure
        HealthMonitoringEventUnitTricklingFailure = 1869,
        //
        // Resumen:
        //     Health monitoring event UnitTricklingPartialFailure
        HealthMonitoringEventUnitTricklingPartialFailure = 1870,
        //
        // Resumen:
        //     Health monitoring event UnitTricklingSuccess
        HealthMonitoringEventUnitTricklingSuccess = 1871,
        //
        // Resumen:
        //     Antipassback disabled: Not supported when unit is in mixed mode
        AreaAntipassbackDisabledMixedMode = 2048,
        //
        // Resumen:
        //     Antipassback disabled: Unit is offline
        AreaAntipassbackDisabledUnitOffline = 2049,
        //
        // Resumen:
        //     People counting disabled: Unit is offline
        AreaPeopleCountDisabledUnitOffline = 2050,
        //
        // Resumen:
        //     Antipassback disabled: Elevator on area perimeter
        AreaAntipassbackDisabledPerimeterOnElevator = 2051,
        //
        // Resumen:
        //     Interlock override on
        AreaSasOverrideOn = 2052,
        //
        // Resumen:
        //     Interlock override off
        AreaSasOverrideOff = 2053,
        //
        // Resumen:
        //     Interlock lockdown on
        AreaSasLockdownOn = 2054,
        //
        // Resumen:
        //     Interlock lockdown off
        AreaSasLockdownOff = 2055,
        //
        // Resumen:
        //     Multiple units are configured for the interlock
        AreaSasMultipleUnitWarning = 2056,
        //
        // Resumen:
        //     Interlock is not supported by the unit
        AreaSasUnsupportedWarning = 2057,
        //
        // Resumen:
        //     A door of an interlock is in maintenance mode
        AreaSasMaintenanceModeWarning = 2058,
        //
        // Resumen:
        //     A door of an interlock has an unlock schedule configured
        AreaSasFreeAccessWarning = 2059,
        //
        // Resumen:
        //     An interlock cannot be in hard antipassback mode
        AreaSasAntipassbackWarning = 2060,
        //
        // Resumen:
        //     An interlock cannot have perimeter floors
        AreaSasFloorWarning = 2061,
        //
        // Resumen:
        //     Antipassback disabled: Invalid settings
        AreaAntipassbackDisabledInvalidSettings = 2062,
        //
        // Resumen:
        //     An interlock cannot have only one perimeter door
        AreaSasOnePerimeterDoorWarning = 2063,
        //
        // Resumen:
        //     An interlock cannot have a perimeter door with no sensor configured
        AreaSasDoorWithNoSensorWarning = 2064,
        AreaLast = 2303,
        //
        // Resumen:
        //     Elevator warning : unit is offline
        ElevatorWarningUnitOffline = 2304,
        //
        // Resumen:
        //     Elevatur scheduled for secured access
        ElevatorSecuredOnSchedule = 2305,
        //
        // Resumen:
        //     Elevator scheduled for free access
        ElevatorFreeAccessOnSchedule = 2306,
        //
        // Resumen:
        //     Event when an Alarm is being investigated.
        AlarmInvestigating = 2384,
        //
        // Resumen:
        //     Event when an Alarm is acknowledged forcibly.
        AlarmForciblyAcked = 2385,
        //
        // Resumen:
        //     Event when a threat level is activated on an area
        ThreatLevelActivated = 2416,
        //
        // Resumen:
        //     Event when a threat level is deactivated on an area
        ThreatLevelDeactivated = 2417,
        //
        // Resumen:
        //     Cardholder no entry detected event
        CardholderNoEntryDetected = 2432,
        //
        // Resumen:
        //     Door no entry detected event
        DoorNoEntryDetected = 2448,
        //
        // Resumen:
        //     Event Cardholder with no entry detected has access granted No entry
        CardholderNoEntryDetectedAccessGrantedNoEntry = 2449,
        //
        // Resumen:
        //     Cardholder entry detected event
        CardholderEntryDetected = 2464,
        //
        // Resumen:
        //     Cardholder entry assumed event
        CardholderEntryAssumed = 2465,
        //
        // Resumen:
        //     VisitorAstray event
        VisitorAstray = 2466,
        //
        // Resumen:
        //     Missing tail escort event
        MissingTailEscort = 2467,
        //
        // Resumen:
        //     Door entry detected event
        DoorEntryDetected = 2480,
        //
        // Resumen:
        //     Door entry detected with access granted no entry event
        DoorEntryDetectedAccessGrantedNoEntry = 2481,
        //
        // Resumen:
        //     Door entry granted despite APB violation
        DoorEntryGrantedDespiteAPBViolation = 2482,
        //
        // Resumen:
        //     par Door entry assumed event
        DoorEntryAssumed = 2496,
        //
        // Resumen:
        //     Offline unit synchronization started event.
        OfflineSynchronizationStarted = 2512,
        //
        // Resumen:
        //     Offline unit synchronization failed event.
        OfflineSynchronizationFailure = 2513,
        //
        // Resumen:
        //     Offline unit synchronization succeeded event.
        OfflineSynchronizationSuccess = 2514,
        //
        // Resumen:
        //     Unit firmware upgrade started event.
        UnitFirmwareUpgradeStarted = 2515,
        //
        // Resumen:
        //     Unit firmware upgrade success event.
        UnitFirmwareUpgradeSuccess = 2516,
        //
        // Resumen:
        //     Unit firware upgrade failure event.
        UnitFirmwareUpgradeFailure = 2517,
        //
        // Resumen:
        //     Access denied Invalid PIN Event
        AccessInvalidPin = 2544,
        //
        // Resumen:
        //     Access denied with valid card but invalid PIN Event
        AccessValidCardInvalidPin = 2545,
        //
        // Resumen:
        //     Access denied by access rule event
        AccessDeniedByAccessRule = 2546,
        //
        // Resumen:
        //     Access denied insufficient privileges event
        AccessInsufficientPrivileges = 2547,
        //
        // Resumen:
        //     Acess denied antipassback violation event
        AccessAntipassbackViolation = 2548,
        //
        // Resumen:
        //     Access denied with out of schedule event
        AccessOutOfSchedule = 2549,
        //
        // Resumen:
        //     Access denied with no access rule assigned event
        AccessNoAccessRuleAssigned = 2550,
        //
        // Resumen:
        //     Access denied because no supervisor was defined and the first in rule is enabled.
        AccessAbsentSupervisor = 2551,
        //
        // Resumen:
        //     Access denied with escort required event.
        AccessEscortRequired = 2552,
        //
        // Resumen:
        //     Access denied with second cardholder required event.
        AccessSecondCardholderRequired = 2553,
        //
        // Resumen:
        //     Access denied because the escort is not supported by the unit
        AccessEscortNotSupported = 2554,
        //
        // Resumen:
        //     Access denied because a companion visitor was denied access
        CompanionVisitorDenied = 2555,
        //
        // Resumen:
        //     Access denied because interlock event
        Interlock = 2556,
        //
        // Resumen:
        //     Access denied because access card and pin timed out
        AccessCardAndPINTimeout = 2557,
        //
        // Resumen:
        //     Access denied with valid card but inactive pin event
        AccessValidCardInactivePIN = 2558,
        //
        // Resumen:
        //     Access denied because max occupancy reached
        AccessDeniedByMaxOccupancy = 2559,
        //
        // Resumen:
        //     The intrusion detection unit input trouble.
        IntrusionUnitInputTrouble = 2560,
        //
        // Resumen:
        //     The intrusion detection unit input bypass activated.
        IntrusionUnitInputBypassActivated = 2561,
        //
        // Resumen:
        //     The intrusion detection unit input bypass deactivated.
        IntrusionUnitInputBypassDeactivated = 2562,
        //
        // Resumen:
        //     The intrusion detection unit tamper.
        IntrusionUnitTamper = 2563,
        //
        // Resumen:
        //     Event when an Input state changed to active.
        InputStateActive = 2816,
        //
        // Resumen:
        //     Event when an Input state changed to normal.
        InputStateNormal = 2817,
        //
        // Resumen:
        //     Event when an Input state changed to trouble.
        InputStateTrouble = 2818,
        //
        // Resumen:
        //     Event when an Input arming state changed to active.
        InputAlarmActive = 2819,
        //
        // Resumen:
        //     Event when an Input arming state changed to armed.
        InputAlarmRestored = 2820,
        //
        // Resumen:
        //     Event when an Input arming state changed to bypass.
        InputBypassed = 2821,
        //
        // Resumen:
        //     Event when an Input arming state restored from bypass.
        InputBypassRestored = 2822,
        //
        // Resumen:
        //     Event that indicates the Archiver Disk is full.
        ArchiverDiskFull = 3072,
        //
        // Resumen:
        //     Event that indicates the file protection for multiple cameras has been applied
        //     successfully.
        ArchiverFileProtectionSuccess = 3073,
        //
        // Resumen:
        //     Event that indicates the file protection for multiple cameras has failed to be
        //     applied.
        ArchiverFileProtectionFailure = 3074,
        //
        // Resumen:
        //     Event that indicates that the archiver is ready to write
        ArchiverCanWrite = 3075,
        //
        // Resumen:
        //     Event that indicates that the archiver database connection was lost
        ArchiverDatabaseLost = 3076,
        //
        // Resumen:
        //     Event that indicates that the archiver database connection was recovered
        ArchiverDatabaseRecovered = 3077,
        //
        // Resumen:
        //     Event that indicates that the archiver disk has changed
        ArchiverDiskChanged = 3078,
        //
        // Resumen:
        //     Event that indicates that the archiver database disk is busy
        ArchiverDiskLoad = 3079,
        //
        // Resumen:
        //     Event that indicates that the archiver custom encryption is invalid
        ArchiverInvalidCustomEncryption = 3080,
        //
        // Resumen:
        //     Event that indicates that the archiver cannnot write
        ArchiverNoWrite = 3081,
        //
        // Resumen:
        //     Event that indicates that the archiver is now writing on a specified Disk
        ArchiverNoWriteOnSpecifiedDisk = 3082,
        //
        // Resumen:
        //     Event that indicates that the archiver has stopped archiving
        ArchiverArchivingStopped = 3083,
        //
        // Resumen:
        //     Event that indicates that the archiver backup has started
        ArchiverBackupStarted = 3084,
        //
        // Resumen:
        //     Event that indicates that the archiver Backup has succeeded
        ArchiverBackupSucceeded = 3085,
        //
        // Resumen:
        //     Event that indicates that the archiver Backup has failed
        ArchiverBackupFailed = 3087,
        //
        // Resumen:
        //     Event that indicates that the archiver protection has exceeded the threshold
        ArchiverProtectionThresholdExceeded = 3088,
        //
        // Resumen:
        //     Event that indicates a vrm connection attempt to the archiver vrm
        ArchiverVrmConnectionAttempt = 3089,
        //
        // Resumen:
        //     Event that indicates a vrm connection to the archiver vrm has failed
        ArchiverVrmConnectionFailure = 3090,
        //
        // Resumen:
        //     Event that indicates a archiver path is too long
        ArchiverPathTooLong = 3091,
        //
        // Resumen:
        //     Event when session created due to a new vehicle entering the parking zone
        ParkingSessionStartedByVehicleEntered = 3328,
        //
        // Resumen:
        //     Event when session created due to an unknown vehicle exiting.
        ParkingSessionStartedByUnknownVehicleExited = 3329,
        //
        // Resumen:
        //     Event when session convenience time begins
        ParkingSessionConvenienceTimeStarted = 3330,
        //
        // Resumen:
        //     Event when paid time validation begins after convenience time expired
        ParkingSessionValidatingPaidTimeByConvenienceTimeExpired = 3331,
        //
        // Resumen:
        //     Event when paid time validation begins after paid time expired
        ParkingSessionValidatingPaidTimeByPaidTimeExpired = 3332,
        //
        // Resumen:
        //     Event when paid time begins after paid time originally valid
        ParkingsessionPaidTimeStartedByPaidTimeValid = 3333,
        //
        // Resumen:
        //     Event when paid time begins after paid time invalid
        ParkingSessionPaidTimeStartedByValidationError = 3334,
        //
        // Resumen:
        //     Event when grace period begins due to convenience time expiring
        ParkingSessionGracePeriodStartedByConvenienceTimeExpired = 3335,
        //
        // Resumen:
        //     Event when grace period started due to paid time becoming invalid
        ParkingSessionGracePeriodStartedByPaidTimeInvalid = 3336,
        //
        // Resumen:
        //     Event when violation detected because of convenience time expiring
        ParkingSessionViolationDetectedByConvenienceTimeExpired = 3337,
        //
        // Resumen:
        //     Event for violation detected from when grace period expired
        ParkingSessionViolationDetectedByGracePeriodExpired = 3338,
        //
        // Resumen:
        //     Event for violation detected due to paid time expiring
        ParkingSessionViolationDetectedByPaidTimeInvalid = 3340,
        //
        // Resumen:
        //     Event for when a violation is enforced in the parking zone
        ParkingSessionViolationEnforced = 3341,
        //
        // Resumen:
        //     Event for when the parking session completes due to an inventory reset
        ParkingSessionCompletedByInventoryReset = 3342,
        //
        // Resumen:
        //     Event for when the parking session completes due to the maximum session time
        //     for the session being reached
        ParkingSessionCompletedByMaxSessionTimeExceeded = 3343,
        //
        // Resumen:
        //     Event for when the parking session completes due to the vehicle being associated
        //     with the session leaving the parking zone
        ParkingSessionCompletedByVehicledExited = 3344,
        //
        // Resumen:
        //     Event for when the parking session completes due to the vehicle being detected
        //     as re-entering when not corresponding exit was detected
        ParkingSessionCompletedByVehicleReentered = 3345,
        //
        // Resumen:
        //     Event for when the parking session completes due to an unknown vehicle exiting
        //     the parking zone (a vehicle that has no corresponding entrance read)
        ParkingSessionCompletedByUnknownVehicleExited = 3346,
        //
        // Resumen:
        //     Event for when an inventory reset occurs on the parking zone
        ParkingZoneInventoryReset = 3347,
        //
        // Resumen:
        //     Event for when the configured capacity threshold of a parking zone is reached
        ParkingZoneCapacityThresholdReached = 3348,
        //
        // Resumen:
        //     Event for when a parking session has started
        ParkingSessionStarted = 3349,
        //
        // Resumen:
        //     Event for when a parking grace session perdiod has started
        ParkingSessionGracePeriodStarted = 3350,
        //
        // Resumen:
        //     Event for when the parking session is validating the paid time
        ParkingSessionValidatingPaidTime = 3351,
        //
        // Resumen:
        //     Event for when parking session paid time has started
        ParkingSessionPaidTimeStarted = 3352,
        //
        // Resumen:
        //     Event for when a violation is detected in the parking session
        ParkingSessionViolationDetected = 3353,
        //
        // Resumen:
        //     Event for when a parking session is completed
        ParkingSessionCompleted = 3354,
        //
        // Resumen:
        //     Event for when a door warning occur when a battery fail
        DoorWarningInterfaceBatteryFail = 3355,
        //
        // Resumen:
        //     Event for when a door warning occur when the AC fail
        DoorWarninInterfaceAcFail = 3356,
        //
        // Resumen:
        //     Event for when a warning for door tampering is restored
        DoorWarningInterfaceTamperRestored = 3357,
        //
        // Resumen:
        //     Event for when a warning for a battery fail is restored
        DoorWarningInterfaceBatteryFailRestored = 3358,
        //
        // Resumen:
        //     Event for when a warning for a AC fail is restored
        DoorWarningInterfaceAcFailRestored = 3359,
        //
        // Resumen:
        //     Event for when it is impossible to assigned a parking zone for the plate number
        //     for a parking session
        ParkingSessionNoZoneRuleAssigned = 3360,
        //
        // Resumen:
        //     Event for when a parking session state transition due to an edited read
        ParkingSessioReadEdited = 3361,
        //
        // Resumen:
        //     Event for when a parking session state transitions due to the deletion of the
        //     parking rule
        ParkingSessionRuleDeleted = 3362,
        //
        // Resumen:
        //     Event for when a a vehicle sharing a permit id enters a parking zone and at the
        //     same time the other vehicle with the same permit id is also parked.
        ParkingSessionSharedPermitMatch = 3363,
        //
        // Resumen:
        //     Audio Analytics Custom event.
        AudioAnalyticsCustom = 3584,
        //
        // Resumen:
        //     Event for ignoring a door scheduled unlock
        DoorScheduledUnlockIgnored = 3617,
        //
        // Resumen:
        //     Event for a tempering warning of a door interface
        DoorWarningInterfaceTamper = 3618,
        //
        // Resumen:
        //     Event for a when a cardholder request a credential
        CardholderCredentialRequested = 3619,
        //
        // Resumen:
        //     Event for a when a cardholder request for credential complete
        CardholderCredentialRequestComplete = 3620,
        //
        // Resumen:
        //     Event for a when a cardholder request for credential is cancelled
        CardholderCredentialRequestCancelled = 3621,
        //
        // Resumen:
        //     Event for a when a credential has expired
        CredentialHasExpired = 3664,
        //
        // Resumen:
        //     Event for a when a credential is expiring
        CredentialIsExpiring = 3665,
        //
        // Resumen:
        //     Event for a when a Lpr update is installed
        LprUpdateInstalled = 3666,
        //
        // Resumen:
        //     Event for a when a Lpr update is uninstalled
        LprUpdateUninstalled = 3667,
        //
        // Resumen:
        //     Event for a when a Lpr update is published
        LprUpdatePublished = 3668,
        //
        // Resumen:
        //     Event for a when a Lpr update has an error
        LprUpdateError = 3669,
        //
        // Resumen:
        //     Event for a when a Lpr update is installing
        LprUpdateInstalling = 3670,
        //
        // Resumen:
        //     Event for a when a Lpr update is uninstalling
        LprUpdateUninstalling = 3671,
        //
        // Resumen:
        //     Event for a when a Lpr Update a package
        LprUpdatePackage = 3672,
        //
        // Resumen:
        //     Event for an alarm triggered from an external system
        ExternalSystemAlarmTriggered = 3712,
        //
        // Resumen:
        //     Event for a system synchronisation that has started from an external system
        ExternalSystemSynchronizationStarted = 3713,
        //
        // Resumen:
        //     Event for a system synchronisation that has completed from an external system
        ExternalSystemSynchronizationCompleted = 3714,
        //
        // Resumen:
        //     Event for a system synchronisation has an error from an external system
        ExternalSystemSynchronizationError = 3715,
        //
        // Resumen:
        //     Event for a system synchronisation that has partially completed from an external
        //     system
        ExternalSystemSynchronizationpartiallyCompleted = 3716,
        //
        // Resumen:
        //     Event an auto action
        AutoActionExecute = 3717,
        //
        // Resumen:
        //     Event entity warning
        EntityWarning = 3718,
        //
        // Resumen:
        //     Event for when a user modified an incident
        UserModifiedincident = 3719,
        //
        // Resumen:
        //     Event when a user failed to login
        UserLoginFailed = 3720,
        //
        // Resumen:
        //     Event when a unit has an invalid config
        unitInvalidConfig = 3721,
        //
        // Resumen:
        //     Event when a unit trigger a temperature alarm
        UnitTemperatureAlarm = 3722,
        //
        // Resumen:
        //     Event when the server is lost
        ServerLost = 3723,
        //
        // Resumen:
        //     Event when a camera rtp lost packet was recovered
        CameraRtpPacketLostRecovery = 3724,
        //
        // Resumen:
        //     Event when a pattroler mlpi read result was evalidated
        InvalidatePatrollerMlpiReadsResultEvent = 3725,
        //
        // Resumen:
        //     Event is a Cardholder Access Refused. The cardholder credential is expired
        CardholderCredentialExpired = 3744,
        //
        // Resumen:
        //     Event is a Cardholder Access Refused. The cardholder credential is inactive
        CardholderCredentialInactive = 3745,
        //
        // Resumen:
        //     Event is a Cardholder Access Refused. The cardholder credential is lost
        CardholderCredentiallost = 3746,
        //
        // Resumen:
        //     Event is a Cardholder Access Refused. The cardholder credential is stolen
        CardholderCredentialStolen = 3747
    }
}
