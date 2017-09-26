Public Class Conexiones
    'Cadena conexion rodrigo "Provider=SQLNCLI11;Data Source=RODRIGOGOMEB0F2\SQLEXPRESS;Integrated Security=SSPI;Initial Catalog=HeladeriaTuGusto"
    'Cadena conexion rodrigo netbook Provider=SQLNCLI11;Data Source=RODRIGO-PC\SQLEXPRESS;Integrated Security=SSPI;Initial Catalog=HeladeriaTuGusto
    'Cadena conexion fran "Provider=SQLNCLI11;Data Source=localhost\SQLExpress;Integrated Security=SSPI;Initial Catalog=HeladeriaTuGusto"
    Private cadena_conexion As String = "Provider=SQLNCLI11;Data Source=RODRIGO-PC\SQLEXPRESS;Integrated Security=SSPI;Initial Catalog=HeladeriaTuGusto"
    Private conexion As New OleDb.OleDbConnection
    Private comando As New OleDb.OleDbCommand

    Private Sub abrirConexion()
        If conexion.ConnectionString = "" Then
            conexion.ConnectionString = cadena_conexion
        End If

        If conexion.State = ConnectionState.Closed Then
            conexion.Open()
        End If
    End Sub

    Private Sub cerrarConexion()
        If conexion.State = ConnectionState.Open Then
            conexion.Close()
        End If
    End Sub

    Public Function leerTabla(ByRef nombre_tabla As String) As DataTable
        'Función que retorna una dataTable cargada con los resultados de la consulta SQL
        Dim tabla As New Data.DataTable
        abrirConexion()

        comando.Connection = conexion
        comando.CommandType = CommandType.Text
        comando.CommandText = "select * from " & nombre_tabla

        tabla.Load(comando.ExecuteReader)
        cerrarConexion()
        Return tabla
    End Function

    Public Sub insertar(ByRef sql As String)
        abrirConexion()
        comando.CommandType = CommandType.Text
        comando.Connection = conexion
        comando.CommandText = sql
        comando.ExecuteNonQuery()
        cerrarConexion()
    End Sub

    Public Function consultar(ByRef sql As String) As DataTable

        Dim tabla As New DataTable
        abrirConexion()
        comando.Connection = conexion
        comando.CommandType = CommandType.Text
        comando.CommandText = sql
        tabla.Load(comando.ExecuteReader)
        cerrarConexion()
        Return tabla
    End Function

    Public Function generar_id_consecutivo(ByRef nombre_tabla As String, ByRef pk As String) As Integer
        Dim tabla As New DataTable
        Me.abrirConexion()
        tabla = Me.consultar("select * from " & nombre_tabla & " order by " & pk)

        If tabla.Rows.Count = 0 Then
            Return 1
        Else
            Dim ultima_pos As Integer = (tabla.Rows.Count - 1)
            Return tabla.Rows(ultima_pos)(pk) + 1
        End If
        Me.cerrarConexion()
    End Function

End Class
