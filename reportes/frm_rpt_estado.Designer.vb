<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_rpt_estado
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
        Me.DS_contratos = New Fira_Cartera_Pasiva.DS_contratos()
        Me.Vw_descuentosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Vw_descuentosTableAdapter = New Fira_Cartera_Pasiva.DS_contratosTableAdapters.vw_descuentosTableAdapter()
        Me.Vw_TIIEpromedioBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Vw_TIIEpromedioTableAdapter = New Fira_Cartera_Pasiva.DS_contratosTableAdapters.Vw_TIIEpromedioTableAdapter()
        Me.CONT_CPF_contratos_garantiasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CONT_CPF_contratos_garantiasTableAdapter = New Fira_Cartera_Pasiva.DS_contratosTableAdapters.CONT_CPF_contratos_garantiasTableAdapter()
        Me.CONT_CPF_csgBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CONT_CPF_csgTableAdapter = New Fira_Cartera_Pasiva.DS_contratosTableAdapters.CONT_CPF_csgTableAdapter()
        Me.CONT_CPF_edocuentaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CONT_CPF_edocuentaTableAdapter = New Fira_Cartera_Pasiva.DS_contratosTableAdapters.CONT_CPF_edocuentaTableAdapter()
        Me.CONT_CPF_ministracionesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CONT_CPF_ministracionesTableAdapter = New Fira_Cartera_Pasiva.DS_contratosTableAdapters.CONT_CPF_ministracionesTableAdapter()
        Me.CONT_CPF_saldos_contingenteBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CONT_CPF_saldos_contingenteTableAdapter = New Fira_Cartera_Pasiva.DS_contratosTableAdapters.CONT_CPF_saldos_contingenteTableAdapter()
        Me.CONT_CPF_vencimientosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CONT_CPF_vencimientosTableAdapter = New Fira_Cartera_Pasiva.DS_contratosTableAdapters.CONT_CPF_vencimientosTableAdapter()
        Me.Vw_GARANTIABindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Vw_GARANTIATableAdapter = New Fira_Cartera_Pasiva.DS_contratosTableAdapters.vw_GARANTIATableAdapter()
        Me.crv = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.CONTCPFpagosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CONT_CPF_pagosTableAdapter = New Fira_Cartera_Pasiva.DS_contratosTableAdapters.CONT_CPF_pagosTableAdapter()
        Me.VwdescuentoSABindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Vw_descuentoSATableAdapter = New Fira_Cartera_Pasiva.DS_contratosTableAdapters.vw_descuentoSATableAdapter()
        CType(Me.DS_contratos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Vw_descuentosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Vw_TIIEpromedioBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CONT_CPF_contratos_garantiasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CONT_CPF_csgBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CONT_CPF_edocuentaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CONT_CPF_ministracionesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CONT_CPF_saldos_contingenteBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CONT_CPF_vencimientosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Vw_GARANTIABindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CONTCPFpagosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VwdescuentoSABindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DS_contratos
        '
        Me.DS_contratos.DataSetName = "DS_contratos"
        Me.DS_contratos.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Vw_descuentosBindingSource
        '
        Me.Vw_descuentosBindingSource.DataMember = "vw_descuentos"
        Me.Vw_descuentosBindingSource.DataSource = Me.DS_contratos
        '
        'Vw_descuentosTableAdapter
        '
        Me.Vw_descuentosTableAdapter.ClearBeforeFill = True
        '
        'Vw_TIIEpromedioBindingSource
        '
        Me.Vw_TIIEpromedioBindingSource.DataMember = "Vw_TIIEpromedio"
        Me.Vw_TIIEpromedioBindingSource.DataSource = Me.DS_contratos
        '
        'Vw_TIIEpromedioTableAdapter
        '
        Me.Vw_TIIEpromedioTableAdapter.ClearBeforeFill = True
        '
        'CONT_CPF_contratos_garantiasBindingSource
        '
        Me.CONT_CPF_contratos_garantiasBindingSource.DataMember = "CONT_CPF_contratos_garantias"
        Me.CONT_CPF_contratos_garantiasBindingSource.DataSource = Me.DS_contratos
        '
        'CONT_CPF_contratos_garantiasTableAdapter
        '
        Me.CONT_CPF_contratos_garantiasTableAdapter.ClearBeforeFill = True
        '
        'CONT_CPF_csgBindingSource
        '
        Me.CONT_CPF_csgBindingSource.DataMember = "CONT_CPF_csg"
        Me.CONT_CPF_csgBindingSource.DataSource = Me.DS_contratos
        '
        'CONT_CPF_csgTableAdapter
        '
        Me.CONT_CPF_csgTableAdapter.ClearBeforeFill = True
        '
        'CONT_CPF_edocuentaBindingSource
        '
        Me.CONT_CPF_edocuentaBindingSource.DataMember = "CONT_CPF_edocuenta"
        Me.CONT_CPF_edocuentaBindingSource.DataSource = Me.DS_contratos
        '
        'CONT_CPF_edocuentaTableAdapter
        '
        Me.CONT_CPF_edocuentaTableAdapter.ClearBeforeFill = True
        '
        'CONT_CPF_ministracionesBindingSource
        '
        Me.CONT_CPF_ministracionesBindingSource.DataMember = "CONT_CPF_ministraciones"
        Me.CONT_CPF_ministracionesBindingSource.DataSource = Me.DS_contratos
        '
        'CONT_CPF_ministracionesTableAdapter
        '
        Me.CONT_CPF_ministracionesTableAdapter.ClearBeforeFill = True
        '
        'CONT_CPF_saldos_contingenteBindingSource
        '
        Me.CONT_CPF_saldos_contingenteBindingSource.DataMember = "CONT_CPF_saldos_contingente"
        Me.CONT_CPF_saldos_contingenteBindingSource.DataSource = Me.DS_contratos
        '
        'CONT_CPF_saldos_contingenteTableAdapter
        '
        Me.CONT_CPF_saldos_contingenteTableAdapter.ClearBeforeFill = True
        '
        'CONT_CPF_vencimientosBindingSource
        '
        Me.CONT_CPF_vencimientosBindingSource.DataMember = "CONT_CPF_vencimientos"
        Me.CONT_CPF_vencimientosBindingSource.DataSource = Me.DS_contratos
        '
        'CONT_CPF_vencimientosTableAdapter
        '
        Me.CONT_CPF_vencimientosTableAdapter.ClearBeforeFill = True
        '
        'Vw_GARANTIABindingSource
        '
        Me.Vw_GARANTIABindingSource.DataMember = "vw_GARANTIA"
        Me.Vw_GARANTIABindingSource.DataSource = Me.DS_contratos
        '
        'Vw_GARANTIATableAdapter
        '
        Me.Vw_GARANTIATableAdapter.ClearBeforeFill = True
        '
        'crv
        '
        Me.crv.ActiveViewIndex = -1
        Me.crv.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.crv.Cursor = System.Windows.Forms.Cursors.Default
        Me.crv.Dock = System.Windows.Forms.DockStyle.Fill
        Me.crv.Location = New System.Drawing.Point(0, 0)
        Me.crv.Name = "crv"
        Me.crv.SelectionFormula = ""
        Me.crv.Size = New System.Drawing.Size(1381, 718)
        Me.crv.TabIndex = 0
        Me.crv.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
        Me.crv.ViewTimeSelectionFormula = ""
        '
        'CONTCPFpagosBindingSource
        '
        Me.CONTCPFpagosBindingSource.DataMember = "CONT_CPF_pagos"
        Me.CONTCPFpagosBindingSource.DataSource = Me.DS_contratos
        '
        'CONT_CPF_pagosTableAdapter
        '
        Me.CONT_CPF_pagosTableAdapter.ClearBeforeFill = True
        '
        'VwdescuentoSABindingSource
        '
        Me.VwdescuentoSABindingSource.DataMember = "vw_descuentoSA"
        Me.VwdescuentoSABindingSource.DataSource = Me.DS_contratos
        '
        'Vw_descuentoSATableAdapter
        '
        Me.Vw_descuentoSATableAdapter.ClearBeforeFill = True
        '
        'frm_rpt_estado
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1381, 718)
        Me.Controls.Add(Me.crv)
        Me.Name = "frm_rpt_estado"
        Me.Text = "Estado de Cuenta"
        CType(Me.DS_contratos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Vw_descuentosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Vw_TIIEpromedioBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CONT_CPF_contratos_garantiasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CONT_CPF_csgBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CONT_CPF_edocuentaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CONT_CPF_ministracionesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CONT_CPF_saldos_contingenteBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CONT_CPF_vencimientosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Vw_GARANTIABindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CONTCPFpagosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VwdescuentoSABindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DS_contratos As Fira_Cartera_Pasiva.DS_contratos
    Friend WithEvents Vw_descuentosBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Vw_descuentosTableAdapter As Fira_Cartera_Pasiva.DS_contratosTableAdapters.vw_descuentosTableAdapter
    Friend WithEvents Vw_TIIEpromedioBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Vw_TIIEpromedioTableAdapter As Fira_Cartera_Pasiva.DS_contratosTableAdapters.Vw_TIIEpromedioTableAdapter
    Friend WithEvents CONT_CPF_contratos_garantiasBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CONT_CPF_contratos_garantiasTableAdapter As Fira_Cartera_Pasiva.DS_contratosTableAdapters.CONT_CPF_contratos_garantiasTableAdapter
    Friend WithEvents CONT_CPF_csgBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CONT_CPF_csgTableAdapter As Fira_Cartera_Pasiva.DS_contratosTableAdapters.CONT_CPF_csgTableAdapter
    Friend WithEvents CONT_CPF_edocuentaBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CONT_CPF_edocuentaTableAdapter As Fira_Cartera_Pasiva.DS_contratosTableAdapters.CONT_CPF_edocuentaTableAdapter
    Friend WithEvents CONT_CPF_ministracionesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CONT_CPF_ministracionesTableAdapter As Fira_Cartera_Pasiva.DS_contratosTableAdapters.CONT_CPF_ministracionesTableAdapter
    Friend WithEvents CONT_CPF_saldos_contingenteBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CONT_CPF_saldos_contingenteTableAdapter As Fira_Cartera_Pasiva.DS_contratosTableAdapters.CONT_CPF_saldos_contingenteTableAdapter
    Friend WithEvents CONT_CPF_vencimientosBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CONT_CPF_vencimientosTableAdapter As Fira_Cartera_Pasiva.DS_contratosTableAdapters.CONT_CPF_vencimientosTableAdapter
    Friend WithEvents Vw_GARANTIABindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Vw_GARANTIATableAdapter As Fira_Cartera_Pasiva.DS_contratosTableAdapters.vw_GARANTIATableAdapter
    Friend WithEvents crv As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents CONTCPFpagosBindingSource As BindingSource
    Friend WithEvents CONT_CPF_pagosTableAdapter As DS_contratosTableAdapters.CONT_CPF_pagosTableAdapter
    Friend WithEvents VwdescuentoSABindingSource As BindingSource
    Friend WithEvents Vw_descuentoSATableAdapter As DS_contratosTableAdapters.vw_descuentoSATableAdapter
End Class
