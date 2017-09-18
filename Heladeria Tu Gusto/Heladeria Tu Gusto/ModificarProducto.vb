Public Class ModificarProducto
    Private conex As New Conexiones
    Private id_producto_seleccionado As Integer = 0
    Private id_tipo_producto_seleccionado As Integer = 0

    Private Sub ModificarProducto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.cargarGrilla()
    End Sub

    Private Sub cargarGrilla()
        Dim sql As String = ""
        sql = "SELECT        Producto.idProducto, Producto.nombre, Producto.idTipo, Producto.precio, Producto.stock, Producto.descripcion, TipoProducto.descripcion as descripcionTipo "
        sql &= "FROM            Producto INNER JOIN TipoProducto ON"
        sql &= "            Producto.idTipo = TipoProducto.idTipo"

        Dim c As Integer = 0
        'Limpiar valores previos si es que había
        Dim tabla As New DataTable
        tabla = conex.consultar(sql)
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

    Private Sub grd_productos_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles grd_productos.CellDoubleClick
        Dim tabla As New DataTable
        Dim sql As String
        sql = "SELECT        Producto.idProducto, Producto.nombre, Producto.idTipo, Producto.precio, Producto.stock, Producto.descripcion, TipoProducto.descripcion as descripcionTipo "
        sql &= "FROM            Producto INNER JOIN TipoProducto ON"
        sql &= "            Producto.idTipo = TipoProducto.idTipo"
        sql &= " WHERE "
        sql &= "Producto.idProducto = " & Me.grd_productos.CurrentRow.Cells(5).Value
        sql &= " AND "
        sql &= "Producto.idTipo = " & Me.grd_productos.CurrentRow.Cells(6).Value

        tabla = conex.consultar(Sql)


        'Cargar los elementos del formulario con los nuevos datos traídos de la BD
        'Recordar que TABLA es una variable que contiene los datos traídos de la base de datos
        'Siempre usamos la posición 0 porque trae UN SOLO REGISTRO de la BD, ya que la PK es única
        Me.txt_nombre.Text = tabla.Rows(0)("nombre")
        Me.txt_precio.Text = tabla.Rows(0)("precio")
        Me.txt_descripcion.Text = tabla.Rows(0)("descripcion")
        Me.cargaCombo(cmb_tipo, conex.leerTabla("TipoProducto"), "descripcion", "idTipo")
        Me.cmb_tipo.SelectedValue = tabla.Rows(0)("idTipo")
        Me.id_producto_seleccionado = tabla.Rows(0)("idProducto")
        Me.id_tipo_producto_seleccionado = tabla.Rows(0)("idTipo")
        'Bloquear los elementos correspondientes a la PK

    End Sub

    Private Sub cargaCombo(ByRef combo As ComboBox, ByRef tabla As DataTable, descriptor As String, pk As String)
        combo.DataSource = Nothing
        'Limpiar el comboBox
        combo.Items.Clear()
        'Le asigno una nueva fuente
        combo.DataSource = tabla
        'Asociar un texto para mostrar
        combo.DisplayMember = descriptor
        'Asignarle un valor a ese texto mostrado
        combo.ValueMember = pk
    End Sub

    Private Sub btn_guardar_Click(sender As Object, e As EventArgs) Handles btn_guardar.Click
        If MessageBox.Show("¿Está seguro de querer modificar los datos del producto seleccionado?", "Precaución", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = Windows.Forms.DialogResult.Yes Then
            Me.modificar()
            Me.cargarGrilla()
        Else
            MessageBox.Show("Los datos no se han alterado.", "Cancelado", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub modificar()
        'Sentencia = insert into Producto values (idProducto, 'nombre', idTipo, precio, stock, 'descripción')
        'Actualizar nombre, precio, idTipo, descripcion
        Dim sql As String = ""
        sql &= "update Producto"
        sql &= " set nombre = '" & Me.txt_nombre.Text.Trim & "'"
        sql &= ", precio = " & Integer.Parse(txt_precio.Text.Trim)
        sql &= ", descripcion = '" & Me.txt_descripcion.Text.Trim & "'"
        sql &= ", idTipo = " & Me.cmb_tipo.SelectedValue
        'Restricción where, prestar atención a los espacios
        sql &= " where idProducto = " & id_producto_seleccionado
        conex.insertar(sql)
    End Sub

    Private Sub btn_cancelar_Click(sender As Object, e As EventArgs) Handles btn_cancelar.Click
        If MessageBox.Show("Perderá los datos ingresados", "¿Desea cancelar la modificación?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = Windows.Forms.DialogResult.Yes Then
            Me.Close()
            Principal.Show()
        End If
    End Sub
End Class