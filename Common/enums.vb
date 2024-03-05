Public Module enums

    Public Enum eCallTypes
        Unknown = -1

        ColdCall = 1
        Rescheduled = 2
    End Enum

    Public Enum eApplications
        'the different application in the suite
        'used to determine user access rights 
        Agent
        ManagementConsole

        DeveloperConsole
    End Enum

    Public Enum eUserStatus
        Inactive = 0
        Active = 1
    End Enum

    Public Enum eUserLevel
        Developer = 1
        Manager = 2
        Agent = 3
        Rep = 4
    End Enum

    Public Enum eCompanyStatus

        ColdCall
        TPS
        InvalidNumber
        InProgress
        NotToHand
        ReviewRequired
        Appointment
        CallBack
        Supervisor

    End Enum

End Module
