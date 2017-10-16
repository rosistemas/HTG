Public Class Reporte
    Private Property Conex As Conexiones = New Conexiones

    Private Sub Reporte_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ConsultarVentas()
        rv_ventas.RefreshReport
    End Sub

    Private sub ConsultarVentas()
       bs_ventas.DataSource = Conex.Consultar("SELECT * FROM DetalleTicket")
       End sub
End Class