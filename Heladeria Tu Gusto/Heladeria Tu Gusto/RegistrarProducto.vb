Public Class RegistrarProducto

    Dim connection_string As String = "Provider=SQLNCLI11;Data Source=localhost\SQLExpress;Integrated Security=SSPI;Initial Catalog=HeladeriaTuGusto"

    Private Sub RegistrarProducto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.cargarTiposProductos(cmb_tipo, leerTabla("TipoProducto"), "descripcion", "idTipo")
    End Sub

    Private Sub cmd_aceptar_Click(sender As Object, e As EventArgs) Handles cmd_aceptar.Click
        Me.insertar()
        MsgBox("Se ha guardado la información.", MsgBoxStyle.OkOnly, "¡Éxito!")

    End Sub

    Private Sub cargarTiposProductos(ByRef combo As ComboBox, ByRef tabla As DataTable, descripcion As String, pk As String)
        cmb_tipo.Items.Clear()
        cmb_tipo.DataSource = tabla
        cmb_tipo.DisplayMember = descripcion
        cmb_tipo.ValueMember = pk
    End Sub

    Private Function leerTabla(ByVal nombre_tabla As String) As DataTable
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

    Private Sub cmd_cancelar_Click(sender As Object, e As EventArgs) Handles cmd_cancelar.Click
        If MessageBox.Show("Perderá los datos ingresados", "¿Desea cancelar el registro?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = Windows.Forms.DialogResult.Yes Then
            txt_descripcion.Clear()
            txt_nombre.Clear()
            txt_precio.Clear()
            Me.Close()
            Principal.Show()
        End If
    End Sub

    Private Sub insertar()
        Dim conexion As New OleDb.OleDbConnection
        Dim comando As New OleDb.OleDbCommand
        Dim sql As String = ""
        conexion.ConnectionString = connection_string
        conexion.Open()
        comando.CommandType = CommandType.Text
        comando.Connection = conexion

        sql = "insert into Producto values"
        sql &= "(" & generarID()                        'idProducto
        sql &= ", '" & txt_nombre.Text.Trim & "'"       'nombre
        sql &= ", " & cmb_tipo.SelectedValue            'idTipo
        sql &= ", " & Integer.Parse(txt_precio.Text.Trim) 'precio
        sql &= ", 20"                                   'stock
        sql &= ", '" & txt_descripcion.Text.Trim & "'"  'descripción
        sql &= ")"

        comando.CommandText = sql
        comando.ExecuteNonQuery()
        conexion.Close()

    End Sub

    Private Function generarID() As Integer
        'Función que genera un número aleatorio entre 1 y 1000
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

        Dim conexion As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim tabla As New Data.DataTable
        conexion.ConnectionString = connection_string
        conexion.Open()
        cmd.Connection = conexion
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "select * from Producto where idProducto = " & id
        tabla.Load(cmd.ExecuteReader)
        conexion.Close()

        If Not (tabla.Rows.Count = 0) Then 'Si la tabla devuelta por la consulta no está vacía...
            'El registro ya existe
            Return False
        End If
        Return true
    End Function
End Class