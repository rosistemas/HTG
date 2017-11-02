 Public Class ModificarLocalidad
    Private Property Conex As Conexiones = New Conexiones
    Private Property LocalidadSeleccionada As Integer
    Private Property Asistente As AsistenteFormulario = New AsistenteFormulario


    Private Sub Modificar_Provincia_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarGrilla()
    End Sub

    Private Sub cmd_cancelar_Click(sender As Object, e As EventArgs) Handles cmd_cancelar.Click
        If _
            MessageBox.Show("Perderá los datos ingresados", "¿Desea cancelar la modificación?", MessageBoxButtons.YesNo,
                            MessageBoxIcon.Warning) = DialogResult.Yes Then
            Close()
            Principal.Show()
        End If
    End Sub

    Private Sub grd_Localidad_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) _
        Handles grd_Localidad.CellDoubleClick
        txt_nombre_localidad.Text = grd_Localidad.CurrentRow.Cells("nombre_localidad").Value
        LocalidadSeleccionada = grd_Localidad.CurrentRow.Cells("id_localidad").Value
        Asistente.CargarCombo(cmb_provincias, Conex.LeerTabla("Provincia"), "nombre", "id")
        cmb_provincias.SelectedValue = grd_Localidad.CurrentRow.Cells("id_provincia").Value
    End Sub

    Private Sub CargarGrilla()
        Dim sql As String
        sql = "select *, p.nombre as nombre_provincia from Localidad l join Provincia p on l.idProvincia = p.id"

        Dim tabla As New DataTable
        tabla = Conex.Consultar(sql)
        grd_Localidad.Rows.Clear()

        For i = 0 To tabla.Rows.Count - 1
            grd_Localidad.Rows.Add(tabla.Rows(i)("id"), tabla.Rows(i)("nombre"), tabla.Rows(i)("nombre_provincia"),
                                   tabla.Rows(i)("idProvincia"))
        Next
    End Sub

    Private Sub Modificar()
        Dim sql As String
        sql = "update Localidad set nombre = '" & txt_nombre_localidad.Text.Trim & "'"
        sql &= ", idProvincia = " & Integer.Parse(cmb_provincias.SelectedValue)
        sql &= " where id = " & LocalidadSeleccionada
        Conex.Insertar(sql)
    End Sub

    Private Sub cmd_guardar_Click(sender As Object, e As EventArgs) Handles cmd_guardar.Click
        If _
            MessageBox.Show("¿Está seguro de querer modificar los datos de la localidad seleccionada?", "Precaución",
                            MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = DialogResult.Yes Then
            If Asistente.VerificarVacios(Controls) = AsistenteFormulario.EstadoValidacion.SinErrores Then
                Modificar()
                CargarGrilla()
                Asistente.LimpiarFormulario(Controls)
            End If

        Else
            MessageBox.Show("Los datos no se han alterado.", "Cancelado", MessageBoxButtons.OK,
                            MessageBoxIcon.Information)
        End If
    End Sub
End Class