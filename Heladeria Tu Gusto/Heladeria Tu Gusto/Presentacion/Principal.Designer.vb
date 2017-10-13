<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Principal
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Principal))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ArchivoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RegistrarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.registrar_venta = New System.Windows.Forms.ToolStripMenuItem()
        Me.registrar_producto = New System.Windows.Forms.ToolStripMenuItem()
        Me.registrar_empleado = New System.Windows.Forms.ToolStripMenuItem()
        Me.registrar_proveedor = New System.Windows.Forms.ToolStripMenuItem()
        Me.CompraToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OtrosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LocalidadToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProvinciaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BarrioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
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
        Me.AyudaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AccesosDirectosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AcercaDeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TipoProductoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ArchivoToolStripMenuItem, Me.PreferenciasToolStripMenuItem, Me.AyudaToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(284, 24)
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
        Me.RegistrarToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.registrar_venta, Me.registrar_producto, Me.registrar_empleado, Me.registrar_proveedor, Me.CompraToolStripMenuItem, Me.OtrosToolStripMenuItem})
        Me.RegistrarToolStripMenuItem.Name = "RegistrarToolStripMenuItem"
        Me.RegistrarToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
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
        Me.LocalidadToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.LocalidadToolStripMenuItem.Text = "Localidad"
        '
        'ProvinciaToolStripMenuItem
        '
        Me.ProvinciaToolStripMenuItem.Name = "ProvinciaToolStripMenuItem"
        Me.ProvinciaToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.ProvinciaToolStripMenuItem.Text = "Provincia"
        '
        'BarrioToolStripMenuItem
        '
        Me.BarrioToolStripMenuItem.Name = "BarrioToolStripMenuItem"
        Me.BarrioToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.BarrioToolStripMenuItem.Text = "Barrio"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.modificar_producto, Me.modificar_empleado, Me.modificar_proveedor, Me.modificar_otros})
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(152, 22)
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
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.SalirToolStripMenuItem.Text = "Salir"
        '
        'PreferenciasToolStripMenuItem
        '
        Me.PreferenciasToolStripMenuItem.Name = "PreferenciasToolStripMenuItem"
        Me.PreferenciasToolStripMenuItem.Size = New System.Drawing.Size(83, 20)
        Me.PreferenciasToolStripMenuItem.Text = "Preferencias"
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
        'TipoProductoToolStripMenuItem
        '
        Me.TipoProductoToolStripMenuItem.Name = "TipoProductoToolStripMenuItem"
        Me.TipoProductoToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.TipoProductoToolStripMenuItem.Text = "Tipo Producto"
        '
        'Principal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Heladeria_Tu_Gusto.My.Resources.Resources.icons8_Banana_split_80
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ClientSize = New System.Drawing.Size(284, 161)
        Me.Controls.Add(Me.MenuStrip1)
        Me.DoubleBuffered = true
        Me.Icon = CType(resources.GetObject("$this.Icon"),System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Principal"
        Me.Text = "Heladería Tu Gusto"
        Me.MenuStrip1.ResumeLayout(false)
        Me.MenuStrip1.PerformLayout
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents ArchivoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RegistrarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents registrar_empleado As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents registrar_proveedor As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents registrar_producto As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OtrosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LocalidadToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ProvinciaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BarrioToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents modificar_empleado As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents modificar_proveedor As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents modificar_producto As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents modificar_otros As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PreferenciasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents registrar_venta As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AyudaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AccesosDirectosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CompraToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AcercaDeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents modificar_barrio As ToolStripMenuItem
    Friend WithEvents modificar_localidad As ToolStripMenuItem
    Friend WithEvents modificar_provincia As ToolStripMenuItem
    Friend WithEvents TipoProductoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
