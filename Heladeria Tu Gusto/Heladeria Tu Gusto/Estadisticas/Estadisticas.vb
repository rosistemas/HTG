Public Class Estadisticas
    Private Property  Conex As Conexiones = New Conexiones

    Private Sub Estadisticas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        rv_productos_vendidos.RefreshReport()
        rv_porcentaje_ingresos.RefreshReport
        rv_ventas_por_horario.RefreshReport
    End Sub

    Private Sub btn_graficar_productos_vendidos_Click(sender As Object, e As EventArgs) Handles btn_graficar_productos_vendidos.Click
        If rv_productos_vendidos.Visible = False Then
            lbl_presione_productos_vendidos.Visible = False
            rv_productos_vendidos.Visible = True
        End If
        GraficarBarrasProductosVendidos()
    End Sub

    Private Sub GraficarBarrasProductosVendidos()
        Dim sql, tabla

        sql = "SELECT P.nombre, SUM(DT.cantidad) as cantidad"
        sql &= " FROM Producto P join DetalleTicket DT on"
        sql &= " P.idProducto = DT.idProducto"
        sql &= " GROUP BY P.nombre"

        If txt_li_productos_vendidos.Text = "" And txt_ls_productos_vendidos.Text = "" Then
        Else
            'Having con limite inferior
            If txt_li_productos_vendidos.Text <> "" Then
                sql &= " HAVING SUM(DT.cantidad) > " & txt_li_productos_vendidos.Text.Trim
            End If

            'Having con limite superior
            If txt_ls_productos_vendidos.Text <> "" Then
                If sql.IndexOf("HAVING") = -1 Then
                    sql &= " HAVING SUM(DT.cantidad) < " & txt_ls_productos_vendidos.Text.Trim
                End If
                sql &= " AND SUM(DT.cantidad) < " & txt_ls_productos_vendidos.Text.Trim
            End If
        End If
        'Ejecutar la consulta y recuperar la tabla
        tabla = Conex.Consultar(sql)
        GraficoBarrasProductosVendidosBindingSource.DataSource = tabla
        rv_productos_vendidos.RefreshReport()
    End Sub

    Private Sub btn_graficar_porcentaje_ganancias_Click(sender As Object, e As EventArgs) Handles btn_graficar_porcentaje_ganancias.Click

        If rv_productos_vendidos.Visible = False Then
            lbl_presione_porcentaje_ganancia.Visible = False
            rv_porcentaje_ingresos.Visible = True
        End If
        GraficarTortaPorcentajeVendidos()
    End Sub

    Private Sub GraficarTortaPorcentajeVendidos()
        Dim sql, tabla

        sql = "SELECT P.nombre, SUM(DT.cantidad) as cantidad, sum(DT.precio) as total"
        sql &= " FROM Producto P join DetalleTicket DT on"
        sql &= " P.idProducto = DT.idProducto"
        sql &= " GROUP BY P.nombre"

        If txt_li_porcentaje_ventas.Text = "" And txt_ls_porcentaje_ventas.Text = "" Then
        Else

            If txt_li_porcentaje_ventas.Text <> "" Then
                sql &= " HAVING SUM(DT.cantidad) > " & txt_li_porcentaje_ventas.Text.Trim
            End If

            If txt_ls_porcentaje_ventas.Text <> "" Then
                If sql.IndexOf("HAVING") = -1 Then
                    sql &= " HAVING SUM(DT.cantidad) < " & txt_ls_porcentaje_ventas.Text.Trim
                End If
                sql &= " AND SUM(DT.cantidad) < " & txt_ls_porcentaje_ventas.Text.Trim
            End If
        End If

        tabla = Conex.consultar(sql)

        Dim calculoAcumulado As Double = 0
        'Ejecuta una consulta en la datatable, primero recibe el comando y luego un filtro
        calculoAcumulado = tabla.Compute("sum(total)", "")
        'Le vamos a agregar una columna para que sea compatible con el DataSet
        tabla.Columns.Add("porcentaje", Type.GetType("System.Double"))

        For i = 0 To tabla.Rows.Count - 1
            'de cada articulo, el porcentaje del total
            tabla.Rows(i)("porcentaje") = tabla.Rows(i)("total") / calculoAcumulado * 100
        Next

        GraficoTortaPorcentajeVendidosBindingSource.DataSource = tabla
        rv_porcentaje_ingresos.RefreshReport()
    End Sub

    Private Sub btn_graficar_ventas_horario_Click(sender As Object, e As EventArgs) Handles btn_graficar_ventas_horario.Click
        If rv_ventas_por_horario.Visible = False Then
            rv_ventas_por_horario.Visible = True
            lbl_presione_ventas_horario.Visible = False
        End If
        GraficarBarrasVentasHorarios()
    End Sub

    Private Sub GraficarBarrasVentasHorarios()
        Dim sql, tabla

        sql = "select SUM(DT.cantidad) as cantidad, DATEPART(HOUR, T.hora) as horario"
        sql &= " from DetalleTicket DT join Ticket T on DT.numeroTicket = T.id"
        If txt_li_ventas_horario.Text = "" And txt_ls_ventas_horario.Text = "" Then
        Else

            If txt_li_ventas_horario.Text <> "" Then
                sql &= " where DATEPART(HOUR, T.hora) > " & txt_li_ventas_horario.Text.Trim 
            End If

            If txt_ls_ventas_horario.Text <> "" Then
                If sql.IndexOf("where") = -1 Then
                    sql &= " where DATEPART(HOUR, T.hora) < " & txt_ls_ventas_horario.Text.Trim
                End If
                sql &= " AND DATEPART(HOUR, T.hora) < " & txt_ls_ventas_horario.Text.Trim
            End If
        End If
        sql &= " group by DATEPART(HOUR, T.hora)"
        sql &= " order by horario"
        
        tabla = Conex.consultar(sql)
        GraficoBarrasVentaPorHorarioBindingSource.DataSource = tabla
        rv_ventas_por_horario.RefreshReport()
    End Sub

End Class