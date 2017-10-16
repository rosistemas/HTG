Imports System.ComponentModel
Imports Microsoft.VisualBasic.CompilerServices

<DesignerGenerated()> _
Partial Class RegistrarProvincia
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
        Dim resources As ComponentResourceManager = New ComponentResourceManager(GetType(RegistrarProvincia))
        Me.lbl_nombre = New Label()
        Me.txt_nombre = New TextBox()
        Me.cmd_cancelar = New Button()
        Me.cmd_guardar = New Button()
        Me.GroupBox1 = New GroupBox()
        Me.Label2 = New Label()
        Me.lbl_guardar = New Label()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lbl_nombre
        '
        Me.lbl_nombre.AutoSize = True
        Me.lbl_nombre.Location = New Point(7, 22)
        Me.lbl_nombre.Name = "lbl_nombre"
        Me.lbl_nombre.Size = New Size(47, 13)
        Me.lbl_nombre.TabIndex = 0
        Me.lbl_nombre.Text = "Nombre:"
        '
        'txt_nombre
        '
        Me.txt_nombre.Location = New Point(60, 19)
        Me.txt_nombre.Name = "txt_nombre"
        Me.txt_nombre.Size = New Size(127, 20)
        Me.txt_nombre.TabIndex = 1
        '
        'cmd_cancelar
        '
        Me.cmd_cancelar.Image = My.Resources.Resources.icons8_Delete_40
        Me.cmd_cancelar.Location = New Point(152, 91)
        Me.cmd_cancelar.Name = "cmd_cancelar"
        Me.cmd_cancelar.Size = New Size(75, 46)
        Me.cmd_cancelar.TabIndex = 3
        Me.cmd_cancelar.UseVisualStyleBackColor = True
        '
        'cmd_guardar
        '
        Me.cmd_guardar.BackgroundImage = My.Resources.Resources.icons8_Add_New_40
        Me.cmd_guardar.BackgroundImageLayout = ImageLayout.Center
        Me.cmd_guardar.Location = New Point(12, 91)
        Me.cmd_guardar.Name = "cmd_guardar"
        Me.cmd_guardar.Size = New Size(75, 46)
        Me.cmd_guardar.TabIndex = 2
        Me.cmd_guardar.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lbl_nombre)
        Me.GroupBox1.Controls.Add(Me.txt_nombre)
        Me.GroupBox1.Location = New Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New Size(215, 60)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Nueva Provincia"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New Point(164, 75)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New Size(49, 13)
        Me.Label2.TabIndex = 18
        Me.Label2.Text = "Cancelar"
        '
        'lbl_guardar
        '
        Me.lbl_guardar.AutoSize = True
        Me.lbl_guardar.Location = New Point(27, 75)
        Me.lbl_guardar.Name = "lbl_guardar"
        Me.lbl_guardar.Size = New Size(45, 13)
        Me.lbl_guardar.TabIndex = 17
        Me.lbl_guardar.Text = "Guardar"
        '
        'RegistrarProvincia
        '
        Me.AutoScaleDimensions = New SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = AutoScaleMode.Font
        Me.ClientSize = New Size(241, 147)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lbl_guardar)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.cmd_cancelar)
        Me.Controls.Add(Me.cmd_guardar)
        Me.Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Me.Name = "RegistrarProvincia"
        Me.Text = "Registrar provincia"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbl_nombre As Label
    Friend WithEvents txt_nombre As TextBox
    Friend WithEvents cmd_guardar As Button
    Friend WithEvents cmd_cancelar As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label2 As Label
    Friend WithEvents lbl_guardar As Label
End Class
