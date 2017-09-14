Public Class Principal
    Private Sub registrar_empleado_Click(sender As Object, e As EventArgs) Handles registrar_empleado.Click
        RegistrarEmpleado.Show()
    End Sub

    Private Sub registrar_producto_Click(sender As Object, e As EventArgs) Handles registrar_producto.Click
        RegistrarProducto.Show()
    End Sub

    Private Sub registrar_proveedor_Click(sender As Object, e As EventArgs) Handles registrar_proveedor.Click
        RegistrarProveedor.Show()
    End Sub

    Private Sub modificar_empleado_Click(sender As Object, e As EventArgs) Handles modificar_empleado.Click
        ModificarEmpleado.Show()
    End Sub

    Private Sub modificar_proveedor_Click(sender As Object, e As EventArgs) Handles modificar_proveedor.Click
        ModificarProveedor.Show()
    End Sub

    Private Sub modificar_producto_Click(sender As Object, e As EventArgs) Handles modificar_producto.Click
        ModificarProducto.Show()
    End Sub
End Class
