Imports System.ComponentModel
Imports Microsoft.VisualBasic.CompilerServices

<DesignerGenerated()> _
Partial Class RegistrarLocalidad
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
        Dim resources As ComponentResourceManager = New ComponentResourceManager(GetType(RegistrarLocalidad))
        Me.GroupBox1 = New GroupBox()
        Me.cmd_cancelar = New Button()
        Me.cmd_guardar = New Button()
        Me.lbl_provincia = New Label()
        Me.cmb_provincia = New ComboBox()
        Me.txt_nombre = New TextBox()
        Me.lbl_nombre = New Label()
        Me.lbl_guardar = New Label()
        Me.lbl_cancelar = New Label()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lbl_provincia)
        Me.GroupBox1.Controls.Add(Me.cmb_provincia)
        Me.GroupBox1.Controls.Add(Me.txt_nombre)
        Me.GroupBox1.Controls.Add(Me.lbl_nombre)
        Me.GroupBox1.Location = New Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New Size(240, 93)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Nueva Localidad"
        '
        'cmd_cancelar
        '
        Me.cmd_cancelar.Image = My.Resources.Resources.icons8_Delete_40
        Me.cmd_cancelar.Location = New Point(177, 124)
        Me.cmd_cancelar.Name = "cmd_cancelar"
        Me.cmd_cancelar.Size = New Size(75, 46)
        Me.cmd_cancelar.TabIndex = 5
        Me.cmd_cancelar.UseVisualStyleBackColor = True
        '
        'cmd_guardar
        '
        Me.cmd_guardar.BackgroundImage = My.Resources.Resources.icons8_Add_New_40
        Me.cmd_guardar.BackgroundImageLayout = ImageLayout.Center
        Me.cmd_guardar.Location = New Point(12, 124)
        Me.cmd_guardar.Name = "cmd_guardar"
        Me.cmd_guardar.Size = New Size(75, 46)
        Me.cmd_guardar.TabIndex = 4
        Me.cmd_guardar.UseVisualStyleBackColor = True
        '
        'lbl_provincia
        '
        Me.lbl_provincia.AutoSize = True
        Me.lbl_provincia.Location = New Point(7, 58)
        Me.lbl_provincia.Name = "lbl_provincia"
        Me.lbl_provincia.Size = New Size(51, 13)
        Me.lbl_provincia.TabIndex = 3
        Me.lbl_provincia.Text = "Provincia"
        '
        'cmb_provincia
        '
        Me.cmb_provincia.FormattingEnabled = True
        Me.cmb_provincia.Location = New Point(89, 58)
        Me.cmb_provincia.Name = "cmb_provincia"
        Me.cmb_provincia.Size = New Size(140, 21)
        Me.cmb_provincia.TabIndex = 2
        '
        'txt_nombre
        '
        Me.txt_nombre.ImeMode = ImeMode.[On]
        Me.txt_nombre.Location = New Point(89, 31)
        Me.txt_nombre.Name = "txt_nombre"
        Me.txt_nombre.Size = New Size(140, 20)
        Me.txt_nombre.TabIndex = 1
        '
        'lbl_nombre
        '
        Me.lbl_nombre.AutoSize = True
        Me.lbl_nombre.Location = New Point(7, 31)
        Me.lbl_nombre.Name = "lbl_nombre"
        Me.lbl_nombre.Size = New Size(44, 13)
        Me.lbl_nombre.TabIndex = 0
        Me.lbl_nombre.Text = "Nombre"
        '
        'lbl_guardar
        '
        Me.lbl_guardar.AutoSize = True
        Me.lbl_guardar.Location = New Point(26, 108)
        Me.lbl_guardar.Name = "lbl_guardar"
        Me.lbl_guardar.Size = New Size(45, 13)
        Me.lbl_guardar.TabIndex = 16
        Me.lbl_guardar.Text = "Guardar"
        '
        'lbl_cancelar
        '
        Me.lbl_cancelar.AutoSize = True
        Me.lbl_cancelar.Location = New Point(191, 108)
        Me.lbl_cancelar.Name = "lbl_cancelar"
        Me.lbl_cancelar.Size = New Size(49, 13)
        Me.lbl_cancelar.TabIndex = 17
        Me.lbl_cancelar.Text = "Cancelar"
        '
        'RegistrarLocalidad
        '
        Me.AutoScaleDimensions = New SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = AutoScaleMode.Font
        Me.ClientSize = New Size(261, 188)
        Me.Controls.Add(Me.lbl_cancelar)
        Me.Controls.Add(Me.lbl_guardar)
        Me.Controls.Add(Me.cmd_cancelar)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.cmd_guardar)
        Me.Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Me.Name = "RegistrarLocalidad"
        Me.Text = "Registrar localidad"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents cmd_cancelar As Button
    Friend WithEvents cmd_guardar As Button
    Friend WithEvents lbl_provincia As Label
    Friend WithEvents cmb_provincia As ComboBox
    Friend WithEvents txt_nombre As TextBox
    Friend WithEvents lbl_nombre As Label
    Friend WithEvents lbl_guardar As Label
    Friend WithEvents lbl_cancelar As Label
End Class
