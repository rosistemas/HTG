<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ModificarProveedor
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ModificarProveedor))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.grd_proveedores = New System.Windows.Forms.DataGridView()
        Me.id_proveedor = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.numero_documento = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.id_tipo_documento = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tipo_documento = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.razon_social = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.mail = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.id_barrio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.barrio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.calle = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.numero_calle = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.id_localidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.localidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lbl_calle = New System.Windows.Forms.Label()
        Me.txt_calle = New System.Windows.Forms.TextBox()
        Me.lbl_numero_calle = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lbl_localidad = New System.Windows.Forms.Label()
        Me.cmb_barrio = New System.Windows.Forms.ComboBox()
        Me.cmb_localidad = New System.Windows.Forms.ComboBox()
        Me.grp_datos = New System.Windows.Forms.GroupBox()
        Me.txt_numero_documento = New System.Windows.Forms.MaskedTextBox()
        Me.txt_razon_social = New System.Windows.Forms.TextBox()
        Me.txt_nombre = New System.Windows.Forms.TextBox()
        Me.lbl_tipo_documento = New System.Windows.Forms.Label()
        Me.lbl_numero_documento = New System.Windows.Forms.Label()
        Me.lbl_nombre = New System.Windows.Forms.Label()
        Me.lbl_mail = New System.Windows.Forms.Label()
        Me.lbl_razon_social = New System.Windows.Forms.Label()
        Me.txt_mail = New System.Windows.Forms.TextBox()
        Me.cmb_tipo_documento = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btn_cancelar = New System.Windows.Forms.Button()
        Me.lbl_guardar = New System.Windows.Forms.Label()
        Me.btn_guardar = New System.Windows.Forms.Button()
        Me.txt_numero_calle = New System.Windows.Forms.TextBox()
        Me.GroupBox1.SuspendLayout
        CType(Me.grd_proveedores,System.ComponentModel.ISupportInitialize).BeginInit
        Me.grp_datos.SuspendLayout
        Me.SuspendLayout
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.grd_proveedores)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(954, 236)
        Me.GroupBox1.TabIndex = 10
        Me.GroupBox1.TabStop = false
        Me.GroupBox1.Text = "Selección del proveedor"
        '
        'grd_proveedores
        '
        Me.grd_proveedores.AllowUserToAddRows = false
        Me.grd_proveedores.AllowUserToDeleteRows = false
        Me.grd_proveedores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grd_proveedores.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id_proveedor, Me.numero_documento, Me.id_tipo_documento, Me.tipo_documento, Me.razon_social, Me.mail, Me.id_barrio, Me.barrio, Me.calle, Me.numero_calle, Me.nombre, Me.id_localidad, Me.localidad})
        Me.grd_proveedores.Location = New System.Drawing.Point(6, 19)
        Me.grd_proveedores.Name = "grd_proveedores"
        Me.grd_proveedores.ReadOnly = true
        Me.grd_proveedores.Size = New System.Drawing.Size(943, 211)
        Me.grd_proveedores.TabIndex = 0
        '
        'id_proveedor
        '
        Me.id_proveedor.HeaderText = "_ID del proveedor"
        Me.id_proveedor.Name = "id_proveedor"
        Me.id_proveedor.ReadOnly = true
        Me.id_proveedor.Visible = false
        '
        'numero_documento
        '
        Me.numero_documento.HeaderText = "Número documento"
        Me.numero_documento.Name = "numero_documento"
        Me.numero_documento.ReadOnly = true
        '
        'id_tipo_documento
        '
        Me.id_tipo_documento.HeaderText = "_ID del documento"
        Me.id_tipo_documento.Name = "id_tipo_documento"
        Me.id_tipo_documento.ReadOnly = true
        Me.id_tipo_documento.Visible = false
        '
        'tipo_documento
        '
        Me.tipo_documento.HeaderText = "Tipo documento"
        Me.tipo_documento.Name = "tipo_documento"
        Me.tipo_documento.ReadOnly = true
        '
        'razon_social
        '
        Me.razon_social.HeaderText = "Razon social"
        Me.razon_social.Name = "razon_social"
        Me.razon_social.ReadOnly = true
        '
        'mail
        '
        Me.mail.HeaderText = "Mail"
        Me.mail.Name = "mail"
        Me.mail.ReadOnly = true
        '
        'id_barrio
        '
        Me.id_barrio.HeaderText = "_ID del barrio"
        Me.id_barrio.Name = "id_barrio"
        Me.id_barrio.ReadOnly = true
        Me.id_barrio.Visible = false
        '
        'barrio
        '
        Me.barrio.HeaderText = "Barrio"
        Me.barrio.Name = "barrio"
        Me.barrio.ReadOnly = true
        '
        'calle
        '
        Me.calle.HeaderText = "Calle"
        Me.calle.Name = "calle"
        Me.calle.ReadOnly = true
        '
        'numero_calle
        '
        Me.numero_calle.HeaderText = "Numero de calle"
        Me.numero_calle.Name = "numero_calle"
        Me.numero_calle.ReadOnly = true
        '
        'nombre
        '
        Me.nombre.HeaderText = "Nombre"
        Me.nombre.Name = "nombre"
        Me.nombre.ReadOnly = true
        '
        'id_localidad
        '
        Me.id_localidad.HeaderText = "_ID de localidad"
        Me.id_localidad.Name = "id_localidad"
        Me.id_localidad.ReadOnly = true
        Me.id_localidad.Visible = false
        '
        'localidad
        '
        Me.localidad.HeaderText = "Localidad"
        Me.localidad.Name = "localidad"
        Me.localidad.ReadOnly = true
        '
        'lbl_calle
        '
        Me.lbl_calle.AutoSize = true
        Me.lbl_calle.Location = New System.Drawing.Point(333, 18)
        Me.lbl_calle.Name = "lbl_calle"
        Me.lbl_calle.Size = New System.Drawing.Size(33, 13)
        Me.lbl_calle.TabIndex = 1
        Me.lbl_calle.Text = "Calle:"
        '
        'txt_calle
        '
        Me.txt_calle.Location = New System.Drawing.Point(372, 15)
        Me.txt_calle.Name = "txt_calle"
        Me.txt_calle.Size = New System.Drawing.Size(140, 20)
        Me.txt_calle.TabIndex = 0
        '
        'lbl_numero_calle
        '
        Me.lbl_numero_calle.AutoSize = true
        Me.lbl_numero_calle.Location = New System.Drawing.Point(518, 18)
        Me.lbl_numero_calle.Name = "lbl_numero_calle"
        Me.lbl_numero_calle.Size = New System.Drawing.Size(22, 13)
        Me.lbl_numero_calle.TabIndex = 1
        Me.lbl_numero_calle.Text = "N°:"
        '
        'Label1
        '
        Me.Label1.AutoSize = true
        Me.Label1.Location = New System.Drawing.Point(329, 74)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(37, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Barrio:"
        '
        'lbl_localidad
        '
        Me.lbl_localidad.AutoSize = true
        Me.lbl_localidad.Location = New System.Drawing.Point(310, 47)
        Me.lbl_localidad.Name = "lbl_localidad"
        Me.lbl_localidad.Size = New System.Drawing.Size(56, 13)
        Me.lbl_localidad.TabIndex = 1
        Me.lbl_localidad.Text = "Localidad:"
        '
        'cmb_barrio
        '
        Me.cmb_barrio.FormattingEnabled = true
        Me.cmb_barrio.Location = New System.Drawing.Point(372, 71)
        Me.cmb_barrio.Name = "cmb_barrio"
        Me.cmb_barrio.Size = New System.Drawing.Size(140, 21)
        Me.cmb_barrio.TabIndex = 3
        '
        'cmb_localidad
        '
        Me.cmb_localidad.FormattingEnabled = true
        Me.cmb_localidad.Location = New System.Drawing.Point(372, 44)
        Me.cmb_localidad.Name = "cmb_localidad"
        Me.cmb_localidad.Size = New System.Drawing.Size(140, 21)
        Me.cmb_localidad.TabIndex = 2
        '
        'grp_datos
        '
        Me.grp_datos.Controls.Add(Me.txt_numero_calle)
        Me.grp_datos.Controls.Add(Me.txt_numero_documento)
        Me.grp_datos.Controls.Add(Me.lbl_calle)
        Me.grp_datos.Controls.Add(Me.txt_razon_social)
        Me.grp_datos.Controls.Add(Me.txt_nombre)
        Me.grp_datos.Controls.Add(Me.txt_calle)
        Me.grp_datos.Controls.Add(Me.lbl_numero_calle)
        Me.grp_datos.Controls.Add(Me.lbl_tipo_documento)
        Me.grp_datos.Controls.Add(Me.lbl_numero_documento)
        Me.grp_datos.Controls.Add(Me.lbl_nombre)
        Me.grp_datos.Controls.Add(Me.lbl_mail)
        Me.grp_datos.Controls.Add(Me.Label1)
        Me.grp_datos.Controls.Add(Me.lbl_razon_social)
        Me.grp_datos.Controls.Add(Me.lbl_localidad)
        Me.grp_datos.Controls.Add(Me.txt_mail)
        Me.grp_datos.Controls.Add(Me.cmb_barrio)
        Me.grp_datos.Controls.Add(Me.cmb_tipo_documento)
        Me.grp_datos.Controls.Add(Me.cmb_localidad)
        Me.grp_datos.Location = New System.Drawing.Point(12, 254)
        Me.grp_datos.Name = "grp_datos"
        Me.grp_datos.Size = New System.Drawing.Size(588, 122)
        Me.grp_datos.TabIndex = 15
        Me.grp_datos.TabStop = false
        Me.grp_datos.Text = "Datos del proveedor"
        '
        'txt_numero_documento
        '
        Me.txt_numero_documento.Location = New System.Drawing.Point(212, 67)
        Me.txt_numero_documento.Mask = "99999999"
        Me.txt_numero_documento.Name = "txt_numero_documento"
        Me.txt_numero_documento.Size = New System.Drawing.Size(68, 20)
        Me.txt_numero_documento.TabIndex = 5
        '
        'txt_razon_social
        '
        Me.txt_razon_social.Location = New System.Drawing.Point(133, 41)
        Me.txt_razon_social.Name = "txt_razon_social"
        Me.txt_razon_social.Size = New System.Drawing.Size(147, 20)
        Me.txt_razon_social.TabIndex = 4
        '
        'txt_nombre
        '
        Me.txt_nombre.Location = New System.Drawing.Point(133, 15)
        Me.txt_nombre.Name = "txt_nombre"
        Me.txt_nombre.Size = New System.Drawing.Size(147, 20)
        Me.txt_nombre.TabIndex = 0
        '
        'lbl_tipo_documento
        '
        Me.lbl_tipo_documento.AutoSize = true
        Me.lbl_tipo_documento.Location = New System.Drawing.Point(25, 70)
        Me.lbl_tipo_documento.Name = "lbl_tipo_documento"
        Me.lbl_tipo_documento.Size = New System.Drawing.Size(102, 13)
        Me.lbl_tipo_documento.TabIndex = 1
        Me.lbl_tipo_documento.Text = "Tipo de documento:"
        '
        'lbl_numero_documento
        '
        Me.lbl_numero_documento.AutoSize = true
        Me.lbl_numero_documento.Location = New System.Drawing.Point(193, 70)
        Me.lbl_numero_documento.Name = "lbl_numero_documento"
        Me.lbl_numero_documento.Size = New System.Drawing.Size(22, 13)
        Me.lbl_numero_documento.TabIndex = 1
        Me.lbl_numero_documento.Text = "N°:"
        '
        'lbl_nombre
        '
        Me.lbl_nombre.AutoSize = true
        Me.lbl_nombre.Location = New System.Drawing.Point(79, 18)
        Me.lbl_nombre.Name = "lbl_nombre"
        Me.lbl_nombre.Size = New System.Drawing.Size(47, 13)
        Me.lbl_nombre.TabIndex = 1
        Me.lbl_nombre.Text = "Nombre:"
        '
        'lbl_mail
        '
        Me.lbl_mail.AutoSize = true
        Me.lbl_mail.Location = New System.Drawing.Point(97, 97)
        Me.lbl_mail.Name = "lbl_mail"
        Me.lbl_mail.Size = New System.Drawing.Size(29, 13)
        Me.lbl_mail.TabIndex = 1
        Me.lbl_mail.Text = "Mail:"
        '
        'lbl_razon_social
        '
        Me.lbl_razon_social.AutoSize = true
        Me.lbl_razon_social.Location = New System.Drawing.Point(56, 44)
        Me.lbl_razon_social.Name = "lbl_razon_social"
        Me.lbl_razon_social.Size = New System.Drawing.Size(71, 13)
        Me.lbl_razon_social.TabIndex = 1
        Me.lbl_razon_social.Text = "Razón social:"
        '
        'txt_mail
        '
        Me.txt_mail.Location = New System.Drawing.Point(132, 94)
        Me.txt_mail.Name = "txt_mail"
        Me.txt_mail.Size = New System.Drawing.Size(148, 20)
        Me.txt_mail.TabIndex = 1
        '
        'cmb_tipo_documento
        '
        Me.cmb_tipo_documento.FormattingEnabled = true
        Me.cmb_tipo_documento.Location = New System.Drawing.Point(133, 67)
        Me.cmb_tipo_documento.Name = "cmb_tipo_documento"
        Me.cmb_tipo_documento.Size = New System.Drawing.Size(54, 21)
        Me.cmb_tipo_documento.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = true
        Me.Label2.Location = New System.Drawing.Point(846, 278)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(49, 13)
        Me.Label2.TabIndex = 20
        Me.Label2.Text = "Cancelar"
        '
        'btn_cancelar
        '
        Me.btn_cancelar.BackgroundImage = Global.Heladeria_Tu_Gusto.My.Resources.Resources.icons8_Delete_40
        Me.btn_cancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btn_cancelar.Location = New System.Drawing.Point(838, 294)
        Me.btn_cancelar.Name = "btn_cancelar"
        Me.btn_cancelar.Size = New System.Drawing.Size(70, 70)
        Me.btn_cancelar.TabIndex = 19
        Me.btn_cancelar.TextAlign = System.Drawing.ContentAlignment.TopLeft
        Me.btn_cancelar.UseVisualStyleBackColor = true
        '
        'lbl_guardar
        '
        Me.lbl_guardar.AutoSize = true
        Me.lbl_guardar.Location = New System.Drawing.Point(681, 278)
        Me.lbl_guardar.Name = "lbl_guardar"
        Me.lbl_guardar.Size = New System.Drawing.Size(87, 13)
        Me.lbl_guardar.TabIndex = 18
        Me.lbl_guardar.Text = "Guardar cambios"
        '
        'btn_guardar
        '
        Me.btn_guardar.BackgroundImage = Global.Heladeria_Tu_Gusto.My.Resources.Resources.icons8_Save_as_64
        Me.btn_guardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btn_guardar.Location = New System.Drawing.Point(690, 294)
        Me.btn_guardar.Name = "btn_guardar"
        Me.btn_guardar.Size = New System.Drawing.Size(70, 70)
        Me.btn_guardar.TabIndex = 17
        Me.btn_guardar.TextAlign = System.Drawing.ContentAlignment.TopLeft
        Me.btn_guardar.UseVisualStyleBackColor = true
        '
        'txt_numero_calle
        '
        Me.txt_numero_calle.Location = New System.Drawing.Point(546, 15)
        Me.txt_numero_calle.Name = "txt_numero_calle"
        Me.txt_numero_calle.Size = New System.Drawing.Size(36, 20)
        Me.txt_numero_calle.TabIndex = 6
        '
        'ModificarProveedor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(972, 382)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btn_cancelar)
        Me.Controls.Add(Me.lbl_guardar)
        Me.Controls.Add(Me.btn_guardar)
        Me.Controls.Add(Me.grp_datos)
        Me.Controls.Add(Me.GroupBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"),System.Drawing.Icon)
        Me.Name = "ModificarProveedor"
        Me.Text = "ModificarProveedor"
        Me.GroupBox1.ResumeLayout(false)
        CType(Me.grd_proveedores,System.ComponentModel.ISupportInitialize).EndInit
        Me.grp_datos.ResumeLayout(false)
        Me.grp_datos.PerformLayout
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents grd_proveedores As System.Windows.Forms.DataGridView
    Friend WithEvents lbl_calle As System.Windows.Forms.Label
    Friend WithEvents txt_calle As System.Windows.Forms.TextBox
    Friend WithEvents lbl_numero_calle As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lbl_localidad As System.Windows.Forms.Label
    Friend WithEvents cmb_barrio As System.Windows.Forms.ComboBox
    Friend WithEvents cmb_localidad As System.Windows.Forms.ComboBox
    Friend WithEvents grp_datos As System.Windows.Forms.GroupBox
    Friend WithEvents txt_razon_social As System.Windows.Forms.TextBox
    Friend WithEvents txt_nombre As System.Windows.Forms.TextBox
    Friend WithEvents lbl_tipo_documento As System.Windows.Forms.Label
    Friend WithEvents lbl_numero_documento As System.Windows.Forms.Label
    Friend WithEvents lbl_nombre As System.Windows.Forms.Label
    Friend WithEvents lbl_mail As System.Windows.Forms.Label
    Friend WithEvents lbl_razon_social As System.Windows.Forms.Label
    Friend WithEvents txt_mail As System.Windows.Forms.TextBox
    Friend WithEvents cmb_tipo_documento As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btn_cancelar As System.Windows.Forms.Button
    Friend WithEvents lbl_guardar As System.Windows.Forms.Label
    Friend WithEvents btn_guardar As System.Windows.Forms.Button
    Friend WithEvents id_proveedor As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents numero_documento As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents id_tipo_documento As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents tipo_documento As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents razon_social As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents mail As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents id_barrio As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents barrio As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents calle As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents numero_calle As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents nombre As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents id_localidad As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents localidad As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents txt_numero_documento As System.Windows.Forms.MaskedTextBox
    Friend WithEvents txt_numero_calle As TextBox
End Class
