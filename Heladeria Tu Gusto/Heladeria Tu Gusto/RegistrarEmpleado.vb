Public Class RegistrarEmpleado
    ReadOnly conex As New Conexiones
    ReadOnly _validador as New Validador
    Private Sub RegistrarEmpleado_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.cargarCombo(cmb_tipo_documento, conex.leerTabla("TipoDoc"), "descripcion", "id")
        Me.cargarCombo(cmb_barrio, conex.leerTabla("Barrio"), "nombre", "id")

    End Sub


    Private Sub cmd_aceptar_Click(sender As Object, e As EventArgs) Handles cmd_aceptar.Click
        If _validador.Verificar_vacios(Me.Controls) = Validador.EstadoValidacion.SinErrores Then
            Me.Insertar()
            MsgBox("Se ha guardado la información.", MsgBoxStyle.OkOnly, "¡Éxito!")
        End If
    End Sub

    Private Sub cargarCombo(ByRef combo As ComboBox, ByRef tabla As DataTable, descripcion As String, pk As String)
        'Sub rutina que rellena el comboBox con los elementos de una dataTable
        combo.Items.Clear()
        combo.DataSource = tabla
        combo.DisplayMember = descripcion
        combo.ValueMember = pk
    End Sub

    Private Sub insertar()
        'Procedimiento para la inserción de los datos en la BD:
        'En el momento de declarar la sentencia SQL, se le van concatenando los valores
        'tomados desde el formulario
        Dim sql As String = ""
        sql = "insert into Empleado values"
        sql &= "(" & conex.Generar_id_consecutivo("Empleado", "id")  'idEmpleado
        sql &= ", " & Integer.Parse(txt_numero_documento.Text.Trim) 'numDoc
        sql &= ", " & cmb_tipo_documento.SelectedValue              'tipoDoc
        sql &= ", '" & txt_nombre.Text.Trim & "'"                   'nombre
        sql &= ", '" & txt_apellido.Text.Trim & "'"                 'apellido
        sql &= ", '" & date_fecha_nacimiento.Value.Date & "'"       'fechaNacimiento
        sql &= ", '" & DateTime.Today.Date & "'"                    'fechaIngreso
        sql &= ", null" '& cmb_barrio.SelectedValue                 'fechaEgreso
        sql &= ", " & cmb_barrio.SelectedValue                 'idBarrio falso
        sql &= ", '" & txt_calle.Text.Trim & "'"                    'calle
        sql &= ", " & Integer.Parse(txt_numero_calle.Text.Trim)     'numCalle
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

    Private Sub RegistrarEmpleado_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If MessageBox.Show("¿Está seguro que desea cancelar?", "Confirmar cancelación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.No Then
            e.Cancel = True
        End If
    End Sub
End Class