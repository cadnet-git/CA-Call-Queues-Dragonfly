
Public Module StringManipulation

    Public Function RemoveNonNumerics(ByVal Input As String) As String
        'remove all non-numerics from the telephone number
        Dim arrChars As Char() = Input.Trim.ToCharArray
        Dim sClean As String = ""

        For i As Integer = 0 To arrChars.Length - 1
            If Char.IsNumber(arrChars(i)) Then
                sClean = sClean & arrChars(i)
            End If
        Next

        RemoveNonNumerics = sClean

    End Function


    Public Function RemoveNonAlphaNumerics(ByVal Input As String, Optional ByVal AllowSpaces As Boolean = False) As String
        'remove all non-numerics from the telephone number
        Dim arrChars As Char() = Input.Trim.ToCharArray
        Dim sClean As String = ""

        For i As Integer = 0 To arrChars.Length - 1
            If AllowSpaces Then
                If Char.IsLetterOrDigit(arrChars(i)) Or arrChars(i) = " " Then
                    sClean = sClean & arrChars(i)
                End If
            Else
                If Char.IsLetterOrDigit(arrChars(i)) Then
                    sClean = sClean & arrChars(i)
                End If
            End If
        Next

        Return sClean

    End Function

    Public Function TitleCase(ByVal Input As String) As String

        Dim NewString As String = ""
        Dim NextLetterToCapital As Boolean = True
        Dim nextletter As String
        Dim LastWasSpace As Boolean = False

        For t As Integer = 0 To Input.Length - 1
            nextletter = Input.Substring(t, 1)
            If nextletter <> " " Then
                If NextLetterToCapital Then
                    NewString = NewString & nextletter.ToUpper
                    NextLetterToCapital = False
                Else
                    NewString = NewString & nextletter.ToLower
                End If
                LastWasSpace = False
            Else
                If LastWasSpace = False Then
                    NextLetterToCapital = True
                    NewString = NewString & nextletter
                    LastWasSpace = True
                End If

            End If
        Next
        Return NewString.Trim
    End Function



End Module
