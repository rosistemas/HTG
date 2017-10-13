<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ModificarLocalidad
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ModificarLocalidad))
        Me.grp_localidades = New System.Windows.Forms.GroupBox()
        Me.grd_Localidad = New System.Windows.Forms.DataGridView()
        Me.txt_nombre_localidad = New System.Windows.Forms.TextBox()
        Me.lbl_provincias = New System.Windows.Forms.Label()
        Me.lbl_nuevo_nombre = New System.Windows.Forms.Label()
        Me.cmd_guardar = New System.Windows.Forms.Button()
        Me.cmd_cancelar = New System.Windows.Forms.Button()
        Me.cmb_provincias = New System.Windows.Forms.ComboBox()
        Me.Id_localidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nombre_localidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nombre_provincia = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.id_provincia = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.grp_datos_localidad = New System.Windows.Forms.GroupBox()
        Me.lbl_cancelar = New System.Windows.Forms.Label()
        Me.lbl_guardar = New System.Windows.Forms.Label()
        Me.grp_localidades.SuspendLayout
        CType(Me.grd_Localidad,System.ComponentModel.ISupportInitialize).BeginInit
        Me.grp_datos_localidad.SuspendLayout
        Me.SuspendLayout
        '
        'grp_localidades
        '
        Me.grp_localidades.Controls.Add(Me.grd_Localidad)
        Me.grp_localidades.Location = New System.Drawing.Point(12, 12)
        Me.grp_localidades.Name = "grp_localidades"
        Me.grp_localidades.Size = New System.Drawing.Size(361, 195)
        Me.grp_localidades.TabIndex = 1
        Me.grp_localidades.TabStop = false
        Me.grp_localidades.Text = "Seleccionar Localidad"
        '
        'grd_Localidad
        '
        Me.grd_Localidad.AllowUserToAddRows = false
        Me.grd_Localidad.AllowUserToDeleteRows = false
        Me.grd_Localidad.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grd_Localidad.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Id_localidad, Me.nombre_localidad, Me.nombre_provincia, Me.id_provincia})
        Me.grd_Localidad.Location = New System.Drawing.Point(6, 18)
        Me.grd_Localidad.Name = "grd_Localidad"
        Me.grd_Localidad.ReadOnly = true
        Me.grd_Localidad.Size = New System.Drawing.Size(348, 171)
        Me.grd_Localidad.TabIndex = 7
        '
        'txt_nombre_localidad
        '
        Me.txt_nombre_localidad.Location = New System.Drawing.Point(100, 45)
        Me.txt_nombre_localidad.Name = "txt_nombre_localidad"
        Me.txt_nombre_localidad.Size = New System.Drawing.Size(150, 20)
        Me.txt_nombre_localidad.TabIndex = 6
        '
        'lbl_provincias
        '
        Me.lbl_provincias.AutoSize = true
        Me.lbl_provincias.Location = New System.Drawing.Point(40, 21)
        Me.lbl_provincias.Name = "lbl_provincias"
        Me.lbl_provincias.Size = New System.Drawing.Size(54, 13)
        Me.lbl_provincias.TabIndex = 3
        Me.lbl_provincias.Text = "Provincia:"
        '
        'lbl_nuevo_nombre
        '
        Me.lbl_nuevo_nombre.AutoSize = true
        Me.lbl_nuevo_nombre.Location = New System.Drawing.Point(14, 48)
        Me.lbl_nuevo_nombre.Name = "lbl_nuevo_nombre"
        Me.lbl_nuevo_nombre.Size = New System.Drawing.Size(80, 13)
        Me.lbl_nuevo_nombre.TabIndex = 4
        Me.lbl_nuevo_nombre.Text = "Nuevo nombre:"
        '
        'cmd_guardar
        '
        Me.cmd_guardar.Image = Global.Heladeria_Tu_Gusto.My.Resources.Resources.icons8_Save_as_64
        Me.cmd_guardar.Location = New System.Drawing.Point(396, 137)
        Me.cmd_guardar.Name = "cmd_guardar"
        Me.cmd_guardar.Size = New System.Drawing.Size(75, 64)
        Me.cmd_guardar.TabIndex = 3
        Me.cmd_guardar.UseVisualStyleBackColor = true
        '
        'cmd_cancelar
        '
        Me.cmd_cancelar.Image = Global.Heladeria_Tu_Gusto.My.Resources.Resources.icons8_Delete_40
        Me.cmd_cancelar.Location = New System.Drawing.Point(572, 137)
        Me.cmd_cancelar.Name = "cmd_cancelar"
        Me.cmd_cancelar.Size = New System.Drawing.Size(75, 64)
        Me.cmd_cancelar.TabIndex = 4
        Me.cmd_cancelar.UseVisualStyleBackColor = true
        '
        'cmb_provincias
        '
        Me.cmb_provincias.FormattingEnabled = true
        Me.cmb_provincias.Location = New System.Drawing.Point(100, 18)
        Me.cmb_provincias.Name = "cmb_provincias"
        Me.cmb_provincias.Size = New System.Drawing.Size(150, 21)
        Me.cmb_provincias.TabIndex = 7
        '
        'Id_localidad
        '
        Me.Id_localidad.HeaderText = "ID LOCALIDAD"
        Me.Id_localidad.Name = "Id_localidad"
        Me.Id_localidad.ReadOnly = true
        Me.Id_localidad.Visible = false
        '
        'nombre_localidad
        '
        Me.nombre_localidad.HeaderText = "Localidad"
        Me.nombre_localidad.Name = "nombre_localidad"
        Me.nombre_localidad.ReadOnly = true
        Me.nombre_localidad.Width = 150
        '
        'nombre_provincia
        '
        Me.nombre_provincia.HeaderText = "Provincia"
        Me.nombre_provincia.Name = "nombre_provincia"
        Me.nombre_provincia.ReadOnly = true
        Me.nombre_provincia.Width = 150
        '
        'id_provincia
        '
        Me.id_provincia.HeaderText = "Id Provincia"
        Me.id_provincia.Name = "id_provincia"
        Me.id_provincia.ReadOnly = true
        Me.id_provincia.Visible = false
        '
        'grp_datos_localidad
        '
        Me.grp_datos_localidad.Controls.Add(Me.cmb_provincias)
        Me.grp_datos_localidad.Controls.Add(Me.txt_nombre_localidad)
        Me.grp_datos_localidad.Controls.Add(Me.lbl_provincias)
        Me.grp_datos_localidad.Controls.Add(Me.lbl_nuevo_nombre)
        Me.grp_datos_localidad.Location = New System.Drawing.Point(379, 12)
        Me.grp_datos_localidad.Name = "grp_datos_localidad"
        Me.grp_datos_localidad.Size = New System.Drawing.Size(268, 76)
        Me.grp_datos_localidad.TabIndex = 2
        Me.grp_datos_localidad.TabStop = false
        Me.grp_datos_localidad.Text = "DatosLocalidad"
        '
        'lbl_cancelar
        '
        Me.lbl_cancelar.AutoSize = true
        Me.lbl_cancelar.Location = New System.Drawing.Point(585, 121)
        Me.lbl_cancelar.Name = "lbl_cancelar"
        Me.lbl_cancelar.Size = New System.Drawing.Size(49, 13)
        Me.lbl_cancelar.TabIndex = 22
        Me.lbl_cancelar.Text = "Cancelar"
        '
        'lbl_guardar
        '
        Me.lbl_guardar.AutoSize = true
        Me.lbl_guardar.Location = New System.Drawing.Point(390, 121)
        Me.lbl_guardar.Name = "lbl_guardar"
        Me.lbl_guardar.Size = New System.Drawing.Size(87, 13)
        Me.lbl_guardar.TabIndex = 21
        Me.lbl_guardar.Text = "Guardar cambios"
        '
        'ModificarLocalidad
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(659, 212)
        Me.Controls.Add(Me.lbl_cancelar)
        Me.Controls.Add(Me.lbl_guardar)
        Me.Controls.Add(Me.cmd_cancelar)
        Me.Controls.Add(Me.cmd_guardar)
        Me.Controls.Add(Me.grp_datos_localidad)
        Me.Controls.Add(Me.grp_localidades)
        Me.Icon = CType(resources.GetObject("$this.Icon"),System.Drawing.Icon)
        Me.Name = "ModificarLocalidad"
        Me.Text = "Modificar localidad"
        Me.grp_localidades.ResumeLayout(false)
        CType(Me.grd_Localidad,System.ComponentModel.ISupportInitialize).EndInit
        Me.grp_datos_localidad.ResumeLayout(false)
        Me.grp_datos_localidad.PerformLayout
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub
    Friend WithEvents grp_localidades As System.Windows.Forms.GroupBox
    Friend WithEvents grd_Localidad As System.Windows.Forms.DataGridView
    Friend WithEvents txt_nombre_localidad As System.Windows.Forms.TextBox
    Friend WithEvents lbl_provincias As System.Windows.Forms.Label
    Friend WithEvents lbl_nuevo_nombre As System.Windows.Forms.Label
    Friend WithEvents cmd_guardar As System.Windows.Forms.Button
    Friend WithEvents cmd_cancelar As System.Windows.Forms.Button
    Friend WithEvents cmb_provincias As ComboBox
    Friend WithEvents Id_localidad As DataGridViewTextBoxColumn
    Friend WithEvents nombre_localidad As DataGridViewTextBoxColumn
    Friend WithEvents nombre_provincia As DataGridViewTextBoxColumn
    Friend WithEvents id_provincia As DataGridViewTextBoxColumn
    Friend WithEvents grp_datos_localidad As GroupBox
    Friend WithEvents lbl_cancelar As Label
    Friend WithEvents lbl_guardar As Label
End Class
