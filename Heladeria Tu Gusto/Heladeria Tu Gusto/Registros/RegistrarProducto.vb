Public Class RegistrarProducto
    ReadOnly _conex As New Conexiones
    ReadOnly _validador As New Validador

    Public ReadOnly Property Conex As Conexiones
        Get
            Return _conex
        End Get
    End Property

    Public ReadOnly Property Validador As Validador
        Get
            Return _validador
        End Get
    End Property

    Private Sub RegistrarProducto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Al cargar el formulario, rellenar el comboBox de tipos de producto
        CargarTiposProductos(cmb_tipo, Conex.LeerTabla("TipoProducto"), "descripcion", "idTipo")
    End Sub

    Private Sub cmd_guardar_Click(sender As Object, e As EventArgs) Handles cmd_guardar.Click
        'Llamar al procedimiento de inserción e informar que fue correcto.
        If Validador.Verificar_vacios(Me.Controls) = Validador.EstadoValidacion.SinErrores Then
            Insertar()
            MsgBox("Se ha guardado la información.", MsgBoxStyle.OkOnly, "¡Éxito!")
        End If
    End Sub

    Private Sub CargarTiposProductos(ByRef combo As ComboBox, ByRef tabla As DataTable, descripcion As String,
                                     pk As String)
        'Sub rutina que rellena el comboBox con los elementos de una dataTable
        cmb_tipo.Items.Clear()
        cmb_tipo.DataSource = tabla
        cmb_tipo.DisplayMember = descripcion
        cmb_tipo.ValueMember = pk
    End Sub

    Private Sub Cmd_cancelar_Click(sender As Object, e As EventArgs) Handles cmd_cancelar.Click
        'Simple funcionalidad del botón cancelar, limpia los campos y vuelve a mostrar la ventana principal
        Close()
    End Sub

    Private Sub Insertar()
        'Sentencia = insert into Producto values (idProducto, 'nombre', idTipo, precio, stock, 'descripción')
        Dim sql As String = ""

        sql = "insert into Producto values"
        sql &= "(" & Conex.Generar_id_consecutivo("Producto", "idProducto") _
        'idProducto, es generado automáticamente y no se repite
        sql &= ", '" & txt_nombre.Text.Trim & "'"       'nombre
        sql &= ", " & cmb_tipo.SelectedValue            'idTipo
        sql &= ", " & Double.Parse(txt_precio.Text.Trim) 'precio
        sql &= ", 0"                                 'stock
        sql &= ", '" & txt_descripcion.Text.Trim & "'"  'descripción
        sql &= ")"

        Conex.Insertar(sql)
    End Sub

    Private Sub txt_precio_MouseHover(sender As Object, e As EventArgs) Handles txt_precio.MouseHover
        toolTip_Precio.SetToolTip(txt_precio, "Recuerde que para precios con centavos, debe utilizar el punto (.)")
    End Sub

    Private Sub RegistrarProducto_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If MessageBox.Show("¿Está seguro que desea cancelar?", "Confirmar cancelación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = Windows.Forms.DialogResult.No Then
            e.Cancel = True
        End If
        Principal.Show()
    End Sub


End Class