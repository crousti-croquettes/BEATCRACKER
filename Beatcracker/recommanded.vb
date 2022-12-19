Public Class recommanded
    Dim hScrollHelper As Guna.UI.Lib.ScrollBar.PanelScrollHelper
    Private Sub recommanded_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        hScrollHelper = New Guna.UI.Lib.ScrollBar.PanelScrollHelper(Guna2Panel1, GunaHScrollBar1, True)
        hScrollHelper.UpdateScrollBar()
    End Sub
End Class
