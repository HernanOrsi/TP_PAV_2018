Public Class frmAbmHeladosSimples

    Dim datos As New DatosHelados("Helados")

    Private Sub frmAbmHeladosSimples_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'PAV_2018_HeladeriaDataSet.Helados' table. You can move, or remove it, as needed.

        txtIdHelado.Enabled = False
        CargarGrilla()
        CargarID()

    End Sub

    Private Sub CargarGrilla()
        dgvHelados.DataSource = datos.CargarTablaHeladosSimples()

    End Sub

    Private Sub CargarID()
        Dim id As String = datos.SiguienteIdHelado()
        txtIdHelado.Text = id
    End Sub



    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        LimpiarCampos()

    End Sub

    Private Sub LimpiarCampos()
        txtNombreHelado.Text = ""
        txtPrecioHelado.Text = ""
        CargarID()

    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click

        'tiene que ValidarDatos ingresados en los textbox
        'un If para cada textbox, un break si no cumple la 
        'condicion
        If txtNombreHelado.Text = "" Then
            MsgBox("Debe cargar un nombre de helado", MsgBoxStyle.Critical, "Importante")
            Me.txtNombreHelado.Focus()
            Exit Sub
        End If

        If txtPrecioHelado.Text = "" Then
            MsgBox("Debe cargar un Precio", MsgBoxStyle.Critical, "Importante")
            Me.txtPrecioHelado.Focus()
            Exit Sub
        End If

        'tiene que buscar si ExisteIdHelado(id)
        'enviandole el id que está en el textbox
        '- si existe
        '    messegebox si/no
        '    advierte que ya existe un helado cargado con 
        '    ese id, y confirma si desea modificarlo
        '    - si desea modificarlo
        '        llama a ModificarHelado(id)
        '        se informa que se guardaron los cambios
        '     - si no lo desea modificar
        '        exit sub
        'Dim id As Integer
        'id = Integer.Parse(txtIdHelado.Text)
        'pensarlo con id=1, para querer obtener el nombre original con el que se guardó ne la bd

        If datos.ExisteIdHelado(txtIdHelado.Text) Then
            'If datos.ExisteNombreHelado(txtNombreHelado.Text) Then
            '   MsgBox("Ya existe un helado con ese nombre")
            '   Exit Sub
            'End If
            Dim nombre As String = datos.NombreHelado(txtIdHelado.Text)
            Dim opc As MsgBoxResult = MsgBox("¿Está seguro que desea modificar los datos del helado: " & nombre & "?", MsgBoxStyle.OkCancel, "Confirmar modifiación")
            If opc = MsgBoxResult.Ok Then
                datos.ModificarHelado(txtIdHelado.Text, txtNombreHelado.Text, txtPrecioHelado.Text)
                MsgBox("Se ha modificado con éxito")
                Me.CargarGrilla()
                Me.LimpiarCampos()

            Else
                Exit Sub
            End If

            '- si no existe
            '    tiene que buscar si ExisteNombre(txtNombre)
            '    - si existe
            '        informa que ya hay un helado con ese nombre
            '        break
            '    -si no existe
            '        llama a AltaHelado
            '        informa que se guardo en nuevo helado
        Else
            If datos.ExisteNombreHelado(txtNombreHelado.Text) Then
                MsgBox("Ya existe un helado con ese nombre")
                Exit Sub
            Else
                datos.AltaHelado(txtNombreHelado.Text, txtPrecioHelado.Text)
                MsgBox("Helado guardado con éxito")
                Me.CargarGrilla()
                Me.LimpiarCampos()

            End If

        End If

        'llama a limpiarcampos



    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        'abre el frmBuscalHeladoSimple con un combo

        'seleccione el helado que desea modificar

        'boton aceptar y cancelar

        '-si cancela
        '   cierra
        '-si acepta
        '   lee el value member del combo
        '   lo guarda el la variable id
        '   se lo manda a CargarDatosHelado(id)
        '   cierra
        Dim formBusqueda As New frmBuscarHeladoSimple
        formBusqueda.ShowDialog()

        Dim nombreBuscado As String = formBusqueda.NombreHelado

        If nombreBuscado = "" Then
            Exit Sub
        End If

        Dim dt As DataTable = datos.BuscarHeladoPorNombre(nombreBuscado)

        If dt.Rows.Count = 0 Then
            MsgBox("No se encontró el helado")
        Else
            MsgBox("Helado encontrado")
            txtIdHelado.Text = dt.Rows(0).Item(0).ToString
            txtNombreHelado.Text = dt.Rows(0).Item(1).ToString
            txtPrecioHelado.Text = dt.Rows(0).Item(4).ToString
        End If

    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        'con el textid llama a la función DatosHelado(id)
        'que devuelve los datos del helado que se va a eliminar
        'lo guardo en un string

        'llamo a un messegebox si/no
        'está por eliminar el siguiente helado:
        'string(Id: x, Nombre: y)
        '¿desea eliminarlo?
        '- si si
        '      llama a EliminarHelado(id)
        '- si no
        '    Exit sub
        If (datos.ExisteIdHelado(txtIdHelado.Text) = False) Then
            MsgBox("No se puede eliminar el helado. No se encuentra registrado")
            Exit Sub
        End If
        Dim nombre As String = datos.NombreHelado(txtIdHelado.Text)
        Dim opc As MsgBoxResult = MsgBox("¿Está seguro que desea eliminar el helado: " & nombre & "?", MsgBoxStyle.OkCancel, "Confirmar eliminación")
        If opc = MsgBoxResult.Ok Then
            datos.EliminarHelado(txtIdHelado.Text)
            MsgBox("Se ha eliminado con éxito")
            Me.CargarGrilla()
            Me.LimpiarCampos()

        Else
            Exit Sub
        End If

    End Sub

    Private Sub txtPrecioHelado_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPrecioHelado.KeyPress
        Select Case Asc(e.KeyChar)
            Case 4, 24, 19, 127, 13, 9, 15, 14, 8
                Exit Sub
        End Select

        If IsNumeric(e.KeyChar) = False Then
            MsgBox("Este carater no es un numero ( " + e.KeyChar + " )", vbCritical, "Importante")
            e.KeyChar = ""
        End If
    End Sub
End Class