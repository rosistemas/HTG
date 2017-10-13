﻿Public Class ModificarProveedor
    ReadOnly _conex As New Conexiones
    ReadOnly _validador as New Validador
    Private id_proveedor_seleccionado As Integer = 0

    Private Sub ModificarProveedor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
        sql = "select P.*, L.id as id_localidad, L.nombre as nombre_localidad,"
        sql &= " B.id as id_barrio, B.nombre as nombre_barrio, D.*"
        sql &= " from Proveedor P"
        sql &= " inner join Localidad L on P.idLocalidad = L.id"
        sql &= " inner join Barrio B on P.idBarrio = B.id"
        sql &= " inner join TipoDoc D on p.tipoDoc = D.id"

        Dim tabla As New DataTable
        tabla = _conex.consultar(sql)
        Me.grd_proveedores.Rows.Clear()
        For i = 0 To tabla.Rows.Count - 1
            Me.grd_proveedores.Rows.Add()
            Me.grd_proveedores.Rows(i).Cells("id_proveedor").Value = tabla.Rows(i)("idProveedor")
            Me.grd_proveedores.Rows(i).Cells("numero_documento").Value = tabla.Rows(i)("numDoc")
            Me.grd_proveedores.Rows(i).Cells("id_tipo_documento").Value = tabla.Rows(i)("tipoDoc")
            Me.grd_proveedores.Rows(i).Cells("razon_social").Value = tabla.Rows(i)("razonSocial")
            Me.grd_proveedores.Rows(i).Cells("mail").Value = tabla.Rows(i)("mail")
            Me.grd_proveedores.Rows(i).Cells("id_barrio").Value = tabla.Rows(i)("idBarrio")
            Me.grd_proveedores.Rows(i).Cells("calle").Value = tabla.Rows(i)("calle")
            Me.grd_proveedores.Rows(i).Cells("numero_calle").Value = tabla.Rows(i)("numCalle")
            Me.grd_proveedores.Rows(i).Cells("nombre").Value = tabla.Rows(i)("nombre")
            Me.grd_proveedores.Rows(i).Cells("id_localidad").Value = tabla.Rows(i)("idLocalidad")
            Me.grd_proveedores.Rows(i).Cells("barrio").Value = tabla.Rows(i)("nombre_barrio")
            Me.grd_proveedores.Rows(i).Cells("localidad").Value = tabla.Rows(i)("nombre_localidad")
            Me.grd_proveedores.Rows(i).Cells("tipo_documento").Value = tabla.Rows(i)("descripcion")
        Next
    End Sub

    Private Sub grd_proveedores_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) _
        Handles grd_proveedores.CellDoubleClick
        Dim tabla As New DataTable
        Dim sql As String
        sql = "select P.*, L.id as id_localidad, L.nombre as nombre_localidad,"
        sql &= " B.id as id_barrio, B.nombre as nombre_barrio, D.*"
        sql &= " from Proveedor P"
        sql &= " inner join Localidad L on P.idLocalidad = L.id"
        sql &= " inner join Barrio B on P.idBarrio = B.id"
        sql &= " inner join TipoDoc D on p.tipoDoc = D.id"
        sql &= " WHERE "
        sql &= " P.idProveedor = " & grd_proveedores.CurrentRow.Cells(0).Value
        sql &= " AND "
        sql &= " D.id = " & grd_proveedores.CurrentRow.Cells(2).Value
        sql &= " AND "
        sql &= " B.id = " & grd_proveedores.CurrentRow.Cells(6).Value
        sql &= " AND "
        sql &= " L.id = " & grd_proveedores.CurrentRow.Cells(11).Value

        tabla = _conex.consultar(sql)
        Me.txt_nombre.Text = tabla.Rows(0)("nombre")
        Me.txt_mail.Text = tabla.Rows(0)("mail")
        Me.txt_numero_documento.Text = tabla.Rows(0)("numDoc")
        Me.txt_razon_social.Text = tabla.Rows(0)("razonSocial")
        Me.txt_calle.Text = tabla.Rows(0)("calle")
        Me.txt_numero_calle.Text = tabla.Rows(0)("numCalle")
        'cargar los combos
        Me.cargaCombo(cmb_barrio, _conex.leerTabla("Barrio"), "nombre", "id")
        Me.cargaCombo(cmb_tipo_documento, _conex.leerTabla("TipoDoc"), "descripcion", "id")
        Me.cargaCombo(cmb_localidad, _conex.leerTabla("Localidad"), "nombre", "id")
        Me.cmb_barrio.SelectedValue = tabla.Rows(0)("idBarrio")
        Me.cmb_tipo_documento.SelectedValue = tabla.Rows(0)("tipoDoc")

        id_proveedor_seleccionado = tabla.Rows(0)("idProveedor")
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
        sql &= "update Proveedor"
        sql &= " set numDoc = " & Integer.Parse(txt_numero_documento.Text.Trim)
        sql &= ", tipoDoc = " & Me.cmb_tipo_documento.SelectedValue
        sql &= ", razonSocial = '" & Me.txt_razon_social.Text.Trim & "'"
        sql &= ", mail = '" & Me.txt_mail.Text.Trim & "'"
        sql &= ", idBarrio = " & Me.cmb_barrio.SelectedValue
        sql &= ", calle = '" & Me.txt_calle.Text.Trim & "'"
        sql &= ", numCalle = " & Integer.Parse(txt_numero_calle.Text.Trim)
        sql &= ", nombre = '" & Me.txt_nombre.Text.Trim & "'"
        sql &= ", idLocalidad = " & cmb_localidad.SelectedValue
        sql &= " where idProveedor = " & id_proveedor_seleccionado
        _conex.insertar(sql)
    End Sub

    Private Sub ModificarProveedor_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If _
            MessageBox.Show("¿Está seguro que desea cancelar?", "Confirmar cancelación", MessageBoxButtons.YesNo,
                            MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.No _
            Then
            e.Cancel = True
        End If
    End Sub
End Class