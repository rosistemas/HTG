<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ABM_PERSONAS
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
        Me.lblApellido = New System.Windows.Forms.Label()
        Me.lblNombre = New System.Windows.Forms.Label()
        Me.lblTipoDocumento = New System.Windows.Forms.Label()
        Me.lblDocumento = New System.Windows.Forms.Label()
        Me.lblEstadoCivil = New System.Windows.Forms.Label()
        Me.lblSexo = New System.Windows.Forms.Label()
        Me.txtApellido = New System.Windows.Forms.TextBox()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.cmbDocumento = New System.Windows.Forms.ComboBox()
        Me.cmbEstadoCivil = New System.Windows.Forms.ComboBox()
        Me.txtSexo = New System.Windows.Forms.MaskedTextBox()
        Me.txtDocumento = New System.Windows.Forms.MaskedTextBox()
        Me.gridABM = New System.Windows.Forms.DataGridView()
        Me.col_surname = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_Name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_docType = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_docNumber = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_idDocType = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.lblContador = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.chk_Eliminar = New System.Windows.Forms.CheckBox()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.btnNuevo = New System.Windows.Forms.Button()
        CType(Me.gridABM, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblApellido
        '
        Me.lblApellido.AutoSize = True
        Me.lblApellido.Location = New System.Drawing.Point(63, 45)
        Me.lblApellido.Name = "lblApellido"
        Me.lblApellido.Size = New System.Drawing.Size(44, 13)
        Me.lblApellido.TabIndex = 0
        Me.lblApellido.Text = "Apellido"
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.Location = New System.Drawing.Point(63, 15)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(44, 13)
        Me.lblNombre.TabIndex = 1
        Me.lblNombre.Text = "Nombre"
        '
        'lblTipoDocumento
        '
        Me.lblTipoDocumento.AutoSize = True
        Me.lblTipoDocumento.Location = New System.Drawing.Point(22, 78)
        Me.lblTipoDocumento.Name = "lblTipoDocumento"
        Me.lblTipoDocumento.Size = New System.Drawing.Size(86, 13)
        Me.lblTipoDocumento.TabIndex = 2
        Me.lblTipoDocumento.Text = "Tipo Documento"
        '
        'lblDocumento
        '
        Me.lblDocumento.AutoSize = True
        Me.lblDocumento.Location = New System.Drawing.Point(46, 105)
        Me.lblDocumento.Name = "lblDocumento"
        Me.lblDocumento.Size = New System.Drawing.Size(62, 13)
        Me.lblDocumento.TabIndex = 3
        Me.lblDocumento.Text = "Documento"
        '
        'lblEstadoCivil
        '
        Me.lblEstadoCivil.AutoSize = True
        Me.lblEstadoCivil.Location = New System.Drawing.Point(46, 157)
        Me.lblEstadoCivil.Name = "lblEstadoCivil"
        Me.lblEstadoCivil.Size = New System.Drawing.Size(62, 13)
        Me.lblEstadoCivil.TabIndex = 4
        Me.lblEstadoCivil.Text = "Estado Civil"
        '
        'lblSexo
        '
        Me.lblSexo.AutoSize = True
        Me.lblSexo.Location = New System.Drawing.Point(77, 131)
        Me.lblSexo.Name = "lblSexo"
        Me.lblSexo.Size = New System.Drawing.Size(31, 13)
        Me.lblSexo.TabIndex = 5
        Me.lblSexo.Text = "Sexo"
        '
        'txtApellido
        '
        Me.txtApellido.Location = New System.Drawing.Point(117, 42)
        Me.txtApellido.Name = "txtApellido"
        Me.txtApellido.Size = New System.Drawing.Size(349, 20)
        Me.txtApellido.TabIndex = 1
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(117, 12)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(349, 20)
        Me.txtNombre.TabIndex = 0
        '
        'cmbDocumento
        '
        Me.cmbDocumento.FormattingEnabled = True
        Me.cmbDocumento.Location = New System.Drawing.Point(118, 75)
        Me.cmbDocumento.Name = "cmbDocumento"
        Me.cmbDocumento.Size = New System.Drawing.Size(121, 21)
        Me.cmbDocumento.TabIndex = 2
        '
        'cmbEstadoCivil
        '
        Me.cmbEstadoCivil.FormattingEnabled = True
        Me.cmbEstadoCivil.Location = New System.Drawing.Point(118, 154)
        Me.cmbEstadoCivil.Name = "cmbEstadoCivil"
        Me.cmbEstadoCivil.Size = New System.Drawing.Size(121, 21)
        Me.cmbEstadoCivil.TabIndex = 5
        '
        'txtSexo
        '
        Me.txtSexo.Location = New System.Drawing.Point(118, 128)
        Me.txtSexo.Mask = "L"
        Me.txtSexo.Name = "txtSexo"
        Me.txtSexo.Size = New System.Drawing.Size(19, 20)
        Me.txtSexo.TabIndex = 4
        '
        'txtDocumento
        '
        Me.txtDocumento.Location = New System.Drawing.Point(118, 102)
        Me.txtDocumento.Mask = "99999999"
        Me.txtDocumento.Name = "txtDocumento"
        Me.txtDocumento.Size = New System.Drawing.Size(56, 20)
        Me.txtDocumento.TabIndex = 3
        '
        'gridABM
        '
        Me.gridABM.AllowUserToAddRows = False
        Me.gridABM.AllowUserToDeleteRows = False
        Me.gridABM.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.gridABM.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.col_surname, Me.col_Name, Me.col_docType, Me.col_docNumber, Me.col_idDocType})
        Me.gridABM.Location = New System.Drawing.Point(25, 181)
        Me.gridABM.Name = "gridABM"
        Me.gridABM.ReadOnly = True
        Me.gridABM.Size = New System.Drawing.Size(444, 199)
        Me.gridABM.TabIndex = 6
        '
        'col_surname
        '
        Me.col_surname.HeaderText = "Apellido"
        Me.col_surname.Name = "col_surname"
        Me.col_surname.ReadOnly = True
        '
        'col_Name
        '
        Me.col_Name.HeaderText = "Nombre"
        Me.col_Name.Name = "col_Name"
        Me.col_Name.ReadOnly = True
        '
        'col_docType
        '
        Me.col_docType.HeaderText = "Tipo Documento"
        Me.col_docType.Name = "col_docType"
        Me.col_docType.ReadOnly = True
        '
        'col_docNumber
        '
        Me.col_docNumber.HeaderText = "Documento"
        Me.col_docNumber.Name = "col_docNumber"
        Me.col_docNumber.ReadOnly = True
        '
        'col_idDocType
        '
        Me.col_idDocType.HeaderText = "idTipoDocumento"
        Me.col_idDocType.Name = "col_idDocType"
        Me.col_idDocType.ReadOnly = True
        Me.col_idDocType.Visible = False
        '
        'btnEliminar
        '
        Me.btnEliminar.Location = New System.Drawing.Point(164, 387)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(75, 39)
        Me.btnEliminar.TabIndex = 11
        Me.btnEliminar.Text = "Eliminar"
        Me.btnEliminar.UseVisualStyleBackColor = True
        '
        'lblContador
        '
        Me.lblContador.AutoSize = True
        Me.lblContador.Location = New System.Drawing.Point(435, 128)
        Me.lblContador.Name = "lblContador"
        Me.lblContador.Size = New System.Drawing.Size(13, 13)
        Me.lblContador.TabIndex = 13
        Me.lblContador.Text = "0"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'chk_Eliminar
        '
        Me.chk_Eliminar.AutoSize = True
        Me.chk_Eliminar.Location = New System.Drawing.Point(385, 156)
        Me.chk_Eliminar.Name = "chk_Eliminar"
        Me.chk_Eliminar.Size = New System.Drawing.Size(74, 17)
        Me.chk_Eliminar.TabIndex = 12
        Me.chk_Eliminar.Text = "¿Eliminar?"
        Me.chk_Eliminar.UseVisualStyleBackColor = True
        '
        'btnBuscar
        '
        Me.btnBuscar.Image = Global.abm_alumnos.My.Resources.Resources.BUSCAR01
        Me.btnBuscar.Location = New System.Drawing.Point(117, 387)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(40, 40)
        Me.btnBuscar.TabIndex = 9
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'btnSalir
        '
        Me.btnSalir.Image = Global.abm_alumnos.My.Resources.Resources.puerta
        Me.btnSalir.Location = New System.Drawing.Point(429, 387)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(40, 40)
        Me.btnSalir.TabIndex = 10
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'btnGuardar
        '
        Me.btnGuardar.Image = Global.abm_alumnos.My.Resources.Resources.Grabar2
        Me.btnGuardar.Location = New System.Drawing.Point(71, 387)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(40, 40)
        Me.btnGuardar.TabIndex = 8
        Me.btnGuardar.UseVisualStyleBackColor = True
        '
        'btnNuevo
        '
        Me.btnNuevo.Image = Global.abm_alumnos.My.Resources.Resources.Nuevo2
        Me.btnNuevo.Location = New System.Drawing.Point(25, 386)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(40, 40)
        Me.btnNuevo.TabIndex = 7
        Me.btnNuevo.UseVisualStyleBackColor = True
        '
        'ABM_PERSONAS
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(479, 439)
        Me.Controls.Add(Me.lblContador)
        Me.Controls.Add(Me.chk_Eliminar)
        Me.Controls.Add(Me.btnEliminar)
        Me.Controls.Add(Me.gridABM)
        Me.Controls.Add(Me.btnBuscar)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.btnNuevo)
        Me.Controls.Add(Me.txtDocumento)
        Me.Controls.Add(Me.txtSexo)
        Me.Controls.Add(Me.cmbEstadoCivil)
        Me.Controls.Add(Me.cmbDocumento)
        Me.Controls.Add(Me.txtNombre)
        Me.Controls.Add(Me.txtApellido)
        Me.Controls.Add(Me.lblSexo)
        Me.Controls.Add(Me.lblEstadoCivil)
        Me.Controls.Add(Me.lblDocumento)
        Me.Controls.Add(Me.lblTipoDocumento)
        Me.Controls.Add(Me.lblNombre)
        Me.Controls.Add(Me.lblApellido)
        Me.Name = "ABM_PERSONAS"
        Me.Text = "ABM Personas"
        CType(Me.gridABM, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblApellido As System.Windows.Forms.Label
    Friend WithEvents lblNombre As System.Windows.Forms.Label
    Friend WithEvents lblTipoDocumento As System.Windows.Forms.Label
    Friend WithEvents lblDocumento As System.Windows.Forms.Label
    Friend WithEvents lblEstadoCivil As System.Windows.Forms.Label
    Friend WithEvents lblSexo As System.Windows.Forms.Label
    Friend WithEvents txtApellido As System.Windows.Forms.TextBox
    Friend WithEvents txtNombre As System.Windows.Forms.TextBox
    Friend WithEvents cmbDocumento As System.Windows.Forms.ComboBox
    Friend WithEvents cmbEstadoCivil As System.Windows.Forms.ComboBox
    Friend WithEvents txtSexo As System.Windows.Forms.MaskedTextBox
    Friend WithEvents txtDocumento As System.Windows.Forms.MaskedTextBox
    Friend WithEvents btnNuevo As System.Windows.Forms.Button
    Friend WithEvents btnGuardar As System.Windows.Forms.Button
    Friend WithEvents btnSalir As System.Windows.Forms.Button
    Friend WithEvents btnBuscar As System.Windows.Forms.Button
    Friend WithEvents gridABM As System.Windows.Forms.DataGridView
    Friend WithEvents col_surname As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents col_Name As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents col_docType As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents col_docNumber As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents col_idDocType As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents btnEliminar As System.Windows.Forms.Button
    Friend WithEvents chk_Eliminar As System.Windows.Forms.CheckBox
    Friend WithEvents lblContador As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer

End Class
