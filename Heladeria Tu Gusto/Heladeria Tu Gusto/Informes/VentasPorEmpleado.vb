Public Class VentasPorEmpleado
    Private Property conex As New Conexiones
    Dim value_changed_desde As Boolean = False

    Private Sub reset()
        value_changed_desde = False
        date_desde.Value = DateString
        date_hasta.Value = DateString
    End Sub
    Private Sub cmd_calcular_Click(sender As Object, e As EventArgs) Handles cmd_calcular.Click

        If value_changed_desde = False Then
            MsgBox("Debe seleccionar una fecha de inicio", MsgBoxStyle.Information, "Error de Coherencia")
            Exit Sub
        End If

        Dim sql As String = ""
        sql = "select e.id as 'legajo', e.nombre, e.apellido, t.id as 'idVenta'"
        sql &= ", t.fecha, t.hora, t.total as 'totalVendido' from empleado e inner join"
        sql &= " ticket t on(e.id = t.legajoEmpleado)"
        sql &= " where  t.fecha > '" & date_desde.Value.Date & "' and "
        sql &= "t.fecha < '" & date_hasta.Value.Date & "'"

        bs_ventas_por_empleado.DataSource = conex.Consultar(sql)
        rv_ventas_por_empleado.RefreshReport()
        reset()

    End Sub

    Private Sub date_desde_ValueChanged(sender As Object, e As EventArgs) Handles date_desde.ValueChanged
        If date_desde.Value > date_hasta.Value Then
            MsgBox("No puede seleccionar una fecha de inicio mayor a la fecha de fin", MsgBoxStyle.Critical, "Error de Coherencia")
            date_desde.Value = date_hasta.Value
            Exit Sub
        End If
        If date_desde.Value <> date_hasta.Value Then
            value_changed_desde = True
        End If

    End Sub

    Private Sub date_hasta_ValueChanged(sender As Object, e As EventArgs) Handles date_hasta.ValueChanged
        If date_hasta.Value > DateString Then
            MsgBox("No puede seleccionar una fecha futura", MsgBoxStyle.Critical, "Error de Coherencia")
            date_hasta.Value = DateString
        End If
        date_desde.Value = date_hasta.Value
    End Sub

    Private Sub VentasPorEmpleado_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class