Imports System.ComponentModel
Imports System.IO
Imports System.Net

Friend Class Dashboard
    'DashCr
    Private IsbL As Boolean = False
    Private Isbdrag As Boolean = False
    Private mousedwnx As Integer
    Private mousedwny As Integer
    Private Msize As Boolean = False
    Private mdowne As Boolean = False
    Private mlefte As Boolean = False
    Private mdolee As Boolean = False
    Private cacc As Boolean = False
    Private cancelfix As Boolean = False
    Private Kdets As String = Nothing
    Private Username As String = Nothing
    Private ReadOnly denchars As String = ":;|+&<>?*/\"""
    Private ReadOnly SUri As New Uri("http://127.0.0.1")
    Private ReadOnly Ssp As ServicePoint = ServicePointManager.FindServicePoint(SUri)
    'Upload
    'Private Pvshelper As Guna.UI.Lib.ScrollBar.PanelScrollHelper
    Private Tupload As New BCUpload
    Private WithEvents TdWCs As New List(Of WebClient)
    Private tdmname As String = Nothing
    Private tdmpath As String = Nothing
    Private tdmpathn As String = 0
#Disable Warning IDE0044 ' Add readonly modifier
    Private Tlista As New List(Of Integer)
#Enable Warning IDE0044 ' Add readonly modifier
    Private tcwclients As String = 0
    Private pendlist As String = Nothing
    Private uppath As String = Nothing
    Private tmpkey As String = Nothing
#Disable Warning IDE0044 ' Add readonly modifier
    Private Tewc As WebClient = New WebClient
#Enable Warning IDE0044 ' Add readonly modifier
    Private tmpname As String = Nothing
    Private tmpfnam As String = Nothing
    Private tmpnumb As String = Nothing
    Private tufpath As String = Nothing
    Private tcuname As String = Nothing
    Private pflesl As Boolean = False
    'Drumkit
    'Private dkvshelper As Guna.UI.Lib.ScrollBar.PanelScrollHelper
#Disable Warning IDE0044 ' Add readonly modifier
    Private dcseldk As New List(Of download)
#Enable Warning IDE0044 ' Add readonly modifier
    Private dmpath As String = Nothing
    Private dmpathn As String = 0
#Disable Warning IDE0044 ' Add readonly modifier
    Private Lista As New List(Of Integer)
#Enable Warning IDE0044 ' Add readonly modifier
    Private cwclients As String = 0
    Private servmdata As String = Nothing
    Private fixmdata As String = Nothing
#Disable Warning IDE0044 ' Add readonly modifier
    Private selmpath As String = Nothing
#Enable Warning IDE0044 ' Add readonly modifier
    Private gmpcount As Integer = 1
    Private useroldheight As String = 0
    Private minfogra As Boolean = False
    Private ftrdrumkit As Boolean = True
    Private mpvcha As Boolean = False

    'Protective Source <:-
    Protected Overrides ReadOnly Property CreateParams() As CreateParams
        Get
            Dim cp As CreateParams = MyBase.CreateParams
            Const CS_NOCLOSE As Integer = &H200
            cp.ClassStyle = cp.ClassStyle Or CS_NOCLOSE
            Return cp
        End Get
    End Property

    'Dashboard Managed <:-
    'Dim vScrollHelper As Guna.UI.Lib.ScrollBar.PanelScrollHelper
    Private Sub Dashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Opacity = 0
        ' Login.Retkk(Kdets, Username)
        ' If Kdets = "Null" Or Username = "Null" Then End
        'Guna.UI.Lib.GraphicsHelper.ShadowForm(Me)
        ShowInTaskbar = True
        Dim tmr As New Timer With {
            .Interval = 2
        }
        tmr.Start()
        AddHandler tmr.Tick, Sub()
                                 If Opacity = 1 Then
                                     'MaximumSize = Screen.FromControl(Me).WorkingArea.Size
                                     hmsgulbl.Text = $"@{Username?.ToString}"
                                     'dkvshelper = New Guna.UI.Lib.ScrollBar.PanelScrollHelper(drmkitlist, GunaVScrollBar1, True)
                                     'Pvshelper = New Guna.UI.Lib.ScrollBar.PanelScrollHelper(PUpbox, pendVSBar, True)
                                     ServicePointManager.Expect100Continue = True
                                     ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12
                                     Ssp.ConnectionLimit = 4
                                     tmr.Dispose()
                                 Else
                                     Opacity += 0.1
                                 End If
                             End Sub
        'vScrollHelper = New Guna.UI.Lib.ScrollBar.PanelScrollHelper(feed, GunaVScrollBar4, True)
        'vScrollHelper.UpdateScrollBar()

        'DASHBOARD LOADING IMAGE //////////////////////

        OBldimage.Image = New System.Drawing.Bitmap(New IO.MemoryStream(New System.Net.WebClient().DownloadData("http://127.0.0.1/img/eeee.png")))
        ' artist1.Image = New System.Drawing.Bitmap(New IO.MemoryStream(New System.Net.WebClient().DownloadData("https://i1.sndcdn.com/avatars-fPr8RJybb0NuOvmE-zGPtbw-t500x500.jpg")))
        ' artist2.Image = New System.Drawing.Bitmap(New IO.MemoryStream(New System.Net.WebClient().DownloadData("https://i1.sndcdn.com/avatars-000710983876-1rsewi-t500x500.jpg")))
        ' artist3.Image = New System.Drawing.Bitmap(New IO.MemoryStream(New System.Net.WebClient().DownloadData("https://i1.sndcdn.com/avatars-BnnuVTfE01z2emvT-30zFrQ-t500x500.jpg")))
        ' artist4.Image = New System.Drawing.Bitmap(New IO.MemoryStream(New System.Net.WebClient().DownloadData("https://i1.sndcdn.com/avatars-t3e8pKrleXlp22WP-Fq2qew-t500x500.jpg")))

        '//////////////////////

    End Sub

    Private Sub Dashboard_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If Opacity > 0 Then
            e.Cancel = True
            If cacc = True Then
                If MsgBox("A transfer is in progress." & vbNewLine & "Do you really want to close the program?", MsgBoxStyle.YesNo, "BeatCracker") = MsgBoxResult.Yes Then
                    cancelfix = True
                    If Tewc.IsBusy = True Then
                        Tewc.CancelAsync()
                    End If
                    Tewc.Dispose()
                    If Tupload.Visible = True Then
                        Tupload.UpStop()
                    End If
                    If TdWCs.Count > 0 Then
                        For Each tpdown As WebClient In TdWCs
                            If tpdown.IsBusy = True Then
                                tpdown.CancelAsync()
                            End If
                            tpdown.Dispose()
                        Next
                        TdWCs.Clear()
                    End If
                    If dcseldk.Count > 0 Then
                        For Each tddown As download In dcseldk
                            If tddown.Visible = True Then
                                tddown.DownStop()
                                tddown.Dispose()
                                tddown.Close()
                            End If
                        Next
                        dcseldk.Clear()
                    End If
                Else
                    Exit Sub
                End If
            End If
            Try
                Dim logreq As HttpWebRequest
                Dim enc As Text.UTF8Encoding = New Text.UTF8Encoding()
                Dim postdata As String
                Dim postdatabytes As Byte()
                logreq = WebRequest.Create($"http://127.0.0.1/Dba/bclog.php")
                logreq.Method = "POST"
                logreq.KeepAlive = False
                logreq.AllowAutoRedirect = False
                logreq.AllowWriteStreamBuffering = False
                logreq.ContentType = "application/x-www-form-urlencoded"
                postdata = $"n={Username?.ToString}&u={Kdets?.ToString}"
                postdatabytes = enc.GetBytes(postdata)
                logreq.ContentLength = postdatabytes.Length
                Dim Stream = logreq.GetRequestStream()
                Stream.Write(postdatabytes, 0, postdatabytes.Length)
                Stream.Close()
                'Close Con
                logreq.GetResponse.Close()
                postdata = "00000"
                postdatabytes = enc.GetBytes(postdata)
            Catch ex As Exception
            End Try
        End If
        Dim tmr As New Timer
        tmr.Interval = 1
        tmr.Start()
        AddHandler tmr.Tick,
        Sub()
            If Opacity > 0 Then
                Opacity -= 0.1
            Else
                Kdets = Nothing
                Username = Nothing
                Login.Show()
                tmr.Dispose()
                Close()
            End If
        End Sub
    End Sub

    Private Sub Dashboard_MouseDown(sender As Object, e As MouseEventArgs) Handles Me.MouseDown
        If e.Button = MouseButtons.Left AndAlso Size <> MaximumSize Then
            Dim p As Point = PointToClient(MousePosition)
            If p.X > Width - 15 And p.Y > Height - 15 Then
                Cursor = Cursors.SizeNWSE
                mdolee = True
                mlefte = False
                mdowne = False
            ElseIf p.X > Width - 15 And p.Y < Height - 15 Then
                Cursor = Cursors.SizeWE
                mdolee = False
                mdowne = False
                mlefte = True
            ElseIf p.X < Width - 15 And p.Y > Height - 15 Then
                Cursor = Cursors.SizeNS
                mdolee = False
                mlefte = False
                mdowne = True
            ElseIf p.Y <= 40 And Isbdrag = False Then
                Isbdrag = True
                mousedwnx = e.X
                mousedwny = e.Y
            End If
        ElseIf e.Button = MouseButtons.Left And Size = MaximumSize Then
            Dim tmp As Point = New Point()
            tmp.X = Location.X + (e.X - mousedwnx)
            tmp.Y = Location.Y + (e.Y - mousedwny)
            Location = tmp
        Else
            Cursor = DefaultCursor
        End If
    End Sub

    Private Sub Dashboard_MouseUp(sender As Object, e As MouseEventArgs) Handles Me.MouseUp
        If e.Button = MouseButtons.Left Then
            Isbdrag = False
            Cursor = DefaultCursor
            mdolee = False
            mdowne = False
            mlefte = False
        ElseIf e.Button = MouseButtons.Right AndAlso IsbL = False Then
            Isbdrag = False
        End If
    End Sub

    Private Sub Dashboard_MouseMove(sender As Object, e As MouseEventArgs) Handles Me.MouseMove
        If Isbdrag = False Then
            If e.Button = MouseButtons.Left And Size <> MaximumSize Then
                Dim XOffset, YOffset As Integer
                If mdolee = True Then
                    XOffset = e.X - (Size.Width)
                    YOffset = e.Y - (Size.Height)
                    Cursor = Cursors.SizeNWSE
                ElseIf mlefte = True Then
                    YOffset = 0
                    XOffset = e.X - (Size.Width)
                    Cursor = Cursors.SizeWE
                ElseIf mdowne = True Then
                    XOffset = 0
                    YOffset = e.Y - (Size.Height)
                    Cursor = Cursors.SizeNS
                End If
                If Size <> MaximumSize Then
                    Size = New Size(Size.Width + XOffset, Size.Height + YOffset)
                Else
                    Return
                End If
            ElseIf Size <> MaximumSize Then
                Dim p As Point = PointToClient(MousePosition)
                If p.X > Width - 15 And p.Y > Height - 15 Then
                    Cursor = Cursors.SizeNWSE
                ElseIf p.X > Width - 15 And p.Y < Height - 15 Then
                    Cursor = Cursors.SizeWE
                ElseIf p.X < Width - 15 And p.Y > Height - 15 Then
                    Cursor = Cursors.SizeNS
                Else
                    Cursor = DefaultCursor
                End If
            Else
                Cursor = DefaultCursor
                Return
            End If
        Else
            Dim tmp As Point = New Point()
            tmp.X = Location.X + (e.X - mousedwnx)
            tmp.Y = Location.Y + (e.Y - mousedwny)
            Location = tmp
        End If
    End Sub

    Private Sub Dashboard_Move(sender As Object, e As EventArgs) Handles Me.Move
        If Size = MaximumSize And Isbdrag = True Then
            Size = New Size(1050, 640)
            'DMaxbtt.BackgroundImage = My.Resources.maxwind
            Return
        End If
    End Sub

    Private Sub Dashboard_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        'If dkvshelper IsNot Nothing Then dkvshelper.UpdateScrollBar()
        'If Pvshelper IsNot Nothing Then Pvshelper.UpdateScrollBar()
        If Size = MaximumSize Then
            CenterToScreen()
            Cursor = Cursors.Default
            Msize = True
            Try
                'DMaxbtt.BackgroundImage = My.Resources.norwind
            Catch ex As Exception
                'Error
            End Try
        Else
            Try
                'DMaxbtt.BackgroundImage = My.Resources.maxwind
            Catch ex As Exception
                'Error
            End Try
        End If
        Refresh()
    End Sub

    Private Sub Dashboard_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles Me.MouseDoubleClick
        If Size <> MaximumSize Then
            WindowState = FormWindowState.Maximized
        ElseIf Size = MaximumSize And Msize = False Then
            WindowState = FormWindowState.Normal
        ElseIf Size = MaximumSize And Msize = True Then
            Size = New Size(1050, 640)
            WindowState = FormWindowState.Normal
            CenterToScreen()
        End If
    End Sub

    Private Sub Dashboard_GotFocus(sender As Object, e As EventArgs) Handles Me.GotFocus
        Cursor = DefaultCursor
    End Sub

    Private Sub Dashboard_MouseLeave(sender As Object, e As EventArgs) Handles Me.MouseLeave
        Cursor = DefaultCursor
    End Sub

    Private Sub DMaxbtt_MouseUp(sender As Object, e As MouseEventArgs)
        If Size <> MaximumSize Then
            Try
                'DMaxbtt.BackgroundImage = My.Resources.maxwind
            Catch ex As Exception
            End Try
        Else
            Try
                'DMaxbtt.BackgroundImage = My.Resources.norwind
            Catch ex As Exception
            End Try
        End If
    End Sub

    Private Sub DMaxbtt_MouseMove(sender As Object, e As MouseEventArgs)
        If Size = MaximumSize Then
            Try
                'DMaxbtt.BackgroundImage = My.Resources.norhwind
            Catch ex As Exception
            End Try
        Else
            Try
                'DMaxbtt.BackgroundImage = My.Resources.maxhwind
            Catch ex As Exception
            End Try
        End If
    End Sub

    Private Sub DMaxbtt_MouseLeave(sender As Object, e As EventArgs)
        If Size = MaximumSize Then
            Try
                'DMaxbtt.BackgroundImage = My.Resources.norwind
            Catch ex As Exception
            End Try
        Else
            Try
                'DMaxbtt.BackgroundImage = My.Resources.maxhwind
            Catch ex As Exception
            End Try
        End If
    End Sub

    Private Sub DMaxbtt_Click(sender As Object, e As EventArgs)

        If WindowState = FormWindowState.Maximized Then
            WindowState = FormWindowState.Normal
            Try
                ' DMaxbtt.BackgroundImage = My.Resources.maxwind
            Catch ex As Exception
                'Error
            End Try
        ElseIf WindowState = FormWindowState.Normal And Size <> MaximumSize Then
            WindowState = FormWindowState.Maximized
            Try
                'DMaxbtt.BackgroundImage = My.Resources.norwind
            Catch ex As Exception
                'Error
            End Try
        Else
            Size = New Size(1329, 700)
            Try
                'DMaxbtt.BackgroundImage = My.Resources.maxwind
            Catch ex As Exception
                'Error
            End Try
        End If
    End Sub

    Private Sub DlTbox_Click(sender As Object, e As EventArgs)
        Process.Start("https://beatcracker.tech")
    End Sub

    ':>Buttons

    Private Sub Ovrvbtt_Click(sender As Object, e As EventArgs) Handles Ovrvbtt.Click
        UploadBox.Hide()
        DownloadBox.Hide()
        OverviewBox.Show()
    End Sub

    Private Sub Uploadsbtt_Click(sender As Object, e As EventArgs) Handles Uploadsbtt.Click
        OverviewBox.Hide()
        DownloadBox.Hide()
        UploadBox.Show()
        'Pvshelper.UpdateScrollBar()
    End Sub

    Private Sub Dkitsbtt_Click(sender As Object, e As EventArgs) Handles Dkitsbtt.Click
        OverviewBox.Hide()
        UploadBox.Hide()
        DownloadBox.Show()
        If DBKits.Visible = True Then
            If mpvcha = False Then
                If DBKits.Visible = True And drmkitlist.Controls.Count = 0 Then
                    dkfirload.Show()
                End If
                'dkvshelper.UpdateScrollBar()
                Call New Action(AddressOf Getmlist).BeginInvoke(Nothing, Nothing)
                Listcreator()
                mpvcha = True
            End If
        End If
    End Sub

    'Overview <:-

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs)
        'imgvideo.Visible = False
        'Dim html As String = "<html><head>"
        ' html &= "<meta content='IE=Edge' http-equiv='X-UA-Compatible'/>"
        'html &= "<iframe id='video' src= 'https://www.youtube.com/embed/{0}' width='560' height='315' frameborder='0' allowfullscreen='allowfullscreen'></iframe>"
        'html &= "</body></html>"
        'Me.WebBrowser1.DocumentText = String.Format(html, txtUrl.Text.Split("=")(1))
    End Sub

    Private Sub OSubsbtt_Click(sender As Object, e As EventArgs)
        Subsbtt.PerformClick()
    End Sub

    'Upload <:-

    Private Sub Ubcdbtt_Click(sender As Object, e As EventArgs)
        '  If PUpbox.Visible = True Then

        '   PUpbox.Visible = False
        '  PUpbox.Enabled = False
        ' Else
        ' PUpbox.Enabled = True
        ' PUpbox.Visible = True

        If pflesl = False Then
            Call New Action(AddressOf Renddrkit).BeginInvoke(Nothing, Nothing)
            Pendlistcr()
            pflesl = True
        End If
        ' End If
    End Sub

    Private Sub UDDbox_DragEnter(sender As Object, e As DragEventArgs)
        If e.Data.GetDataPresent(DataFormats.FileDrop) = True Then
            Dim tfile As String = e?.Data?.GetData(DataFormats.FileDrop)(0)
            If tfile.EndsWith(".rar") Or tfile.EndsWith(".zip") Then
                e.Effect = DragDropEffects.Move
            Else
                e.Effect = DragDropEffects.None
            End If
        End If
    End Sub

    Private Sub UDDbox_DragDrop(sender As Object, e As DragEventArgs)
        If e.Data.GetDataPresent(DataFormats.FileDrop) = True Then
            If e.Effect = DragDropEffects.Move Then
                Dim tupfilet As String = e?.Data?.GetData(DataFormats.FileDrop)(0).ToString
                If tupfilet.EndsWith(".rar") Or tupfilet.EndsWith(".zip") AndAlso tupfilet.Contains("\") Then
                    Dim ocfnlc As Integer = tupfilet.Split("\").Length.ToString
                    If ocfnlc > 1 Then
                        ocfnlc -= 1
                    Else
                        Exit Sub
                    End If
                    Dim tmten As String = tupfilet.Split("\")(ocfnlc)
                    ocfnlc = 0
                    For Each la As Char In tmten
                        If denchars.Contains(la) Then
                            ' Upinfofn.Text = tmten?.ToString
                            '  Upinfofp.Text = tupfilet?.ToString
                            tmten = ""
                            tupfilet = ""
                            Exit Sub
                        End If
                    Next
                    '  Upinfofn.Text = tmten.ToString
                    '  Upinfofp.Text = tupfilet.ToString
                    tmten = ""
                    tupfilet = ""
                End If
            End If
        End If
    End Sub

    Private Sub UBupcbtt_Click(sender As Object, e As EventArgs)
        '  upcstats.Text = "Waiting."
        ' upcstats.ForeColor = Color.Orange
        UplKitC()
    End Sub

    Private Sub Upinfofn_KeyPress(sender As Object, e As KeyPressEventArgs)
        If denchars.Contains(e.KeyChar) <> False Then
            e.Handled = True
            Return
        End If
    End Sub

    Private Sub Upkbbtt_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs)
        UplKitC()
    End Sub

    Private Sub UplKitC()
        'UploadDkbtt.Enabled = False
        'UploadDkbtt.Visible = False
        ' upcstats.Visible = True
        Dim tupfiled As OpenFileDialog = New OpenFileDialog With {
            .Title = "BeatCracker: Choose file to upload",
            .Filter = "Files|*.zip;*.rar;"
        }
        tupfiled.ShowDialog()
        If tupfiled.FileName <> "" Then
            If tupfiled.SafeFileName.Contains(":") Or tupfiled.SafeFileName.Contains(";") Or tupfiled.SafeFileName.Contains("&") Or tupfiled.SafeFileName.Contains("|") Or tupfiled.SafeFileName.Contains("<") Or tupfiled.SafeFileName.Contains(">") Or tupfiled.SafeFileName.Contains("""") Or tupfiled.SafeFileName.Contains("?") Or tupfiled.SafeFileName.Contains("*") Or tupfiled.SafeFileName.Contains("/") Or tupfiled.SafeFileName.Contains("\") Or tupfiled.SafeFileName.Contains("+") Then
                If MsgBox("File name is not supported!" & vbNewLine & "Do you want the file to be auto renamed?", MsgBoxStyle.YesNo, "BeatCracker") = MsgBoxResult.Yes Then
                    '  upcstats.Text = "Preparing."
                    '  upcstats.ForeColor = Color.Orange
                    tcuname = tupfiled.SafeFileName.ToString.Replace(":", "_").Replace(";", "_").Replace("&", "_").Replace("|", "_").Replace("<", "_").Replace(">", "_").Replace("""", "_").Replace("?", "_").Replace("*", "_").Replace("/", "_").Replace("\", "_").Replace("+", "_")
                    tufpath = tupfiled.FileName.ToString.Replace(tupfiled.SafeFileName.ToString, "") & tcuname.ToString
                    '  Upinfofn.ForeColor = Color.White
                    ' Upinfofn.Text = tcuname.ToString
                    '  Upinfofp.Text = tufpath.ToString
                    Try
                        If File.Exists(tufpath.ToString) Then
                            File.Delete(tufpath.ToString)
                            File.Copy(tupfiled.FileName.ToString, tufpath.ToString)
                        Else
                            File.Copy(tupfiled.FileName.ToString, tufpath.ToString)
                        End If
                    Catch ex As Exception
                        'Error
                    End Try
                    Dim infoReader As System.IO.FileInfo = My.Computer.FileSystem.GetFileInfo(tupfiled.FileName)
                    If infoReader.Length.ToString >= 1073741824 Then
                        '  Upinfofs.Text = Format(infoReader.Length.ToString / 1024 / 1024 / 1024, "#0.00") & " GB"
                    ElseIf infoReader.Length.ToString >= 1048576 Then
                        '   Upinfofs.Text = Format(infoReader.Length.ToString / 1024 / 1024, "#0.00") & " MB"
                    ElseIf infoReader.Length.ToString >= 1024 Then
                        '   Upinfofs.Text = Format(infoReader.Length.ToString / 1024, "#0.00") & " KB"
                    ElseIf infoReader.Length.ToString < 1024 Then
                        '  Upinfofs.Text = Fix(infoReader.Length.ToString) & " Bytes"
                    End If
                    Uploadfile(tufpath.ToString, tcuname)
                Else
                    tupfiled.Dispose()
                    '  Upinfofn.Text = "Error with file name."
                    ' Upinfofn.ForeColor = Color.Crimson
                    'UploadDkbtt.Enabled = True
                    'UploadDkbtt.Visible = True

                End If
            Else
                '  upcstats.Text = "Preparing."
                '  upcstats.ForeColor = Color.Orange
                Dim infoReader As System.IO.FileInfo = My.Computer.FileSystem.GetFileInfo(tupfiled.FileName)
                ' Upinfofn.ForeColor = Color.White
                '   Upinfofn.Text = tupfiled.SafeFileName.ToString
                '  Upinfofp.Text = tupfiled.FileName.ToString
                ' Upinfoan.Text = Username.ToString
                If infoReader.Length.ToString >= 1073741824 Then
                    '   Upinfofs.Text = Format(infoReader.Length.ToString / 1024 / 1024 / 1024, "#0.00") & " GB"
                ElseIf infoReader.Length.ToString >= 1048576 Then
                    '  Upinfofs.Text = Format(infoReader.Length.ToString / 1024 / 1024, "#0.00") & " MB"
                ElseIf infoReader.Length.ToString >= 1024 Then
                    '  Upinfofs.Text = Format(infoReader.Length.ToString / 1024, "#0.00") & " KB"
                ElseIf infoReader.Length.ToString < 1024 Then
                    '    Upinfofs.Text = Fix(infoReader.Length.ToString) & " Bytes"
                End If
                Uploadfile(tupfiled.FileName.ToString, tupfiled.SafeFileName.ToString)
            End If
        Else
            tupfiled.Dispose()
            'UploadDkbtt.Enabled = True
            Exit Sub
        End If
    End Sub

    Private Sub Uploadfile(ByVal uppath As String, ByVal upname As String)
        If My.Computer.Network.IsAvailable = True Then
            cacc = True
            Try
                '  upcstats.ForeColor = Color.Yellow
                Dim reqmdata As HttpWebRequest
                Dim resmdata As HttpWebResponse
                Dim mdatastream As StreamReader
                Dim enc As Text.UTF8Encoding = New Text.UTF8Encoding()
                Dim postdata As String
                Dim postdatabytes As Byte()
                reqmdata = WebRequest.Create($"http://127.0.0.1/Dba/tupked.php")
                reqmdata.Method = "POST"
                reqmdata.KeepAlive = False
                reqmdata.AllowAutoRedirect = False
                reqmdata.ContentType = "application/x-www-form-urlencoded"
                postdata = $"n={Username?.ToString}&u={Kdets?.ToString}&f={upname?.ToString}"
                postdatabytes = enc.GetBytes(postdata)
                reqmdata.ContentLength = postdatabytes.Length
                Dim Stream = reqmdata.GetRequestStream()
                Stream.Write(postdatabytes, 0, postdatabytes.Length)
                Stream.Close()
                resmdata = reqmdata.GetResponse()
                mdatastream = New StreamReader(resmdata.GetResponseStream)
                tmpkey = mdatastream.ReadToEnd
                Me.uppath = uppath
                'Close connection
                reqmdata.GetResponse.Close()
                resmdata.GetResponseStream.Close()
                resmdata.Close()
                mdatastream.Close()
                postdata = "00000"
                postdatabytes = enc.GetBytes(postdata)

                '  upprogbar.Value = 0
                '  upprogbar.Visible = True
                'UploadDkbtt.Visible = False

                Dim tmpmod As String = ""
                If GunaAdvenceButton9.Checked = True Then
                    tmpmod = "d"
                ElseIf GunaAdvenceButton24.Checked = True Then
                    tmpmod = "f"
                Else
                    tmpmod = "g"
                End If
                Tupload = New BCUpload
                Tupload.Show()
                Tupload.UpStart(Username.ToString, tmpkey.ToString, tmpmod.ToString, uppath.ToString)
                tmpkey = ""
                tmpmod = ""
            Catch ex As Exception
                '   upcstats.Text = "Error!"
                '  upcstats.ForeColor = Color.Crimson
                tmpkey = Nothing
                cacc = False
                'UploadDkbtt.Enabled = True
                'UploadDkbtt.Visible = True

            End Try
        Else
            '  upcstats.Text = "Error!"
            ' upcstats.ForeColor = Color.Crimson
            tmpkey = Nothing
            cacc = False
            'UploadDkbtt.Enabled = True
            'UploadDkbtt.Visible = True
        End If
    End Sub

    Protected Friend Sub SetUp(ByRef workn As Boolean, ByRef gpv As Boolean, ByRef gbte As Boolean, ByRef gcpv As Color, ByRef gpcv As Integer, ByRef gcim As String)
        Try
            If workn = True Or workn = False Then
                cacc = workn
            End If
            If gpv = True Or gpv = False Then
                ' upprogbar.Visible = gpv
            End If
            If gpcv >= 0 AndAlso gpcv < 101 Then
                '   upprogbar.Value = gpcv
            End If
            '  If upcstats.Text <> "" Then
            '   upcstats.Text = gcim.ToString
            ' End If
            If gcpv.IsEmpty = False Then
                ' upcstats.ForeColor = gcpv
            End If
            If gbte = True Or gbte = False Then
                'UploadDkbtt.Enabled = gbte
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub Renddrkit()
        If My.Computer.Network.IsAvailable = True AndAlso Visible = True Then
            Try
                Dim reqmdata As HttpWebRequest
                Dim resmdata As HttpWebResponse
                Dim mdatastream As StreamReader
                Dim enc As Text.UTF8Encoding = New Text.UTF8Encoding()
                Dim postdata As String
                Dim postdatabytes As Byte()
                reqmdata = WebRequest.Create($"http://127.0.0.1/Dba/pendmfl.php")
                reqmdata.Method = "POST"
                reqmdata.KeepAlive = False
                reqmdata.AllowAutoRedirect = False
                reqmdata.ContentType = "application/x-www-form-urlencoded"
                postdata = $"n={Username?.ToString}&u={Kdets?.ToString}"
                postdatabytes = enc.GetBytes(postdata)
                reqmdata.ContentLength = postdatabytes.Length
                Dim Stream = reqmdata.GetRequestStream()
                Stream.Write(postdatabytes, 0, postdatabytes.Length)
                Stream.Close()
                resmdata = reqmdata.GetResponse()
                mdatastream = New StreamReader(resmdata.GetResponseStream)
                pendlist = mdatastream.ReadToEnd
                If pendlist = Nothing Then
                    pendlist = "None"
                End If
                'Close connection
                reqmdata.GetResponse.Close()
                resmdata.GetResponseStream.Close()
                resmdata.Close()
                mdatastream.Close()
                postdata = "00000"
                postdatabytes = enc.GetBytes(postdata)
            Catch ex As Exception
                pendlist = "None"
            End Try
        Else
            pendlist = "Int"
        End If
        Exit Sub
    End Sub

    Private Async Sub Pendlistcr()
        Await Task.Delay(1200)
        If UploadBox.Visible = True Then
            Dim mlcon As String = Nothing
            If pendlist IsNot Nothing And pendlist <> "None" And pendlist <> "Int" Then
                '  PUpbox.Controls.Clear()
                mlcon = pendlist
                pendlist = Nothing
                Dim upgmp As Integer = 1
                Dim puuseroldh As String = 0
                For Each line In mlcon.Split(";")
                    If line IsNot "" AndAlso line IsNot " " Then
                        Dim fowname As String = Nothing
                        Dim refilen As String = Nothing
                        Dim filesize As String = Nothing
                        Dim selfilesize As String = Nothing
                        Try
                            Dim occurCount As Integer = line.Split(":").Length
                            If occurCount = 3 Then
                                fowname = line.Split(":")(0)
                                refilen = line.Split(":")(1)
                                filesize = line.Split(":")(2)
                            Else
                                refilen = line.Split(":")(0)
                                filesize = line.Split(":")(1)
                            End If
                            If refilen(refilen.Length - 2) = "." Then
                                Exit Try
                            End If
                            If filesize >= 1073741824 Then
                                selfilesize = Format(filesize / 1024 / 1024 / 1024, "#0.00") & " GB"
                            ElseIf filesize >= 1048576 Then
                                selfilesize = Format(filesize / 1024 / 1024, "#0.00") & " MB"
                            ElseIf filesize >= 1024 Then
                                selfilesize = Format(filesize / 1024, "#0.00") & " KB"
                            ElseIf filesize < 1024 Then
                                selfilesize = Fix(filesize) & " Bytes"
                            End If
                            'Create area
                            Dim newbox As Panel
                            newbox = New Panel With {
                                .Anchor = AnchorStyles.Left Or AnchorStyles.Right Or AnchorStyles.Top,
                                .Dock = DockStyle.None,
                                .AutoSize = True,
                                .Name = "GunaP" & upgmp,
                                .BackColor = Color.FromArgb(37, 35, 63),
                                .ForeColor = Color.FromArgb(37, 35, 63),
                                .Padding = New Padding(6, 10, 6, 10)
                            }
                            '    PUpbox.Controls.Add(newbox)
                            newbox.AutoSize = False
                            ' If PUpbox.VerticalScroll.Visible = True Then
                            'newbox.Width = PUpbox.Width - 23
                            'Else
                            ' newbox.Width = PUpbox.Width - 4
                            'End If
                            newbox.Height = 50
                            newbox.Location = New Point(2)
                            ' newbox.Top = puuseroldh + 5 - PUpbox.VerticalScroll.Value
                            '  puuseroldh = newbox.Top + PUpbox.VerticalScroll.Value + 50
                            'Insert image
                            Dim newfipi As PictureBox
                            newfipi = New PictureBox With {
                                .Anchor = AnchorStyles.Top Or AnchorStyles.Left,
                                .Dock = DockStyle.None,
                                .AutoSize = False,
                                .Height = 39,
                                .Width = 30,
                                .Name = "GunaPFpi" & upgmp,
                                .BackColor = Color.Transparent,
                                .SizeMode = PictureBoxSizeMode.Zoom
                            }
                            Try
                                If line.Contains(".zip") Then
                                    newfipi.Image = My.Resources.zip_52px
                                    'newfipi.Image = My.Resources.verified_account_48px
                                ElseIf line.Contains(".rar") Then
                                    newfipi.Image = My.Resources.rar_52px
                                    'newfipi.Image = My.Resources.verified_account_48px
                                End If
                            Catch ex As Exception
                            End Try
                            newfipi.Location = New Point(7, 6)
                            newbox.Controls.Add(newfipi)
                            'Create text
                            Dim newfile As TextBox
                            newfile = New TextBox With {
                                .Anchor = AnchorStyles.Top Or AnchorStyles.Left,
                                .Dock = DockStyle.None,
                                .BorderStyle = BorderStyle.None,
                                .Cursor = DefaultCursor,
                                .ReadOnly = True,
                                .ShortcutsEnabled = False,
                                .SelectionLength = 0,
                                .SelectionStart = 0,
                                .TabStop = True,
                                .HideSelection = True,
                                .MaxLength = 500,
                                .AutoSize = True,
                                .TextAlign = HorizontalAlignment.Left,
                                .Font = New Font("Segoe UI Emoji", 11, FontStyle.Regular),
                                .Name = "GunaPF" & upgmp,
                                .BackColor = Color.FromArgb(37, 35, 63),
                                .ForeColor = Color.White
                            }
                            Try
                                newfile.Text = refilen
                            Catch ex As Exception
                            End Try
                            newfile.Location = New Point(47, 1)
                            newbox.Controls.Add(newfile)
                            Dim nmtsize As String = newfile.Width.ToString
                            newfile.AutoSize = False
                            newfile.Height = 24
                            If fowname <> Nothing Then
                                newfile.Width = newbox.Width - 230
                            Else
                                newfile.Width = newbox.Width - 10
                            End If
                            'Create info text
                            Dim newstfile As Label
                            newstfile = New Label With {
                                .Anchor = AnchorStyles.Top Or AnchorStyles.Left,
                                .Dock = DockStyle.None,
                                .AutoSize = True,
                                .TextAlign = ContentAlignment.MiddleLeft,
                                .Font = New Font("Segoe UI Emoji", 8, FontStyle.Italic),
                                .Name = "GunaPsF" & upgmp,
                                .BackColor = Color.Transparent,
                                .ForeColor = Color.LightGray
                            }
                            Try
                                If fowname <> Nothing Then
                                    newstfile.Text = $"Posted by: {fowname.ToString} / File size: {selfilesize.ToString}"
                                Else
                                    newstfile.Text = $"File size: {selfilesize.ToString}"
                                End If
                            Catch ex As Exception
                            End Try
                            newstfile.Location = New Point(47, 25)
                            newbox.Controls.Add(newstfile)
                            Dim newstfiletw As String = newstfile.Width.ToString
                            newstfile.AutoSize = False
                            newstfile.Height = 18
                            newstfile.Width = newstfiletw
                            newstfile.BringToFront()
                            If fowname <> Nothing Then
                                'Create Deny Button
                                Dim newpden As Button
                                newpden = New Button
                                newpden.Anchor = AnchorStyles.Top Or AnchorStyles.Right
                                newpden.Dock = DockStyle.None
                                newpden.AutoSize = False
                                newpden.Height = 19
                                newpden.Width = 70
                                'newpden.Radius = 2
                                'newpden.GradientMode = Drawing2D.LinearGradientMode.Horizontal
                                newpden.Name = $"{fowname.ToString}:" & Replace(refilen, " ", "%20") & $":{upgmp}"
                                newpden.BackColor = Color.Transparent
                                newpden.ForeColor = Color.White
                                'newpden.BaseColor1 = Color.FromArgb(50, 36, 177)
                                'newpden.BaseColor2 = Color.FromArgb(113, 54, 252)
                                'newpden.OnHoverBaseColor1 = Color.FromArgb(155, 145, 221)
                                'newpden.OnHoverBaseColor2 = Color.FromArgb(255, 85, 255)
                                'newpden.Animated = True
                                'newpden.AnimationHoverSpeed = 0.07
                                'newpden.AnimationSpeed = 0.03
                                'newpden.TextRenderingHint = Guna.UI.WinForms.DrawingTextRenderingHint.SystemDefault
                                Try
                                    newpden.Image = Nothing
                                Catch ex As Exception
                                End Try
                                newpden.Text = "Deny"
                                newpden.TextAlign = HorizontalAlignment.Center
                                newpden.Location = New Point(newbox.Width - newpden.Width - 7, 27)
                                newbox.Controls.Add(newpden)
                                'AddHandler newpden.MouseClick, AddressOf Denydkit
                                'Create Accept Button
                                Dim newpacc As Button
                                newpacc = New Button
                                newpacc.Anchor = AnchorStyles.Top Or AnchorStyles.Right
                                newpacc.Dock = DockStyle.None
                                newpacc.AutoSize = False
                                newpacc.Height = 19
                                newpacc.Width = 70
                                'newpacc.Radius = 2
                                'newpacc.GradientMode = Drawing2D.LinearGradientMode.Horizontal
                                newpacc.Name = $"{fowname.ToString}:" & Replace(refilen, " ", "%20") & $":{upgmp}"
                                newpacc.BackColor = Color.Transparent
                                newpacc.ForeColor = Color.White
                                'newpacc.BaseColor1 = Color.FromArgb(50, 36, 177)
                                'newpacc.BaseColor2 = Color.FromArgb(113, 54, 252)
                                'newpacc.OnHoverBaseColor1 = Color.FromArgb(155, 145, 221)
                                'newpacc.OnHoverBaseColor2 = Color.FromArgb(255, 85, 255)
                                'newpacc.Animated = True
                                'newpacc.AnimationHoverSpeed = 0.07
                                'newpacc.AnimationSpeed = 0.03
                                'newpacc.TextRenderingHint = Guna.UI.WinForms.DrawingTextRenderingHint.SystemDefault
                                Try
                                    newpacc.Image = Nothing
                                Catch ex As Exception
                                End Try
                                newpacc.Text = "Accept"
                                newpacc.TextAlign = HorizontalAlignment.Center
                                newpacc.Location = New Point(newbox.Width - newpacc.Width - 7, 4)
                                newbox.Controls.Add(newpacc)
                                AddHandler newpacc.MouseClick, AddressOf Acceptdkit
                                'Create Download Button
                                Dim newpdow As Button
                                newpdow = New Button
                                newpdow.Anchor = AnchorStyles.Top Or AnchorStyles.Right
                                newpdow.Dock = DockStyle.None
                                newpdow.AutoSize = False
                                newpdow.Height = 40
                                newpdow.Width = 90
                                'newpdow.Radius = 2
                                'newpdow.GradientMode = Drawing2D.LinearGradientMode.Horizontal
                                newpdow.Name = $"{fowname.ToString}:" & Replace(refilen, " ", "%20") & $":{upgmp}"
                                newpdow.BackColor = Color.Transparent
                                newpdow.ForeColor = Color.White
                                'newpdow.BaseColor1 = Color.FromArgb(50, 36, 177)
                                'newpdow.BaseColor2 = Color.FromArgb(113, 54, 252)
                                'newpdow.OnHoverBaseColor1 = Color.FromArgb(155, 145, 221)
                                'newpdow.OnHoverBaseColor2 = Color.FromArgb(255, 85, 255)
                                'newpdow.Animated = True
                                'newpdow.AnimationHoverSpeed = 0.07
                                'newpdow.AnimationSpeed = 0.03
                                'newpdow.TextRenderingHint = Guna.UI.WinForms.DrawingTextRenderingHint.SystemDefault
                                Try
                                    newpdow.Image = Nothing
                                Catch ex As Exception
                                End Try
                                newpdow.Text = "Download"
                                newpdow.TextAlign = HorizontalAlignment.Center
                                newpdow.Location = New Point(newbox.Width - newpacc.Width - newpdow.Width - 12, 5)
                                newbox.Controls.Add(newpdow)
                                'AddHandler newpdow.MouseClick, AddressOf Downloaddkit
                                'Create Idle Bar
                                Dim newgncpii As ProgressBar
                                newgncpii = New ProgressBar
                                newgncpii.Anchor = AnchorStyles.Top Or AnchorStyles.Right
                                newgncpii.Height = 50
                                newgncpii.Width = 50
                                newgncpii.Name = "Gunacpii" & upgmp
                                newgncpii.Visible = False
                                'newgncpii.Animated = True
                                'newgncpii.AnimationSpeed = 2
                                newgncpii.BackColor = Color.Transparent
                                'newgncpii.BaseColor = Color.Transparent
                                'newgncpii.IdleColor = Color.Transparent
                                'newgncpii.ProgressMaxColor = Color.DarkOrchid
                                'newgncpii.ProgressMinColor = Color.Orchid
                                newgncpii.Location = New Point(newbox.Width - newpacc.Width - newgncpii.Width - 30, 0)
                                newgncpii.Value = 15
                                'newgncpii.IdleOffset = 20
                                'newgncpii.ProgressThickness = 2
                                'newgncpii.ProgressOffset = 20
                                newbox.Controls.Add(newgncpii)
                                'Create ProgressBar
                                Dim newmdprog As ProgressBar
                                newmdprog = New ProgressBar
                                newmdprog.Anchor = AnchorStyles.Top Or AnchorStyles.Right
                                newmdprog.Dock = DockStyle.None
                                newmdprog.AutoSize = False
                                newmdprog.Height = 10
                                newmdprog.Width = 70
                                newmdprog.Minimum = 0
                                newmdprog.Maximum = 100
                                newmdprog.Name = "GunaPBi" & upgmp
                                newmdprog.Visible = False
                                newmdprog.BackColor = Color.FromArgb(35, 30, 59)
                                'newmdprog.IdleColor = Color.FromArgb(30, 28, 54)
                                'newmdprog.ProgressMinColor = Color.FromArgb(155, 145, 221)
                                'newmdprog.ProgressMaxColor = Color.FromArgb(255, 85, 255)
                                'newmdprog.Radius = 0
                                'newmdprog.Style = Guna.UI.WinForms.ProgressBarStyle.Blocks
                                newmdprog.Location = New Point(newbox.Width - newpacc.Width - newmdprog.Width - 15, 22)
                                newmdprog.Value = 0
                                newbox.Controls.Add(newmdprog)
                                'Create Completed Image
                                Dim newpicbox As PictureBox
                                newpicbox = New PictureBox With {
                                    .Anchor = AnchorStyles.Top Or AnchorStyles.Right,
                                    .Dock = DockStyle.None,
                                    .AutoSize = False,
                                    .Height = 43,
                                    .Width = 50,
                                    .Name = "GunaPBoxi" & upgmp,
                                    .Visible = False,
                                    .BackColor = Color.Transparent,
                                    .SizeMode = PictureBoxSizeMode.Zoom
                                }
                                newpicbox.Location = New Point(newbox.Width - newpacc.Width - newpicbox.Width - 30, 4)
                                Try
                                    newpicbox.Image = My.Resources.checkmark_48px
                                Catch ex As Exception
                                End Try
                                newbox.Controls.Add(newpicbox)
                            End If

                            upgmp += 1
                        Catch ex As Exception
                            'Error 
                        End Try
                    End If
                Next
            ElseIf pendlist = "None" Then
                ' PUpbox.Controls.Clear()
                Dim tnewfi As Label
                tnewfi = New Label With {
                    .Anchor = AnchorStyles.Left Or AnchorStyles.Right Or AnchorStyles.Top,
                    .Dock = DockStyle.None,
                    .AutoSize = True,
                    .Name = "lblntfound",
                    .BackColor = Color.FromArgb(37, 35, 63),
                    .ForeColor = Color.Crimson,
                    .Padding = New Padding(6, 10, 6, 10),
                    .Text = "There are no pending files.",
                    .TextAlign = ContentAlignment.MiddleCenter,
                    .Font = New Font("Segoe UI Emoji", 11, FontStyle.Regular)
                }
                ' PUpbox.Controls.Add(tnewfi)
                tnewfi.AutoSize = False
                ' tnewfi.Width = PUpbox.Width - 24
                tnewfi.Height = 45
                tnewfi.Location = New Point(11, 1)
                'tnewfi.Top = PUpbox.Height / 2 - tnewfi.Height
                pflesl = False
            ElseIf pendlist = "Int" Then
                Exit Sub
            Else
                Pendlistcr()
            End If
            pendlist = Nothing
            mlcon = Nothing
            'If Pvshelper IsNot Nothing Then Pvshelper.UpdateScrollBar()
            pflesl = False
        End If
        Exit Sub
    End Sub

    Private Sub Acceptdkit(ByVal sender As Object, e As EventArgs)
        Dim tmstrn As String = DirectCast(sender, Button).Name
        Dim occurCount As Integer = tmstrn.Split(":").Length
        If occurCount = 3 Then
            DirectCast(sender, Button).Enabled = False
            tmpname = tmstrn.Split(":")(0)
            tmpfnam = tmstrn.Split(":")(1)
            tmpnumb = tmstrn.Split(":")(2)
        End If
        Call New Action(AddressOf Accdkitconn).BeginInvoke(Nothing, Nothing)
    End Sub

    Private Sub Accdkitconn()
        Try
            Dim tdata As String = Nothing
            Dim reqmdata As HttpWebRequest
            Dim resmdata As HttpWebResponse
            Dim mdatastream As StreamReader
            Dim enc As Text.UTF8Encoding = New Text.UTF8Encoding()
            Dim postdata As String
            Dim postdatabytes As Byte()
            reqmdata = WebRequest.Create($"http://127.0.0.1/padacc.php")
            reqmdata.Method = "POST"
            reqmdata.KeepAlive = False
            reqmdata.AllowAutoRedirect = False
            reqmdata.ContentType = "application/x-www-form-urlencoded"
            postdata = $"n={Username.ToString}&u={Kdets.ToString}&a={tmpname.ToString}&f={tmpfnam.ToString}"
            postdatabytes = enc.GetBytes(postdata)
            reqmdata.ContentLength = postdatabytes.Length
            Dim Stream = reqmdata.GetRequestStream()
            Stream.Write(postdatabytes, 0, postdatabytes.Length)
            Stream.Close()
            resmdata = reqmdata.GetResponse()
            mdatastream = New StreamReader(resmdata.GetResponseStream)
            tdata = mdatastream.ReadToEnd
            'Close connection
            reqmdata.GetResponse.Close()
            resmdata.GetResponseStream.Close()
            resmdata.Close()
            mdatastream.Close()
            postdata = "00000"
            postdatabytes = enc.GetBytes(postdata)
            If tdata.Contains("Completed") Then
                'DirectCast(PUpbox.Controls($"GunaP{tmpnumb}"), Panel).Dispose()
            Else
                MsgBox(tdata.ToString)
            End If
            tdata = Nothing
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Exit Sub
    End Sub

    Private Sub Downkmus()
        TdWCs.Add(New WebClient)
        Tlista.Add(tdmpathn)
        AddHandler TdWCs(tcwclients).DownloadProgressChanged, AddressOf Tcdown_ProgressChanged
        AddHandler TdWCs(tcwclients).DownloadFileCompleted, AddressOf Tcdpwm_DownloadCompleted
        Dim filename As String = tdmpath.Replace("%20", " ").Replace("|", "_")
        If drksvpath.Text.Length > 0 AndAlso IO.Directory.Exists(drksvpath.Text.ToString) Then
            TdWCs(tcwclients).DownloadFileAsync(New Uri($"http://127.0.0.1/Dbu/Pend/{tdmpath.ToString}"), $"{drksvpath?.Text?.ToString}\{filename}")
        Else
            TdWCs(tcwclients).DownloadFileAsync(New Uri($"http://127.0.0.1/Dbu/Pend/{tdmname.ToString}/{tdmpath.ToString}"), Application.StartupPath & $"\{filename}")
        End If
        tcwclients += 1
    End Sub

    Private Sub Tcdown_ProgressChanged(sender As Object, e As DownloadProgressChangedEventArgs)
        cacc = True
        Dim WC As WebClient = DirectCast(sender, WebClient)
        Dim tmudbr As Double = Double.Parse(e.BytesReceived.ToString())
        Dim tmudtbr As Double = Double.Parse(e.TotalBytesToReceive.ToString())
        Dim udprog As Integer = tmudbr / tmudtbr * 100
        If cancelfix = True Then
            WC.CancelAsync()
            WC.Dispose()
            Exit Sub
        Else
            Try
                'DirectCast(PUpbox.Controls($"GunaP{Tlista.Item(TdWCs.IndexOf(WC))}").Controls($"GunaPBi{Tlista.Item(TdWCs.IndexOf(WC))}"), ProgressBar).Visible = True
                ' DirectCast(PUpbox.Controls($"GunaP{Tlista.Item(TdWCs.IndexOf(WC))}").Controls($"Gunacpii{Tlista.Item(TdWCs.IndexOf(WC))}"), ProgressBar).Visible = False
                'DirectCast(PUpbox.Controls($"GunaP{Tlista.Item(TdWCs.IndexOf(WC))}").Controls($"GunaPBi{Tlista.Item(TdWCs.IndexOf(WC))}"), ProgressBar).Value = udprog
            Catch ex As Exception
                'Error
            End Try
        End If
    End Sub

    Private Sub Tcdpwm_DownloadCompleted(sender As Object, e As AsyncCompletedEventArgs)
        cacc = False
        Dim WC As WebClient = DirectCast(sender, WebClient)
        If cancelfix = True Then
            WC.CancelAsync()
            WC.Dispose()
            Exit Sub
        Else
            If e?.Error?.ToString = Nothing Then
                Try
                    'DirectCast(PUpbox.Controls($"GunaP{Tlista.Item(TdWCs.IndexOf(WC))}").Controls($"GunaPBi{Tlista.Item(TdWCs.IndexOf(WC))}"), ProgressBar).Visible = False
                    'DirectCast(PUpbox.Controls($"GunaP{Tlista.Item(TdWCs.IndexOf(WC))}").Controls($"GunaPBoxi{Tlista.Item(TdWCs.IndexOf(WC))}"), PictureBox).Visible = True
                Catch ex As Exception
                End Try
            Else
                MsgBox(e.Error.Message.ToString)
                'DirectCast(PUpbox.Controls($"GunaP{Tlista.Item(TdWCs.IndexOf(WC))}").Controls($"Gunacpii{Tlista.Item(TdWCs.IndexOf(WC))}"), ProgressBar).Visible = False
            End If
        End If
        DirectCast(sender, WebClient).CancelAsync()
        DirectCast(sender, WebClient).Dispose()
    End Sub

    'Drumkit <:-
    Private Sub DDrkitbtt_Click(sender As Object, e As EventArgs)
        DBKits.Show()
        If drmkitlist.Controls.Count = 0 Then
            dkfirload.Show()
        Else
            dkfirload.Hide()
        End If
    End Sub

    Private Sub DDiscArtbtt_Click(sender As Object, e As EventArgs)
        dkfirload.Hide()
        DBKits.Hide()
    End Sub

    Private Sub DSlSettbtt_Click(sender As Object, e As EventArgs)
        DBKits.Enabled = False
    End Sub

    Private Sub DOpexbtt_Click(sender As Object, e As EventArgs)
        DBKits.Enabled = True
    End Sub

    Private Sub Defspabtt_Click(sender As Object, e As EventArgs) Handles Defspabtt.Click
        Dim tdkofidiag As FolderBrowserDialog = New FolderBrowserDialog
        tdkofidiag.SelectedPath = Environment.SpecialFolder.MyDocuments
        tdkofidiag.Description = "BeatCracker: Choose default storage path"
        tdkofidiag.ShowDialog()
        If tdkofidiag.SelectedPath <> "" Then
            drksvpath.Text = tdkofidiag.SelectedPath
        End If
    End Sub

    Private Async Sub Getmlist()
        Await Task.Delay(60)
        If My.Computer.Network.IsAvailable = True AndAlso Visible = True AndAlso DownloadBox.Visible = True Then
            Try
                Dim reqmdata As HttpWebRequest
                Dim resmdata As HttpWebResponse
                Dim mdatastream As StreamReader
                Dim enc As Text.UTF8Encoding = New Text.UTF8Encoding()
                Dim postdata As String
                Dim postdatabytes As Byte()
                reqmdata = WebRequest.Create("http://127.0.0.1/Dba/mflist.php")
                reqmdata.Method = "POST"
                reqmdata.KeepAlive = False
                reqmdata.AllowAutoRedirect = False
                reqmdata.ContentType = "application/x-www-form-urlencoded"
                postdata = $"n={Username?.ToString}&u={Kdets?.ToString}"
                postdatabytes = enc.GetBytes(postdata)
                reqmdata.ContentLength = postdatabytes.Length
                Dim Stream = reqmdata.GetRequestStream()
                Stream.Write(postdatabytes, 0, postdatabytes.Length)
                Stream.Close()
                resmdata = reqmdata.GetResponse()
                mdatastream = New StreamReader(resmdata.GetResponseStream)
                postdata = "00000"
                postdatabytes = enc.GetBytes(postdata)
                If mdatastream.ToString = Nothing Then
                    'Close connection
                    reqmdata.GetResponse.Close()
                    resmdata.GetResponseStream.Close()
                    resmdata.Close()
                    mdatastream.Close()
                    Getmlist()
                Else
                    If minfogra = False Then
                        servmdata = mdatastream.ReadToEnd
                    End If
                    'Close connection
                    reqmdata.GetResponse.Close()
                    resmdata.GetResponseStream.Close()
                    resmdata.Close()
                    mdatastream.Close()
                    Exit Sub
                End If
            Catch wex As WebException
                servmdata = "Err"
                Exit Sub
            Catch ex As Exception
                Getmlist()
            End Try
        ElseIf DownloadBox.Visible = False Then
            mpvcha = False
            Exit Sub
        Else
            If Visible = False AndAlso Login.Visible = True Then
                Exit Sub
            End If
        End If
        Exit Sub
    End Sub

    Private Async Sub Listcreator()
        Await Task.Delay(120)
        If DownloadBox.Visible = True Then
            Dim userhelper As String = servmdata
            Dim mlcon As String = Nothing
            Dim tmdnum As Integer = 0
            If userhelper <> fixmdata AndAlso userhelper <> Nothing AndAlso userhelper = "Err" <> True Then
                dkfirload.Hide()
                minfogra = True
                If fixmdata IsNot Nothing AndAlso userhelper.Contains(fixmdata) Then
                    'Fix file upload
                    mlcon = Replace(userhelper, fixmdata, "")
                ElseIf ftrdrumkit = True Then
                    'First use
                    mlcon = userhelper
                    fixmdata = "00000000000000"
                    ftrdrumkit = False
                Else
                    mlcon = userhelper
                End If
                minfogra = False
                If mlcon IsNot Nothing Then
                    For Each line In mlcon.Split(";")
                        tmdnum += 1
                        If line IsNot "" AndAlso line IsNot " " And fixmdata.Contains(line) = False Then
                            Dim fowname As String = Nothing
                            Dim refilen As String = Nothing
                            Dim filesize As String = Nothing
                            Dim selfilesize As String = Nothing
                            Try
                                fowname = line.Split(":")(0)
                                refilen = line.Split(":")(1)
                                filesize = line.Split(":")(2)
                                If filesize >= 1073741824 Then
                                    selfilesize = Format(filesize / 1024 / 1024 / 1024, "#0.00") & " GB"
                                ElseIf filesize >= 1048576 Then
                                    selfilesize = Format(filesize / 1024 / 1024, "#0.00") & " MB"
                                ElseIf filesize >= 1024 Then
                                    selfilesize = Format(filesize / 1024, "#0.00") & " KB"
                                ElseIf filesize < 1024 Then
                                    selfilesize = Fix(filesize) & " Bytes"
                                End If
                                'Create area
                                'Dim newbox As Guna.UI.WinForms.GunaElipsePanel
                                'newbox = New Guna.UI.WinForms.GunaElipsePanel
                                Dim newbox As Panel
                                newbox = New Panel
                                newbox.Anchor = AnchorStyles.Left Or AnchorStyles.Top Or AnchorStyles.Right
                                newbox.Dock = DockStyle.None
                                newbox.AutoSize = True
                                newbox.Name = "GunaP" & gmpcount
                                newbox.BackColor = Color.FromArgb(33, 32, 35)
                                newbox.ForeColor = Color.FromArgb(33, 32, 35)
                                'newbox.BaseColor = Color.FromArgb(33, 32, 35)
                                'newbox.Radius = 6
                                'newbox.ShadowDepth = 80
                                'newbox.ShadowStyle = Guna.UI.WinForms.ShadowMode.Surrounded
                                newbox.Padding = New Padding(6, 10, 6, 10)
                                drmkitlist.Controls.Add(newbox)
                                newbox.AutoSize = False
                                newbox.Width = drmkitlist.Width - 20
                                newbox.Height = 140
                                newbox.Location = New Point(1)
                                newbox.Top = useroldheight + 120 - drmkitlist.VerticalScroll.Value
                                useroldheight = newbox.Top + drmkitlist.VerticalScroll.Value + 40
                                'Insert image
                                Dim newfipi As PictureBox
                                newfipi = New PictureBox
                                newfipi.Anchor = AnchorStyles.Top Or AnchorStyles.Left
                                newfipi.Dock = DockStyle.None
                                newfipi.AutoSize = False
                                newfipi.Height = 50 ' location 
                                newfipi.Width = 40
                                newfipi.Name = "GunaPFpi" & gmpcount
                                newfipi.BackColor = Color.Transparent
                                newfipi.Size = New Size(100, 100)
                                newfipi.SizeMode = PictureBoxSizeMode.Zoom
                                Try
                                    If line.Contains(".zip") Then
                                        'newfipi.Image = My.Resources.zip_64px
                                        newfipi.Image = My.Resources.zip_52px
                                    ElseIf line.Contains(".rar") Then
                                        'newfipi.Image = My.Resources.winrar_30px
                                        newfipi.Image = My.Resources.DK
                                    ElseIf line.Contains(".7z") Then
                                        newfipi.Image = My.Resources._7zip_52px
                                    End If
                                Catch ex As Exception
                                End Try
                                newfipi.Location = New Point(25, 18)
                                newbox.Controls.Add(newfipi)
                                'Create text
                                Dim newfile As TextBox
                                newfile = New TextBox With {
                                    .Anchor = AnchorStyles.Top Or AnchorStyles.Left,
                                    .Dock = DockStyle.None,
                                    .BorderStyle = BorderStyle.None,
                                    .ShortcutsEnabled = False,
                                    .Cursor = DefaultCursor,
                                    .ReadOnly = True,
                                    .WordWrap = False,
                                    .AutoSize = True,
                                    .Font = New Font("Arial", 11, FontStyle.Bold),
                                    .Name = "GunaPF" & gmpcount,
                                    .BackColor = Color.FromArgb(33, 32, 35),
                                    .ForeColor = Color.White
                                }
                                Try
                                    newfile.Text = refilen
                                Catch ex As Exception
                                End Try
                                newfile.Location = New Point(150, 18)
                                newbox.Controls.Add(newfile)
                                newfile.SelectionStart = 0
                                newfile.SelectionLength = 0
                                newfile.HideSelection = True
                                Dim nmtsize As String = newfile.Width.ToString
                                newfile.AutoSize = False
                                newfile.Height = 30
                                newfile.Width = newbox.Width - 230
                                'Create size text
                                Dim newstfile As Label
                                newstfile = New Label With {
                                    .Anchor = AnchorStyles.Top Or AnchorStyles.Left,
                                    .Dock = DockStyle.None,
                                    .AutoSize = True,
                                    .TextAlign = ContentAlignment.MiddleLeft,
                                    .Font = New Font("Arial", 8, FontStyle.Bold),
                                    .Name = "GunaPsF" & gmpcount,
                                    .BackColor = Color.Transparent,
                                    .ForeColor = Color.LightGray
                                }
                                Try
                                    newstfile.Text = $"• Posted by {fowname} | Size: " & selfilesize
                                Catch ex As Exception
                                End Try
                                newstfile.Location = New Point(150, 45)
                                newbox.Controls.Add(newstfile)
                                '<- number downloads
                                Dim dll As Label
                                dll = New Label With {
                                    .Anchor = AnchorStyles.Top Or AnchorStyles.Right,
                                    .Dock = DockStyle.None,
                                    .AutoSize = False,
                                    .TextAlign = ContentAlignment.MiddleRight,
                                    .Font = New Font("Arial", 8, FontStyle.Regular),
                                    .Name = "GunaPsF" & gmpcount,
                                    .BackColor = Color.Transparent,
                                    .ForeColor = Color.LightGray
                                }
                                Try
                                    dll.Text = "1 dowloads"
                                Catch ex As Exception
                                End Try
                                dll.Location = New Point(790, 65)
                                newbox.Controls.Add(dll)

                                Dim sep As Guna.UI2.WinForms.Guna2Separator
                                sep = New Guna.UI2.WinForms.Guna2Separator With {
                                    .Anchor = AnchorStyles.Top Or AnchorStyles.Left,
                                    .Dock = DockStyle.None,
                                    .AutoSize = False,
                                    .BackColor = Color.Transparent,
                                    .FillColor = Color.FromArgb(26, 27, 29),
                                    .FillThickness = 1.5,
                                    .Size = New Size(700, 10)
                                    }
                                Try
                                    sep.BackColor = Color.Transparent
                                Catch ex As Exception
                                End Try
                                sep.Location = New Point(150, 85)
                                newbox.Controls.Add(sep)
                                Dim newstfiletw As String = newstfile.Width.ToString
                                newstfile.AutoSize = False
                                newstfile.Height = 18
                                newstfile.Width = newstfiletw
                                newstfile.BringToFront()
                                'Create Button
                                Dim newfbutt As Button
                                newfbutt = New Button
                                newfbutt.Anchor = AnchorStyles.Top Or AnchorStyles.Right
                                newfbutt.Dock = DockStyle.None
                                newfbutt.AutoSize = False
                                newfbutt.Height = 35
                                newfbutt.Width = 40
                                'newfbutt.Radius = 16
                                'newfbutt.GradientMode = Drawing2D.LinearGradientMode.Horizontal
                                newfbutt.Name = Replace(refilen, " ", "%20") & $":{gmpcount}"
                                newfbutt.BackColor = Color.Transparent
                                newfbutt.ForeColor = Color.White
                                'newfbutt.BaseColor1 = Color.FromArgb(50, 36, 177)
                                'newfbutt.BaseColor1 = Color.Transparent
                                'newfbutt.BaseColor2 = Color.FromArgb(113, 54, 252)
                                'newfbutt.BaseColor2 = Color.Transparent
                                'newfbutt.OnHoverBaseColor1 = Color.FromArgb(27, 26, 29)
                                'newfbutt.OnHoverBaseColor2 = Color.FromArgb(27, 26, 29)
                                'newfbutt.Animated = True
                                'newfbutt.AnimationHoverSpeed = 0.07
                                'newfbutt.AnimationSpeed = 0.03
                                'newfbutt.TextRenderingHint = Guna.UI.WinForms.DrawingTextRenderingHint.SystemDefault
                                Try
                                    newfbutt.Image = My.Resources.downloading_updates_48px
                                Catch ex As Exception
                                End Try
                                newfbutt.Text = ""
                                newfbutt.Location = New Point(newbox.Width - 50, 95)
                                newbox.Controls.Add(newfbutt)
                                AddHandler newfbutt.MouseClick, AddressOf Usclicked
                                'Create Idle Bar
                                Dim newgncpii As ProgressBar
                                newgncpii = New ProgressBar
                                newgncpii.Anchor = AnchorStyles.Top Or AnchorStyles.Right
                                newgncpii.Height = 35
                                newgncpii.Width = 40
                                newgncpii.Name = "Gunacpii" & gmpcount
                                newgncpii.Visible = False
                                'newgncpii.Animated = True
                                'newgncpii.AnimationSpeed = 2
                                newgncpii.BackColor = Color.Transparent
                                'newgncpii.BaseColor = Color.Transparent
                                'newgncpii.IdleColor = Color.Transparent
                                'newgncpii.ProgressMaxColor = Color.FromArgb(57, 153, 250)
                                'newgncpii.ProgressMinColor = Color.FromArgb(240, 163, 255)
                                newgncpii.Location = New Point(newbox.Width - 50, 95)
                                newgncpii.Value = 15
                                'newgncpii.IdleOffset = 20
                                'newgncpii.ProgressThickness = 2
                                'newgncpii.ProgressOffset = 20
                                newbox.Controls.Add(newgncpii)
                                'Create ProgressBar
                                Dim newmdprog As ProgressBar
                                newmdprog = New ProgressBar
                                newmdprog.Anchor = AnchorStyles.Top Or AnchorStyles.Left
                                newmdprog.Dock = DockStyle.None
                                newmdprog.AutoSize = False
                                newmdprog.Height = 4
                                newmdprog.Width = 870
                                newmdprog.Minimum = 0
                                newmdprog.Maximum = 100
                                newmdprog.Name = "GunaPBi" & gmpcount
                                newmdprog.Visible = False
                                newmdprog.BackColor = Color.FromArgb(33, 32, 35)
                                'newmdprog.IdleColor = Color.FromArgb(27, 26, 29)
                                'newmdprog.ProgressMinColor = Color.FromArgb(57, 153, 250)
                                'newmdprog.ProgressMaxColor = Color.FromArgb(240, 163, 255)
                                'newmdprog.Radius = 0
                                'newmdprog.Radius = prog.BorderRadius
                                'newmdprog.Style = Guna.UI.WinForms.ProgressBarStyle.Blocks
                                'newmdprog.Location = New Point(newbox.Width - 135, 22)
                                newmdprog.Location = New Point(newbox.Width - 880, 130)
                                newmdprog.Value = 0
                                newbox.Controls.Add(newmdprog)
                                'Create Completed Image
                                Dim newpicbox As PictureBox
                                newpicbox = New PictureBox With {
                                    .Anchor = AnchorStyles.Top Or AnchorStyles.Right,
                                    .Dock = DockStyle.None,
                                    .AutoSize = False,
                                    .Height = 35,
                                    .Width = 40,
                                    .Name = "GunaPBoxi" & gmpcount,
                                    .Visible = False,
                                    .BackColor = Color.Transparent,
                                    .SizeMode = PictureBoxSizeMode.Zoom,
                                    .Location = New Point(newbox.Width - 50, 95)
                                }
                                Try
                                    newpicbox.Image = My.Resources.checkmark_488px
                                Catch ex As Exception
                                End Try
                                newbox.Controls.Add(newpicbox)

                                gmpcount += 1
                            Catch ex As Exception
                                'Error 
                            End Try
                        End If
                    Next
                    'If dkvshelper IsNot Nothing Then dkvshelper.UpdateScrollBar()
                    fixmdata = userhelper
                    userhelper = Nothing
                    mlcon = Nothing
                Else
                    Listcreator()
                End If
            ElseIf userhelper = Nothing Then
                Listcreator()
            ElseIf userhelper = "Err" Then
                mpvcha = False
                Exit Sub
            Else
                mpvcha = False
                Exit Sub
            End If
        ElseIf DownloadBox.Visible = False Then
            mpvcha = False
            Exit Sub
        End If
        mpvcha = False
        Exit Sub
    End Sub

    Private Sub Usclicked(ByVal sender As Object, e As EventArgs)
        Dim dowobj As String = DirectCast(sender, Button).Name
        Dim occurCount As Integer = dowobj.Split(":").Length
        If occurCount = 2 Then
            dmpath = dowobj.Split(":")(0)
            dmpathn = dowobj.Split(":")(1)
        Else
            Exit Sub
        End If
        If dmpath IsNot Nothing AndAlso dmpathn IsNot Nothing And dmpathn > 0 Then
            DirectCast(sender, Button).Visible = False
            DirectCast(drmkitlist.Controls($"GunaP{dmpathn}").Controls($"Gunacpii{dmpathn}"), ProgressBar).Visible = True
            dcseldk.Add(New download)
            dcseldk(cwclients).Show()
            dcseldk(cwclients).DownStart(drksvpath.Text, dmpath.ToString, dmpathn)
            cwclients += 1
        End If
    End Sub

    Protected Friend Sub SetDown(ByRef workn As Boolean, ByRef gpv As Boolean, ByRef gcpv As Boolean, ByRef gpcv As Integer, ByRef gcim As Boolean, ByRef git As Integer)
        Try
            cacc = workn
            DirectCast(drmkitlist.Controls($"GunaP{git}").Controls($"GunaPBi{git}"), ProgressBar).Visible = gpv
            DirectCast(drmkitlist.Controls($"GunaP{git}").Controls($"Gunacpii{git}"), ProgressBar).Visible = gcpv
            DirectCast(drmkitlist.Controls($"GunaP{git}").Controls($"GunaPBi{git}"), ProgressBar).Value = gpcv
            DirectCast(drmkitlist.Controls($"GunaP{git}").Controls($"GunaPBoxi{git}"), PictureBox).Visible = gcim
        Catch ex As Exception
        End Try
    End Sub

    'About <:-

    Private Sub GunaAdvenceButton25_Click(sender As Object, e As EventArgs)
        Process.Start("https://www.instagram.com/sneaky_haxor/")
    End Sub

    Private Sub GunaAdvenceButton26_Click(sender As Object, e As EventArgs)
        Process.Start("https://twitter.com/Sneaky_Haxor")
    End Sub

    Private Sub GunaAdvenceButton11_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub GunaAdvenceButton10_Click(sender As Object, e As EventArgs)

    End Sub

    'Donate <:-
    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs)
        Process.Start("https://paypal.me/sneakyhaxor")
    End Sub

    Private Sub dwnl_Click(sender As Object, e As EventArgs) Handles dwnl.Click
        dwnlhome()
    End Sub
    Public Sub dwnlhome()

        'dwnlhomepr.Visible = True
        dwnl.Visible = False
        Dim webClient2 As WebClient = New WebClient()
        AddHandler webClient2.DownloadProgressChanged, AddressOf client_ProgressChanged
        AddHandler webClient2.DownloadFileCompleted, AddressOf client_DownloadCompleted
        Dim text2 As String = webClient2.DownloadString("http://beatcracker.tech/SNEAKY%20KIT%204.rar")
        Dim fileName As String = "SNEAKY KIT 4"
        ' If Operators.CompareString(BunifuCustomLabel2.Text, "PREPARING TO DOWNLOAD..", False) = 0 Then

        'webClient2.DownloadString("http://beatcracker.tech/SNEAKY%20KIT%204.rar")
        'End If

        dwnl.Visible = False
        ' dwnlhomepr.Value = 0
        'dwnlhomepr.Visible = True
        'webClient2.DownloadFileAsync(New Uri(text2), Application.StartupPath & $"\name of app {Text.ToString}.exe")

    End Sub
    Private Sub client_ProgressChanged(sender As Object, e As DownloadProgressChangedEventArgs)

        'dwnlhomepr.Visible = True
        Dim num As Double = Double.Parse(e.BytesReceived.ToString())
        Dim num2 As Double = Double.Parse(e.TotalBytesToReceive.ToString())
        Dim d As Double = num / num2 * 100.0
        'BunifuCustomLabel2.Text = "DOWNLOADING.."
        'BunifuCustomLabel2.Location = New Point(270, 292)
        ' BunifuCustomLabel3.Text = Conversions.ToString(Integer.Parse(Conversions.ToString(Math.Truncate(d)))) + "%"
        'dwnlhomepr.Value = Integer.Parse(Math.Truncate(d).ToString())
    End Sub

    Private Sub client_DownloadCompleted(sender As Object, e As AsyncCompletedEventArgs)

        ' BunifuCustomLabel2.Text = "DOWNLOADING FINISH."
        'BunifuCustomLabel2.Location = New Point(241, 292)
        dwnl.Visible = True
        'dwnlhomepr.Visible = False
        ' BunifuCustomLabel3.Visible = False





        Return

    End Sub
    Private Sub seemore_Click(sender As Object, e As EventArgs) Handles seemore.Click
        Process.Start("https://payhip.com/Sneaky")
    End Sub

    Private Sub Gsinginbtt_Click(sender As Object, e As EventArgs) Handles Gsinginbtt.Click
        Process.Start("https://soundcloud.com/sneaky_haxor")
    End Sub
End Class
