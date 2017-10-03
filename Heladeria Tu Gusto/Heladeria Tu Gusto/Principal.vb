Imports System.Text

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

    Private Sub registrar_venta_Click(sender As Object, e As EventArgs) Handles registrar_venta.Click
        RegistrarVenta.Show()
    End Sub

    Private Sub Principal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        KeyPreview = True
    End Sub

    Private Sub Principal_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If (e.Control AndAlso e.KeyCode = Keys.NumPad0) Then
            RegistrarVenta.Show()
        End If
        
        If (e.Control AndAlso e.KeyCode = Keys.NumPad1) Then
            RegistrarProducto.Show()
        End If
        If (e.Alt AndAlso  e.Alt AndAlso e.KeyCode = Keys.NumPad1) Then
            ModificarProducto.Show()
        End If

        If (e.Control AndAlso e.KeyCode = Keys.NumPad2) Then
            RegistrarEmpleado.Show()
        End If
        If (e.Alt AndAlso  e.Alt AndAlso e.KeyCode = Keys.NumPad2) Then
            ModificarEmpleado.Show()
        End If

        If (e.Control AndAlso e.KeyCode = Keys.NumPad3) Then
            RegistrarProveedor.Show()
        End If
        If (e.Alt AndAlso  e.Alt AndAlso e.KeyCode = Keys.NumPad3) Then
            ModificarProveedor.Show()
        End If

    End Sub

    Private Sub AccesosDirectosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AccesosDirectosToolStripMenuItem.Click
        Dim explicacion As New StringBuilder
        explicacion.Append("Ctrl + 0: Registrar una nueva venta" ).AppendLine()
        explicacion.Append("Ctrl + 1: Registrar un nuevo producto" ).AppendLine()
        explicacion.Append("Ctrl + 2: Registrar un nuevo empleado" ).AppendLine()
        explicacion.Append("Ctrl + 3: Registrar un nuevo proveedor" ).AppendLine()
        explicacion.Append("Alt + 1: Modificar un producto" ).AppendLine()
        explicacion.Append("Alt + 2: Modificar un empleado" ).AppendLine()
        explicacion.Append("Alt + 3: Modificar un proveedor" )

        MessageBox.Show(explicacion.ToString(),"Acerca de los accesos directos", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
End Class
