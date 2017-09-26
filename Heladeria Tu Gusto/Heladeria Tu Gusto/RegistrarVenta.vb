Public Class RegistrarVenta
    Dim cadena_conexion As String = "Provider=SQLNCLI11;Data Source=RODRIGOGOMEB0F2\SQLEXPRESS;Integrated Security=SSPI;Initial Catalog=HeladeriaTuGusto"
    Dim conex As New Conexiones
    Private Sub cmd_agregar_Click(sender As Object, e As EventArgs) Handles cmd_agregar.Click
        If Len(txt_codigo_producto.Text.Trim) = 0 Or Len(txt_cantidad.Text.Trim) = 0 Then
            MsgBox("Debe ingresar los datos de la venta.", MsgBoxStyle.Critical, "¡Error crítico!")
            Exit Sub
        End If

        Dim tabla As New DataTable
        tabla = conex.consultar("select * from Producto where idProducto = " & txt_codigo_producto.Text.Trim)

        If tabla.Rows.Count = 0 Then
            MsgBox("El código de producto ingresado es inexistente.", MsgBoxStyle.Critical, "¡Producto no encontrado!")
            Exit Sub
        End If

        For i = 0 To grd_detalle_de_venta.Rows.Count - 1
            If grd_detalle_de_venta.Rows(i).Cells("col_codigo").Value = txt_codigo_producto.Text.Trim Then
                grd_detalle_de_venta.Rows(i).Cells("col_cantidad").Value = Integer.Parse(grd_detalle_de_venta.Rows(i).Cells("col_cantidad").Value) + Integer.Parse(txt_cantidad.Text.Trim)
                grd_detalle_de_venta.Rows(i).Cells("col_subtotal").Value = Integer.Parse(grd_detalle_de_venta.Rows(i).Cells("col_subtotal").Value) + (Integer.Parse(txt_cantidad.Text.Trim) * Integer.Parse(tabla.Rows(0)("precio")))
                lbl_total_display.Text = Integer.Parse(lbl_total_display.Text.Trim) + (Integer.Parse(txt_cantidad.Text.Trim) * Integer.Parse(tabla.Rows(0)("precio")))
                Exit Sub
            End If
        Next

        grd_detalle_de_venta.Rows.Add()
        Dim ultima_pos As Integer = (grd_detalle_de_venta.Rows.Count - 1)
        grd_detalle_de_venta.Rows(ultima_pos).Cells("col_codigo").Value = tabla.Rows(0)("idProducto")
        grd_detalle_de_venta.Rows(ultima_pos).Cells("col_nombre").Value = tabla.Rows(0)("nombre")
        grd_detalle_de_venta.Rows(ultima_pos).Cells("col_cantidad").Value = txt_cantidad.Text.Trim
        grd_detalle_de_venta.Rows(ultima_pos).Cells("col_precio").Value = tabla.Rows(0)("precio")
        grd_detalle_de_venta.Rows(ultima_pos).Cells("col_subtotal").Value = (Integer.Parse(txt_cantidad.Text.Trim) * Integer.Parse(tabla.Rows(0)("precio")))
        lbl_total_display.Text = Integer.Parse(lbl_total_display.Text.Trim) + (Integer.Parse(txt_cantidad.Text.Trim) * Integer.Parse(tabla.Rows(0)("precio")))
       
    End Sub

    Private Function generar_id_venta()
        Dim tabla As New DataTable
        Dim id As Integer
        tabla = conex.consultar("select * from Ticket order by id")

        If tabla.Rows.Count = 0 Then
            id = 1

        Else
            Dim ultima_pos As Integer = (tabla.Rows.Count - 1)
            id = tabla.Rows(ultima_pos)("id") + 1
        End If

        Return id

    End Function

    Private Sub insertar_en_bd_ticket()
        Dim sql As String = ""
        sql = "insert into ticket values("
        sql &= lbl_id_venta_display.Text.Trim & ", "
        sql &= cmb_empleado.SelectedValue & ", '"
        sql &= Format(Date.Parse(DateString), "yyyy/MM/dd") & "', '"
        sql &= TimeString & "', "
        sql &= lbl_total_display.Text.Trim & ")"
        conex.insertar(sql)
    End Sub

    Private Sub insertar_en_bd_detalle_ticket(ByRef id_prod As Integer, ByRef cant As Integer, precio As Double)
        Dim sql As String = ""
        sql = "insert into DetalleTicket values("
        sql &= lbl_id_venta_display.Text.Trim & ", "
        sql &= id_prod & ", "
        sql &= cant & ", "
        sql &= precio & ")"
        conex.insertar(sql)
    End Sub


    Private Sub cargar_combo(ByRef combo As ComboBox, ByRef tabla As DataTable, ByRef pk As String, ByRef desc As String)
        combo.DataSource = Nothing
        combo.Items.Clear()
        combo.DataSource = tabla
        combo.ValueMember = pk
        combo.DisplayMember = desc

    End Sub

    Private Sub RegistrarVenta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargar_combo(cmb_empleado, conex.leerTabla("empleado"), "id", "id")
        lbl_id_venta_display.Text = generar_id_venta()
        mostrar_info_empleado()
    End Sub

    Private Sub cmd_cancelar_Click(sender As Object, e As EventArgs) Handles btn_cancelar.Click
        Me.Close()
    End Sub

    Private Sub RegistrarVenta_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If MessageBox.Show("¿Está seguro que desea cancelar?", "Confirmar cancelación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.No Then
            e.Cancel = True
        End If
    End Sub

    Private Sub cmd_guardar_Click(sender As Object, e As EventArgs) Handles btn_guardar.Click
        If MessageBox.Show("¿Está seguro que desea registrar?", "Confirmar registro", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = Windows.Forms.DialogResult.Yes Then
            insertar_en_bd_ticket()
            For i = 0 To grd_detalle_de_venta.Rows.Count - 1
                insertar_en_bd_detalle_ticket(grd_detalle_de_venta.Rows(i).Cells("col_codigo").Value, grd_detalle_de_venta.Rows(i).Cells("col_cantidad").Value, grd_detalle_de_venta.Rows(i).Cells("col_precio").Value)
            Next
            lbl_total_display.Text = 0
            grd_detalle_de_venta.Rows.Clear()
            lbl_id_venta_display.Text = generar_id_venta()
            txt_cantidad.Text = ""
            txt_codigo_producto.Text = ""
        End If
    End Sub

    Private Sub mostrar_info_empleado()
        Dim selected As String = cmb_empleado.SelectedValue
        Dim table As New DataTable
        Dim sql As String = "select * from empleado where id = " & selected
        table = conex.consultar(sql)
        lbl_info_empleado.Text = table.Rows(0)("nombre") & " " & table.Rows(0)("apellido")
    End Sub

    Private Sub cmb_empleado_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cmb_empleado.SelectionChangeCommitted
        mostrar_info_empleado()
    End Sub
End Class
