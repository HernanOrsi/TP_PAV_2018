Imports System.Data.SqlClient

Public Class DatosHelados

    Dim string_conexion As String = "Data Source=DESKTOP-MKC1CQU;Initial Catalog=PAV_2018_Heladeria;Integrated Security=True"
    Dim nombre_Tabla As String = ""

    Dim cmd As Data.SqlClient.SqlCommand
    Dim conexion As Data.SqlClient.SqlConnection


    Public Property StringConexion() As String
        Get
            Return string_conexion
        End Get
        Set(ByVal value As String)
            string_conexion = value
        End Set
    End Property


    Public Property NombreTabla() As String
        Get
            Return nombre_Tabla
        End Get
        Set(ByVal value As String)
            nombre_Tabla = value
        End Set
    End Property

    Public Sub New()
        conexion = New Data.SqlClient.SqlConnection
        cmd = New Data.SqlClient.SqlCommand
    End Sub

    Public Sub New(ByVal pNombreTabla As String)
        NombreTabla = pNombreTabla
        conexion = New Data.SqlClient.SqlConnection
        cmd = New Data.SqlClient.SqlCommand
    End Sub

    Public Function CargarTablaHeladosSimples() As DataTable
        Dim dt As New DataTable
        Dim strSql As String = "SELECT IdHelado, Nombre, Precio FROM Helados"
        Dim da As New SqlDataAdapter(strSql, string_conexion)
        da.Fill(dt)
        Return dt

        ' Dim dt As New DataTable
        'Dim strSql As String = "SELECT (IdHelado,Nombre,Precio) FROM Helados"

        'conexion.ConnectionString = string_conexion
        'conexion.Open()
        'cmd.Connection = conexion
        'cmd.CommandType = CommandType.Text
        'cmd.CommandText = strSql
        'dt.Load(cmd.ExecuteReader())

        Return dt

    End Function

    Public Function SiguienteIdHelado() As String

        Dim dt As New DataTable
        Dim strSql As String = "SELECT TOP 1 IdHelado FROM Helados ORDER BY IdHelado DESC"
        Dim da As New SqlDataAdapter(strSql, string_conexion)
        da.Fill(dt)

        If dt.Rows.Count = 0 Then
            Return "1"
        Else

            Dim c As Integer = (dt.Rows(0).Item(0)) + 1
            Return c.ToString
        End If

    End Function

    Public Function ExisteIdHelado(ByVal pId As String) As Boolean
        Dim dt As New DataTable
        Dim strSql As String = "SELECT IdHelado FROM Helados WHERE IdHelado = " & pId
        Dim da As New SqlDataAdapter(strSql, string_conexion)
        da.Fill(dt)

        If dt.Rows.Count = 0 Then
            Return False
        Else
            Return True
        End If
    End Function

    Public Function ExisteNombreHelado(ByVal pNom As String) As Boolean
        Dim dt As New DataTable
        Dim strSql As String = "SELECT Nombre FROM Helados WHERE Nombre = '" & pNom & "'"
        Dim da As New SqlDataAdapter(strSql, string_conexion)
        da.Fill(dt)

        If dt.Rows.Count = 0 Then
            Return False
        Else
            Return True
        End If
    End Function

    Public Sub ModificarHelado(ByVal pId As String, ByVal pNom As String, ByVal pPrecio As String)
        Dim dt As New DataTable
        Dim strSql As String = "UPDATE Helados SET Nombre = '" & pNom & "', Precio = " & pPrecio & " WHERE IdHelado = " & pId

        conexion.ConnectionString = string_conexion
        conexion.Open()
        cmd.Connection = conexion
        cmd.CommandType = CommandType.Text
        cmd.CommandText = strSql
        cmd.ExecuteNonQuery()
        conexion.Close()

    End Sub



    Public Sub AltaHelado(ByVal pNom As String, ByVal pPrecio As String)
        Dim dt As New DataTable
        Dim strSql As String = "Insert into Helados (Nombre, EsEspecial, TieneProveedor, Precio) values ('" & pNom & "', 0, 0, " & pPrecio & ")"
        conexion.ConnectionString = string_conexion
        conexion.Open()
        cmd.Connection = conexion
        cmd.CommandType = CommandType.Text
        cmd.CommandText = strSql
        cmd.ExecuteNonQuery()
        conexion.Close()
    End Sub

    Public Sub EliminarHelado(ByVal pId As String)
        Dim dt As New DataTable
        Dim strSql As String = "delete from Helados where IdHelado = " & pId
        conexion.ConnectionString = string_conexion
        conexion.Open()
        cmd.Connection = conexion
        cmd.CommandType = CommandType.Text
        cmd.CommandText = strSql
        cmd.ExecuteNonQuery()
        conexion.Close()
    End Sub


    Public Function NombreHelado(ByVal pId As String) As String
        Dim nombre As String

        Dim dt As New DataTable
        Dim strSql As String = "SELECT Nombre FROM Helados WHERE IdHelado = " & pId
        Dim da As New SqlDataAdapter(strSql, string_conexion)
        da.Fill(dt)

        nombre = (dt.Rows(0).Item(0))

        Return nombre
    End Function

    Public Function BuscarHeladoPorNombre(ByVal pNom As String) As DataTable
        Dim dt As New DataTable
        Dim strSql As String = "SELECT * FROM Helados WHERE Nombre = '" & pNom & "'"
        Dim da As New SqlDataAdapter(strSql, string_conexion)
        da.Fill(dt)
        Return dt
    End Function

End Class
