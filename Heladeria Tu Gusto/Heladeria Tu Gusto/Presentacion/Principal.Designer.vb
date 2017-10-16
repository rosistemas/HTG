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
        Dim resources As ComponentResourceManager = New ComponentResourceManager(GetType(Principal))
        Me.MenuStrip1 = New MenuStrip()
        Me.ArchivoToolStripMenuItem = New ToolStripMenuItem()
        Me.RegistrarToolStripMenuItem = New ToolStripMenuItem()
        Me.registrar_venta = New ToolStripMenuItem()
        Me.registrar_producto = New ToolStripMenuItem()
        Me.registrar_empleado = New ToolStripMenuItem()
        Me.registrar_proveedor = New ToolStripMenuItem()
        Me.CompraToolStripMenuItem = New ToolStripMenuItem()
        Me.OtrosToolStripMenuItem = New ToolStripMenuItem()
        Me.LocalidadToolStripMenuItem = New ToolStripMenuItem()
        Me.ProvinciaToolStripMenuItem = New ToolStripMenuItem()
        Me.BarrioToolStripMenuItem = New ToolStripMenuItem()
        Me.TipoProductoToolStripMenuItem = New ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New ToolStripMenuItem()
        Me.modificar_producto = New ToolStripMenuItem()
        Me.modificar_empleado = New ToolStripMenuItem()
        Me.modificar_proveedor = New ToolStripMenuItem()
        Me.modificar_otros = New ToolStripMenuItem()
        Me.modificar_barrio = New ToolStripMenuItem()
        Me.modificar_localidad = New ToolStripMenuItem()
        Me.modificar_provincia = New ToolStripMenuItem()
        Me.SalirToolStripMenuItem = New ToolStripMenuItem()
        Me.PreferenciasToolStripMenuItem = New ToolStripMenuItem()
        Me.AyudaToolStripMenuItem = New ToolStripMenuItem()
        Me.AccesosDirectosToolStripMenuItem = New ToolStripMenuItem()
        Me.AcercaDeToolStripMenuItem = New ToolStripMenuItem()
        Me.TurnoToolStripMenuItem = New ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New ToolStripItem() {Me.ArchivoToolStripMenuItem, Me.PreferenciasToolStripMenuItem, Me.AyudaToolStripMenuItem})
        Me.MenuStrip1.Location = New Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New Size(284, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ArchivoToolStripMenuItem
        '
        Me.ArchivoToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {Me.RegistrarToolStripMenuItem, Me.ToolStripMenuItem1, Me.SalirToolStripMenuItem})
        Me.ArchivoToolStripMenuItem.Name = "ArchivoToolStripMenuItem"
        Me.ArchivoToolStripMenuItem.Size = New Size(60, 20)
        Me.ArchivoToolStripMenuItem.Text = "Archivo"
        '
        'RegistrarToolStripMenuItem
        '
        Me.RegistrarToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {Me.registrar_venta, Me.registrar_producto, Me.registrar_empleado, Me.registrar_proveedor, Me.CompraToolStripMenuItem, Me.TurnoToolStripMenuItem, Me.OtrosToolStripMenuItem})
        Me.RegistrarToolStripMenuItem.Name = "RegistrarToolStripMenuItem"
        Me.RegistrarToolStripMenuItem.Size = New Size(152, 22)
        Me.RegistrarToolStripMenuItem.Text = "Registrar"
        '
        'registrar_venta
        '
        Me.registrar_venta.Name = "registrar_venta"
        Me.registrar_venta.ShortcutKeyDisplayString = "(Ctrl+0)"
        Me.registrar_venta.Size = New Size(176, 22)
        Me.registrar_venta.Tag = ""
        Me.registrar_venta.Text = "Venta"
        '
        'registrar_producto
        '
        Me.registrar_producto.Name = "registrar_producto"
        Me.registrar_producto.ShortcutKeyDisplayString = "(Ctrl+1)"
        Me.registrar_producto.Size = New Size(176, 22)
        Me.registrar_producto.Text = "Producto"
        '
        'registrar_empleado
        '
        Me.registrar_empleado.Name = "registrar_empleado"
        Me.registrar_empleado.ShortcutKeyDisplayString = "(Ctrl+2)"
        Me.registrar_empleado.Size = New Size(176, 22)
        Me.registrar_empleado.Text = "Empleado"
        '
        'registrar_proveedor
        '
        Me.registrar_proveedor.Name = "registrar_proveedor"
        Me.registrar_proveedor.ShortcutKeyDisplayString = "(Ctrl+3)"
        Me.registrar_proveedor.Size = New Size(176, 22)
        Me.registrar_proveedor.Text = "Proveedor"
        '
        'CompraToolStripMenuItem
        '
        Me.CompraToolStripMenuItem.Name = "CompraToolStripMenuItem"
        Me.CompraToolStripMenuItem.ShortcutKeyDisplayString = "(Ctrl+4)"
        Me.CompraToolStripMenuItem.Size = New Size(176, 22)
        Me.CompraToolStripMenuItem.Text = "Compra"
        '
        'OtrosToolStripMenuItem
        '
        Me.OtrosToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {Me.LocalidadToolStripMenuItem, Me.ProvinciaToolStripMenuItem, Me.BarrioToolStripMenuItem, Me.TipoProductoToolStripMenuItem})
        Me.OtrosToolStripMenuItem.Name = "OtrosToolStripMenuItem"
        Me.OtrosToolStripMenuItem.Size = New Size(176, 22)
        Me.OtrosToolStripMenuItem.Text = "Otros"
        '
        'LocalidadToolStripMenuItem
        '
        Me.LocalidadToolStripMenuItem.Name = "LocalidadToolStripMenuItem"
        Me.LocalidadToolStripMenuItem.Size = New Size(150, 22)
        Me.LocalidadToolStripMenuItem.Text = "Localidad"
        '
        'ProvinciaToolStripMenuItem
        '
        Me.ProvinciaToolStripMenuItem.Name = "ProvinciaToolStripMenuItem"
        Me.ProvinciaToolStripMenuItem.Size = New Size(150, 22)
        Me.ProvinciaToolStripMenuItem.Text = "Provincia"
        '
        'BarrioToolStripMenuItem
        '
        Me.BarrioToolStripMenuItem.Name = "BarrioToolStripMenuItem"
        Me.BarrioToolStripMenuItem.Size = New Size(150, 22)
        Me.BarrioToolStripMenuItem.Text = "Barrio"
        '
        'TipoProductoToolStripMenuItem
        '
        Me.TipoProductoToolStripMenuItem.Name = "TipoProductoToolStripMenuItem"
        Me.TipoProductoToolStripMenuItem.Size = New Size(150, 22)
        Me.TipoProductoToolStripMenuItem.Text = "Tipo Producto"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.DropDownItems.AddRange(New ToolStripItem() {Me.modificar_producto, Me.modificar_empleado, Me.modificar_proveedor, Me.modificar_otros})
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New Size(152, 22)
        Me.ToolStripMenuItem1.Text = "Modificar"
        '
        'modificar_producto
        '
        Me.modificar_producto.Name = "modificar_producto"
        Me.modificar_producto.ShortcutKeyDisplayString = "(Alt+1)"
        Me.modificar_producto.Size = New Size(172, 22)
        Me.modificar_producto.Text = "Producto"
        '
        'modificar_empleado
        '
        Me.modificar_empleado.Name = "modificar_empleado"
        Me.modificar_empleado.ShortcutKeyDisplayString = "(Alt+2)"
        Me.modificar_empleado.Size = New Size(172, 22)
        Me.modificar_empleado.Text = "Empleado"
        '
        'modificar_proveedor
        '
        Me.modificar_proveedor.Name = "modificar_proveedor"
        Me.modificar_proveedor.ShortcutKeyDisplayString = "(Alt+3)"
        Me.modificar_proveedor.Size = New Size(172, 22)
        Me.modificar_proveedor.Text = "Proveedor"
        '
        'modificar_otros
        '
        Me.modificar_otros.DropDownItems.AddRange(New ToolStripItem() {Me.modificar_barrio, Me.modificar_localidad, Me.modificar_provincia})
        Me.modificar_otros.Name = "modificar_otros"
        Me.modificar_otros.Size = New Size(172, 22)
        Me.modificar_otros.Text = "Otros"
        '
        'modificar_barrio
        '
        Me.modificar_barrio.Name = "modificar_barrio"
        Me.modificar_barrio.Size = New Size(125, 22)
        Me.modificar_barrio.Text = "Barrio"
        '
        'modificar_localidad
        '
        Me.modificar_localidad.Name = "modificar_localidad"
        Me.modificar_localidad.Size = New Size(125, 22)
        Me.modificar_localidad.Text = "Localidad"
        '
        'modificar_provincia
        '
        Me.modificar_provincia.Name = "modificar_provincia"
        Me.modificar_provincia.Size = New Size(125, 22)
        Me.modificar_provincia.Text = "Provincia"
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New Size(152, 22)
        Me.SalirToolStripMenuItem.Text = "Salir"
        '
        'PreferenciasToolStripMenuItem
        '
        Me.PreferenciasToolStripMenuItem.Name = "PreferenciasToolStripMenuItem"
        Me.PreferenciasToolStripMenuItem.Size = New Size(83, 20)
        Me.PreferenciasToolStripMenuItem.Text = "Preferencias"
        '
        'AyudaToolStripMenuItem
        '
        Me.AyudaToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {Me.AccesosDirectosToolStripMenuItem, Me.AcercaDeToolStripMenuItem})
        Me.AyudaToolStripMenuItem.Name = "AyudaToolStripMenuItem"
        Me.AyudaToolStripMenuItem.Size = New Size(53, 20)
        Me.AyudaToolStripMenuItem.Text = "Ayuda"
        '
        'AccesosDirectosToolStripMenuItem
        '
        Me.AccesosDirectosToolStripMenuItem.Name = "AccesosDirectosToolStripMenuItem"
        Me.AccesosDirectosToolStripMenuItem.Size = New Size(162, 22)
        Me.AccesosDirectosToolStripMenuItem.Text = "Accesos directos"
        '
        'AcercaDeToolStripMenuItem
        '
        Me.AcercaDeToolStripMenuItem.Name = "AcercaDeToolStripMenuItem"
        Me.AcercaDeToolStripMenuItem.Size = New Size(162, 22)
        Me.AcercaDeToolStripMenuItem.Text = "Acerca de..."
        '
        'TurnoToolStripMenuItem
        '
        Me.TurnoToolStripMenuItem.Name = "TurnoToolStripMenuItem"
        Me.TurnoToolStripMenuItem.Size = New Size(176, 22)
        Me.TurnoToolStripMenuItem.Text = "Turno"
        '
        'Principal
        '
        Me.AutoScaleDimensions = New SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = AutoScaleMode.Font
        Me.BackgroundImage = My.Resources.Resources.icons8_Banana_split_80
        Me.BackgroundImageLayout = ImageLayout.Center
        Me.ClientSize = New Size(284, 161)
        Me.Controls.Add(Me.MenuStrip1)
        Me.DoubleBuffered = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Principal"
        Me.Text = "Heladería Tu Gusto"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

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
End Class
