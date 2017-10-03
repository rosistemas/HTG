<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RegistrarEmpleado
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RegistrarEmpleado))
        Me.lbl_tipo_documento = New System.Windows.Forms.Label()
        Me.lbl_numero_documento = New System.Windows.Forms.Label()
        Me.lbl_nombre = New System.Windows.Forms.Label()
        Me.lbl_apellido = New System.Windows.Forms.Label()
        Me.lbl_calle = New System.Windows.Forms.Label()
        Me.lbl_fecha_nacimiento = New System.Windows.Forms.Label()
        Me.txt_nombre = New System.Windows.Forms.TextBox()
        Me.txt_apellido = New System.Windows.Forms.TextBox()
        Me.cmb_tipo_documento = New System.Windows.Forms.ComboBox()
        Me.date_fecha_nacimiento = New System.Windows.Forms.DateTimePicker()
        Me.txt_calle = New System.Windows.Forms.TextBox()
        Me.cmd_cancelar = New System.Windows.Forms.Button()
        Me.cmd_aceptar = New System.Windows.Forms.Button()
        Me.lbl_numero_calle = New System.Windows.Forms.Label()
        Me.grp_datos = New System.Windows.Forms.GroupBox()
        Me.txt_numero_documento = New System.Windows.Forms.MaskedTextBox()
        Me.grp_domicilio = New System.Windows.Forms.GroupBox()
        Me.txt_numero_calle = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmb_barrio = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lbl_guardar = New System.Windows.Forms.Label()
        Me.grp_datos.SuspendLayout
        Me.grp_domicilio.SuspendLayout
        Me.SuspendLayout
        '
        'lbl_tipo_documento
        '
        Me.lbl_tipo_documento.AutoSize = true
        Me.lbl_tipo_documento.Location = New System.Drawing.Point(19, 117)
        Me.lbl_tipo_documento.Name = "lbl_tipo_documento"
        Me.lbl_tipo_documento.Size = New System.Drawing.Size(102, 13)
        Me.lbl_tipo_documento.TabIndex = 1
        Me.lbl_tipo_documento.Text = "Tipo de documento:"
        '
        'lbl_numero_documento
        '
        Me.lbl_numero_documento.AutoSize = true
        Me.lbl_numero_documento.Location = New System.Drawing.Point(234, 117)
        Me.lbl_numero_documento.Name = "lbl_numero_documento"
        Me.lbl_numero_documento.Size = New System.Drawing.Size(47, 13)
        Me.lbl_numero_documento.TabIndex = 1
        Me.lbl_numero_documento.Text = "Número:"
        '
        'lbl_nombre
        '
        Me.lbl_nombre.AutoSize = true
        Me.lbl_nombre.Location = New System.Drawing.Point(74, 30)
        Me.lbl_nombre.Name = "lbl_nombre"
        Me.lbl_nombre.Size = New System.Drawing.Size(47, 13)
        Me.lbl_nombre.TabIndex = 1
        Me.lbl_nombre.Text = "Nombre:"
        '
        'lbl_apellido
        '
        Me.lbl_apellido.AutoSize = true
        Me.lbl_apellido.Location = New System.Drawing.Point(74, 76)
        Me.lbl_apellido.Name = "lbl_apellido"
        Me.lbl_apellido.Size = New System.Drawing.Size(47, 13)
        Me.lbl_apellido.TabIndex = 1
        Me.lbl_apellido.Text = "Apellido:"
        '
        'lbl_calle
        '
        Me.lbl_calle.AutoSize = true
        Me.lbl_calle.Location = New System.Drawing.Point(78, 30)
        Me.lbl_calle.Name = "lbl_calle"
        Me.lbl_calle.Size = New System.Drawing.Size(33, 13)
        Me.lbl_calle.TabIndex = 1
        Me.lbl_calle.Text = "Calle:"
        '
        'lbl_fecha_nacimiento
        '
        Me.lbl_fecha_nacimiento.AutoSize = true
        Me.lbl_fecha_nacimiento.Location = New System.Drawing.Point(12, 162)
        Me.lbl_fecha_nacimiento.Name = "lbl_fecha_nacimiento"
        Me.lbl_fecha_nacimiento.Size = New System.Drawing.Size(109, 13)
        Me.lbl_fecha_nacimiento.TabIndex = 1
        Me.lbl_fecha_nacimiento.Text = "Fecha de nacimiento:"
        '
        'txt_nombre
        '
        Me.txt_nombre.Location = New System.Drawing.Point(127, 29)
        Me.txt_nombre.Name = "txt_nombre"
        Me.txt_nombre.Size = New System.Drawing.Size(220, 20)
        Me.txt_nombre.TabIndex = 0
        '
        'txt_apellido
        '
        Me.txt_apellido.Location = New System.Drawing.Point(127, 71)
        Me.txt_apellido.Name = "txt_apellido"
        Me.txt_apellido.Size = New System.Drawing.Size(220, 20)
        Me.txt_apellido.TabIndex = 1
        '
        'cmb_tipo_documento
        '
        Me.cmb_tipo_documento.FormattingEnabled = true
        Me.cmb_tipo_documento.Location = New System.Drawing.Point(127, 113)
        Me.cmb_tipo_documento.Name = "cmb_tipo_documento"
        Me.cmb_tipo_documento.Size = New System.Drawing.Size(100, 21)
        Me.cmb_tipo_documento.TabIndex = 2
        '
        'date_fecha_nacimiento
        '
        Me.date_fecha_nacimiento.Location = New System.Drawing.Point(127, 156)
        Me.date_fecha_nacimiento.Name = "date_fecha_nacimiento"
        Me.date_fecha_nacimiento.Size = New System.Drawing.Size(220, 20)
        Me.date_fecha_nacimiento.TabIndex = 4
        '
        'txt_calle
        '
        Me.txt_calle.Location = New System.Drawing.Point(127, 27)
        Me.txt_calle.Name = "txt_calle"
        Me.txt_calle.Size = New System.Drawing.Size(100, 20)
        Me.txt_calle.TabIndex = 0
        '
        'cmd_cancelar
        '
        Me.cmd_cancelar.BackgroundImage = Global.Heladeria_Tu_Gusto.My.Resources.Resources.icons8_Delete_40
        Me.cmd_cancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.cmd_cancelar.Location = New System.Drawing.Point(284, 323)
        Me.cmd_cancelar.Name = "cmd_cancelar"
        Me.cmd_cancelar.Size = New System.Drawing.Size(75, 46)
        Me.cmd_cancelar.TabIndex = 1
        Me.cmd_cancelar.UseVisualStyleBackColor = true
        '
        'cmd_aceptar
        '
        Me.cmd_aceptar.BackgroundImage = Global.Heladeria_Tu_Gusto.My.Resources.Resources.icons8_Add_New_40
        Me.cmd_aceptar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.cmd_aceptar.Location = New System.Drawing.Point(9, 323)
        Me.cmd_aceptar.Name = "cmd_aceptar"
        Me.cmd_aceptar.Size = New System.Drawing.Size(75, 46)
        Me.cmd_aceptar.TabIndex = 0
        Me.cmd_aceptar.UseVisualStyleBackColor = true
        '
        'lbl_numero_calle
        '
        Me.lbl_numero_calle.AutoSize = true
        Me.lbl_numero_calle.Location = New System.Drawing.Point(234, 30)
        Me.lbl_numero_calle.Name = "lbl_numero_calle"
        Me.lbl_numero_calle.Size = New System.Drawing.Size(47, 13)
        Me.lbl_numero_calle.TabIndex = 1
        Me.lbl_numero_calle.Text = "Número:"
        '
        'grp_datos
        '
        Me.grp_datos.Controls.Add(Me.txt_numero_documento)
        Me.grp_datos.Controls.Add(Me.txt_nombre)
        Me.grp_datos.Controls.Add(Me.lbl_tipo_documento)
        Me.grp_datos.Controls.Add(Me.lbl_numero_documento)
        Me.grp_datos.Controls.Add(Me.date_fecha_nacimiento)
        Me.grp_datos.Controls.Add(Me.lbl_nombre)
        Me.grp_datos.Controls.Add(Me.lbl_apellido)
        Me.grp_datos.Controls.Add(Me.lbl_fecha_nacimiento)
        Me.grp_datos.Controls.Add(Me.txt_apellido)
        Me.grp_datos.Controls.Add(Me.cmb_tipo_documento)
        Me.grp_datos.Location = New System.Drawing.Point(6, 21)
        Me.grp_datos.Name = "grp_datos"
        Me.grp_datos.Size = New System.Drawing.Size(353, 185)
        Me.grp_datos.TabIndex = 9
        Me.grp_datos.TabStop = false
        Me.grp_datos.Text = "Datos personales"
        '
        'txt_numero_documento
        '
        Me.txt_numero_documento.Location = New System.Drawing.Point(287, 114)
        Me.txt_numero_documento.Mask = "99999999"
        Me.txt_numero_documento.Name = "txt_numero_documento"
        Me.txt_numero_documento.Size = New System.Drawing.Size(60, 20)
        Me.txt_numero_documento.TabIndex = 3
        '
        'grp_domicilio
        '
        Me.grp_domicilio.Controls.Add(Me.txt_numero_calle)
        Me.grp_domicilio.Controls.Add(Me.lbl_calle)
        Me.grp_domicilio.Controls.Add(Me.txt_calle)
        Me.grp_domicilio.Controls.Add(Me.lbl_numero_calle)
        Me.grp_domicilio.Controls.Add(Me.Label1)
        Me.grp_domicilio.Controls.Add(Me.cmb_barrio)
        Me.grp_domicilio.Location = New System.Drawing.Point(6, 212)
        Me.grp_domicilio.Name = "grp_domicilio"
        Me.grp_domicilio.Size = New System.Drawing.Size(353, 90)
        Me.grp_domicilio.TabIndex = 10
        Me.grp_domicilio.TabStop = false
        Me.grp_domicilio.Text = "Domicilio"
        '
        'txt_numero_calle
        '
        Me.txt_numero_calle.Location = New System.Drawing.Point(287, 27)
        Me.txt_numero_calle.Name = "txt_numero_calle"
        Me.txt_numero_calle.Size = New System.Drawing.Size(57, 20)
        Me.txt_numero_calle.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = true
        Me.Label1.Location = New System.Drawing.Point(74, 56)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(37, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Barrio:"
        '
        'cmb_barrio
        '
        Me.cmb_barrio.FormattingEnabled = true
        Me.cmb_barrio.Location = New System.Drawing.Point(127, 53)
        Me.cmb_barrio.Name = "cmb_barrio"
        Me.cmb_barrio.Size = New System.Drawing.Size(217, 21)
        Me.cmb_barrio.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = true
        Me.Label2.Location = New System.Drawing.Point(298, 307)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(49, 13)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "Cancelar"
        '
        'lbl_guardar
        '
        Me.lbl_guardar.AutoSize = true
        Me.lbl_guardar.Location = New System.Drawing.Point(25, 307)
        Me.lbl_guardar.Name = "lbl_guardar"
        Me.lbl_guardar.Size = New System.Drawing.Size(45, 13)
        Me.lbl_guardar.TabIndex = 11
        Me.lbl_guardar.Text = "Guardar"
        '
        'RegistrarEmpleado
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(362, 373)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lbl_guardar)
        Me.Controls.Add(Me.grp_domicilio)
        Me.Controls.Add(Me.grp_datos)
        Me.Controls.Add(Me.cmd_cancelar)
        Me.Controls.Add(Me.cmd_aceptar)
        Me.Icon = CType(resources.GetObject("$this.Icon"),System.Drawing.Icon)
        Me.Name = "RegistrarEmpleado"
        Me.Text = "Nuevo empleado"
        Me.grp_datos.ResumeLayout(false)
        Me.grp_datos.PerformLayout
        Me.grp_domicilio.ResumeLayout(false)
        Me.grp_domicilio.PerformLayout
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub
    Friend WithEvents lbl_tipo_documento As System.Windows.Forms.Label
    Friend WithEvents lbl_numero_documento As System.Windows.Forms.Label
    Friend WithEvents lbl_nombre As System.Windows.Forms.Label
    Friend WithEvents lbl_apellido As System.Windows.Forms.Label
    Friend WithEvents lbl_calle As System.Windows.Forms.Label
    Friend WithEvents lbl_fecha_nacimiento As System.Windows.Forms.Label
    Friend WithEvents txt_nombre As System.Windows.Forms.TextBox
    Friend WithEvents txt_apellido As System.Windows.Forms.TextBox
    Friend WithEvents cmb_tipo_documento As System.Windows.Forms.ComboBox
    Friend WithEvents date_fecha_nacimiento As System.Windows.Forms.DateTimePicker
    Friend WithEvents txt_calle As System.Windows.Forms.TextBox
    Friend WithEvents cmd_cancelar As System.Windows.Forms.Button
    Friend WithEvents cmd_aceptar As System.Windows.Forms.Button
    Friend WithEvents lbl_numero_calle As System.Windows.Forms.Label
    Friend WithEvents grp_datos As System.Windows.Forms.GroupBox
    Friend WithEvents grp_domicilio As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmb_barrio As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lbl_guardar As System.Windows.Forms.Label
    Friend WithEvents txt_numero_documento As System.Windows.Forms.MaskedTextBox
    Friend WithEvents txt_numero_calle As TextBox
End Class
