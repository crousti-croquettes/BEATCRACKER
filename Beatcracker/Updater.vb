Imports System.ComponentModel
Imports System.IO
Imports System.Net

Friend Class Updater
    Private ReadOnly CurrentVersion As String = "1.9"
    Private CheckVersion As String = "1.9"
    Private updfound As Integer = 0

    'Protective Source <:-
    Protected Overrides ReadOnly Property CreateParams() As CreateParams
        Get
            Dim cp As CreateParams = MyBase.CreateParams
            Const CS_NOCLOSE As Integer = &H200
            cp.ClassStyle = cp.ClassStyle Or CS_NOCLOSE
            Return cp
        End Get
    End Property

    'Update <:-
    Private Sub Updater_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Opacity = 0
        Dim tmr As New Timer
        tmr.Interval = 2
        tmr.Start()
        AddHandler tmr.Tick, Sub()
                                 Opacity += 0.1
                                 If Opacity = 1 Then tmr.Dispose()
                             End Sub

        Appcheck()
        Call New Action(AddressOf CheckForUpdates).BeginInvoke(Nothing, Nothing)
        Dim tmc As String = CurrentVersion.Split(".")(1)
        tmc -= 1
        If File.Exists($"{Application.StartupPath}\Beatcracker {CurrentVersion.Split(".")(0)}.{tmc}.exe") Then
            Try
                File.Delete($"{Application.StartupPath}\Beatcracker {CurrentVersion.Split(".")(0)}.{tmc}.exe")
            Catch ex As Exception
                'Error
            End Try
        End If
    End Sub

    Private Sub Updater_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If Opacity > 0 Then
            e.Cancel = True
        End If
        Dim tmr As New Timer
        tmr.Interval = 1
        tmr.Start()
        AddHandler tmr.Tick, Sub()
                                 If Opacity > 0 Then
                                     Opacity -= 0.1
                                 Else
                                     If updfound <> 3 Then
                                         Login.Show()
                                     End If
                                     tmr.Dispose()
                                     Close()
                                 End If
                             End Sub
    End Sub

    'Check <:-
    Private Async Sub Appcheck()
        Await Task.Delay(120)
        If updfound = 1 Then
            'No updates
            Close()
        ElseIf updfound = 2 Then
            'Update Found
            UpdCSlbl.Text = "UPDATES FOUND!"
            UpdFSlbl.Text = $"Current Version: {CurrentVersion?.ToString}{vbNewLine}New Version: {CheckVersion?.ToString}{vbNewLine}Downloading.."
            Height = 265
            UpdBar.Location = New Point(153, 186)
            Downloadupd()
            updfound = 0
            Exit Sub
        ElseIf updfound = 3 Then
            'No Internet
            Close()
        ElseIf updfound = 4 Then
            'Something went wrong so leave update for next startup
            Close()
        End If
        Appcheck()
    End Sub

    Private Async Sub CheckForUpdates()
        Await Task.Delay(500)
        If My.Computer.Network.IsAvailable = True Then
            Try
                ServicePointManager.Expect100Continue = True
                ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12
                Dim wdownver As WebClient = New WebClient()
                CheckVersion = wdownver.DownloadString("https://beatcracker.tech/version.txt")
                wdownver.Dispose()
                If CurrentVersion = CheckVersion Then
                    updfound = 1
                Else
                    updfound = 2
                End If
            Catch ex As Exception
                updfound = 4
            End Try
        Else
            updfound = 3
        End If
    End Sub

    Private Sub Downloadupd()
        Dim wdownuplink As WebClient = New WebClient()
        Dim nflink As String = Nothing
        Try
            ServicePointManager.Expect100Continue = True
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12
            nflink = wdownuplink.DownloadString("https://beatcracker.tech/download.txt")
        Catch ex As Exception
            'For Errors
        End Try
        If nflink <> Nothing Then
            ServicePointManager.Expect100Continue = True
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12
            Dim wdownp As WebClient = New WebClient
            AddHandler wdownp.DownloadProgressChanged, AddressOf Client_ProgressChanged
            AddHandler wdownp.DownloadFileCompleted, AddressOf Client_DownloadCompleted
            Try
                wdownp.DownloadFileAsync(New Uri(nflink), Application.StartupPath & $"\Beatcracker {CheckVersion.ToString}.exe")
            Catch ex As Exception
                'For Errors
            End Try
        End If
    End Sub

    Private Sub Client_ProgressChanged(sender As Object, e As DownloadProgressChangedEventArgs)
        UpdBar.Animated = False
        GunaLabel5.Visible = False
        UpdFSlbl.Visible = False
        UpdBar.Visible = True
        Dim num As Double = Double.Parse(e.BytesReceived.ToString())
        Dim num2 As Double = Double.Parse(e.TotalBytesToReceive.ToString())
        Dim d As Double = num / num2 * 100.0

        'BunifuCustomLabel3.Text = Conversions.ToString(Integer.Parse(Conversions.ToString(Math.Truncate(d)))) + "%"
        UpdBar.Value = Integer.Parse(Math.Truncate(d).ToString())
    End Sub

    Private Async Sub Client_DownloadCompleted(sender As Object, e As AsyncCompletedEventArgs)
        UpdBar.Visible = False
        UpdBar.Animated = False
        GunaLabel5.Visible = False
        UpdFSlbl.Visible = False
        Await Task.Delay(1000)
        Try
            Process.Start($"{Application.StartupPath}\BeatCracker {CheckVersion?.ToString}.exe")
            End
        Catch ex As Exception
            End
        End Try
    End Sub
End Class
