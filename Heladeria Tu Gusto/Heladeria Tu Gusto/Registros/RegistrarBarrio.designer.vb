Imports System.ComponentModel
Imports Microsoft.VisualBasic.CompilerServices

<DesignerGenerated()> _
Partial Class RegistrarBarrio
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
        Me.components = New Container()
        Dim resources As ComponentResourceManager = New ComponentResourceManager(GetType(RegistrarBarrio))
        Me.ContextMenuStrip1 = New ContextMenuStrip(Me.components)
        Me.grp_barrio = New GroupBox()
        Me.txt_nombre = New TextBox()
        Me.cmd_cancelar = New Button()
        Me.cmd_guardar = New Button()
        Me.lbl_localidad = New Label()
        Me.lbl_nombre = New Label()
        Me.cmb_localidad = New ComboBox()
        Me.lbl_cancelar = New Label()
        Me.lbl_guardar = New Label()
        Me.grp_barrio.SuspendLayout()
        Me.SuspendLayout()
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New Size(61, 4)
        '
        'grp_barrio
        '
        Me.grp_barrio.Controls.Add(Me.txt_nombre)
        Me.grp_barrio.Controls.Add(Me.lbl_localidad)
        Me.grp_barrio.Controls.Add(Me.lbl_nombre)
        Me.grp_barrio.Controls.Add(Me.cmb_localidad)
        Me.grp_barrio.Location = New Point(12, 12)
        Me.grp_barrio.Name = "grp_barrio"
        Me.grp_barrio.Size = New Size(251, 94)
        Me.grp_barrio.TabIndex = 1
        Me.grp_barrio.TabStop = False
        Me.grp_barrio.Text = "Nuevo Barrio"
        '
        'txt_nombre
        '
        Me.txt_nombre.Location = New Point(78, 20)
        Me.txt_nombre.Name = "txt_nombre"
        Me.txt_nombre.Size = New Size(167, 20)
        Me.txt_nombre.TabIndex = 5
        '
        'cmd_cancelar
        '
        Me.cmd_cancelar.Image = My.Resources.Resources.icons8_Delete_40
        Me.cmd_cancelar.Location = New Point(188, 135)
        Me.cmd_cancelar.Name = "cmd_cancelar"
        Me.cmd_cancelar.Size = New Size(75, 46)
        Me.cmd_cancelar.TabIndex = 4
        Me.cmd_cancelar.UseVisualStyleBackColor = True
        '
        'cmd_guardar
        '
        Me.cmd_guardar.BackgroundImage = My.Resources.Resources.icons8_Add_New_40
        Me.cmd_guardar.BackgroundImageLayout = ImageLayout.Center
        Me.cmd_guardar.Location = New Point(11, 135)
        Me.cmd_guardar.Name = "cmd_guardar"
        Me.cmd_guardar.Size = New Size(75, 46)
        Me.cmd_guardar.TabIndex = 3
        Me.cmd_guardar.Text = "                                                                      "
        Me.cmd_guardar.UseVisualStyleBackColor = True
        '
        'lbl_localidad
        '
        Me.lbl_localidad.AutoSize = True
        Me.lbl_localidad.Location = New Point(16, 63)
        Me.lbl_localidad.Name = "lbl_localidad"
        Me.lbl_localidad.Size = New Size(56, 13)
        Me.lbl_localidad.TabIndex = 2
        Me.lbl_localidad.Text = "Localidad:"
        '
        'lbl_nombre
        '
        Me.lbl_nombre.AutoSize = True
        Me.lbl_nombre.Location = New Point(25, 23)
        Me.lbl_nombre.Name = "lbl_nombre"
        Me.lbl_nombre.Size = New Size(47, 13)
        Me.lbl_nombre.TabIndex = 1
        Me.lbl_nombre.Text = "Nombre:"
        '
        'cmb_localidad
        '
        Me.cmb_localidad.FormattingEnabled = True
        Me.cmb_localidad.Location = New Point(78, 60)
        Me.cmb_localidad.Name = "cmb_localidad"
        Me.cmb_localidad.Size = New Size(167, 21)
        Me.cmb_localidad.TabIndex = 0
        '
        'lbl_cancelar
        '
        Me.lbl_cancelar.AutoSize = True
        Me.lbl_cancelar.Location = New Point(199, 115)
        Me.lbl_cancelar.Name = "lbl_cancelar"
        Me.lbl_cancelar.Size = New Size(49, 13)
        Me.lbl_cancelar.TabIndex = 18
        Me.lbl_cancelar.Text = "Cancelar"
        '
        'lbl_guardar
        '
        Me.lbl_guardar.AutoSize = True
        Me.lbl_guardar.Location = New Point(27, 115)
        Me.lbl_guardar.Name = "lbl_guardar"
        Me.lbl_guardar.Size = New Size(45, 13)
        Me.lbl_guardar.TabIndex = 17
        Me.lbl_guardar.Text = "Guardar"
        '
        'RegistrarBarrio
        '
        Me.AutoScaleDimensions = New SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = AutoScaleMode.Font
        Me.ClientSize = New Size(275, 192)
        Me.Controls.Add(Me.lbl_cancelar)
        Me.Controls.Add(Me.lbl_guardar)
        Me.Controls.Add(Me.cmd_cancelar)
        Me.Controls.Add(Me.cmd_guardar)
        Me.Controls.Add(Me.grp_barrio)
        Me.Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Me.Name = "RegistrarBarrio"
        Me.Text = "Registrar barrio"
        Me.grp_barrio.ResumeLayout(False)
        Me.grp_barrio.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents grp_barrio As GroupBox
    Friend WithEvents txt_nombre As TextBox
    Friend WithEvents cmd_cancelar As Button
    Friend WithEvents cmd_guardar As Button
    Friend WithEvents lbl_localidad As Label
    Friend WithEvents lbl_nombre As Label
    Friend WithEvents cmb_localidad As ComboBox
    Friend WithEvents lbl_cancelar As Label
    Friend WithEvents lbl_guardar As Label
End Class
