﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Reporte
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
        Dim ReportDataSource2 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Reporte))
        Me.rv_ventas = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.bs_ventas = New System.Windows.Forms.BindingSource(Me.components)
        CType(Me.bs_ventas,System.ComponentModel.ISupportInitialize).BeginInit
        Me.SuspendLayout
        '
        'rv_ventas
        '
        Me.rv_ventas.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource2.Name = "ListadoDeVentas"
        ReportDataSource2.Value = Me.bs_ventas
        Me.rv_ventas.LocalReport.DataSources.Add(ReportDataSource2)
        Me.rv_ventas.LocalReport.ReportEmbeddedResource = "Heladeria_Tu_Gusto.Reporte.rdlc"
        Me.rv_ventas.Location = New System.Drawing.Point(0, 0)
        Me.rv_ventas.Name = "rv_ventas"
        Me.rv_ventas.ServerReport.BearerToken = Nothing
        Me.rv_ventas.Size = New System.Drawing.Size(682, 535)
        Me.rv_ventas.TabIndex = 0
        '
        'Reporte
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(682, 535)
        Me.Controls.Add(Me.rv_ventas)
        Me.Icon = CType(resources.GetObject("$this.Icon"),System.Drawing.Icon)
        Me.Name = "Reporte"
        Me.Text = "Reporte de ventas"
        CType(Me.bs_ventas,System.ComponentModel.ISupportInitialize).EndInit
        Me.ResumeLayout(false)

End Sub

    Friend WithEvents rv_ventas As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents bs_ventas As BindingSource
End Class