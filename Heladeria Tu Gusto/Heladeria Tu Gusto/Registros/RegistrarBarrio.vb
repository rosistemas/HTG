Imports Heladeria_Tu_Gusto

Public Class RegistrarBarrio
    Dim ReadOnly _conex As New Conexiones

    Public ReadOnly Property Conex As Conexiones
        Get
            Return _conex
        End Get
    End Property

    Private Sub Insertar()
        Dim sql As String = ""
        sql = "insert into Barrio values"
        sql &= "(" & Conex.Generar_id_consecutivo("Barrio", "id")                               'idBarrio
        sql &= ", '" & txt_nombre.Text.Trim & "'"                   'nombre
        sql &= ", " & cmb_localidad.SelectedValue & ")"            'Combo localidad

        Conex.Insertar(sql)
    End Sub


    Private Sub cmd_guardar_Click(sender As Object, e As EventArgs) Handles cmd_guardar.Click
        Me.Insertar()
        MsgBox("Se ha guardado la información.", MsgBoxStyle.OkOnly, "¡Éxito!")
    End Sub

    Private Sub cmd_cancelar_Click(sender As Object, e As EventArgs) Handles cmd_cancelar.Click
        'Simple funcionalidad del botón cancelar, limpia los campos y vuelve a mostrar la ventana principal
        If _
            MessageBox.Show("Perderá los datos ingresados", "¿Desea cancelar el registro?", MessageBoxButtons.YesNo,
                            MessageBoxIcon.Warning) = Windows.Forms.DialogResult.Yes Then
            Me.Close()
            Principal.Show()
        End If
    End Sub

    Private Sub CargarCombo(ByRef combo As ComboBox, ByRef tabla As DataTable, descripcion As String, pk As String)
        'Sub rutina que rellena el comboBox con los elementos de una dataTable
        combo.Items.Clear()
        combo.DataSource = tabla
        combo.DisplayMember = descripcion
        combo.ValueMember = pk
    End Sub

    Private Sub RegistrarBarrio_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarCombo(cmb_localidad, Conex.LeerTabla("Localidad"), "nombre", "id")
    End Sub
End Class