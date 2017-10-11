<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Modificar_Localidad
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.grd_Localidad = New System.Windows.Forms.DataGridView()
        Me.IdLocalidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nombre_localidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.id_provincia = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txt_nombre = New System.Windows.Forms.TextBox()
        Me.txt_provincia = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.button_guardar = New System.Windows.Forms.Button()
        Me.button_cancelar = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        CType(Me.grd_Localidad, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.grd_Localidad)
        Me.GroupBox1.Location = New System.Drawing.Point(2, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(285, 145)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Seleccionar Localidad"
        '
        'grd_Localidad
        '
        Me.grd_Localidad.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grd_Localidad.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdLocalidad, Me.nombre_localidad, Me.id_provincia})
        Me.grd_Localidad.Location = New System.Drawing.Point(17, 19)
        Me.grd_Localidad.Name = "grd_Localidad"
        Me.grd_Localidad.Size = New System.Drawing.Size(254, 96)
        Me.grd_Localidad.TabIndex = 7
        '
        'IdLocalidad
        '
        Me.IdLocalidad.HeaderText = "ID LOCALIDAD"
        Me.IdLocalidad.Name = "IdLocalidad"
        '
        'nombre_localidad
        '
        Me.nombre_localidad.HeaderText = "NOMBRE"
        Me.nombre_localidad.Name = "nombre_localidad"
        '
        'id_provincia
        '
        Me.id_provincia.HeaderText = "Id Provincia"
        Me.id_provincia.Name = "id_provincia"
        Me.id_provincia.Visible = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txt_nombre)
        Me.GroupBox2.Controls.Add(Me.txt_provincia)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Location = New System.Drawing.Point(2, 173)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(285, 76)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "DatosLocalidad"
        '
        'txt_nombre
        '
        Me.txt_nombre.Location = New System.Drawing.Point(98, 45)
        Me.txt_nombre.Name = "txt_nombre"
        Me.txt_nombre.Size = New System.Drawing.Size(143, 20)
        Me.txt_nombre.TabIndex = 6
        '
        'txt_provincia
        '
        Me.txt_provincia.Location = New System.Drawing.Point(98, 19)
        Me.txt_provincia.Name = "txt_provincia"
        Me.txt_provincia.Size = New System.Drawing.Size(143, 20)
        Me.txt_provincia.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(10, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(54, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Provincia:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(10, 48)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(47, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Nombre:"
        '
        'button_guardar
        '
        Me.button_guardar.Image = Global.Heladeria_Tu_Gusto.My.Resources.Resources.icons8_Save_as_64
        Me.button_guardar.Location = New System.Drawing.Point(12, 303)
        Me.button_guardar.Name = "button_guardar"
        Me.button_guardar.Size = New System.Drawing.Size(75, 64)
        Me.button_guardar.TabIndex = 3
        Me.button_guardar.UseVisualStyleBackColor = True
        '
        'button_cancelar
        '
        Me.button_cancelar.Image = Global.Heladeria_Tu_Gusto.My.Resources.Resources.icons8_Delete_40
        Me.button_cancelar.Location = New System.Drawing.Point(147, 303)
        Me.button_cancelar.Name = "button_cancelar"
        Me.button_cancelar.Size = New System.Drawing.Size(75, 64)
        Me.button_cancelar.TabIndex = 4
        Me.button_cancelar.UseVisualStyleBackColor = True
        '
        'Modificar_Localidad
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(319, 387)
        Me.Controls.Add(Me.button_cancelar)
        Me.Controls.Add(Me.button_guardar)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Modificar_Localidad"
        Me.Text = "Modificar_Localidad"
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.grd_Localidad, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents grd_Localidad As System.Windows.Forms.DataGridView
    Friend WithEvents IdLocalidad As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents nombre_localidad As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents id_provincia As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents txt_nombre As System.Windows.Forms.TextBox
    Friend WithEvents txt_provincia As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents button_guardar As System.Windows.Forms.Button
    Friend WithEvents button_cancelar As System.Windows.Forms.Button
End Class
