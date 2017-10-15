Public Class AsistenteFormulario

    Public Sub CargarCombo(ByRef combo As ComboBox, ByRef tabla As DataTable, descriptor As String, pk As String)
        combo.DataSource = Nothing
        'Limpiar el comboBox
        combo.Items.Clear()
        'Le asigno una nueva fuente
        combo.DataSource = tabla
        'Asociar un texto para mostrar
        combo.DisplayMember = descriptor
        'Asignarle un valor a ese texto mostrado
        combo.ValueMember = pk
    End Sub
    Public Sub MostrarInfoEmpleado(ByRef combo As ComboBox, ByRef label As Label)
        'Muestra la informacion de un empleado en un Display label
        Dim conex As New Conexiones
        Dim selected As String = combo.SelectedValue
        Dim table As New DataTable
        Dim sql As String = "select * from empleado where id = " & selected
        table = conex.Consultar(sql)
        label.Text = table.Rows(0)("nombre") & " " & table.Rows(0)("apellido")
    End Sub

End Class
