Public Class RegistrarProveedor
    Public conex As New Conexiones
    Private Sub RegistrarProveedor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.cargarCombo(cmb_tipo_documento, conex.leerTabla("TipoDoc"), "descripcion", "id")
        Me.cargarCombo(cmb_localidad, conex.leerTabla("Localidad"), "nombre", "id")
        Me.cargarCombo(cmb_barrio, conex.leerTabla("Barrio"), "nombre", "id")
    End Sub
    Private Sub cmd_aceptar_Click(sender As Object, e As EventArgs) Handles cmd_aceptar.Click
        Me.insertar()
        MsgBox("Se ha guardado la información.", MsgBoxStyle.OkOnly, "¡Éxito!")
    End Sub

    Private Sub cargarCombo(ByRef combo As ComboBox, ByRef tabla As DataTable, descripcion As String, pk As String)
        'Sub rutina que rellena el comboBox con los elementos de una dataTable
        combo.Items.Clear()
        combo.DataSource = tabla
        combo.DisplayMember = descripcion
        combo.ValueMember = pk
    End Sub

    Private Sub insertar()
        'Sentencia = insert into Producto values (idProveedor, numDoc, tipoDoc, 'razonSocial' , 'mail', idBarrio, 'calle', numCalle, 'nombre')
        Dim sql As String = ""

        sql = "insert into Proveedor values"
        sql &= "(" & conex.generar_id_consecutivo("Proveedor", "idProveedor")                  'idProveedor
        sql &= ", " & Integer.Parse(txt_numero_documento.Text.Trim) 'numDoc
        sql &= ", " & cmb_tipo_documento.SelectedValue              'tipoDoc
        sql &= ", '" & txt_razon_social.Text.Trim & "'"             'razonSocial
        sql &= ", '" & txt_mail.Text.Trim & "'"                     'mail
        sql &= ", " & cmb_barrio.SelectedValue                      'idBarrio
        sql &= ", '" & txt_calle.Text.Trim & "'"                    'calle
        sql &= ", " & Integer.Parse(txt_numero_calle.Text.Trim)     'numCalle
        sql &= ", '" & txt_nombre.Text.Trim & "'"                   'nombre
        sql &= ", " & cmb_localidad.SelectedValue                   'idLocalidad
        sql &= ")"

        conex.insertar(sql)
    End Sub

    Private Sub cmd_cancelar_Click(sender As Object, e As EventArgs) Handles cmd_cancelar.Click
        'Simple funcionalidad del botón cancelar, limpia los campos y vuelve a mostrar la ventana principal
        If MessageBox.Show("Perderá los datos ingresados", "¿Desea cancelar el registro?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = Windows.Forms.DialogResult.Yes Then
            Me.Close()
            Principal.Show()
        End If
    End Sub

End Class