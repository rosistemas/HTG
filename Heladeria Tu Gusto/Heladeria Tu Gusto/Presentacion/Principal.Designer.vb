Imports System.ComponentModel
Imports Microsoft.VisualBasic.CompilerServices

<DesignerGenerated()> _
Partial Class Principal
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Principal))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ArchivoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RegistrarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.registrar_venta = New System.Windows.Forms.ToolStripMenuItem()
        Me.registrar_producto = New System.Windows.Forms.ToolStripMenuItem()
        Me.registrar_empleado = New System.Windows.Forms.ToolStripMenuItem()
        Me.registrar_proveedor = New System.Windows.Forms.ToolStripMenuItem()
        Me.CompraToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TurnoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OtrosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LocalidadToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProvinciaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BarrioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TipoProductoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.modificar_producto = New System.Windows.Forms.ToolStripMenuItem()
        Me.modificar_empleado = New System.Windows.Forms.ToolStripMenuItem()
        Me.modificar_proveedor = New System.Windows.Forms.ToolStripMenuItem()
        Me.modificar_otros = New System.Windows.Forms.ToolStripMenuItem()
        Me.modificar_barrio = New System.Windows.Forms.ToolStripMenuItem()
        Me.modificar_localidad = New System.Windows.Forms.ToolStripMenuItem()
        Me.modificar_provincia = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PreferenciasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EstadísticasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReporteDeVentasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EmpleadosPorVentaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AyudaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AccesosDirectosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AcercaDeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.pb_registrar_venta = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.pb_registrar_compra = New System.Windows.Forms.PictureBox()
        Me.gb_registrar = New System.Windows.Forms.GroupBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.pb_registrar_turno = New System.Windows.Forms.PictureBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.pb_registrar_proveedor = New System.Windows.Forms.PictureBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.pb_registrar_producto = New System.Windows.Forms.PictureBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.pb_registrar_empleado = New System.Windows.Forms.PictureBox()
        Me.gb_estadisticas = New System.Windows.Forms.GroupBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.pb_ventas_empleado = New System.Windows.Forms.PictureBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.pb_ventas = New System.Windows.Forms.PictureBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.pb_estadisticas = New System.Windows.Forms.PictureBox()
        Me.MenuStrip1.SuspendLayout
        CType(Me.pb_registrar_venta,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.pb_registrar_compra,System.ComponentModel.ISupportInitialize).BeginInit
        Me.gb_registrar.SuspendLayout
        CType(Me.pb_registrar_turno,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.pb_registrar_proveedor,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.pb_registrar_producto,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.pb_registrar_empleado,System.ComponentModel.ISupportInitialize).BeginInit
        Me.gb_estadisticas.SuspendLayout
        CType(Me.pb_ventas_empleado,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.pb_ventas,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.pb_estadisticas,System.ComponentModel.ISupportInitialize).BeginInit
        Me.SuspendLayout
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ArchivoToolStripMenuItem, Me.PreferenciasToolStripMenuItem, Me.AyudaToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(509, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ArchivoToolStripMenuItem
        '
        Me.ArchivoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RegistrarToolStripMenuItem, Me.ToolStripMenuItem1, Me.SalirToolStripMenuItem})
        Me.ArchivoToolStripMenuItem.Name = "ArchivoToolStripMenuItem"
        Me.ArchivoToolStripMenuItem.Size = New System.Drawing.Size(60, 20)
        Me.ArchivoToolStripMenuItem.Text = "Archivo"
        '
        'RegistrarToolStripMenuItem
        '
        Me.RegistrarToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.registrar_venta, Me.registrar_producto, Me.registrar_empleado, Me.registrar_proveedor, Me.CompraToolStripMenuItem, Me.TurnoToolStripMenuItem, Me.OtrosToolStripMenuItem})
        Me.RegistrarToolStripMenuItem.Name = "RegistrarToolStripMenuItem"
        Me.RegistrarToolStripMenuItem.Size = New System.Drawing.Size(125, 22)
        Me.RegistrarToolStripMenuItem.Text = "Registrar"
        '
        'registrar_venta
        '
        Me.registrar_venta.Name = "registrar_venta"
        Me.registrar_venta.ShortcutKeyDisplayString = "(Ctrl+0)"
        Me.registrar_venta.Size = New System.Drawing.Size(176, 22)
        Me.registrar_venta.Tag = ""
        Me.registrar_venta.Text = "Venta"
        '
        'registrar_producto
        '
        Me.registrar_producto.Name = "registrar_producto"
        Me.registrar_producto.ShortcutKeyDisplayString = "(Ctrl+1)"
        Me.registrar_producto.Size = New System.Drawing.Size(176, 22)
        Me.registrar_producto.Text = "Producto"
        '
        'registrar_empleado
        '
        Me.registrar_empleado.Name = "registrar_empleado"
        Me.registrar_empleado.ShortcutKeyDisplayString = "(Ctrl+2)"
        Me.registrar_empleado.Size = New System.Drawing.Size(176, 22)
        Me.registrar_empleado.Text = "Empleado"
        '
        'registrar_proveedor
        '
        Me.registrar_proveedor.Name = "registrar_proveedor"
        Me.registrar_proveedor.ShortcutKeyDisplayString = "(Ctrl+3)"
        Me.registrar_proveedor.Size = New System.Drawing.Size(176, 22)
        Me.registrar_proveedor.Text = "Proveedor"
        '
        'CompraToolStripMenuItem
        '
        Me.CompraToolStripMenuItem.Name = "CompraToolStripMenuItem"
        Me.CompraToolStripMenuItem.ShortcutKeyDisplayString = "(Ctrl+4)"
        Me.CompraToolStripMenuItem.Size = New System.Drawing.Size(176, 22)
        Me.CompraToolStripMenuItem.Text = "Compra"
        '
        'TurnoToolStripMenuItem
        '
        Me.TurnoToolStripMenuItem.Name = "TurnoToolStripMenuItem"
        Me.TurnoToolStripMenuItem.Size = New System.Drawing.Size(176, 22)
        Me.TurnoToolStripMenuItem.Text = "Turno"
        '
        'OtrosToolStripMenuItem
        '
        Me.OtrosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LocalidadToolStripMenuItem, Me.ProvinciaToolStripMenuItem, Me.BarrioToolStripMenuItem, Me.TipoProductoToolStripMenuItem})
        Me.OtrosToolStripMenuItem.Name = "OtrosToolStripMenuItem"
        Me.OtrosToolStripMenuItem.Size = New System.Drawing.Size(176, 22)
        Me.OtrosToolStripMenuItem.Text = "Otros"
        '
        'LocalidadToolStripMenuItem
        '
        Me.LocalidadToolStripMenuItem.Name = "LocalidadToolStripMenuItem"
        Me.LocalidadToolStripMenuItem.Size = New System.Drawing.Size(150, 22)
        Me.LocalidadToolStripMenuItem.Text = "Localidad"
        '
        'ProvinciaToolStripMenuItem
        '
        Me.ProvinciaToolStripMenuItem.Name = "ProvinciaToolStripMenuItem"
        Me.ProvinciaToolStripMenuItem.Size = New System.Drawing.Size(150, 22)
        Me.ProvinciaToolStripMenuItem.Text = "Provincia"
        '
        'BarrioToolStripMenuItem
        '
        Me.BarrioToolStripMenuItem.Name = "BarrioToolStripMenuItem"
        Me.BarrioToolStripMenuItem.Size = New System.Drawing.Size(150, 22)
        Me.BarrioToolStripMenuItem.Text = "Barrio"
        '
        'TipoProductoToolStripMenuItem
        '
        Me.TipoProductoToolStripMenuItem.Name = "TipoProductoToolStripMenuItem"
        Me.TipoProductoToolStripMenuItem.Size = New System.Drawing.Size(150, 22)
        Me.TipoProductoToolStripMenuItem.Text = "Tipo Producto"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.modificar_producto, Me.modificar_empleado, Me.modificar_proveedor, Me.modificar_otros})
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(125, 22)
        Me.ToolStripMenuItem1.Text = "Modificar"
        '
        'modificar_producto
        '
        Me.modificar_producto.Name = "modificar_producto"
        Me.modificar_producto.ShortcutKeyDisplayString = "(Alt+1)"
        Me.modificar_producto.Size = New System.Drawing.Size(172, 22)
        Me.modificar_producto.Text = "Producto"
        '
        'modificar_empleado
        '
        Me.modificar_empleado.Name = "modificar_empleado"
        Me.modificar_empleado.ShortcutKeyDisplayString = "(Alt+2)"
        Me.modificar_empleado.Size = New System.Drawing.Size(172, 22)
        Me.modificar_empleado.Text = "Empleado"
        '
        'modificar_proveedor
        '
        Me.modificar_proveedor.Name = "modificar_proveedor"
        Me.modificar_proveedor.ShortcutKeyDisplayString = "(Alt+3)"
        Me.modificar_proveedor.Size = New System.Drawing.Size(172, 22)
        Me.modificar_proveedor.Text = "Proveedor"
        '
        'modificar_otros
        '
        Me.modificar_otros.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.modificar_barrio, Me.modificar_localidad, Me.modificar_provincia})
        Me.modificar_otros.Name = "modificar_otros"
        Me.modificar_otros.Size = New System.Drawing.Size(172, 22)
        Me.modificar_otros.Text = "Otros"
        '
        'modificar_barrio
        '
        Me.modificar_barrio.Name = "modificar_barrio"
        Me.modificar_barrio.Size = New System.Drawing.Size(125, 22)
        Me.modificar_barrio.Text = "Barrio"
        '
        'modificar_localidad
        '
        Me.modificar_localidad.Name = "modificar_localidad"
        Me.modificar_localidad.Size = New System.Drawing.Size(125, 22)
        Me.modificar_localidad.Text = "Localidad"
        '
        'modificar_provincia
        '
        Me.modificar_provincia.Name = "modificar_provincia"
        Me.modificar_provincia.Size = New System.Drawing.Size(125, 22)
        Me.modificar_provincia.Text = "Provincia"
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(125, 22)
        Me.SalirToolStripMenuItem.Text = "Salir"
        '
        'PreferenciasToolStripMenuItem
        '
        Me.PreferenciasToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EstadísticasToolStripMenuItem, Me.ReporteDeVentasToolStripMenuItem, Me.EmpleadosPorVentaToolStripMenuItem})
        Me.PreferenciasToolStripMenuItem.Name = "PreferenciasToolStripMenuItem"
        Me.PreferenciasToolStripMenuItem.Size = New System.Drawing.Size(65, 20)
        Me.PreferenciasToolStripMenuItem.Text = "Reportes"
        '
        'EstadísticasToolStripMenuItem
        '
        Me.EstadísticasToolStripMenuItem.Name = "EstadísticasToolStripMenuItem"
        Me.EstadísticasToolStripMenuItem.ShortcutKeyDisplayString = "(Ctrl+R)"
        Me.EstadísticasToolStripMenuItem.Size = New System.Drawing.Size(246, 22)
        Me.EstadísticasToolStripMenuItem.Text = "Estadísticas"
        '
        'ReporteDeVentasToolStripMenuItem
        '
        Me.ReporteDeVentasToolStripMenuItem.Name = "ReporteDeVentasToolStripMenuItem"
        Me.ReporteDeVentasToolStripMenuItem.Size = New System.Drawing.Size(246, 22)
        Me.ReporteDeVentasToolStripMenuItem.Text = "Informe de ventas"
        '
        'EmpleadosPorVentaToolStripMenuItem
        '
        Me.EmpleadosPorVentaToolStripMenuItem.Name = "EmpleadosPorVentaToolStripMenuItem"
        Me.EmpleadosPorVentaToolStripMenuItem.Size = New System.Drawing.Size(246, 22)
        Me.EmpleadosPorVentaToolStripMenuItem.Text = "Informe de ventas por empleado"
        '
        'AyudaToolStripMenuItem
        '
        Me.AyudaToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AccesosDirectosToolStripMenuItem, Me.AcercaDeToolStripMenuItem})
        Me.AyudaToolStripMenuItem.Name = "AyudaToolStripMenuItem"
        Me.AyudaToolStripMenuItem.Size = New System.Drawing.Size(53, 20)
        Me.AyudaToolStripMenuItem.Text = "Ayuda"
        '
        'AccesosDirectosToolStripMenuItem
        '
        Me.AccesosDirectosToolStripMenuItem.Name = "AccesosDirectosToolStripMenuItem"
        Me.AccesosDirectosToolStripMenuItem.Size = New System.Drawing.Size(162, 22)
        Me.AccesosDirectosToolStripMenuItem.Text = "Accesos directos"
        '
        'AcercaDeToolStripMenuItem
        '
        Me.AcercaDeToolStripMenuItem.Name = "AcercaDeToolStripMenuItem"
        Me.AcercaDeToolStripMenuItem.Size = New System.Drawing.Size(162, 22)
        Me.AcercaDeToolStripMenuItem.Text = "Acerca de..."
        '
        'pb_registrar_venta
        '
        Me.pb_registrar_venta.BackColor = System.Drawing.Color.Transparent
        Me.pb_registrar_venta.BackgroundImage = Global.Heladeria_Tu_Gusto.My.Resources.Resources.icons8_Checkout_128
        Me.pb_registrar_venta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pb_registrar_venta.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pb_registrar_venta.Location = New System.Drawing.Point(6, 40)
        Me.pb_registrar_venta.Name = "pb_registrar_venta"
        Me.pb_registrar_venta.Size = New System.Drawing.Size(70, 70)
        Me.pb_registrar_venta.TabIndex = 1
        Me.pb_registrar_venta.TabStop = false
        '
        'Label1
        '
        Me.Label1.AutoSize = true
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 12!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label1.ForeColor = System.Drawing.Color.SaddleBrown
        Me.Label1.Location = New System.Drawing.Point(11, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(55, 19)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Venta"
        '
        'Label2
        '
        Me.Label2.AutoSize = true
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 12!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label2.ForeColor = System.Drawing.Color.SaddleBrown
        Me.Label2.Location = New System.Drawing.Point(405, 18)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(74, 19)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Compra"
        '
        'pb_registrar_compra
        '
        Me.pb_registrar_compra.BackColor = System.Drawing.Color.Transparent
        Me.pb_registrar_compra.BackgroundImage = Global.Heladeria_Tu_Gusto.My.Resources.Resources.icons8_Package_128
        Me.pb_registrar_compra.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pb_registrar_compra.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pb_registrar_compra.Location = New System.Drawing.Point(409, 40)
        Me.pb_registrar_compra.Name = "pb_registrar_compra"
        Me.pb_registrar_compra.Size = New System.Drawing.Size(70, 70)
        Me.pb_registrar_compra.TabIndex = 3
        Me.pb_registrar_compra.TabStop = false
        '
        'gb_registrar
        '
        Me.gb_registrar.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom)  _
            Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.gb_registrar.BackColor = System.Drawing.Color.Transparent
        Me.gb_registrar.Controls.Add(Me.Label6)
        Me.gb_registrar.Controls.Add(Me.pb_registrar_turno)
        Me.gb_registrar.Controls.Add(Me.Label5)
        Me.gb_registrar.Controls.Add(Me.pb_registrar_proveedor)
        Me.gb_registrar.Controls.Add(Me.Label4)
        Me.gb_registrar.Controls.Add(Me.pb_registrar_producto)
        Me.gb_registrar.Controls.Add(Me.Label3)
        Me.gb_registrar.Controls.Add(Me.pb_registrar_empleado)
        Me.gb_registrar.Controls.Add(Me.pb_registrar_venta)
        Me.gb_registrar.Controls.Add(Me.Label2)
        Me.gb_registrar.Controls.Add(Me.Label1)
        Me.gb_registrar.Controls.Add(Me.pb_registrar_compra)
        Me.gb_registrar.Font = New System.Drawing.Font("Arial", 10!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.gb_registrar.ForeColor = System.Drawing.Color.SaddleBrown
        Me.gb_registrar.Location = New System.Drawing.Point(12, 201)
        Me.gb_registrar.Name = "gb_registrar"
        Me.gb_registrar.Size = New System.Drawing.Size(485, 375)
        Me.gb_registrar.TabIndex = 5
        Me.gb_registrar.TabStop = false
        Me.gb_registrar.Text = "Registrar"
        '
        'Label6
        '
        Me.Label6.AutoSize = true
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Century Gothic", 12!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label6.ForeColor = System.Drawing.Color.SaddleBrown
        Me.Label6.Location = New System.Drawing.Point(421, 263)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(51, 19)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Turno"
        '
        'pb_registrar_turno
        '
        Me.pb_registrar_turno.BackColor = System.Drawing.Color.Transparent
        Me.pb_registrar_turno.BackgroundImage = Global.Heladeria_Tu_Gusto.My.Resources.Resources.icons8_calendar_plus
        Me.pb_registrar_turno.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pb_registrar_turno.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pb_registrar_turno.Location = New System.Drawing.Point(409, 294)
        Me.pb_registrar_turno.Name = "pb_registrar_turno"
        Me.pb_registrar_turno.Size = New System.Drawing.Size(70, 70)
        Me.pb_registrar_turno.TabIndex = 11
        Me.pb_registrar_turno.TabStop = false
        '
        'Label5
        '
        Me.Label5.AutoSize = true
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 12!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Peru
        Me.Label5.Location = New System.Drawing.Point(400, 140)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(88, 19)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Proveedor"
        '
        'pb_registrar_proveedor
        '
        Me.pb_registrar_proveedor.BackColor = System.Drawing.Color.Transparent
        Me.pb_registrar_proveedor.BackgroundImage = Global.Heladeria_Tu_Gusto.My.Resources.Resources.Proveedor
        Me.pb_registrar_proveedor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pb_registrar_proveedor.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pb_registrar_proveedor.Location = New System.Drawing.Point(409, 167)
        Me.pb_registrar_proveedor.Name = "pb_registrar_proveedor"
        Me.pb_registrar_proveedor.Size = New System.Drawing.Size(70, 70)
        Me.pb_registrar_proveedor.TabIndex = 9
        Me.pb_registrar_proveedor.TabStop = false
        '
        'Label4
        '
        Me.Label4.AutoSize = true
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 12!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Peru
        Me.Label4.Location = New System.Drawing.Point(6, 140)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(78, 19)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Producto"
        '
        'pb_registrar_producto
        '
        Me.pb_registrar_producto.BackColor = System.Drawing.Color.Transparent
        Me.pb_registrar_producto.BackgroundImage = Global.Heladeria_Tu_Gusto.My.Resources.Resources.ice_cream
        Me.pb_registrar_producto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pb_registrar_producto.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pb_registrar_producto.Location = New System.Drawing.Point(10, 167)
        Me.pb_registrar_producto.Name = "pb_registrar_producto"
        Me.pb_registrar_producto.Size = New System.Drawing.Size(70, 70)
        Me.pb_registrar_producto.TabIndex = 7
        Me.pb_registrar_producto.TabStop = false
        '
        'Label3
        '
        Me.Label3.AutoSize = true
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 12!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label3.ForeColor = System.Drawing.Color.SaddleBrown
        Me.Label3.Location = New System.Drawing.Point(6, 263)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(90, 19)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Empleado"
        '
        'pb_registrar_empleado
        '
        Me.pb_registrar_empleado.BackColor = System.Drawing.Color.Transparent
        Me.pb_registrar_empleado.BackgroundImage = Global.Heladeria_Tu_Gusto.My.Resources.Resources.icons8_Resume_80
        Me.pb_registrar_empleado.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pb_registrar_empleado.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pb_registrar_empleado.Location = New System.Drawing.Point(10, 294)
        Me.pb_registrar_empleado.Name = "pb_registrar_empleado"
        Me.pb_registrar_empleado.Size = New System.Drawing.Size(70, 70)
        Me.pb_registrar_empleado.TabIndex = 5
        Me.pb_registrar_empleado.TabStop = false
        '
        'gb_estadisticas
        '
        Me.gb_estadisticas.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom)  _
            Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.gb_estadisticas.BackColor = System.Drawing.Color.Transparent
        Me.gb_estadisticas.Controls.Add(Me.Label9)
        Me.gb_estadisticas.Controls.Add(Me.pb_ventas_empleado)
        Me.gb_estadisticas.Controls.Add(Me.Label8)
        Me.gb_estadisticas.Controls.Add(Me.pb_ventas)
        Me.gb_estadisticas.Controls.Add(Me.Label7)
        Me.gb_estadisticas.Controls.Add(Me.pb_estadisticas)
        Me.gb_estadisticas.Font = New System.Drawing.Font("Arial", 10!, System.Drawing.FontStyle.Bold)
        Me.gb_estadisticas.ForeColor = System.Drawing.Color.SaddleBrown
        Me.gb_estadisticas.Location = New System.Drawing.Point(15, 594)
        Me.gb_estadisticas.Name = "gb_estadisticas"
        Me.gb_estadisticas.Size = New System.Drawing.Size(485, 132)
        Me.gb_estadisticas.TabIndex = 6
        Me.gb_estadisticas.TabStop = false
        Me.gb_estadisticas.Text = "Estadísticas y reportes"
        '
        'Label9
        '
        Me.Label9.AutoSize = true
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Century Gothic", 12!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label9.ForeColor = System.Drawing.Color.SaddleBrown
        Me.Label9.Location = New System.Drawing.Point(157, 19)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(178, 19)
        Me.Label9.TabIndex = 12
        Me.Label9.Text = "Ventas por empleado"
        '
        'pb_ventas_empleado
        '
        Me.pb_ventas_empleado.BackColor = System.Drawing.Color.Transparent
        Me.pb_ventas_empleado.BackgroundImage = Global.Heladeria_Tu_Gusto.My.Resources.Resources.icons8_user
        Me.pb_ventas_empleado.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pb_ventas_empleado.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pb_ventas_empleado.Location = New System.Drawing.Point(212, 51)
        Me.pb_ventas_empleado.Name = "pb_ventas_empleado"
        Me.pb_ventas_empleado.Size = New System.Drawing.Size(70, 70)
        Me.pb_ventas_empleado.TabIndex = 11
        Me.pb_ventas_empleado.TabStop = false
        '
        'Label8
        '
        Me.Label8.AutoSize = true
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Century Gothic", 12!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label8.ForeColor = System.Drawing.Color.SaddleBrown
        Me.Label8.Location = New System.Drawing.Point(418, 19)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(61, 19)
        Me.Label8.TabIndex = 10
        Me.Label8.Text = "Ventas"
        '
        'pb_ventas
        '
        Me.pb_ventas.BackColor = System.Drawing.Color.Transparent
        Me.pb_ventas.BackgroundImage = Global.Heladeria_Tu_Gusto.My.Resources.Resources.icons8_Sales_Performance_100
        Me.pb_ventas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pb_ventas.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pb_ventas.Location = New System.Drawing.Point(409, 51)
        Me.pb_ventas.Name = "pb_ventas"
        Me.pb_ventas.Size = New System.Drawing.Size(70, 70)
        Me.pb_ventas.TabIndex = 9
        Me.pb_ventas.TabStop = false
        '
        'Label7
        '
        Me.Label7.AutoSize = true
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Century Gothic", 12!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label7.ForeColor = System.Drawing.Color.SaddleBrown
        Me.Label7.Location = New System.Drawing.Point(5, 19)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(94, 19)
        Me.Label7.TabIndex = 8
        Me.Label7.Text = "Estadísticas"
        '
        'pb_estadisticas
        '
        Me.pb_estadisticas.BackColor = System.Drawing.Color.Transparent
        Me.pb_estadisticas.BackgroundImage = Global.Heladeria_Tu_Gusto.My.Resources.Resources.icons8_statistics
        Me.pb_estadisticas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pb_estadisticas.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pb_estadisticas.Location = New System.Drawing.Point(15, 51)
        Me.pb_estadisticas.Name = "pb_estadisticas"
        Me.pb_estadisticas.Size = New System.Drawing.Size(70, 70)
        Me.pb_estadisticas.TabIndex = 7
        Me.pb_estadisticas.TabStop = false
        '
        'Principal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Heladeria_Tu_Gusto.My.Resources.Resources.Fondo_2
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(509, 751)
        Me.Controls.Add(Me.gb_estadisticas)
        Me.Controls.Add(Me.gb_registrar)
        Me.Controls.Add(Me.MenuStrip1)
        Me.DoubleBuffered = true
        Me.Icon = CType(resources.GetObject("$this.Icon"),System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Principal"
        Me.Text = "Heladería Tu Gusto"
        Me.MenuStrip1.ResumeLayout(false)
        Me.MenuStrip1.PerformLayout
        CType(Me.pb_registrar_venta,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.pb_registrar_compra,System.ComponentModel.ISupportInitialize).EndInit
        Me.gb_registrar.ResumeLayout(false)
        Me.gb_registrar.PerformLayout
        CType(Me.pb_registrar_turno,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.pb_registrar_proveedor,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.pb_registrar_producto,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.pb_registrar_empleado,System.ComponentModel.ISupportInitialize).EndInit
        Me.gb_estadisticas.ResumeLayout(false)
        Me.gb_estadisticas.PerformLayout
        CType(Me.pb_ventas_empleado,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.pb_ventas,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.pb_estadisticas,System.ComponentModel.ISupportInitialize).EndInit
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ArchivoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RegistrarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents registrar_empleado As ToolStripMenuItem
    Friend WithEvents registrar_proveedor As ToolStripMenuItem
    Friend WithEvents registrar_producto As ToolStripMenuItem
    Friend WithEvents OtrosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LocalidadToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ProvinciaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BarrioToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents modificar_empleado As ToolStripMenuItem
    Friend WithEvents modificar_proveedor As ToolStripMenuItem
    Friend WithEvents modificar_producto As ToolStripMenuItem
    Friend WithEvents modificar_otros As ToolStripMenuItem
    Friend WithEvents PreferenciasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents registrar_venta As ToolStripMenuItem
    Friend WithEvents AyudaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AccesosDirectosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CompraToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AcercaDeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents modificar_barrio As ToolStripMenuItem
    Friend WithEvents modificar_localidad As ToolStripMenuItem
    Friend WithEvents modificar_provincia As ToolStripMenuItem
    Friend WithEvents TipoProductoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TurnoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ReporteDeVentasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EmpleadosPorVentaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EstadísticasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents pb_registrar_venta As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents pb_registrar_compra As PictureBox
    Friend WithEvents gb_registrar As GroupBox
    Friend WithEvents Label3 As Label
    Friend WithEvents pb_registrar_empleado As PictureBox
    Friend WithEvents Label4 As Label
    Friend WithEvents pb_registrar_producto As PictureBox
    Friend WithEvents Label5 As Label
    Friend WithEvents pb_registrar_proveedor As PictureBox
    Friend WithEvents Label6 As Label
    Friend WithEvents pb_registrar_turno As PictureBox
    Friend WithEvents gb_estadisticas As GroupBox
    Friend WithEvents Label7 As Label
    Friend WithEvents pb_estadisticas As PictureBox
    Friend WithEvents Label9 As Label
    Friend WithEvents pb_ventas_empleado As PictureBox
    Friend WithEvents Label8 As Label
    Friend WithEvents pb_ventas As PictureBox
End Class
