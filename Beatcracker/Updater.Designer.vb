<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Updater
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Updater))
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.GunaLabel5 = New System.Windows.Forms.Label()
        Me.UpdFSlbl = New System.Windows.Forms.Label()
        Me.UpdCSlbl = New System.Windows.Forms.Label()
        Me.UpdBar = New Guna.UI2.WinForms.Guna2CircleProgressBar()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Guna2Elipse1 = New Guna.UI2.WinForms.Guna2Elipse(Me.components)
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(462, 76)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(13, 13)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "0"
        Me.Label2.Visible = False
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {""})
        Me.ComboBox1.Location = New System.Drawing.Point(432, 24)
        Me.ComboBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(92, 21)
        Me.ComboBox1.TabIndex = 7
        Me.ComboBox1.Text = "0"
        Me.ComboBox1.Visible = False
        '
        'GunaLabel5
        '
        Me.GunaLabel5.BackColor = System.Drawing.Color.Transparent
        Me.GunaLabel5.Font = New System.Drawing.Font("Segoe UI", 16.0!, System.Drawing.FontStyle.Bold)
        Me.GunaLabel5.ForeColor = System.Drawing.Color.White
        Me.GunaLabel5.Location = New System.Drawing.Point(0, 0)
        Me.GunaLabel5.Name = "GunaLabel5"
        Me.GunaLabel5.Size = New System.Drawing.Size(371, 38)
        Me.GunaLabel5.TabIndex = 23
        Me.GunaLabel5.Text = "BEATCRACKER"
        Me.GunaLabel5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'UpdFSlbl
        '
        Me.UpdFSlbl.AutoSize = True
        Me.UpdFSlbl.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UpdFSlbl.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.UpdFSlbl.Location = New System.Drawing.Point(97, 91)
        Me.UpdFSlbl.Name = "UpdFSlbl"
        Me.UpdFSlbl.Size = New System.Drawing.Size(177, 75)
        Me.UpdFSlbl.TabIndex = 24
        Me.UpdFSlbl.Text = "Current Version: 0.0" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "New Version: 0.0" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Downloading..."
        Me.UpdFSlbl.Visible = False
        '
        'UpdCSlbl
        '
        Me.UpdCSlbl.AutoSize = True
        Me.UpdCSlbl.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.UpdCSlbl.ForeColor = System.Drawing.Color.White
        Me.UpdCSlbl.Location = New System.Drawing.Point(82, 65)
        Me.UpdCSlbl.Name = "UpdCSlbl"
        Me.UpdCSlbl.Size = New System.Drawing.Size(207, 21)
        Me.UpdCSlbl.TabIndex = 26
        Me.UpdCSlbl.Text = "CHECKING FOR UPDATES.."
        '
        'UpdBar
        '
        Me.UpdBar.Animated = True
        Me.UpdBar.FillColor = System.Drawing.Color.Transparent
        Me.UpdBar.FillOffset = 50
        Me.UpdBar.FillThickness = 0
        Me.UpdBar.Location = New System.Drawing.Point(153, 119)
        Me.UpdBar.Name = "UpdBar"
        Me.UpdBar.ProgressColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.UpdBar.ProgressColor2 = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(163, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.UpdBar.ProgressOffset = 20
        Me.UpdBar.ProgressThickness = 3
        Me.UpdBar.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.UpdBar.ShadowDecoration.Parent = Me.UpdBar
        Me.UpdBar.Size = New System.Drawing.Size(64, 64)
        Me.UpdBar.TabIndex = 33
        Me.UpdBar.Value = 15
        '
        'Label1
        '
        Me.Label1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 16.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(1, 38)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(3, 165)
        Me.Label1.TabIndex = 34
        Me.Label1.Text = " "
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 16.0!, System.Drawing.FontStyle.Bold)
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(366, 38)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(3, 165)
        Me.Label3.TabIndex = 35
        Me.Label3.Text = " "
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Me.Label4.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label4.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 16.0!, System.Drawing.FontStyle.Bold)
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(0, 201)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(370, 3)
        Me.Label4.TabIndex = 36
        Me.Label4.Text = " "
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Guna2Elipse1
        '
        Me.Guna2Elipse1.BorderRadius = 4
        Me.Guna2Elipse1.TargetControl = Me
        '
        'Updater
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(47, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(370, 205)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.UpdCSlbl)
        Me.Controls.Add(Me.GunaLabel5)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.UpdBar)
        Me.Controls.Add(Me.UpdFSlbl)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Updater"
        Me.Opacity = 0R
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Updating"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label2 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents GunaLabel5 As Label
    Friend WithEvents UpdFSlbl As Label
    Friend WithEvents UpdCSlbl As Label
    Friend WithEvents UpdBar As Guna.UI2.WinForms.Guna2CircleProgressBar
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Guna2Elipse1 As Guna.UI2.WinForms.Guna2Elipse
End Class
