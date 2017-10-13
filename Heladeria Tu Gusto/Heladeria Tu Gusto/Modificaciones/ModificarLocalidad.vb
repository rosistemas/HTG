Public Class ModificarLocalidad

    Dim ReadOnly _conex As New Conexiones
    Dim Private _localidadSeleccionada As Integer
    Dim ReadOnly _asistente As New AsistenteFormulario

    Public ReadOnly Property Conex As Conexiones
        Get
            Return _conex
        End Get
    End Property

    Public Property LocalidadSeleccionada As Integer
        Get
            Return _localidadSeleccionada
        End Get
        Set(value As Integer)
            _localidadSeleccionada = value
        End Set
    End Property

    Public ReadOnly Property Asistente As AsistenteFormulario
        Get
            Return _asistente
        End Get
    End Property

    Private Sub Modificar_Provincia_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarGrilla()
    End Sub

    Private Sub cmd_cancelar_Click(sender As Object, e As EventArgs) Handles cmd_cancelar.Click
        If MessageBox.Show("Perderá los datos ingresados", "¿Desea cancelar la modificación?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = Windows.Forms.DialogResult.Yes Then
            Me.Close()
            Principal.Show()
        End If
    End Sub

    Private Sub grd_Localidad_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles grd_Localidad.CellDoubleClick
        txt_nombre_localidad.Text = grd_Localidad.CurrentRow.Cells("nombre_localidad").Value
        LocalidadSeleccionada = grd_Localidad.CurrentRow.Cells("id_localidad").Value
        Asistente.CargarCombo(cmb_provincias, Conex.LeerTabla("Provincia"),"nombre","id")
        cmb_provincias.SelectedValue = grd_Localidad.CurrentRow.Cells("id_provincia").Value
    End Sub

    Private Sub CargarGrilla()
        Dim sql As String
        sql = "select *, p.nombre as nombre_provincia from Localidad l join Provincia p on l.idProvincia = p.id"

        Dim tabla As New DataTable
        tabla = Conex.Consultar(sql)
        grd_Localidad.Rows.Clear()

        For i = 0 To tabla.Rows.Count - 1
            grd_Localidad.Rows.Add(tabla.Rows(i)("id"), tabla.Rows(i)("nombre"), tabla.Rows(i)("nombre_provincia"),tabla.Rows(i)("idProvincia"))
        Next
    End Sub

    Private Sub Modificar()
        Dim sql As String
        sql = "update Localidad set nombre = '" & txt_nombre_localidad.Text.Trim & "'"
        sql &= ", idProvincia = " & Integer.Parse(cmb_provincias.SelectedValue)
        sql &= " where id = " & LocalidadSeleccionada
        Conex.Insertar(sql)
    End Sub
    
    Private Sub cmd_guardar_Click(sender As Object, e As EventArgs) Handles cmd_guardar.Click
        If MessageBox.Show("¿Está seguro de querer modificar los datos de la localidad seleccionada?", "Precaución", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = Windows.Forms.DialogResult.Yes Then
            Modificar()
            CargarGrilla()
        Else
            MessageBox.Show("Los datos no se han alterado.", "Cancelado", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub
End Class