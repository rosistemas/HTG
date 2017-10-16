Imports System.ComponentModel
Imports Heladeria_Tu_Gusto.My.Resources
Imports Microsoft.VisualBasic.CompilerServices

<DesignerGenerated()> _
Partial Class RegistrarTipoProducto
    Inherits Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RegistrarTipoProducto))
        Me.grp_nvoTipoProducto = New System.Windows.Forms.GroupBox()
        Me.txt_nombre = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmd_guardar = New System.Windows.Forms.Button()
        Me.cmd_cancelar = New System.Windows.Forms.Button()
        Me.lbl_guardar = New System.Windows.Forms.Label()
        Me.lbl_cancelar = New System.Windows.Forms.Label()
        Me.grp_nvoTipoProducto.SuspendLayout
        Me.SuspendLayout
        '
        'grp_nvoTipoProducto
        '
        Me.grp_nvoTipoProducto.Controls.Add(Me.txt_nombre)
        Me.grp_nvoTipoProducto.Controls.Add(Me.Label1)
        Me.grp_nvoTipoProducto.Location = New System.Drawing.Point(22, 24)
        Me.grp_nvoTipoProducto.Name = "grp_nvoTipoProducto"
        Me.grp_nvoTipoProducto.Size = New System.Drawing.Size(235, 67)
        Me.grp_nvoTipoProducto.TabIndex = 0
        Me.grp_nvoTipoProducto.TabStop = false
        Me.grp_nvoTipoProducto.Text = "Datos del tipo de producto"
        '
        'txt_nombre
        '
        Me.txt_nombre.Location = New System.Drawing.Point(64, 23)
        Me.txt_nombre.Name = "txt_nombre"
        Me.txt_nombre.Size = New System.Drawing.Size(157, 20)
        Me.txt_nombre.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = true
        Me.Label1.Location = New System.Drawing.Point(11, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(47, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nombre:"
        '
        'cmd_guardar
        '
        Me.cmd_guardar.Image = Global.Heladeria_Tu_Gusto.My.Resources.Resources.icons8_Save_as_64
        Me.cmd_guardar.Location = New System.Drawing.Point(36, 116)
        Me.cmd_guardar.Name = "cmd_guardar"
        Me.cmd_guardar.Size = New System.Drawing.Size(75, 61)
        Me.cmd_guardar.TabIndex = 0
        Me.cmd_guardar.UseVisualStyleBackColor = true
        '
        'cmd_cancelar
        '
        Me.cmd_cancelar.Image = Global.Heladeria_Tu_Gusto.My.Resources.Resources.icons8_Delete_40
        Me.cmd_cancelar.Location = New System.Drawing.Point(168, 116)
        Me.cmd_cancelar.Name = "cmd_cancelar"
        Me.cmd_cancelar.Size = New System.Drawing.Size(75, 61)
        Me.cmd_cancelar.TabIndex = 1
        Me.cmd_cancelar.UseVisualStyleBackColor = true
        '
        'lbl_guardar
        '
        Me.lbl_guardar.AutoSize = true
        Me.lbl_guardar.Location = New System.Drawing.Point(46, 100)
        Me.lbl_guardar.Name = "lbl_guardar"
        Me.lbl_guardar.Size = New System.Drawing.Size(45, 13)
        Me.lbl_guardar.TabIndex = 18
        Me.lbl_guardar.Text = "Guardar"
        '
        'lbl_cancelar
        '
        Me.lbl_cancelar.AutoSize = true
        Me.lbl_cancelar.Location = New System.Drawing.Point(179, 100)
        Me.lbl_cancelar.Name = "lbl_cancelar"
        Me.lbl_cancelar.Size = New System.Drawing.Size(49, 13)
        Me.lbl_cancelar.TabIndex = 19
        Me.lbl_cancelar.Text = "Cancelar"
        '
        'RegistrarTipoProducto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 184)
        Me.Controls.Add(Me.lbl_cancelar)
        Me.Controls.Add(Me.lbl_guardar)
        Me.Controls.Add(Me.cmd_cancelar)
        Me.Controls.Add(Me.cmd_guardar)
        Me.Controls.Add(Me.grp_nvoTipoProducto)
        Me.Icon = CType(resources.GetObject("$this.Icon"),System.Drawing.Icon)
        Me.Name = "RegistrarTipoProducto"
        Me.Text = "Registrar tipo de producto"
        Me.grp_nvoTipoProducto.ResumeLayout(false)
        Me.grp_nvoTipoProducto.PerformLayout
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub
    Friend WithEvents grp_nvoTipoProducto As GroupBox
    Friend WithEvents cmd_guardar As Button
    Friend WithEvents cmd_cancelar As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents txt_nombre As TextBox
    Friend WithEvents lbl_guardar As Label
    Friend WithEvents lbl_cancelar As Label
End Class
