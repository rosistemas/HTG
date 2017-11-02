Public Class ModificarEmpleado
    Private Property Asistente As AsistenteFormulario = New AsistenteFormulario
    Private Property IdEmpleadoSeleccionado As Integer = 0
    Private Property Conex As Conexiones = New Conexiones

    Private Sub ModificarEmpleado_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarGrilla()
    End Sub

    Private Sub btn_guardar_Click(sender As Object, e As EventArgs) Handles btn_guardar.Click
        If Asistente.VerificarVacios(Controls) = AsistenteFormulario.EstadoValidacion.SinErrores Then
            If MessageBox.Show("¿Está seguro de querer modificar los datos del producto seleccionado?", "Precaución", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = DialogResult.Yes Then
                Modificar()
                CargarGrilla()
                Asistente.LimpiarFormulario(Controls)
            Else
                MessageBox.Show("Los datos no se han alterado.", "Cancelado", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End If
    End Sub

    Private Sub btn_cancelar_Click(sender As Object, e As EventArgs) Handles btn_cancelar.Click
        If MessageBox.Show("Perderá los datos ingresados", "¿Desea cancelar la modificación?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.Yes Then
            Close()
            Principal.Show()
        End If
    End Sub

    Private Sub CargarGrilla()
        Dim sql
        sql = "SELECT E.*, T.descripcion, B.nombre as nombre_barrio FROM Empleado E INNER JOIN TipoDoc T ON E.tipoDoc = T.id INNER JOIN Barrio B ON E.idBarrio = B.id"
        Dim tabla As New DataTable
        tabla = Conex.Consultar(sql)
        Me.grd_empleados.Rows.Clear()
        For i = 0 To tabla.Rows.Count - 1
            grd_empleados.Rows.Add()
            grd_empleados.Rows(i).Cells("id").Value = tabla.Rows(i)("id")
            grd_empleados.Rows(i).Cells("nombre").Value = tabla.Rows(i)("nombre")
            grd_empleados.Rows(i).Cells("apellido").Value = tabla.Rows(i)("apellido")
            grd_empleados.Rows(i).Cells("tipo_documento").Value = tabla.Rows(i)("descripcion")
            grd_empleados.Rows(i).Cells("numero_documento").Value = tabla.Rows(i)("numDoc")
            grd_empleados.Rows(i).Cells("fecha_nacimiento").Value = tabla.Rows(i)("fechaNacimiento")
            grd_empleados.Rows(i).Cells("fecha_ingreso").Value = tabla.Rows(i)("fechaIngreso")
            grd_empleados.Rows(i).Cells("fecha_egreso").Value = tabla.Rows(i)("fechaEgreso")
            grd_empleados.Rows(i).Cells("id_barrio").Value = tabla.Rows(i)("idBarrio")
            grd_empleados.Rows(i).Cells("barrio").Value = tabla.Rows(i)("nombre_barrio")
            grd_empleados.Rows(i).Cells("calle").Value = tabla.Rows(i)("calle")
            grd_empleados.Rows(i).Cells("numero_calle").Value = tabla.Rows(i)("numCalle")
            grd_empleados.Rows(i).Cells("id_documento").Value = tabla.Rows(i)("tipoDoc")
        Next
    End Sub

    Private Sub grd_empleados_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles grd_empleados.CellDoubleClick

        txt_nombre.Text = grd_empleados.CurrentRow.Cells("nombre").Value
        txt_apellido.Text = grd_empleados.CurrentRow.Cells("apellido").Value
        txt_numero_documento.Text = grd_empleados.CurrentRow.Cells("numero_documento").Value
        txt_calle.Text = grd_empleados.CurrentRow.Cells("calle").Value
        txt_numero_calle.Text = grd_empleados.CurrentRow.Cells("numero_calle").Value
        Asistente.CargarCombo(cmb_barrio, Conex.LeerTabla("Barrio"), "nombre", "id")
        Asistente.CargarCombo(cmb_tipo_documento, Conex.LeerTabla("TipoDoc"), "descripcion", "id")
        cmb_barrio.SelectedValue = grd_empleados.CurrentRow.Cells("id_barrio").Value
        cmb_tipo_documento.SelectedValue = grd_empleados.CurrentRow.Cells("id_documento").Value

        IdEmpleadoSeleccionado = grd_empleados.CurrentRow.Cells("id").Value
    End Sub

    Private Sub Modificar()
        Dim sql
        sql = "update Empleado"
        sql &= " set nombre = '" & Me.txt_nombre.Text.Trim & "'"
        sql &= ", numDoc = " & Integer.Parse(txt_numero_documento.Text.Trim)
        sql &= ", tipoDoc = " & Me.cmb_tipo_documento.SelectedValue
        sql &= ", apellido = '" & Me.txt_apellido.Text.Trim & "'"
        sql &= ", fechaNacimiento = '" & date_fecha_nacimiento.Value.Date & "'"
        sql &= ", fechaIngreso = '" & date_fecha_ingreso.Value.Date & "'"
        sql &= ", idBarrio = " & Me.cmb_barrio.SelectedValue
        sql &= ", calle = '" & Me.txt_calle.Text.Trim & "'"
        sql &= ", numCalle = " & Integer.Parse(txt_numero_calle.Text.Trim)
        sql &= " where id = " & IdEmpleadoSeleccionado
        Conex.Insertar(sql)
    End Sub

    Private Sub ModificarEmpleado_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If MessageBox.Show("¿Está seguro que desea cancelar?", "Confirmar cancelación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) = DialogResult.No Then
            e.Cancel = True
        End If
    End Sub
End Class