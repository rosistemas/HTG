Public Class RegistrarProveedor
    'Cadena de conexión generada por el visual studio
    Dim connection_string As String = "Provider=SQLNCLI11;Data Source=localhost\SQLExpress;Integrated Security=SSPI;Initial Catalog=HeladeriaTuGusto"

    Private Sub cmd_aceptar_Click(sender As Object, e As EventArgs) Handles cmd_aceptar.Click
        Me.insertar()
        MsgBox("Se ha guardado la información.", MsgBoxStyle.OkOnly, "¡Éxito!")
    End Sub

    Private Sub cargarTiposDocumento(ByRef combo As ComboBox, ByRef tabla As DataTable, descripcion As String, pk As String)
        'Sub rutina que rellena el comboBox con los elementos de una dataTable
        cmb_tipo_documento.Items.Clear()
        cmb_tipo_documento.DataSource = tabla
        cmb_tipo_documento.DisplayMember = descripcion
        cmb_tipo_documento.ValueMember = pk
    End Sub

    Private Function leerTabla(ByVal nombre_tabla As String) As DataTable
        'Función que retorna una dataTable cargada con los resultados de la consulta SQL
        Dim conexion As New OleDb.OleDbConnection
        Dim comando As New OleDb.OleDbCommand
        Dim tabla As New Data.DataTable

        conexion.ConnectionString = connection_string
        conexion.Open()
        comando.Connection = conexion
        comando.CommandType = CommandType.Text
        comando.CommandText = "select * from " & nombre_tabla

        tabla.Load(comando.ExecuteReader)
        conexion.Close()
        Return tabla
    End Function

    Private Sub insertar()
        'Procedimiento para la inserción de los datos en la BD:
        'En el momento de declarar la sentencia SQL, se le van concatenando los valores
        'tomados desde el formulario
        'Sentencia = insert into Producto values (idProveedor, numDoc, tipoDoc, 'razonSocial' , 'mail', idBarrio, 'calle', numCalle, 'nombre')
        Dim conexion As New OleDb.OleDbConnection
        Dim comando As New OleDb.OleDbCommand
        Dim sql As String = ""
        conexion.ConnectionString = connection_string
        conexion.Open()
        comando.CommandType = CommandType.Text
        comando.Connection = conexion

        sql = "insert into Proveedor values"
        sql &= "(" & generarID()                                    'idProveedor
        sql &= ", " & Integer.Parse(txt_numero_documento.Text.Trim) 'numDoc
        sql &= ", " & cmb_tipo_documento.SelectedValue              'tipoDoc
        sql &= ", '" & txt_razon_social.Text.Trim & "'"             'razonSocial
        sql &= ", '" & txt_mail.Text.Trim & "'"                     'mail
        sql &= ", null" & cmb_barrio.SelectedValue                      'idBarrio falso
        sql &= ", '" & txt_calle.Text.Trim & "'"                    'calle
        sql &= ", " & Integer.Parse(txt_numero_calle.Text.Trim)     'numCalle
        sql &= ", '" & txt_nombre.Text.Trim & "'"                   'nombre
        sql &= ")"

        comando.CommandText = sql
        comando.ExecuteNonQuery()
        conexion.Close()

    End Sub

    Private Function generarID() As Integer
        'Función que genera un número aleatorio entre 100 y 1000
        Dim id As Integer
        Dim r As New Random
        id = r.Next(100, 1001)
        Dim disponible As Boolean
        disponible = idEstaDisponible(id)

        If Not disponible Then
            generarID()
        End If
        Return id
    End Function

    Private Function idEstaDisponible(id As Integer) As Boolean
        'Función auxiliar que verifica si el número generado en generarID() ya existe en la BD como una PK
        Dim conexion As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim tabla As New Data.DataTable
        conexion.ConnectionString = connection_string
        conexion.Open()
        cmd.Connection = conexion
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "select * from Proveedor where idProveedor = " & id
        tabla.Load(cmd.ExecuteReader)
        conexion.Close()

        If Not (tabla.Rows.Count = 0) Then 'Si la tabla devuelta por la consulta no está vacía...
            'El registro ya existe
            Return False
        End If
        Return True
    End Function

    Private Sub RegistrarProveedor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.cargarTiposDocumento(cmb_tipo_documento, leerTabla("TipoDoc"), "descripcion", "id")

    End Sub

    Private Sub cmd_cancelar_Click(sender As Object, e As EventArgs) Handles cmd_cancelar.Click
        'Simple funcionalidad del botón cancelar, limpia los campos y vuelve a mostrar la ventana principal
        If MessageBox.Show("Perderá los datos ingresados", "¿Desea cancelar el registro?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = Windows.Forms.DialogResult.Yes Then
            Me.Close()
            Principal.Show()
        End If
    End Sub

End Class