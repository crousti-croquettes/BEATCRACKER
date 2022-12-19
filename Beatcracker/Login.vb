Imports System.IO
Imports System.Net
Imports System.Security.Cryptography
Imports System.Text

Friend Class Login
    Private dnup As Boolean = False
    Private duup As Boolean = False
    Private dlup As Boolean = False
    Private keepdetails As String = Nothing
    Private unke As String = Nothing
    Private ReadOnly allkeys As String = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890"
    Private ReadOnly numkeys As String = "1234567890"
    Private nulb As Short = 0
    Private nnlb As Short = 0
    Private nllb As Short = 0

    Private Sub BCExit()
        Dispose()
        Close()
        End
    End Sub

    Protected Friend Function Retkk(ByRef getDet As String, ByRef getNam As String) As String
        If keepdetails <> Nothing Then
            getDet = keepdetails.ToString
            getNam = Usernametext.Text.ToString
            Usernametext.Text = Nothing
            Passwordtext.Text = Nothing
            keepdetails = Nothing
            unke = Nothing
            Opacity = 0
            Dispose()
            Close()
            Return getDet & getNam
        Else
            Usernametext.Text = Nothing
            Passwordtext.Text = Nothing
            keepdetails = Nothing
            unke = Nothing
            Opacity = 0
            BCExit()
            Return Nothing
        End If
    End Function

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Opacity = 0
        Dim tmr1 As New Timer
        tmr1.Interval = 3
        tmr1.Start()
        AddHandler tmr1.Tick, Sub()
                                  ShowInTaskbar = True
                                  TopMost = True
                                  If Opacity < 1 Then
                                      Opacity += 0.1
                                  Else
                                      TopMost = False
                                      'Ex.Visible = True
                                      CenterToScreen()
                                      Usernametext.Enabled = True
                                      Passwordtext.Enabled = True
                                      tmr1.Stop()
                                      tmr1.Dispose()
                                  End If
                              End Sub

    End Sub

    Private Sub Ex_Click(sender As Object, e As EventArgs)
        Dim tmr0 As New Timer
        tmr0.Interval = 1
        tmr0.Start()
        Dim tm01 As Boolean = False
        AddHandler tmr0.Tick, Sub()
                                  If Opacity > 0 Then
                                      Opacity -= 0.1
                                  Else
                                      tmr0.Stop()
                                      tmr0.Dispose()
                                      BCExit()
                                  End If
                              End Sub
    End Sub

    Private Sub Gsinginbtt_Click(sender As Object, e As EventArgs) Handles Gsinginbtt.Click
        'lgglbl.Text = "Log into your account"
        ' Usmlbl.Visible = False
        'Psmlbl.Visible = False
        'Esmlbl.Visible = False
        passbar.Visible = False
        Gcreabtt.Visible = False
        'Gforgpbtt.Visible = True
        Loginbtt.Visible = True
        Gsinginbtt.Visible = False
        Gsingupbtt.Visible = True
        'Ex.Visible = True
        EmailText.Visible = False
        'labelmail.Visible = False
        rgmlbl.Visible = True
        Gsingupbtt.Enabled = True
    End Sub

    Private Sub Gsingupbtt_MouseHover(sender As Object, e As EventArgs) Handles Gsingupbtt.MouseHover
        Try
            Gsingupbtt.ForeColor = Color.FromArgb(57, 153, 250)
        Catch Ex As Exception
        End Try
    End Sub

    Private Sub Gsingupbtt_MouseLeave(sender As Object, e As EventArgs) Handles Gsingupbtt.MouseLeave
        Gsingupbtt.ForeColor = Color.FromArgb(82, 104, 244)
    End Sub

    Private Sub Gsingupbtt_Click(sender As Object, e As EventArgs) Handles Gsingupbtt.Click
        'lgglbl.Text = "          Registration"
        'Usmlbl.Visible = False
        'Psmlbl.Visible = False
        ' Esmlbl.Visible = False
        Terms.Visible = True
        LinkLabel1.Visible = True
        back.Visible = True
        passbar.Visible = True
        LCLlbar.Visible = False
        Loginbtt.Visible = False
        'Gforgpbtt.Visible = False
        Gcreabtt.Visible = True
        Gsinginbtt.Visible = True
        Gsingupbtt.Visible = False
        'Ex.Visible = False
        EmailText.Visible = True
        'labelmail.Visible = True
        rgmlbl.Visible = False
    End Sub

    Private Sub Usernametext_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Usernametext.KeyPress
        If allkeys.Contains(e.KeyChar) <> True AndAlso e.KeyChar <> Convert.ToChar(Keys.Back) AndAlso e.KeyChar <> Convert.ToChar(1) Then
            e.Handled = True
            Return
        End If
    End Sub

    Private Sub Usernametext_TextChanged(sender As Object, e As EventArgs) Handles Usernametext.TextChanged
        If Usernametext.Text.Length > 5 Then
            'Usmlbl.Visible = False
        End If
    End Sub

    Private Sub Passwordtext_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Passwordtext.KeyPress
        If e.KeyChar <> Convert.ToChar(Keys.Back) Then
            If numkeys.Contains(e.KeyChar) AndAlso dnup = False Then
                nnlb += 1
                dnup = True
            ElseIf numkeys.Contains(e.KeyChar) Then
                nnlb += 1
            End If
            If e.KeyChar = UCase(e.KeyChar) AndAlso duup = False AndAlso numkeys.Contains(e.KeyChar) = False Then
                nulb += 1
                duup = True
            ElseIf e.KeyChar = UCase(e.KeyChar) AndAlso numkeys.Contains(e.KeyChar) = False Then
                nulb += 1
            End If
            If e.KeyChar = LCase(e.KeyChar) AndAlso dlup = False AndAlso numkeys.Contains(e.KeyChar) = False Then
                nllb += 1
                dlup = True
            ElseIf e.KeyChar = LCase(e.KeyChar) AndAlso numkeys.Contains(e.KeyChar) = False Then
                nllb += 1
            End If
            If e.KeyChar = Chr(13) AndAlso Loginbtt.Visible = True Then
                e.Handled = True
                If My.Computer.Network.IsAvailable = True And Usernametext.Text.Length > 5 AndAlso Passwordtext.Text.Length > 7 Then
                    Inilbl.Visible = False
                    Cloud.Visible = False
                    Loginbtt.Enabled = False
                    Usernametext.Enabled = False
                    Passwordtext.Enabled = False
                    Gsingupbtt.Enabled = False
                    LCLlbar.Visible = True
                    'Ex.Visible = False
                Else
                    If My.Computer.Network.IsAvailable = True Then
                        ' Cloud.Location = New Size(286, 482)
                        'Inilbl.Location = New Size(307, 479)
                        Inilbl.Text = "Internet Error"
                        Inilbl.Visible = True
                        Cloud.Visible = True
                    End If
                    If Usernametext.Text.Length <= 5 Then
                        'Usmlbl.Location = New Size(522, 218)
                        'Usmlbl.Visible = True
                    End If
                    If Passwordtext.Text.Length <= 7 Then
                        ' Psmlbl.Visible = True
                    End If
                End If
            End If
        ElseIf Passwordtext.Text.Length < 1 Then
            passbar.Value = 0
            dnup = False
            duup = False
            dlup = False
            nnlb = 0
            nulb = 0
            nllb = 0
        End If
    End Sub

    Private Sub Passwordtext_TextChanged(sender As Object, e As EventArgs) Handles Passwordtext.TextChanged
        'Psmlbl.Visible = False
        If Passwordtext.Text.Length > 0 Then
            If Passwordtext.Text.Length <= nnlb And Passwordtext.Text.Length = 1 Then
                passbar.Value = 1
                duup = False
                nnlb = 0
                dlup = False
                nllb = 0
            ElseIf Passwordtext.Text.Length < nnlb Then
                dnup = False
                nnlb = 0
            ElseIf dnup = True And Passwordtext.Text.Length = nnlb Then
                passbar.Value = Passwordtext.Text.Length
                passbar.Value += 1
            End If
            If Passwordtext.Text.Length <= nulb And Passwordtext.Text.Length = 1 Then
                passbar.Value = 1
                dnup = False
                nnlb = 0
                dlup = False
                nllb = 0
            ElseIf Passwordtext.Text.Length < nulb Then
                duup = False
                nulb = 0
            ElseIf duup = True And Passwordtext.Text.Length = nulb Then
                passbar.Value = Passwordtext.Text.Length
                passbar.Value += 1
            End If
            If Passwordtext.Text.Length <= nllb And Passwordtext.Text.Length = 1 Then
                passbar.Value = 1
                dnup = False
                nnlb = 0
                duup = False
                nllb = 0
            ElseIf Passwordtext.Text.Length < nllb Then
                dlup = False
                nllb = 0
            ElseIf dlup = True And Passwordtext.Text.Length = nllb Then
                passbar.Value = Passwordtext.Text.Length
                passbar.Value += 1
            End If
            Dim atm As Short = 0
            If dnup = True Then
                atm += 1
            End If
            If duup = True Then
                atm += 1
            End If
            If dlup = True Then
                atm += 1
            End If
            If atm >= 3 Then
                If Passwordtext.Text.Length > 12 Then
                    passbar.Value = 45
                Else
                    passbar.Value = Passwordtext.Text.Length * 2.25
                End If
            ElseIf atm = 2 Then
                Dim account As Short = 0
                account = nnlb
                If account < nulb Then
                    account = nulb
                End If
                If account < nllb Then
                    account = nllb
                End If
                If Passwordtext.Text.Length - account > 1 Then
                    passbar.Value = Passwordtext.Text.Length * 2
                Else
                    passbar.Value += 1
                End If
            ElseIf atm = 1 Then
                passbar.Value = Passwordtext.Text.Length
            End If
            passbar.Visible = True
        Else
            dnup = False
            duup = False
            dlup = False
            nnlb = 0
            nulb = 0
            nllb = 0
            If Gcreabtt.Visible = True Then
                passbar.Visible = False
            End If
            passbar.Value = 0
        End If
    End Sub

    Private Sub Emailtext_KeyPress(sender As Object, e As KeyPressEventArgs)
        If allkeys.Contains(e.KeyChar) <> True AndAlso e.KeyChar <> Convert.ToChar(Keys.Back) AndAlso e.KeyChar <> Convert.ToChar(1) AndAlso e.KeyChar <> Convert.ToChar("@") Then
            e.Handled = True
            Return
        End If
    End Sub

    Private Sub EmailText_TextChanged(sender As Object, e As EventArgs) Handles EmailText.TextChanged
        If EmailText.Text.Length > 7 And EmailText.Text.Contains("@") And EmailText.Text.Contains(".") Then
            'Esmlbl.Visible = False
        End If
    End Sub

    Private Sub Hashcred()
        Try
            Dim sha256 As SHA256 = SHA256.Create()
            Dim bytes As Byte() = Encoding.UTF8.GetBytes(Passwordtext.Text)
            Dim hash As Byte() = sha256.ComputeHash(bytes)
            bytes = Encoding.UTF8.GetBytes("00000000")
            Dim tsbuildo As New StringBuilder()
            For i As Integer = 0 To hash.Length - 1
                tsbuildo.Append(hash(i).ToString("X2"))
            Next
            hash = Encoding.UTF8.GetBytes("00000000")
            keepdetails = tsbuildo.ToString
            tsbuildo.Append("00000000")
        Catch ex As Exception
            keepdetails = "HError"
        End Try
    End Sub

    Private Sub Gcreabtt_Click(sender As Object, e As EventArgs) Handles Gcreabtt.Click
        If Usernametext.Text.Length > 5 AndAlso Passwordtext.Text.Length > 7 AndAlso EmailText.Text.Length > 7 AndAlso EmailText.Text.Contains("@") Then
            'Terms.Visible = True
            'Ex.Visible = False
            rgmlbl.Visible = False
            Gsingupbtt.Visible = False
            Passwordtext.Enabled = False
            Usernametext.Enabled = False
            EmailText.Enabled = False
            Inilbl.Visible = False
            Cloud.Visible = False
            Gcreabtt.Enabled = False
            Gcreabtt.Visible = False
            Gsinginbtt.Enabled = False
            LCLlbar.Visible = True
            Hashcred()
            Dim logincr As New LoginClass
            If keepdetails <> "HError" Then
                logincr.CallRegister(Usernametext.Text, keepdetails, EmailText.Text)
            Else

            End If
            keepdetails = ""
        Else
            If My.Computer.Network.IsAvailable = False Then
                ' Cloud.Location = New Size(286, 482)
                ' Inilbl.Location = New Size(307, 479)
                Inilbl.Text = "Internet Error"
                Inilbl.Visible = True
                Cloud.Visible = True
            End If
            If Usernametext.Text.Length <= 5 Then
                'Usmlbl.Location = New Size(522, 218)
                'Usmlbl.Visible = True
            End If
            If Passwordtext.Text.Length <= 7 Then
                'Psmlbl.Visible = True
            End If
            If EmailText.Text.Length <= 7 Or EmailText.Text.Contains("@") <> True Then
                'Esmlbl.Location = New Size(521, 365)
                'Esmlbl.Visible = True
                ' Esmlbl.BringToFront()
            End If
        End If
    End Sub

    Private Sub Loginbtt_Click(sender As Object, e As EventArgs) Handles Loginbtt.Click
        If Usernametext.Text.Length > 5 AndAlso Passwordtext.Text.Length > 7 Then
            Terms.Visible = False
            Inilbl.Visible = False
            Cloud.Visible = False
            Loginbtt.Enabled = False
            Usernametext.Enabled = False
            Passwordtext.Enabled = False
            Gsingupbtt.Enabled = False
            LCLlbar.Visible = True
            Gcreabtt.Visible = False
            'Ex.Visible = False
            Hashcred()
            Dim logincl As New LoginClass
            If keepdetails <> "HError" Then
                logincl.CallLogin(Usernametext.Text, keepdetails)
            Else

            End If
            keepdetails = ""
        Else
            If My.Computer.Network.IsAvailable = True Then
                ' Cloud.Location = New Size(286, 482)
                '  Inilbl.Location = New Size(307, 479)
                Inilbl.Text = "Internet Error"
                Inilbl.Visible = True
                Cloud.Visible = True
            End If
            If Usernametext.Text.Length <= 5 Then
                Usernametext.BorderColor = Color.FromArgb(246, 98, 98)
                'Usmlbl.Location = New Size(522, 218)
                'Usmlbl.Visible = True
            End If
            If Passwordtext.Text.Length <= 7 Then
                'Psmlbl.Visible = True
                Passwordtext.BorderColor = Color.FromArgb(246, 98, 98)
            End If
        End If
    End Sub

    Protected Friend Sub DataSet(cstats As String, ckate As String)
        If cstats = "Completed" Then
            Try
                Hide()
                passbar.Visible = False
                dnup = False
                duup = False
                dlup = False
                nnlb = 0
                nulb = 0
                nllb = 0
                Usernametext.Enabled = False
                Passwordtext.Enabled = False
                Passwordtext.Text = Nothing
                Loginbtt.Enabled = True
                Gcreabtt.Enabled = False
                Gcreabtt.Visible = False
                'Gforgpbtt.Visible = True
                Gsinginbtt.Visible = False
                Gsingupbtt.Visible = True
                LCLlbar.Visible = False
                keepdetails = ckate
                Dashboard.Show()
                'Ex.Visible = True
            Catch ex As Exception
            End Try
        Else
            Try
                Usernametext.Enabled = True
                Passwordtext.Text = Nothing
                Passwordtext.Enabled = True
                passbar.Visible = False
                dnup = False
                duup = False
                dlup = False
                nnlb = 0
                nulb = 0
                nllb = 0
                Loginbtt.Enabled = True
                Gcreabtt.Enabled = False
                Gcreabtt.Visible = False
                'Gforgpbtt.Visible = True
                Gsinginbtt.Visible = False
                Gsingupbtt.Visible = True
                LCLlbar.Visible = False
                'Ex.Visible = True
                If cstats = "Error" Or cstats = "Packet" Then
                    ' Cloud.Location = New Size(255, 482)
                    ' Inilbl.Location = New Size(276, 479)
                    rgmlbl.Visible = False
                    Gsingupbtt.Visible = False
                    Inilbl.Text = "Something went wrong"
                    Cloud.Visible = True
                    Inilbl.Visible = True
                ElseIf cstats = "Wrong" Then
                    ' Psmlbl.Visible = True
                ElseIf cstats = "Exists" Then
                    'Usmlbl.Visible = True
                ElseIf cstats = "Banned" Then
                    '  Cloud.Location = New Size(279, 482)
                    ' Inilbl.Location = New Size(300, 479)
                    Inilbl.Text = "You got banned"
                    Cloud.Visible = True
                    Inilbl.Visible = True
                End If
            Catch ex As Exception
            End Try
        End If
    End Sub

    Private Sub LinkLabel2_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
        Process.Start("https://discord.gg/RKdq9bm36Z")
    End Sub

    Private Sub Guna2ImageButton1_Click(sender As Object, e As EventArgs) Handles back.Click
        'Ex.Visible = True
        Loginbtt.Visible = True
        Gcreabtt.Visible = False
        back.Visible = False
        rgmlbl.Visible = True
        Gsinginbtt.Visible = True
        Gsingupbtt.Visible = True
        Terms.Visible = False
        LinkLabel1.Visible = False
        EmailText.Visible = False
    End Sub

    Private Sub Guna2ControlBox1_Click(sender As Object, e As EventArgs) Handles Guna2ControlBox1.Click
        Dim tmr0 As New Timer
        tmr0.Interval = 1
        tmr0.Start()
        Dim tm01 As Boolean = False
        AddHandler tmr0.Tick, Sub()
                                  If Opacity > 0 Then
                                      Opacity -= 0.1
                                  Else
                                      tmr0.Stop()
                                      tmr0.Dispose()
                                      BCExit()
                                  End If
                              End Sub
    End Sub
End Class
