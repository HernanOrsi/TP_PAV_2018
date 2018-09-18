Public Class frmMenuPrincipal
    Private Sub ConProveedorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ConProveedorToolStripMenuItem.Click
        Dim frmHeladosSimples As New frmAbmHeladosSimples
        frmAbmHeladosSimples.ShowDialog()
    End Sub
End Class
