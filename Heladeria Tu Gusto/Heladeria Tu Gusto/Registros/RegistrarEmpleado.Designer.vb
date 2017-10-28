Imports System.ComponentModel
Imports Microsoft.VisualBasic.CompilerServices

<DesignerGenerated()> _
Partial Class RegistrarEmpleado
    Inherits Form

    'Form overrides dispose to clean up the component list.
    <DebuggerNonUserCode()> _
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
    Private components As IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <DebuggerStepThrough()> _
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
        Me.lbl_numero_calle = New System.Windows.Forms.Label()
        Me.grp_datos = New System.Windows.Forms.GroupBox()
        Me.txt_numero_documento = New System.Windows.Forms.MaskedTextBox()
        Me.grp_domicilio = New System.Windows.Forms.GroupBox()
        Me.txt_numero_calle = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmb_barrio = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lbl_guardar = New System.Windows.Forms.Label()
        Me.cmd_cancelar = New System.Windows.Forms.Button()
        Me.cmd_guardar = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cmb_provincia = New System.Windows.Forms.ComboBox()
        Me.lbl_localidad = New System.Windows.Forms.Label()
        Me.cmb_localidad = New System.Windows.Forms.ComboBox()
        Me.grp_datos.SuspendLayout()
        Me.grp_domicilio.SuspendLayout()
        Me.SuspendLayout()
        '
        'lbl_tipo_documento
        '
        Me.lbl_tipo_documento.AutoSize = True
        Me.lbl_tipo_documento.Location = New System.Drawing.Point(19, 117)
        Me.lbl_tipo_documento.Name = "lbl_tipo_documento"
        Me.lbl_tipo_documento.Size = New System.Drawing.Size(102, 13)
        Me.lbl_tipo_documento.TabIndex = 1
        Me.lbl_tipo_documento.Text = "Tipo de documento:"
        '
        'lbl_numero_documento
        '
        Me.lbl_numero_documento.AutoSize = True
        Me.lbl_numero_documento.Location = New System.Drawing.Point(234, 117)
        Me.lbl_numero_documento.Name = "lbl_numero_documento"
        Me.lbl_numero_documento.Size = New System.Drawing.Size(47, 13)
        Me.lbl_numero_documento.TabIndex = 1
        Me.lbl_numero_documento.Text = "Número:"
        '
        'lbl_nombre
        '
        Me.lbl_nombre.AutoSize = True
        Me.lbl_nombre.Location = New System.Drawing.Point(74, 30)
        Me.lbl_nombre.Name = "lbl_nombre"
        Me.lbl_nombre.Size = New System.Drawing.Size(47, 13)
        Me.lbl_nombre.TabIndex = 1
        Me.lbl_nombre.Text = "Nombre:"
        '
        'lbl_apellido
        '
        Me.lbl_apellido.AutoSize = True
        Me.lbl_apellido.Location = New System.Drawing.Point(74, 76)
        Me.lbl_apellido.Name = "lbl_apellido"
        Me.lbl_apellido.Size = New System.Drawing.Size(47, 13)
        Me.lbl_apellido.TabIndex = 1
        Me.lbl_apellido.Text = "Apellido:"
        '
        'lbl_calle
        '
        Me.lbl_calle.AutoSize = True
        Me.lbl_calle.Location = New System.Drawing.Point(78, 114)
        Me.lbl_calle.Name = "lbl_calle"
        Me.lbl_calle.Size = New System.Drawing.Size(33, 13)
        Me.lbl_calle.TabIndex = 1
        Me.lbl_calle.Text = "Calle:"
        '
        'lbl_fecha_nacimiento
        '
        Me.lbl_fecha_nacimiento.AutoSize = True
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
        Me.cmb_tipo_documento.FormattingEnabled = True
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
        Me.txt_calle.Location = New System.Drawing.Point(127, 111)
        Me.txt_calle.Name = "txt_calle"
        Me.txt_calle.Size = New System.Drawing.Size(100, 20)
        Me.txt_calle.TabIndex = 0
        '
        'lbl_numero_calle
        '
        Me.lbl_numero_calle.AutoSize = True
        Me.lbl_numero_calle.Location = New System.Drawing.Point(234, 114)
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
        Me.grp_datos.TabStop = False
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
        Me.grp_domicilio.Controls.Add(Me.Label3)
        Me.grp_domicilio.Controls.Add(Me.cmb_provincia)
        Me.grp_domicilio.Controls.Add(Me.lbl_localidad)
        Me.grp_domicilio.Controls.Add(Me.cmb_localidad)
        Me.grp_domicilio.Controls.Add(Me.txt_numero_calle)
        Me.grp_domicilio.Controls.Add(Me.lbl_calle)
        Me.grp_domicilio.Controls.Add(Me.txt_calle)
        Me.grp_domicilio.Controls.Add(Me.lbl_numero_calle)
        Me.grp_domicilio.Controls.Add(Me.Label1)
        Me.grp_domicilio.Controls.Add(Me.cmb_barrio)
        Me.grp_domicilio.Location = New System.Drawing.Point(6, 212)
        Me.grp_domicilio.Name = "grp_domicilio"
        Me.grp_domicilio.Size = New System.Drawing.Size(353, 137)
        Me.grp_domicilio.TabIndex = 10
        Me.grp_domicilio.TabStop = False
        Me.grp_domicilio.Text = "Domicilio"
        '
        'txt_numero_calle
        '
        Me.txt_numero_calle.Location = New System.Drawing.Point(287, 111)
        Me.txt_numero_calle.Name = "txt_numero_calle"
        Me.txt_numero_calle.Size = New System.Drawing.Size(57, 20)
        Me.txt_numero_calle.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(74, 87)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(37, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Barrio:"
        '
        'cmb_barrio
        '
        Me.cmb_barrio.FormattingEnabled = True
        Me.cmb_barrio.Location = New System.Drawing.Point(127, 84)
        Me.cmb_barrio.Name = "cmb_barrio"
        Me.cmb_barrio.Size = New System.Drawing.Size(217, 21)
        Me.cmb_barrio.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(298, 368)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(49, 13)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "Cancelar"
        '
        'lbl_guardar
        '
        Me.lbl_guardar.AutoSize = True
        Me.lbl_guardar.Location = New System.Drawing.Point(25, 368)
        Me.lbl_guardar.Name = "lbl_guardar"
        Me.lbl_guardar.Size = New System.Drawing.Size(45, 13)
        Me.lbl_guardar.TabIndex = 11
        Me.lbl_guardar.Text = "Guardar"
        '
        'cmd_cancelar
        '
        Me.cmd_cancelar.BackgroundImage = Global.Heladeria_Tu_Gusto.My.Resources.Resources.icons8_Delete_40
        Me.cmd_cancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.cmd_cancelar.Location = New System.Drawing.Point(284, 384)
        Me.cmd_cancelar.Name = "cmd_cancelar"
        Me.cmd_cancelar.Size = New System.Drawing.Size(75, 46)
        Me.cmd_cancelar.TabIndex = 1
        Me.cmd_cancelar.UseVisualStyleBackColor = True
        '
        'cmd_guardar
        '
        Me.cmd_guardar.BackgroundImage = Global.Heladeria_Tu_Gusto.My.Resources.Resources.icons8_Add_New_40
        Me.cmd_guardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.cmd_guardar.Location = New System.Drawing.Point(9, 384)
        Me.cmd_guardar.Name = "cmd_guardar"
        Me.cmd_guardar.Size = New System.Drawing.Size(75, 46)
        Me.cmd_guardar.TabIndex = 0
        Me.cmd_guardar.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(68, 22)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(54, 13)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Provincia:"
        '
        'cmb_provincia
        '
        Me.cmb_provincia.FormattingEnabled = True
        Me.cmb_provincia.Location = New System.Drawing.Point(127, 19)
        Me.cmb_provincia.Name = "cmb_provincia"
        Me.cmb_provincia.Size = New System.Drawing.Size(220, 21)
        Me.cmb_provincia.TabIndex = 9
        '
        'lbl_localidad
        '
        Me.lbl_localidad.AutoSize = True
        Me.lbl_localidad.Location = New System.Drawing.Point(68, 54)
        Me.lbl_localidad.Name = "lbl_localidad"
        Me.lbl_localidad.Size = New System.Drawing.Size(56, 13)
        Me.lbl_localidad.TabIndex = 6
        Me.lbl_localidad.Text = "Localidad:"
        '
        'cmb_localidad
        '
        Me.cmb_localidad.FormattingEnabled = True
        Me.cmb_localidad.Location = New System.Drawing.Point(127, 51)
        Me.cmb_localidad.Name = "cmb_localidad"
        Me.cmb_localidad.Size = New System.Drawing.Size(220, 21)
        Me.cmb_localidad.TabIndex = 7
        '
        'RegistrarEmpleado
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(362, 442)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lbl_guardar)
        Me.Controls.Add(Me.grp_domicilio)
        Me.Controls.Add(Me.grp_datos)
        Me.Controls.Add(Me.cmd_cancelar)
        Me.Controls.Add(Me.cmd_guardar)
        Me.Icon = CType(resources.GetObject("$this.Icon"),System.Drawing.Icon)
        Me.Name = "RegistrarEmpleado"
        Me.Text = "Registrar empleado"
        Me.grp_datos.ResumeLayout(false)
        Me.grp_datos.PerformLayout
        Me.grp_domicilio.ResumeLayout(false)
        Me.grp_domicilio.PerformLayout
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub
    Friend WithEvents lbl_tipo_documento As Label
    Friend WithEvents lbl_numero_documento As Label
    Friend WithEvents lbl_nombre As Label
    Friend WithEvents lbl_apellido As Label
    Friend WithEvents lbl_calle As Label
    Friend WithEvents lbl_fecha_nacimiento As Label
    Friend WithEvents txt_nombre As TextBox
    Friend WithEvents txt_apellido As TextBox
    Friend WithEvents cmb_tipo_documento As ComboBox
    Friend WithEvents date_fecha_nacimiento As DateTimePicker
    Friend WithEvents txt_calle As TextBox
    Friend WithEvents cmd_cancelar As Button
    Friend WithEvents cmd_guardar As Button
    Friend WithEvents lbl_numero_calle As Label
    Friend WithEvents grp_datos As GroupBox
    Friend WithEvents grp_domicilio As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents cmb_barrio As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents lbl_guardar As Label
    Friend WithEvents txt_numero_documento As MaskedTextBox
    Friend WithEvents txt_numero_calle As TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cmb_provincia As System.Windows.Forms.ComboBox
    Friend WithEvents lbl_localidad As System.Windows.Forms.Label
    Friend WithEvents cmb_localidad As System.Windows.Forms.ComboBox
End Class
