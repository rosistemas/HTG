<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Registrar_Barrio
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
        Me.components = New System.ComponentModel.Container()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txt_nombre = New System.Windows.Forms.TextBox()
        Me.button_cancel = New System.Windows.Forms.Button()
        Me.button_save = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmb_localidad = New System.Windows.Forms.ComboBox()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(61, 4)
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txt_nombre)
        Me.GroupBox1.Controls.Add(Me.button_cancel)
        Me.GroupBox1.Controls.Add(Me.button_save)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.cmb_localidad)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(260, 237)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Nuevo Barrio"
        '
        'txt_nombre
        '
        Me.txt_nombre.Location = New System.Drawing.Point(126, 39)
        Me.txt_nombre.Name = "txt_nombre"
        Me.txt_nombre.Size = New System.Drawing.Size(121, 20)
        Me.txt_nombre.TabIndex = 5
        '
        'button_cancel
        '
        Me.button_cancel.Image = Global.Heladeria_Tu_Gusto.My.Resources.Resources.icons8_Delete_40
        Me.button_cancel.Location = New System.Drawing.Point(147, 157)
        Me.button_cancel.Name = "button_cancel"
        Me.button_cancel.Size = New System.Drawing.Size(75, 62)
        Me.button_cancel.TabIndex = 4
        Me.button_cancel.UseVisualStyleBackColor = True
        '
        'button_save
        '
        Me.button_save.Image = Global.Heladeria_Tu_Gusto.My.Resources.Resources.icons8_Save_as_64
        Me.button_save.Location = New System.Drawing.Point(31, 157)
        Me.button_save.Name = "button_save"
        Me.button_save.Size = New System.Drawing.Size(75, 62)
        Me.button_save.TabIndex = 3
        Me.button_save.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(28, 87)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Localidad"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(28, 42)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Nombre"
        '
        'cmb_localidad
        '
        Me.cmb_localidad.FormattingEnabled = True
        Me.cmb_localidad.Location = New System.Drawing.Point(126, 79)
        Me.cmb_localidad.Name = "cmb_localidad"
        Me.cmb_localidad.Size = New System.Drawing.Size(121, 21)
        Me.cmb_localidad.TabIndex = 0
        '
        'Registrar_Barrio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Registrar_Barrio"
        Me.Text = "Registrar_Barrio"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txt_nombre As System.Windows.Forms.TextBox
    Friend WithEvents button_cancel As System.Windows.Forms.Button
    Friend WithEvents button_save As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmb_localidad As System.Windows.Forms.ComboBox
End Class
