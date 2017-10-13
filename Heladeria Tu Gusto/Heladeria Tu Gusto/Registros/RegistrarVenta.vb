Imports Heladeria_Tu_Gusto

Public Class RegistrarVenta

    Dim ReadOnly _conex As New Conexiones

    Public ReadOnly Property Conex As Conexiones
        Get
            Return _conex
        End Get
    End Property

    Private Sub cmd_agregar_Click(sender As Object, e As EventArgs) Handles cmd_agregar.Click
        If Len(txt_codigo_producto.Text.Trim) = 0 Or Len(txt_cantidad.Text.Trim) = 0 Then
            MsgBox("Debe ingresar los datos de la venta.", MsgBoxStyle.Critical, "¡Error crítico!")
            Exit Sub
        End If

        Dim tabla As New DataTable
        tabla = Conex.Consultar("select * from Producto where idProducto = " & txt_codigo_producto.Text.Trim)

        If tabla.Rows.Count = 0 Then
            MsgBox("El código de producto ingresado es inexistente.", MsgBoxStyle.Critical, "¡Producto no encontrado!")
            Exit Sub
        End If

        If validar_stock() = False Then
            Exit Sub
        End If

        For i = 0 To grd_detalle_de_venta.Rows.Count - 1
            If grd_detalle_de_venta.Rows(i).Cells("col_codigo").Value = txt_codigo_producto.Text.Trim Then
                grd_detalle_de_venta.Rows(i).Cells("col_cantidad").Value =
                    Integer.Parse(grd_detalle_de_venta.Rows(i).Cells("col_cantidad").Value) +
                    Integer.Parse(txt_cantidad.Text.Trim)
                grd_detalle_de_venta.Rows(i).Cells("col_subtotal").Value =
                    Integer.Parse(grd_detalle_de_venta.Rows(i).Cells("col_subtotal").Value) +
                    (Integer.Parse(txt_cantidad.Text.Trim) * Integer.Parse(tabla.Rows(0)("precio")))
                lbl_total_display.Text = Integer.Parse(lbl_total_display.Text.Trim) +
                                         (Integer.Parse(txt_cantidad.Text.Trim) * Integer.Parse(tabla.Rows(0)("precio")))
                Exit Sub
            End If
        Next

        grd_detalle_de_venta.Rows.Add()
        Dim ultimaPos As Integer = (grd_detalle_de_venta.Rows.Count - 1)
        grd_detalle_de_venta.Rows(ultimaPos).Cells("col_codigo").Value = tabla.Rows(0)("idProducto")
        grd_detalle_de_venta.Rows(ultimaPos).Cells("col_nombre").Value = tabla.Rows(0)("nombre")
        grd_detalle_de_venta.Rows(ultimaPos).Cells("col_cantidad").Value = txt_cantidad.Text.Trim
        grd_detalle_de_venta.Rows(ultimaPos).Cells("col_precio").Value = tabla.Rows(0)("precio")
        grd_detalle_de_venta.Rows(ultimaPos).Cells("col_subtotal").Value =
            (Integer.Parse(txt_cantidad.Text.Trim) * Integer.Parse(tabla.Rows(0)("precio")))
        lbl_total_display.Text = Integer.Parse(lbl_total_display.Text.Trim) +
                                 (Integer.Parse(txt_cantidad.Text.Trim) * Integer.Parse(tabla.Rows(0)("precio")))
    End Sub

    Private Function generar_id_venta()
        Dim tabla As New DataTable
        Dim id As Integer
        tabla = Conex.Consultar("select * from Ticket order by id")

        If tabla.Rows.Count = 0 Then
            id = 1

        Else
            Dim ultimaPos As Integer = (tabla.Rows.Count - 1)
            id = tabla.Rows(ultimaPos)("id") + 1
        End If

        Return id
    End Function

    Private Sub insertar_en_bd_ticket()
        Dim sql = ""
        sql = "insert into ticket values("
        sql &= lbl_id_venta_display.Text.Trim & ", "
        sql &= cmb_empleado.SelectedValue & ", '"
        sql &= Format(Date.Parse(DateString), "yyyy/MM/dd") & "', '"
        sql &= TimeString & "', "
        sql &= lbl_total_display.Text.Trim & ")"
        Conex.Insertar(sql)
    End Sub

    Private Sub insertar_en_bd_detalle_ticket(ByRef idProd As Integer, ByRef cant As Integer, precio As Double)
        Dim sql = ""
        sql = "insert into DetalleTicket values("
        sql &= lbl_id_venta_display.Text.Trim & ", "
        sql &= idProd & ", "
        sql &= cant & ", "
        sql &= precio & ")"
        Conex.Insertar(sql)
    End Sub

    Private Function validar_stock() As Boolean

        Dim stockActual As Integer
        Dim sql As String
        Dim tabla As New DataTable
        sql = "select stock from producto where idProducto = " & txt_codigo_producto.Text.Trim
        tabla = Conex.Consultar(sql)
        stockActual = tabla.Rows(0)("stock")
        For i = 0 To grd_detalle_de_venta.Rows.Count - 1
            If grd_detalle_de_venta.Rows(i).Cells("col_codigo").Value = txt_codigo_producto.Text.Trim Then
                stockActual = stockActual - Integer.Parse(grd_detalle_de_venta.Rows(i).Cells("col_cantidad").Value)
            End If
        Next
        If stockActual < Integer.Parse(txt_cantidad.Text.Trim) Then
            MsgBox("No se encuentra stock", MsgBoxStyle.Exclamation, "Stock insuficiente")
            Return False
        Else
            Return True
        End If
    End Function

    Private Sub descontar_stock()
        Dim stockActual As Integer
        Dim sql As String


        For i = 0 To grd_detalle_de_venta.Rows.Count - 1
            Dim tabla As New DataTable
            sql = "select stock from producto where idProducto = " &
                  grd_detalle_de_venta.Rows(i).Cells("col_codigo").Value
            tabla = Conex.Consultar(sql)
            stockActual = tabla.Rows(0)("stock")
            Dim stockResultante As Integer

            stockResultante = stockActual - Integer.Parse(grd_detalle_de_venta.Rows(i).Cells("col_cantidad").Value)
            sql = "update producto set stock = " & stockResultante & " where idProducto = " &
                  grd_detalle_de_venta.Rows(i).Cells("col_codigo").Value
            Conex.Insertar(sql)
        Next
    End Sub

    Private Sub cargar_combo(ByRef combo As ComboBox, ByRef tabla As DataTable, ByRef pk As String, ByRef desc As String)
        combo.DataSource = Nothing
        combo.Items.Clear()
        combo.DataSource = tabla
        combo.ValueMember = pk
        combo.DisplayMember = desc
    End Sub

    Private Sub RegistrarVenta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargar_combo(cmb_empleado, Conex.LeerTabla("empleado"), "id", "id")
        lbl_id_venta_display.Text = generar_id_venta()
        mostrar_info_empleado()
    End Sub

    Private Sub cmd_cancelar_Click(sender As Object, e As EventArgs) Handles btn_cancelar.Click
        Close()
    End Sub

    Private Sub RegistrarVenta_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If _
            MessageBox.Show("¿Está seguro que desea cancelar?", "Confirmar cancelación", MessageBoxButtons.YesNo,
                            MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) = DialogResult.No _
            Then
            e.Cancel = True
        End If
        Principal.Show()
    End Sub

    Private Sub cmd_guardar_Click(sender As Object, e As EventArgs) Handles btn_guardar.Click

        If validar_info() = False Then
            MsgBox("No se han cargado datos", MsgBoxStyle.Critical, "No se puede guardar")
            Exit Sub
        End If

        If _
            MessageBox.Show("¿Está seguro que desea registrar?", "Confirmar registro", MessageBoxButtons.YesNo,
                            MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = DialogResult.Yes _
            Then
            insertar_en_bd_ticket()
            For i = 0 To grd_detalle_de_venta.Rows.Count - 1
                insertar_en_bd_detalle_ticket(grd_detalle_de_venta.Rows(i).Cells("col_codigo").Value,
                                              grd_detalle_de_venta.Rows(i).Cells("col_cantidad").Value,
                                              grd_detalle_de_venta.Rows(i).Cells("col_precio").Value)
            Next
            descontar_stock()
            lbl_total_display.Text = 0
            grd_detalle_de_venta.Rows.Clear()
            lbl_id_venta_display.Text = generar_id_venta()
            txt_cantidad.Text = ""
            txt_codigo_producto.Text = ""
        End If
        MsgBox("Los datos de han guardado con éxito.", MsgBoxStyle.Information, "Datos registrados")
    End Sub

    Private Sub mostrar_info_empleado()
        Dim selected As String = cmb_empleado.SelectedValue
        Dim table As New DataTable
        Dim sql As String = "select * from empleado where id = " & selected
        table = Conex.Consultar(sql)
        lbl_info_empleado.Text = table.Rows(0)("nombre") & " " & table.Rows(0)("apellido")
    End Sub

    Private Function validar_info() As Boolean
        If grd_detalle_de_venta.Rows.Count = 0 Then
            Return False
        Else
            Return True
        End If
    End Function

    Private Sub cmb_empleado_SelectionChangeCommitted(sender As Object, e As EventArgs) _
        Handles cmb_empleado.SelectionChangeCommitted
        mostrar_info_empleado()
    End Sub
End Class
