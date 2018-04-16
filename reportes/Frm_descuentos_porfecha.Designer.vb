<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_descuentos_porfecha
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
        Me.dt_fecha = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.bt_Salir = New System.Windows.Forms.Button()
        Me.bt_procesar = New System.Windows.Forms.Button()
        Me.crv_descuentos = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.DS_reportes = New Fira_Cartera_Pasiva.DS_reportes()
        Me.Vw_ministraciones_contratosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Vw_ministraciones_contratosTableAdapter = New Fira_Cartera_Pasiva.DS_reportesTableAdapters.vw_ministraciones_contratosTableAdapter()
        Me.Vw_ministraciones_contratosTableAdapter1 = New Fira_Cartera_Pasiva.DS_reportesTableAdapters.vw_ministraciones_contratosTableAdapter()
        CType(Me.DS_reportes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Vw_ministraciones_contratosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dt_fecha
        '
        Me.dt_fecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dt_fecha.Location = New System.Drawing.Point(12, 33)
        Me.dt_fecha.Name = "dt_fecha"
        Me.dt_fecha.Size = New System.Drawing.Size(128, 20)
        Me.dt_fecha.TabIndex = 7
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 13)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Fecha "
        '
        'bt_Salir
        '
        Me.bt_Salir.Location = New System.Drawing.Point(257, 30)
        Me.bt_Salir.Name = "bt_Salir"
        Me.bt_Salir.Size = New System.Drawing.Size(75, 23)
        Me.bt_Salir.TabIndex = 5
        Me.bt_Salir.Text = "Salir"
        Me.bt_Salir.UseVisualStyleBackColor = True
        '
        'bt_procesar
        '
        Me.bt_procesar.Location = New System.Drawing.Point(162, 30)
        Me.bt_procesar.Name = "bt_procesar"
        Me.bt_procesar.Size = New System.Drawing.Size(75, 23)
        Me.bt_procesar.TabIndex = 4
        Me.bt_procesar.Text = "Procesar"
        Me.bt_procesar.UseVisualStyleBackColor = True
        '
        'crv_descuentos
        '
        Me.crv_descuentos.ActiveViewIndex = -1
        Me.crv_descuentos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.crv_descuentos.Cursor = System.Windows.Forms.Cursors.Default
        Me.crv_descuentos.Location = New System.Drawing.Point(13, 59)
        Me.crv_descuentos.Name = "crv_descuentos"
        Me.crv_descuentos.SelectionFormula = ""
        Me.crv_descuentos.Size = New System.Drawing.Size(748, 361)
        Me.crv_descuentos.TabIndex = 8
        Me.crv_descuentos.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
        Me.crv_descuentos.ViewTimeSelectionFormula = ""
        '
        'DS_reportes
        '
        Me.DS_reportes.DataSetName = "DS_reportes"
        Me.DS_reportes.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Vw_ministraciones_contratosBindingSource
        '
        Me.Vw_ministraciones_contratosBindingSource.DataMember = "vw_ministraciones_contratos"
        Me.Vw_ministraciones_contratosBindingSource.DataSource = Me.DS_reportes
        '
        'Vw_ministraciones_contratosTableAdapter
        '
        Me.Vw_ministraciones_contratosTableAdapter.ClearBeforeFill = True
        '
        'Vw_ministraciones_contratosTableAdapter1
        '
        Me.Vw_ministraciones_contratosTableAdapter1.ClearBeforeFill = True
        '
        'Frm_descuentos_porfecha
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(773, 432)
        Me.Controls.Add(Me.crv_descuentos)
        Me.Controls.Add(Me.dt_fecha)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.bt_Salir)
        Me.Controls.Add(Me.bt_procesar)
        Me.Name = "Frm_descuentos_porfecha"
        Me.Text = "Reporte de Descuentos por Fecha"
        CType(Me.DS_reportes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Vw_ministraciones_contratosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dt_fecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents bt_Salir As System.Windows.Forms.Button
    Friend WithEvents bt_procesar As System.Windows.Forms.Button
    Friend WithEvents crv_descuentos As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents DS_reportes As Fira_Cartera_Pasiva.DS_reportes
    Friend WithEvents Vw_ministraciones_contratosBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Vw_ministraciones_contratosTableAdapter As Fira_Cartera_Pasiva.DS_reportesTableAdapters.vw_ministraciones_contratosTableAdapter
    Friend WithEvents Vw_ministraciones_contratosTableAdapter1 As DS_reportesTableAdapters.vw_ministraciones_contratosTableAdapter
End Class
