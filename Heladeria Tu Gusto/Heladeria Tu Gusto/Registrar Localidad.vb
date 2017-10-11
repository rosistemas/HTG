Public Class Registrar_Localidad

    Dim connection_string As String = "Provider=SQLNCLI11;Data Source=localhost\SQLExpress;Integrated Security=SSPI;Initial Catalog=master"
    Dim conex As New Conexiones
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
        cmd.CommandText = "select * from Provincia where id = " & id
        tabla.Load(cmd.ExecuteReader)
        conexion.Close()

        If Not (tabla.Rows.Count = 0) Then 'Si la tabla devuelta por la consulta no está vacía...
            'El registro ya existe
            Return False
        End If
        Return True
    End Function
    Private Sub insertar()
        'Procedimiento para la inserción de los datos en la BD:
        'En el momento de declarar la sentencia SQL, se le van concatenando los valores
        'tomados desde el formulario
        Dim sql As String = ""
        sql = "insert into Localidad values"
        sql &= "(" & generarID()                                    'idLocalidad
        sql &= ", '" & txt_nombre.Text.Trim & "'"                   'nombre
        sql &= ", '" & cmb_provincia.SelectedValue & "')"            'Combo provincia

        Dim c As New Conexiones
        c.insertar(sql)

    End Sub


    Private Sub button_save_Click(sender As Object, e As EventArgs) Handles button_save.Click
        Me.insertar()
        MsgBox("Se ha guardado la información.", MsgBoxStyle.OkOnly, "¡Éxito!")
    End Sub

    Private Sub button_cancel_Click(sender As Object, e As EventArgs) Handles button_cancel.Click
        'Simple funcionalidad del botón cancelar, limpia los campos y vuelve a mostrar la ventana principal
        If MessageBox.Show("Perderá los datos ingresados", "¿Desea cancelar el registro?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = Windows.Forms.DialogResult.Yes Then
            Me.Close()
            Principal.Show()
        End If
    End Sub
    Private Sub cargarCombo(ByRef combo As ComboBox, ByRef tabla As DataTable, descripcion As String, pk As String)
        'Sub rutina que rellena el comboBox con los elementos de una dataTable
        combo.Items.Clear()
        combo.DataSource = tabla
        combo.DisplayMember = descripcion
        combo.ValueMember = pk
    End Sub
    Private Sub RegistrarEmpleado_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.cargarCombo(cmb_provincia, conex.leerTabla("Provincia"), "nombre", "id")


    End Sub

End Class