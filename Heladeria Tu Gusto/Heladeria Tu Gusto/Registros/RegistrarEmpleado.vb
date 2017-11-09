Public Class RegistrarEmpleado
    Private Property Asistente As AsistenteFormulario = New AsistenteFormulario
    Private Property Conex As Conexiones = New Conexiones

    Private Sub RegistrarEmpleado_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Asistente.CargarCombo(cmb_tipo_documento, Conex.LeerTabla("TipoDoc"), "descripcion", "id")
        cmb_barrio.DataSource = Nothing
        cmb_localidad.DataSource = Nothing
        cmb_barrio.Items.Clear()
        cmb_localidad.Items.Clear()
        Asistente.CargarCombo(cmb_provincia, Conex.LeerTabla("Provincia"), "nombre", "id")
    End Sub

    Private Sub cmd_guardar_Click(sender As Object, e As EventArgs) Handles cmd_guardar.Click
        If Asistente.VerificarVacios(Controls) = AsistenteFormulario.EstadoValidacion.SinErrores Then
            Insertar()
            MsgBox("Se ha guardado la información.", MsgBoxStyle.OkOnly, "¡Éxito!")
            Asistente.LimpiarFormulario(Controls)
        End If
    End Sub

    Private Sub Insertar()
        Dim sql
        sql = "insert into Empleado values"
        sql &= "(" & Conex.Generar_id_consecutivo("Empleado", "id")  'idEmpleado
        sql &= ", " & txt_numero_documento.Text.Trim                'numDoc
        sql &= ", " & cmb_tipo_documento.SelectedValue              'tipoDoc
        sql &= ", '" & txt_nombre.Text.Trim & "'"                   'nombre
        sql &= ", '" & txt_apellido.Text.Trim & "'"                 'apellido
        sql &= ", '" & date_fecha_nacimiento.Value.Date & "'"       'fechaNacimiento
        sql &= ", '" & DateTime.Today.Date & "'"                    'fechaIngreso
        sql &= ", null" '                                           'fechaEgreso
        sql &= ", " & cmb_barrio.SelectedValue                      'idBarrio
        sql &= ", '" & txt_calle.Text.Trim & "'"                    'calle
        sql &= ", " & txt_numero_calle.Text.Trim                    'numCalle
        sql &= ", " & cmb_localidad.SelectedValue                                             'idLocalidad
        sql &= ", " & cmb_provincia.SelectedValue                                             'idProvincia    
        sql &= ")"
        Conex.Insertar(sql)
    End Sub

    Private Sub cmd_cancelar_Click(sender As Object, e As EventArgs) Handles cmd_cancelar.Click
        Close()
    End Sub

    Private Sub RegistrarEmpleado_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If _
            MessageBox.Show("¿Desea cancelar el registro?", "Perderá los datos ingresados", MessageBoxButtons.YesNo,
                            MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) = DialogResult.No _
            Then
            e.Cancel = True
        End If
    End Sub

    Private Sub cmb_provincia_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cmb_provincia.SelectionChangeCommitted
        cmb_barrio.DataSource = Nothing
        cmb_barrio.Items.Clear()
        Asistente.CargarCombo(cmb_localidad, Conex.Consultar("select * from localidad l where l.idProvincia = " & cmb_provincia.SelectedValue), "nombre", "id")
    End Sub

    Private Sub cmb_localidad_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cmb_localidad.SelectionChangeCommitted
        Asistente.CargarCombo(cmb_barrio, Conex.Consultar("select * from barrio l where l.idLocalidad = " & cmb_localidad.SelectedValue), "nombre", "id")
    End Sub
End Class