Public Class RegistrarBarrio
    Private Property Conex As Conexiones = New Conexiones
    Private Property Asistente As AsistenteFormulario = New AsistenteFormulario

    Private Sub RegistrarBarrio_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Asistente.CargarCombo(cmb_localidad, Conex.LeerTabla("Localidad"), "nombre", "id")
    End Sub

    Private Sub cmd_guardar_Click(sender As Object, e As EventArgs) Handles cmd_guardar.Click
        Insertar()
        MsgBox("Se ha guardado la información.", MsgBoxStyle.OkOnly, "¡Éxito!")
    End Sub

    Private Sub Insertar()
        Dim sql 
        sql = "insert into Barrio values"
        sql &= "(" & Conex.Generar_id_consecutivo("Barrio", "id")  'idBarrio
        sql &= ", '" & txt_nombre.Text.Trim & "'"                  'nombre
        sql &= ", " & cmb_localidad.SelectedValue & ")"            'Combo localidad

        Conex.Insertar(sql)
    End Sub

    Private Sub cmd_cancelar_Click(sender As Object, e As EventArgs) Handles cmd_cancelar.Click
        'Simple funcionalidad del botón cancelar, limpia los campos y vuelve a mostrar la ventana principal
        If _
            MessageBox.Show("Perderá los datos ingresados", "¿Desea cancelar el registro?", MessageBoxButtons.YesNo,
                            MessageBoxIcon.Warning) = DialogResult.Yes Then
            Close()
            Principal.Show()
        End If
    End Sub
End Class