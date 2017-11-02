Public Class ModificarProveedor
    Private Property Conex As Conexiones = New Conexiones
    Private Property Asistente As AsistenteFormulario = new AsistenteFormulario
    Private id_proveedor_seleccionado As Integer = 0

    Private Sub ModificarProveedor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarGrilla()
    End Sub

    Private Sub btn_guardar_Click(sender As Object, e As EventArgs) Handles btn_guardar.Click
        If Asistente.VerificarVacios(Controls) = Validador.EstadoValidacion.SinErrores Then
            If MessageBox.Show("¿Está seguro de querer modificar los datos del producto seleccionado?", "Precaución", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = DialogResult.Yes Then
                Modificar()
                CargarGrilla()
            Else
                MessageBox.Show("Los datos no se han alterado.", "Cancelado", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End If
    End Sub

    Private Sub btn_cancelar_Click(sender As Object, e As EventArgs) Handles btn_cancelar.Click
        If MessageBox.Show("Perderá los datos ingresados", "¿Desea cancelar la modificación?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.Yes Then
            Close()
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
        tabla = Conex.Consultar(sql)
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

    Private Sub grd_proveedores_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles grd_proveedores.CellDoubleClick
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

        tabla = Conex.Consultar(sql)
        Me.txt_nombre.Text = tabla.Rows(0)("nombre")
        Me.txt_mail.Text = tabla.Rows(0)("mail")
        Me.txt_numero_documento.Text = tabla.Rows(0)("numDoc")
        Me.txt_razon_social.Text = tabla.Rows(0)("razonSocial")
        Me.txt_calle.Text = tabla.Rows(0)("calle")
        Me.txt_numero_calle.Text = tabla.Rows(0)("numCalle")
        'cargar los combos
        Asistente.CargarCombo(cmb_barrio, Conex.LeerTabla("Barrio"), "nombre", "id")
        Asistente.CargarCombo(cmb_tipo_documento, Conex.LeerTabla("TipoDoc"), "descripcion", "id")
        Asistente.CargarCombo(cmb_localidad, Conex.LeerTabla("Localidad"), "nombre", "id")
        Me.cmb_barrio.SelectedValue = tabla.Rows(0)("idBarrio")
        Me.cmb_tipo_documento.SelectedValue = tabla.Rows(0)("tipoDoc")

        id_proveedor_seleccionado = tabla.Rows(0)("idProveedor")
    End Sub

    Private Sub Modificar()
        Dim sql
        sql = "update Proveedor"
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
        Conex.Insertar(sql)
    End Sub

    Private Sub ModificarProveedor_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If MessageBox.Show("¿Está seguro que desea cancelar?", "Confirmar cancelación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) = DialogResult.No Then
            e.Cancel = True
        End If
    End Sub
End Class