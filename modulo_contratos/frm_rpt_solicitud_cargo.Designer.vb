<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_rpt_solicitud_cargo
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.DescuentosDS = New Fira_Cartera_Pasiva.DescuentosDS()
        Me.SaldoGarantiaEjercidaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SaldoGarantiaEjercidaTableAdapter = New Fira_Cartera_Pasiva.DescuentosDSTableAdapters.SaldoGarantiaEjercidaTableAdapter()
        Me.Vw_descuentosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Vw_descuentosTableAdapter = New Fira_Cartera_Pasiva.DescuentosDSTableAdapters.vw_descuentosTableAdapter()
        Me.CRV = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        CType(Me.DescuentosDS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SaldoGarantiaEjercidaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Vw_descuentosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DescuentosDS
        '
        Me.DescuentosDS.DataSetName = "DescuentosDS"
        Me.DescuentosDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'SaldoGarantiaEjercidaBindingSource
        '
        Me.SaldoGarantiaEjercidaBindingSource.DataMember = "SaldoGarantiaEjercida"
        Me.SaldoGarantiaEjercidaBindingSource.DataSource = Me.DescuentosDS
        '
        'SaldoGarantiaEjercidaTableAdapter
        '
        Me.SaldoGarantiaEjercidaTableAdapter.ClearBeforeFill = True
        '
        'Vw_descuentosBindingSource
        '
        Me.Vw_descuentosBindingSource.DataMember = "vw_descuentos"
        Me.Vw_descuentosBindingSource.DataSource = Me.DescuentosDS
        '
        'Vw_descuentosTableAdapter
        '
        Me.Vw_descuentosTableAdapter.ClearBeforeFill = True
        '
        'CRV
        '
        Me.CRV.ActiveViewIndex = -1
        Me.CRV.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CRV.Cursor = System.Windows.Forms.Cursors.Default
        Me.CRV.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CRV.Location = New System.Drawing.Point(0, 0)
        Me.CRV.Name = "CRV"
        Me.CRV.SelectionFormula = ""
        Me.CRV.Size = New System.Drawing.Size(1066, 575)
        Me.CRV.TabIndex = 1
        Me.CRV.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
        Me.CRV.ViewTimeSelectionFormula = ""
        '
        'frm_rpt_solicitud_cargo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1066, 575)
        Me.Controls.Add(Me.CRV)
        Me.Name = "frm_rpt_solicitud_cargo"
        Me.Text = "frm_rpt_solicitud_cargo"
        CType(Me.DescuentosDS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SaldoGarantiaEjercidaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Vw_descuentosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DescuentosDS As Fira_Cartera_Pasiva.DescuentosDS
    Friend WithEvents SaldoGarantiaEjercidaBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SaldoGarantiaEjercidaTableAdapter As Fira_Cartera_Pasiva.DescuentosDSTableAdapters.SaldoGarantiaEjercidaTableAdapter
    Friend WithEvents Vw_descuentosBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Vw_descuentosTableAdapter As Fira_Cartera_Pasiva.DescuentosDSTableAdapters.vw_descuentosTableAdapter
    Friend WithEvents CRV As CrystalDecisions.Windows.Forms.CrystalReportViewer
End Class
