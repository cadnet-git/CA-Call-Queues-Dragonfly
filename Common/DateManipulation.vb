Public Module DateManipulation

    Public Enum DateFormats
        ForDisplayWithFullDay
        ForSQLInsertion
        ForDisplayMonthNameYear
    End Enum
    Public Function DateTimeToString(ByVal aDate As Date, ByVal DateFormat As DateFormats) As String
        'format a string for display
        '

        DateTimeToString = ""

        Select Case DateFormat
            Case DateFormats.ForSQLInsertion
                DateTimeToString = FormatSQLDateTime(aDate)
            Case DateFormats.ForDisplayWithFullDay
                'eg Monday, 12th March 2007 14:00:00
                DateTimeToString = aDate.ToString("dddd") & ", " & GetDateDescription(aDate, False) & " " & MonthName(aDate.Month) & " " & aDate.Year()
                DateTimeToString = DateTimeToString & " " & aDate.ToShortDateString("hh:mm:ss")

            Case Else
                'unexpected format
                DateTimeToString = "Unexpected Date Format: " & DateFormat.ToString()
        End Select

    End Function
    Public Function DateToString(ByVal aDate As Date, ByVal DateFormat As DateFormats) As String
        'format a string for display
        '

        DateToString = ""

        Select Case DateFormat
            Case DateFormats.ForSQLInsertion
                DateToString = FormatSQLDate(aDate)
            Case DateFormats.ForDisplayWithFullDay
                'eg Monday, 12th March 2007
                DateToString = aDate.ToString("dddd") & ", " & GetDateDescription(aDate, False) & " " & MonthName(aDate.Month) & " " & aDate.Year()
            Case DateFormats.ForDisplayMonthNameYear
                'eg Febuary 2008
                DateToString = MonthName(aDate.Month) & " " & aDate.Year
            Case Else
                'unexpected format
                DateToString = "Unexpected Date Format: " & DateFormat.ToString()
        End Select

    End Function
    Public Function FormatSQLDate(ByVal aDate As Date) As String
        'formats a date for easy use in SQL Server

        Dim sTemp As String = ""

        sTemp = aDate.Day & aDate.ToString(" MMM ") & aDate.Year

        FormatSQLDate = sTemp

    End Function
    Public Function FormatSQLDateTime(ByVal aDate As Date) As String
        'formats a date for easy use in SQL Server

        Dim sTemp As String = ""

        sTemp = aDate.Day & aDate.ToString(" MMM ") & aDate.Year
        sTemp = sTemp & " " & aDate.ToString("hh:mm:ss")


        FormatSQLDateTime = sTemp

    End Function


    Public Function GetStartOfWeek(ByVal aDate As Date) As Date

        Dim iOffset As Integer = 0

        Select Case aDate.DayOfWeek
            Case DayOfWeek.Monday
                iOffset = 0
            Case DayOfWeek.Tuesday
                iOffset = -1
            Case DayOfWeek.Wednesday
                iOffset = -2
            Case DayOfWeek.Thursday
                iOffset = -3
            Case DayOfWeek.Friday
                iOffset = -4
            Case DayOfWeek.Saturday
                iOffset = -5
            Case DayOfWeek.Sunday
                iOffset = -6
        End Select

        GetStartOfWeek = DateAdd(DateInterval.Day, iOffset, aDate)


    End Function

    Public Function GetDateDescription(ByVal aDate As DateTime, Optional ByVal IncludeDayName As Boolean = True) As String


        Dim sTemp As String = ""

        If IncludeDayName Then
            sTemp = aDate.ToString("ddd, ")
        End If

        sTemp = sTemp & aDate.Day
        Select Case aDate.Day
            Case 1, 21, 31
                sTemp = sTemp & "st"
            Case 2, 22
                sTemp = sTemp & "nd"
            Case 3, 23
                sTemp = sTemp & "rd"
            Case Else
                sTemp = sTemp & "th"
        End Select
        GetDateDescription = sTemp

    End Function
End Module

