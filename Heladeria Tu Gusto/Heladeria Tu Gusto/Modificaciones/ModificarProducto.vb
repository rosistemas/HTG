Public Class ModificarProducto
    Private Property  Conex as Conexiones = New Conexiones
    Private Property Validador As Validador = New Validador
    Private Property Asistente as AsistenteFormulario = New AsistenteFormulario
    Private id_producto_seleccionado As Integer = 0
    Private id_tipo_producto_seleccionado As Integer = 0

    Private Sub ModificarProducto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargarGrilla()
    End Sub

    Private Sub CargarGrilla()
        Dim sql
        sql =
            "SELECT        Producto.idProducto, Producto.nombre, Producto.idTipo, Producto.precio, Producto.stock, Producto.descripcion, TipoProducto.descripcion as descripcionTipo "
        sql &= "FROM            Producto INNER JOIN TipoProducto ON"
        sql &= "            Producto.idTipo = TipoProducto.idTipo"

        'Limpiar valores previos si es que había
        Dim tabla As New DataTable
        tabla = Conex.consultar(sql)
        Me.grd_productos.Rows.Clear()
        'Desde la fila 0 hasta cantidad de filas -1
        For c = 0 To tabla.Rows.Count - 1
            Me.grd_productos.Rows.Add()
            'Del lado izquierdo van los nombres de las columnas de la grilla gráfica,
            'Mientras que del lado derecho van los nombres que se corresponden a las columnas de la Tabla 
            'Traída de la base de datos
            Me.grd_productos.Rows(c).Cells("nombre").Value = tabla.Rows(c)("nombre")
            Me.grd_productos.Rows(c).Cells("stock").Value = tabla.Rows(c)("stock")
            Me.grd_productos.Rows(c).Cells("precio").Value = tabla.Rows(c)("precio")
            Me.grd_productos.Rows(c).Cells("tipo").Value = tabla.Rows(c)("descripcionTipo")
            Me.grd_productos.Rows(c).Cells("descripcion").Value = tabla.Rows(c)("descripcion")
            Me.grd_productos.Rows(c).Cells("id_producto").Value = tabla.Rows(c)("idProducto")
            Me.grd_productos.Rows(c).Cells("id_tipo_producto").Value = tabla.Rows(c)("idTipo")
        Next
    End Sub

    Private Sub grd_productos_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) _
        Handles grd_productos.CellDoubleClick
        Dim tabla As New DataTable
        Dim sql As String
        sql =
            "SELECT        Producto.idProducto, Producto.nombre, Producto.idTipo, Producto.precio, Producto.stock, Producto.descripcion, TipoProducto.descripcion as descripcionTipo "
        sql &= "FROM            Producto INNER JOIN TipoProducto ON"
        sql &= "            Producto.idTipo = TipoProducto.idTipo"
        sql &= " WHERE "
        sql &= "Producto.idProducto = " & Me.grd_productos.CurrentRow.Cells(5).Value
        sql &= " AND "
        sql &= "Producto.idTipo = " & Me.grd_productos.CurrentRow.Cells(6).Value

        tabla = Conex.consultar(Sql)


        'Cargar los elementos del formulario con los nuevos datos traídos de la BD
        'Recordar que TABLA es una variable que contiene los datos traídos de la base de datos
        'Siempre usamos la posición 0 porque trae UN SOLO REGISTRO de la BD, ya que la PK es única
        Me.txt_nombre.Text = tabla.Rows(0)("nombre")
        Me.txt_precio.Text = tabla.Rows(0)("precio")
        Me.txt_descripcion.Text = tabla.Rows(0)("descripcion")
        Asistente.CargarCombo(cmb_tipo, Conex.leerTabla("TipoProducto"), "descripcion", "idTipo")
        Me.cmb_tipo.SelectedValue = tabla.Rows(0)("idTipo")
        Me.id_producto_seleccionado = tabla.Rows(0)("idProducto")
        Me.id_tipo_producto_seleccionado = tabla.Rows(0)("idTipo")
        'Bloquear los elementos correspondientes a la PK
    End Sub

    Private Sub btn_guardar_Click(sender As Object, e As EventArgs) Handles btn_guardar.Click
        If Asistente.VerificarVacios(Controls) = Validador.EstadoValidacion.SinErrores Then
            If _
                MessageBox.Show("¿Está seguro de querer modificar los datos del producto seleccionado?", "Precaución",
                                MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = DialogResult.Yes _
                Then
                modificar()
                cargarGrilla()
            Else
                MessageBox.Show("Los datos no se han alterado.", "Cancelado", MessageBoxButtons.OK,
                                MessageBoxIcon.Information)
            End If
        End If
    End Sub

    Private Sub Modificar()
        'Sentencia = insert into Producto values (idProducto, 'nombre', idTipo, precio, stock, 'descripción')
        'Actualizar nombre, precio, idTipo, descripcion
        Dim sql
        sql = "update Producto"
        sql &= " set nombre = '" & Double.Parse(txt_precio.Text.Trim)
        sql &= ", descripcion = '" & Me.txt_descripcion.Text.Trim & "'"
        sql &= ", idTipo = " & Me.cmb_tipo.SelectedValue
        'Restricción where, prestar atención a los espacios
        sql &= " where idProducto = " & id_producto_seleccionado
        Conex.insertar(sql)
    End Sub

    Private Sub btn_cancelar_Click(sender As Object, e As EventArgs) Handles btn_cancelar.Click
        If _
            MessageBox.Show("Perderá los datos ingresados", "¿Desea cancelar la modificación?", MessageBoxButtons.YesNo,
                            MessageBoxIcon.Warning) = DialogResult.Yes Then
            Close()
            Principal.Show()
        End If
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