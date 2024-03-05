Imports System.Data.SqlClient

Public Class DataLayer

    Private Training As Boolean = False
    Public Sub SetTraining(ByVal isTraining As Boolean)
        Training = isTraining
    End Sub

    Private bDebugMode As Boolean = False
    Public Property DebugMode() As Boolean
        Get
            DebugMode = bDebugMode
        End Get
        Set(ByVal value As Boolean)
            bDebugMode = value
        End Set
    End Property

    Public sCS As String
    Friend ReadOnly Property Connection() As SqlConnection
        Get

            Dim CN As SqlConnection = Nothing

            If CN Is Nothing Then
                CN = New SqlConnection
                ' Dim sCS As String = "Data Source=CA-SQL;Initial Catalog=CallQueues_Dragonfly;Persist Security Info=True;User ID=Callqueues2; Password=Callqueues2"
                sCS = "Server=tcp:dragonflyserver.database.windows.net,1433;Initial Catalog=CallQueues_Dragonfly_Cloud;Persist Security Info=False;User ID=cadnet;Password=$Solipsism;MultipleActiveResultSets=True;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;"
                'sCS = "Server=tcp:dragonflyserver.database.windows.net,1433;Initial Catalog=CallQueues_Dragonfly_Cloud_Dev;Persist Security Info=False;User ID=cadnet;Password=$Solipsism;MultipleActiveResultSets=True;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;"

                Select Case My.Computer.Name.ToUpper
                    Case "LAPTOPXPSx"
                        ' sCS = "Data Source=Localhost;Initial Catalog=CallQueues_Dragonfly;Persist Security Info=True;Integrated Security=true;"
                        sCS = "Server=tcp:dragonflyserver.database.windows.net,1433;Initial Catalog=CallQueues_Dragonfly_Cloud;Persist Security Info=False;User ID=cadnet;Password=$Solipsism;MultipleActiveResultSets=True;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;"

                End Select

                CN.ConnectionString = sCS
            End If

            Try
                If CN.State = ConnectionState.Closed Then
                    CN.Open()
                End If
            Catch ex As Exception

                Dim aWobbler As New Exception("Cannot open connection to database- " & CN.ConnectionString, ex)
                Throw aWobbler
            End Try

            Connection = CN

        End Get
    End Property

    Public Sub CreateParameter(ByRef Params As Collection, ByVal ParamName As String, ByVal DataType As SqlDbType, ByVal Value As Object)
        'create a new sqlk param and add it to the collection

        Dim aPar As New SqlClient.SqlParameter(ParamName, DataType)

        If Value Is Nothing Then
            aPar.IsNullable = True
            aPar.SqlValue = DBNull.Value
        Else
            aPar.SqlValue = Value
        End If
        Params.Add(aPar)

    End Sub


    Public Sub ExecuteSPNoQuery(ByVal spTitle As String, Optional ByVal Params As Collection = Nothing)

        Dim CN As SqlConnection = Connection
        Dim CMD As SqlCommand

        Dim deadlockcounter = 0
        Do While True = True
            Try
                CMD = New SqlCommand()
                CMD.Connection = CN
                CMD.CommandType = CommandType.StoredProcedure
                CMD.CommandText = spTitle
                CMD.CommandTimeout = 60

                If Params Is Nothing Then
                    'no params to add
                Else
                    For Each aParam As SqlParameter In Params
                        CMD.Parameters.Add(aParam)
                    Next
                End If
                CMD.ExecuteNonQuery()
                CN.Close()



                Exit Do
            Catch ex As Exception
                If ex.Message.Contains("deadlocked") Then
                    System.Threading.Thread.Sleep(100)
                    deadlockcounter += 1
                    If deadlockcounter > 5 Then
                        CN.Close()
                        Throw ex
                    End If
                Else
                    CN.Close()
                    Throw ex
                End If
            End Try
        Loop



    End Sub
    Public Function ExecuteSP(ByVal spTitle As String, Optional ByVal Params As Collection = Nothing) As DataSet

        Dim CN As SqlConnection = Connection
        Dim CMD As New SqlCommand()
        CMD.Connection = CN
        CMD.CommandType = CommandType.StoredProcedure
        CMD.CommandText = spTitle
        CMD.CommandTimeout = 60
        If Params Is Nothing Then
            'no params to add
        Else
            For Each aParam As SqlParameter In Params
                CMD.Parameters.Add(aParam)
            Next
        End If

        Dim DA As New SqlDataAdapter(CMD)
        Dim DS As New DataSet

        'Dim previousConnectionState As ConnectionState = CN.State
        'If CN.State = ConnectionState.Closed Then
        '    CN.Open()
        'End If
        Dim deadlockcounter = 0
        Do While True = True
            Try
                DA.Fill(DS)
                Exit Do
            Catch ex As Exception
                If ex.Message.Contains("deadlocked") Then
                    System.Threading.Thread.Sleep(100)
                    deadlockcounter += 1
                    If deadlockcounter > 5 Then
                        Throw ex
                    End If
                Else
                    Throw ex
                End If
            End Try
        Loop


        'If previousConnectionState = ConnectionState.Closed Then
        '    CN.Close()
        'End If
        CN.Close()
        ExecuteSP = DS

    End Function

    Public Function ExecuteSQL(ByVal sSql As String) As DataSet

        Dim CN As SqlConnection = Connection
        Dim CMD As New SqlCommand()
        CMD.Connection = CN
        CMD.CommandType = CommandType.Text
        CMD.CommandText = sSql
        CMD.CommandTimeout = 60

        Dim DA As New SqlDataAdapter(CMD)
        Dim DS As New DataSet

        'Dim previousConnectionState As ConnectionState = CN.State
        'If CN.State = ConnectionState.Closed Then
        '    CN.Open()
        'End If
        Dim deadlockcounter = 0
        Do While True = True
            Try
                DA.Fill(DS)
                Exit Do
            Catch ex As Exception
                If ex.Message.Contains("deadlocked") Then
                    System.Threading.Thread.Sleep(100)
                    deadlockcounter += 1
                    If deadlockcounter > 5 Then
                        Throw ex
                    End If
                Else
                    Throw ex
                End If
            End Try
        Loop

        'If previousConnectionState = ConnectionState.Closed Then
        '    CN.Close()
        'End If
        CN.Close()
        ExecuteSQL = DS

    End Function

    Protected Overrides Sub Finalize()
        MyBase.Finalize()
    End Sub
End Class
