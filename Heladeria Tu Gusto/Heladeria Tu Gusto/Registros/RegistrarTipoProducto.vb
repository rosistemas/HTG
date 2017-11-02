Public Class RegistrarTipoProducto
    Private Property  Conex as Conexiones = new Conexiones

    Private Sub Insertar()
        Dim sql 
        sql = "insert into TipoProducto values"
        sql &= "(" & Conex.Generar_id_consecutivo("TipoProducto", "idTipo") 
        sql &= ", '" & txt_nombre.Text.Trim & "')"               
        Conex.Insertar(sql)
    End Sub

    Private Sub cmd_guardar_Click(sender As Object, e As EventArgs) Handles cmd_guardar.Click
        insertar()
        MsgBox("Se ha guardado la información.", MsgBoxStyle.OkOnly, "¡Éxito!")
    End Sub

    Private Sub cmd_cancelar_Click(sender As Object, e As EventArgs) Handles cmd_cancelar.Click
        If _
            MessageBox.Show("Perderá los datos ingresados", "¿Desea cancelar el registro?", MessageBoxButtons.YesNo,
                            MessageBoxIcon.Warning) = DialogResult.Yes Then
            Close()
            Principal.Show()
        End If
    End Sub
End Class

