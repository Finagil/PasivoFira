<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_rpt_cartera
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
        Me.btnEnviar = New System.Windows.Forms.Button()
        Me.dtpFechaCartera = New System.Windows.Forms.DateTimePicker()
        Me.crvReporteCartera = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.Sp_CONT_CPF_RptCarteraBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DS_reportes = New Fira_Cartera_Pasiva.DS_reportes()
        Me.Sp_CONT_CPF_RptCarteraTableAdapter = New Fira_Cartera_Pasiva.DS_reportesTableAdapters.Sp_CONT_CPF_RptCarteraTableAdapter()
        Me.rpt_cartera1 = New Fira_Cartera_Pasiva.rpt_cartera()
        Me.rpt_cartera2 = New Fira_Cartera_Pasiva.rpt_cartera()
        CType(Me.Sp_CONT_CPF_RptCarteraBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DS_reportes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnEnviar
        '
        Me.btnEnviar.Location = New System.Drawing.Point(218, 11)
        Me.btnEnviar.Name = "btnEnviar"
        Me.btnEnviar.Size = New System.Drawing.Size(75, 23)
        Me.btnEnviar.TabIndex = 3
        Me.btnEnviar.Text = "Enviar"
        Me.btnEnviar.UseVisualStyleBackColor = True
        '
        'dtpFechaCartera
        '
        Me.dtpFechaCartera.Location = New System.Drawing.Point(12, 12)
        Me.dtpFechaCartera.Name = "dtpFechaCartera"
        Me.dtpFechaCartera.Size = New System.Drawing.Size(200, 20)
        Me.dtpFechaCartera.TabIndex = 4
        '
        'crvReporteCartera
        '
        Me.crvReporteCartera.ActiveViewIndex = -1
        Me.crvReporteCartera.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.crvReporteCartera.Cursor = System.Windows.Forms.Cursors.Default
        Me.crvReporteCartera.Location = New System.Drawing.Point(12, 42)
        Me.crvReporteCartera.Name = "crvReporteCartera"
        Me.crvReporteCartera.Size = New System.Drawing.Size(1149, 486)
        Me.crvReporteCartera.TabIndex = 5
        Me.crvReporteCartera.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
        '
        'Sp_CONT_CPF_RptCarteraBindingSource
        '
        Me.Sp_CONT_CPF_RptCarteraBindingSource.DataMember = "Sp_CONT_CPF_RptCartera"
        Me.Sp_CONT_CPF_RptCarteraBindingSource.DataSource = Me.DS_reportes
        '
        'DS_reportes
        '
        Me.DS_reportes.DataSetName = "DS_reportes"
        Me.DS_reportes.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Sp_CONT_CPF_RptCarteraTableAdapter
        '
        Me.Sp_CONT_CPF_RptCarteraTableAdapter.ClearBeforeFill = True
        '
        'frm_rpt_cartera
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1181, 548)
        Me.Controls.Add(Me.crvReporteCartera)
        Me.Controls.Add(Me.dtpFechaCartera)
        Me.Controls.Add(Me.btnEnviar)
        Me.Name = "frm_rpt_cartera"
        Me.Text = "Reporte Cartera"
        CType(Me.Sp_CONT_CPF_RptCarteraBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DS_reportes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DS_reportes As DS_reportes
    Friend WithEvents Sp_CONT_CPF_RptCarteraBindingSource As BindingSource
    Friend WithEvents Sp_CONT_CPF_RptCarteraTableAdapter As DS_reportesTableAdapters.Sp_CONT_CPF_RptCarteraTableAdapter
    Friend WithEvents btnEnviar As Button
    Friend WithEvents dtpFechaCartera As DateTimePicker
    Friend WithEvents rpt_cartera1 As Fira_Cartera_Pasiva.rpt_cartera
    Friend WithEvents crvReporteCartera As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents rpt_cartera2 As rpt_cartera
End Class
