<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Login
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Login))
        Me.LCLlbar = New Guna.UI2.WinForms.Guna2CircleProgressBar()
        Me.Loginbtt = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.Gcreabtt = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.Gsinginbtt = New Guna.UI2.WinForms.Guna2Button()
        Me.passbar = New Guna.UI2.WinForms.Guna2ProgressBar()
        Me.Inilbl = New System.Windows.Forms.Label()
        Me.EmailText = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Gsingupbtt = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.rgmlbl = New System.Windows.Forms.Label()
        Me.Lmfrm = New Guna.UI2.WinForms.Guna2DragControl(Me.components)
        Me.Guna2CustomGradientPanel1 = New Guna.UI2.WinForms.Guna2CustomGradientPanel()
        Me.Guna2ControlBox1 = New Guna.UI2.WinForms.Guna2ControlBox()
        Me.back = New Guna.UI2.WinForms.Guna2ImageButton()
        Me.LinkLabel2 = New System.Windows.Forms.LinkLabel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.Usernametext = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Cloud = New System.Windows.Forms.PictureBox()
        Me.Passwordtext = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Terms = New Guna.UI2.WinForms.Guna2CheckBox()
        Me.Guna2BorderlessForm1 = New Guna.UI2.WinForms.Guna2BorderlessForm(Me.components)
        Me.Guna2CustomGradientPanel1.SuspendLayout()
        CType(Me.Cloud, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LCLlbar
        '
        Me.LCLlbar.Animated = True
        Me.LCLlbar.AnimationSpeed = 2.0!
        Me.LCLlbar.BackColor = System.Drawing.Color.Transparent
        Me.LCLlbar.FillColor = System.Drawing.Color.Transparent
        Me.LCLlbar.ImageSize = New System.Drawing.Size(64, 64)
        Me.LCLlbar.Location = New System.Drawing.Point(148, 368)
        Me.LCLlbar.Name = "LCLlbar"
        Me.LCLlbar.ProgressColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.LCLlbar.ProgressColor2 = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(163, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.LCLlbar.ProgressOffset = 20
        Me.LCLlbar.ProgressThickness = 3
        Me.LCLlbar.ShadowDecoration.Parent = Me.LCLlbar
        Me.LCLlbar.Size = New System.Drawing.Size(40, 40)
        Me.LCLlbar.TabIndex = 9
        Me.LCLlbar.Value = 30
        Me.LCLlbar.Visible = False
        '
        'Loginbtt
        '
        Me.Loginbtt.Animated = True
        Me.Loginbtt.BackColor = System.Drawing.Color.Transparent
        Me.Loginbtt.BorderRadius = 6
        Me.Loginbtt.CheckedState.Parent = Me.Loginbtt
        Me.Loginbtt.CustomImages.Parent = Me.Loginbtt
        Me.Loginbtt.FillColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.Loginbtt.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.Loginbtt.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.Loginbtt.ForeColor = System.Drawing.Color.White
        Me.Loginbtt.HoverState.Parent = Me.Loginbtt
        Me.Loginbtt.Location = New System.Drawing.Point(45, 308)
        Me.Loginbtt.Name = "Loginbtt"
        Me.Loginbtt.ShadowDecoration.Parent = Me.Loginbtt
        Me.Loginbtt.Size = New System.Drawing.Size(248, 37)
        Me.Loginbtt.TabIndex = 19
        Me.Loginbtt.Text = "Login"
        '
        'Gcreabtt
        '
        Me.Gcreabtt.Animated = True
        Me.Gcreabtt.BackColor = System.Drawing.Color.Transparent
        Me.Gcreabtt.BorderColor = System.Drawing.Color.Transparent
        Me.Gcreabtt.BorderRadius = 6
        Me.Gcreabtt.CheckedState.Parent = Me.Gcreabtt
        Me.Gcreabtt.CustomImages.Parent = Me.Gcreabtt
        Me.Gcreabtt.FillColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.Gcreabtt.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.Gcreabtt.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.Gcreabtt.ForeColor = System.Drawing.Color.White
        Me.Gcreabtt.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(11, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.Gcreabtt.HoverState.Parent = Me.Gcreabtt
        Me.Gcreabtt.Location = New System.Drawing.Point(44, 364)
        Me.Gcreabtt.Name = "Gcreabtt"
        Me.Gcreabtt.ShadowDecoration.Parent = Me.Gcreabtt
        Me.Gcreabtt.Size = New System.Drawing.Size(248, 37)
        Me.Gcreabtt.TabIndex = 24
        Me.Gcreabtt.Text = "Create Account"
        Me.Gcreabtt.Visible = False
        '
        'Gsinginbtt
        '
        Me.Gsinginbtt.Animated = True
        Me.Gsinginbtt.BorderColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.Gsinginbtt.CheckedState.Parent = Me.Gsinginbtt
        Me.Gsinginbtt.CustomImages.Parent = Me.Gsinginbtt
        Me.Gsinginbtt.FillColor = System.Drawing.Color.Transparent
        Me.Gsinginbtt.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Gsinginbtt.ForeColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(130, Byte), Integer))
        Me.Gsinginbtt.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.Gsinginbtt.HoverState.CustomBorderColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.Gsinginbtt.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.Gsinginbtt.HoverState.ForeColor = System.Drawing.Color.White
        Me.Gsinginbtt.HoverState.Parent = Me.Gsinginbtt
        Me.Gsinginbtt.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.Gsinginbtt.ImageSize = New System.Drawing.Size(22, 22)
        Me.Gsinginbtt.Location = New System.Drawing.Point(408, -42)
        Me.Gsinginbtt.Name = "Gsinginbtt"
        Me.Gsinginbtt.ShadowDecoration.Parent = Me.Gsinginbtt
        Me.Gsinginbtt.Size = New System.Drawing.Size(63, 32)
        Me.Gsinginbtt.TabIndex = 25
        Me.Gsinginbtt.Text = "Back"
        Me.Gsinginbtt.Visible = False
        '
        'passbar
        '
        Me.passbar.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.passbar.BorderColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.passbar.FillColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(29, Byte), Integer))
        Me.passbar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.passbar.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.passbar.Location = New System.Drawing.Point(49, 291)
        Me.passbar.Maximum = 45
        Me.passbar.Name = "passbar"
        Me.passbar.ProgressColor = System.Drawing.Color.FromArgb(CType(CType(113, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.passbar.ProgressColor2 = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.passbar.ShadowDecoration.Parent = Me.passbar
        Me.passbar.Size = New System.Drawing.Size(242, 3)
        Me.passbar.TabIndex = 30
        Me.passbar.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault
        '
        'Inilbl
        '
        Me.Inilbl.AutoSize = True
        Me.Inilbl.BackColor = System.Drawing.Color.Transparent
        Me.Inilbl.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Inilbl.ForeColor = System.Drawing.Color.White
        Me.Inilbl.Location = New System.Drawing.Point(130, 462)
        Me.Inilbl.Name = "Inilbl"
        Me.Inilbl.Size = New System.Drawing.Size(119, 20)
        Me.Inilbl.TabIndex = 33
        Me.Inilbl.Text = "You got banned"
        Me.Inilbl.Visible = False
        '
        'EmailText
        '
        Me.EmailText.AccessibleDescription = "test"
        Me.EmailText.Animated = True
        Me.EmailText.BackColor = System.Drawing.Color.Transparent
        Me.EmailText.BorderColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.EmailText.BorderRadius = 2
        Me.EmailText.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.EmailText.DefaultText = ""
        Me.EmailText.DisabledState.Parent = Me.EmailText
        Me.EmailText.FillColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.EmailText.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.EmailText.FocusedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(47, Byte), Integer))
        Me.EmailText.FocusedState.Parent = Me.EmailText
        Me.EmailText.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.EmailText.ForeColor = System.Drawing.Color.Gainsboro
        Me.EmailText.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.EmailText.HoverState.Parent = Me.EmailText
        Me.EmailText.IconLeft = Global.Beatcracker.My.Resources.Resources.important_mail_48px
        Me.EmailText.Location = New System.Drawing.Point(46, 308)
        Me.EmailText.Name = "EmailText"
        Me.EmailText.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.EmailText.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.EmailText.PlaceholderText = "Email"
        Me.EmailText.SelectedText = ""
        Me.EmailText.ShadowDecoration.Parent = Me.EmailText
        Me.EmailText.Size = New System.Drawing.Size(248, 37)
        Me.EmailText.TabIndex = 36
        Me.EmailText.Tag = ""
        Me.EmailText.TextOffset = New System.Drawing.Point(5, 0)
        Me.EmailText.Visible = False
        '
        'Gsingupbtt
        '
        Me.Gsingupbtt.AutoSize = False
        Me.Gsingupbtt.BackColor = System.Drawing.Color.Transparent
        Me.Gsingupbtt.Font = New System.Drawing.Font("Segoe UI Black", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Gsingupbtt.ForeColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.Gsingupbtt.IsContextMenuEnabled = False
        Me.Gsingupbtt.IsSelectionEnabled = False
        Me.Gsingupbtt.Location = New System.Drawing.Point(217, 425)
        Me.Gsingupbtt.Name = "Gsingupbtt"
        Me.Gsingupbtt.Size = New System.Drawing.Size(53, 18)
        Me.Gsingupbtt.TabIndex = 38
        Me.Gsingupbtt.Text = "Register"
        Me.Gsingupbtt.TextAlignment = System.Drawing.ContentAlignment.TopCenter
        '
        'rgmlbl
        '
        Me.rgmlbl.AutoSize = True
        Me.rgmlbl.BackColor = System.Drawing.Color.Transparent
        Me.rgmlbl.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.rgmlbl.ForeColor = System.Drawing.Color.DarkGray
        Me.rgmlbl.Location = New System.Drawing.Point(89, 423)
        Me.rgmlbl.Name = "rgmlbl"
        Me.rgmlbl.Size = New System.Drawing.Size(126, 19)
        Me.rgmlbl.TabIndex = 46
        Me.rgmlbl.Text = "Not registered yet?"
        '
        'Lmfrm
        '
        Me.Lmfrm.ContainerControl = Me
        Me.Lmfrm.TargetControl = Me
        '
        'Guna2CustomGradientPanel1
        '
        Me.Guna2CustomGradientPanel1.Controls.Add(Me.Guna2ControlBox1)
        Me.Guna2CustomGradientPanel1.Controls.Add(Me.back)
        Me.Guna2CustomGradientPanel1.Controls.Add(Me.LCLlbar)
        Me.Guna2CustomGradientPanel1.Controls.Add(Me.LinkLabel2)
        Me.Guna2CustomGradientPanel1.Controls.Add(Me.Label3)
        Me.Guna2CustomGradientPanel1.Controls.Add(Me.Label2)
        Me.Guna2CustomGradientPanel1.Controls.Add(Me.Label1)
        Me.Guna2CustomGradientPanel1.Controls.Add(Me.Gsingupbtt)
        Me.Guna2CustomGradientPanel1.Controls.Add(Me.LinkLabel1)
        Me.Guna2CustomGradientPanel1.Controls.Add(Me.Usernametext)
        Me.Guna2CustomGradientPanel1.Controls.Add(Me.passbar)
        Me.Guna2CustomGradientPanel1.Controls.Add(Me.Cloud)
        Me.Guna2CustomGradientPanel1.Controls.Add(Me.Inilbl)
        Me.Guna2CustomGradientPanel1.Controls.Add(Me.Passwordtext)
        Me.Guna2CustomGradientPanel1.Controls.Add(Me.Gsinginbtt)
        Me.Guna2CustomGradientPanel1.Controls.Add(Me.Gcreabtt)
        Me.Guna2CustomGradientPanel1.Controls.Add(Me.Loginbtt)
        Me.Guna2CustomGradientPanel1.Controls.Add(Me.EmailText)
        Me.Guna2CustomGradientPanel1.Controls.Add(Me.rgmlbl)
        Me.Guna2CustomGradientPanel1.Controls.Add(Me.Terms)
        Me.Guna2CustomGradientPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Guna2CustomGradientPanel1.FillColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.Guna2CustomGradientPanel1.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.Guna2CustomGradientPanel1.FillColor3 = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(47, Byte), Integer))
        Me.Guna2CustomGradientPanel1.FillColor4 = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.Guna2CustomGradientPanel1.Location = New System.Drawing.Point(0, 0)
        Me.Guna2CustomGradientPanel1.Name = "Guna2CustomGradientPanel1"
        Me.Guna2CustomGradientPanel1.ShadowDecoration.Parent = Me.Guna2CustomGradientPanel1
        Me.Guna2CustomGradientPanel1.Size = New System.Drawing.Size(358, 583)
        Me.Guna2CustomGradientPanel1.TabIndex = 53
        '
        'Guna2ControlBox1
        '
        Me.Guna2ControlBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Guna2ControlBox1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2ControlBox1.ControlBoxStyle = Guna.UI2.WinForms.Enums.ControlBoxStyle.Custom
        Me.Guna2ControlBox1.CustomIconSize = 12.0!
        Me.Guna2ControlBox1.FillColor = System.Drawing.Color.Transparent
        Me.Guna2ControlBox1.HoverState.IconColor = System.Drawing.Color.WhiteSmoke
        Me.Guna2ControlBox1.HoverState.Parent = Me.Guna2ControlBox1
        Me.Guna2ControlBox1.IconColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.Guna2ControlBox1.Location = New System.Drawing.Point(329, 4)
        Me.Guna2ControlBox1.Name = "Guna2ControlBox1"
        Me.Guna2ControlBox1.ShadowDecoration.Parent = Me.Guna2ControlBox1
        Me.Guna2ControlBox1.Size = New System.Drawing.Size(24, 19)
        Me.Guna2ControlBox1.TabIndex = 61
        '
        'back
        '
        Me.back.BackColor = System.Drawing.Color.Transparent
        Me.back.CheckedState.ImageSize = New System.Drawing.Size(32, 32)
        Me.back.CheckedState.Parent = Me.back
        Me.back.HoverState.ImageSize = New System.Drawing.Size(38, 38)
        Me.back.HoverState.Parent = Me.back
        Me.back.Image = CType(resources.GetObject("back.Image"), System.Drawing.Image)
        Me.back.ImageRotate = 0!
        Me.back.ImageSize = New System.Drawing.Size(32, 32)
        Me.back.Location = New System.Drawing.Point(12, 12)
        Me.back.Name = "back"
        Me.back.PressedState.ImageSize = New System.Drawing.Size(32, 32)
        Me.back.PressedState.Parent = Me.back
        Me.back.Size = New System.Drawing.Size(25, 25)
        Me.back.TabIndex = 60
        Me.back.Visible = False
        '
        'LinkLabel2
        '
        Me.LinkLabel2.ActiveLinkColor = System.Drawing.Color.WhiteSmoke
        Me.LinkLabel2.AutoSize = True
        Me.LinkLabel2.BackColor = System.Drawing.Color.Transparent
        Me.LinkLabel2.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.LinkLabel2.ForeColor = System.Drawing.Color.DimGray
        Me.LinkLabel2.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.LinkLabel2.LinkColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.LinkLabel2.Location = New System.Drawing.Point(148, 523)
        Me.LinkLabel2.Name = "LinkLabel2"
        Me.LinkLabel2.Size = New System.Drawing.Size(62, 15)
        Me.LinkLabel2.TabIndex = 58
        Me.LinkLabel2.TabStop = True
        Me.LinkLabel2.Text = "contact us"
        Me.LinkLabel2.VisitedLinkColor = System.Drawing.Color.WhiteSmoke
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(130, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(115, 503)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(128, 15)
        Me.Label3.TabIndex = 57
        Me.Label3.Text = "A problem logging in? "
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.DarkGray
        Me.Label2.Location = New System.Drawing.Point(45, 128)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(249, 48)
        Me.Label2.TabIndex = 56
        Me.Label2.Text = "All connections to the servers are 100% secure you do not risk any risks"
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(45, 48)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(249, 67)
        Me.Label1.TabIndex = 55
        Me.Label1.Text = "Join us, and download more drumkit, flp, and gfx packs for FREE !"
        '
        'LinkLabel1
        '
        Me.LinkLabel1.ActiveLinkColor = System.Drawing.Color.WhiteSmoke
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.BackColor = System.Drawing.Color.Transparent
        Me.LinkLabel1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.LinkLabel1.ForeColor = System.Drawing.Color.DimGray
        Me.LinkLabel1.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.LinkLabel1.LinkColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.LinkLabel1.Location = New System.Drawing.Point(245, 425)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(74, 15)
        Me.LinkLabel1.TabIndex = 54
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "Terms of Use"
        Me.LinkLabel1.Visible = False
        Me.LinkLabel1.VisitedLinkColor = System.Drawing.Color.WhiteSmoke
        '
        'Usernametext
        '
        Me.Usernametext.AccessibleDescription = "test"
        Me.Usernametext.Animated = True
        Me.Usernametext.BackColor = System.Drawing.Color.Transparent
        Me.Usernametext.BorderColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.Usernametext.BorderRadius = 2
        Me.Usernametext.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Usernametext.DefaultText = ""
        Me.Usernametext.DisabledState.Parent = Me.Usernametext
        Me.Usernametext.FillColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.Usernametext.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.Usernametext.FocusedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(47, Byte), Integer))
        Me.Usernametext.FocusedState.Parent = Me.Usernametext
        Me.Usernametext.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Usernametext.ForeColor = System.Drawing.Color.Gainsboro
        Me.Usernametext.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(233, Byte), Integer))
        Me.Usernametext.HoverState.Parent = Me.Usernametext
        Me.Usernametext.IconLeft = Global.Beatcracker.My.Resources.Resources.male_user_48px
        Me.Usernametext.Location = New System.Drawing.Point(46, 196)
        Me.Usernametext.MaxLength = 15
        Me.Usernametext.Name = "Usernametext"
        Me.Usernametext.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.Usernametext.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.Usernametext.PlaceholderText = "Username"
        Me.Usernametext.SelectedText = ""
        Me.Usernametext.ShadowDecoration.Parent = Me.Usernametext
        Me.Usernametext.Size = New System.Drawing.Size(248, 37)
        Me.Usernametext.TabIndex = 16
        Me.Usernametext.Tag = ""
        Me.Usernametext.TextOffset = New System.Drawing.Point(5, 0)
        '
        'Cloud
        '
        Me.Cloud.Image = Global.Beatcracker.My.Resources.Resources.box_important_48px1
        Me.Cloud.Location = New System.Drawing.Point(109, 465)
        Me.Cloud.Name = "Cloud"
        Me.Cloud.Size = New System.Drawing.Size(16, 16)
        Me.Cloud.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Cloud.TabIndex = 52
        Me.Cloud.TabStop = False
        Me.Cloud.Visible = False
        '
        'Passwordtext
        '
        Me.Passwordtext.Animated = True
        Me.Passwordtext.BackColor = System.Drawing.Color.Transparent
        Me.Passwordtext.BorderColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.Passwordtext.BorderRadius = 2
        Me.Passwordtext.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Passwordtext.DefaultText = ""
        Me.Passwordtext.DisabledState.Parent = Me.Passwordtext
        Me.Passwordtext.FillColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.Passwordtext.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.Passwordtext.FocusedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(47, Byte), Integer))
        Me.Passwordtext.FocusedState.Parent = Me.Passwordtext
        Me.Passwordtext.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Passwordtext.ForeColor = System.Drawing.Color.Gainsboro
        Me.Passwordtext.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(233, Byte), Integer))
        Me.Passwordtext.HoverState.Parent = Me.Passwordtext
        Me.Passwordtext.IconLeft = Global.Beatcracker.My.Resources.Resources.privacy_52px
        Me.Passwordtext.Location = New System.Drawing.Point(46, 251)
        Me.Passwordtext.MaxLength = 15
        Me.Passwordtext.Name = "Passwordtext"
        Me.Passwordtext.PasswordChar = Global.Microsoft.VisualBasic.ChrW(9679)
        Me.Passwordtext.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.Passwordtext.PlaceholderText = "Password"
        Me.Passwordtext.SelectedText = ""
        Me.Passwordtext.ShadowDecoration.Parent = Me.Passwordtext
        Me.Passwordtext.Size = New System.Drawing.Size(248, 37)
        Me.Passwordtext.TabIndex = 18
        Me.Passwordtext.TextOffset = New System.Drawing.Point(5, 0)
        Me.Passwordtext.UseSystemPasswordChar = True
        '
        'Terms
        '
        Me.Terms.Animated = True
        Me.Terms.AutoEllipsis = True
        Me.Terms.BackColor = System.Drawing.Color.Transparent
        Me.Terms.CheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Terms.CheckedState.BorderRadius = 3
        Me.Terms.CheckedState.BorderThickness = 1
        Me.Terms.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Terms.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Terms.ForeColor = System.Drawing.Color.DarkGray
        Me.Terms.Location = New System.Drawing.Point(39, 419)
        Me.Terms.Name = "Terms"
        Me.Terms.Size = New System.Drawing.Size(280, 29)
        Me.Terms.TabIndex = 53
        Me.Terms.Text = " I agree to all statements included in"
        Me.Terms.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.Terms.UncheckedState.BorderRadius = 3
        Me.Terms.UncheckedState.BorderThickness = 1
        Me.Terms.UncheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.Terms.UseVisualStyleBackColor = False
        Me.Terms.Visible = False
        '
        'Guna2BorderlessForm1
        '
        Me.Guna2BorderlessForm1.AnimateWindow = True
        Me.Guna2BorderlessForm1.BorderRadius = 3
        Me.Guna2BorderlessForm1.ContainerControl = Me
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(358, 583)
        Me.Controls.Add(Me.Guna2CustomGradientPanel1)
        Me.DoubleBuffered = True
        Me.ForeColor = System.Drawing.Color.Black
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Login"
        Me.Opacity = 0R
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Login"
        Me.Guna2CustomGradientPanel1.ResumeLayout(False)
        Me.Guna2CustomGradientPanel1.PerformLayout()
        CType(Me.Cloud, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents LCLlbar As Guna.UI2.WinForms.Guna2CircleProgressBar
    Friend WithEvents Loginbtt As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents Passwordtext As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Usernametext As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Gcreabtt As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents Gsinginbtt As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents passbar As Guna.UI2.WinForms.Guna2ProgressBar
    Friend WithEvents Inilbl As Label
    Friend WithEvents EmailText As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents rgmlbl As Label
    Private WithEvents Gsingupbtt As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Lmfrm As Guna.UI2.WinForms.Guna2DragControl
    Friend WithEvents Cloud As PictureBox
    Friend WithEvents Guna2CustomGradientPanel1 As Guna.UI2.WinForms.Guna2CustomGradientPanel
    Friend WithEvents Guna2BorderlessForm1 As Guna.UI2.WinForms.Guna2BorderlessForm
    Friend WithEvents Terms As Guna.UI2.WinForms.Guna2CheckBox
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents LinkLabel2 As LinkLabel
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents back As Guna.UI2.WinForms.Guna2ImageButton
    Friend WithEvents Guna2ControlBox1 As Guna.UI2.WinForms.Guna2ControlBox
End Class
