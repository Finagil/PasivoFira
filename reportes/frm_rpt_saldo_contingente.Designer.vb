<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_rpt_saldo_contingente
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.DS_reportes = New Fira_Cartera_Pasiva.DS_reportes()
        Me.Sp_CONT_CPF_RptSaldoContigenteBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Sp_CONT_CPF_RptSaldoContigenteTableAdapter = New Fira_Cartera_Pasiva.DS_reportesTableAdapters.Sp_CONT_CPF_RptSaldoContigenteTableAdapter()
        Me.rpt_saldo_contingente1 = New Fira_Cartera_Pasiva.rpt_saldo_contingente()
        Me.crv_saldo_contingente = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        CType(Me.DS_reportes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Sp_CONT_CPF_RptSaldoContigenteBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DS_reportes
        '
        Me.DS_reportes.DataSetName = "DS_reportes"
        Me.DS_reportes.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Sp_CONT_CPF_RptSaldoContigenteBindingSource
        '
        Me.Sp_CONT_CPF_RptSaldoContigenteBindingSource.DataMember = "Sp_CONT_CPF_RptSaldoContigente"
        Me.Sp_CONT_CPF_RptSaldoContigenteBindingSource.DataSource = Me.DS_reportes
        '
        'Sp_CONT_CPF_RptSaldoContigenteTableAdapter
        '
        Me.Sp_CONT_CPF_RptSaldoContigenteTableAdapter.ClearBeforeFill = True
        '
        'crv_saldo_contingente
        '
        Me.crv_saldo_contingente.ActiveViewIndex = -1
        Me.crv_saldo_contingente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.crv_saldo_contingente.Cursor = System.Windows.Forms.Cursors.Default
        Me.crv_saldo_contingente.Dock = System.Windows.Forms.DockStyle.Fill
        Me.crv_saldo_contingente.Location = New System.Drawing.Point(0, 0)
        Me.crv_saldo_contingente.Name = "crv_saldo_contingente"
        Me.crv_saldo_contingente.SelectionFormula = ""
        Me.crv_saldo_contingente.Size = New System.Drawing.Size(1294, 496)
        Me.crv_saldo_contingente.TabIndex = 1
        Me.crv_saldo_contingente.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
        Me.crv_saldo_contingente.ViewTimeSelectionFormula = ""
        '
        'frm_rpt_saldo_contingente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1294, 496)
        Me.Controls.Add(Me.crv_saldo_contingente)
        Me.Name = "frm_rpt_saldo_contingente"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Reporte Saldo Contingente "
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.DS_reportes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Sp_CONT_CPF_RptSaldoContigenteBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents rpt_saldo_contingente1 As rpt_saldo_contingente
    Friend WithEvents DS_reportes As DS_reportes
    Friend WithEvents Sp_CONT_CPF_RptSaldoContigenteBindingSource As BindingSource
    Friend WithEvents Sp_CONT_CPF_RptSaldoContigenteTableAdapter As DS_reportesTableAdapters.Sp_CONT_CPF_RptSaldoContigenteTableAdapter
    Friend WithEvents crv_saldo_contingente As CrystalDecisions.Windows.Forms.CrystalReportViewer
End Class
