<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RegistrarVenta
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
        Me.lbl_empleado = New System.Windows.Forms.Label()
        Me.grp_detalle_de_venta = New System.Windows.Forms.GroupBox()
        Me.grd_detalle_de_venta = New System.Windows.Forms.DataGridView()
        Me.col_codigo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_cantidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_precio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_subtotal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cmb_empleado = New System.Windows.Forms.ComboBox()
        Me.lbl_codigo_producto = New System.Windows.Forms.Label()
        Me.lbl_cantidad = New System.Windows.Forms.Label()
        Me.txt_codigo_producto = New System.Windows.Forms.TextBox()
        Me.txt_cantidad = New System.Windows.Forms.MaskedTextBox()
        Me.grp_agregar_producto = New System.Windows.Forms.GroupBox()
        Me.cmd_agregar = New System.Windows.Forms.Button()
        Me.cmd_guardar = New System.Windows.Forms.Button()
        Me.cmd_cancelar = New System.Windows.Forms.Button()
        Me.lbl_total = New System.Windows.Forms.Label()
        Me.lbl_total_display = New System.Windows.Forms.Label()
        Me.lbl_id = New System.Windows.Forms.Label()
        Me.lbl_id_venta_display = New System.Windows.Forms.Label()
        Me.lbl_info_empleado = New System.Windows.Forms.Label()
        Me.grp_detalle_de_venta.SuspendLayout()
        CType(Me.grd_detalle_de_venta, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grp_agregar_producto.SuspendLayout()
        Me.SuspendLayout()
        '
        'lbl_empleado
        '
        Me.lbl_empleado.AutoSize = True
        Me.lbl_empleado.Location = New System.Drawing.Point(22, 41)
        Me.lbl_empleado.Name = "lbl_empleado"
        Me.lbl_empleado.Size = New System.Drawing.Size(57, 13)
        Me.lbl_empleado.TabIndex = 0
        Me.lbl_empleado.Text = "Empleado:"
        '
        'grp_detalle_de_venta
        '
        Me.grp_detalle_de_venta.BackColor = System.Drawing.Color.Silver
        Me.grp_detalle_de_venta.Controls.Add(Me.grd_detalle_de_venta)
        Me.grp_detalle_de_venta.ForeColor = System.Drawing.Color.Navy
        Me.grp_detalle_de_venta.Location = New System.Drawing.Point(14, 207)
        Me.grp_detalle_de_venta.Name = "grp_detalle_de_venta"
        Me.grp_detalle_de_venta.Size = New System.Drawing.Size(466, 182)
        Me.grp_detalle_de_venta.TabIndex = 1
        Me.grp_detalle_de_venta.TabStop = False
        Me.grp_detalle_de_venta.Text = "Detalle de Venta"
        '
        'grd_detalle_de_venta
        '
        Me.grd_detalle_de_venta.AllowUserToAddRows = False
        Me.grd_detalle_de_venta.AllowUserToDeleteRows = False
        Me.grd_detalle_de_venta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grd_detalle_de_venta.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.col_codigo, Me.col_nombre, Me.col_cantidad, Me.col_precio, Me.col_subtotal})
        Me.grd_detalle_de_venta.Location = New System.Drawing.Point(9, 19)
        Me.grd_detalle_de_venta.Name = "grd_detalle_de_venta"
        Me.grd_detalle_de_venta.ReadOnly = True
        Me.grd_detalle_de_venta.Size = New System.Drawing.Size(444, 150)
        Me.grd_detalle_de_venta.TabIndex = 1
        '
        'col_codigo
        '
        Me.col_codigo.HeaderText = "CÓDIGO"
        Me.col_codigo.Name = "col_codigo"
        Me.col_codigo.ReadOnly = True
        Me.col_codigo.Width = 50
        '
        'col_nombre
        '
        Me.col_nombre.HeaderText = "NOMBRE"
        Me.col_nombre.Name = "col_nombre"
        Me.col_nombre.ReadOnly = True
        Me.col_nombre.Width = 125
        '
        'col_cantidad
        '
        Me.col_cantidad.HeaderText = "CANTIDAD"
        Me.col_cantidad.Name = "col_cantidad"
        Me.col_cantidad.ReadOnly = True
        Me.col_cantidad.Width = 50
        '
        'col_precio
        '
        Me.col_precio.HeaderText = "PRECIO"
        Me.col_precio.Name = "col_precio"
        Me.col_precio.ReadOnly = True
        Me.col_precio.Width = 75
        '
        'col_subtotal
        '
        Me.col_subtotal.HeaderText = "SUBTOTAL"
        Me.col_subtotal.Name = "col_subtotal"
        Me.col_subtotal.ReadOnly = True
        '
        'cmb_empleado
        '
        Me.cmb_empleado.FormattingEnabled = True
        Me.cmb_empleado.Location = New System.Drawing.Point(85, 38)
        Me.cmb_empleado.Name = "cmb_empleado"
        Me.cmb_empleado.Size = New System.Drawing.Size(57, 21)
        Me.cmb_empleado.TabIndex = 2
        '
        'lbl_codigo_producto
        '
        Me.lbl_codigo_producto.AutoSize = True
        Me.lbl_codigo_producto.ForeColor = System.Drawing.Color.Black
        Me.lbl_codigo_producto.Location = New System.Drawing.Point(20, 35)
        Me.lbl_codigo_producto.Name = "lbl_codigo_producto"
        Me.lbl_codigo_producto.Size = New System.Drawing.Size(43, 13)
        Me.lbl_codigo_producto.TabIndex = 0
        Me.lbl_codigo_producto.Text = "Código:"
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
        'txt_codigo_producto
        '
        Me.txt_codigo_producto.Location = New System.Drawing.Point(71, 32)
        Me.txt_codigo_producto.Name = "txt_codigo_producto"
        Me.txt_codigo_producto.Size = New System.Drawing.Size(239, 20)
        Me.txt_codigo_producto.TabIndex = 3
        '
        'txt_cantidad
        '
        Me.txt_cantidad.Location = New System.Drawing.Point(71, 58)
        Me.txt_cantidad.Name = "txt_cantidad"
        Me.txt_cantidad.Size = New System.Drawing.Size(239, 20)
        Me.txt_cantidad.TabIndex = 4
        '
        'grp_agregar_producto
        '
        Me.grp_agregar_producto.BackColor = System.Drawing.Color.Silver
        Me.grp_agregar_producto.Controls.Add(Me.cmd_agregar)
        Me.grp_agregar_producto.Controls.Add(Me.txt_cantidad)
        Me.grp_agregar_producto.Controls.Add(Me.txt_codigo_producto)
        Me.grp_agregar_producto.Controls.Add(Me.lbl_cantidad)
        Me.grp_agregar_producto.Controls.Add(Me.lbl_codigo_producto)
        Me.grp_agregar_producto.ForeColor = System.Drawing.Color.Navy
        Me.grp_agregar_producto.Location = New System.Drawing.Point(14, 82)
        Me.grp_agregar_producto.Name = "grp_agregar_producto"
        Me.grp_agregar_producto.Size = New System.Drawing.Size(466, 107)
        Me.grp_agregar_producto.TabIndex = 5
        Me.grp_agregar_producto.TabStop = False
        Me.grp_agregar_producto.Text = "Agregar Producto"
        '
        'cmd_agregar
        '
        Me.cmd_agregar.BackColor = System.Drawing.Color.Thistle
        Me.cmd_agregar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmd_agregar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_agregar.ForeColor = System.Drawing.Color.Black
        Me.cmd_agregar.Location = New System.Drawing.Point(316, 32)
        Me.cmd_agregar.Name = "cmd_agregar"
        Me.cmd_agregar.Size = New System.Drawing.Size(137, 46)
        Me.cmd_agregar.TabIndex = 5
        Me.cmd_agregar.Text = "AGREGAR"
        Me.cmd_agregar.UseVisualStyleBackColor = False
        '
        'cmd_guardar
        '
        Me.cmd_guardar.Location = New System.Drawing.Point(14, 407)
        Me.cmd_guardar.Name = "cmd_guardar"
        Me.cmd_guardar.Size = New System.Drawing.Size(75, 34)
        Me.cmd_guardar.TabIndex = 6
        Me.cmd_guardar.Text = "Guardar"
        Me.cmd_guardar.UseVisualStyleBackColor = True
        '
        'cmd_cancelar
        '
        Me.cmd_cancelar.Location = New System.Drawing.Point(405, 407)
        Me.cmd_cancelar.Name = "cmd_cancelar"
        Me.cmd_cancelar.Size = New System.Drawing.Size(75, 34)
        Me.cmd_cancelar.TabIndex = 6
        Me.cmd_cancelar.Text = "Cancelar"
        Me.cmd_cancelar.UseVisualStyleBackColor = True
        '
        'lbl_total
        '
        Me.lbl_total.AutoSize = True
        Me.lbl_total.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_total.Location = New System.Drawing.Point(138, 409)
        Me.lbl_total.Name = "lbl_total"
        Me.lbl_total.Size = New System.Drawing.Size(66, 25)
        Me.lbl_total.TabIndex = 0
        Me.lbl_total.Text = "Total:"
        '
        'lbl_total_display
        '
        Me.lbl_total_display.BackColor = System.Drawing.Color.Silver
        Me.lbl_total_display.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_total_display.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lbl_total_display.Location = New System.Drawing.Point(199, 409)
        Me.lbl_total_display.Name = "lbl_total_display"
        Me.lbl_total_display.Size = New System.Drawing.Size(138, 25)
        Me.lbl_total_display.TabIndex = 0
        Me.lbl_total_display.Text = "0"
        Me.lbl_total_display.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbl_id
        '
        Me.lbl_id.AutoSize = True
        Me.lbl_id.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_id.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lbl_id.Location = New System.Drawing.Point(354, 9)
        Me.lbl_id.Name = "lbl_id"
        Me.lbl_id.Size = New System.Drawing.Size(50, 13)
        Me.lbl_id.TabIndex = 0
        Me.lbl_id.Text = "Id Venta:"
        '
        'lbl_id_venta_display
        '
        Me.lbl_id_venta_display.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_id_venta_display.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lbl_id_venta_display.Location = New System.Drawing.Point(402, 9)
        Me.lbl_id_venta_display.Name = "lbl_id_venta_display"
        Me.lbl_id_venta_display.Size = New System.Drawing.Size(71, 13)
        Me.lbl_id_venta_display.TabIndex = 0
        Me.lbl_id_venta_display.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lbl_info_empleado
        '
        Me.lbl_info_empleado.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.lbl_info_empleado.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_info_empleado.ForeColor = System.Drawing.Color.Black
        Me.lbl_info_empleado.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lbl_info_empleado.Location = New System.Drawing.Point(148, 38)
        Me.lbl_info_empleado.Name = "lbl_info_empleado"
        Me.lbl_info_empleado.Size = New System.Drawing.Size(149, 21)
        Me.lbl_info_empleado.TabIndex = 0
        Me.lbl_info_empleado.Text = "Marcelo Liberatori"
        Me.lbl_info_empleado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'RegistrarVenta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(493, 454)
        Me.Controls.Add(Me.cmd_cancelar)
        Me.Controls.Add(Me.cmd_guardar)
        Me.Controls.Add(Me.cmb_empleado)
        Me.Controls.Add(Me.grp_detalle_de_venta)
        Me.Controls.Add(Me.lbl_total_display)
        Me.Controls.Add(Me.lbl_id_venta_display)
        Me.Controls.Add(Me.lbl_info_empleado)
        Me.Controls.Add(Me.lbl_id)
        Me.Controls.Add(Me.lbl_total)
        Me.Controls.Add(Me.lbl_empleado)
        Me.Controls.Add(Me.grp_agregar_producto)
        Me.Name = "RegistrarVenta"
        Me.Text = "Registrar Venta"
        Me.grp_detalle_de_venta.ResumeLayout(False)
        CType(Me.grd_detalle_de_venta, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grp_agregar_producto.ResumeLayout(False)
        Me.grp_agregar_producto.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbl_empleado As System.Windows.Forms.Label
    Friend WithEvents grp_detalle_de_venta As System.Windows.Forms.GroupBox
    Friend WithEvents grd_detalle_de_venta As System.Windows.Forms.DataGridView
    Friend WithEvents cmb_empleado As System.Windows.Forms.ComboBox
    Friend WithEvents col_codigo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents col_nombre As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents col_cantidad As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents col_precio As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents col_subtotal As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents lbl_codigo_producto As System.Windows.Forms.Label
    Friend WithEvents lbl_cantidad As System.Windows.Forms.Label
    Friend WithEvents txt_codigo_producto As System.Windows.Forms.TextBox
    Friend WithEvents txt_cantidad As System.Windows.Forms.MaskedTextBox
    Friend WithEvents grp_agregar_producto As System.Windows.Forms.GroupBox
    Friend WithEvents cmd_agregar As System.Windows.Forms.Button
    Friend WithEvents cmd_guardar As System.Windows.Forms.Button
    Friend WithEvents cmd_cancelar As System.Windows.Forms.Button
    Friend WithEvents lbl_total As System.Windows.Forms.Label
    Friend WithEvents lbl_total_display As System.Windows.Forms.Label
    Friend WithEvents lbl_id As System.Windows.Forms.Label
    Friend WithEvents lbl_id_venta_display As System.Windows.Forms.Label
    Friend WithEvents lbl_info_empleado As System.Windows.Forms.Label

End Class
