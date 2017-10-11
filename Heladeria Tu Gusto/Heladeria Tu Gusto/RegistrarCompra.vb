Public Class RegistrarCompra
    Dim conex As New Conexiones
    Private Sub cargar_combo(ByRef combo As ComboBox, ByRef tabla As DataTable, ByRef pk As String, ByRef desc As String)

        combo.DataSource = Nothing
        combo.Items.Clear()
        combo.DataSource = tabla
        combo.ValueMember = pk
        combo.DisplayMember = desc


    End Sub

    Private Sub mostrar_info_empleado()
        Dim selected As String = cmb_empleado.SelectedValue
        Dim table As New DataTable
        Dim sql As String = "select * from empleado where id = " & selected
        table = conex.consultar(sql)
        lbl_info_empleado.Text = table.Rows(0)("nombre") & " " & table.Rows(0)("apellido")
    End Sub

    Private Function generar_id_compra()
        Dim tabla As New DataTable
        Dim id As Integer
        tabla = conex.consultar("select * from Compra order by id")

        If tabla.Rows.Count = 0 Then
            id = 1

        Else
            Dim ultima_pos As Integer = (tabla.Rows.Count - 1)
            id = tabla.Rows(ultima_pos)("id") + 1
        End If

        Return id

    End Function

    Private Sub RegistrarCompra_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargar_combo(cmb_empleado, conex.leerTabla("Empleado"), "id", "id")
        cargar_combo(cmb_producto, conex.leerTabla("Producto"), "idProducto", "nombre")
        mostrar_info_empleado()
        lbl_id_compra_display.Text = generar_id_compra()



    End Sub

    Private Sub mostrar_info_proveedor()
        Dim producto_seleccionado As String = cmb_producto.SelectedValue
        Dim tabla As New DataTable
        Dim sql As String = "select * from proveedor where idProducto = " & producto_seleccionado
        tabla = conex.consultar(sql)
        If tabla.Rows.Count = 0 Then
            lbl_display_id_proveedor.Text = ""
            lbl_display_mail_proveedor.Text = ""
            lbl_display_razon_social_proveedor.Text = ""
            lbl_display_nombre_proveedor.Text = ""

            grd_telefonos.Rows.Clear()
            MsgBox("No se ha registrado un proveedor para el producto seleccionado.", MsgBoxStyle.Exclamation, "Proveedor no asociado")
            Exit Sub
        End If
        lbl_display_id_proveedor.Text = tabla.Rows(0)("idProveedor")
        lbl_display_mail_proveedor.Text = tabla.Rows(0)("mail")
        lbl_display_razon_social_proveedor.Text = tabla.Rows(0)("razonSocial")
        lbl_display_nombre_proveedor.Text = tabla.Rows(0)("nombre")

        grd_telefonos.Rows.Clear()
        sql = "select tp.*, tf.descripcion as nombreTelefono from TelefonoXProveedor tp inner join "
        sql &= "TipoTelefono tf on (tp.idTipoTelefono = tf.idTipo)"
        sql &= " where idProveedor = " & tabla.Rows(0)("idProveedor")
        tabla = conex.consultar(sql)
        For i = 0 To tabla.Rows.Count - 1
            grd_telefonos.Rows.Add()
            grd_telefonos.Rows(i).Cells("col_tipo").Value = tabla.Rows(i)("nombreTelefono")
            grd_telefonos.Rows(i).Cells("col_numero").Value = tabla.Rows(i)("numero")

        Next



    End Sub

    Private Sub cmb_empleado_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cmb_empleado.SelectionChangeCommitted
        mostrar_info_empleado()
    End Sub

    Private Sub cmb_producto_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cmb_producto.SelectionChangeCommitted
        mostrar_info_proveedor()
    End Sub

    Private Sub calcular_total()
        If Len(msk_precio.Text.Trim) <> 6 Or Len(msk_cantidad.Text.Trim) <> 3 Then
            lbl_total_display.Text = "0"
            Exit Sub
        End If

        lbl_total_display.Text = Double.Parse(msk_cantidad.Text) * Double.Parse(msk_precio.Text)


    End Sub

    Private Sub txt_cantidad_TextChanged(sender As Object, e As EventArgs) Handles msk_cantidad.TextChanged
        calcular_total()
     
    End Sub

    Private Sub msk_precio_TextChanged(sender As Object, e As EventArgs) Handles msk_precio.TextChanged
        calcular_total()
    End Sub

    Private Sub RegistrarCompra_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If MessageBox.Show("¿Está seguro que desea cancelar?", "Confirmar cancelación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.No Then
            e.Cancel = True
        End If
    End Sub

    Private Sub btn_cancelar_Click(sender As Object, e As EventArgs) Handles btn_cancelar.Click
        Me.Close()
    End Sub

    Private Sub btn_guardar_Click(sender As Object, e As EventArgs) Handles btn_guardar.Click

        If validar_info() = False Then
            MsgBox("No se han cargado datos", MsgBoxStyle.Critical, "No se puede guardar")
            Exit Sub
        End If
        If MessageBox.Show("¿Está seguro que desea registrar?", "Confirmar registro", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = Windows.Forms.DialogResult.No Then
            Exit Sub
        End If
        Dim sql As String = ""
        sql = "insert into Compra values("
        sql &= lbl_id_compra_display.Text.Trim & ", "
        sql &= lbl_display_id_proveedor.Text.Trim & ", "
        sql &= cmb_empleado.SelectedValue & ", '"
        sql &= Format(Date.Parse(DateString), "yyyy/MM/dd") & "', '"
        sql &= TimeString & "', "
        sql &= Replace(lbl_total_display.Text.Trim, ",", ".") & ", "
        sql &= Replace(msk_precio.Text.Trim, ",", ".") & ", "
        sql &= msk_cantidad.Text.Trim & ", "
        sql &= cmb_producto.SelectedValue & ")"
        conex.insertar(sql)
        actualizar_stock()
        lbl_id_compra_display.Text = generar_id_compra()
        msk_cantidad.Clear()
        msk_precio.Clear()
        MsgBox("Los datos de han guardado con éxito.", MsgBoxStyle.Information, "Datos registrados")
    End Sub

    Private Sub actualizar_stock()
        Dim sql As String = ""
        Dim table As New DataTable
        sql = "select stock from producto where idProducto = " & cmb_producto.SelectedValue
        table = conex.consultar(sql)

        Dim stock_actual As Integer = table.Rows(0)("stock")
        Dim stock_resultante As Integer = stock_actual + Integer.Parse(msk_cantidad.Text.Trim)
        sql = "update Producto set stock = " & stock_resultante & " where idProducto = " & cmb_producto.SelectedValue
        conex.insertar(sql)
    End Sub

    Private Function validar_info() As Boolean
        If lbl_display_id_proveedor.Text = "" Then
            Return False
        Else
            If lbl_total_display.Text = 0 Then
                Return False
            Else
                Return True
            End If
        End If
        
    End Function
End Class