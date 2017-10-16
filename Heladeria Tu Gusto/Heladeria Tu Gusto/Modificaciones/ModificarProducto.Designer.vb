Imports System.ComponentModel
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
        Me.components = New Container()
        Dim resources As ComponentResourceManager = New ComponentResourceManager(GetType(ModificarProducto))
        Me.grd_productos = New DataGridView()
        Me.nombre = New DataGridViewTextBoxColumn()
        Me.stock = New DataGridViewTextBoxColumn()
        Me.precio = New DataGridViewTextBoxColumn()
        Me.tipo = New DataGridViewTextBoxColumn()
        Me.descripcion = New DataGridViewTextBoxColumn()
        Me.id_producto = New DataGridViewTextBoxColumn()
        Me.id_tipo_producto = New DataGridViewTextBoxColumn()
        Me.GroupBox1 = New GroupBox()
        Me.grp_datos = New GroupBox()
        Me.lbl_tipo = New Label()
        Me.lbl_nombre = New Label()
        Me.lbl_precio = New Label()
        Me.cmb_tipo = New ComboBox()
        Me.lbl_descripcion = New Label()
        Me.txt_precio = New MaskedTextBox()
        Me.txt_nombre = New TextBox()
        Me.txt_descripcion = New TextBox()
        Me.lbl_guardar = New Label()
        Me.Label1 = New Label()
        Me.btn_cancelar = New Button()
        Me.btn_guardar = New Button()
        Me.toolTip_Precio = New ToolTip(Me.components)
        CType(Me.grd_productos, ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.grp_datos.SuspendLayout()
        Me.SuspendLayout()
        '
        'grd_productos
        '
        Me.grd_productos.AllowUserToAddRows = False
        Me.grd_productos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grd_productos.Columns.AddRange(New DataGridViewColumn() {Me.nombre, Me.stock, Me.precio, Me.tipo, Me.descripcion, Me.id_producto, Me.id_tipo_producto})
        Me.grd_productos.Location = New Point(6, 19)
        Me.grd_productos.Name = "grd_productos"
        Me.grd_productos.Size = New Size(695, 211)
        Me.grd_productos.TabIndex = 0
        '
        'nombre
        '
        Me.nombre.HeaderText = "Nombre"
        Me.nombre.Name = "nombre"
        '
        'stock
        '
        Me.stock.HeaderText = "Stock"
        Me.stock.Name = "stock"
        '
        'precio
        '
        Me.precio.HeaderText = "Precio"
        Me.precio.Name = "precio"
        '
        'tipo
        '
        Me.tipo.HeaderText = "Tipo de producto"
        Me.tipo.Name = "tipo"
        Me.tipo.Width = 150
        '
        'descripcion
        '
        Me.descripcion.HeaderText = "Descripción"
        Me.descripcion.Name = "descripcion"
        Me.descripcion.Width = 200
        '
        'id_producto
        '
        Me.id_producto.HeaderText = "ID del producto"
        Me.id_producto.Name = "id_producto"
        Me.id_producto.Visible = False
        '
        'id_tipo_producto
        '
        Me.id_tipo_producto.HeaderText = "ID del tipo de producto"
        Me.id_tipo_producto.Name = "id_tipo_producto"
        Me.id_tipo_producto.Visible = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.grd_productos)
        Me.GroupBox1.Location = New Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New Size(707, 236)
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
        Me.grp_datos.Location = New Point(18, 254)
        Me.grp_datos.Name = "grp_datos"
        Me.grp_datos.Size = New Size(453, 101)
        Me.grp_datos.TabIndex = 6
        Me.grp_datos.TabStop = False
        Me.grp_datos.Text = "Datos del producto"
        '
        'lbl_tipo
        '
        Me.lbl_tipo.AutoSize = True
        Me.lbl_tipo.Location = New Point(19, 51)
        Me.lbl_tipo.Name = "lbl_tipo"
        Me.lbl_tipo.Size = New Size(31, 13)
        Me.lbl_tipo.TabIndex = 0
        Me.lbl_tipo.Text = "Tipo:"
        '
        'lbl_nombre
        '
        Me.lbl_nombre.AutoSize = True
        Me.lbl_nombre.Location = New Point(6, 22)
        Me.lbl_nombre.Name = "lbl_nombre"
        Me.lbl_nombre.Size = New Size(47, 13)
        Me.lbl_nombre.TabIndex = 0
        Me.lbl_nombre.Text = "Nombre:"
        '
        'lbl_precio
        '
        Me.lbl_precio.AutoSize = True
        Me.lbl_precio.Location = New Point(13, 75)
        Me.lbl_precio.Name = "lbl_precio"
        Me.lbl_precio.Size = New Size(40, 13)
        Me.lbl_precio.TabIndex = 0
        Me.lbl_precio.Text = "Precio:"
        '
        'cmb_tipo
        '
        Me.cmb_tipo.FormattingEnabled = True
        Me.cmb_tipo.Location = New Point(59, 45)
        Me.cmb_tipo.Name = "cmb_tipo"
        Me.cmb_tipo.Size = New Size(140, 21)
        Me.cmb_tipo.TabIndex = 3
        '
        'lbl_descripcion
        '
        Me.lbl_descripcion.AutoSize = True
        Me.lbl_descripcion.Location = New Point(236, 16)
        Me.lbl_descripcion.Name = "lbl_descripcion"
        Me.lbl_descripcion.Size = New Size(66, 13)
        Me.lbl_descripcion.TabIndex = 0
        Me.lbl_descripcion.Text = "Descripción:"
        '
        'txt_precio
        '
        Me.txt_precio.Location = New Point(59, 72)
        Me.txt_precio.Name = "txt_precio"
        Me.txt_precio.Size = New Size(48, 20)
        Me.txt_precio.TabIndex = 1
        '
        'txt_nombre
        '
        Me.txt_nombre.Location = New Point(59, 19)
        Me.txt_nombre.Name = "txt_nombre"
        Me.txt_nombre.Size = New Size(140, 20)
        Me.txt_nombre.TabIndex = 0
        '
        'txt_descripcion
        '
        Me.txt_descripcion.Location = New Point(239, 32)
        Me.txt_descripcion.Multiline = True
        Me.txt_descripcion.Name = "txt_descripcion"
        Me.txt_descripcion.Size = New Size(190, 60)
        Me.txt_descripcion.TabIndex = 2
        '
        'lbl_guardar
        '
        Me.lbl_guardar.AutoSize = True
        Me.lbl_guardar.Location = New Point(532, 260)
        Me.lbl_guardar.Name = "lbl_guardar"
        Me.lbl_guardar.Size = New Size(87, 13)
        Me.lbl_guardar.TabIndex = 5
        Me.lbl_guardar.Text = "Guardar cambios"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New Point(659, 260)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New Size(49, 13)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Cancelar"
        '
        'btn_cancelar
        '
        Me.btn_cancelar.BackgroundImage = My.Resources.Resources.icons8_Delete_40
        Me.btn_cancelar.BackgroundImageLayout = ImageLayout.Center
        Me.btn_cancelar.Location = New Point(649, 276)
        Me.btn_cancelar.Name = "btn_cancelar"
        Me.btn_cancelar.Size = New Size(70, 70)
        Me.btn_cancelar.TabIndex = 7
        Me.btn_cancelar.TextAlign = ContentAlignment.TopLeft
        Me.btn_cancelar.UseVisualStyleBackColor = True
        '
        'btn_guardar
        '
        Me.btn_guardar.BackgroundImage = My.Resources.Resources.icons8_Save_as_64
        Me.btn_guardar.BackgroundImageLayout = ImageLayout.Center
        Me.btn_guardar.Location = New Point(540, 276)
        Me.btn_guardar.Name = "btn_guardar"
        Me.btn_guardar.Size = New Size(70, 70)
        Me.btn_guardar.TabIndex = 4
        Me.btn_guardar.TextAlign = ContentAlignment.TopLeft
        Me.btn_guardar.UseVisualStyleBackColor = True
        '
        'ModificarProducto
        '
        Me.AutoScaleDimensions = New SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = AutoScaleMode.Font
        Me.ClientSize = New Size(727, 363)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btn_cancelar)
        Me.Controls.Add(Me.lbl_guardar)
        Me.Controls.Add(Me.grp_datos)
        Me.Controls.Add(Me.btn_guardar)
        Me.Controls.Add(Me.GroupBox1)
        Me.DoubleBuffered = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Me.Name = "ModificarProducto"
        Me.Text = "Modificar datos de un producto"
        CType(Me.grd_productos, ISupportInitialize).EndInit()
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
    Friend WithEvents nombre As DataGridViewTextBoxColumn
    Friend WithEvents stock As DataGridViewTextBoxColumn
    Friend WithEvents precio As DataGridViewTextBoxColumn
    Friend WithEvents tipo As DataGridViewTextBoxColumn
    Friend WithEvents descripcion As DataGridViewTextBoxColumn
    Friend WithEvents id_producto As DataGridViewTextBoxColumn
    Friend WithEvents id_tipo_producto As DataGridViewTextBoxColumn
    Friend WithEvents cmb_tipo As ComboBox
    Friend WithEvents btn_guardar As Button
    Friend WithEvents lbl_guardar As Label
    Friend WithEvents btn_cancelar As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents txt_precio As MaskedTextBox
    Friend WithEvents toolTip_Precio As ToolTip
End Class
