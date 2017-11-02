Public Class RegistrarProveedor
    Private Property Conex As Conexiones = New Conexiones
    Private Property Asistente As AsistenteFormulario = New AsistenteFormulario


    Private Sub RegistrarProveedor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim tabla As New DataTable
        tabla = Conex.Consultar("select * from Provincia")
        Asistente.CargarCombo(cmb_tipo_documento, Conex.LeerTabla("TipoDoc"), "descripcion", "id")
        Asistente.CargarCombo(cmb_producto, Conex.Consultar("select * from producto p where p.idProducto not in (select p1.idProducto from proveedor p1)"), "nombre", "idProducto")
        Asistente.CargarCombo(cmb_provincia, tabla, "nombre", "id")
        cmb_localidad.DataSource = Nothing
        cmb_barrio.DataSource = Nothing
        cmb_localidad.Items.Clear()
        cmb_barrio.Items.Clear()
    End Sub

    Private Sub cmd_guardar_Click(sender As Object, e As EventArgs) Handles cmd_guardar.Click
        If Asistente.VerificarVacios(Controls) = Validador.EstadoValidacion.SinErrores Then
            Insertar()
            MsgBox("Se ha guardado la información.", MsgBoxStyle.OkOnly, "¡Éxito!")
        End If
    End Sub

    Private Sub Insertar()
        Dim sql 
        sql = "insert into Proveedor values"
        sql &= "(" & Conex.Generar_id_consecutivo("Proveedor", "idProveedor") 'idProveedor
        sql &= ", " & Integer.Parse(txt_numero_documento.Text.Trim) 'numDoc
        sql &= ", " & cmb_tipo_documento.SelectedValue              'tipoDoc
        sql &= ", '" & txt_razon_social.Text.Trim & "'"             'razonSocial
        sql &= ", '" & txt_mail.Text.Trim & "'"                     'mail
        sql &= ", " & cmb_barrio.SelectedValue                      'idBarrio
        sql &= ", '" & txt_calle.Text.Trim & "'"                    'calle
        sql &= ", " & Integer.Parse(txt_numero_calle.Text.Trim)     'numCalle
        sql &= ", '" & txt_nombre.Text.Trim & "'"                   'nombre
        sql &= ", " & cmb_localidad.SelectedValue                   'idLocalidad
        sql &= ", " & cmb_producto.SelectedValue                   'idProducto
        sql &= ", " & cmb_provincia.SelectedValue                   'idProvincia
        sql &= ")"

        Conex.Insertar(sql)
    End Sub

    Private Sub Cmd_cancelar_Click(sender As Object, e As EventArgs) Handles cmd_cancelar.Click
        'Simple funcionalidad del botón cancelar, limpia los campos y vuelve a mostrar la ventana principal
        Close()
    End Sub

    Private Sub RegistrarProveedor_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If MessageBox.Show("¿Está seguro que desea cancelar?", "Confirmar cancelación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) = DialogResult.No Then
            e.Cancel = True
        End If
        Principal.Show()
    End Sub

    Private Sub cmb_localidad_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cmb_localidad.SelectionChangeCommitted
        cmb_barrio.DataSource = Nothing
        cmb_barrio.Items.Clear()
        Dim sql As String = "select * from barrio where idLocalidad = " & cmb_localidad.SelectedValue
        Asistente.CargarCombo(cmb_barrio, Conex.Consultar(sql), "nombre", "id")
    End Sub


    Private Sub cmb_provincia_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cmb_provincia.SelectionChangeCommitted

        cmb_localidad.DataSource = Nothing
        cmb_barrio.DataSource = Nothing
        cmb_localidad.Items.Clear()
        cmb_barrio.Items.Clear()
        Dim sql As String = "select * from localidad where idProvincia = " & cmb_provincia.SelectedValue
        Asistente.CargarCombo(cmb_localidad, Conex.Consultar(sql), "nombre", "id")
    End Sub
End Class