Public Class frmBuscarHeladoSimple
    Dim busqueda As String = ""


    Public Property NombreHelado() As String
        Get
            Return busqueda
        End Get
        Set(ByVal value As String)
            busqueda = value
        End Set
    End Property

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        If Me.txtBuscar.Text <> "" Then
            Me.busqueda = Me.txtBuscar.Text
            Me.Close()
        Else
            MsgBox("Cargue un nombre para realizar la busqueda")
        End If
    End Sub
End Class