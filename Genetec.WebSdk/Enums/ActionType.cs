using System;
using System.Collections.Generic;
using System.Text;

namespace Genetec.WebSdk
{
    //
    // Resumen:
    //     Enumeration indicating the possible actions available in security center.
    public enum ActionType
    {
        //
        // Resumen:
        //     No action type.
        None = 0,
        //
        // Resumen:
        //     Send mail.
        SendEmail = 1,
        //
        // Resumen:
        //     Execute a macro.
        ExecuteMacro = 2,
        //
        // Resumen:
        //     Send string on serial connection.
        SendStringOnSerial = 3,
        //
        // Resumen:
        //     Sound buzzer.
        SoundBuzzer = 4,
        //
        // Resumen:
        //     Silence Buzzer.
        SilenceBuzzer = 5,
        //
        // Resumen:
        //     Save an Incident.
        IncidentSave = 6,
        //
        // Resumen:
        //     Update incident.
        IncidentUpdate = 7,
        //
        // Resumen:
        //     Send an incident.
        IncidentSend = 8,
        //
        // Resumen:
        //     Update custom field type.
        UpdateCustomFieldType = 9,
        //
        // Resumen:
        //     Create an antipassback exemption.
        AntiPassbackExemption = 10,
        //
        // Resumen:
        //     Begining of user actions.
        FirstUserActionMarker = 4096,
        //
        // Resumen:
        //     Send a message.
        SendMessage = 4097,
        //
        // Resumen:
        //     Play a sound.
        PlaySound = 4098,
        //
        // Resumen:
        //     Disconnect a user.
        DisconnectUser = 4099,
        //
        // Resumen:
        //     End of user actions.
        LastUserActionMarker = 4100,
        //
        // Resumen:
        //     Begining of access point group actions.
        FirstAccessPointGroupActionMarker = 12288,
        //
        // Resumen:
        //     Open access point group.
        Open = 12289,
        //
        // Resumen:
        //     Reset the people count.
        PeopleCountReset = 12290,
        //
        // Resumen:
        //     End of access point group actions.
        LastAccessPointGroupActionMarker = 12291,
        //
        // Resumen:
        //     Begining of access point actions.
        FirstAccessPointActionMarker = 16384,
        //
        // Resumen:
        //     Start recording.
        StartRecording = 16385,
        //
        // Resumen:
        //     Stop recording.
        StopRecording = 16386,
        //
        // Resumen:
        //     Add bookmark.
        AddBookmark = 16387,
        //
        // Resumen:
        //     Go to a preset
        GotoPreset = 16388,
        //
        // Resumen:
        //     Edit a bookmark.
        EditBookmark = 16389,
        //
        // Resumen:
        //     Delete a bookmark.
        DeleteBookmark = 16390,
        //
        // Resumen:
        //     End of access point actions.
        LastAccessPointActionMarker = 16391,
        //
        // Resumen:
        //     Begining of unit actions.
        FirstUnitActionMarker = 20480,
        //
        // Resumen:
        //     Reset a unit.
        UnitReset = 20481,
        //
        // Resumen:
        //     Upgrade the firmware on a unit.
        FirmwareUpgrade = 20482,
        //
        // Resumen:
        //     Add a unit.
        AddUnit = 20483,
        //
        // Resumen:
        //     Toggle encryption
        ToggleEncryption = 20484,
        //
        // Resumen:
        //     Add unit progress information.
        AddUnitProgressInformation = 20485,
        //
        // Resumen:
        //     Start offline synchronization.
        StartOfflineSynchronization = 20486,
        //
        // Resumen:
        //     Swat unit.
        SwapUnit = 20487,
        //
        // Resumen:
        //     Swap unit response.
        SwapUnitResponse = 20488,
        //
        // Resumen:
        //     Do an Extension specific action.
        ExtensionSpecificAction = 20489,
        //
        // Resumen:
        //     Send an action for the unit to identify itself.
        IdentifyUnit = 20490,
        //
        // Resumen:
        //     Ending of unit actions.
        LastUnitActionMarker = 20491,
        //
        // Resumen:
        //     Reconnect a unit.
        UnitReconnect = 20492,
        //
        // Resumen:
        //     Begining of application actions.
        FirstApplicationActionMarker = 24576,
        //
        // Resumen:
        //     Display entity.
        DisplayEntity = 24577,
        //
        // Resumen:
        //     Trigger Discovery.
        TriggerDiscovery = 24578,
        //
        // Resumen:
        //     Ping
        Ping = 24579,
        //
        // Resumen:
        //     Trigger Datastore test.
        TriggerDatastoreTest = 24580,
        //
        // Resumen:
        //     Trigger offline synchronization.
        TriggerOfflineSync = 24581,
        //
        // Resumen:
        //     Request listening cameras.
        RequestListeningCameras = 24582,
        //
        // Resumen:
        //     Answer listening cameras.
        AnswerListeningCameras = 24583,
        //
        // Resumen:
        //     Subscribe to current tile context.
        SubscribeCurrentTileContext = 24584,
        //
        // Resumen:
        //     Unsubscribe to current tile context.
        UnsubscribeCurrentTileContext = 24585,
        //
        // Resumen:
        //     update current tile context.
        UpdateCurrentTileContext = 24586,
        //
        // Resumen:
        //     Matric command.
        MatrixCommand = 24587,
        //
        // Resumen:
        //     Modify people count.
        ModifyPeopleCount = 24588,
        //
        // Resumen:
        //     End of application actions.
        LastApplicationActionMarker = 24589,
        //
        // Resumen:
        //     SetTileContent actions.
        SetTileContent = 24590,
        //
        // Resumen:
        //     Begining of alarm actions
        FirstAlarmActionMarker = 28672,
        //
        // Resumen:
        //     Trigger an alarm.
        TriggerAlarm = 28673,
        //
        // Resumen:
        //     Acknowledge an alarm.
        AcknowledgeAlarm = 28674,
        //
        // Resumen:
        //     Negative acknowledge and alarm.
        NegativeAcknowledgeAlarm = 28675,
        //
        // Resumen:
        //     Custom acknowledge alarm.
        CustomAcknowledgeAlarm = 28676,
        //
        // Resumen:
        //     Forward alarm.
        ForwardAlarm = 28677,
        //
        // Resumen:
        //     End of alarm actions.
        LastAlarmActionMarker = 28678,
        //
        // Resumen:
        //     Begining of camera actions.
        FirstCameraActionMarker = 32768,
        //
        // Resumen:
        //     Run pattern.
        RunPattern = 32769,
        //
        // Resumen:
        //     Ptz command.
        PtzCommand = 32770,
        //
        // Resumen:
        //     Boost quality as scheduled.
        BoostQualityAsScheduled = 32771,
        //
        // Resumen:
        //     Boost quality on motion.
        BoostQualityOnMotion = 32772,
        //
        // Resumen:
        //     Boost quality manualy.
        BoostQualityManual = 32773,
        //
        // Resumen:
        //     Start file protection.
        StartFileProtection = 32774,
        //
        // Resumen:
        //     Stop file protection.
        StopFileProtection = 32775,
        //
        // Resumen:
        //     Protect file.
        ProtectFile = 32776,
        //
        // Resumen:
        //     Delete file.
        DeleteFile = 32777,
        //
        // Resumen:
        //     Go to home.
        GoHome = 32778,
        //
        // Resumen:
        //     Block unblock video.
        BlockUnblockVideo = 32779,
        //
        // Resumen:
        //     Start a preset tour.
        StartPresetTour = 32780,
        //
        // Resumen:
        //     Stop current preset tour.
        StopPresetTour = 32781,
        //
        // Resumen:
        //     Protect file.
        MultipleCameraProtectFile = 32782,
        //
        // Resumen:
        //     End of camera actions
        LastCameraActionMarker = 32783,
        //
        // Resumen:
        //     Begining of External system actions
        FirstExternalSystemActionMarker = 36864,
        //
        // Resumen:
        //     Log on to active directory.
        ActiveDirectoryLogon = 36865,
        //
        // Resumen:
        //     Active directory logon response.
        ActiveDirectoryLogonReponse = 36866,
        //
        // Resumen:
        //     External system trigger alarm.
        ExternalSystemTriggerAlarm = 36867,
        //
        // Resumen:
        //     External system acknowledge alarm.
        ExternalSystemAcknowledgeAlarm = 36868,
        //
        // Resumen:
        //     External system merge alarm.
        ExternalSystemMergeAlarm = 36869,
        //
        // Resumen:
        //     External system add entity.
        ExternalSystemAddEntity = 36870,
        //
        // Resumen:
        //     External system trigger synchronization.
        ExternalSystemTriggerSynchronization = 36871,
        //
        // Resumen:
        //     Delete External system.
        ExternalSystemDelete = 36872,
        //
        // Resumen:
        //     Reset an external system.
        ExternalSystemReset = 36873,
        //
        // Resumen:
        //     Send a Role Command.
        RoleCommand = 36874,
        //
        // Resumen:
        //     Get the role command result.
        RoleCommandResult = 36875,
        //
        // Resumen:
        //     End of External System actions.
        LastExternalSystemActionMarker = 36876,
        //
        // Resumen:
        //     Begining of device actions.
        FirstDeviceActionMarker = 65536,
        //
        // Resumen:
        //     Trigger output.
        TriggerOutput = 65537,
        //
        // Resumen:
        //     End of device actions.
        LastDeviceActionMarker = 65538,
        //
        // Resumen:
        //     Bypass an intrusion input.
        BypassInput = 65539,
        //
        // Resumen:
        //     Unbypass an intrusion input
        UnbypassInput = 65540,
        //
        // Resumen:
        //     Begining of macro actions.
        FirstMacroActionMarker = 69632,
        //
        // Resumen:
        //     Run a macro.
        RunMacro = 69633,
        //
        // Resumen:
        //     Stop a macro from running.
        AbortMacro = 69634,
        //
        // Resumen:
        //     End of macro actions.
        LastMacroActionMarker = 69635,
        //
        // Resumen:
        //     Begining of report actions.
        FirstReportActionMarker = 73727,
        //
        // Resumen:
        //     Send report by email.
        SendEmailReport = 73728,
        //
        // Resumen:
        //     Print a report.
        PrintReport = 73729,
        //
        // Resumen:
        //     End of report actions.
        LastReportActionMarker = 73730,
        //
        // Resumen:
        //     Send snapshot by email.
        SendEmailSnapshotReport = 73731,
        //
        // Resumen:
        //     Begining of query actions.
        FirstQueryActionMarker = 77824,
        //
        // Resumen:
        //     Cancel a query.
        CancelQuery = 77825,
        //
        // Resumen:
        //     End of query actions.
        LastQueryActionMarker = 77826,
        //
        // Resumen:
        //     Create database.
        CreateDatabase = 81920,
        //
        // Resumen:
        //     Drop database.
        DropDatabase = 81921,
        //
        // Resumen:
        //     Back up restore database.
        BackUpRestoreDatabase = 81922,
        //
        // Resumen:
        //     Test database connection.
        TestDatabaseConnection = 81923,
        //
        // Resumen:
        //     Upgrade a database.
        UpgradeDatabase = 81924,
        //
        // Resumen:
        //     Protect License plate recognition event.
        ProtectLprEvent = 86016,
        //
        // Resumen:
        //     Reset License plate recognition unit.
        LprUnitReset = 86017,
        //
        // Resumen:
        //     Modify Mlpi Read.
        ModifyMlpiRead = 86018,
        //
        // Resumen:
        //     Process Mlpi results.
        ProcessMlpiResults = 86019,
        //
        // Resumen:
        //     Invalidate Patroller Mlpi reads.
        InvalidatePatrollerMlpiReads = 86020,
        //
        // Resumen:
        //     Delete inventory.
        DeleteInventory = 86021,
        //
        // Resumen:
        //     Modify Mlpi Read.
        EditRead = 86022,
        //
        // Resumen:
        //     Modify Mlpi Read.
        LprUnitTriggerRead = 86023,
        //
        // Resumen:
        //     Set door maintenance mode.
        SetDoorMaintenanceMode = 90112,
        //
        // Resumen:
        //     Override locking schedule.
        OverrideLockingSchedule = 90113,
        //
        // Resumen:
        //     Send user task.
        SendUserTask = 94208,
        //
        // Resumen:
        //     End of user task actions.
        LastUserTaskActionMarker = 94209,
        //
        // Resumen:
        //     Arm intrusion area.
        ArmIntrusionArea = 98304,
        //
        // Resumen:
        //     Disarm intrustion area.
        DisarmIntrusionArea = 98305,
        //
        // Resumen:
        //     Trigger an intrusion alarm.
        TriggerIntrusionAlarm = 98306,
        //
        // Resumen:
        //     Postpone instrusion area arming.
        PostponeIntrusionAreaArming = 98307,
        //
        // Resumen:
        //     Network detection action.
        NetworkDetectionAction = 98308,
        //
        // Resumen:
        //     Network detection response action.
        NetworkDetectionReponseAction = 98309,
        //
        // Resumen:
        //     Execute Custom Alarm Panel Action
        ExecuteCustomAlarmPanelAction = 98310,
        //
        // Resumen:
        //     Activates a threat level on an area
        ActivateThreatLevel = 98311,
        //
        // Resumen:
        //     Set the access permission level on an area, door or elevator
        SetAccessPermissionLevel = 98312,
        //
        // Resumen:
        //     Silences the intrusion alarm
        SilenceIntrusionAlarm = 98313,
        //
        // Resumen:
        //     Acknowledges the intrusion alarm
        AckIntrusionAlarm = 98320,
        //
        // Resumen:
        //     Arms a zone
        ArmZone = 102400,
        //
        // Resumen:
        //     Disarms a zone
        DisarmZone = 102401,
        //
        // Resumen:
        //     Displays a camera on an analog monitor
        DisplayOnAnalogMonitor = 139265,
        //
        // Resumen:
        //     Refresh the role in order to get up to date statistics.
        RefreshRoleStatistics = 143361
    }
}
