Public Class RegistrarProveedor
    ReadOnly conex As New Conexiones
    ReadOnly _validador as New Validador

    Private Sub RegistrarProveedor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargarCombo(cmb_tipo_documento, conex.leerTabla("TipoDoc"), "descripcion", "id")
        cargarCombo(cmb_localidad, conex.leerTabla("Localidad"), "nombre", "id")
        cargarCombo(cmb_barrio, conex.leerTabla("Barrio"), "nombre", "id")
    End Sub

    Private Sub cmd_aceptar_Click(sender As Object, e As EventArgs) Handles cmd_aceptar.Click
        If _validador.Verificar_vacios(Me.Controls) = Validador.EstadoValidacion.SinErrores Then
            Insertar()
            MsgBox("Se ha guardado la información.", MsgBoxStyle.OkOnly, "¡Éxito!")
        End If
    End Sub

    Private Sub CargarCombo(ByRef combo As ComboBox, ByRef tabla As DataTable, descripcion As String, pk As String)

        combo.Items.Clear()
        combo.DataSource = tabla
        combo.DisplayMember = descripcion
        combo.ValueMember = pk
    End Sub

    Private Sub Insertar()
        Dim sql As String = ""

        sql = "insert into Proveedor values"
        sql &= "(" & conex.Generar_id_consecutivo("Proveedor", "idProveedor")'idProveedor
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

    Private Sub Cmd_cancelar_Click(sender As Object, e As EventArgs) Handles cmd_cancelar.Click
        'Simple funcionalidad del botón cancelar, limpia los campos y vuelve a mostrar la ventana principal
        If _
            MessageBox.Show("Perderá los datos ingresados", "¿Desea cancelar el registro?", MessageBoxButtons.YesNo,
                            MessageBoxIcon.Warning) = DialogResult.Yes Then
            Me.Close()
            Principal.Show()
        End If
    End Sub

    Private Sub RegistrarProveedor_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If MessageBox.Show("¿Está seguro que desea cancelar?", "Confirmar cancelación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.No Then
            e.Cancel = True
        End If
    End Sub
End Class