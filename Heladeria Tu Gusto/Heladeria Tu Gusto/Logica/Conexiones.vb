﻿Imports System.Data.OleDb

Public Class Conexiones
    'Cadena conexion rodrigo "Provider=SQLNCLI11;Data Source=DESKTOP-UH7QCBC\SQLEXPRESS;Integrated Security=SSPI;Initial Catalog=HeladeriaTuGusto"
    'Cadena conexion rodrigo netbook Provider=SQLNCLI11;Data Source=RODRIGO-PC\SQLEXPRESS;Integrated Security=SSPI;Initial Catalog=HeladeriaTuGusto
    'Cadena conexion fran "Provider=SQLNCLI11;Data Source=localhost\SQLExpress;Integrated Security=SSPI;Initial Catalog=HeladeriaTuGusto"
    Private ReadOnly _cadenaConexion As String = "Provider=SQLNCLI11;Data Source=DESKTOP-LF51CMQ\SQLEXPRESS01;Integrated Security=SSPI;Initial Catalog=HeladeriaTuGusto"
    Private ReadOnly _conexion As New OleDbConnection
    Private ReadOnly _comando As New OleDbCommand

    Public ReadOnly Property CadenaConexion As String
        Get
            Return _cadenaConexion
        End Get
    End Property

    Public ReadOnly Property Conexion As OleDbConnection
        Get
            Return _conexion
        End Get
    End Property

    Public ReadOnly Property Comando As OleDbCommand
        Get
            Return _comando
        End Get
    End Property


    Private Sub AbrirConexion()
        If Conexion.ConnectionString = "" Then
            Conexion.ConnectionString = CadenaConexion
        End If

        If Conexion.State = ConnectionState.Closed Then
            Conexion.Open()
        End If
    End Sub

    Private Sub CerrarConexion()
        If Conexion.State = ConnectionState.Open Then
            Conexion.Close()
        End If
    End Sub

    Public Function LeerTabla(ByRef nombreTabla As String) As DataTable
        'Función que retorna una dataTable cargada con los resultados de la consulta SQL
        Dim tabla As New DataTable
        AbrirConexion()

        Comando.Connection = Conexion
        Comando.CommandType = CommandType.Text
        Comando.CommandText = "select * from " & nombreTabla

        tabla.Load(Comando.ExecuteReader)
        CerrarConexion()
        Return tabla
    End Function

    Public Sub Insertar(ByRef sql As String)
        AbrirConexion()
        Comando.CommandType = CommandType.Text
        Comando.Connection = Conexion
        Comando.CommandText = sql
        Comando.ExecuteNonQuery()
        CerrarConexion()
    End Sub

    Public Function Consultar(ByRef sql As String) As DataTable

        Dim tabla As New DataTable
        AbrirConexion()
        Comando.Connection = Conexion
        Comando.CommandType = CommandType.Text
        Comando.CommandText = sql
        tabla.Load(Comando.ExecuteReader)
        CerrarConexion()
        Return tabla
    End Function

    Public Function Generar_id_consecutivo(ByRef nombreTabla As String, ByRef pk As String) As Integer
        Dim tabla As New DataTable
        Me.AbrirConexion()
        tabla = Me.Consultar("select * from " & nombreTabla & " order by " & pk)
        Me.CerrarConexion()
        If tabla.Rows.Count = 0 Then
            Return 1
        Else
            Dim ultimaPos As Integer = (tabla.Rows.Count - 1)
            Return tabla.Rows(ultimaPos)(pk) + 1
        End If
    End Function

End Class
