<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ModificarProvincia
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ModificarProvincia))
        Me.grd_Provincia = New System.Windows.Forms.DataGridView()
        Me.idProvincia = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nombre_provincia = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.grp_modificar_provincia = New System.Windows.Forms.GroupBox()
        Me.txt_nombre = New System.Windows.Forms.TextBox()
        Me.lbl_nuevo_nombre = New System.Windows.Forms.Label()
        Me.button_cancel = New System.Windows.Forms.Button()
        Me.button_guardar = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lbl_guardar = New System.Windows.Forms.Label()
        CType(Me.grd_Provincia,System.ComponentModel.ISupportInitialize).BeginInit
        Me.grp_modificar_provincia.SuspendLayout
        Me.SuspendLayout
        '
        'grd_Provincia
        '
        Me.grd_Provincia.AllowUserToAddRows = false
        Me.grd_Provincia.AllowUserToDeleteRows = false
        Me.grd_Provincia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grd_Provincia.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.idProvincia, Me.nombre_provincia})
        Me.grd_Provincia.Location = New System.Drawing.Point(7, 30)
        Me.grd_Provincia.Name = "grd_Provincia"
        Me.grd_Provincia.ReadOnly = true
        Me.grd_Provincia.Size = New System.Drawing.Size(244, 118)
        Me.grd_Provincia.TabIndex = 0
        '
        'idProvincia
        '
        Me.idProvincia.HeaderText = "ID Provincia"
        Me.idProvincia.Name = "idProvincia"
        Me.idProvincia.ReadOnly = true
        Me.idProvincia.Visible = false
        '
        'nombre_provincia
        '
        Me.nombre_provincia.HeaderText = "Nombre provincia"
        Me.nombre_provincia.Name = "nombre_provincia"
        Me.nombre_provincia.ReadOnly = true
        Me.nombre_provincia.Width = 200
        '
        'grp_modificar_provincia
        '
        Me.grp_modificar_provincia.Controls.Add(Me.txt_nombre)
        Me.grp_modificar_provincia.Controls.Add(Me.lbl_nuevo_nombre)
        Me.grp_modificar_provincia.Controls.Add(Me.grd_Provincia)
        Me.grp_modificar_provincia.Location = New System.Drawing.Point(12, 12)
        Me.grp_modificar_provincia.Name = "grp_modificar_provincia"
        Me.grp_modificar_provincia.Size = New System.Drawing.Size(264, 215)
        Me.grp_modificar_provincia.TabIndex = 1
        Me.grp_modificar_provincia.TabStop = false
        Me.grp_modificar_provincia.Text = "Seleccionar provincia"
        '
        'txt_nombre
        '
        Me.txt_nombre.Location = New System.Drawing.Point(92, 177)
        Me.txt_nombre.Name = "txt_nombre"
        Me.txt_nombre.Size = New System.Drawing.Size(159, 20)
        Me.txt_nombre.TabIndex = 3
        '
        'lbl_nuevo_nombre
        '
        Me.lbl_nuevo_nombre.AutoSize = true
        Me.lbl_nuevo_nombre.Location = New System.Drawing.Point(6, 180)
        Me.lbl_nuevo_nombre.Name = "lbl_nuevo_nombre"
        Me.lbl_nuevo_nombre.Size = New System.Drawing.Size(80, 13)
        Me.lbl_nuevo_nombre.TabIndex = 1
        Me.lbl_nuevo_nombre.Text = "Nuevo nombre:"
        '
        'button_cancel
        '
        Me.button_cancel.Image = Global.Heladeria_Tu_Gusto.My.Resources.Resources.icons8_Delete_40
        Me.button_cancel.Location = New System.Drawing.Point(201, 250)
        Me.button_cancel.Name = "button_cancel"
        Me.button_cancel.Size = New System.Drawing.Size(75, 69)
        Me.button_cancel.TabIndex = 4
        Me.button_cancel.UseVisualStyleBackColor = true
        '
        'button_guardar
        '
        Me.button_guardar.Image = Global.Heladeria_Tu_Gusto.My.Resources.Resources.icons8_Save_as_64
        Me.button_guardar.Location = New System.Drawing.Point(12, 250)
        Me.button_guardar.Name = "button_guardar"
        Me.button_guardar.Size = New System.Drawing.Size(87, 69)
        Me.button_guardar.TabIndex = 3
        Me.button_guardar.UseVisualStyleBackColor = true
        '
        'Label1
        '
        Me.Label1.AutoSize = true
        Me.Label1.Location = New System.Drawing.Point(216, 234)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(49, 13)
        Me.Label1.TabIndex = 22
        Me.Label1.Text = "Cancelar"
        '
        'lbl_guardar
        '
        Me.lbl_guardar.AutoSize = true
        Me.lbl_guardar.Location = New System.Drawing.Point(12, 234)
        Me.lbl_guardar.Name = "lbl_guardar"
        Me.lbl_guardar.Size = New System.Drawing.Size(87, 13)
        Me.lbl_guardar.TabIndex = 21
        Me.lbl_guardar.Text = "Guardar cambios"
        '
        'ModificarProvincia
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(281, 324)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lbl_guardar)
        Me.Controls.Add(Me.button_cancel)
        Me.Controls.Add(Me.button_guardar)
        Me.Controls.Add(Me.grp_modificar_provincia)
        Me.Icon = CType(resources.GetObject("$this.Icon"),System.Drawing.Icon)
        Me.Name = "ModificarProvincia"
        Me.Text = "Modificar provincia"
        CType(Me.grd_Provincia,System.ComponentModel.ISupportInitialize).EndInit
        Me.grp_modificar_provincia.ResumeLayout(false)
        Me.grp_modificar_provincia.PerformLayout
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub
    Friend WithEvents grd_Provincia As System.Windows.Forms.DataGridView
    Friend WithEvents grp_modificar_provincia As System.Windows.Forms.GroupBox
    Friend WithEvents lbl_nuevo_nombre As System.Windows.Forms.Label
    Friend WithEvents txt_nombre As System.Windows.Forms.TextBox
    Friend WithEvents button_cancel As System.Windows.Forms.Button
    Friend WithEvents button_guardar As System.Windows.Forms.Button
    Friend WithEvents idProvincia As DataGridViewTextBoxColumn
    Friend WithEvents nombre_provincia As DataGridViewTextBoxColumn
    Friend WithEvents Label1 As Label
    Friend WithEvents lbl_guardar As Label

End Class
