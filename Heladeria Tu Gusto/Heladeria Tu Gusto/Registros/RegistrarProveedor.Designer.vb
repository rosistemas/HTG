Imports System.ComponentModel
Imports Microsoft.VisualBasic.CompilerServices

<DesignerGenerated()> _
Partial Class RegistrarProveedor
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RegistrarProveedor))
        Me.grp_domicilio = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cmb_provincia = New System.Windows.Forms.ComboBox()
        Me.txt_numero_calle = New System.Windows.Forms.TextBox()
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
        Me.cmd_cancelar = New System.Windows.Forms.Button()
        Me.cmd_guardar = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lbl_guardar = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cmb_producto = New System.Windows.Forms.ComboBox()
        Me.grp_domicilio.SuspendLayout()
        Me.grp_datos.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'grp_domicilio
        '
        Me.grp_domicilio.Controls.Add(Me.Label3)
        Me.grp_domicilio.Controls.Add(Me.cmb_provincia)
        Me.grp_domicilio.Controls.Add(Me.txt_numero_calle)
        Me.grp_domicilio.Controls.Add(Me.lbl_calle)
        Me.grp_domicilio.Controls.Add(Me.txt_calle)
        Me.grp_domicilio.Controls.Add(Me.lbl_numero_calle)
        Me.grp_domicilio.Controls.Add(Me.Label1)
        Me.grp_domicilio.Controls.Add(Me.lbl_localidad)
        Me.grp_domicilio.Controls.Add(Me.cmb_barrio)
        Me.grp_domicilio.Controls.Add(Me.cmb_localidad)
        Me.grp_domicilio.Location = New System.Drawing.Point(12, 160)
        Me.grp_domicilio.Name = "grp_domicilio"
        Me.grp_domicilio.Size = New System.Drawing.Size(353, 159)
        Me.grp_domicilio.TabIndex = 14
        Me.grp_domicilio.TabStop = False
        Me.grp_domicilio.Text = "Domicilio"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(65, 26)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(54, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Provincia:"
        '
        'cmb_provincia
        '
        Me.cmb_provincia.FormattingEnabled = True
        Me.cmb_provincia.Location = New System.Drawing.Point(124, 23)
        Me.cmb_provincia.Name = "cmb_provincia"
        Me.cmb_provincia.Size = New System.Drawing.Size(220, 21)
        Me.cmb_provincia.TabIndex = 5
        '
        'txt_numero_calle
        '
        Me.txt_numero_calle.Location = New System.Drawing.Point(285, 119)
        Me.txt_numero_calle.Name = "txt_numero_calle"
        Me.txt_numero_calle.Size = New System.Drawing.Size(59, 20)
        Me.txt_numero_calle.TabIndex = 1
        '
        'lbl_calle
        '
        Me.lbl_calle.AutoSize = True
        Me.lbl_calle.Location = New System.Drawing.Point(85, 122)
        Me.lbl_calle.Name = "lbl_calle"
        Me.lbl_calle.Size = New System.Drawing.Size(33, 13)
        Me.lbl_calle.TabIndex = 1
        Me.lbl_calle.Text = "Calle:"
        '
        'txt_calle
        '
        Me.txt_calle.Location = New System.Drawing.Point(124, 119)
        Me.txt_calle.Name = "txt_calle"
        Me.txt_calle.Size = New System.Drawing.Size(100, 20)
        Me.txt_calle.TabIndex = 0
        '
        'lbl_numero_calle
        '
        Me.lbl_numero_calle.AutoSize = True
        Me.lbl_numero_calle.Location = New System.Drawing.Point(234, 122)
        Me.lbl_numero_calle.Name = "lbl_numero_calle"
        Me.lbl_numero_calle.Size = New System.Drawing.Size(47, 13)
        Me.lbl_numero_calle.TabIndex = 1
        Me.lbl_numero_calle.Text = "Número:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(81, 85)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(37, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Barrio:"
        '
        'lbl_localidad
        '
        Me.lbl_localidad.AutoSize = True
        Me.lbl_localidad.Location = New System.Drawing.Point(65, 58)
        Me.lbl_localidad.Name = "lbl_localidad"
        Me.lbl_localidad.Size = New System.Drawing.Size(56, 13)
        Me.lbl_localidad.TabIndex = 1
        Me.lbl_localidad.Text = "Localidad:"
        '
        'cmb_barrio
        '
        Me.cmb_barrio.FormattingEnabled = True
        Me.cmb_barrio.Location = New System.Drawing.Point(124, 82)
        Me.cmb_barrio.Name = "cmb_barrio"
        Me.cmb_barrio.Size = New System.Drawing.Size(220, 21)
        Me.cmb_barrio.TabIndex = 3
        '
        'cmb_localidad
        '
        Me.cmb_localidad.FormattingEnabled = True
        Me.cmb_localidad.Location = New System.Drawing.Point(124, 55)
        Me.cmb_localidad.Name = "cmb_localidad"
        Me.cmb_localidad.Size = New System.Drawing.Size(220, 21)
        Me.cmb_localidad.TabIndex = 2
        '
        'grp_datos
        '
        Me.grp_datos.Controls.Add(Me.txt_numero_documento)
        Me.grp_datos.Controls.Add(Me.txt_razon_social)
        Me.grp_datos.Controls.Add(Me.txt_nombre)
        Me.grp_datos.Controls.Add(Me.lbl_tipo_documento)
        Me.grp_datos.Controls.Add(Me.lbl_numero_documento)
        Me.grp_datos.Controls.Add(Me.lbl_nombre)
        Me.grp_datos.Controls.Add(Me.lbl_mail)
        Me.grp_datos.Controls.Add(Me.lbl_razon_social)
        Me.grp_datos.Controls.Add(Me.txt_mail)
        Me.grp_datos.Controls.Add(Me.cmb_tipo_documento)
        Me.grp_datos.Location = New System.Drawing.Point(12, 12)
        Me.grp_datos.Name = "grp_datos"
        Me.grp_datos.Size = New System.Drawing.Size(353, 142)
        Me.grp_datos.TabIndex = 13
        Me.grp_datos.TabStop = False
        Me.grp_datos.Text = "Datos personales"
        '
        'txt_numero_documento
        '
        Me.txt_numero_documento.Location = New System.Drawing.Point(285, 81)
        Me.txt_numero_documento.Mask = "99999999"
        Me.txt_numero_documento.Name = "txt_numero_documento"
        Me.txt_numero_documento.Size = New System.Drawing.Size(60, 20)
        Me.txt_numero_documento.TabIndex = 3
        '
        'txt_razon_social
        '
        Me.txt_razon_social.Location = New System.Drawing.Point(125, 108)
        Me.txt_razon_social.Name = "txt_razon_social"
        Me.txt_razon_social.Size = New System.Drawing.Size(220, 20)
        Me.txt_razon_social.TabIndex = 4
        '
        'txt_nombre
        '
        Me.txt_nombre.Location = New System.Drawing.Point(125, 29)
        Me.txt_nombre.Name = "txt_nombre"
        Me.txt_nombre.Size = New System.Drawing.Size(220, 20)
        Me.txt_nombre.TabIndex = 0
        '
        'lbl_tipo_documento
        '
        Me.lbl_tipo_documento.AutoSize = True
        Me.lbl_tipo_documento.Location = New System.Drawing.Point(17, 84)
        Me.lbl_tipo_documento.Name = "lbl_tipo_documento"
        Me.lbl_tipo_documento.Size = New System.Drawing.Size(102, 13)
        Me.lbl_tipo_documento.TabIndex = 1
        Me.lbl_tipo_documento.Text = "Tipo de documento:"
        '
        'lbl_numero_documento
        '
        Me.lbl_numero_documento.AutoSize = True
        Me.lbl_numero_documento.Location = New System.Drawing.Point(234, 84)
        Me.lbl_numero_documento.Name = "lbl_numero_documento"
        Me.lbl_numero_documento.Size = New System.Drawing.Size(47, 13)
        Me.lbl_numero_documento.TabIndex = 1
        Me.lbl_numero_documento.Text = "Número:"
        '
        'lbl_nombre
        '
        Me.lbl_nombre.AutoSize = True
        Me.lbl_nombre.Location = New System.Drawing.Point(71, 32)
        Me.lbl_nombre.Name = "lbl_nombre"
        Me.lbl_nombre.Size = New System.Drawing.Size(47, 13)
        Me.lbl_nombre.TabIndex = 1
        Me.lbl_nombre.Text = "Nombre:"
        '
        'lbl_mail
        '
        Me.lbl_mail.AutoSize = True
        Me.lbl_mail.Location = New System.Drawing.Point(89, 59)
        Me.lbl_mail.Name = "lbl_mail"
        Me.lbl_mail.Size = New System.Drawing.Size(29, 13)
        Me.lbl_mail.TabIndex = 1
        Me.lbl_mail.Text = "Mail:"
        '
        'lbl_razon_social
        '
        Me.lbl_razon_social.AutoSize = True
        Me.lbl_razon_social.Location = New System.Drawing.Point(47, 111)
        Me.lbl_razon_social.Name = "lbl_razon_social"
        Me.lbl_razon_social.Size = New System.Drawing.Size(71, 13)
        Me.lbl_razon_social.TabIndex = 1
        Me.lbl_razon_social.Text = "Razón social:"
        '
        'txt_mail
        '
        Me.txt_mail.Location = New System.Drawing.Point(125, 55)
        Me.txt_mail.Name = "txt_mail"
        Me.txt_mail.Size = New System.Drawing.Size(220, 20)
        Me.txt_mail.TabIndex = 1
        '
        'cmb_tipo_documento
        '
        Me.cmb_tipo_documento.FormattingEnabled = True
        Me.cmb_tipo_documento.Location = New System.Drawing.Point(125, 81)
        Me.cmb_tipo_documento.Name = "cmb_tipo_documento"
        Me.cmb_tipo_documento.Size = New System.Drawing.Size(100, 21)
        Me.cmb_tipo_documento.TabIndex = 2
        '
        'cmd_cancelar
        '
        Me.cmd_cancelar.BackgroundImage = Global.Heladeria_Tu_Gusto.My.Resources.Resources.icons8_Delete_40
        Me.cmd_cancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.cmd_cancelar.Location = New System.Drawing.Point(290, 417)
        Me.cmd_cancelar.Name = "cmd_cancelar"
        Me.cmd_cancelar.Size = New System.Drawing.Size(75, 46)
        Me.cmd_cancelar.TabIndex = 1
        Me.cmd_cancelar.UseVisualStyleBackColor = True
        '
        'cmd_guardar
        '
        Me.cmd_guardar.BackgroundImage = Global.Heladeria_Tu_Gusto.My.Resources.Resources.icons8_Add_New_40
        Me.cmd_guardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.cmd_guardar.Location = New System.Drawing.Point(12, 417)
        Me.cmd_guardar.Name = "cmd_guardar"
        Me.cmd_guardar.Size = New System.Drawing.Size(75, 46)
        Me.cmd_guardar.TabIndex = 0
        Me.cmd_guardar.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(303, 401)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(49, 13)
        Me.Label2.TabIndex = 16
        Me.Label2.Text = "Cancelar"
        '
        'lbl_guardar
        '
        Me.lbl_guardar.AutoSize = True
        Me.lbl_guardar.Location = New System.Drawing.Point(27, 401)
        Me.lbl_guardar.Name = "lbl_guardar"
        Me.lbl_guardar.Size = New System.Drawing.Size(45, 13)
        Me.lbl_guardar.TabIndex = 15
        Me.lbl_guardar.Text = "Guardar"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cmb_producto)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 325)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(353, 67)
        Me.GroupBox1.TabIndex = 17
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Producto"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 32)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(120, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Seleccione un producto"
        '
        'cmb_producto
        '
        Me.cmb_producto.FormattingEnabled = True
        Me.cmb_producto.Location = New System.Drawing.Point(160, 29)
        Me.cmb_producto.Name = "cmb_producto"
        Me.cmb_producto.Size = New System.Drawing.Size(180, 21)
        Me.cmb_producto.TabIndex = 7
        '
        'RegistrarProveedor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(387, 473)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lbl_guardar)
        Me.Controls.Add(Me.grp_domicilio)
        Me.Controls.Add(Me.grp_datos)
        Me.Controls.Add(Me.cmd_cancelar)
        Me.Controls.Add(Me.cmd_guardar)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "RegistrarProveedor"
        Me.Text = "Registrar proveedor"
        Me.grp_domicilio.ResumeLayout(False)
        Me.grp_domicilio.PerformLayout()
        Me.grp_datos.ResumeLayout(False)
        Me.grp_datos.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout

End Sub
    Friend WithEvents grp_domicilio As GroupBox
    Friend WithEvents lbl_calle As Label
    Friend WithEvents txt_calle As TextBox
    Friend WithEvents lbl_numero_calle As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents lbl_localidad As Label
    Friend WithEvents cmb_barrio As ComboBox
    Friend WithEvents cmb_localidad As ComboBox
    Friend WithEvents grp_datos As GroupBox
    Friend WithEvents txt_nombre As TextBox
    Friend WithEvents lbl_nombre As Label
    Friend WithEvents lbl_mail As Label
    Friend WithEvents txt_mail As TextBox
    Friend WithEvents cmd_cancelar As Button
    Friend WithEvents cmd_guardar As Button
    Friend WithEvents txt_razon_social As TextBox
    Friend WithEvents lbl_tipo_documento As Label
    Friend WithEvents lbl_razon_social As Label
    Friend WithEvents cmb_tipo_documento As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents lbl_guardar As Label
    Friend WithEvents txt_numero_documento As MaskedTextBox
    Private WithEvents lbl_numero_documento As Label
    Friend WithEvents txt_numero_calle As TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cmb_provincia As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents cmb_producto As System.Windows.Forms.ComboBox
End Class
