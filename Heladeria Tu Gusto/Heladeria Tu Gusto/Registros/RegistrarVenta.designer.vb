Imports System.ComponentModel
Imports Microsoft.VisualBasic.CompilerServices

<DesignerGenerated()> _
Partial Class RegistrarVenta
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RegistrarVenta))
        Me.lbl_empleado = New System.Windows.Forms.Label()
        Me.grp_detalle_de_venta = New System.Windows.Forms.GroupBox()
        Me.grd_detalle_de_venta = New System.Windows.Forms.DataGridView()
        Me.cmb_empleado = New System.Windows.Forms.ComboBox()
        Me.lbl_codigo_producto = New System.Windows.Forms.Label()
        Me.lbl_cantidad = New System.Windows.Forms.Label()
        Me.txt_codigo_producto = New System.Windows.Forms.TextBox()
        Me.txt_cantidad = New System.Windows.Forms.MaskedTextBox()
        Me.grp_agregar_producto = New System.Windows.Forms.GroupBox()
        Me.cmd_agregar = New System.Windows.Forms.Button()
        Me.btn_guardar = New System.Windows.Forms.Button()
        Me.btn_cancelar = New System.Windows.Forms.Button()
        Me.lbl_total = New System.Windows.Forms.Label()
        Me.lbl_total_display = New System.Windows.Forms.Label()
        Me.lbl_id = New System.Windows.Forms.Label()
        Me.lbl_id_venta_display = New System.Windows.Forms.Label()
        Me.lbl_info_empleado = New System.Windows.Forms.Label()
        Me.lbl_guardar = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.col_codigo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_cantidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_precio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_subtotal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.grp_detalle_de_venta.SuspendLayout
        CType(Me.grd_detalle_de_venta,System.ComponentModel.ISupportInitialize).BeginInit
        Me.grp_agregar_producto.SuspendLayout
        Me.SuspendLayout
        '
        'lbl_empleado
        '
        Me.lbl_empleado.AutoSize = true
        Me.lbl_empleado.Location = New System.Drawing.Point(22, 14)
        Me.lbl_empleado.Name = "lbl_empleado"
        Me.lbl_empleado.Size = New System.Drawing.Size(57, 13)
        Me.lbl_empleado.TabIndex = 0
        Me.lbl_empleado.Text = "Empleado:"
        '
        'grp_detalle_de_venta
        '
        Me.grp_detalle_de_venta.BackColor = System.Drawing.Color.Transparent
        Me.grp_detalle_de_venta.Controls.Add(Me.grd_detalle_de_venta)
        Me.grp_detalle_de_venta.ForeColor = System.Drawing.Color.Navy
        Me.grp_detalle_de_venta.Location = New System.Drawing.Point(14, 180)
        Me.grp_detalle_de_venta.Name = "grp_detalle_de_venta"
        Me.grp_detalle_de_venta.Size = New System.Drawing.Size(466, 173)
        Me.grp_detalle_de_venta.TabIndex = 1
        Me.grp_detalle_de_venta.TabStop = false
        Me.grp_detalle_de_venta.Text = "Detalle de Venta"
        '
        'grd_detalle_de_venta
        '
        Me.grd_detalle_de_venta.AllowUserToAddRows = false
        Me.grd_detalle_de_venta.AllowUserToDeleteRows = false
        Me.grd_detalle_de_venta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grd_detalle_de_venta.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.col_codigo, Me.col_nombre, Me.col_cantidad, Me.col_precio, Me.col_subtotal})
        Me.grd_detalle_de_venta.Location = New System.Drawing.Point(9, 19)
        Me.grd_detalle_de_venta.Name = "grd_detalle_de_venta"
        Me.grd_detalle_de_venta.ReadOnly = true
        Me.grd_detalle_de_venta.Size = New System.Drawing.Size(444, 143)
        Me.grd_detalle_de_venta.TabIndex = 1
        '
        'cmb_empleado
        '
        Me.cmb_empleado.FormattingEnabled = true
        Me.cmb_empleado.Location = New System.Drawing.Point(85, 11)
        Me.cmb_empleado.Name = "cmb_empleado"
        Me.cmb_empleado.Size = New System.Drawing.Size(57, 21)
        Me.cmb_empleado.TabIndex = 2
        '
        'lbl_codigo_producto
        '
        Me.lbl_codigo_producto.AutoSize = true
        Me.lbl_codigo_producto.ForeColor = System.Drawing.Color.Black
        Me.lbl_codigo_producto.Location = New System.Drawing.Point(20, 35)
        Me.lbl_codigo_producto.Name = "lbl_codigo_producto"
        Me.lbl_codigo_producto.Size = New System.Drawing.Size(43, 13)
        Me.lbl_codigo_producto.TabIndex = 0
        Me.lbl_codigo_producto.Text = "Código:"
        '
        'lbl_cantidad
        '
        Me.lbl_cantidad.AutoSize = true
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
        Me.grp_agregar_producto.BackColor = System.Drawing.Color.Transparent
        Me.grp_agregar_producto.Controls.Add(Me.cmd_agregar)
        Me.grp_agregar_producto.Controls.Add(Me.txt_cantidad)
        Me.grp_agregar_producto.Controls.Add(Me.txt_codigo_producto)
        Me.grp_agregar_producto.Controls.Add(Me.lbl_cantidad)
        Me.grp_agregar_producto.Controls.Add(Me.lbl_codigo_producto)
        Me.grp_agregar_producto.ForeColor = System.Drawing.Color.Navy
        Me.grp_agregar_producto.Location = New System.Drawing.Point(14, 55)
        Me.grp_agregar_producto.Name = "grp_agregar_producto"
        Me.grp_agregar_producto.Size = New System.Drawing.Size(466, 107)
        Me.grp_agregar_producto.TabIndex = 5
        Me.grp_agregar_producto.TabStop = false
        Me.grp_agregar_producto.Text = "Agregar Producto"
        '
        'cmd_agregar
        '
        Me.cmd_agregar.BackColor = System.Drawing.Color.Thistle
        Me.cmd_agregar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmd_agregar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.cmd_agregar.ForeColor = System.Drawing.Color.Black
        Me.cmd_agregar.Location = New System.Drawing.Point(316, 32)
        Me.cmd_agregar.Name = "cmd_agregar"
        Me.cmd_agregar.Size = New System.Drawing.Size(137, 46)
        Me.cmd_agregar.TabIndex = 5
        Me.cmd_agregar.Text = "AGREGAR"
        Me.cmd_agregar.UseVisualStyleBackColor = false
        '
        'btn_guardar
        '
        Me.btn_guardar.Image = Global.Heladeria_Tu_Gusto.My.Resources.Resources.icons8_Add_New_40
        Me.btn_guardar.Location = New System.Drawing.Point(14, 374)
        Me.btn_guardar.Name = "btn_guardar"
        Me.btn_guardar.Size = New System.Drawing.Size(75, 46)
        Me.btn_guardar.TabIndex = 6
        Me.btn_guardar.UseVisualStyleBackColor = true
        '
        'btn_cancelar
        '
        Me.btn_cancelar.Image = Global.Heladeria_Tu_Gusto.My.Resources.Resources.icons8_Delete_40
        Me.btn_cancelar.Location = New System.Drawing.Point(406, 374)
        Me.btn_cancelar.Name = "btn_cancelar"
        Me.btn_cancelar.Size = New System.Drawing.Size(75, 46)
        Me.btn_cancelar.TabIndex = 6
        Me.btn_cancelar.UseVisualStyleBackColor = true
        '
        'lbl_total
        '
        Me.lbl_total.AutoSize = true
        Me.lbl_total.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.lbl_total.Location = New System.Drawing.Point(138, 382)
        Me.lbl_total.Name = "lbl_total"
        Me.lbl_total.Size = New System.Drawing.Size(66, 25)
        Me.lbl_total.TabIndex = 0
        Me.lbl_total.Text = "Total:"
        '
        'lbl_total_display
        '
        Me.lbl_total_display.BackColor = System.Drawing.Color.Silver
        Me.lbl_total_display.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.lbl_total_display.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0,Byte),Integer), CType(CType(192,Byte),Integer), CType(CType(0,Byte),Integer))
        Me.lbl_total_display.Location = New System.Drawing.Point(199, 382)
        Me.lbl_total_display.Name = "lbl_total_display"
        Me.lbl_total_display.Size = New System.Drawing.Size(138, 25)
        Me.lbl_total_display.TabIndex = 0
        Me.lbl_total_display.Text = "0"
        Me.lbl_total_display.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbl_id
        '
        Me.lbl_id.AutoSize = true
        Me.lbl_id.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.lbl_id.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64,Byte),Integer), CType(CType(64,Byte),Integer), CType(CType(64,Byte),Integer))
        Me.lbl_id.Location = New System.Drawing.Point(353, 11)
        Me.lbl_id.Name = "lbl_id"
        Me.lbl_id.Size = New System.Drawing.Size(51, 13)
        Me.lbl_id.TabIndex = 0
        Me.lbl_id.Text = "ID venta:"
        '
        'lbl_id_venta_display
        '
        Me.lbl_id_venta_display.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.lbl_id_venta_display.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64,Byte),Integer), CType(CType(64,Byte),Integer), CType(CType(64,Byte),Integer))
        Me.lbl_id_venta_display.Location = New System.Drawing.Point(401, 11)
        Me.lbl_id_venta_display.Name = "lbl_id_venta_display"
        Me.lbl_id_venta_display.Size = New System.Drawing.Size(71, 13)
        Me.lbl_id_venta_display.TabIndex = 0
        Me.lbl_id_venta_display.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lbl_info_empleado
        '
        Me.lbl_info_empleado.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.lbl_info_empleado.Font = New System.Drawing.Font("Microsoft Sans Serif", 9!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.lbl_info_empleado.ForeColor = System.Drawing.Color.Black
        Me.lbl_info_empleado.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lbl_info_empleado.Location = New System.Drawing.Point(148, 11)
        Me.lbl_info_empleado.Name = "lbl_info_empleado"
        Me.lbl_info_empleado.Size = New System.Drawing.Size(149, 21)
        Me.lbl_info_empleado.TabIndex = 0
        Me.lbl_info_empleado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl_guardar
        '
        Me.lbl_guardar.AutoSize = true
        Me.lbl_guardar.Location = New System.Drawing.Point(29, 358)
        Me.lbl_guardar.Name = "lbl_guardar"
        Me.lbl_guardar.Size = New System.Drawing.Size(45, 13)
        Me.lbl_guardar.TabIndex = 16
        Me.lbl_guardar.Text = "Guardar"
        '
        'Label2
        '
        Me.Label2.AutoSize = true
        Me.Label2.Location = New System.Drawing.Point(419, 358)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(49, 13)
        Me.Label2.TabIndex = 17
        Me.Label2.Text = "Cancelar"
        '
        'col_codigo
        '
        Me.col_codigo.HeaderText = "CÓDIGO"
        Me.col_codigo.Name = "col_codigo"
        Me.col_codigo.ReadOnly = true
        Me.col_codigo.Width = 50
        '
        'col_nombre
        '
        Me.col_nombre.HeaderText = "NOMBRE"
        Me.col_nombre.Name = "col_nombre"
        Me.col_nombre.ReadOnly = true
        Me.col_nombre.Width = 125
        '
        'col_cantidad
        '
        Me.col_cantidad.HeaderText = "CANT."
        Me.col_cantidad.Name = "col_cantidad"
        Me.col_cantidad.ReadOnly = true
        Me.col_cantidad.Width = 50
        '
        'col_precio
        '
        Me.col_precio.HeaderText = "PRECIO"
        Me.col_precio.Name = "col_precio"
        Me.col_precio.ReadOnly = true
        Me.col_precio.Width = 75
        '
        'col_subtotal
        '
        Me.col_subtotal.HeaderText = "SUBTOTAL"
        Me.col_subtotal.Name = "col_subtotal"
        Me.col_subtotal.ReadOnly = true
        '
        'RegistrarVenta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(493, 428)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lbl_guardar)
        Me.Controls.Add(Me.btn_cancelar)
        Me.Controls.Add(Me.btn_guardar)
        Me.Controls.Add(Me.cmb_empleado)
        Me.Controls.Add(Me.grp_detalle_de_venta)
        Me.Controls.Add(Me.lbl_total_display)
        Me.Controls.Add(Me.lbl_id_venta_display)
        Me.Controls.Add(Me.lbl_info_empleado)
        Me.Controls.Add(Me.lbl_id)
        Me.Controls.Add(Me.lbl_total)
        Me.Controls.Add(Me.lbl_empleado)
        Me.Controls.Add(Me.grp_agregar_producto)
        Me.Icon = CType(resources.GetObject("$this.Icon"),System.Drawing.Icon)
        Me.Name = "RegistrarVenta"
        Me.Text = "Registrar Venta"
        Me.grp_detalle_de_venta.ResumeLayout(false)
        CType(Me.grd_detalle_de_venta,System.ComponentModel.ISupportInitialize).EndInit
        Me.grp_agregar_producto.ResumeLayout(false)
        Me.grp_agregar_producto.PerformLayout
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub
    Friend WithEvents lbl_empleado As Label
    Friend WithEvents grp_detalle_de_venta As GroupBox
    Friend WithEvents grd_detalle_de_venta As DataGridView
    Friend WithEvents cmb_empleado As ComboBox
    Friend WithEvents lbl_codigo_producto As Label
    Friend WithEvents lbl_cantidad As Label
    Friend WithEvents txt_codigo_producto As TextBox
    Friend WithEvents txt_cantidad As MaskedTextBox
    Friend WithEvents grp_agregar_producto As GroupBox
    Friend WithEvents cmd_agregar As Button
    Friend WithEvents btn_guardar As Button
    Friend WithEvents btn_cancelar As Button
    Friend WithEvents lbl_total As Label
    Friend WithEvents lbl_total_display As Label
    Friend WithEvents lbl_id As Label
    Friend WithEvents lbl_id_venta_display As Label
    Friend WithEvents lbl_info_empleado As Label
    Friend WithEvents lbl_guardar As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents col_codigo As DataGridViewTextBoxColumn
    Friend WithEvents col_nombre As DataGridViewTextBoxColumn
    Friend WithEvents col_cantidad As DataGridViewTextBoxColumn
    Friend WithEvents col_precio As DataGridViewTextBoxColumn
    Friend WithEvents col_subtotal As DataGridViewTextBoxColumn
End Class
