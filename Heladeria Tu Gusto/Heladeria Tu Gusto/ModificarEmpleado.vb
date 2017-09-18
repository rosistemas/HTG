Public Class ModificarEmpleado
    Private conex As New Conexiones
    Private id_empleado_seleccionado As Integer = 0
    Private id_barrio_seleccionado As Integer = 0
    Private id_documento_seleccionado As Integer = 0
    Private Sub ModificarEmpleado_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.cargarGrilla()
    End Sub

    Private Sub btn_guardar_Click(sender As Object, e As EventArgs) Handles btn_guardar.Click
        If MessageBox.Show("¿Está seguro de querer modificar los datos del producto seleccionado?", "Precaución", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = Windows.Forms.DialogResult.Yes Then
            Me.modificar()
            Me.cargarGrilla()
        Else
            MessageBox.Show("Los datos no se han alterado.", "Cancelado", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub cargarGrilla()
        Dim sql As String
        sql = "SELECT Empleado.id, Empleado.numDoc, Empleado.tipoDoc, Empleado.nombre, Empleado.apellido, Empleado.fechaNacimiento, Empleado.fechaIngreso, Empleado.fechaEgreso, Empleado.idBarrio, Empleado.calle, Empleado.numCalle, TipoDoc.descripcion, Barrio.nombre as nombre_barrio FROM Empleado INNER JOIN TipoDoc ON Empleado.tipoDoc = TipoDoc.id INNER JOIN Barrio ON Empleado.idBarrio = Barrio.id"
        Dim tabla As New DataTable
        tabla = conex.consultar(sql)
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

    Private Sub grd_empleados_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles grd_empleados.CellDoubleClick
        Dim tabla As New DataTable

        Dim sql As String
        sql = "SELECT Empleado.id, Empleado.numDoc, Empleado.tipoDoc, Empleado.nombre, Empleado.apellido, Empleado.fechaNacimiento, Empleado.fechaIngreso, Empleado.fechaEgreso, Empleado.idBarrio, Empleado.calle, Empleado.numCalle, TipoDoc.descripcion, Barrio.nombre as nombre_barrio FROM Empleado INNER JOIN TipoDoc ON Empleado.tipoDoc = TipoDoc.id INNER JOIN Barrio ON Empleado.idBarrio = Barrio.id"
        sql &= " WHERE "
        sql &= " Empleado.id = " & grd_empleados.CurrentRow.Cells(0).Value
        sql &= " AND "
        sql &= " TipoDoc.id = " & grd_empleados.CurrentRow.Cells(1).Value
        sql &= " AND "
        sql &= " Barrio.id = " & grd_empleados.CurrentRow.Cells(9).Value

        tabla = conex.consultar(sql)
        Me.txt_nombre.Text = tabla.Rows(0)("nombre")
        Me.txt_apellido.Text = tabla.Rows(0)("apellido")
        Me.txt_numero_documento.Text = tabla.Rows(0)("numDoc")
        Me.txt_calle.Text = tabla.Rows(0)("calle")
        Me.txt_numero_calle.Text = tabla.Rows(0)("numCalle")
        'cargar los combos
        Me.cargaCombo(cmb_barrio, conex.leerTabla("Barrio"), "nombre", "id")
        Me.cargaCombo(cmb_tipo_documento, conex.leerTabla("TipoDoc"), "descripcion", "id")
        Me.cmb_barrio.SelectedValue = tabla.Rows(0)("idBarrio")
        Me.cmb_tipo_documento.SelectedValue = tabla.Rows(0)("tipoDoc")

        id_empleado_seleccionado = tabla.Rows(0)("id")
        id_barrio_seleccionado = tabla.Rows(0)("idBarrio")
        id_documento_seleccionado = tabla.Rows(0)("tipoDoc")
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

    Private Sub modificar()
        Dim sql As String = ""
        sql &= "update Empleado"
        sql &= " set nombre = '" & Me.txt_nombre.Text.Trim & "'"
        sql &= ", numDoc = " & Integer.Parse(txt_numero_documento.Text.Trim)
        sql &= ", tipoDoc = " & Me.cmb_tipo_documento.SelectedValue
        sql &= ", apellido = '" & Me.txt_apellido.Text.Trim & "'"
        sql &= ", fechaNacimiento = '" & date_fecha_nacimiento.Value.Date & "'"
        sql &= ", fechaIngreso = '" & date_fecha_ingreso.Value.Date & "'"
        sql &= ", idBarrio = " & Me.cmb_barrio.SelectedValue
        sql &= ", calle = '" & Me.txt_calle.Text.Trim & "'"
        sql &= ", numCalle = " & Integer.Parse(txt_numero_calle.Text.Trim)
        sql &= " where id = " & id_empleado_seleccionado
        conex.insertar(sql)
    End Sub

    Private Sub btn_cancelar_Click(sender As Object, e As EventArgs) Handles btn_cancelar.Click
        If MessageBox.Show("Perderá los datos ingresados", "¿Desea cancelar la modificación?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = Windows.Forms.DialogResult.Yes Then
            Me.Close()
            Principal.Show()
        End If
    End Sub
End Class