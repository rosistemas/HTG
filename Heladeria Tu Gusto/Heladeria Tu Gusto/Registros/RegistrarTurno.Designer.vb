﻿Imports System.ComponentModel
Imports Heladeria_Tu_Gusto.My.Resources
Imports Microsoft.VisualBasic.CompilerServices

<DesignerGenerated()> _
Partial Class RegistrarTurno

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RegistrarTurno))
        Me.cmb_turno = New System.Windows.Forms.ComboBox()
        Me.lbl_turno = New System.Windows.Forms.Label()
        Me.grp_detalle = New System.Windows.Forms.GroupBox()
        Me.lbl_display_segundo_ayudante = New System.Windows.Forms.Label()
        Me.lbl_display_primer_ayudante = New System.Windows.Forms.Label()
        Me.lbl_display_supervisor = New System.Windows.Forms.Label()
        Me.lbl_segundo_ayudante = New System.Windows.Forms.Label()
        Me.lbl_primer_ayudante = New System.Windows.Forms.Label()
        Me.lbl_supervisor = New System.Windows.Forms.Label()
        Me.cmb_segundo_ayudante = New System.Windows.Forms.ComboBox()
        Me.cmb_primer_ayudante = New System.Windows.Forms.ComboBox()
        Me.cmb_supervisor = New System.Windows.Forms.ComboBox()
        Me.date_fecha = New System.Windows.Forms.DateTimePicker()
        Me.lbl_fecha = New System.Windows.Forms.Label()
        Me.lbl_cancelar = New System.Windows.Forms.Label()
        Me.lbl_guardar = New System.Windows.Forms.Label()
        Me.cmd_cancelar = New System.Windows.Forms.Button()
        Me.cmd_guardar = New System.Windows.Forms.Button()
        Me.chk_un_ayudante = New System.Windows.Forms.CheckBox()
        Me.grp_detalle.SuspendLayout
        Me.SuspendLayout
        '
        'cmb_turno
        '
        Me.cmb_turno.FormattingEnabled = true
        Me.cmb_turno.Location = New System.Drawing.Point(68, 6)
        Me.cmb_turno.Name = "cmb_turno"
        Me.cmb_turno.Size = New System.Drawing.Size(77, 21)
        Me.cmb_turno.TabIndex = 0
        '
        'lbl_turno
        '
        Me.lbl_turno.AutoSize = true
        Me.lbl_turno.Location = New System.Drawing.Point(24, 9)
        Me.lbl_turno.Name = "lbl_turno"
        Me.lbl_turno.Size = New System.Drawing.Size(38, 13)
        Me.lbl_turno.TabIndex = 1
        Me.lbl_turno.Text = "Turno:"
        '
        'grp_detalle
        '
        Me.grp_detalle.Controls.Add(Me.lbl_display_segundo_ayudante)
        Me.grp_detalle.Controls.Add(Me.lbl_display_primer_ayudante)
        Me.grp_detalle.Controls.Add(Me.lbl_display_supervisor)
        Me.grp_detalle.Controls.Add(Me.lbl_segundo_ayudante)
        Me.grp_detalle.Controls.Add(Me.lbl_primer_ayudante)
        Me.grp_detalle.Controls.Add(Me.lbl_supervisor)
        Me.grp_detalle.Controls.Add(Me.cmb_segundo_ayudante)
        Me.grp_detalle.Controls.Add(Me.cmb_primer_ayudante)
        Me.grp_detalle.Controls.Add(Me.cmb_supervisor)
        Me.grp_detalle.ForeColor = System.Drawing.Color.Navy
        Me.grp_detalle.Location = New System.Drawing.Point(13, 114)
        Me.grp_detalle.Name = "grp_detalle"
        Me.grp_detalle.Size = New System.Drawing.Size(335, 167)
        Me.grp_detalle.TabIndex = 2
        Me.grp_detalle.TabStop = false
        Me.grp_detalle.Text = "Detalle de Turno"
        '
        'lbl_display_segundo_ayudante
        '
        Me.lbl_display_segundo_ayudante.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.lbl_display_segundo_ayudante.Font = New System.Drawing.Font("Microsoft Sans Serif", 9!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.lbl_display_segundo_ayudante.ForeColor = System.Drawing.Color.Black
        Me.lbl_display_segundo_ayudante.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lbl_display_segundo_ayudante.Location = New System.Drawing.Point(172, 131)
        Me.lbl_display_segundo_ayudante.Name = "lbl_display_segundo_ayudante"
        Me.lbl_display_segundo_ayudante.Size = New System.Drawing.Size(149, 21)
        Me.lbl_display_segundo_ayudante.TabIndex = 21
        Me.lbl_display_segundo_ayudante.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl_display_primer_ayudante
        '
        Me.lbl_display_primer_ayudante.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.lbl_display_primer_ayudante.Font = New System.Drawing.Font("Microsoft Sans Serif", 9!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.lbl_display_primer_ayudante.ForeColor = System.Drawing.Color.Black
        Me.lbl_display_primer_ayudante.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lbl_display_primer_ayudante.Location = New System.Drawing.Point(172, 88)
        Me.lbl_display_primer_ayudante.Name = "lbl_display_primer_ayudante"
        Me.lbl_display_primer_ayudante.Size = New System.Drawing.Size(149, 21)
        Me.lbl_display_primer_ayudante.TabIndex = 21
        Me.lbl_display_primer_ayudante.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl_display_supervisor
        '
        Me.lbl_display_supervisor.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.lbl_display_supervisor.Font = New System.Drawing.Font("Microsoft Sans Serif", 9!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.lbl_display_supervisor.ForeColor = System.Drawing.Color.Black
        Me.lbl_display_supervisor.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lbl_display_supervisor.Location = New System.Drawing.Point(172, 40)
        Me.lbl_display_supervisor.Name = "lbl_display_supervisor"
        Me.lbl_display_supervisor.Size = New System.Drawing.Size(149, 21)
        Me.lbl_display_supervisor.TabIndex = 21
        Me.lbl_display_supervisor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl_segundo_ayudante
        '
        Me.lbl_segundo_ayudante.AutoSize = true
        Me.lbl_segundo_ayudante.ForeColor = System.Drawing.Color.Black
        Me.lbl_segundo_ayudante.Location = New System.Drawing.Point(4, 136)
        Me.lbl_segundo_ayudante.Name = "lbl_segundo_ayudante"
        Me.lbl_segundo_ayudante.Size = New System.Drawing.Size(100, 13)
        Me.lbl_segundo_ayudante.TabIndex = 1
        Me.lbl_segundo_ayudante.Text = "Segundo ayudante:"
        '
        'lbl_primer_ayudante
        '
        Me.lbl_primer_ayudante.AutoSize = true
        Me.lbl_primer_ayudante.ForeColor = System.Drawing.Color.Black
        Me.lbl_primer_ayudante.Location = New System.Drawing.Point(18, 93)
        Me.lbl_primer_ayudante.Name = "lbl_primer_ayudante"
        Me.lbl_primer_ayudante.Size = New System.Drawing.Size(86, 13)
        Me.lbl_primer_ayudante.TabIndex = 1
        Me.lbl_primer_ayudante.Text = "Primer ayudante:"
        '
        'lbl_supervisor
        '
        Me.lbl_supervisor.AutoSize = true
        Me.lbl_supervisor.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.lbl_supervisor.ForeColor = System.Drawing.Color.Black
        Me.lbl_supervisor.Location = New System.Drawing.Point(33, 45)
        Me.lbl_supervisor.Name = "lbl_supervisor"
        Me.lbl_supervisor.Size = New System.Drawing.Size(71, 13)
        Me.lbl_supervisor.TabIndex = 1
        Me.lbl_supervisor.Text = "Supervisor:"
        '
        'cmb_segundo_ayudante
        '
        Me.cmb_segundo_ayudante.FormattingEnabled = true
        Me.cmb_segundo_ayudante.Location = New System.Drawing.Point(110, 133)
        Me.cmb_segundo_ayudante.Name = "cmb_segundo_ayudante"
        Me.cmb_segundo_ayudante.Size = New System.Drawing.Size(56, 21)
        Me.cmb_segundo_ayudante.TabIndex = 0
        '
        'cmb_primer_ayudante
        '
        Me.cmb_primer_ayudante.FormattingEnabled = true
        Me.cmb_primer_ayudante.Location = New System.Drawing.Point(110, 90)
        Me.cmb_primer_ayudante.Name = "cmb_primer_ayudante"
        Me.cmb_primer_ayudante.Size = New System.Drawing.Size(56, 21)
        Me.cmb_primer_ayudante.TabIndex = 0
        '
        'cmb_supervisor
        '
        Me.cmb_supervisor.FormattingEnabled = true
        Me.cmb_supervisor.Location = New System.Drawing.Point(110, 42)
        Me.cmb_supervisor.Name = "cmb_supervisor"
        Me.cmb_supervisor.Size = New System.Drawing.Size(56, 21)
        Me.cmb_supervisor.TabIndex = 0
        '
        'date_fecha
        '
        Me.date_fecha.Location = New System.Drawing.Point(66, 42)
        Me.date_fecha.Name = "date_fecha"
        Me.date_fecha.Size = New System.Drawing.Size(200, 20)
        Me.date_fecha.TabIndex = 3
        '
        'lbl_fecha
        '
        Me.lbl_fecha.AutoSize = true
        Me.lbl_fecha.Location = New System.Drawing.Point(22, 48)
        Me.lbl_fecha.Name = "lbl_fecha"
        Me.lbl_fecha.Size = New System.Drawing.Size(40, 13)
        Me.lbl_fecha.TabIndex = 1
        Me.lbl_fecha.Text = "Fecha:"
        '
        'lbl_cancelar
        '
        Me.lbl_cancelar.AutoSize = true
        Me.lbl_cancelar.Location = New System.Drawing.Point(286, 290)
        Me.lbl_cancelar.Name = "lbl_cancelar"
        Me.lbl_cancelar.Size = New System.Drawing.Size(49, 13)
        Me.lbl_cancelar.TabIndex = 34
        Me.lbl_cancelar.Text = "Cancelar"
        '
        'lbl_guardar
        '
        Me.lbl_guardar.AutoSize = true
        Me.lbl_guardar.Location = New System.Drawing.Point(25, 289)
        Me.lbl_guardar.Name = "lbl_guardar"
        Me.lbl_guardar.Size = New System.Drawing.Size(45, 13)
        Me.lbl_guardar.TabIndex = 33
        Me.lbl_guardar.Text = "Guardar"
        '
        'cmd_cancelar
        '
        Me.cmd_cancelar.Image = Global.Heladeria_Tu_Gusto.My.Resources.Resources.icons8_Delete_40
        Me.cmd_cancelar.Location = New System.Drawing.Point(273, 306)
        Me.cmd_cancelar.Name = "cmd_cancelar"
        Me.cmd_cancelar.Size = New System.Drawing.Size(75, 46)
        Me.cmd_cancelar.TabIndex = 32
        Me.cmd_cancelar.UseVisualStyleBackColor = true
        '
        'cmd_guardar
        '
        Me.cmd_guardar.Image = Global.Heladeria_Tu_Gusto.My.Resources.Resources.icons8_Add_New_40
        Me.cmd_guardar.Location = New System.Drawing.Point(10, 305)
        Me.cmd_guardar.Name = "cmd_guardar"
        Me.cmd_guardar.Size = New System.Drawing.Size(75, 46)
        Me.cmd_guardar.TabIndex = 31
        Me.cmd_guardar.UseVisualStyleBackColor = true
        '
        'chk_un_ayudante
        '
        Me.chk_un_ayudante.AutoSize = true
        Me.chk_un_ayudante.ForeColor = System.Drawing.Color.Black
        Me.chk_un_ayudante.Location = New System.Drawing.Point(237, 91)
        Me.chk_un_ayudante.Name = "chk_un_ayudante"
        Me.chk_un_ayudante.Size = New System.Drawing.Size(109, 17)
        Me.chk_un_ayudante.TabIndex = 22
        Me.chk_un_ayudante.Text = "Un solo ayudante"
        Me.chk_un_ayudante.UseVisualStyleBackColor = true
        '
        'RegistrarTurno
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(359, 363)
        Me.Controls.Add(Me.chk_un_ayudante)
        Me.Controls.Add(Me.lbl_cancelar)
        Me.Controls.Add(Me.lbl_guardar)
        Me.Controls.Add(Me.cmd_cancelar)
        Me.Controls.Add(Me.cmd_guardar)
        Me.Controls.Add(Me.date_fecha)
        Me.Controls.Add(Me.grp_detalle)
        Me.Controls.Add(Me.lbl_fecha)
        Me.Controls.Add(Me.lbl_turno)
        Me.Controls.Add(Me.cmb_turno)
        Me.Icon = CType(resources.GetObject("$this.Icon"),System.Drawing.Icon)
        Me.Name = "RegistrarTurno"
        Me.Text = "Registrar Turno"
        Me.grp_detalle.ResumeLayout(false)
        Me.grp_detalle.PerformLayout
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub

    Friend WithEvents cmb_turno As ComboBox

    Friend WithEvents lbl_turno As Label

    Friend WithEvents grp_detalle As GroupBox

    Friend WithEvents lbl_supervisor As Label

    Friend WithEvents cmb_supervisor As ComboBox

    Friend WithEvents lbl_display_supervisor As Label

    Friend WithEvents lbl_display_segundo_ayudante As Label

    Friend WithEvents lbl_display_primer_ayudante As Label

    Friend WithEvents lbl_segundo_ayudante As Label

    Friend WithEvents lbl_primer_ayudante As Label

    Friend WithEvents cmb_segundo_ayudante As ComboBox

    Friend WithEvents cmb_primer_ayudante As ComboBox

    Friend WithEvents date_fecha As DateTimePicker

    Friend WithEvents lbl_fecha As Label

    Friend WithEvents lbl_cancelar As Label

    Friend WithEvents lbl_guardar As Label

    Friend WithEvents cmd_cancelar As Button

    Friend WithEvents cmd_guardar As Button

    Friend WithEvents chk_un_ayudante As CheckBox

End Class
