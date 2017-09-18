Public Class ModificarProveedor
    Private conex As New Conexiones
    Private id_proveedor_seleccionado As Integer = 0
    Private Sub ModificarProveedor_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Private Sub btn_guardar_Click(sender As Object, e As EventArgs) Handles btn_guardar.Click

    End Sub

    Private Sub btn_cancelar_Click(sender As Object, e As EventArgs) Handles btn_cancelar.Click

    End Sub

    Private Sub grd_proveedores_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles grd_proveedores.CellDoubleClick

    End Sub

    Private Sub cargarGrilla()
        Dim sql As String
        sql = "SELECT Empleado.id, Empleado.numDoc, Empleado.tipoDoc, Empleado.nombre, Empleado.apellido, Empleado.fechaNacimiento, Empleado.fechaIngreso, Empleado.fechaEgreso, Empleado.idBarrio, Empleado.calle, Empleado.numCalle, TipoDoc.descripcion, Barrio.nombre as nombre_barrio FROM Empleado INNER JOIN TipoDoc ON Empleado.tipoDoc = TipoDoc.id INNER JOIN Barrio ON Empleado.idBarrio = Barrio.id"

        Dim tabla As New DataTable
        tabla = conex.consultar(sql)
        Me.grd_proveedores.Rows.Clear()
        For i = 0 To tabla.Rows.Count - 1
            Me.grd_proveedores.Rows.Add()
            Me.grd_proveedores.Rows(i).Cells("id").Value = tabla.Rows(i)("id")
            Me.grd_proveedores.Rows(i).Cells("nombre").Value = tabla.Rows(i)("nombre")
            Me.grd_proveedores.Rows(i).Cells("apellido").Value = tabla.Rows(i)("apellido")
            Me.grd_proveedores.Rows(i).Cells("tipo_documento").Value = tabla.Rows(i)("descripcion")
            Me.grd_proveedores.Rows(i).Cells("numero_documento").Value = tabla.Rows(i)("numDoc")
            Me.grd_proveedores.Rows(i).Cells("fecha_nacimiento").Value = tabla.Rows(i)("fechaNacimiento")
            Me.grd_proveedores.Rows(i).Cells("fecha_ingreso").Value = tabla.Rows(i)("fechaIngreso")
            Me.grd_proveedores.Rows(i).Cells("fecha_egreso").Value = tabla.Rows(i)("fechaEgreso")
            Me.grd_proveedores.Rows(i).Cells("id_barrio").Value = tabla.Rows(i)("idBarrio")
            Me.grd_proveedores.Rows(i).Cells("barrio").Value = tabla.Rows(i)("nombre_barrio")
            Me.grd_proveedores.Rows(i).Cells("calle").Value = tabla.Rows(i)("calle")
            Me.grd_proveedores.Rows(i).Cells("numero_calle").Value = tabla.Rows(i)("numCalle")
            Me.grd_proveedores.Rows(i).Cells("id_documento").Value = tabla.Rows(i)("tipoDoc")
        Next
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
End Class