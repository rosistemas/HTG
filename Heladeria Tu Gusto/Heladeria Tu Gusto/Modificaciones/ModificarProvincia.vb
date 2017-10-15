Public Class ModificarProvincia
    Private ReadOnly Property Conex As Conexiones = New Conexiones
    Private ReadOnly Property Asistente As AsistenteFormulario = new AsistenteFormulario
    Private Property IdProvinciaSeleccionada As Integer = 0

    Private Sub Modificar_Provincia_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargarGrilla()
    End Sub

    Private Sub button_guardar_Click(sender As Object, e As EventArgs) Handles button_guardar.Click
        If _
            MessageBox.Show("¿Está seguro de querer modificar los datos del producto seleccionado?", "Precaución",
                            MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = Windows.Forms.DialogResult.Yes Then

            if Asistente.VerificarVacios(Controls) = AsistenteFormulario.EstadoValidacion.SinErrores then
                Modificar()
                CargarGrilla()
                Asistente.LimpiarFormulario(Controls)
            End If
        Else
            MessageBox.Show("Los datos no se han alterado.", "Cancelado", MessageBoxButtons.OK,
                            MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub button_cancel_Click(sender As Object, e As EventArgs) Handles button_cancel.Click
        If _
            MessageBox.Show("Perderá los datos ingresados", "¿Desea cancelar la modificación?", MessageBoxButtons.YesNo,
                            MessageBoxIcon.Warning) = Windows.Forms.DialogResult.Yes Then
            Me.Close()
            Principal.Show()
        End If
    End Sub

    Private Sub CargarGrilla()
        Dim sql As String
        sql = "select * from Provincia"

        Dim tabla As New DataTable
        tabla = Conex.Consultar(sql)
        Me.grd_Provincia.Rows.Clear()
        For i = 0 To tabla.Rows.Count - 1
            Me.grd_Provincia.Rows.Add()
            Me.grd_Provincia.Rows(i).Cells("idProvincia").Value = tabla.Rows(i)("id")
            Me.grd_Provincia.Rows(i).Cells("nombre_Provincia").Value = tabla.Rows(i)("nombre")
        Next
    End Sub

    Private Sub grd_Provincia_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) _
        Handles grd_Provincia.CellDoubleClick
        Dim tabla As New DataTable
        Dim sql As String
        sql = "select * from Provincia where id = " & grd_Provincia.CurrentRow.Cells(0).Value

        tabla = Conex.Consultar(sql)
        txt_nombre.Text = tabla.Rows(0)("nombre")
        IdProvinciaSeleccionada = tabla.Rows(0)("id")
    End Sub

    Private Sub Modificar()
       Dim sql As String = "update Provincia set nombre = '" & txt_nombre.Text.Trim & "' where id = " &
                                IdProvinciaSeleccionada
            Conex.Insertar(sql)
    End Sub
End Class