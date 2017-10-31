<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Estadisticas
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
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim ReportDataSource2 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.GraficoBarrasProductosVendidosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Datos = New Heladeria_Tu_Gusto.Datos()
        Me.GraficoTortaPorcentajeVendidosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.rv_productos_vendidos = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_ls_productos_vendidos = New System.Windows.Forms.TextBox()
        Me.txt_li_productos_vendidos = New System.Windows.Forms.TextBox()
        Me.btn_graficar_productos_vendidos = New System.Windows.Forms.Button()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.rv_porcentaje_ingresos = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.lbl_presione_porcentaje_ventas = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txt_ls_porcentaje_ventas = New System.Windows.Forms.TextBox()
        Me.txt_li_porcentaje_ventas = New System.Windows.Forms.TextBox()
        Me.btn_graficar_porcentaje_ganancias = New System.Windows.Forms.Button()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.lbl_presione_productos_vendidos = New System.Windows.Forms.Label()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        CType(Me.GraficoBarrasProductosVendidosBindingSource,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Datos,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.GraficoTortaPorcentajeVendidosBindingSource,System.ComponentModel.ISupportInitialize).BeginInit
        Me.TabPage2.SuspendLayout
        Me.TabPage1.SuspendLayout
        Me.TabControl1.SuspendLayout
        Me.SuspendLayout
        '
        'GraficoBarrasProductosVendidosBindingSource
        '
        Me.GraficoBarrasProductosVendidosBindingSource.DataMember = "GraficoBarrasProductosVendidos"
        Me.GraficoBarrasProductosVendidosBindingSource.DataSource = Me.Datos
        '
        'Datos
        '
        Me.Datos.DataSetName = "Datos"
        Me.Datos.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GraficoTortaPorcentajeVendidosBindingSource
        '
        Me.GraficoTortaPorcentajeVendidosBindingSource.DataMember = "GraficoTortaPorcentajeVendidos"
        Me.GraficoTortaPorcentajeVendidosBindingSource.DataSource = Me.Datos
        '
        'rv_productos_vendidos
        '
        Me.rv_productos_vendidos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom)  _
            Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.GraficoBarrasProductosVendidosBindingSource
        Me.rv_productos_vendidos.LocalReport.DataSources.Add(ReportDataSource1)
        Me.rv_productos_vendidos.LocalReport.ReportEmbeddedResource = "Heladeria_Tu_Gusto.ProductosVendidos.rdlc"
        Me.rv_productos_vendidos.Location = New System.Drawing.Point(3, 58)
        Me.rv_productos_vendidos.Name = "rv_productos_vendidos"
        Me.rv_productos_vendidos.ServerReport.BearerToken = Nothing
        Me.rv_productos_vendidos.Size = New System.Drawing.Size(842, 506)
        Me.rv_productos_vendidos.TabIndex = 6
        Me.rv_productos_vendidos.Visible = false
        '
        'Label2
        '
        Me.Label2.AutoSize = true
        Me.Label2.Location = New System.Drawing.Point(6, 35)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(79, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Límite superior:"
        '
        'Label1
        '
        Me.Label1.AutoSize = true
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(73, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Límite inferior:"
        '
        'txt_ls_productos_vendidos
        '
        Me.txt_ls_productos_vendidos.Location = New System.Drawing.Point(91, 32)
        Me.txt_ls_productos_vendidos.Name = "txt_ls_productos_vendidos"
        Me.txt_ls_productos_vendidos.Size = New System.Drawing.Size(100, 20)
        Me.txt_ls_productos_vendidos.TabIndex = 3
        '
        'txt_li_productos_vendidos
        '
        Me.txt_li_productos_vendidos.Location = New System.Drawing.Point(91, 6)
        Me.txt_li_productos_vendidos.Name = "txt_li_productos_vendidos"
        Me.txt_li_productos_vendidos.Size = New System.Drawing.Size(100, 20)
        Me.txt_li_productos_vendidos.TabIndex = 2
        '
        'btn_graficar_productos_vendidos
        '
        Me.btn_graficar_productos_vendidos.Location = New System.Drawing.Point(197, 6)
        Me.btn_graficar_productos_vendidos.Name = "btn_graficar_productos_vendidos"
        Me.btn_graficar_productos_vendidos.Size = New System.Drawing.Size(77, 46)
        Me.btn_graficar_productos_vendidos.TabIndex = 0
        Me.btn_graficar_productos_vendidos.Text = "Graficar"
        Me.btn_graficar_productos_vendidos.UseVisualStyleBackColor = true
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.rv_porcentaje_ingresos)
        Me.TabPage2.Controls.Add(Me.lbl_presione_porcentaje_ventas)
        Me.TabPage2.Controls.Add(Me.Label4)
        Me.TabPage2.Controls.Add(Me.Label5)
        Me.TabPage2.Controls.Add(Me.txt_ls_porcentaje_ventas)
        Me.TabPage2.Controls.Add(Me.txt_li_porcentaje_ventas)
        Me.TabPage2.Controls.Add(Me.btn_graficar_porcentaje_ganancias)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(851, 665)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Porcentaje de ventas"
        Me.TabPage2.UseVisualStyleBackColor = true
        '
        'rv_porcentaje_ingresos
        '
        Me.rv_porcentaje_ingresos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom)  _
            Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        ReportDataSource2.Name = "DataSet1"
        ReportDataSource2.Value = Me.GraficoTortaPorcentajeVendidosBindingSource
        Me.rv_porcentaje_ingresos.LocalReport.DataSources.Add(ReportDataSource2)
        Me.rv_porcentaje_ingresos.LocalReport.ReportEmbeddedResource = "Heladeria_Tu_Gusto.PorcentajeDeIngresos.rdlc"
        Me.rv_porcentaje_ingresos.Location = New System.Drawing.Point(7, 58)
        Me.rv_porcentaje_ingresos.Name = "rv_porcentaje_ingresos"
        Me.rv_porcentaje_ingresos.ServerReport.BearerToken = Nothing
        Me.rv_porcentaje_ingresos.Size = New System.Drawing.Size(838, 601)
        Me.rv_porcentaje_ingresos.TabIndex = 14
        Me.rv_porcentaje_ingresos.Visible = false
        '
        'lbl_presione_porcentaje_ventas
        '
        Me.lbl_presione_porcentaje_ventas.AutoSize = true
        Me.lbl_presione_porcentaje_ventas.BackColor = System.Drawing.Color.Silver
        Me.lbl_presione_porcentaje_ventas.Location = New System.Drawing.Point(320, 22)
        Me.lbl_presione_porcentaje_ventas.Name = "lbl_presione_porcentaje_ventas"
        Me.lbl_presione_porcentaje_ventas.Size = New System.Drawing.Size(206, 13)
        Me.lbl_presione_porcentaje_ventas.TabIndex = 13
        Me.lbl_presione_porcentaje_ventas.Text = "Presione graficar para visualizar el reporte."
        '
        'Label4
        '
        Me.Label4.AutoSize = true
        Me.Label4.Location = New System.Drawing.Point(4, 35)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(79, 13)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "Límite superior:"
        '
        'Label5
        '
        Me.Label5.AutoSize = true
        Me.Label5.Location = New System.Drawing.Point(10, 9)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(73, 13)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Límite inferior:"
        '
        'txt_ls_porcentaje_ventas
        '
        Me.txt_ls_porcentaje_ventas.Location = New System.Drawing.Point(89, 32)
        Me.txt_ls_porcentaje_ventas.Name = "txt_ls_porcentaje_ventas"
        Me.txt_ls_porcentaje_ventas.Size = New System.Drawing.Size(100, 20)
        Me.txt_ls_porcentaje_ventas.TabIndex = 10
        '
        'txt_li_porcentaje_ventas
        '
        Me.txt_li_porcentaje_ventas.Location = New System.Drawing.Point(89, 6)
        Me.txt_li_porcentaje_ventas.Name = "txt_li_porcentaje_ventas"
        Me.txt_li_porcentaje_ventas.Size = New System.Drawing.Size(100, 20)
        Me.txt_li_porcentaje_ventas.TabIndex = 9
        '
        'btn_graficar_porcentaje_ganancias
        '
        Me.btn_graficar_porcentaje_ganancias.Location = New System.Drawing.Point(195, 6)
        Me.btn_graficar_porcentaje_ganancias.Name = "btn_graficar_porcentaje_ganancias"
        Me.btn_graficar_porcentaje_ganancias.Size = New System.Drawing.Size(77, 46)
        Me.btn_graficar_porcentaje_ganancias.TabIndex = 8
        Me.btn_graficar_porcentaje_ganancias.Text = "Graficar"
        Me.btn_graficar_porcentaje_ganancias.UseVisualStyleBackColor = true
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.lbl_presione_productos_vendidos)
        Me.TabPage1.Controls.Add(Me.rv_productos_vendidos)
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Controls.Add(Me.txt_ls_productos_vendidos)
        Me.TabPage1.Controls.Add(Me.txt_li_productos_vendidos)
        Me.TabPage1.Controls.Add(Me.btn_graficar_productos_vendidos)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(851, 570)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Productos vendidos"
        Me.TabPage1.UseVisualStyleBackColor = true
        '
        'lbl_presione_productos_vendidos
        '
        Me.lbl_presione_productos_vendidos.AutoSize = true
        Me.lbl_presione_productos_vendidos.BackColor = System.Drawing.Color.Silver
        Me.lbl_presione_productos_vendidos.Location = New System.Drawing.Point(327, 23)
        Me.lbl_presione_productos_vendidos.Name = "lbl_presione_productos_vendidos"
        Me.lbl_presione_productos_vendidos.Size = New System.Drawing.Size(206, 13)
        Me.lbl_presione_productos_vendidos.TabIndex = 7
        Me.lbl_presione_productos_vendidos.Text = "Presione graficar para visualizar el reporte."
        '
        'TabControl1
        '
        Me.TabControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom)  _
            Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(12, 12)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(859, 691)
        Me.TabControl1.TabIndex = 0
        '
        'Estadisticas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(883, 715)
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "Estadisticas"
        Me.Text = "Estadisticas"
        CType(Me.GraficoBarrasProductosVendidosBindingSource,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Datos,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.GraficoTortaPorcentajeVendidosBindingSource,System.ComponentModel.ISupportInitialize).EndInit
        Me.TabPage2.ResumeLayout(false)
        Me.TabPage2.PerformLayout
        Me.TabPage1.ResumeLayout(false)
        Me.TabPage1.PerformLayout
        Me.TabControl1.ResumeLayout(false)
        Me.ResumeLayout(false)

End Sub
    Friend WithEvents btn_graficar_productos_vendidos As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txt_ls_productos_vendidos As TextBox
    Friend WithEvents txt_li_productos_vendidos As TextBox
    Friend WithEvents rv_productos_vendidos As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents GraficoBarrasProductosVendidosBindingSource As BindingSource
    Friend WithEvents Datos As Datos
    Friend WithEvents lbl_presione_productos_vendidos As Label
    Friend WithEvents lbl_presione_porcentaje_ventas As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txt_ls_porcentaje_ventas As TextBox
    Friend WithEvents txt_li_porcentaje_ventas As TextBox
    Friend WithEvents btn_graficar_porcentaje_ganancias As Button
    Friend WithEvents rv_porcentaje_ingresos As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents GraficoTortaPorcentajeVendidosBindingSource As BindingSource
End Class
