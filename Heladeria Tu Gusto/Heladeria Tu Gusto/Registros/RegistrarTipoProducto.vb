Public Class RegistrarTipoProducto


    Dim _conex As New Conexiones

    Private Sub Insertar()

        Dim sql As String = ""
        sql = "insert into TipoProducto values"
        sql &= "(" & _conex.Generar_id_consecutivo("TipoProducto", "idTipo") _
        
        sql &= ", '" & txt_nombre.Text.Trim & "')"               
        _conex.Insertar(sql)
    End Sub

    Private Sub cmd_guardar_Click(sender As Object, e As EventArgs) Handles cmd_guardar.Click
        Me.insertar()
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

