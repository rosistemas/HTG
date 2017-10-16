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

    Private Sub CompraToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CompraToolStripMenuItem.Click
        RegistrarCompra.Show()
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
        If (e.Control AndAlso e.KeyCode = Keys.NumPad4) Then
            RegistrarCompra.Show()
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

   Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        Close()
    End Sub

    Private Sub ProvinciaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProvinciaToolStripMenuItem.Click
        RegistrarProvincia.Show()
    End Sub

    Private Sub LocalidadToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LocalidadToolStripMenuItem.Click
        RegistrarLocalidad.Show()
    End Sub

    Private Sub BarrioToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BarrioToolStripMenuItem.Click
        RegistrarBarrio.Show()
    End Sub


    Private Sub AcercaDeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AcercaDeToolStripMenuItem.Click
        Dim mensaje As New StringBuilder
        mensaje.Append("DESARROLLADORES").AppendLine()
        mensaje.Append("Rodrigo Gomez").AppendLine()
        mensaje.Append("Daniel Caminos").AppendLine()
        mensaje.Append("Francisco Castillo").AppendLine()
        mensaje.Append("Tomas Bianco").AppendLine()
        mensaje.AppendLine()
        mensaje.AppendLine()
        mensaje.Append("Todos los derechos reservados...")
        MessageBox.Show(mensaje.ToString, "HELADERIA TU GUSTO", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub Principal_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Inicio.Close()
    End Sub

    Private Sub modificar_barrio_Click(sender As Object, e As EventArgs) Handles modificar_barrio.Click
        ModificarBarrio.Show()
    End Sub

    Private Sub modificar_localidad_Click(sender As Object, e As EventArgs) Handles modificar_localidad.Click
        ModificarLocalidad.Show()
    End Sub

    Private Sub modificar_provincia_Click(sender As Object, e As EventArgs) Handles modificar_provincia.Click
        ModificarProvincia.Show()
    End Sub

    Private Sub TipoProductoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TipoProductoToolStripMenuItem.Click
        RegistrarTipoProducto.Show()

    End Sub

    Private Sub TurnoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TurnoToolStripMenuItem.Click
        RegistrarTurno.Show()
    End Sub
End Class