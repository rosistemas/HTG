Public Class Modificar_Localidad


    Private conex As New Conexiones

    Private Sub Modificar_Provincia_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.cargarGrilla()
    End Sub



    'Private Sub button_guardar_Click(sender As Object, e As EventArgs)
    '    If MessageBox.Show("¿Está seguro de querer modificar los datos de la localidad seleccionada?", "Precaución", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = Windows.Forms.DialogResult.Yes Then
    '        Me.modificar()
    '        Me.cargarGrilla()
    '    Else
    '        MessageBox.Show("Los datos no se han alterado.", "Cancelado", MessageBoxButtons.OK, MessageBoxIcon.Information)
    '    End If
    'End Sub

    Private Sub button_cancel_Click(sender As Object, e As EventArgs) Handles button_cancelar.Click
        If MessageBox.Show("Perderá los datos ingresados", "¿Desea cancelar la modificación?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = Windows.Forms.DialogResult.Yes Then
            Me.Close()
            Principal.Show()
        End If
    End Sub
    Private Sub grd_Localidad_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles grd_Localidad.CellDoubleClick
        Dim tabla As New DataTable
        Dim sql As String
        Dim idprovinciaString As String

        sql = "select * from Localidad where id = " & grd_Localidad.CurrentRow.Cells(0).Value

        tabla = conex.consultar(sql)
        Me.txt_nombre.Text = tabla.Rows(0)("nombre")
        idprovinciaString = tabla.Rows(0)("idProvincia")
        sql = "select * from Provincia where id = " & idprovinciaString
        tabla = conex.consultar(sql)
        Me.txt_provincia.Text = tabla.Rows(0)("nombre")

    End Sub
    Private Sub cargarGrilla()
        Dim sql As String
        sql = "select * from Localidad"

        Dim tabla As New DataTable
        tabla = conex.consultar(sql)
        Me.grd_Localidad.Rows.Clear()
        For i = 0 To tabla.Rows.Count - 1
            Me.grd_Localidad.Rows.Add()
            Me.grd_Localidad.Rows(i).Cells("idLocalidad").Value = tabla.Rows(i)("id")
            Me.grd_Localidad.Rows(i).Cells("nombre_Localidad").Value = tabla.Rows(i)("nombre")
            Me.grd_Localidad.Rows(i).Cells("id_provincia").Value = tabla.Rows(i)("idProvincia")
        Next

    End Sub




    Private Sub modificar()
        Dim tabla As New DataTable
        Dim sql As String
        sql = "select id from Localidad l where l.nombre = " & Integer.Parse(txt_nombre.Text.Trim)
        tabla = conex.consultar(sql)
        Dim idaux As Integer = tabla.Rows(0)("id")
        sql = "update Localidad set nombre = " & Integer.Parse(txt_nombre.Text.Trim) & " where id =" & idaux
        conex.insertar(sql)
    End Sub




    Private Sub button_guardar_Click_1(sender As Object, e As EventArgs) Handles button_guardar.Click
        If MessageBox.Show("¿Está seguro de querer modificar los datos de la localidad seleccionada?", "Precaución", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = Windows.Forms.DialogResult.Yes Then
            Me.modificar()
            Me.cargarGrilla()
        Else
            MessageBox.Show("Los datos no se han alterado.", "Cancelado", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub
End Class