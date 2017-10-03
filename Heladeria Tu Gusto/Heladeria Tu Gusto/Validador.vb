Public Class Validador
    Enum EstadoValidacion
        SinErrores
        ConErrores
    End Enum

    Public Function Verificar_vacios(ByRef controles As Object) As EstadoValidacion

        For Each obj As Control In controles
            'Group Boxes
            If obj.GetType().Name = "GroupBox" Then
               If Verificar_vacios(DirectCast(obj,GroupBox).Controls) = EstadoValidacion.ConErrores Then 
                    Return EstadoValidacion.ConErrores
                End If
            'Textboxes
            ElseIf obj.GetType().Name = "TextBox" Then
                If DirectCast(obj, TextBox).Text = "" Then
                    MessageBox.Show("Por favor, verifique los datos", "Campo de texto vacío", MessageBoxButtons.OK, MessageBoxIcon.Error)
                   DirectCast(obj, TextBox).Focus()
                    Return EstadoValidacion.ConErrores
                End If
                'Masked textboxes
            ElseIf obj.GetType().Name = "MaskedTextBox" Then
                If DirectCast(obj, MaskedTextBox).MaskFull = False Then
                    MessageBox.Show("Por favor, verifique los datos", "Valor incompleto", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    DirectCast(obj, MaskedTextBox).Focus()
                    Return EstadoValidacion.ConErrores
                End If
            End If
        Next
        Return EstadoValidacion.SinErrores
    End Function
End Class
