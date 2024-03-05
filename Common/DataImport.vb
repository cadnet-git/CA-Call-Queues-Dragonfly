Public Module DataImport


    Public Function ValidateTelephoneReason(ByVal sTelephone As String) As String
        'this version of validate acts the same as validatepostcode!

        'returns an empty string if the number validates
        'else returns a description of why
        Dim sTelClean As String = Common.RemoveNonNumerics(sTelephone)

        If sTelClean.StartsWith("0") = False Then
            'the import though excel can strip off leading zeros
            sTelClean = "0" & sTelClean
        End If

        If sTelClean.Length < 10 Then
            ValidateTelephoneReason = "Too short"
            Exit Function
        End If

        If sTelClean.Length > 12 Then
            ValidateTelephoneReason = "Too long"
        End If

        ValidateTelephoneReason = ""

    End Function
    Public Function ValidateTelephone(ByVal sTelephone As String) As String

        'returns Empty string if the number does not validate
        'returns the cleaned up number if it does

        Dim sTelClean As String = Common.RemoveNonNumerics(sTelephone)

        If sTelClean.StartsWith("0") = False Then
            'the import though excel can strip off leading zeros
            sTelClean = "0" & sTelClean
        End If

        If sTelClean.Length < 10 Then
            'too short!
            sTelClean = ""
        End If

        If sTelClean.Length > 12 Then
            'too long! 
            sTelClean = ""
        End If

        ValidateTelephone = sTelClean

    End Function



End Module
