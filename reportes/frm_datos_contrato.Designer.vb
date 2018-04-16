<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_datos_contrato
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
        Me.bt_procesar = New System.Windows.Forms.Button()
        Me.bt_Salir = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dt_fecha = New System.Windows.Forms.DateTimePicker()
        Me.crv = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.DS_reportes = New Fira_Cartera_Pasiva.DS_reportes()
        Me.Vw_descuentosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Vw_descuentosTableAdapter = New Fira_Cartera_Pasiva.DS_reportesTableAdapters.vw_descuentosTableAdapter()
        CType(Me.DS_reportes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Vw_descuentosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'bt_procesar
        '
        Me.bt_procesar.Location = New System.Drawing.Point(171, 26)
        Me.bt_procesar.Name = "bt_procesar"
        Me.bt_procesar.Size = New System.Drawing.Size(75, 23)
        Me.bt_procesar.TabIndex = 0
        Me.bt_procesar.Text = "Procesar"
        Me.bt_procesar.UseVisualStyleBackColor = True
        '
        'bt_Salir
        '
        Me.bt_Salir.Location = New System.Drawing.Point(266, 26)
        Me.bt_Salir.Name = "bt_Salir"
        Me.bt_Salir.Size = New System.Drawing.Size(75, 23)
        Me.bt_Salir.TabIndex = 1
        Me.bt_Salir.Text = "Salir"
        Me.bt_Salir.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(18, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Fecha "
        '
        'dt_fecha
        '
        Me.dt_fecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dt_fecha.Location = New System.Drawing.Point(21, 29)
        Me.dt_fecha.Name = "dt_fecha"
        Me.dt_fecha.Size = New System.Drawing.Size(128, 20)
        Me.dt_fecha.TabIndex = 3
        '
        'crv
        '
        Me.crv.ActiveViewIndex = -1
        Me.crv.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.crv.Cursor = System.Windows.Forms.Cursors.Default
        Me.crv.Location = New System.Drawing.Point(33, 108)
        Me.crv.Name = "crv"
        Me.crv.SelectionFormula = ""
        Me.crv.Size = New System.Drawing.Size(1280, 942)
        Me.crv.TabIndex = 4
        Me.crv.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
        Me.crv.ViewTimeSelectionFormula = ""
        '
        'DS_reportes
        '
        Me.DS_reportes.DataSetName = "DS_reportes"
        Me.DS_reportes.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Vw_descuentosBindingSource
        '
        Me.Vw_descuentosBindingSource.DataMember = "vw_descuentos"
        Me.Vw_descuentosBindingSource.DataSource = Me.DS_reportes
        '
        'Vw_descuentosTableAdapter
        '
        Me.Vw_descuentosTableAdapter.ClearBeforeFill = True
        '
        'frm_datos_contrato
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1398, 1062)
        Me.Controls.Add(Me.crv)
        Me.Controls.Add(Me.dt_fecha)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.bt_Salir)
        Me.Controls.Add(Me.bt_procesar)
        Me.Name = "frm_datos_contrato"
        Me.Text = "Datos Contrato"
        CType(Me.DS_reportes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Vw_descuentosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents bt_procesar As System.Windows.Forms.Button
    Friend WithEvents bt_Salir As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dt_fecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents crv As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents DS_reportes As Fira_Cartera_Pasiva.DS_reportes
    Friend WithEvents Vw_descuentosBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Vw_descuentosTableAdapter As Fira_Cartera_Pasiva.DS_reportesTableAdapters.vw_descuentosTableAdapter
End Class
