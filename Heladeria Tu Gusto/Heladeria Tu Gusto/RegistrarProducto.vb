Public Class RegistrarProducto
    'Cadena de conexión generada por el visual studio
    Dim connection_string As String = "Provider=SQLNCLI11;Data Source=localhost\SQLExpress;Integrated Security=SSPI;Initial Catalog=HeladeriaTuGusto"
    Dim conex As New Conexiones
    Private Sub RegistrarProducto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Al cargar el formulario, rellenar el comboBox de tipos de producto
        Me.cargarTiposProductos(cmb_tipo, conex.leerTabla("TipoProducto"), "descripcion", "idTipo")
    End Sub

    Private Sub cmd_aceptar_Click(sender As Object, e As EventArgs) Handles cmd_aceptar.Click
        'Llamar al procedimiento de inserción e informar que fue correcto.
        Me.insertar()
        MsgBox("Se ha guardado la información.", MsgBoxStyle.OkOnly, "¡Éxito!")
    End Sub

    Private Sub cargarTiposProductos(ByRef combo As ComboBox, ByRef tabla As DataTable, descripcion As String, pk As String)
        'Sub rutina que rellena el comboBox con los elementos de una dataTable
        cmb_tipo.Items.Clear()
        cmb_tipo.DataSource = tabla
        cmb_tipo.DisplayMember = descripcion
        cmb_tipo.ValueMember = pk
    End Sub

    Private Sub cmd_cancelar_Click(sender As Object, e As EventArgs) Handles cmd_cancelar.Click
        'Simple funcionalidad del botón cancelar, limpia los campos y vuelve a mostrar la ventana principal
        If MessageBox.Show("Perderá los datos ingresados", "¿Desea cancelar el registro?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = Windows.Forms.DialogResult.Yes Then
            Me.Close()
            Principal.Show()
        End If
    End Sub

    Private Sub insertar()
        'Sentencia = insert into Producto values (idProducto, 'nombre', idTipo, precio, stock, 'descripción')
        Dim sql As String = ""

        sql = "insert into Producto values"
        sql &= "(" & conex.generar_id_consecutivo("Producto", "idProducto")   'idProducto, es generado automáticamente y no se repite
        sql &= ", '" & txt_nombre.Text.Trim & "'"       'nombre
        sql &= ", " & cmb_tipo.SelectedValue            'idTipo
        sql &= ", " & Integer.Parse(txt_precio.Text.Trim) 'precio
        sql &= ", 20"                                   'stock
        sql &= ", '" & txt_descripcion.Text.Trim & "'"  'descripción
        sql &= ")"

        conex.insertar(sql)
    End Sub
End Class