Imports System.ComponentModel
Imports Microsoft.VisualBasic.CompilerServices

<DesignerGenerated()> _
Partial Class ModificarBarrio
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ModificarBarrio))
        Me.grd_datos = New System.Windows.Forms.GroupBox()
        Me.cmb_localidades = New System.Windows.Forms.ComboBox()
        Me.txt_nombre = New System.Windows.Forms.TextBox()
        Me.lbl_nombre_localidad = New System.Windows.Forms.Label()
        Me.lbl_nombre_barrio = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.grd_barrios = New System.Windows.Forms.DataGridView()
        Me.cmd_cancelar = New System.Windows.Forms.Button()
        Me.cmd_guardar = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lbl_guardar = New System.Windows.Forms.Label()
        Me.Id_barrio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nombre_barrio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.id_localidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nombre_localidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.grd_datos.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.grd_barrios, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grd_datos
        '
        Me.grd_datos.Controls.Add(Me.cmb_localidades)
        Me.grd_datos.Controls.Add(Me.txt_nombre)
        Me.grd_datos.Controls.Add(Me.lbl_nombre_localidad)
        Me.grd_datos.Controls.Add(Me.lbl_nombre_barrio)
        Me.grd_datos.Location = New System.Drawing.Point(3, 163)
        Me.grd_datos.Name = "grd_datos"
        Me.grd_datos.Size = New System.Drawing.Size(285, 76)
        Me.grd_datos.TabIndex = 6
        Me.grd_datos.TabStop = False
        Me.grd_datos.Text = "DatosBarrio"
        '
        'cmb_localidades
        '
        Me.cmb_localidades.FormattingEnabled = True
        Me.cmb_localidades.Location = New System.Drawing.Point(128, 19)
        Me.cmb_localidades.Name = "cmb_localidades"
        Me.cmb_localidades.Size = New System.Drawing.Size(143, 21)
        Me.cmb_localidades.TabIndex = 7
        '
        'txt_nombre
        '
        Me.txt_nombre.Location = New System.Drawing.Point(128, 48)
        Me.txt_nombre.Name = "txt_nombre"
        Me.txt_nombre.Size = New System.Drawing.Size(143, 20)
        Me.txt_nombre.TabIndex = 6
        '
        'lbl_nombre_localidad
        '
        Me.lbl_nombre_localidad.AutoSize = True
        Me.lbl_nombre_localidad.Location = New System.Drawing.Point(36, 22)
        Me.lbl_nombre_localidad.Name = "lbl_nombre_localidad"
        Me.lbl_nombre_localidad.Size = New System.Drawing.Size(56, 13)
        Me.lbl_nombre_localidad.TabIndex = 3
        Me.lbl_nombre_localidad.Text = "Localidad:"
        '
        'lbl_nombre_barrio
        '
        Me.lbl_nombre_barrio.AutoSize = True
        Me.lbl_nombre_barrio.Location = New System.Drawing.Point(12, 51)
        Me.lbl_nombre_barrio.Name = "lbl_nombre_barrio"
        Me.lbl_nombre_barrio.Size = New System.Drawing.Size(80, 13)
        Me.lbl_nombre_barrio.TabIndex = 4
        Me.lbl_nombre_barrio.Text = "Nuevo nombre:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.grd_barrios)
        Me.GroupBox1.Location = New System.Drawing.Point(3, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(285, 145)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Seleccionar Barrio"
        '
        'grd_barrios
        '
        Me.grd_barrios.AllowUserToAddRows = False
        Me.grd_barrios.AllowUserToDeleteRows = False
        Me.grd_barrios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grd_barrios.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Id_barrio, Me.nombre_barrio, Me.id_localidad, Me.nombre_localidad})
        Me.grd_barrios.Location = New System.Drawing.Point(17, 19)
        Me.grd_barrios.Name = "grd_barrios"
        Me.grd_barrios.ReadOnly = True
        Me.grd_barrios.Size = New System.Drawing.Size(254, 96)
        Me.grd_barrios.TabIndex = 7
        '
        'cmd_cancelar
        '
        Me.cmd_cancelar.Image = Global.Heladeria_Tu_Gusto.My.Resources.Resources.icons8_Delete_40
        Me.cmd_cancelar.Location = New System.Drawing.Point(214, 258)
        Me.cmd_cancelar.Name = "cmd_cancelar"
        Me.cmd_cancelar.Size = New System.Drawing.Size(70, 70)
        Me.cmd_cancelar.TabIndex = 4
        Me.cmd_cancelar.UseVisualStyleBackColor = True
        '
        'cmd_guardar
        '
        Me.cmd_guardar.Image = Global.Heladeria_Tu_Gusto.My.Resources.Resources.icons8_Save_as_64
        Me.cmd_guardar.Location = New System.Drawing.Point(3, 258)
        Me.cmd_guardar.Name = "cmd_guardar"
        Me.cmd_guardar.Size = New System.Drawing.Size(70, 70)
        Me.cmd_guardar.TabIndex = 3
        Me.cmd_guardar.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(225, 242)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(49, 13)
        Me.Label1.TabIndex = 29
        Me.Label1.Text = "Cancelar"
        '
        'lbl_guardar
        '
        Me.lbl_guardar.AutoSize = True
        Me.lbl_guardar.Location = New System.Drawing.Point(0, 242)
        Me.lbl_guardar.Name = "lbl_guardar"
        Me.lbl_guardar.Size = New System.Drawing.Size(87, 13)
        Me.lbl_guardar.TabIndex = 28
        Me.lbl_guardar.Text = "Guardar cambios"
        '
        'Id_barrio
        '
        Me.Id_barrio.HeaderText = "ID Barrio"
        Me.Id_barrio.Name = "Id_barrio"
        Me.Id_barrio.ReadOnly = True
        Me.Id_barrio.Visible = False
        '
        'nombre_barrio
        '
        Me.nombre_barrio.HeaderText = "Barrio"
        Me.nombre_barrio.Name = "nombre_barrio"
        Me.nombre_barrio.ReadOnly = True
        Me.nombre_barrio.Width = 105
        '
        'id_localidad
        '
        Me.id_localidad.HeaderText = "ID Localidad"
        Me.id_localidad.Name = "id_localidad"
        Me.id_localidad.ReadOnly = True
        Me.id_localidad.Visible = False
        '
        'nombre_localidad
        '
        Me.nombre_localidad.HeaderText = "Localidad"
        Me.nombre_localidad.Name = "nombre_localidad"
        Me.nombre_localidad.ReadOnly = True
        Me.nombre_localidad.Width = 105
        '
        'ModificarBarrio
        '
        Me.ClientSize = New System.Drawing.Size(296, 336)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lbl_guardar)
        Me.Controls.Add(Me.grd_datos)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.cmd_cancelar)
        Me.Controls.Add(Me.cmd_guardar)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "ModificarBarrio"
        Me.Text = "ModificarBarrio"
        Me.grd_datos.ResumeLayout(False)
        Me.grd_datos.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.grd_barrios, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmd_cancelar As Button
    Friend WithEvents cmd_guardar As Button
    Friend WithEvents grd_datos As GroupBox
    Friend WithEvents cmb_localidades As ComboBox
    Friend WithEvents txt_nombre As TextBox
    Friend WithEvents lbl_nombre_localidad As Label
    Friend WithEvents lbl_nombre_barrio As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents grd_barrios As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents lbl_guardar As Label
    Friend WithEvents Id_barrio As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents nombre_barrio As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents id_localidad As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents nombre_localidad As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
