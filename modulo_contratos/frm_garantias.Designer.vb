<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_garantias
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
        Me.components = New System.ComponentModel.Container
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.CONT_CPF_contratos_garantiasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DS_contratos = New Fira_Cartera_Pasiva.DS_contratos
        Me.CONT_CPF_garantiasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CONT_CPF_contratos_garantiasDataGridView = New System.Windows.Forms.DataGridView
        Me.CONT_CPF_contratos_garantiasTableAdapter = New Fira_Cartera_Pasiva.DS_contratosTableAdapters.CONT_CPF_contratos_garantiasTableAdapter
        Me.CONT_CPF_garantiasTableAdapter = New Fira_Cartera_Pasiva.DS_contratosTableAdapters.CONT_CPF_garantiasTableAdapter
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewCheckBoxColumn1 = New System.Windows.Forms.DataGridViewCheckBoxColumn
        CType(Me.CONT_CPF_contratos_garantiasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DS_contratos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CONT_CPF_garantiasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CONT_CPF_contratos_garantiasDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CONT_CPF_contratos_garantiasBindingSource
        '
        Me.CONT_CPF_contratos_garantiasBindingSource.DataMember = "CONT_CPF_contratos_garantias"
        Me.CONT_CPF_contratos_garantiasBindingSource.DataSource = Me.DS_contratos
        '
        'DS_contratos
        '
        Me.DS_contratos.DataSetName = "DS_contratos"
        Me.DS_contratos.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CONT_CPF_garantiasBindingSource
        '
        Me.CONT_CPF_garantiasBindingSource.DataMember = "CONT_CPF_garantias"
        Me.CONT_CPF_garantiasBindingSource.DataSource = Me.DS_contratos
        '
        'CONT_CPF_contratos_garantiasDataGridView
        '
        Me.CONT_CPF_contratos_garantiasDataGridView.AllowUserToAddRows = False
        Me.CONT_CPF_contratos_garantiasDataGridView.AllowUserToDeleteRows = False
        Me.CONT_CPF_contratos_garantiasDataGridView.AutoGenerateColumns = False
        Me.CONT_CPF_contratos_garantiasDataGridView.ColumnHeadersHeight = 34
        Me.CONT_CPF_contratos_garantiasDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn5, Me.DataGridViewCheckBoxColumn1})
        Me.CONT_CPF_contratos_garantiasDataGridView.DataSource = Me.CONT_CPF_contratos_garantiasBindingSource
        Me.CONT_CPF_contratos_garantiasDataGridView.Location = New System.Drawing.Point(13, 18)
        Me.CONT_CPF_contratos_garantiasDataGridView.Name = "CONT_CPF_contratos_garantiasDataGridView"
        Me.CONT_CPF_contratos_garantiasDataGridView.ReadOnly = True
        Me.CONT_CPF_contratos_garantiasDataGridView.Size = New System.Drawing.Size(659, 146)
        Me.CONT_CPF_contratos_garantiasDataGridView.TabIndex = 30
        '
        'CONT_CPF_contratos_garantiasTableAdapter
        '
        Me.CONT_CPF_contratos_garantiasTableAdapter.ClearBeforeFill = True
        '
        'CONT_CPF_garantiasTableAdapter
        '
        Me.CONT_CPF_garantiasTableAdapter.ClearBeforeFill = True
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "cobertura_nominal"
        Me.DataGridViewTextBoxColumn4.HeaderText = "% C. Nominal"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "cobertura_efectiva"
        Me.DataGridViewTextBoxColumn6.HeaderText = "% C. Efectiva"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "saldo_contingente"
        DataGridViewCellStyle1.Format = "N2"
        DataGridViewCellStyle1.NullValue = Nothing
        Me.DataGridViewTextBoxColumn5.DefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridViewTextBoxColumn5.HeaderText = "Saldo C."
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        '
        'DataGridViewCheckBoxColumn1
        '
        Me.DataGridViewCheckBoxColumn1.DataPropertyName = "fondeo"
        Me.DataGridViewCheckBoxColumn1.HeaderText = "Fondeo"
        Me.DataGridViewCheckBoxColumn1.Name = "DataGridViewCheckBoxColumn1"
        Me.DataGridViewCheckBoxColumn1.ReadOnly = True
        '
        'frm_garantias
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(684, 177)
        Me.Controls.Add(Me.CONT_CPF_contratos_garantiasDataGridView)
        Me.Name = "frm_garantias"
        Me.Text = "Garantías"
        CType(Me.CONT_CPF_contratos_garantiasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DS_contratos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CONT_CPF_garantiasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CONT_CPF_contratos_garantiasDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DS_contratos As Fira_Cartera_Pasiva.DS_contratos
    Friend WithEvents CONT_CPF_contratos_garantiasBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CONT_CPF_contratos_garantiasTableAdapter As Fira_Cartera_Pasiva.DS_contratosTableAdapters.CONT_CPF_contratos_garantiasTableAdapter
    Friend WithEvents CONT_CPF_contratos_garantiasDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents CONT_CPF_garantiasBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CONT_CPF_garantiasTableAdapter As Fira_Cartera_Pasiva.DS_contratosTableAdapters.CONT_CPF_garantiasTableAdapter
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewCheckBoxColumn1 As System.Windows.Forms.DataGridViewCheckBoxColumn
End Class
