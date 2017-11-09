Public Class ModificarProvincia
    Private Property Conex As Conexiones = New Conexiones
    Private Property Asistente As AsistenteFormulario = New AsistenteFormulario
    Private Property IdProvinciaSeleccionada As Integer = 0

    Private Sub Modificar_Provincia_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarGrilla()
    End Sub

    Private Sub cmd_guardar_Click(sender As Object, e As EventArgs) Handles cmd_guardar.Click
        If _
            MessageBox.Show("¿Está seguro de querer modificar los datos del producto seleccionado?", "Precaución",
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

    Private Sub cmd_cancel_Click(sender As Object, e As EventArgs) Handles cmd_cancelar.Click
        Close()
        Principal.Show()
    End Sub

    Private Sub CargarGrilla()
        Dim sql
        sql = "select * from Provincia"

        Dim tabla As New DataTable
        tabla = Conex.Consultar(sql)
        Me.grd_Provincia.Rows.Clear()
        For i = 0 To tabla.Rows.Count - 1
            grd_Provincia.Rows.Add()
            grd_Provincia.Rows(i).Cells("id_provincia").Value = tabla.Rows(i)("id")
            grd_Provincia.Rows(i).Cells("nombre_Provincia").Value = tabla.Rows(i)("nombre")
        Next
    End Sub

    Private Sub grd_Provincia_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) _
        Handles grd_Provincia.CellDoubleClick
        IdProvinciaSeleccionada = grd_Provincia.CurrentRow.Cells("id_provincia").Value
        txt_nombre.Text = grd_Provincia.CurrentRow.Cells("nombre_provincia").Value
    End Sub

    Private Sub Modificar()
        Dim sql As String = "update Provincia set nombre = '" & txt_nombre.Text.Trim & "' where id = " &
                                 IdProvinciaSeleccionada
        Conex.Insertar(sql)
    End Sub

    Private Sub ModificarProvincia_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If _
            MessageBox.Show("¿Está seguro que desea cancelar?", "Confirmar cancelación", MessageBoxButtons.YesNo,
                            MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) = DialogResult.No _
            Then
            e.Cancel = True
        End If
    End Sub
End Class