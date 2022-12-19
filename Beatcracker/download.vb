Imports System.ComponentModel
Imports System.Net

Friend Class download
    Private WithEvents WCD As New WebClient
    Private dmpath As String = ""
    Private dmpathn As String = 0
    Private drksvpath As String = ""
    Private filename As String = ""
    Private cancelfix As Boolean = False
    Private git As Integer = 0

    'Protective Source <:-
    Protected Overrides ReadOnly Property CreateParams() As CreateParams
        Get
            Dim cp As CreateParams = MyBase.CreateParams
            Const CS_NOCLOSE As Integer = &H200
            cp.ClassStyle = cp.ClassStyle Or CS_NOCLOSE
            Return cp
        End Get
    End Property

    Protected Friend Sub DownStop()
        cancelfix = True
        WCD.CancelAsync()
        WCD.Dispose()
        Dispose()
        Close()
    End Sub

    Protected Friend Sub DownStart(ByRef drksvpath As String, ByRef dmpath As String, ByRef giet As Integer)
        git = giet
        Me.drksvpath = drksvpath
        Me.dmpath = dmpath
        filename = dmpath.Replace("%20", " ").Replace("|", "_")
        AddHandler WCD.DownloadProgressChanged, AddressOf Client_ProgressChanged
        AddHandler WCD.DownloadFileCompleted, AddressOf Client_DownloadCompleted
        If drksvpath.Length > 0 AndAlso IO.Directory.Exists(drksvpath.ToString) Then
            Try
                WCD.DownloadFileAsync(New Uri($"https://beatcracker.tech/Drumkit/{dmpath.ToString}"), $"{drksvpath.ToString}\{filename}")
            Catch ex As Exception
            End Try
        Else
            Try
                WCD.DownloadFileAsync(New Uri($"https://beatcracker.tech/Drumkit/{dmpath.ToString}"), Application.StartupPath & $"\{filename}")
            Catch ex As Exception
            End Try
        End If
    End Sub

    Private Sub Client_ProgressChanged(sender As Object, e As DownloadProgressChangedEventArgs)
        Dim tmdbr As Double = Double.Parse(e.BytesReceived.ToString())
        Dim tmdtbr As Double = Double.Parse(e.TotalBytesToReceive.ToString())
        Dim tmdpc As Integer = tmdbr / tmdtbr * 100.0
        If cancelfix = True Then
            WCD.CancelAsync()
            WCD.Dispose()
            Exit Sub
        Else
            Try
                Dashboard.SetDown(True, True, False, tmdpc, False, git)
            Catch ex As Exception
            End Try
        End If
    End Sub

    Private Sub Client_DownloadCompleted(sender As Object, e As AsyncCompletedEventArgs)
        If cancelfix = True Then
            WCD.CancelAsync()
            WCD.Dispose()
            Exit Sub
        Else
            If e?.Error?.ToString = Nothing Then
                Try
                    Dashboard.SetDown(False, False, False, 0, True, git)
                Catch ex As Exception
                End Try
            Else
                Dashboard.SetDown(False, False, False, 0, False, git)
            End If
        End If
        WCD.CancelAsync()
        WCD.Dispose()
        Dispose()
        Close()
    End Sub
End Class