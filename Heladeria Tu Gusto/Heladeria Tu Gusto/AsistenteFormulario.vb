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

End Class
