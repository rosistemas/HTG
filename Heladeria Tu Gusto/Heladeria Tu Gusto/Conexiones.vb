Public Class Conexiones
    'Cadena conexion rodrigo "Provider=SQLNCLI11;Data Source=DESKTOP-UH7QCBC\SQLEXPRESS;Integrated Security=SSPI;Initial Catalog=HeladeriaTuGusto"
    'Cadena conexion rodrigo netbook Provider=SQLNCLI11;Data Source=RODRIGO-PC\SQLEXPRESS;Integrated Security=SSPI;Initial Catalog=HeladeriaTuGusto
    'Cadena conexion fran "Provider=SQLNCLI11;Data Source=localhost\SQLExpress;Integrated Security=SSPI;Initial Catalog=HeladeriaTuGusto"
    Private ReadOnly _cadenaConexion As String = "Provider=SQLNCLI11;Data Source=DESKTOP-UH7QCBC\SQLEXPRESS;Integrated Security=SSPI;Initial Catalog=HeladeriaTuGusto"
    Private ReadOnly _conexion As New OleDb.OleDbConnection
    Private ReadOnly _comando As New OleDb.OleDbCommand

    Private Sub AbrirConexion()
        If _conexion.ConnectionString = "" Then
            _conexion.ConnectionString = _cadenaConexion
        End If

        If _conexion.State = ConnectionState.Closed Then
            _conexion.Open()
        End If
    End Sub

    Private Sub CerrarConexion()
        If _conexion.State = ConnectionState.Open Then
            _conexion.Close()
        End If
    End Sub

    Public Function LeerTabla(ByRef nombreTabla As String) As DataTable
        'Función que retorna una dataTable cargada con los resultados de la consulta SQL
        Dim tabla As New Data.DataTable
        abrirConexion()

        _comando.Connection = _conexion
        _comando.CommandType = CommandType.Text
        _comando.CommandText = "select * from " & nombreTabla

        tabla.Load(_comando.ExecuteReader)
        cerrarConexion()
        Return tabla
    End Function

    Public Sub Insertar(ByRef sql As String)
        abrirConexion()
        _comando.CommandType = CommandType.Text
        _comando.Connection = _conexion
        _comando.CommandText = sql
        _comando.ExecuteNonQuery()
        cerrarConexion()
    End Sub

    Public Function Consultar(ByRef sql As String) As DataTable

        Dim tabla As New DataTable
        abrirConexion()
        _comando.Connection = _conexion
        _comando.CommandType = CommandType.Text
        _comando.CommandText = sql
        tabla.Load(_comando.ExecuteReader)
        cerrarConexion()
        Return tabla
    End Function

    Public Function Generar_id_consecutivo(ByRef nombreTabla As String, ByRef pk As String) As Integer
        Dim tabla As New DataTable
        Me.abrirConexion()
        tabla = Me.consultar("select * from " & nombreTabla & " order by " & pk)
        Me.cerrarConexion()
        If tabla.Rows.Count = 0 Then
            Return 1
        Else
            Dim ultimaPos As Integer = (tabla.Rows.Count - 1)
            Return tabla.Rows(ultimaPos)(pk) + 1
        End If
    End Function

End Class
