Public Class ModificarBarrio



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
   
    Private Sub cargarGrilla()
        Dim sql As String
        sql = "select * from Barrio"

        Dim tabla As New DataTable
        tabla = conex.consultar(sql)
        Me.grd_Barrios.Rows.Clear()
        For i = 0 To tabla.Rows.Count - 1
            Me.grd_Barrios.Rows.Add()
            Me.grd_Barrios.Rows(i).Cells("idBarrio").Value = tabla.Rows(i)("id")
            Me.grd_Barrios.Rows(i).Cells("nombre_barrio").Value = tabla.Rows(i)("nombre")
            Me.grd_Barrios.Rows(i).Cells("id_localidad").Value = tabla.Rows(i)("idLocalidad")
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

    Private Sub grd_Barrios_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles grd_Barrios.CellContentClick
        Dim tabla As New DataTable
        Dim sql As String
        Dim idlocalidadString As String

        sql = "select * from Barrio where id = " & grd_Barrios.CurrentRow.Cells(0).Value

        tabla = conex.consultar(sql)
        Me.txt_nombre.Text = tabla.Rows(0)("nombre")
        idlocalidadString = tabla.Rows(0)("idLocalidad")
        sql = "select * from Localidad where id = " & idlocalidadString
        tabla = conex.consultar(sql)
        Me.txt_localidad.Text = tabla.Rows(0)("nombre")
    End Sub
End Class
