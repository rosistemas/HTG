Public Class ModificarEmpleado
    Private conex As New Conexiones
    Private Sub ModificarEmpleado_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.cargarGrilla()

    End Sub
    Private Sub btn_guardar_Click(sender As Object, e As EventArgs) Handles btn_guardar.Click

    End Sub

    Private Sub cargarGrilla()
        Dim sql As String = ""
        sql = "SELECT "
        sql &= " Empleado.id, Empleado.numDoc, Empleado.tipoDoc, Empleado.nombre, Empleado.apellido, "
        sql &= " Empleado.fechaNacimiento, Empleado.fechaIngreso, Empleado.fechaEgreso,"
        sql &= " Empleado.idBarrio, Empleado.calle, Empleado.numCalle,"
        sql &= " TipoDoc.descripcion, Barrio.nombre as nombre_barrio"
        sql &= "FROM "
        sql &= " Empleado INNER JOIN TipoDoc ON"
        sql &= " Empleado.tipoDoc = TipoDoc.id"
        sql &= " INNER JOIN Barrio ON"
        sql &= " Empleado.idBarrio = Barrio.id"

        Dim consulta As String
        consulta = "SELECT Empleado.id, Empleado.numDoc, Empleado.tipoDoc, Empleado.nombre, Empleado.apellido, Empleado.fechaNacimiento, Empleado.fechaIngreso, Empleado.fechaEgreso, Empleado.idBarrio, Empleado.calle, Empleado.numCalle, TipoDoc.descripcion, Barrio.nombre as nombre_barrio FROM Empleado INNER JOIN TipoDoc ON Empleado.tipoDoc = TipoDoc.id INNER JOIN Barrio ON Empleado.idBarrio = Barrio.id"
        Dim tabla As New DataTable
        tabla = conex.consultar(consulta)
        Me.grd_empleados.Rows.Clear()
        For i = 0 To tabla.Rows.Count - 1
            Me.grd_empleados.Rows.Add()
            Me.grd_empleados.Rows(i).Cells("id").Value = tabla.Rows(i)("id")
            Me.grd_empleados.Rows(i).Cells("nombre").Value = tabla.Rows(i)("nombre")
            Me.grd_empleados.Rows(i).Cells("apellido").Value = tabla.Rows(i)("apellido")
            Me.grd_empleados.Rows(i).Cells("tipo_documento").Value = tabla.Rows(i)("descripcion")
            Me.grd_empleados.Rows(i).Cells("numero_documento").Value = tabla.Rows(i)("numDoc")
            Me.grd_empleados.Rows(i).Cells("fecha_nacimiento").Value = tabla.Rows(i)("fechaNacimiento")
            Me.grd_empleados.Rows(i).Cells("fecha_ingreso").Value = tabla.Rows(i)("fechaIngreso")
            Me.grd_empleados.Rows(i).Cells("fecha_egreso").Value = tabla.Rows(i)("fechaEgreso")
            Me.grd_empleados.Rows(i).Cells("id_barrio").Value = tabla.Rows(i)("idBarrio")
            Me.grd_empleados.Rows(i).Cells("barrio").Value = tabla.Rows(i)("nombre_barrio")
            Me.grd_empleados.Rows(i).Cells("calle").Value = tabla.Rows(i)("calle")
            Me.grd_empleados.Rows(i).Cells("numero_calle").Value = tabla.Rows(i)("numCalle")
            Me.grd_empleados.Rows(i).Cells("id_documento").Value = tabla.Rows(i)("tipoDoc")
        Next
    End Sub
End Class