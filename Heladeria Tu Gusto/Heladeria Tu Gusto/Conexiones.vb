﻿Public Class Conexiones
    Private cadena_conexion As String = "Provider=SQLNCLI11;Data Source=localhost\SQLExpress;Integrated Security=SSPI;Initial Catalog=HeladeriaTuGusto"
    Private conexion As New OleDb.OleDbConnection
    Private comando As New OleDb.OleDbCommand

    Private Sub abrirConexion()
        conexion.ConnectionString = cadena_conexion
        If conexion.State = ConnectionState.Closed Then
            conexion.Open()
        End If
    End Sub

    Private Sub cerrarConexion()
        If conexion.State = ConnectionState.Open Then
            conexion.Close()
        End If
    End Sub

    Public Function leerTabla(ByVal nombre_tabla As String) As DataTable
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

    Public Sub insertar(sql As String)
        abrirConexion()
        comando.CommandType = CommandType.Text
        comando.Connection = conexion
        comando.CommandText = sql
        comando.ExecuteNonQuery()
        cerrarConexion()
    End Sub

End Class