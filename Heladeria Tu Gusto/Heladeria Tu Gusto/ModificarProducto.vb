Public Class ModificarProducto
    Private conex As New Conexiones
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
        tabla = conex.consultar(Sql)
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
        Next
    End Sub
End Class