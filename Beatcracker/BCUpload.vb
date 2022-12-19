Imports System.Net

Friend Class BCUpload
    Private WithEvents WCD As New WebClient
    Private cancelfix As Boolean = False
    Private Progval As Integer = 0

    Protected Overrides ReadOnly Property CreateParams() As CreateParams
        Get
            Dim cp As CreateParams = MyBase.CreateParams
            Const CS_NOCLOSE As Integer = &H200
            cp.ClassStyle = cp.ClassStyle Or CS_NOCLOSE
            Return cp
        End Get
    End Property

    Protected Friend Sub UpStop()
        cancelfix = True
        WCD.CancelAsync()
        WCD.Dispose()
        Dispose()
        Close()
    End Sub

    Protected Friend Sub UpStart(ByRef Username As String, ByRef tmpkey As String, ByRef mmode As String, ByRef uppath As String)
        If uppath.ToString <> Nothing And IO.File.Exists(uppath.ToString) Then
            Rppr()
            AddHandler WCD.UploadProgressChanged, AddressOf Upprogcha
            AddHandler WCD.UploadFileCompleted, AddressOf Upprogchc
            Try
                WCD.UploadFileAsync(New Uri($"https://beatcracker.tech/Dba/uploaddk.php?n={Username?.ToString}&u={tmpkey?.ToString}&p={mmode?.ToString}"), uppath.ToString)
            Catch ex As Exception
            End Try
        End If
    End Sub

    Private Sub Upprogcha(sender As Object, ByVal e As UploadProgressChangedEventArgs)
        If cancelfix = True Then
            Exit Sub
        End If
        Progval = e.ProgressPercentage
    End Sub

    Private Sub Upprogchc(sender As Object, ByVal e As UploadFileCompletedEventArgs)
        If cancelfix = True Then
            Exit Sub
        End If
        Progval = 1000
    End Sub

    Private Async Sub Rppr()
        If cancelfix = True Then
            Exit Sub
        Else
            Await Task.Delay(1000)
            If cancelfix = True Then
                Exit Sub
            End If
            If Progval > 100 Then
                Dashboard.SetUp(False, False, True, Color.Green, 0, "Completed!")
                Rppr()
            Else
                Dashboard.SetUp(True, True, False, Color.LightGreen, Progval, "Uploading!")
            End If
            If cancelfix = True Then
                Exit Sub
            End If
            Rppr()
        End If
    End Sub
End Class
