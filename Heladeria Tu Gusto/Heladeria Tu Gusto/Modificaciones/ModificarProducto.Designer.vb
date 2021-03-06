﻿Imports System.ComponentModel
Imports Microsoft.VisualBasic.CompilerServices

<DesignerGenerated()> _
Partial Class ModificarProducto
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ModificarProducto))
        Me.grd_productos = New System.Windows.Forms.DataGridView()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.grp_datos = New System.Windows.Forms.GroupBox()
        Me.lbl_tipo = New System.Windows.Forms.Label()
        Me.lbl_nombre = New System.Windows.Forms.Label()
        Me.lbl_precio = New System.Windows.Forms.Label()
        Me.cmb_tipo = New System.Windows.Forms.ComboBox()
        Me.lbl_descripcion = New System.Windows.Forms.Label()
        Me.txt_precio = New System.Windows.Forms.MaskedTextBox()
        Me.txt_nombre = New System.Windows.Forms.TextBox()
        Me.txt_descripcion = New System.Windows.Forms.TextBox()
        Me.lbl_guardar = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btn_cancelar = New System.Windows.Forms.Button()
        Me.btn_guardar = New System.Windows.Forms.Button()
        Me.toolTip_Precio = New System.Windows.Forms.ToolTip(Me.components)
        Me.nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.precio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tipo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.descripcion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.id_producto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.id_tipo_producto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.grd_productos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.grp_datos.SuspendLayout()
        Me.SuspendLayout()
        '
        'grd_productos
        '
        Me.grd_productos.AllowUserToAddRows = False
        Me.grd_productos.AllowUserToDeleteRows = False
        Me.grd_productos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grd_productos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.nombre, Me.precio, Me.tipo, Me.descripcion, Me.id_producto, Me.id_tipo_producto})
        Me.grd_productos.Location = New System.Drawing.Point(6, 19)
        Me.grd_productos.Name = "grd_productos"
        Me.grd_productos.ReadOnly = True
        Me.grd_productos.Size = New System.Drawing.Size(695, 211)
        Me.grd_productos.TabIndex = 0
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.grd_productos)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(707, 236)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Selección del producto"
        '
        'grp_datos
        '
        Me.grp_datos.Controls.Add(Me.lbl_tipo)
        Me.grp_datos.Controls.Add(Me.lbl_nombre)
        Me.grp_datos.Controls.Add(Me.lbl_precio)
        Me.grp_datos.Controls.Add(Me.cmb_tipo)
        Me.grp_datos.Controls.Add(Me.lbl_descripcion)
        Me.grp_datos.Controls.Add(Me.txt_precio)
        Me.grp_datos.Controls.Add(Me.txt_nombre)
        Me.grp_datos.Controls.Add(Me.txt_descripcion)
        Me.grp_datos.Location = New System.Drawing.Point(18, 254)
        Me.grp_datos.Name = "grp_datos"
        Me.grp_datos.Size = New System.Drawing.Size(453, 101)
        Me.grp_datos.TabIndex = 6
        Me.grp_datos.TabStop = False
        Me.grp_datos.Text = "Datos del producto"
        '
        'lbl_tipo
        '
        Me.lbl_tipo.AutoSize = True
        Me.lbl_tipo.Location = New System.Drawing.Point(22, 48)
        Me.lbl_tipo.Name = "lbl_tipo"
        Me.lbl_tipo.Size = New System.Drawing.Size(31, 13)
        Me.lbl_tipo.TabIndex = 0
        Me.lbl_tipo.Text = "Tipo:"
        '
        'lbl_nombre
        '
        Me.lbl_nombre.AutoSize = True
        Me.lbl_nombre.Location = New System.Drawing.Point(6, 22)
        Me.lbl_nombre.Name = "lbl_nombre"
        Me.lbl_nombre.Size = New System.Drawing.Size(47, 13)
        Me.lbl_nombre.TabIndex = 0
        Me.lbl_nombre.Text = "Nombre:"
        '
        'lbl_precio
        '
        Me.lbl_precio.AutoSize = True
        Me.lbl_precio.Location = New System.Drawing.Point(13, 75)
        Me.lbl_precio.Name = "lbl_precio"
        Me.lbl_precio.Size = New System.Drawing.Size(40, 13)
        Me.lbl_precio.TabIndex = 0
        Me.lbl_precio.Text = "Precio:"
        '
        'cmb_tipo
        '
        Me.cmb_tipo.FormattingEnabled = True
        Me.cmb_tipo.Location = New System.Drawing.Point(59, 45)
        Me.cmb_tipo.Name = "cmb_tipo"
        Me.cmb_tipo.Size = New System.Drawing.Size(140, 21)
        Me.cmb_tipo.TabIndex = 3
        '
        'lbl_descripcion
        '
        Me.lbl_descripcion.AutoSize = True
        Me.lbl_descripcion.Location = New System.Drawing.Point(236, 16)
        Me.lbl_descripcion.Name = "lbl_descripcion"
        Me.lbl_descripcion.Size = New System.Drawing.Size(66, 13)
        Me.lbl_descripcion.TabIndex = 0
        Me.lbl_descripcion.Text = "Descripción:"
        '
        'txt_precio
        '
        Me.txt_precio.Location = New System.Drawing.Point(59, 72)
        Me.txt_precio.Name = "txt_precio"
        Me.txt_precio.Size = New System.Drawing.Size(48, 20)
        Me.txt_precio.TabIndex = 1
        '
        'txt_nombre
        '
        Me.txt_nombre.Location = New System.Drawing.Point(59, 19)
        Me.txt_nombre.Name = "txt_nombre"
        Me.txt_nombre.Size = New System.Drawing.Size(140, 20)
        Me.txt_nombre.TabIndex = 0
        '
        'txt_descripcion
        '
        Me.txt_descripcion.Location = New System.Drawing.Point(239, 32)
        Me.txt_descripcion.Multiline = True
        Me.txt_descripcion.Name = "txt_descripcion"
        Me.txt_descripcion.Size = New System.Drawing.Size(190, 60)
        Me.txt_descripcion.TabIndex = 2
        '
        'lbl_guardar
        '
        Me.lbl_guardar.AutoSize = True
        Me.lbl_guardar.Location = New System.Drawing.Point(532, 260)
        Me.lbl_guardar.Name = "lbl_guardar"
        Me.lbl_guardar.Size = New System.Drawing.Size(87, 13)
        Me.lbl_guardar.TabIndex = 5
        Me.lbl_guardar.Text = "Guardar cambios"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(659, 260)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(49, 13)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Cancelar"
        '
        'btn_cancelar
        '
        Me.btn_cancelar.BackgroundImage = Global.Heladeria_Tu_Gusto.My.Resources.Resources.icons8_Delete_40
        Me.btn_cancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btn_cancelar.Location = New System.Drawing.Point(649, 276)
        Me.btn_cancelar.Name = "btn_cancelar"
        Me.btn_cancelar.Size = New System.Drawing.Size(70, 70)
        Me.btn_cancelar.TabIndex = 7
        Me.btn_cancelar.TextAlign = System.Drawing.ContentAlignment.TopLeft
        Me.btn_cancelar.UseVisualStyleBackColor = True
        '
        'btn_guardar
        '
        Me.btn_guardar.BackgroundImage = Global.Heladeria_Tu_Gusto.My.Resources.Resources.icons8_Save_as_64
        Me.btn_guardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btn_guardar.Location = New System.Drawing.Point(540, 276)
        Me.btn_guardar.Name = "btn_guardar"
        Me.btn_guardar.Size = New System.Drawing.Size(70, 70)
        Me.btn_guardar.TabIndex = 4
        Me.btn_guardar.TextAlign = System.Drawing.ContentAlignment.TopLeft
        Me.btn_guardar.UseVisualStyleBackColor = True
        '
        'nombre
        '
        Me.nombre.HeaderText = "Nombre"
        Me.nombre.Name = "nombre"
        Me.nombre.ReadOnly = True
        Me.nombre.Width = 150
        '
        'precio
        '
        Me.precio.HeaderText = "Precio"
        Me.precio.Name = "precio"
        Me.precio.ReadOnly = True
        Me.precio.Width = 50
        '
        'tipo
        '
        Me.tipo.HeaderText = "Tipo de producto"
        Me.tipo.Name = "tipo"
        Me.tipo.ReadOnly = True
        Me.tipo.Width = 150
        '
        'descripcion
        '
        Me.descripcion.HeaderText = "Descripción"
        Me.descripcion.Name = "descripcion"
        Me.descripcion.ReadOnly = True
        Me.descripcion.Width = 300
        '
        'id_producto
        '
        Me.id_producto.HeaderText = "ID del producto"
        Me.id_producto.Name = "id_producto"
        Me.id_producto.ReadOnly = True
        Me.id_producto.Visible = False
        '
        'id_tipo_producto
        '
        Me.id_tipo_producto.HeaderText = "ID del tipo de producto"
        Me.id_tipo_producto.Name = "id_tipo_producto"
        Me.id_tipo_producto.ReadOnly = True
        Me.id_tipo_producto.Visible = False
        '
        'ModificarProducto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(727, 363)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btn_cancelar)
        Me.Controls.Add(Me.lbl_guardar)
        Me.Controls.Add(Me.grp_datos)
        Me.Controls.Add(Me.btn_guardar)
        Me.Controls.Add(Me.GroupBox1)
        Me.DoubleBuffered = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "ModificarProducto"
        Me.Text = "Modificar datos de un producto"
        CType(Me.grd_productos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.grp_datos.ResumeLayout(False)
        Me.grp_datos.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents grd_productos As DataGridView
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents grp_datos As GroupBox
    Friend WithEvents lbl_tipo As Label
    Friend WithEvents lbl_nombre As Label
    Friend WithEvents lbl_precio As Label
    Friend WithEvents lbl_descripcion As Label
    Friend WithEvents txt_nombre As TextBox
    Friend WithEvents txt_descripcion As TextBox
    Friend WithEvents cmb_tipo As ComboBox
    Friend WithEvents btn_guardar As Button
    Friend WithEvents lbl_guardar As Label
    Friend WithEvents btn_cancelar As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents txt_precio As MaskedTextBox
    Friend WithEvents toolTip_Precio As ToolTip
    Friend WithEvents nombre As DataGridViewTextBoxColumn
    Friend WithEvents precio As DataGridViewTextBoxColumn
    Friend WithEvents tipo As DataGridViewTextBoxColumn
    Friend WithEvents descripcion As DataGridViewTextBoxColumn
    Friend WithEvents id_producto As DataGridViewTextBoxColumn
    Friend WithEvents id_tipo_producto As DataGridViewTextBoxColumn
End Class
