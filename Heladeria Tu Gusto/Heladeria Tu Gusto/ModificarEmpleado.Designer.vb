<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ModificarEmpleado
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ModificarEmpleado))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lbl_guardar = New System.Windows.Forms.Label()
        Me.grp_datos = New System.Windows.Forms.GroupBox()
        Me.txt_nombre = New System.Windows.Forms.TextBox()
        Me.cmb_tipo_documento = New System.Windows.Forms.ComboBox()
        Me.date_fecha_ingreso = New System.Windows.Forms.DateTimePicker()
        Me.txt_apellido = New System.Windows.Forms.TextBox()
        Me.cmb_barrio = New System.Windows.Forms.ComboBox()
        Me.lbl_tipo_documento = New System.Windows.Forms.Label()
        Me.lbl_fecha_nacimiento = New System.Windows.Forms.Label()
        Me.lbl_fecha_ingreso = New System.Windows.Forms.Label()
        Me.lbl_numero_documento = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lbl_numero_calle = New System.Windows.Forms.Label()
        Me.date_fecha_nacimiento = New System.Windows.Forms.DateTimePicker()
        Me.lbl_calle = New System.Windows.Forms.Label()
        Me.lbl_apellido = New System.Windows.Forms.Label()
        Me.txt_calle = New System.Windows.Forms.TextBox()
        Me.lbl_nombre = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.grd_empleados = New System.Windows.Forms.DataGridView()
        Me.id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.id_documento = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.numero_documento = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tipo_documento = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.apellido = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.fecha_nacimiento = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.fecha_ingreso = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.fecha_egreso = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.id_barrio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.barrio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.calle = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.numero_calle = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btn_cancelar = New System.Windows.Forms.Button()
        Me.btn_guardar = New System.Windows.Forms.Button()
        Me.txt_numero_documento = New System.Windows.Forms.MaskedTextBox()
        Me.txt_numero_calle = New System.Windows.Forms.MaskedTextBox()
        Me.grp_datos.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.grd_empleados, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(806, 279)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(49, 13)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "Cancelar"
        '
        'lbl_guardar
        '
        Me.lbl_guardar.AutoSize = True
        Me.lbl_guardar.Location = New System.Drawing.Point(642, 283)
        Me.lbl_guardar.Name = "lbl_guardar"
        Me.lbl_guardar.Size = New System.Drawing.Size(87, 13)
        Me.lbl_guardar.TabIndex = 11
        Me.lbl_guardar.Text = "Guardar cambios"
        '
        'grp_datos
        '
        Me.grp_datos.Controls.Add(Me.txt_numero_calle)
        Me.grp_datos.Controls.Add(Me.txt_numero_documento)
        Me.grp_datos.Controls.Add(Me.txt_nombre)
        Me.grp_datos.Controls.Add(Me.cmb_tipo_documento)
        Me.grp_datos.Controls.Add(Me.date_fecha_ingreso)
        Me.grp_datos.Controls.Add(Me.txt_apellido)
        Me.grp_datos.Controls.Add(Me.cmb_barrio)
        Me.grp_datos.Controls.Add(Me.lbl_tipo_documento)
        Me.grp_datos.Controls.Add(Me.lbl_fecha_nacimiento)
        Me.grp_datos.Controls.Add(Me.lbl_fecha_ingreso)
        Me.grp_datos.Controls.Add(Me.lbl_numero_documento)
        Me.grp_datos.Controls.Add(Me.Label2)
        Me.grp_datos.Controls.Add(Me.lbl_numero_calle)
        Me.grp_datos.Controls.Add(Me.date_fecha_nacimiento)
        Me.grp_datos.Controls.Add(Me.lbl_calle)
        Me.grp_datos.Controls.Add(Me.lbl_apellido)
        Me.grp_datos.Controls.Add(Me.txt_calle)
        Me.grp_datos.Controls.Add(Me.lbl_nombre)
        Me.grp_datos.Location = New System.Drawing.Point(12, 254)
        Me.grp_datos.Name = "grp_datos"
        Me.grp_datos.Size = New System.Drawing.Size(624, 127)
        Me.grp_datos.TabIndex = 12
        Me.grp_datos.TabStop = False
        Me.grp_datos.Text = "Datos del empleado"
        '
        'txt_nombre
        '
        Me.txt_nombre.Location = New System.Drawing.Point(113, 22)
        Me.txt_nombre.Name = "txt_nombre"
        Me.txt_nombre.Size = New System.Drawing.Size(140, 20)
        Me.txt_nombre.TabIndex = 5
        '
        'cmb_tipo_documento
        '
        Me.cmb_tipo_documento.FormattingEnabled = True
        Me.cmb_tipo_documento.Location = New System.Drawing.Point(113, 74)
        Me.cmb_tipo_documento.Name = "cmb_tipo_documento"
        Me.cmb_tipo_documento.Size = New System.Drawing.Size(54, 21)
        Me.cmb_tipo_documento.TabIndex = 12
        '
        'date_fecha_ingreso
        '
        Me.date_fecha_ingreso.Location = New System.Drawing.Point(399, 22)
        Me.date_fecha_ingreso.Name = "date_fecha_ingreso"
        Me.date_fecha_ingreso.Size = New System.Drawing.Size(220, 20)
        Me.date_fecha_ingreso.TabIndex = 24
        '
        'txt_apellido
        '
        Me.txt_apellido.Location = New System.Drawing.Point(113, 48)
        Me.txt_apellido.Name = "txt_apellido"
        Me.txt_apellido.Size = New System.Drawing.Size(140, 20)
        Me.txt_apellido.TabIndex = 11
        '
        'cmb_barrio
        '
        Me.cmb_barrio.FormattingEnabled = True
        Me.cmb_barrio.Location = New System.Drawing.Point(399, 99)
        Me.cmb_barrio.Name = "cmb_barrio"
        Me.cmb_barrio.Size = New System.Drawing.Size(140, 21)
        Me.cmb_barrio.TabIndex = 20
        '
        'lbl_tipo_documento
        '
        Me.lbl_tipo_documento.AutoSize = True
        Me.lbl_tipo_documento.Location = New System.Drawing.Point(5, 80)
        Me.lbl_tipo_documento.Name = "lbl_tipo_documento"
        Me.lbl_tipo_documento.Size = New System.Drawing.Size(102, 13)
        Me.lbl_tipo_documento.TabIndex = 6
        Me.lbl_tipo_documento.Text = "Tipo de documento:"
        '
        'lbl_fecha_nacimiento
        '
        Me.lbl_fecha_nacimiento.AutoSize = True
        Me.lbl_fecha_nacimiento.Location = New System.Drawing.Point(267, 52)
        Me.lbl_fecha_nacimiento.Name = "lbl_fecha_nacimiento"
        Me.lbl_fecha_nacimiento.Size = New System.Drawing.Size(109, 13)
        Me.lbl_fecha_nacimiento.TabIndex = 10
        Me.lbl_fecha_nacimiento.Text = "Fecha de nacimiento:"
        '
        'lbl_fecha_ingreso
        '
        Me.lbl_fecha_ingreso.AutoSize = True
        Me.lbl_fecha_ingreso.Location = New System.Drawing.Point(284, 22)
        Me.lbl_fecha_ingreso.Name = "lbl_fecha_ingreso"
        Me.lbl_fecha_ingreso.Size = New System.Drawing.Size(92, 13)
        Me.lbl_fecha_ingreso.TabIndex = 23
        Me.lbl_fecha_ingreso.Text = "Fecha de ingreso:"
        '
        'lbl_numero_documento
        '
        Me.lbl_numero_documento.AutoSize = True
        Me.lbl_numero_documento.Location = New System.Drawing.Point(169, 80)
        Me.lbl_numero_documento.Name = "lbl_numero_documento"
        Me.lbl_numero_documento.Size = New System.Drawing.Size(22, 13)
        Me.lbl_numero_documento.TabIndex = 7
        Me.lbl_numero_documento.Text = "N°:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(339, 102)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(37, 13)
        Me.Label2.TabIndex = 19
        Me.Label2.Text = "Barrio:"
        '
        'lbl_numero_calle
        '
        Me.lbl_numero_calle.AutoSize = True
        Me.lbl_numero_calle.Location = New System.Drawing.Point(558, 76)
        Me.lbl_numero_calle.Name = "lbl_numero_calle"
        Me.lbl_numero_calle.Size = New System.Drawing.Size(22, 13)
        Me.lbl_numero_calle.TabIndex = 17
        Me.lbl_numero_calle.Text = "N°:"
        '
        'date_fecha_nacimiento
        '
        Me.date_fecha_nacimiento.Location = New System.Drawing.Point(399, 48)
        Me.date_fecha_nacimiento.Name = "date_fecha_nacimiento"
        Me.date_fecha_nacimiento.Size = New System.Drawing.Size(220, 20)
        Me.date_fecha_nacimiento.TabIndex = 14
        '
        'lbl_calle
        '
        Me.lbl_calle.AutoSize = True
        Me.lbl_calle.Location = New System.Drawing.Point(343, 80)
        Me.lbl_calle.Name = "lbl_calle"
        Me.lbl_calle.Size = New System.Drawing.Size(33, 13)
        Me.lbl_calle.TabIndex = 16
        Me.lbl_calle.Text = "Calle:"
        '
        'lbl_apellido
        '
        Me.lbl_apellido.AutoSize = True
        Me.lbl_apellido.Location = New System.Drawing.Point(60, 52)
        Me.lbl_apellido.Name = "lbl_apellido"
        Me.lbl_apellido.Size = New System.Drawing.Size(47, 13)
        Me.lbl_apellido.TabIndex = 9
        Me.lbl_apellido.Text = "Apellido:"
        '
        'txt_calle
        '
        Me.txt_calle.Location = New System.Drawing.Point(399, 73)
        Me.txt_calle.Name = "txt_calle"
        Me.txt_calle.Size = New System.Drawing.Size(140, 20)
        Me.txt_calle.TabIndex = 15
        '
        'lbl_nombre
        '
        Me.lbl_nombre.AutoSize = True
        Me.lbl_nombre.Location = New System.Drawing.Point(60, 22)
        Me.lbl_nombre.Name = "lbl_nombre"
        Me.lbl_nombre.Size = New System.Drawing.Size(47, 13)
        Me.lbl_nombre.TabIndex = 8
        Me.lbl_nombre.Text = "Nombre:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.grd_empleados)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(862, 236)
        Me.GroupBox1.TabIndex = 9
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Selección del empleado"
        '
        'grd_empleados
        '
        Me.grd_empleados.AllowUserToAddRows = False
        Me.grd_empleados.AllowUserToDeleteRows = False
        Me.grd_empleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grd_empleados.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id, Me.id_documento, Me.numero_documento, Me.tipo_documento, Me.nombre, Me.apellido, Me.fecha_nacimiento, Me.fecha_ingreso, Me.fecha_egreso, Me.id_barrio, Me.barrio, Me.calle, Me.numero_calle})
        Me.grd_empleados.Location = New System.Drawing.Point(6, 19)
        Me.grd_empleados.Name = "grd_empleados"
        Me.grd_empleados.ReadOnly = True
        Me.grd_empleados.Size = New System.Drawing.Size(850, 211)
        Me.grd_empleados.TabIndex = 0
        '
        'id
        '
        Me.id.HeaderText = "ID del empleado"
        Me.id.Name = "id"
        Me.id.ReadOnly = True
        Me.id.Visible = False
        '
        'id_documento
        '
        Me.id_documento.HeaderText = "ID del documento"
        Me.id_documento.Name = "id_documento"
        Me.id_documento.ReadOnly = True
        Me.id_documento.Visible = False
        '
        'numero_documento
        '
        Me.numero_documento.HeaderText = "Número documento"
        Me.numero_documento.Name = "numero_documento"
        Me.numero_documento.ReadOnly = True
        '
        'tipo_documento
        '
        Me.tipo_documento.HeaderText = "Tipo documento"
        Me.tipo_documento.Name = "tipo_documento"
        Me.tipo_documento.ReadOnly = True
        '
        'nombre
        '
        Me.nombre.HeaderText = "Nombre"
        Me.nombre.Name = "nombre"
        Me.nombre.ReadOnly = True
        '
        'apellido
        '
        Me.apellido.HeaderText = "Apellido"
        Me.apellido.Name = "apellido"
        Me.apellido.ReadOnly = True
        '
        'fecha_nacimiento
        '
        Me.fecha_nacimiento.HeaderText = "Fecha de nacimiento"
        Me.fecha_nacimiento.Name = "fecha_nacimiento"
        Me.fecha_nacimiento.ReadOnly = True
        '
        'fecha_ingreso
        '
        Me.fecha_ingreso.HeaderText = "Fecha de ingreso"
        Me.fecha_ingreso.Name = "fecha_ingreso"
        Me.fecha_ingreso.ReadOnly = True
        Me.fecha_ingreso.Visible = False
        '
        'fecha_egreso
        '
        Me.fecha_egreso.HeaderText = "Fecha de egreso"
        Me.fecha_egreso.Name = "fecha_egreso"
        Me.fecha_egreso.ReadOnly = True
        Me.fecha_egreso.Visible = False
        '
        'id_barrio
        '
        Me.id_barrio.HeaderText = "ID del barrio"
        Me.id_barrio.Name = "id_barrio"
        Me.id_barrio.ReadOnly = True
        Me.id_barrio.Visible = False
        '
        'barrio
        '
        Me.barrio.HeaderText = "Barrio"
        Me.barrio.Name = "barrio"
        Me.barrio.ReadOnly = True
        '
        'calle
        '
        Me.calle.HeaderText = "Calle"
        Me.calle.Name = "calle"
        Me.calle.ReadOnly = True
        '
        'numero_calle
        '
        Me.numero_calle.HeaderText = "Numero de calle"
        Me.numero_calle.Name = "numero_calle"
        Me.numero_calle.ReadOnly = True
        '
        'btn_cancelar
        '
        Me.btn_cancelar.BackgroundImage = Global.Heladeria_Tu_Gusto.My.Resources.Resources.icons8_Delete_40
        Me.btn_cancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btn_cancelar.Location = New System.Drawing.Point(798, 299)
        Me.btn_cancelar.Name = "btn_cancelar"
        Me.btn_cancelar.Size = New System.Drawing.Size(70, 70)
        Me.btn_cancelar.TabIndex = 13
        Me.btn_cancelar.TextAlign = System.Drawing.ContentAlignment.TopLeft
        Me.btn_cancelar.UseVisualStyleBackColor = True
        '
        'btn_guardar
        '
        Me.btn_guardar.BackgroundImage = Global.Heladeria_Tu_Gusto.My.Resources.Resources.icons8_Save_as_64
        Me.btn_guardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btn_guardar.Location = New System.Drawing.Point(653, 299)
        Me.btn_guardar.Name = "btn_guardar"
        Me.btn_guardar.Size = New System.Drawing.Size(70, 70)
        Me.btn_guardar.TabIndex = 10
        Me.btn_guardar.TextAlign = System.Drawing.ContentAlignment.TopLeft
        Me.btn_guardar.UseVisualStyleBackColor = True
        '
        'txt_numero_documento
        '
        Me.txt_numero_documento.Location = New System.Drawing.Point(193, 75)
        Me.txt_numero_documento.Mask = "99999999"
        Me.txt_numero_documento.Name = "txt_numero_documento"
        Me.txt_numero_documento.Size = New System.Drawing.Size(60, 20)
        Me.txt_numero_documento.TabIndex = 25
        '
        'txt_numero_calle
        '
        Me.txt_numero_calle.Location = New System.Drawing.Point(586, 73)
        Me.txt_numero_calle.Mask = "9999"
        Me.txt_numero_calle.Name = "txt_numero_calle"
        Me.txt_numero_calle.Size = New System.Drawing.Size(33, 20)
        Me.txt_numero_calle.TabIndex = 26
        '
        'ModificarEmpleado
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(879, 386)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btn_cancelar)
        Me.Controls.Add(Me.lbl_guardar)
        Me.Controls.Add(Me.grp_datos)
        Me.Controls.Add(Me.btn_guardar)
        Me.Controls.Add(Me.GroupBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "ModificarEmpleado"
        Me.Text = "ModificarEmpleado"
        Me.grp_datos.ResumeLayout(False)
        Me.grp_datos.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.grd_empleados, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btn_cancelar As System.Windows.Forms.Button
    Friend WithEvents lbl_guardar As System.Windows.Forms.Label
    Friend WithEvents grp_datos As System.Windows.Forms.GroupBox
    Friend WithEvents btn_guardar As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents grd_empleados As System.Windows.Forms.DataGridView
    Friend WithEvents txt_nombre As System.Windows.Forms.TextBox
    Friend WithEvents lbl_tipo_documento As System.Windows.Forms.Label
    Friend WithEvents lbl_numero_documento As System.Windows.Forms.Label
    Friend WithEvents date_fecha_nacimiento As System.Windows.Forms.DateTimePicker
    Friend WithEvents lbl_nombre As System.Windows.Forms.Label
    Friend WithEvents lbl_apellido As System.Windows.Forms.Label
    Friend WithEvents lbl_fecha_nacimiento As System.Windows.Forms.Label
    Friend WithEvents txt_apellido As System.Windows.Forms.TextBox
    Friend WithEvents cmb_tipo_documento As System.Windows.Forms.ComboBox
    Friend WithEvents lbl_calle As System.Windows.Forms.Label
    Friend WithEvents txt_calle As System.Windows.Forms.TextBox
    Friend WithEvents lbl_numero_calle As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cmb_barrio As System.Windows.Forms.ComboBox
    Friend WithEvents id As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents id_documento As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents numero_documento As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents tipo_documento As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents nombre As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents apellido As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents fecha_nacimiento As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents fecha_ingreso As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents fecha_egreso As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents id_barrio As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents barrio As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents calle As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents numero_calle As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents date_fecha_ingreso As System.Windows.Forms.DateTimePicker
    Friend WithEvents lbl_fecha_ingreso As System.Windows.Forms.Label
    Friend WithEvents txt_numero_calle As System.Windows.Forms.MaskedTextBox
    Friend WithEvents txt_numero_documento As System.Windows.Forms.MaskedTextBox
End Class
