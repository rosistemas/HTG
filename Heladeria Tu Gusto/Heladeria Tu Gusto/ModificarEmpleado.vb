Public Class ModificarEmpleado
    ReadOnly _conex As New Conexiones
    Private _idEmpleadoSeleccionado As Integer = 0
    ReadOnly _validador as New Validador

    Private Sub ModificarEmpleado_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.cargarGrilla()
    End Sub

    Private Sub btn_guardar_Click(sender As Object, e As EventArgs) Handles btn_guardar.Click
        If _validador.Verificar_vacios(Controls) = Validador.EstadoValidacion.SinErrores Then

            If _
                MessageBox.Show("¿Está seguro de querer modificar los datos del producto seleccionado?", "Precaución",
                                MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = Windows.Forms.DialogResult.Yes _
                Then
                Me.modificar()
                Me.cargarGrilla()
            Else
                MessageBox.Show("Los datos no se han alterado.", "Cancelado", MessageBoxButtons.OK,
                                MessageBoxIcon.Information)
            End If
        End If
    End Sub

    Private Sub btn_cancelar_Click(sender As Object, e As EventArgs) Handles btn_cancelar.Click
        If _
            MessageBox.Show("Perderá los datos ingresados", "¿Desea cancelar la modificación?", MessageBoxButtons.YesNo,
                            MessageBoxIcon.Warning) = Windows.Forms.DialogResult.Yes Then
            Me.Close()
            Principal.Show()
        End If
    End Sub

    Private Sub CargarGrilla()
        Dim sql As String
        sql =
            "SELECT E.*, T.descripcion, B.nombre as nombre_barrio FROM Empleado E INNER JOIN TipoDoc T ON E.tipoDoc = T.id INNER JOIN Barrio B ON E.idBarrio = B.id"
        Dim tabla As New DataTable
        tabla = _conex.consultar(sql)
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

    Private Sub grd_empleados_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) _
        Handles grd_empleados.CellDoubleClick
        Dim tabla As New DataTable

        Dim sql As String
        sql =
            "SELECT Empleado.id, Empleado.numDoc, Empleado.tipoDoc, Empleado.nombre, Empleado.apellido, Empleado.fechaNacimiento, Empleado.fechaIngreso, Empleado.fechaEgreso, Empleado.idBarrio, Empleado.calle, Empleado.numCalle, TipoDoc.descripcion, Barrio.nombre as nombre_barrio FROM Empleado INNER JOIN TipoDoc ON Empleado.tipoDoc = TipoDoc.id INNER JOIN Barrio ON Empleado.idBarrio = Barrio.id"
        sql &= " WHERE "
        sql &= " Empleado.id = " & grd_empleados.CurrentRow.Cells(0).Value
        sql &= " AND "
        sql &= " TipoDoc.id = " & grd_empleados.CurrentRow.Cells(1).Value
        sql &= " AND "
        sql &= " Barrio.id = " & grd_empleados.CurrentRow.Cells(9).Value

        tabla = _conex.consultar(sql)
        Me.txt_nombre.Text = tabla.Rows(0)("nombre")
        Me.txt_apellido.Text = tabla.Rows(0)("apellido")
        Me.txt_numero_documento.Text = tabla.Rows(0)("numDoc")
        Me.txt_calle.Text = tabla.Rows(0)("calle")
        Me.txt_numero_calle.Text = tabla.Rows(0)("numCalle")
        'cargar los combos
        Me.cargaCombo(cmb_barrio, _conex.leerTabla("Barrio"), "nombre", "id")
        Me.cargaCombo(cmb_tipo_documento, _conex.leerTabla("TipoDoc"), "descripcion", "id")
        Me.cmb_barrio.SelectedValue = tabla.Rows(0)("idBarrio")
        Me.cmb_tipo_documento.SelectedValue = tabla.Rows(0)("tipoDoc")

        _idEmpleadoSeleccionado = tabla.Rows(0)("id")
    End Sub

    Private Sub CargaCombo(ByRef combo As ComboBox, ByRef tabla As DataTable, descriptor As String, pk As String)
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

    Private Sub Modificar()
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
        sql &= " where id = " & _idEmpleadoSeleccionado
        _conex.insertar(sql)
    End Sub

    Private Sub ModificarEmpleado_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If _
            MessageBox.Show("¿Está seguro que desea cancelar?", "Confirmar cancelación", MessageBoxButtons.YesNo,
                            MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.No _
            Then
            e.Cancel = True
        End If
    End Sub
End Class