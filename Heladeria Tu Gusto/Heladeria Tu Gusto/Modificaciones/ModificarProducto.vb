Public Class ModificarProducto
    Private Property  Conex as Conexiones = New Conexiones
    Private Property Asistente As AsistenteFormulario = New AsistenteFormulario
    Private id_producto_seleccionado As Integer = 0

    Private Sub ModificarProducto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargarGrilla()
    End Sub

    Private Sub CargarGrilla()
        Dim sql
        sql =
            "SELECT        Producto.idProducto, Producto.nombre, Producto.idTipo, Producto.precio, Producto.descripcion, TipoProducto.descripcion as descripcionTipo "
        sql &= "FROM            Producto INNER JOIN TipoProducto ON"
        sql &= "            Producto.idTipo = TipoProducto.idTipo"

        'Limpiar valores previos si es que había
        Dim tabla As New DataTable
        tabla = Conex.consultar(sql)
        grd_productos.Rows.Clear()
        'Desde la fila 0 hasta cantidad de filas -1
        For c = 0 To tabla.Rows.Count - 1
            grd_productos.Rows.Add()
            'Del lado izquierdo van los nombres de las columnas de la grilla gráfica,
            'Mientras que del lado derecho van los nombres que se corresponden a las columnas de la Tabla 
            'Traída de la base de datos
            grd_productos.Rows(c).Cells("nombre").Value = tabla.Rows(c)("nombre")
            grd_productos.Rows(c).Cells("precio").Value = tabla.Rows(c)("precio")
            grd_productos.Rows(c).Cells("tipo").Value = tabla.Rows(c)("descripcionTipo")
            grd_productos.Rows(c).Cells("descripcion").Value = tabla.Rows(c)("descripcion")
            grd_productos.Rows(c).Cells("id_producto").Value = tabla.Rows(c)("idProducto")
            grd_productos.Rows(c).Cells("id_tipo_producto").Value = tabla.Rows(c)("idTipo")
        Next
    End Sub

    Private Sub grd_productos_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) _
        Handles grd_productos.CellDoubleClick

        txt_nombre.Text = grd_productos.CurrentRow.Cells("nombre").Value
        txt_precio.Text = grd_productos.CurrentRow.Cells("precio").Value
        txt_descripcion.Text = grd_productos.CurrentRow.Cells("descripcion").Value
        Asistente.CargarCombo(cmb_tipo, Conex.LeerTabla("TipoProducto"), "descripcion", "idTipo")
        cmb_tipo.SelectedValue = grd_productos.CurrentRow.Cells("id_tipo_producto").Value
        id_producto_seleccionado = grd_productos.CurrentRow.Cells("id_producto").Value
    End Sub

    Private Sub btn_guardar_Click(sender As Object, e As EventArgs) Handles btn_guardar.Click
        If Asistente.VerificarVacios(Controls) = Validador.EstadoValidacion.SinErrores Then
            If _
                MessageBox.Show("¿Está seguro de querer modificar los datos del producto seleccionado?", "Precaución",
                                MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = DialogResult.Yes _
                Then
                Modificar()
                CargarGrilla()
            Else
                MessageBox.Show("Los datos no se han alterado.", "Cancelado", MessageBoxButtons.OK,
                                MessageBoxIcon.Information)
            End If
        End If
    End Sub

    Private Sub Modificar()
        Dim sql
        sql = "update Producto"
        sql &= " set nombre = '" & txt_nombre.Text.Trim & "'"
        sql &= ", descripcion = '" & txt_descripcion.Text.Trim & "'"
        sql &= ", precio = " & Double.Parse(txt_precio.Text)
        sql &= ", idTipo = " & cmb_tipo.SelectedValue
        sql &= " where idProducto = " & id_producto_seleccionado
        Conex.insertar(sql)
    End Sub

    Private Sub btn_cancelar_Click(sender As Object, e As EventArgs) Handles btn_cancelar.Click
        Close()
        Principal.Show()
    End Sub

    Private Sub txt_precio_MouseHover(sender As Object, e As EventArgs) Handles txt_precio.MouseHover
        toolTip_Precio.SetToolTip(txt_precio, "Recuerde que para precios con centavos, debe utilizar el punto (.)")
    End Sub

    Private Sub ModificarProducto_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If _
            MessageBox.Show("¿Está seguro que desea cancelar?", "Confirmar cancelación", MessageBoxButtons.YesNo,
                            MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) = DialogResult.No _
            Then
            e.Cancel = True
        End If
    End Sub
End Class