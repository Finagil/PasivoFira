<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_rpt_garantiasE
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
        Me.crv = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.DS_reportes = New Fira_Cartera_Pasiva.DS_reportes()
        Me.VwCONTCPFGarantiaerecidaRptBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Vw_CONT_CPF_GarantiaerecidaRptTableAdapter = New Fira_Cartera_Pasiva.DS_reportesTableAdapters.vw_CONT_CPF_GarantiaerecidaRptTableAdapter()
        CType(Me.DS_reportes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VwCONTCPFGarantiaerecidaRptBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'crv
        '
        Me.crv.ActiveViewIndex = -1
        Me.crv.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.crv.Cursor = System.Windows.Forms.Cursors.Default
        Me.crv.DisplayStatusBar = False
        Me.crv.Dock = System.Windows.Forms.DockStyle.Fill
        Me.crv.Location = New System.Drawing.Point(0, 0)
        Me.crv.Name = "crv"
        Me.crv.Size = New System.Drawing.Size(1081, 704)
        Me.crv.TabIndex = 3
        Me.crv.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
        '
        'DS_reportes
        '
        Me.DS_reportes.DataSetName = "DS_reportes"
        Me.DS_reportes.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'VwCONTCPFGarantiaerecidaRptBindingSource
        '
        Me.VwCONTCPFGarantiaerecidaRptBindingSource.DataMember = "vw_CONT_CPF_GarantiaerecidaRpt"
        Me.VwCONTCPFGarantiaerecidaRptBindingSource.DataSource = Me.DS_reportes
        '
        'Vw_CONT_CPF_GarantiaerecidaRptTableAdapter
        '
        Me.Vw_CONT_CPF_GarantiaerecidaRptTableAdapter.ClearBeforeFill = True
        '
        'frm_rpt_garantiasE
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1081, 704)
        Me.Controls.Add(Me.crv)
        Me.Name = "frm_rpt_garantiasE"
        Me.Text = "Garantias Ejercidas"
        CType(Me.DS_reportes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VwCONTCPFGarantiaerecidaRptBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents crv As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents DS_reportes As DS_reportes
    Friend WithEvents VwCONTCPFGarantiaerecidaRptBindingSource As BindingSource
    Friend WithEvents Vw_CONT_CPF_GarantiaerecidaRptTableAdapter As DS_reportesTableAdapters.vw_CONT_CPF_GarantiaerecidaRptTableAdapter
End Class
