Imports System.IO
Imports System.Net
Imports System.Text

Friend Class LoginClass
    Private unke As String = Nothing
    Private username As String = Nothing
    Private keepdetails As String = Nothing

    Protected Friend Sub CallLogin(username As String, keepdetails As String)
        Me.keepdetails = keepdetails
        Dim uriString As New Uri("http://127.0.0.1/Dba/bclogin.php")
        Dim myWebClient As New WebClient()
        Dim postData As String = $"n={username}&p={keepdetails}|{Date.Now.Day}:{Date.Now.Month}:{Date.Now.Year}|{Date.Now.TimeOfDay.Hours}:{Date.Now.TimeOfDay.Minutes}:{Date.Now.TimeOfDay.Seconds}"
        myWebClient.Headers.Add("Content-Type", "application/x-www-form-urlencoded")
        Dim byteArray As Byte() = Encoding.ASCII.GetBytes(postData)
        AddHandler myWebClient.UploadDataCompleted, AddressOf LUploadDataCompleted
        myWebClient.UploadDataAsync(uriString, "POST", byteArray)
    End Sub

    Private Sub LUploadDataCompleted(sender As Object, e As UploadDataCompletedEventArgs)
        Try
            If e.Cancelled = True Or e.Error.HResult Then
                CheckCL("Cancelled")
            ElseIf e.Error.HResult Then
                CheckCL("Error")
            Else
                Dim data() As Byte = e.Result
                Dim reply As String = Encoding.UTF8.GetString(data)
                CheckCL(reply)
            End If
        Catch ex As Exception
            CheckCL("Error")
        End Try
    End Sub

    Protected Friend Sub CallRegister(username As String, keepdetails As String, emaild As String)
        Me.keepdetails = keepdetails
        Dim uriString As New Uri("http://127.0.0.1/Dba/bclogin.php")
        Dim myWebClient As New WebClient()
        Dim postData As String = $"n={username}&p={keepdetails}&e={emaild}&t={Date.Now.Day}{Date.Now.Month}{Date.Now.Year}{Date.Now.TimeOfDay.Hours}{Date.Now.TimeOfDay.Minutes}{Date.Now.TimeOfDay.Seconds}"
        myWebClient.Headers.Add("Content-Type", "application/x-www-form-urlencoded")
        Dim byteArray As Byte() = Encoding.ASCII.GetBytes(postData)
        AddHandler myWebClient.UploadDataCompleted, AddressOf LUploadDataCompleted
        myWebClient.UploadDataAsync(uriString, "POST", byteArray)
    End Sub

    Private Sub RUploadDataCompleted(sender As Object, e As UploadDataCompletedEventArgs)
        Try
            If e.Cancelled = True Or e.Error.HResult Then
                CheckCL("Cancelled")
            ElseIf e.Error.HResult Then
                CheckCL("Error")
            Else
                Dim data() As Byte = e.Result
                Dim reply As String = Encoding.UTF8.GetString(data)
                CheckCL(reply)
            End If
        Catch ex As Exception
            CheckCL("Error")
        End Try
    End Sub

    Private Sub CheckCL(unke As String)
        If keepdetails <> Nothing And keepdetails <> "Error" And keepdetails <> "HError" And unke <> Nothing Then
            keepdetails = Nothing
            Dim occurCount As Integer = unke.Split("|").Length
            Dim cstat As String
            Dim cunn As String = Nothing
            If occurCount = 2 Then
                Try
                    cstat = unke.Split("|")(0)
                    cunn = unke.Split("|")(1)
                Catch ex As Exception
                    cstat = unke
                End Try
            Else
                cstat = unke
            End If
            unke = Nothing
            occurCount = 0
            If cstat.Contains("Completed") Then
                Try
                    Login.DataSet("Completed", cunn?.ToString)
                Catch ex As Exception
                End Try
            ElseIf cstat.Contains("Wrong") Then
                Try
                    Login.DataSet("Wrong", "")
                Catch ex As Exception
                End Try
            ElseIf cstat.Contains("Exists") Then
                Try
                    Login.DataSet("Exists", "")
                Catch ex As Exception
                End Try
            ElseIf cstat.Contains("Packet") Then
                Try
                    Login.DataSet("Packet", "")
                Catch ex As Exception
                End Try
            ElseIf cstat.Contains("Banned") Then
                Try
                    Login.DataSet("Banned", "")
                Catch ex As Exception
                End Try
            ElseIf cstat = "Error" Then
                Try
                    Login.DataSet("Error", "")
                Catch ex As Exception
                End Try
            Else
                Try
                    Login.DataSet("Error", "")
                Catch ex As Exception
                End Try
            End If
            cstat = Nothing
            cunn = Nothing
        Else
            Try
                Login.DataSet("Error", "")
            Catch ex As Exception
            End Try
        End If
    End Sub
End Class