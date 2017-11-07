Public Class Comprobante_Factura
    Public aux As New AsistenteFormulario
    Public conex As New Conexiones

    Private Sub Comprobante_Factura_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim sql As String = ""
        aux.CargarCombo(cmb_factura, conex.Consultar("select * from ticket"), "id", "id")
        sql &= "select "
        sql &= " t.id,(e.nombre+' '+e.apellido) as Empleado,t.fecha,t.total,p.nombre,dt.precio,dt.cantidad "
        sql &= " from ticket t inner join detalleticket dt on t.id=dt.numeroTicket  "
        sql &= " inner join producto p on dt.idProducto=p.idProducto "
        sql &= " inner join empleado e on t.legajoEmpleado=e.id "
        sql &= " where t.id=1 "



        TablaFacturaBindingSource.DataSource = conex.Consultar(sql)
        ReportViewer1.RefreshReport()
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim sql As String = ""
        Sql &= "select "
        sql &= " t.id,(e.nombre+' '+e.apellido) as Empleado,t.fecha,t.total,p.nombre,dt.precio,dt.cantidad "
        sql &= " from ticket t inner join detalleticket dt on t.id=dt.numeroTicket "
        sql &= " inner join producto p on dt.idProducto=p.idProducto "
        sql &= " inner join empleado e on t.legajoEmpleado=e.id "
        sql &= " where t.id=" & cmb_factura.SelectedValue



        TablaFacturaBindingSource.DataSource = conex.Consultar(Sql)
        ReportViewer1.RefreshReport()
    End Sub
End Class