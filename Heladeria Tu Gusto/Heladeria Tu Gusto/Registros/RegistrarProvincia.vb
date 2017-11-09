﻿Public Class RegistrarProvincia
    Private Property  Conex as Conexiones = new Conexiones
    Private Sub Insertar()
        Dim sql
        sql = "insert into Provincia values"
        sql &= "(" & Conex.Generar_id_consecutivo("Provincia", "id")  'idProvincia
        sql &= ", '" & txt_nombre.Text.Trim & "')"                     'nombre
        Conex.Insertar(sql)
    End Sub
    
    Private Sub cmd_guardar_Click(sender As Object, e As EventArgs) Handles cmd_guardar.Click
        insertar()
        MsgBox("Se ha guardado la información.", MsgBoxStyle.OkOnly, "¡Éxito!")
    End Sub

    Private Sub cmd_cancelar_Click(sender As Object, e As EventArgs) Handles cmd_cancelar.Click
        Close()
    End Sub

    Private Sub RegistrarProvincia_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If _
            MessageBox.Show("¿Desea cancelar el registro?", "Perderá los datos ingresados", MessageBoxButtons.YesNo,
                            MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) = DialogResult.No _
            Then
            e.Cancel = True
        End If
    End Sub
End Class