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
                Asistente.LimpiarFormulario(Controls)
            Else
                MessageBox.Show("Los datos no se han alterado.", "Cancelado", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End If
    End Sub

    Private Sub btn_cancelar_Click(sender As Object, e As EventArgs) Handles btn_cancelar.Click
        Close()
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
        grd_proveedores.Rows.Clear()
        For i = 0 To tabla.Rows.Count - 1
            grd_proveedores.Rows.Add()
            grd_proveedores.Rows(i).Cells("id_proveedor").Value = tabla.Rows(i)("idProveedor")
            grd_proveedores.Rows(i).Cells("numero_documento").Value = tabla.Rows(i)("numDoc")
            grd_proveedores.Rows(i).Cells("id_tipo_documento").Value = tabla.Rows(i)("tipoDoc")
            grd_proveedores.Rows(i).Cells("razon_social").Value = tabla.Rows(i)("razonSocial")
            grd_proveedores.Rows(i).Cells("mail").Value = tabla.Rows(i)("mail")
            grd_proveedores.Rows(i).Cells("id_barrio").Value = tabla.Rows(i)("idBarrio")
            grd_proveedores.Rows(i).Cells("calle").Value = tabla.Rows(i)("calle")
            grd_proveedores.Rows(i).Cells("numero_calle").Value = tabla.Rows(i)("numCalle")
            grd_proveedores.Rows(i).Cells("nombre").Value = tabla.Rows(i)("nombre")
            grd_proveedores.Rows(i).Cells("id_localidad").Value = tabla.Rows(i)("idLocalidad")
            grd_proveedores.Rows(i).Cells("barrio").Value = tabla.Rows(i)("nombre_barrio")
            grd_proveedores.Rows(i).Cells("localidad").Value = tabla.Rows(i)("nombre_localidad")
            grd_proveedores.Rows(i).Cells("tipo_documento").Value = tabla.Rows(i)("descripcion")
        Next
    End Sub

    Private Sub grd_proveedores_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles grd_proveedores.CellDoubleClick
        txt_nombre.Text = grd_proveedores.CurrentRow.Cells("nombre").Value
        txt_mail.Text = grd_proveedores.CurrentRow.Cells("mail").Value
        txt_numero_documento.Text = grd_proveedores.CurrentRow.Cells("numero_documento").Value
        txt_razon_social.Text = grd_proveedores.CurrentRow.Cells("razon_social").Value
        txt_calle.Text = grd_proveedores.CurrentRow.Cells("calle").Value
        txt_numero_calle.Text = grd_proveedores.CurrentRow.Cells("numero_calle").Value
        'cargar los combos
        Asistente.CargarCombo(cmb_barrio, Conex.LeerTabla("Barrio"), "nombre", "id")
        Asistente.CargarCombo(cmb_tipo_documento, Conex.LeerTabla("TipoDoc"), "descripcion", "id")
        Asistente.CargarCombo(cmb_localidad, Conex.LeerTabla("Localidad"), "nombre", "id")
        cmb_barrio.SelectedValue = grd_proveedores.CurrentRow.Cells("id_barrio").Value
        cmb_tipo_documento.SelectedValue = grd_proveedores.CurrentRow.Cells("id_tipo_documento").Value
        id_proveedor_seleccionado = grd_proveedores.CurrentRow.Cells("id_proveedor").Value
    End Sub

    Private Sub Modificar()
        Dim sql
        sql = "update Proveedor"
        sql &= " set numDoc = " & Integer.Parse(txt_numero_documento.Text.Trim)
        sql &= ", tipoDoc = " & cmb_tipo_documento.SelectedValue
        sql &= ", razonSocial = '" & txt_razon_social.Text.Trim & "'"
        sql &= ", mail = '" & txt_mail.Text.Trim & "'"
        sql &= ", idBarrio = " & cmb_barrio.SelectedValue
        sql &= ", calle = '" & txt_calle.Text.Trim & "'"
        sql &= ", numCalle = " & Integer.Parse(txt_numero_calle.Text.Trim)
        sql &= ", nombre = '" & txt_nombre.Text.Trim & "'"
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