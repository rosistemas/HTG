 Public Class ModificarBarrio

    Private Property Conex As Conexiones = New Conexiones
    Private Property Asistente As AsistenteFormulario = New AsistenteFormulario
    Private Property BarrioSeleccionado As Integer
    Private Sub Modificar_Provincia_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarGrilla()
    End Sub

    Private Sub cmd_cancel_Click(sender As Object, e As EventArgs) Handles cmd_cancelar.Click
        If MessageBox.Show("Perderá los datos ingresados", "¿Desea cancelar la modificación?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.Yes Then
            Close()
            Principal.Show()
        End If
    End Sub

    Private Sub CargarGrilla()
        Dim sql As String
        sql = "select B.*, L.nombre as nombre_localidad from Barrio B join Localidad L on B.idLocalidad = L.id"

        Dim tabla As New DataTable
        tabla = Conex.Consultar(sql)
        grd_barrios.Rows.Clear()
        For i = 0 To tabla.Rows.Count - 1
            grd_barrios.Rows.Add(tabla.Rows(i)("id"), tabla.Rows(i)("nombre"), tabla.Rows(i)("idLocalidad"), tabla.Rows(i)("nombre_localidad"))
        Next
    End Sub

    Private Sub Modificar()
        Dim sql As String
        sql = "update Barrio set nombre = '" & txt_nombre.Text.Trim & "'"
        sql &= ", idLocalidad = " & cmb_localidades.SelectedValue
        sql &= " where id = " & BarrioSeleccionado
        Conex.Insertar(sql)
    End Sub

    Private Sub cmd_guardar_Click(sender As Object, e As EventArgs) Handles cmd_guardar.Click
        If MessageBox.Show("¿Está seguro de querer modificar los datos de la localidad seleccionada?", "Precaución", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = DialogResult.Yes Then
            If Asistente.VerificarVacios(Controls) = AsistenteFormulario.EstadoValidacion.SinErrores Then
                Modificar()
                CargarGrilla()
                Asistente.LimpiarFormulario(Controls)
            End If
        Else
            MessageBox.Show("Los datos no se han alterado.", "Cancelado", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub grd_barrios_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles grd_barrios.CellDoubleClick
        Asistente.CargarCombo(cmb_localidades, Conex.LeerTabla("Localidad"), "nombre", "id")
        cmb_localidades.SelectedValue = grd_barrios.CurrentRow.Cells("id_localidad").Value
        txt_nombre.Text = grd_barrios.CurrentRow.Cells("nombre_barrio").Value
        BarrioSeleccionado = grd_barrios.CurrentRow.Cells("id_barrio").Value
    End Sub
End Class