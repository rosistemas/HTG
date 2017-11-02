Public Class RegistrarTurno
    Dim asistente As New AsistenteFormulario
    Dim conex As New Conexiones

    Private Sub RegistrarTurno_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        asistente.CargarCombo(cmb_turno, conex.LeerTabla("Turno"), "descripcion", "id")
        asistente.CargarCombo(cmb_supervisor, conex.LeerTabla("Empleado"), "id", "id")
        asistente.CargarCombo(cmb_primer_ayudante, conex.LeerTabla("Empleado"), "id", "id")
        asistente.CargarCombo(cmb_segundo_ayudante, conex.LeerTabla("Empleado"), "id", "id")
        asistente.MostrarInfoEmpleado(cmb_supervisor, lbl_display_supervisor)
        asistente.MostrarInfoEmpleado(cmb_primer_ayudante, lbl_display_primer_ayudante)
        asistente.MostrarInfoEmpleado(cmb_segundo_ayudante, lbl_display_segundo_ayudante)
    End Sub

    Private Sub cmb_supervisor_SelectionChangeCommitted(sender As Object, e As EventArgs) _
        Handles cmb_supervisor.SelectionChangeCommitted
        asistente.MostrarInfoEmpleado(cmb_supervisor, lbl_display_supervisor)
    End Sub

    Private Sub cmb_primer_ayudante_SelectionChangeCommitted(sender As Object, e As EventArgs) _
        Handles cmb_primer_ayudante.SelectionChangeCommitted
        asistente.MostrarInfoEmpleado(cmb_primer_ayudante, lbl_display_primer_ayudante)
    End Sub

    Private Sub cmb_segundo_ayudante_SelectionChangeCommitted(sender As Object, e As EventArgs) _
        Handles cmb_segundo_ayudante.SelectionChangeCommitted
        asistente.MostrarInfoEmpleado(cmb_segundo_ayudante, lbl_display_segundo_ayudante)
    End Sub

    Private Sub cmd_guardar_Click(sender As Object, e As EventArgs) Handles cmd_guardar.Click
        If chk_un_ayudante.Checked = False Then
            If cmb_supervisor.SelectedValue = cmb_primer_ayudante.SelectedValue Or
               cmb_supervisor.SelectedValue = cmb_segundo_ayudante.SelectedValue Or
               cmb_primer_ayudante.SelectedValue = cmb_segundo_ayudante.SelectedValue Then
                MsgBox("Un mismo empleado no puede cubrir más de un rol en un turno.", MsgBoxStyle.Critical,
                       "Error de coherencia")
                Exit Sub
            End If
            If validar_fecha_futura() = False Then
                MsgBox("No puede asignar un turno a un día pasado.", MsgBoxStyle.Critical, "Error de coherencia")
                Exit Sub
            End If
            If _
                MessageBox.Show("¿Está seguro que desea registrar?", "Confirmar registro", MessageBoxButtons.YesNo,
                                MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = DialogResult.No Then
                Exit Sub
            End If
            Dim tabla As New DataTable
            tabla = validar_exitencia_turno()
            If tabla.Rows.Count <> 0 Then
                MsgBox("El turno seleccionado ya está registrado.", MsgBoxStyle.Information, "Turno existente")
                Exit Sub
            End If

            Dim sql As String = ""
            sql = "insert into detallesturno values("
            sql &= cmb_turno.SelectedValue & ", '"
            sql &= date_fecha.Value.Date & "', "
            sql &= cmb_supervisor.SelectedValue & ", "
            sql &= cmb_primer_ayudante.SelectedValue & ", "
            sql &= cmb_segundo_ayudante.SelectedValue & ")"
            conex.Insertar(sql)
            MsgBox("El turno se ha guardado con éxito.", MsgBoxStyle.Information, "Datos guardados")
        Else
            If cmb_supervisor.SelectedValue = cmb_primer_ayudante.SelectedValue Then
                MsgBox("Un mismo empleado no puede cubrir más de un rol en un turno.", MsgBoxStyle.Critical,
                       "Error de coherencia")
                Exit Sub
            End If
            If validar_fecha_futura() = False Then
                MsgBox("No puede asignar un turno a un día pasado.", MsgBoxStyle.Critical, "Error de coherencia")
                Exit Sub
            End If

            If _
                MessageBox.Show("¿Está seguro que desea registrar?", "Confirmar registro", MessageBoxButtons.YesNo,
                                MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = DialogResult.No Then
                Exit Sub
            End If
            Dim tabla As New DataTable
            tabla = validar_exitencia_turno()
            If tabla.Rows.Count <> 0 Then
                MsgBox("El turno seleccionado ya está registrado.", MsgBoxStyle.Information, "Turno existente")
                Exit Sub
            End If
            Dim sql As String = ""
            sql = "insert into detallesturno values("
            sql &= cmb_turno.SelectedValue & ", '"
            sql &= date_fecha.Value.Date & "', "
            sql &= cmb_supervisor.SelectedValue & ", "
            sql &= cmb_primer_ayudante.SelectedValue & ", "
            sql &= "null)"
            conex.Insertar(sql)
            MsgBox("El turno se ha guardado con éxito.", MsgBoxStyle.Information, "Datos guardados")
        End If
    End Sub

    Private Function validar_exitencia_turno() As DataTable
        Dim tabla As New DataTable
        Dim validacion As String = "select * from detallesTurno where idTurno = " & cmb_turno.SelectedValue
        validacion &= " and fecha = '" & date_fecha.Value.Date & "'"
        tabla = conex.Consultar(validacion)
        Return tabla
    End Function

    Private Function validar_fecha_futura() As Boolean
        If DateString > date_fecha.Value.Date Then
            'La fecha seleccionada es anterior al dia
            Return False
        Else
            'La fecha seleccionada es futura
            Return True
        End If
    End Function

    Private Sub habilitar_deshabilitar_ayudante()
        If cmb_segundo_ayudante.Enabled = True Then
            cmb_segundo_ayudante.Enabled = False
            lbl_display_segundo_ayudante.Text = ""
            lbl_segundo_ayudante.Enabled = False
            cmb_segundo_ayudante.DataSource = Nothing
            cmb_segundo_ayudante.Items.Clear()
        Else
            cmb_segundo_ayudante.Enabled = True
            lbl_segundo_ayudante.Enabled = True
            asistente.CargarCombo(cmb_segundo_ayudante, conex.LeerTabla("Empleado"), "id", "id")
            asistente.MostrarInfoEmpleado(cmb_segundo_ayudante, lbl_display_segundo_ayudante)
        End If
    End Sub

    Private Sub chk_un_ayudante_CheckedChanged(sender As Object, e As EventArgs) Handles chk_un_ayudante.CheckedChanged
        habilitar_deshabilitar_ayudante()
    End Sub

    Private Sub cmd_cancelar_Click(sender As Object, e As EventArgs) Handles cmd_cancelar.Click
        Close()
    End Sub

    Private Sub RegistrarTurno_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If _
            MessageBox.Show("¿Está seguro que desea cancelar?", "Confirmar cancelación", MessageBoxButtons.YesNo,
                            MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) = DialogResult.No Then
            e.Cancel = True
        End If
    End Sub
End Class