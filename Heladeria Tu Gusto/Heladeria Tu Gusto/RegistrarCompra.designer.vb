<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RegistrarCompra
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lbl_guardar = New System.Windows.Forms.Label()
        Me.btn_cancelar = New System.Windows.Forms.Button()
        Me.btn_guardar = New System.Windows.Forms.Button()
        Me.cmb_empleado = New System.Windows.Forms.ComboBox()
        Me.grp_detalle_de_proveedor = New System.Windows.Forms.GroupBox()
        Me.grd_telefonos = New System.Windows.Forms.DataGridView()
        Me.col_tipo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_numero = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lbl_mail_proveedor = New System.Windows.Forms.Label()
        Me.lbl_telefonos = New System.Windows.Forms.Label()
        Me.lbl_razon_social_proveedor = New System.Windows.Forms.Label()
        Me.lbl_nombre_proveedor = New System.Windows.Forms.Label()
        Me.lbl_display_mail_proveedor = New System.Windows.Forms.Label()
        Me.lbl_display_razon_social_proveedor = New System.Windows.Forms.Label()
        Me.lbl_id_proveedor = New System.Windows.Forms.Label()
        Me.lbl_display_nombre_proveedor = New System.Windows.Forms.Label()
        Me.lbl_display_id_proveedor = New System.Windows.Forms.Label()
        Me.lbl_total_display = New System.Windows.Forms.Label()
        Me.lbl_id_compra_display = New System.Windows.Forms.Label()
        Me.lbl_info_empleado = New System.Windows.Forms.Label()
        Me.lbl_id = New System.Windows.Forms.Label()
        Me.lbl_total = New System.Windows.Forms.Label()
        Me.lbl_empleado = New System.Windows.Forms.Label()
        Me.grp_producto = New System.Windows.Forms.GroupBox()
        Me.msk_precio = New System.Windows.Forms.MaskedTextBox()
        Me.msk_cantidad = New System.Windows.Forms.MaskedTextBox()
        Me.lbl_precio = New System.Windows.Forms.Label()
        Me.lbl_cantidad = New System.Windows.Forms.Label()
        Me.lbl_producto = New System.Windows.Forms.Label()
        Me.cmb_producto = New System.Windows.Forms.ComboBox()
        Me.grp_detalle_de_proveedor.SuspendLayout()
        CType(Me.grd_telefonos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grp_producto.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(417, 387)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(49, 13)
        Me.Label2.TabIndex = 30
        Me.Label2.Text = "Cancelar"
        '
        'lbl_guardar
        '
        Me.lbl_guardar.AutoSize = True
        Me.lbl_guardar.Location = New System.Drawing.Point(27, 387)
        Me.lbl_guardar.Name = "lbl_guardar"
        Me.lbl_guardar.Size = New System.Drawing.Size(45, 13)
        Me.lbl_guardar.TabIndex = 29
        Me.lbl_guardar.Text = "Guardar"
        '
        'btn_cancelar
        '
        Me.btn_cancelar.Image = Global.Heladeria_Tu_Gusto.My.Resources.Resources.icons8_Delete_40
        Me.btn_cancelar.Location = New System.Drawing.Point(404, 403)
        Me.btn_cancelar.Name = "btn_cancelar"
        Me.btn_cancelar.Size = New System.Drawing.Size(75, 46)
        Me.btn_cancelar.TabIndex = 3
        Me.btn_cancelar.UseVisualStyleBackColor = True
        '
        'btn_guardar
        '
        Me.btn_guardar.Image = Global.Heladeria_Tu_Gusto.My.Resources.Resources.icons8_Add_New_40
        Me.btn_guardar.Location = New System.Drawing.Point(12, 403)
        Me.btn_guardar.Name = "btn_guardar"
        Me.btn_guardar.Size = New System.Drawing.Size(75, 46)
        Me.btn_guardar.TabIndex = 2
        Me.btn_guardar.UseVisualStyleBackColor = True
        '
        'cmb_empleado
        '
        Me.cmb_empleado.FormattingEnabled = True
        Me.cmb_empleado.Location = New System.Drawing.Point(83, 40)
        Me.cmb_empleado.Name = "cmb_empleado"
        Me.cmb_empleado.Size = New System.Drawing.Size(57, 21)
        Me.cmb_empleado.TabIndex = 0
        '
        'grp_detalle_de_proveedor
        '
        Me.grp_detalle_de_proveedor.BackColor = System.Drawing.Color.Transparent
        Me.grp_detalle_de_proveedor.Controls.Add(Me.grd_telefonos)
        Me.grp_detalle_de_proveedor.Controls.Add(Me.lbl_mail_proveedor)
        Me.grp_detalle_de_proveedor.Controls.Add(Me.lbl_telefonos)
        Me.grp_detalle_de_proveedor.Controls.Add(Me.lbl_razon_social_proveedor)
        Me.grp_detalle_de_proveedor.Controls.Add(Me.lbl_nombre_proveedor)
        Me.grp_detalle_de_proveedor.Controls.Add(Me.lbl_display_mail_proveedor)
        Me.grp_detalle_de_proveedor.Controls.Add(Me.lbl_display_razon_social_proveedor)
        Me.grp_detalle_de_proveedor.Controls.Add(Me.lbl_id_proveedor)
        Me.grp_detalle_de_proveedor.Controls.Add(Me.lbl_display_nombre_proveedor)
        Me.grp_detalle_de_proveedor.Controls.Add(Me.lbl_display_id_proveedor)
        Me.grp_detalle_de_proveedor.ForeColor = System.Drawing.Color.Navy
        Me.grp_detalle_de_proveedor.Location = New System.Drawing.Point(12, 196)
        Me.grp_detalle_de_proveedor.Name = "grp_detalle_de_proveedor"
        Me.grp_detalle_de_proveedor.Size = New System.Drawing.Size(466, 175)
        Me.grp_detalle_de_proveedor.TabIndex = 24
        Me.grp_detalle_de_proveedor.TabStop = False
        Me.grp_detalle_de_proveedor.Text = "Detalle de Proveedor"
        '
        'grd_telefonos
        '
        Me.grd_telefonos.AllowUserToAddRows = False
        Me.grd_telefonos.AllowUserToDeleteRows = False
        Me.grd_telefonos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grd_telefonos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.col_tipo, Me.col_numero})
        Me.grd_telefonos.Location = New System.Drawing.Point(244, 41)
        Me.grd_telefonos.Name = "grd_telefonos"
        Me.grd_telefonos.ReadOnly = True
        Me.grd_telefonos.Size = New System.Drawing.Size(216, 118)
        Me.grd_telefonos.TabIndex = 21
        '
        'col_tipo
        '
        Me.col_tipo.HeaderText = "TIPO"
        Me.col_tipo.Name = "col_tipo"
        Me.col_tipo.ReadOnly = True
        Me.col_tipo.Width = 72
        '
        'col_numero
        '
        Me.col_numero.HeaderText = "NÚMERO"
        Me.col_numero.Name = "col_numero"
        Me.col_numero.ReadOnly = True
        '
        'lbl_mail_proveedor
        '
        Me.lbl_mail_proveedor.AutoSize = True
        Me.lbl_mail_proveedor.ForeColor = System.Drawing.Color.Black
        Me.lbl_mail_proveedor.Location = New System.Drawing.Point(26, 143)
        Me.lbl_mail_proveedor.Name = "lbl_mail_proveedor"
        Me.lbl_mail_proveedor.Size = New System.Drawing.Size(29, 13)
        Me.lbl_mail_proveedor.TabIndex = 0
        Me.lbl_mail_proveedor.Text = "Mail:"
        '
        'lbl_telefonos
        '
        Me.lbl_telefonos.AutoSize = True
        Me.lbl_telefonos.ForeColor = System.Drawing.Color.Navy
        Me.lbl_telefonos.Location = New System.Drawing.Point(241, 16)
        Me.lbl_telefonos.Name = "lbl_telefonos"
        Me.lbl_telefonos.Size = New System.Drawing.Size(113, 13)
        Me.lbl_telefonos.TabIndex = 0
        Me.lbl_telefonos.Text = "Teléfonos Registrados"
        '
        'lbl_razon_social_proveedor
        '
        Me.lbl_razon_social_proveedor.AutoSize = True
        Me.lbl_razon_social_proveedor.ForeColor = System.Drawing.Color.Black
        Me.lbl_razon_social_proveedor.Location = New System.Drawing.Point(21, 80)
        Me.lbl_razon_social_proveedor.Name = "lbl_razon_social_proveedor"
        Me.lbl_razon_social_proveedor.Size = New System.Drawing.Size(73, 13)
        Me.lbl_razon_social_proveedor.TabIndex = 0
        Me.lbl_razon_social_proveedor.Text = "Razón Social:"
        '
        'lbl_nombre_proveedor
        '
        Me.lbl_nombre_proveedor.AutoSize = True
        Me.lbl_nombre_proveedor.ForeColor = System.Drawing.Color.Black
        Me.lbl_nombre_proveedor.Location = New System.Drawing.Point(8, 112)
        Me.lbl_nombre_proveedor.Name = "lbl_nombre_proveedor"
        Me.lbl_nombre_proveedor.Size = New System.Drawing.Size(47, 13)
        Me.lbl_nombre_proveedor.TabIndex = 0
        Me.lbl_nombre_proveedor.Text = "Nombre:"
        '
        'lbl_display_mail_proveedor
        '
        Me.lbl_display_mail_proveedor.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.lbl_display_mail_proveedor.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_display_mail_proveedor.ForeColor = System.Drawing.Color.Black
        Me.lbl_display_mail_proveedor.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lbl_display_mail_proveedor.Location = New System.Drawing.Point(61, 138)
        Me.lbl_display_mail_proveedor.Name = "lbl_display_mail_proveedor"
        Me.lbl_display_mail_proveedor.Size = New System.Drawing.Size(177, 21)
        Me.lbl_display_mail_proveedor.TabIndex = 20
        Me.lbl_display_mail_proveedor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl_display_razon_social_proveedor
        '
        Me.lbl_display_razon_social_proveedor.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.lbl_display_razon_social_proveedor.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_display_razon_social_proveedor.ForeColor = System.Drawing.Color.Black
        Me.lbl_display_razon_social_proveedor.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lbl_display_razon_social_proveedor.Location = New System.Drawing.Point(97, 75)
        Me.lbl_display_razon_social_proveedor.Name = "lbl_display_razon_social_proveedor"
        Me.lbl_display_razon_social_proveedor.Size = New System.Drawing.Size(141, 21)
        Me.lbl_display_razon_social_proveedor.TabIndex = 20
        Me.lbl_display_razon_social_proveedor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl_id_proveedor
        '
        Me.lbl_id_proveedor.AutoSize = True
        Me.lbl_id_proveedor.ForeColor = System.Drawing.Color.Black
        Me.lbl_id_proveedor.Location = New System.Drawing.Point(34, 32)
        Me.lbl_id_proveedor.Name = "lbl_id_proveedor"
        Me.lbl_id_proveedor.Size = New System.Drawing.Size(21, 13)
        Me.lbl_id_proveedor.TabIndex = 0
        Me.lbl_id_proveedor.Text = "ID:"
        '
        'lbl_display_nombre_proveedor
        '
        Me.lbl_display_nombre_proveedor.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.lbl_display_nombre_proveedor.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_display_nombre_proveedor.ForeColor = System.Drawing.Color.Black
        Me.lbl_display_nombre_proveedor.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lbl_display_nombre_proveedor.Location = New System.Drawing.Point(61, 107)
        Me.lbl_display_nombre_proveedor.Name = "lbl_display_nombre_proveedor"
        Me.lbl_display_nombre_proveedor.Size = New System.Drawing.Size(177, 21)
        Me.lbl_display_nombre_proveedor.TabIndex = 20
        Me.lbl_display_nombre_proveedor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl_display_id_proveedor
        '
        Me.lbl_display_id_proveedor.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.lbl_display_id_proveedor.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_display_id_proveedor.ForeColor = System.Drawing.Color.Black
        Me.lbl_display_id_proveedor.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lbl_display_id_proveedor.Location = New System.Drawing.Point(61, 27)
        Me.lbl_display_id_proveedor.Name = "lbl_display_id_proveedor"
        Me.lbl_display_id_proveedor.Size = New System.Drawing.Size(49, 21)
        Me.lbl_display_id_proveedor.TabIndex = 20
        Me.lbl_display_id_proveedor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl_total_display
        '
        Me.lbl_total_display.BackColor = System.Drawing.Color.Silver
        Me.lbl_total_display.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_total_display.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lbl_total_display.Location = New System.Drawing.Point(197, 411)
        Me.lbl_total_display.Name = "lbl_total_display"
        Me.lbl_total_display.Size = New System.Drawing.Size(138, 25)
        Me.lbl_total_display.TabIndex = 18
        Me.lbl_total_display.Text = "0"
        Me.lbl_total_display.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbl_id_compra_display
        '
        Me.lbl_id_compra_display.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_id_compra_display.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lbl_id_compra_display.Location = New System.Drawing.Point(410, 11)
        Me.lbl_id_compra_display.Name = "lbl_id_compra_display"
        Me.lbl_id_compra_display.Size = New System.Drawing.Size(71, 13)
        Me.lbl_id_compra_display.TabIndex = 19
        Me.lbl_id_compra_display.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lbl_info_empleado
        '
        Me.lbl_info_empleado.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.lbl_info_empleado.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_info_empleado.ForeColor = System.Drawing.Color.Black
        Me.lbl_info_empleado.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lbl_info_empleado.Location = New System.Drawing.Point(146, 40)
        Me.lbl_info_empleado.Name = "lbl_info_empleado"
        Me.lbl_info_empleado.Size = New System.Drawing.Size(149, 21)
        Me.lbl_info_empleado.TabIndex = 20
        Me.lbl_info_empleado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl_id
        '
        Me.lbl_id.AutoSize = True
        Me.lbl_id.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_id.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lbl_id.Location = New System.Drawing.Point(352, 11)
        Me.lbl_id.Name = "lbl_id"
        Me.lbl_id.Size = New System.Drawing.Size(58, 13)
        Me.lbl_id.TabIndex = 21
        Me.lbl_id.Text = "Id Compra:"
        '
        'lbl_total
        '
        Me.lbl_total.AutoSize = True
        Me.lbl_total.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_total.Location = New System.Drawing.Point(136, 411)
        Me.lbl_total.Name = "lbl_total"
        Me.lbl_total.Size = New System.Drawing.Size(66, 25)
        Me.lbl_total.TabIndex = 22
        Me.lbl_total.Text = "Total:"
        '
        'lbl_empleado
        '
        Me.lbl_empleado.AutoSize = True
        Me.lbl_empleado.Location = New System.Drawing.Point(20, 43)
        Me.lbl_empleado.Name = "lbl_empleado"
        Me.lbl_empleado.Size = New System.Drawing.Size(57, 13)
        Me.lbl_empleado.TabIndex = 23
        Me.lbl_empleado.Text = "Empleado:"
        '
        'grp_producto
        '
        Me.grp_producto.BackColor = System.Drawing.Color.Transparent
        Me.grp_producto.Controls.Add(Me.msk_precio)
        Me.grp_producto.Controls.Add(Me.msk_cantidad)
        Me.grp_producto.Controls.Add(Me.lbl_precio)
        Me.grp_producto.Controls.Add(Me.lbl_cantidad)
        Me.grp_producto.Controls.Add(Me.lbl_producto)
        Me.grp_producto.Controls.Add(Me.cmb_producto)
        Me.grp_producto.ForeColor = System.Drawing.Color.Navy
        Me.grp_producto.Location = New System.Drawing.Point(12, 84)
        Me.grp_producto.Name = "grp_producto"
        Me.grp_producto.Size = New System.Drawing.Size(466, 97)
        Me.grp_producto.TabIndex = 1
        Me.grp_producto.TabStop = False
        Me.grp_producto.Text = "Seleccionar Producto"
        '
        'msk_precio
        '
        Me.msk_precio.Location = New System.Drawing.Point(315, 58)
        Me.msk_precio.Mask = "999.99"
        Me.msk_precio.Name = "msk_precio"
        Me.msk_precio.Size = New System.Drawing.Size(145, 20)
        Me.msk_precio.TabIndex = 2
        '
        'msk_cantidad
        '
        Me.msk_cantidad.Location = New System.Drawing.Point(71, 58)
        Me.msk_cantidad.Mask = "999"
        Me.msk_cantidad.Name = "msk_cantidad"
        Me.msk_cantidad.Size = New System.Drawing.Size(139, 20)
        Me.msk_cantidad.TabIndex = 1
        '
        'lbl_precio
        '
        Me.lbl_precio.AutoSize = True
        Me.lbl_precio.ForeColor = System.Drawing.Color.Black
        Me.lbl_precio.Location = New System.Drawing.Point(216, 61)
        Me.lbl_precio.Name = "lbl_precio"
        Me.lbl_precio.Size = New System.Drawing.Size(93, 13)
        Me.lbl_precio.TabIndex = 0
        Me.lbl_precio.Text = "Precio por unidad:"
        '
        'lbl_cantidad
        '
        Me.lbl_cantidad.AutoSize = True
        Me.lbl_cantidad.ForeColor = System.Drawing.Color.Black
        Me.lbl_cantidad.Location = New System.Drawing.Point(16, 61)
        Me.lbl_cantidad.Name = "lbl_cantidad"
        Me.lbl_cantidad.Size = New System.Drawing.Size(52, 13)
        Me.lbl_cantidad.TabIndex = 0
        Me.lbl_cantidad.Text = "Cantidad:"
        '
        'lbl_producto
        '
        Me.lbl_producto.AutoSize = True
        Me.lbl_producto.ForeColor = System.Drawing.Color.Black
        Me.lbl_producto.Location = New System.Drawing.Point(16, 32)
        Me.lbl_producto.Name = "lbl_producto"
        Me.lbl_producto.Size = New System.Drawing.Size(53, 13)
        Me.lbl_producto.TabIndex = 0
        Me.lbl_producto.Text = "Producto:"
        '
        'cmb_producto
        '
        Me.cmb_producto.FormattingEnabled = True
        Me.cmb_producto.Location = New System.Drawing.Point(71, 29)
        Me.cmb_producto.Name = "cmb_producto"
        Me.cmb_producto.Size = New System.Drawing.Size(389, 21)
        Me.cmb_producto.TabIndex = 0
        '
        'RegistrarCompra
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(493, 454)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lbl_guardar)
        Me.Controls.Add(Me.btn_cancelar)
        Me.Controls.Add(Me.btn_guardar)
        Me.Controls.Add(Me.cmb_empleado)
        Me.Controls.Add(Me.grp_detalle_de_proveedor)
        Me.Controls.Add(Me.lbl_total_display)
        Me.Controls.Add(Me.lbl_id_compra_display)
        Me.Controls.Add(Me.lbl_info_empleado)
        Me.Controls.Add(Me.lbl_id)
        Me.Controls.Add(Me.lbl_total)
        Me.Controls.Add(Me.lbl_empleado)
        Me.Controls.Add(Me.grp_producto)
        Me.Name = "RegistrarCompra"
        Me.Text = "Registrar Compra"
        Me.grp_detalle_de_proveedor.ResumeLayout(False)
        Me.grp_detalle_de_proveedor.PerformLayout()
        CType(Me.grd_telefonos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grp_producto.ResumeLayout(False)
        Me.grp_producto.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lbl_guardar As System.Windows.Forms.Label
    Friend WithEvents btn_cancelar As System.Windows.Forms.Button
    Friend WithEvents btn_guardar As System.Windows.Forms.Button
    Friend WithEvents cmb_empleado As System.Windows.Forms.ComboBox
    Friend WithEvents grp_detalle_de_proveedor As System.Windows.Forms.GroupBox
    Friend WithEvents lbl_total_display As System.Windows.Forms.Label
    Friend WithEvents lbl_id_compra_display As System.Windows.Forms.Label
    Friend WithEvents lbl_info_empleado As System.Windows.Forms.Label
    Friend WithEvents lbl_id As System.Windows.Forms.Label
    Friend WithEvents lbl_total As System.Windows.Forms.Label
    Friend WithEvents lbl_empleado As System.Windows.Forms.Label
    Friend WithEvents grp_producto As System.Windows.Forms.GroupBox
    Friend WithEvents msk_cantidad As System.Windows.Forms.MaskedTextBox
    Friend WithEvents lbl_cantidad As System.Windows.Forms.Label
    Friend WithEvents lbl_producto As System.Windows.Forms.Label
    Friend WithEvents cmb_producto As System.Windows.Forms.ComboBox
    Friend WithEvents grd_telefonos As System.Windows.Forms.DataGridView
    Friend WithEvents col_tipo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents col_numero As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents lbl_mail_proveedor As System.Windows.Forms.Label
    Friend WithEvents lbl_nombre_proveedor As System.Windows.Forms.Label
    Friend WithEvents lbl_display_mail_proveedor As System.Windows.Forms.Label
    Friend WithEvents lbl_id_proveedor As System.Windows.Forms.Label
    Friend WithEvents lbl_display_nombre_proveedor As System.Windows.Forms.Label
    Friend WithEvents lbl_display_id_proveedor As System.Windows.Forms.Label
    Friend WithEvents msk_precio As System.Windows.Forms.MaskedTextBox
    Friend WithEvents lbl_precio As System.Windows.Forms.Label
    Friend WithEvents lbl_telefonos As System.Windows.Forms.Label
    Friend WithEvents lbl_razon_social_proveedor As System.Windows.Forms.Label
    Friend WithEvents lbl_display_razon_social_proveedor As System.Windows.Forms.Label
End Class
