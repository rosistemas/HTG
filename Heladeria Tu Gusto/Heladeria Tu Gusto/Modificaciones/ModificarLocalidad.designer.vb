﻿Imports System.ComponentModel
Imports Microsoft.VisualBasic.CompilerServices

<DesignerGenerated()> _
Partial Class ModificarLocalidad
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ModificarLocalidad))
        Me.cmd_guardar = New System.Windows.Forms.Button()
        Me.cmd_cancelar = New System.Windows.Forms.Button()
        Me.lbl_cancelar = New System.Windows.Forms.Label()
        Me.lbl_guardar = New System.Windows.Forms.Label()
        Me.grp_datos_localidad = New System.Windows.Forms.GroupBox()
        Me.cmb_provincias = New System.Windows.Forms.ComboBox()
        Me.txt_nombre_localidad = New System.Windows.Forms.TextBox()
        Me.lbl_provincias = New System.Windows.Forms.Label()
        Me.lbl_nuevo_nombre = New System.Windows.Forms.Label()
        Me.grp_localidades = New System.Windows.Forms.GroupBox()
        Me.grd_Localidad = New System.Windows.Forms.DataGridView()
        Me.Id_localidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nombre_localidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nombre_provincia = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.id_provincia = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.grp_datos_localidad.SuspendLayout()
        Me.grp_localidades.SuspendLayout()
        CType(Me.grd_Localidad, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmd_guardar
        '
        Me.cmd_guardar.Image = Global.Heladeria_Tu_Gusto.My.Resources.Resources.icons8_Save_as_64
        Me.cmd_guardar.Location = New System.Drawing.Point(396, 137)
        Me.cmd_guardar.Name = "cmd_guardar"
        Me.cmd_guardar.Size = New System.Drawing.Size(70, 70)
        Me.cmd_guardar.TabIndex = 3
        Me.cmd_guardar.UseVisualStyleBackColor = True
        '
        'cmd_cancelar
        '
        Me.cmd_cancelar.Image = Global.Heladeria_Tu_Gusto.My.Resources.Resources.icons8_Delete_40
        Me.cmd_cancelar.Location = New System.Drawing.Point(572, 137)
        Me.cmd_cancelar.Name = "cmd_cancelar"
        Me.cmd_cancelar.Size = New System.Drawing.Size(70, 70)
        Me.cmd_cancelar.TabIndex = 4
        Me.cmd_cancelar.UseVisualStyleBackColor = True
        '
        'lbl_cancelar
        '
        Me.lbl_cancelar.AutoSize = True
        Me.lbl_cancelar.Location = New System.Drawing.Point(585, 121)
        Me.lbl_cancelar.Name = "lbl_cancelar"
        Me.lbl_cancelar.Size = New System.Drawing.Size(49, 13)
        Me.lbl_cancelar.TabIndex = 22
        Me.lbl_cancelar.Text = "Cancelar"
        '
        'lbl_guardar
        '
        Me.lbl_guardar.AutoSize = True
        Me.lbl_guardar.Location = New System.Drawing.Point(390, 121)
        Me.lbl_guardar.Name = "lbl_guardar"
        Me.lbl_guardar.Size = New System.Drawing.Size(87, 13)
        Me.lbl_guardar.TabIndex = 21
        Me.lbl_guardar.Text = "Guardar cambios"
        '
        'grp_datos_localidad
        '
        Me.grp_datos_localidad.Controls.Add(Me.cmb_provincias)
        Me.grp_datos_localidad.Controls.Add(Me.txt_nombre_localidad)
        Me.grp_datos_localidad.Controls.Add(Me.lbl_provincias)
        Me.grp_datos_localidad.Controls.Add(Me.lbl_nuevo_nombre)
        Me.grp_datos_localidad.Location = New System.Drawing.Point(379, 9)
        Me.grp_datos_localidad.Name = "grp_datos_localidad"
        Me.grp_datos_localidad.Size = New System.Drawing.Size(268, 76)
        Me.grp_datos_localidad.TabIndex = 24
        Me.grp_datos_localidad.TabStop = False
        Me.grp_datos_localidad.Text = "DatosLocalidad"
        '
        'cmb_provincias
        '
        Me.cmb_provincias.FormattingEnabled = True
        Me.cmb_provincias.Location = New System.Drawing.Point(100, 18)
        Me.cmb_provincias.Name = "cmb_provincias"
        Me.cmb_provincias.Size = New System.Drawing.Size(150, 21)
        Me.cmb_provincias.TabIndex = 7
        '
        'txt_nombre_localidad
        '
        Me.txt_nombre_localidad.Location = New System.Drawing.Point(100, 45)
        Me.txt_nombre_localidad.Name = "txt_nombre_localidad"
        Me.txt_nombre_localidad.Size = New System.Drawing.Size(150, 20)
        Me.txt_nombre_localidad.TabIndex = 6
        '
        'lbl_provincias
        '
        Me.lbl_provincias.AutoSize = True
        Me.lbl_provincias.Location = New System.Drawing.Point(40, 21)
        Me.lbl_provincias.Name = "lbl_provincias"
        Me.lbl_provincias.Size = New System.Drawing.Size(54, 13)
        Me.lbl_provincias.TabIndex = 3
        Me.lbl_provincias.Text = "Provincia:"
        '
        'lbl_nuevo_nombre
        '
        Me.lbl_nuevo_nombre.AutoSize = True
        Me.lbl_nuevo_nombre.Location = New System.Drawing.Point(14, 48)
        Me.lbl_nuevo_nombre.Name = "lbl_nuevo_nombre"
        Me.lbl_nuevo_nombre.Size = New System.Drawing.Size(80, 13)
        Me.lbl_nuevo_nombre.TabIndex = 4
        Me.lbl_nuevo_nombre.Text = "Nuevo nombre:"
        '
        'grp_localidades
        '
        Me.grp_localidades.Controls.Add(Me.grd_Localidad)
        Me.grp_localidades.Location = New System.Drawing.Point(12, 9)
        Me.grp_localidades.Name = "grp_localidades"
        Me.grp_localidades.Size = New System.Drawing.Size(361, 195)
        Me.grp_localidades.TabIndex = 23
        Me.grp_localidades.TabStop = False
        Me.grp_localidades.Text = "Seleccionar Localidad"
        '
        'grd_Localidad
        '
        Me.grd_Localidad.AllowUserToAddRows = False
        Me.grd_Localidad.AllowUserToDeleteRows = False
        Me.grd_Localidad.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grd_Localidad.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Id_localidad, Me.nombre_localidad, Me.nombre_provincia, Me.id_provincia})
        Me.grd_Localidad.Location = New System.Drawing.Point(6, 18)
        Me.grd_Localidad.Name = "grd_Localidad"
        Me.grd_Localidad.ReadOnly = True
        Me.grd_Localidad.Size = New System.Drawing.Size(348, 171)
        Me.grd_Localidad.TabIndex = 7
        '
        'Id_localidad
        '
        Me.Id_localidad.HeaderText = "ID LOCALIDAD"
        Me.Id_localidad.Name = "Id_localidad"
        Me.Id_localidad.ReadOnly = True
        Me.Id_localidad.Visible = False
        '
        'nombre_localidad
        '
        Me.nombre_localidad.HeaderText = "Localidad"
        Me.nombre_localidad.Name = "nombre_localidad"
        Me.nombre_localidad.ReadOnly = True
        Me.nombre_localidad.Width = 150
        '
        'nombre_provincia
        '
        Me.nombre_provincia.HeaderText = "Provincia"
        Me.nombre_provincia.Name = "nombre_provincia"
        Me.nombre_provincia.ReadOnly = True
        Me.nombre_provincia.Width = 150
        '
        'id_provincia
        '
        Me.id_provincia.HeaderText = "Id Provincia"
        Me.id_provincia.Name = "id_provincia"
        Me.id_provincia.ReadOnly = True
        Me.id_provincia.Visible = False
        '
        'ModificarLocalidad
        '
        Me.ClientSize = New System.Drawing.Size(659, 212)
        Me.Controls.Add(Me.grp_datos_localidad)
        Me.Controls.Add(Me.grp_localidades)
        Me.Controls.Add(Me.lbl_cancelar)
        Me.Controls.Add(Me.lbl_guardar)
        Me.Controls.Add(Me.cmd_cancelar)
        Me.Controls.Add(Me.cmd_guardar)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "ModificarLocalidad"
        Me.Text = "Modificar localidad"
        Me.grp_datos_localidad.ResumeLayout(False)
        Me.grp_datos_localidad.PerformLayout()
        Me.grp_localidades.ResumeLayout(False)
        CType(Me.grd_Localidad, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmd_guardar As Button
    Friend WithEvents cmd_cancelar As Button
    Friend WithEvents lbl_cancelar As Label
    Friend WithEvents lbl_guardar As Label
    Friend WithEvents grp_datos_localidad As GroupBox
    Friend WithEvents cmb_provincias As ComboBox
    Friend WithEvents txt_nombre_localidad As TextBox
    Friend WithEvents lbl_provincias As Label
    Friend WithEvents lbl_nuevo_nombre As Label
    Friend WithEvents grp_localidades As GroupBox
    Friend WithEvents grd_Localidad As DataGridView
    Friend WithEvents Id_localidad As DataGridViewTextBoxColumn
    Friend WithEvents nombre_localidad As DataGridViewTextBoxColumn
    Friend WithEvents nombre_provincia As DataGridViewTextBoxColumn
    Friend WithEvents id_provincia As DataGridViewTextBoxColumn
End Class
