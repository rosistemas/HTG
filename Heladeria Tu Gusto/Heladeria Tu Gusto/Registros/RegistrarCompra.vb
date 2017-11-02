Public Class RegistrarCompra
    Private Property Conex As Conexiones = New Conexiones
    Private Property Asistente As AsistenteFormulario = new AsistenteFormulario

    Private Sub RegistrarCompra_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Asistente.CargarCombo(cmb_empleado, Conex.LeerTabla("Empleado"), "id", "id")
        Asistente.CargarCombo(cmb_producto, Conex.LeerTabla("Producto"), "idProducto", "nombre")
        MostrarInfoEmpleado()
        lbl_id_compra_display.Text = Conex.Generar_id_consecutivo("Compra", "id")
    End Sub

    Private Sub MostrarInfoEmpleado()
        Dim selected As String = cmb_empleado.SelectedValue
        Dim table As New DataTable
        Dim sql As String = "select * from empleado where id = " & selected
        table = Conex.Consultar(sql)
        lbl_info_empleado.Text = table.Rows(0)("nombre") & " " & table.Rows(0)("apellido")
    End Sub

    Private Sub MostrarInfoProveedor()
        Dim productoSeleccionado As String = cmb_producto.SelectedValue
        Dim tabla As New DataTable
        Dim sql As String = "select * from proveedor where idProducto = " & productoSeleccionado
        tabla = Conex.Consultar(sql)
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
        tabla = Conex.Consultar(sql)
        For i = 0 To tabla.Rows.Count - 1
            grd_telefonos.Rows.Add()
            grd_telefonos.Rows(i).Cells("col_tipo").Value = tabla.Rows(i)("nombreTelefono")
            grd_telefonos.Rows(i).Cells("col_numero").Value = tabla.Rows(i)("numero")

        Next
    End Sub

    Private Sub cmb_empleado_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cmb_empleado.SelectionChangeCommitted
        MostrarInfoEmpleado()
    End Sub

    Private Sub cmb_producto_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cmb_producto.SelectionChangeCommitted
        MostrarInfoProveedor()
    End Sub

    Private Sub CalcularTotal()
        If Len(msk_precio.Text.Trim) <> 6 Or Len(msk_cantidad.Text.Trim) <> 3 Then
            lbl_total_display.Text = "0"
            Exit Sub
        End If
        lbl_total_display.Text = Double.Parse(msk_cantidad.Text)*Double.Parse(msk_precio.Text)
    End Sub

    Private Sub txt_cantidad_TextChanged(sender As Object, e As EventArgs) Handles msk_cantidad.TextChanged
        CalcularTotal()
    End Sub

    Private Sub msk_precio_TextChanged(sender As Object, e As EventArgs) Handles msk_precio.TextChanged
        CalcularTotal()
    End Sub

    Private Sub RegistrarCompra_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If MessageBox.Show("¿Está seguro que desea cancelar?", "Confirmar cancelación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) = DialogResult.No Then
            e.Cancel = True
        End If
    End Sub

    Private Sub btn_cancelar_Click(sender As Object, e As EventArgs) Handles btn_cancelar.Click
        Close()
    End Sub

    Private Sub btn_guardar_Click(sender As Object, e As EventArgs) Handles btn_guardar.Click

        If ValidarInfo() = False And Asistente.VerificarVacios(Controls) = Validador.EstadoValidacion.ConErrores Then
            MsgBox("No se han cargado datos", MsgBoxStyle.Critical, "No se puede guardar")
            Exit Sub
        End If
        If MessageBox.Show("¿Está seguro que desea registrar?", "Confirmar registro", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = DialogResult.No Then
            Exit Sub
        End If
        Dim sql = ""
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
        Conex.Insertar(sql)
        ActualizarStock()
        lbl_id_compra_display.Text = Conex.Generar_id_consecutivo("Compra", "id")
        msk_cantidad.Clear()
        msk_precio.Clear()
        MsgBox("Los datos de han guardado con éxito.", MsgBoxStyle.Information, "Datos registrados")
    End Sub

    Private Sub ActualizarStock()
        Dim sql = ""
        Dim table As New DataTable
        sql = "select stock from producto where idProducto = " & cmb_producto.SelectedValue
        table = Conex.Consultar(sql)

        Dim stockActual As Integer = table.Rows(0)("stock")
        Dim stockResultante As Integer = stockActual + Integer.Parse(msk_cantidad.Text.Trim)
        sql = "update Producto set stock = " & stockResultante & " where idProducto = " & cmb_producto.SelectedValue
        Conex.Insertar(sql)
    End Sub

    Private Function ValidarInfo() As Boolean
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