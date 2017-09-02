Public Class ABM_PERSONAS
    'Variables fijas
    'Indica donde esta alojado el servidor
    Dim cadenaConexion As String = "Provider=SQLNCLI11;Data Source=maquis;User ID=avisuales1;Initial Catalog=__BD_PAV1_3K3; password=avisuales1"
    'Indica que por defecto los datos del formulario irán a un nuevo registro
    Dim control_grabacion As tipoGrabacion = tipoGrabacion.Insertar
    'Una enumeración que contiene dos posibles valores de retorno

    Enum Validacion
        Correcta
        Erronea
    End Enum

    Enum tipoGrabacion
        Insertar
        Modificar
    End Enum

    Enum estadoBusqueda
        Encontro
        NoEncontro
    End Enum

    Private Sub ABM_PERSONAS_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.cargarGrilla()
        Me.cargaCombo(cmbDocumento, lectorTabla("tipos_documento"), "n_tipo_documento", "id_tipo_documento")
        Me.cargaCombo(cmbEstadoCivil, lectorTabla("tipos_estado_civil"), "n_estado_civil", "id_estado_civil")
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        If Me.validar() = Validacion.Correcta Then
            If control_grabacion = tipoGrabacion.Insertar Then
                'inserción de datos en la bd
                If verificarPKExistente() = estadoBusqueda.NoEncontro Then
                    Me.insertar()

                Else
                    MsgBox("Este documento y tipo ya existe.", MsgBoxStyle.OkOnly, "Documento ya existente")
                    Exit Sub 'Salir forzosamente para que no diga que la grabación fue exitosa más adelante
                End If

            Else
                'modificación de datos en la bd
                Me.modificar()
            End If
            MsgBox("La grabación fue exitosa.")
            Me.cargarGrilla()
        End If
    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        'Setear el tipo de grabacion como un nuevo registro
        Me.control_grabacion = tipoGrabacion.Insertar
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub cargarGrilla()

        '------------------REALIZAR LA CONSULTA-------------------
        Dim consulta As String = ""
        'Objeto de conexión a la base
        Dim conexion As New OleDb.OleDbConnection
        'Objeto para realizar una consulta
        Dim cmd As New OleDb.OleDbCommand
        'Objeto para recibir la información de respuesta
        Dim tabla As New Data.DataTable

        'Le paso la cadena de conexion al objeto de conexion
        conexion.ConnectionString = cadenaConexion
        'Realizar la apertura a la base
        conexion.Open()
        'Hay que indicarle a cmd a quién realizarle las operaciones
        cmd.Connection = conexion
        'Realizar una consulta local (una consulta almacenada en un String, como 'consulta')
        cmd.CommandType = CommandType.Text

        consulta = "SELECT        personas.apellido, personas.nombre, tipos_documento.n_tipo_documento, personas.nro_documento, personas.id_tipo_documento"
        consulta &= " FROM            personas INNER JOIN"
        consulta &= "            tipos_documento ON personas.id_tipo_documento = tipos_documento.id_tipo_documento"
        'Ejecutar la consulta
        cmd.CommandText = consulta
        'Cargar la tabla con el resultado de la ejecución
        tabla.Load(cmd.ExecuteReader)
        'Cerrar la conexión SIEMPRE
        conexion.Close()

        '------------------CARGAR LA TABLA-------------------
        Dim c As Integer = 0
        Me.gridABM.Rows.Clear()
        'Desde la fila 0 hasta cantidad de filas -1
        For c = 0 To tabla.Rows.Count - 1
            Me.gridABM.Rows.Add()
            'Del lado izquierdo van los nombres de las columnas de la grilla gráfica,
            'Mientras que del lado derecho van los nombres que se corresponden a las columnas de la Tabla 
            'Traída de la base de datos
            Me.gridABM.Rows(c).Cells("col_surname").Value = tabla.Rows(c)("apellido")
            Me.gridABM.Rows(c).Cells("col_Name").Value = tabla.Rows(c)("nombre")
            Me.gridABM.Rows(c).Cells("col_docType").Value = tabla.Rows(c)("n_tipo_documento")
            Me.gridABM.Rows(c).Cells("col_docNumber").Value = tabla.Rows(c)("nro_documento")
            Me.gridABM.Rows(c).Cells("col_idDocType").Value = tabla.Rows(c)("id_tipo_documento")
        Next

    End Sub

    Private Function lectorTabla(ByVal nombre_tabla As String) As DataTable
        'Función, tiene un valor de retorno. La subrutina no tiene.
        'Lee una tabla completa
        Dim conexion As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim tabla As New Data.DataTable

        conexion.ConnectionString = cadenaConexion
        conexion.Open()
        cmd.Connection = conexion
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "SELECT * FROM " & nombre_tabla 'Paso por valor, como en C

        tabla.Load(cmd.ExecuteReader)
        conexion.Close()
        Return tabla
    End Function

    Private Sub cargaCombo(ByRef combo As ComboBox, ByRef tabla As DataTable, descriptor As String, pk As String)
        'Limpiar el comboBox
        combo.Items.Clear()
        'Le asigno una nueva fuente
        combo.DataSource = tabla
        'Asociar un texto para mostrar
        combo.DisplayMember = descriptor
        'Asignarle un valor a ese texto mostrado
        combo.ValueMember = pk
    End Sub

    Private Function validar() As Validacion
        'Una función que va a retornar un elemento de la enumeración 
        'Validar los campos de texto
        'Validar el Apellido
        If Me.txtApellido.Text = "" Then
            'Mensaje de la caja              'Botones de la caja  'Título de la caja
            MsgBox("El apellido está vacío.", MsgBoxStyle.OkOnly, "Error de validación")
            'Setear el cursor en la caja de texto de apellido
            Me.txtApellido.Focus()
            Return Validacion.Erronea
        End If
        'Validar el Nombre
        If Me.txtNombre.Text = "" Then
            'Mensaje de la caja                   'Título de la caja        'Botón de la caja       'Icono de la caja
            MessageBox.Show("El nombre está vacío.", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            'Setear el cursor en la caja de texto de apellido
            Me.txtNombre.Focus()
            Return Validacion.Erronea
        End If
        'Validar el Sexo
        If Me.txtSexo.Text = "" Then
            'Mensaje de la caja                   'Título de la caja        'Botón de la caja       'Icono de la caja
            MessageBox.Show("El sexo está vacío.", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            'Setear el cursor en la caja de texto de apellido
            Me.txtSexo.Focus()
            Return Validacion.Erronea
        End If
        'Validar el Documento
        If Me.txtDocumento.Text = "" Then
            'Mensaje de la caja                   'Título de la caja        'Botón de la caja       'Icono de la caja
            MessageBox.Show("El Documento está vacío.", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            'Setear el cursor en la caja de texto de apellido
            Me.txtDocumento.Focus()
            Return Validacion.Erronea
        End If

        'Validar que hayan seleccionados valores de los comboBox
        If Me.cmbDocumento.SelectedIndex = -1 Then
            'Mensaje de la caja                   'Título de la caja        'Botón de la caja       'Icono de la caja
            MessageBox.Show("El tipo Documento esta sin selección.", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            'Setear el cursor en la caja de texto de apellido
            Me.cmbDocumento.Focus()
            Return Validacion.Erronea
        End If

        If Me.cmbEstadoCivil.SelectedIndex = -1 Then
            'Mensaje de la caja                   'Título de la caja        'Botón de la caja       'Icono de la caja
            MessageBox.Show("El Estado Civil esta sin selección.", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            'Setear el cursor en la caja de texto de apellido
            Me.cmbEstadoCivil.Focus()
            Return Validacion.Erronea
        End If

        Return Validacion.Correcta
    End Function

    Private Sub insertar()
        'Crear objetos necesarios para conectarse a la BD
        Dim conexion As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        conexion.ConnectionString = cadenaConexion
        conexion.Open()
        cmd.Connection = conexion
        cmd.CommandType = CommandType.Text

        'Construir la sentencia SQL para insertar
        Dim sql As String = ""
        sql = "insert into personas (nro_documento, id_tipo_documento, apellido, nombre, sexo, id_estado_civil)"
        sql &= "values("
        sql &= Me.txtDocumento.Text.Trim 'Cortar espacios a derecha e izquierda
        sql &= "," & Me.cmbDocumento.SelectedValue 'Trae el valor asociado al descriptor
        sql &= ", '" & Me.txtApellido.Text.Trim & "'" 'Le otorga a SQL el valor de la cadena con comillas simples, es decir, cumplir la sintaxis sql
        sql &= ", '" & Me.txtNombre.Text.Trim & "'"
        sql &= ", '" & Me.txtSexo.Text.Trim & "'"
        sql &= "," & Me.cmbEstadoCivil.SelectedValue
        sql &= ")"

        cmd.CommandText = sql
        'Ejecución de una No consulta (Es decir, una inserción, modificación o un borrado, no trae datos)
        cmd.ExecuteNonQuery()
        conexion.Close()


    End Sub

    Private Sub modificar()
        Dim conexion As New OleDb.OleDbConnection
        Dim comando As New OleDb.OleDbCommand

        'Consulta de actualización
        Dim sql As String = ""
        sql &= "update personas"
        sql &= " set apellido = '" & Me.txtApellido.Text.Trim & "'"
        sql &= ", nombre = '" & Me.txtNombre.Text.Trim & "'"
        sql &= ", sexo = '" & Me.txtSexo.Text.Trim & "'"
        sql &= ", id_estado_civil = " & Me.cmbEstadoCivil.SelectedValue
        'Restricción where, prestar atención a los espacios
        sql &= " where id_tipo_documento = " & Me.cmbDocumento.SelectedValue
        sql &= " and nro_documento = " & Me.txtDocumento.Text.Trim

        'Datos de la conexión
        conexion.ConnectionString = cadenaConexion
        conexion.Open()
        comando.Connection = conexion
        comando.CommandType = CommandType.Text
        comando.CommandText = sql
        comando.ExecuteNonQuery()
        conexion.Close()

    End Sub

    Private Function verificarPKExistente() As estadoBusqueda
        Dim conexion As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim tabla As New Data.DataTable

        conexion.ConnectionString = cadenaConexion
        conexion.Open()
        cmd.Connection = conexion
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "select * from personas where nro_documento = " & Me.txtDocumento.Text.Trim _
        & "and id_tipo_documento = " & Me.cmbDocumento.SelectedValue

        tabla.Load(cmd.ExecuteReader)
        conexion.Close()

        If tabla.Rows.Count = 0 Then 'Si la tabla devuelta por la consulta está vacía...
            'El registro nuevo todavía no existe en la bd
            Return estadoBusqueda.NoEncontro
        Else
            'El registro nuevo ya existe en la bd
            Return estadoBusqueda.Encontro
        End If
    End Function

    Private Sub gridABM_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles gridABM.CellDoubleClick
        Dim conexion As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim tabla As New Data.DataTable

        conexion.ConnectionString = cadenaConexion
        conexion.Open()
        cmd.Connection = conexion
        cmd.CommandType = CommandType.Text

        'Verificar si se desea eliminar o no
        If chk_Eliminar.Checked = True Then ' Eliminar los datos
            'Verifica la selección de SI/NO en el messagebox
            If MessageBox.Show("¿Está seguro de que desea eliminar?", "Tenga cuidado al seleccionar los datos", _
                               MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = Windows.Forms.DialogResult.Yes Then

                cmd.CommandText = "delete from personas where " _
                & " nro_documento = " & Me.gridABM.CurrentRow.Cells(3).Value _
                & "and id_tipo_documento = " & Me.gridABM.CurrentRow.Cells(4).Value
                cmd.ExecuteNonQuery()
                'Hacer efectiva la actualización
                conexion.Close()
                'recargar la grilla
                Me.cargarGrilla()
            End If

        Else 'Recuperar los datos
            ' 3 y 4 se corresponden a las posiciones de las columnas en la grilla, es decir,
            'where nro_documento = (valor de la columna Documento) y id_tipo_documento = (valor de la columna idTipoDocumento)
            cmd.CommandText = "select * from personas where " _
            & " nro_documento = " & Me.gridABM.CurrentRow.Cells(3).Value _
            & "and id_tipo_documento = " & Me.gridABM.CurrentRow.Cells(4).Value

            tabla.Load(cmd.ExecuteReader)


            'Cargar los elementos del formulario con los nuevos datos traídos de la BD
            'Recordar que TABLA es una variable que contiene los datos traídos de la base de datos
            'Siempre usamos la posición 0 porque trae UN SOLO REGISTRO de la BD, ya que la PK es única
            Me.txtApellido.Text = tabla.Rows(0)("apellido")
            Me.txtNombre.Text = tabla.Rows(0)("nombre")
            Me.txtSexo.Text = tabla.Rows(0)("sexo")
            Me.txtDocumento.Text = tabla.Rows(0)("nro_documento")
            Me.cmbDocumento.SelectedValue = tabla.Rows(0)("id_tipo_documento")
            Me.cmbEstadoCivil.SelectedValue = tabla.Rows(0)("id_estado_civil")
            Me.control_grabacion = tipoGrabacion.Modificar
            'Bloquear los elementos correspondientes a la PK
            Me.txtDocumento.Enabled = False
            Me.cmbDocumento.Enabled = False
            conexion.Close()
        End If

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Dim tabla As New DataTable
        tabla = Me.lectorTabla("personas")
        lblContador.Text = tabla.Rows.Count.ToString()
    End Sub
End Class
