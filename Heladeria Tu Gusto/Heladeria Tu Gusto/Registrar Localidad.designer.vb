<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Registrar_Localidad
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.button_cancel = New System.Windows.Forms.Button()
        Me.button_save = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmb_provincia = New System.Windows.Forms.ComboBox()
        Me.txt_nombre = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.button_cancel)
        Me.GroupBox1.Controls.Add(Me.button_save)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.cmb_provincia)
        Me.GroupBox1.Controls.Add(Me.txt_nombre)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(25, 25)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(229, 206)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Nueva Localidad"
        '
        'button_cancel
        '
        Me.button_cancel.Image = Global.Heladeria_Tu_Gusto.My.Resources.Resources.icons8_Delete_40
        Me.button_cancel.Location = New System.Drawing.Point(128, 134)
        Me.button_cancel.Name = "button_cancel"
        Me.button_cancel.Size = New System.Drawing.Size(88, 48)
        Me.button_cancel.TabIndex = 5
        Me.button_cancel.UseVisualStyleBackColor = True
        '
        'button_save
        '
        Me.button_save.Image = Global.Heladeria_Tu_Gusto.My.Resources.Resources.icons8_Save_as_64
        Me.button_save.Location = New System.Drawing.Point(10, 134)
        Me.button_save.Name = "button_save"
        Me.button_save.Size = New System.Drawing.Size(82, 48)
        Me.button_save.TabIndex = 4
        Me.button_save.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(7, 58)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(51, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Provincia"
        '
        'cmb_provincia
        '
        Me.cmb_provincia.FormattingEnabled = True
        Me.cmb_provincia.Location = New System.Drawing.Point(89, 58)
        Me.cmb_provincia.Name = "cmb_provincia"
        Me.cmb_provincia.Size = New System.Drawing.Size(121, 21)
        Me.cmb_provincia.TabIndex = 2
        '
        'txt_nombre
        '
        Me.txt_nombre.ImeMode = System.Windows.Forms.ImeMode.[On]
        Me.txt_nombre.Location = New System.Drawing.Point(89, 31)
        Me.txt_nombre.Name = "txt_nombre"
        Me.txt_nombre.Size = New System.Drawing.Size(121, 20)
        Me.txt_nombre.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(7, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nombre"
        '
        'Registrar_Localidad
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Registrar_Localidad"
        Me.Text = "Registrar_Localidad"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents button_cancel As System.Windows.Forms.Button
    Friend WithEvents button_save As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cmb_provincia As System.Windows.Forms.ComboBox
    Friend WithEvents txt_nombre As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
