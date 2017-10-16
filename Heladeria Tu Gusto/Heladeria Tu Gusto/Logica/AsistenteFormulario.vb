Public Class AsistenteFormulario
    Enum EstadoValidacion
        SinErrores
        ConErrores
    End Enum

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
        'Muestra la informacion de un empleado en un Display label        Dim conex As New Conexiones        Dim selected As String = combo.SelectedValue        Dim table As New DataTable        Dim sql As String = "select * from empleado where id = " & selected        table = conex.Consultar(sql)        label.Text = table.Rows(0)("nombre") & " " & table.Rows(0)("apellido")        End Sub
    Public Sub LimpiarFormulario(ByRef controles As Object)
        For Each obj As Object In controles
            'Si es un groupbox, procesar sus controles
            If obj.getType().Name = "GroupBox" Then
                LimpiarFormulario(DirectCast(obj, GroupBox).Controls)
                'Textboxes
            ElseIf obj.getType().Name = "TextBox" Then
                DirectCast(obj, TextBox).Clear()
                'Masked textboxes
            ElseIf obj.getType().Name = "MaskedTextBox" Then
                DirectCast(obj, MaskedTextBox).Clear()
                'Combos
            ElseIf obj.GetType().Name = "ComboBox" Then
                DirectCast(obj, ComboBox).DataSource = Nothing
            End If

        Next
    End Sub


    Public Function VerificarVacios(ByRef controles As Object) As EstadoValidacion

        For Each obj As Control In controles
            'Group Boxes
            If obj.GetType().Name = "GroupBox" Then
                If VerificarVacios(DirectCast(obj, GroupBox).Controls) = EstadoValidacion.ConErrores Then
                    Return EstadoValidacion.ConErrores
                End If
                'Textboxes
            ElseIf obj.GetType().Name = "TextBox" Then
                If DirectCast(obj, TextBox).Text = "" Then
                    MessageBox.Show("Por favor, verifique los datos", "Campo de texto vacío", MessageBoxButtons.OK,
                                    MessageBoxIcon.Error)
                    DirectCast(obj, TextBox).Focus()
                    Return EstadoValidacion.ConErrores
                End If
                'Masked textboxes
            ElseIf obj.GetType().Name = "MaskedTextBox" Then
                If DirectCast(obj, MaskedTextBox).MaskFull = False Then
                    MessageBox.Show("Por favor, verifique los datos", "Valor incompleto", MessageBoxButtons.OK,
                                    MessageBoxIcon.Error)
                    DirectCast(obj, MaskedTextBox).Focus()
                    Return EstadoValidacion.ConErrores
                End If
            End If
        Next
        Return EstadoValidacion.SinErrores
    End Function

End Class
