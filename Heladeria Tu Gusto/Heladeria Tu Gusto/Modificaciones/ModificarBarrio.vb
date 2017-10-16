 Public Class ModificarBarrio

    Private Property Conex As Conexiones = New Conexiones
    Private Property Asistente As AsistenteFormulario = New AsistenteFormulario

    Private Sub Modificar_Provincia_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargarGrilla()
    End Sub

    Private Sub cmd_cancel_Click(sender As Object, e As EventArgs) Handles cmd_cancelar.Click
        If MessageBox.Show("Perderá los datos ingresados", "¿Desea cancelar la modificación?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.Yes Then
            Close()
            Principal.Show()
        End If
    End Sub

    Private Sub CargarGrilla()
        Dim sql As String
        sql = "select * from Barrio"

        Dim tabla As New DataTable
        tabla = conex.consultar(sql)
        Me.grd_barrios.Rows.Clear()
        For i = 0 To tabla.Rows.Count - 1
            Me.grd_barrios.Rows.Add()
            Me.grd_barrios.Rows(i).Cells("idBarrio").Value = tabla.Rows(i)("id")
            Me.grd_barrios.Rows(i).Cells("nombre_barrio").Value = tabla.Rows(i)("nombre")
            Me.grd_barrios.Rows(i).Cells("id_localidad").Value = tabla.Rows(i)("idLocalidad")
        Next

    End Sub

    Private Sub Modificar()
        Dim tabla As New DataTable
        Dim sql As String
        sql = "select id from Localidad l where l.nombre = " & Integer.Parse(txt_nombre.Text.Trim)
        tabla = conex.consultar(sql)
        Dim idaux As Integer = tabla.Rows(0)("id")
        sql = "update Localidad set nombre = " & Integer.Parse(txt_nombre.Text.Trim) & " where id =" & idaux
        conex.insertar(sql)
    End Sub

    Private Sub cmd_guardar_Click_1(sender As Object, e As EventArgs) Handles cmd_guardar.Click
        If MessageBox.Show("¿Está seguro de querer modificar los datos de la localidad seleccionada?", "Precaución", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = DialogResult.Yes Then
            Me.modificar()
            Me.cargarGrilla()
        Else
            MessageBox.Show("Los datos no se han alterado.", "Cancelado", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub grd_barrios_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles grd_barrios.CellDoubleClick

        Asistente.CargarCombo(cmb_localidades, Conex.LeerTabla("Barrio"), "nombre", "id")
        txt_nombre.Text = grd_barrios.CurrentRow.Cells("nombre_barrio").Value

    End Sub
End Class