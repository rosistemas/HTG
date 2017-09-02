Public Class Principal

    Private Sub EmpleadoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EmpleadoToolStripMenuItem.Click
        RegistrarEmpleado.Show()
        Me.Hide()
    End Sub

    Private Sub ProductoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProductoToolStripMenuItem.Click
        RegistrarProducto.Show()
        Me.Hide()
    End Sub

    Private Sub ProveedorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProveedorToolStripMenuItem.Click
        RegistrarProveedor.Show()
        Me.Hide()
    End Sub
End Class
