<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_rpt_saldp
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
        Me.DT_FECHA = New System.Windows.Forms.DateTimePicker()
        Me.crv = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.DS_reportes = New Fira_Cartera_Pasiva.DS_reportes()
        Me.VwsaldoPFBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.VwsaldoPFBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.Vw_saldo_PFTableAdapter = New Fira_Cartera_Pasiva.DS_reportesTableAdapters.vw_saldo_PFTableAdapter()
        CType(Me.DS_reportes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VwsaldoPFBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VwsaldoPFBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DT_FECHA
        '
        Me.DT_FECHA.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DT_FECHA.Location = New System.Drawing.Point(103, 13)
        Me.DT_FECHA.Name = "DT_FECHA"
        Me.DT_FECHA.Size = New System.Drawing.Size(148, 20)
        Me.DT_FECHA.TabIndex = 0
        '
        'crv
        '
        Me.crv.ActiveViewIndex = -1
        Me.crv.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.crv.Cursor = System.Windows.Forms.Cursors.Default
        Me.crv.DisplayStatusBar = False
        Me.crv.Location = New System.Drawing.Point(21, 73)
        Me.crv.Name = "crv"
        Me.crv.Size = New System.Drawing.Size(904, 727)
        Me.crv.TabIndex = 2
        Me.crv.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(32, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(65, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Fecha Corte"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(276, 14)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(110, 26)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "Imprimir"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'DS_reportes
        '
        Me.DS_reportes.DataSetName = "DS_reportes"
        Me.DS_reportes.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'VwsaldoPFBindingSource
        '
        Me.VwsaldoPFBindingSource.DataMember = "vw_saldo_PF"
        Me.VwsaldoPFBindingSource.DataSource = Me.DS_reportes
        '
        'VwsaldoPFBindingSource1
        '
        Me.VwsaldoPFBindingSource1.DataMember = "vw_saldo_PF"
        Me.VwsaldoPFBindingSource1.DataSource = Me.DS_reportes
        '
        'Vw_saldo_PFTableAdapter
        '
        Me.Vw_saldo_PFTableAdapter.ClearBeforeFill = True
        '
        'frm_rpt_saldp
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(939, 880)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.crv)
        Me.Controls.Add(Me.DT_FECHA)
        Me.Name = "frm_rpt_saldp"
        Me.Text = "frm_rpt_saldo"
        CType(Me.DS_reportes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VwsaldoPFBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VwsaldoPFBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DT_FECHA As DateTimePicker
    Friend WithEvents crv As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents Label1 As Label
    Friend WithEvents DS_reportes As DS_reportes
    Friend WithEvents VwsaldoPFBindingSource As BindingSource
    Friend WithEvents Button1 As Button
    Friend WithEvents VwsaldoPFBindingSource1 As BindingSource
    Friend WithEvents Vw_saldo_PFTableAdapter As DS_reportesTableAdapters.vw_saldo_PFTableAdapter
End Class
