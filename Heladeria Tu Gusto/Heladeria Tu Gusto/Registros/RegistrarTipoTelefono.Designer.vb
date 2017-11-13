<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RegistrarTipoTelefono
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RegistrarTipoTelefono))
        Me.lbl_cancelar = New System.Windows.Forms.Label()
        Me.lbl_guardar = New System.Windows.Forms.Label()
        Me.cmd_cancelar = New System.Windows.Forms.Button()
        Me.cmd_guardar = New System.Windows.Forms.Button()
        Me.grp_nvoTipoTelefono = New System.Windows.Forms.GroupBox()
        Me.txt_nombre = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.grp_nvoTipoTelefono.SuspendLayout()
        Me.SuspendLayout()
        '
        'lbl_cancelar
        '
        Me.lbl_cancelar.AutoSize = True
        Me.lbl_cancelar.Location = New System.Drawing.Point(220, 88)
        Me.lbl_cancelar.Name = "lbl_cancelar"
        Me.lbl_cancelar.Size = New System.Drawing.Size(49, 13)
        Me.lbl_cancelar.TabIndex = 24
        Me.lbl_cancelar.Text = "Cancelar"
        '
        'lbl_guardar
        '
        Me.lbl_guardar.AutoSize = True
        Me.lbl_guardar.Location = New System.Drawing.Point(22, 88)
        Me.lbl_guardar.Name = "lbl_guardar"
        Me.lbl_guardar.Size = New System.Drawing.Size(45, 13)
        Me.lbl_guardar.TabIndex = 23
        Me.lbl_guardar.Text = "Guardar"
        '
        'cmd_cancelar
        '
        Me.cmd_cancelar.Image = Global.Heladeria_Tu_Gusto.My.Resources.Resources.icons8_Delete_40
        Me.cmd_cancelar.Location = New System.Drawing.Point(209, 104)
        Me.cmd_cancelar.Name = "cmd_cancelar"
        Me.cmd_cancelar.Size = New System.Drawing.Size(75, 61)
        Me.cmd_cancelar.TabIndex = 22
        Me.cmd_cancelar.UseVisualStyleBackColor = True
        '
        'cmd_guardar
        '
        Me.cmd_guardar.Image = Global.Heladeria_Tu_Gusto.My.Resources.Resources.icons8_Save_as_64
        Me.cmd_guardar.Location = New System.Drawing.Point(12, 104)
        Me.cmd_guardar.Name = "cmd_guardar"
        Me.cmd_guardar.Size = New System.Drawing.Size(75, 61)
        Me.cmd_guardar.TabIndex = 20
        Me.cmd_guardar.UseVisualStyleBackColor = True
        '
        'grp_nvoTipoTelefono
        '
        Me.grp_nvoTipoTelefono.Controls.Add(Me.txt_nombre)
        Me.grp_nvoTipoTelefono.Controls.Add(Me.Label1)
        Me.grp_nvoTipoTelefono.Location = New System.Drawing.Point(12, 12)
        Me.grp_nvoTipoTelefono.Name = "grp_nvoTipoTelefono"
        Me.grp_nvoTipoTelefono.Size = New System.Drawing.Size(272, 67)
        Me.grp_nvoTipoTelefono.TabIndex = 21
        Me.grp_nvoTipoTelefono.TabStop = False
        Me.grp_nvoTipoTelefono.Text = "Datos del tipo de telefono"
        '
        'txt_nombre
        '
        Me.txt_nombre.Location = New System.Drawing.Point(71, 28)
        Me.txt_nombre.Name = "txt_nombre"
        Me.txt_nombre.Size = New System.Drawing.Size(157, 20)
        Me.txt_nombre.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(18, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(47, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nombre:"
        '
        'RegistrarTipoTelefono
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(296, 174)
        Me.Controls.Add(Me.lbl_cancelar)
        Me.Controls.Add(Me.lbl_guardar)
        Me.Controls.Add(Me.cmd_cancelar)
        Me.Controls.Add(Me.cmd_guardar)
        Me.Controls.Add(Me.grp_nvoTipoTelefono)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "RegistrarTipoTelefono"
        Me.Text = "RegistrarTipoTelefono"
        Me.grp_nvoTipoTelefono.ResumeLayout(False)
        Me.grp_nvoTipoTelefono.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbl_cancelar As Label
    Friend WithEvents lbl_guardar As Label
    Friend WithEvents cmd_cancelar As Button
    Friend WithEvents cmd_guardar As Button
    Friend WithEvents grp_nvoTipoTelefono As GroupBox
    Friend WithEvents txt_nombre As TextBox
    Friend WithEvents Label1 As Label
End Class
