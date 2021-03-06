﻿Imports System.ComponentModel
Imports Microsoft.VisualBasic.CompilerServices

<DesignerGenerated()> _
Partial Class RegistrarProducto
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RegistrarProducto))
        Me.lbl_nombre = New System.Windows.Forms.Label()
        Me.lbl_precio = New System.Windows.Forms.Label()
        Me.lbl_tipo = New System.Windows.Forms.Label()
        Me.lbl_descripcion = New System.Windows.Forms.Label()
        Me.txt_nombre = New System.Windows.Forms.TextBox()
        Me.txt_descripcion = New System.Windows.Forms.TextBox()
        Me.cmb_tipo = New System.Windows.Forms.ComboBox()
        Me.cmd_guardar = New System.Windows.Forms.Button()
        Me.cmd_cancelar = New System.Windows.Forms.Button()
        Me.grp_datos = New System.Windows.Forms.GroupBox()
        Me.txt_precio = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lbl_guardar = New System.Windows.Forms.Label()
        Me.toolTip_Precio = New System.Windows.Forms.ToolTip(Me.components)
        Me.grp_datos.SuspendLayout
        Me.SuspendLayout
        '
        'lbl_nombre
        '
        Me.lbl_nombre.AutoSize = true
        Me.lbl_nombre.Location = New System.Drawing.Point(37, 28)
        Me.lbl_nombre.Name = "lbl_nombre"
        Me.lbl_nombre.Size = New System.Drawing.Size(47, 13)
        Me.lbl_nombre.TabIndex = 0
        Me.lbl_nombre.Text = "Nombre:"
        '
        'lbl_precio
        '
        Me.lbl_precio.AutoSize = true
        Me.lbl_precio.Location = New System.Drawing.Point(189, 122)
        Me.lbl_precio.Name = "lbl_precio"
        Me.lbl_precio.Size = New System.Drawing.Size(77, 13)
        Me.lbl_precio.TabIndex = 0
        Me.lbl_precio.Text = "Precio unitario:"
        '
        'lbl_tipo
        '
        Me.lbl_tipo.AutoSize = true
        Me.lbl_tipo.Location = New System.Drawing.Point(53, 122)
        Me.lbl_tipo.Name = "lbl_tipo"
        Me.lbl_tipo.Size = New System.Drawing.Size(31, 13)
        Me.lbl_tipo.TabIndex = 0
        Me.lbl_tipo.Text = "Tipo:"
        '
        'lbl_descripcion
        '
        Me.lbl_descripcion.AutoSize = true
        Me.lbl_descripcion.Location = New System.Drawing.Point(18, 58)
        Me.lbl_descripcion.Name = "lbl_descripcion"
        Me.lbl_descripcion.Size = New System.Drawing.Size(66, 13)
        Me.lbl_descripcion.TabIndex = 0
        Me.lbl_descripcion.Text = "Descripción:"
        '
        'txt_nombre
        '
        Me.txt_nombre.Location = New System.Drawing.Point(90, 25)
        Me.txt_nombre.Name = "txt_nombre"
        Me.txt_nombre.Size = New System.Drawing.Size(220, 20)
        Me.txt_nombre.TabIndex = 0
        '
        'txt_descripcion
        '
        Me.txt_descripcion.Location = New System.Drawing.Point(90, 55)
        Me.txt_descripcion.Multiline = true
        Me.txt_descripcion.Name = "txt_descripcion"
        Me.txt_descripcion.Size = New System.Drawing.Size(220, 57)
        Me.txt_descripcion.TabIndex = 2
        '
        'cmb_tipo
        '
        Me.cmb_tipo.FormattingEnabled = true
        Me.cmb_tipo.Location = New System.Drawing.Point(90, 118)
        Me.cmb_tipo.Name = "cmb_tipo"
        Me.cmb_tipo.Size = New System.Drawing.Size(93, 21)
        Me.cmb_tipo.TabIndex = 3
        '
        'cmd_guardar
        '
        Me.cmd_guardar.BackgroundImage = Global.Heladeria_Tu_Gusto.My.Resources.Resources.icons8_Add_New_40
        Me.cmd_guardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.cmd_guardar.Location = New System.Drawing.Point(12, 185)
        Me.cmd_guardar.Name = "cmd_guardar"
        Me.cmd_guardar.Size = New System.Drawing.Size(75, 46)
        Me.cmd_guardar.TabIndex = 0
        Me.cmd_guardar.UseVisualStyleBackColor = true
        '
        'cmd_cancelar
        '
        Me.cmd_cancelar.BackgroundImage = Global.Heladeria_Tu_Gusto.My.Resources.Resources.icons8_Delete_40
        Me.cmd_cancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.cmd_cancelar.Location = New System.Drawing.Point(253, 185)
        Me.cmd_cancelar.Name = "cmd_cancelar"
        Me.cmd_cancelar.Size = New System.Drawing.Size(75, 46)
        Me.cmd_cancelar.TabIndex = 1
        Me.cmd_cancelar.UseVisualStyleBackColor = true
        '
        'grp_datos
        '
        Me.grp_datos.Controls.Add(Me.txt_precio)
        Me.grp_datos.Controls.Add(Me.lbl_tipo)
        Me.grp_datos.Controls.Add(Me.lbl_nombre)
        Me.grp_datos.Controls.Add(Me.lbl_precio)
        Me.grp_datos.Controls.Add(Me.cmb_tipo)
        Me.grp_datos.Controls.Add(Me.lbl_descripcion)
        Me.grp_datos.Controls.Add(Me.txt_nombre)
        Me.grp_datos.Controls.Add(Me.txt_descripcion)
        Me.grp_datos.Location = New System.Drawing.Point(12, 12)
        Me.grp_datos.Name = "grp_datos"
        Me.grp_datos.Size = New System.Drawing.Size(316, 153)
        Me.grp_datos.TabIndex = 5
        Me.grp_datos.TabStop = false
        Me.grp_datos.Text = "Datos del producto"
        '
        'txt_precio
        '
        Me.txt_precio.Location = New System.Drawing.Point(270, 119)
        Me.txt_precio.Name = "txt_precio"
        Me.txt_precio.Size = New System.Drawing.Size(40, 20)
        Me.txt_precio.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = true
        Me.Label1.Location = New System.Drawing.Point(268, 169)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(49, 13)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Cancelar"
        '
        'lbl_guardar
        '
        Me.lbl_guardar.AutoSize = true
        Me.lbl_guardar.Location = New System.Drawing.Point(29, 169)
        Me.lbl_guardar.Name = "lbl_guardar"
        Me.lbl_guardar.Size = New System.Drawing.Size(45, 13)
        Me.lbl_guardar.TabIndex = 6
        Me.lbl_guardar.Text = "Guardar"
        '
        'RegistrarProducto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(339, 234)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lbl_guardar)
        Me.Controls.Add(Me.grp_datos)
        Me.Controls.Add(Me.cmd_cancelar)
        Me.Controls.Add(Me.cmd_guardar)
        Me.Icon = CType(resources.GetObject("$this.Icon"),System.Drawing.Icon)
        Me.Name = "RegistrarProducto"
        Me.Text = "Registrar producto"
        Me.grp_datos.ResumeLayout(false)
        Me.grp_datos.PerformLayout
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub
    Friend WithEvents lbl_nombre As Label
    Friend WithEvents lbl_precio As Label
    Friend WithEvents lbl_tipo As Label
    Friend WithEvents lbl_descripcion As Label
    Friend WithEvents txt_nombre As TextBox
    Friend WithEvents txt_descripcion As TextBox
    Friend WithEvents cmb_tipo As ComboBox
    Friend WithEvents cmd_guardar As Button
    Friend WithEvents cmd_cancelar As Button
    Friend WithEvents grp_datos As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents lbl_guardar As Label
    Friend WithEvents txt_precio As TextBox
    Friend WithEvents toolTip_Precio As ToolTip
End Class
