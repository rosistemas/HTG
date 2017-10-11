<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Modificar_Provincia
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
        Me.grd_Provincia = New System.Windows.Forms.DataGridView()
        Me.idProvincia = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nombre_provincia = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.button_cancel = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txt_idProvincia = New System.Windows.Forms.TextBox()
        Me.txt_nombre = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.button_guardar = New System.Windows.Forms.Button()
        CType(Me.grd_Provincia, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'grd_Provincia
        '
        Me.grd_Provincia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grd_Provincia.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.idProvincia, Me.nombre_provincia})
        Me.grd_Provincia.Location = New System.Drawing.Point(48, 16)
        Me.grd_Provincia.Name = "grd_Provincia"
        Me.grd_Provincia.Size = New System.Drawing.Size(246, 118)
        Me.grd_Provincia.TabIndex = 0
        '
        'idProvincia
        '
        Me.idProvincia.HeaderText = "ID Provincia"
        Me.idProvincia.Name = "idProvincia"
        '
        'nombre_provincia
        '
        Me.nombre_provincia.HeaderText = "Nombre Provincia"
        Me.nombre_provincia.Name = "nombre_provincia"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.grd_Provincia)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(334, 154)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Seleccionar Provincia"
        '
        'button_cancel
        '
        Me.button_cancel.Image = Global.Heladeria_Tu_Gusto.My.Resources.Resources.icons8_Delete_40
        Me.button_cancel.Location = New System.Drawing.Point(231, 250)
        Me.button_cancel.Name = "button_cancel"
        Me.button_cancel.Size = New System.Drawing.Size(75, 69)
        Me.button_cancel.TabIndex = 4
        Me.button_cancel.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(178, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Nombre"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txt_idProvincia)
        Me.GroupBox2.Controls.Add(Me.txt_nombre)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 172)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(334, 66)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Datos Provincia"
        '
        'txt_idProvincia
        '
        Me.txt_idProvincia.Location = New System.Drawing.Point(29, 16)
        Me.txt_idProvincia.Name = "txt_idProvincia"
        Me.txt_idProvincia.Size = New System.Drawing.Size(100, 20)
        Me.txt_idProvincia.TabIndex = 4
        '
        'txt_nombre
        '
        Me.txt_nombre.Location = New System.Drawing.Point(228, 16)
        Me.txt_nombre.Name = "txt_nombre"
        Me.txt_nombre.Size = New System.Drawing.Size(100, 20)
        Me.txt_nombre.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(3, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(19, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Id "
        '
        'button_guardar
        '
        Me.button_guardar.Image = Global.Heladeria_Tu_Gusto.My.Resources.Resources.icons8_Save_as_64
        Me.button_guardar.Location = New System.Drawing.Point(27, 250)
        Me.button_guardar.Name = "button_guardar"
        Me.button_guardar.Size = New System.Drawing.Size(87, 69)
        Me.button_guardar.TabIndex = 3
        Me.button_guardar.UseVisualStyleBackColor = True
        '
        'Modificar_Provincia
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(360, 343)
        Me.Controls.Add(Me.button_cancel)
        Me.Controls.Add(Me.button_guardar)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Modificar_Provincia"
        Me.Text = "Modificar_Provincia"
        CType(Me.grd_Provincia, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents grd_Provincia As System.Windows.Forms.DataGridView
    Friend WithEvents idProvincia As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents nombre_provincia As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txt_idProvincia As System.Windows.Forms.TextBox
    Friend WithEvents txt_nombre As System.Windows.Forms.TextBox
    Friend WithEvents button_cancel As System.Windows.Forms.Button
    Friend WithEvents button_guardar As System.Windows.Forms.Button


    
    
    
End Class
