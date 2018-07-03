<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_cl_plazo
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
        Me.dtpCLPlazo = New System.Windows.Forms.DateTimePicker()
        Me.btnEnviar = New System.Windows.Forms.Button()
        Me.rpt_prueba021 = New Fira_Cartera_Pasiva.rpt_prueba02()
        Me.CrystalReportViewer1 = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.rpt_cl_plazo021 = New Fira_Cartera_Pasiva.rpt_cl_plazo02()
        Me.DS_reportes = New Fira_Cartera_Pasiva.DS_reportes()
        Me.CL_PlazoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CL_Plazo_03TableAdapter = New Fira_Cartera_Pasiva.DS_reportesTableAdapters.CL_Plazo_03TableAdapter()
        CType(Me.DS_reportes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CL_PlazoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dtpCLPlazo
        '
        Me.dtpCLPlazo.Location = New System.Drawing.Point(12, 12)
        Me.dtpCLPlazo.Name = "dtpCLPlazo"
        Me.dtpCLPlazo.Size = New System.Drawing.Size(200, 20)
        Me.dtpCLPlazo.TabIndex = 1
        '
        'btnEnviar
        '
        Me.btnEnviar.Location = New System.Drawing.Point(243, 12)
        Me.btnEnviar.Name = "btnEnviar"
        Me.btnEnviar.Size = New System.Drawing.Size(75, 23)
        Me.btnEnviar.TabIndex = 2
        Me.btnEnviar.Text = "Enviar"
        Me.btnEnviar.UseVisualStyleBackColor = True
        '
        'CrystalReportViewer1
        '
        Me.CrystalReportViewer1.ActiveViewIndex = -1
        Me.CrystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CrystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default
        Me.CrystalReportViewer1.Location = New System.Drawing.Point(12, 41)
        Me.CrystalReportViewer1.Name = "CrystalReportViewer1"
        Me.CrystalReportViewer1.Size = New System.Drawing.Size(1266, 611)
        Me.CrystalReportViewer1.TabIndex = 0
        Me.CrystalReportViewer1.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
        '
        'DS_reportes
        '
        Me.DS_reportes.DataSetName = "DS_reportes"
        Me.DS_reportes.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CL_PlazoBindingSource
        '
        Me.CL_PlazoBindingSource.DataMember = "CL_Plazo_03"
        Me.CL_PlazoBindingSource.DataSource = Me.DS_reportes
        '
        'CL_Plazo_03TableAdapter
        '
        Me.CL_Plazo_03TableAdapter.ClearBeforeFill = True
        '
        'frm_cl_plazo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1290, 664)
        Me.Controls.Add(Me.btnEnviar)
        Me.Controls.Add(Me.dtpCLPlazo)
        Me.Controls.Add(Me.CrystalReportViewer1)
        Me.Name = "frm_cl_plazo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Corto y Largo Plazo"
        CType(Me.DS_reportes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CL_PlazoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents CrystalReportViewer1 As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents rpt_cl_plazo021 As Fira_Cartera_Pasiva.rpt_cl_plazo02
    Friend WithEvents DS_reportes As DS_reportes
    Friend WithEvents CL_PlazoBindingSource As BindingSource
    Friend WithEvents CL_PlazoTableAdapter As DS_reportesTableAdapters.CL_PlazoTableAdapter
    Friend WithEvents dtpCLPlazo As DateTimePicker
    Friend WithEvents btnEnviar As Button
    Friend WithEvents rpt_prueba021 As rpt_prueba02
    Friend WithEvents CL_Plazo_03TableAdapter As DS_reportesTableAdapters.CL_Plazo_03TableAdapter
End Class
