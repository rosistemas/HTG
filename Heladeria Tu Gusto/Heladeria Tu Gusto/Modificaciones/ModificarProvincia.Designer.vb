<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ModificarProvincia
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.grd_Provincia = New System.Windows.Forms.DataGridView()
        Me.grp_modificar_provincia = New System.Windows.Forms.GroupBox()
        Me.txt_nombre = New System.Windows.Forms.TextBox()
        Me.lbl_nuevo_nombre = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lbl_guardar = New System.Windows.Forms.Label()
        Me.cmd_cancelar = New System.Windows.Forms.Button()
        Me.cmd_guardar = New System.Windows.Forms.Button()
        Me.id_provincia = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nombre_provincia = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.grd_Provincia, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grp_modificar_provincia.SuspendLayout()
        Me.SuspendLayout()
        '
        'grd_Provincia
        '
        Me.grd_Provincia.AllowUserToAddRows = False
        Me.grd_Provincia.AllowUserToDeleteRows = False
        Me.grd_Provincia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grd_Provincia.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id_provincia, Me.nombre_provincia})
        Me.grd_Provincia.Location = New System.Drawing.Point(7, 30)
        Me.grd_Provincia.Name = "grd_Provincia"
        Me.grd_Provincia.ReadOnly = True
        Me.grd_Provincia.Size = New System.Drawing.Size(244, 118)
        Me.grd_Provincia.TabIndex = 0
        '
        'grp_modificar_provincia
        '
        Me.grp_modificar_provincia.Controls.Add(Me.txt_nombre)
        Me.grp_modificar_provincia.Controls.Add(Me.lbl_nuevo_nombre)
        Me.grp_modificar_provincia.Controls.Add(Me.grd_Provincia)
        Me.grp_modificar_provincia.Location = New System.Drawing.Point(12, 12)
        Me.grp_modificar_provincia.Name = "grp_modificar_provincia"
        Me.grp_modificar_provincia.Size = New System.Drawing.Size(264, 215)
        Me.grp_modificar_provincia.TabIndex = 23
        Me.grp_modificar_provincia.TabStop = False
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
        Me.lbl_nuevo_nombre.AutoSize = True
        Me.lbl_nuevo_nombre.Location = New System.Drawing.Point(6, 180)
        Me.lbl_nuevo_nombre.Name = "lbl_nuevo_nombre"
        Me.lbl_nuevo_nombre.Size = New System.Drawing.Size(80, 13)
        Me.lbl_nuevo_nombre.TabIndex = 1
        Me.lbl_nuevo_nombre.Text = "Nuevo nombre:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(216, 234)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(49, 13)
        Me.Label1.TabIndex = 27
        Me.Label1.Text = "Cancelar"
        '
        'lbl_guardar
        '
        Me.lbl_guardar.AutoSize = True
        Me.lbl_guardar.Location = New System.Drawing.Point(12, 234)
        Me.lbl_guardar.Name = "lbl_guardar"
        Me.lbl_guardar.Size = New System.Drawing.Size(87, 13)
        Me.lbl_guardar.TabIndex = 26
        Me.lbl_guardar.Text = "Guardar cambios"
        '
        'cmd_cancelar
        '
        Me.cmd_cancelar.Image = Global.Heladeria_Tu_Gusto.My.Resources.Resources.icons8_Delete_40
        Me.cmd_cancelar.Location = New System.Drawing.Point(201, 250)
        Me.cmd_cancelar.Name = "cmd_cancelar"
        Me.cmd_cancelar.Size = New System.Drawing.Size(75, 64)
        Me.cmd_cancelar.TabIndex = 6
        Me.cmd_cancelar.UseVisualStyleBackColor = True
        '
        'cmd_guardar
        '
        Me.cmd_guardar.Image = Global.Heladeria_Tu_Gusto.My.Resources.Resources.icons8_Save_as_64
        Me.cmd_guardar.Location = New System.Drawing.Point(12, 250)
        Me.cmd_guardar.Name = "cmd_guardar"
        Me.cmd_guardar.Size = New System.Drawing.Size(75, 64)
        Me.cmd_guardar.TabIndex = 5
        Me.cmd_guardar.UseVisualStyleBackColor = True
        '
        'id_provincia
        '
        Me.id_provincia.HeaderText = "ID Provincia"
        Me.id_provincia.Name = "id_provincia"
        Me.id_provincia.ReadOnly = True
        Me.id_provincia.Visible = False
        '
        'nombre_provincia
        '
        Me.nombre_provincia.HeaderText = "Nombre provincia"
        Me.nombre_provincia.Name = "nombre_provincia"
        Me.nombre_provincia.ReadOnly = True
        Me.nombre_provincia.Width = 200
        '
        'ModificarProvincia
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(281, 324)
        Me.Controls.Add(Me.cmd_cancelar)
        Me.Controls.Add(Me.cmd_guardar)
        Me.Controls.Add(Me.grp_modificar_provincia)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lbl_guardar)
        Me.Name = "ModificarProvincia"
        Me.Text = "ModificarProvincia"
        CType(Me.grd_Provincia, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grp_modificar_provincia.ResumeLayout(False)
        Me.grp_modificar_provincia.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents grd_Provincia As System.Windows.Forms.DataGridView
    Friend WithEvents grp_modificar_provincia As System.Windows.Forms.GroupBox
    Friend WithEvents txt_nombre As System.Windows.Forms.TextBox
    Friend WithEvents lbl_nuevo_nombre As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lbl_guardar As System.Windows.Forms.Label
    Friend WithEvents cmd_cancelar As System.Windows.Forms.Button
    Friend WithEvents cmd_guardar As System.Windows.Forms.Button
    Friend WithEvents id_provincia As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents nombre_provincia As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
