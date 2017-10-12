Public Class RegistrarLocalidad
    Dim ReadOnly _conex As New Conexiones

    Public ReadOnly Property Conex As Conexiones
        Get
            Return _conex
        End Get
    End Property

    Private Sub Insertar()
        Dim sql As String = ""
        sql = "insert into Localidad values"
        sql &= "(" & Conex.Generar_id_consecutivo("Localidad", "idLocalidad") _
        'idLocalidad
        sql &= ", '" & txt_nombre.Text.Trim & "'"                   'nombre
        sql &= ", " & cmb_provincia.SelectedValue & ")"            'Combo provincia

        Conex.Insertar(sql)
    End Sub

    Private Sub cmd_guardar_Click(sender As Object, e As EventArgs) Handles cmd_guardar.Click
        Insertar()
        MsgBox("Se ha guardado la información.", MsgBoxStyle.OkOnly, "¡Éxito!")
    End Sub

    Private Sub cmd_cancelar_Click(sender As Object, e As EventArgs) Handles cmd_cancelar.Click
        If _
            MessageBox.Show("Perderá los datos ingresados", "¿Desea cancelar el registro?", MessageBoxButtons.YesNo,
                            MessageBoxIcon.Warning) = Windows.Forms.DialogResult.Yes Then
            Me.Close()
            Principal.Show()
        End If
    End Sub

    Private Sub CargarCombo(ByRef combo As ComboBox, ByRef tabla As DataTable, descripcion As String, pk As String)
        combo.Items.Clear()
        combo.DataSource = tabla
        combo.DisplayMember = descripcion
        combo.ValueMember = pk
    End Sub

    Private Sub RegistrarLocalidad_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarCombo(cmb_provincia, Conex.LeerTabla("Provincia"), "nombre", "id")
    End Sub
End Class