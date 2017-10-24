<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class VentasPorEmpleado
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.bs_ventas_por_empleado = New System.Windows.Forms.BindingSource(Me.components)
        Me.cmd_calcular = New System.Windows.Forms.Button()
        Me.date_hasta = New System.Windows.Forms.DateTimePicker()
        Me.date_desde = New System.Windows.Forms.DateTimePicker()
        Me.lbl_fecha_hasta = New System.Windows.Forms.Label()
        Me.lbl_fecha_desde = New System.Windows.Forms.Label()
        Me.rv_ventas_por_empleado = New Microsoft.Reporting.WinForms.ReportViewer()
        CType(Me.bs_ventas_por_empleado, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmd_calcular
        '
        Me.cmd_calcular.Location = New System.Drawing.Point(309, 16)
        Me.cmd_calcular.Name = "cmd_calcular"
        Me.cmd_calcular.Size = New System.Drawing.Size(74, 50)
        Me.cmd_calcular.TabIndex = 9
        Me.cmd_calcular.Text = "Calcular"
        Me.cmd_calcular.UseVisualStyleBackColor = True
        '
        'date_hasta
        '
        Me.date_hasta.Location = New System.Drawing.Point(102, 46)
        Me.date_hasta.Name = "date_hasta"
        Me.date_hasta.Size = New System.Drawing.Size(200, 20)
        Me.date_hasta.TabIndex = 7
        '
        'date_desde
        '
        Me.date_desde.Location = New System.Drawing.Point(102, 16)
        Me.date_desde.Name = "date_desde"
        Me.date_desde.Size = New System.Drawing.Size(200, 20)
        Me.date_desde.TabIndex = 8
        '
        'lbl_fecha_hasta
        '
        Me.lbl_fecha_hasta.AutoSize = True
        Me.lbl_fecha_hasta.Location = New System.Drawing.Point(27, 52)
        Me.lbl_fecha_hasta.Name = "lbl_fecha_hasta"
        Me.lbl_fecha_hasta.Size = New System.Drawing.Size(69, 13)
        Me.lbl_fecha_hasta.TabIndex = 5
        Me.lbl_fecha_hasta.Text = "Fecha hasta:"
        '
        'lbl_fecha_desde
        '
        Me.lbl_fecha_desde.AutoSize = True
        Me.lbl_fecha_desde.Location = New System.Drawing.Point(24, 22)
        Me.lbl_fecha_desde.Name = "lbl_fecha_desde"
        Me.lbl_fecha_desde.Size = New System.Drawing.Size(72, 13)
        Me.lbl_fecha_desde.TabIndex = 6
        Me.lbl_fecha_desde.Text = "Fecha desde:"
        '
        'rv_ventas_por_empleado
        '
        ReportDataSource1.Name = "ds_ventas_por_empleado"
        ReportDataSource1.Value = Me.bs_ventas_por_empleado
        Me.rv_ventas_por_empleado.LocalReport.DataSources.Add(ReportDataSource1)
        Me.rv_ventas_por_empleado.LocalReport.ReportEmbeddedResource = "Heladeria_Tu_Gusto.report_VentasPorEmpleado.rdlc"
        Me.rv_ventas_por_empleado.Location = New System.Drawing.Point(12, 84)
        Me.rv_ventas_por_empleado.Name = "rv_ventas_por_empleado"
        Me.rv_ventas_por_empleado.ServerReport.BearerToken = Nothing
        Me.rv_ventas_por_empleado.Size = New System.Drawing.Size(903, 453)
        Me.rv_ventas_por_empleado.TabIndex = 10
        '
        'VentasPorEmpleado
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(928, 549)
        Me.Controls.Add(Me.rv_ventas_por_empleado)
        Me.Controls.Add(Me.cmd_calcular)
        Me.Controls.Add(Me.date_hasta)
        Me.Controls.Add(Me.date_desde)
        Me.Controls.Add(Me.lbl_fecha_hasta)
        Me.Controls.Add(Me.lbl_fecha_desde)
        Me.Name = "VentasPorEmpleado"
        Me.Text = "VentasPorEmpleado"
        CType(Me.bs_ventas_por_empleado, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmd_calcular As System.Windows.Forms.Button
    Friend WithEvents date_hasta As System.Windows.Forms.DateTimePicker
    Friend WithEvents date_desde As System.Windows.Forms.DateTimePicker
    Friend WithEvents lbl_fecha_hasta As System.Windows.Forms.Label
    Friend WithEvents lbl_fecha_desde As System.Windows.Forms.Label
    Friend WithEvents Ventas As Heladeria_Tu_Gusto.Ventas
    Friend WithEvents rv_ventas_por_empleado As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents bs_ventas_por_empleado As System.Windows.Forms.BindingSource
End Class
