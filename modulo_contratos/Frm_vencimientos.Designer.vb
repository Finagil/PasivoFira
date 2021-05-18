<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Nuevo
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Nuevo))
        Me.CONT_CPF_vencimientosDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CONT_CPF_vencimientosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DS_contratos = New Fira_Cartera_Pasiva.DS_contratos()
        Me.CONT_CPF_vencimientosTableAdapter = New Fira_Cartera_Pasiva.DS_contratosTableAdapters.CONT_CPF_vencimientosTableAdapter()
        Me.bt_agregar = New System.Windows.Forms.Button()
        CType(Me.CONT_CPF_vencimientosDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CONT_CPF_vencimientosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DS_contratos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CONT_CPF_vencimientosDataGridView
        '
        Me.CONT_CPF_vencimientosDataGridView.AllowUserToDeleteRows = False
        Me.CONT_CPF_vencimientosDataGridView.AutoGenerateColumns = False
        Me.CONT_CPF_vencimientosDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6})
        Me.CONT_CPF_vencimientosDataGridView.DataSource = Me.CONT_CPF_vencimientosBindingSource
        Me.CONT_CPF_vencimientosDataGridView.Location = New System.Drawing.Point(9, 5)
        Me.CONT_CPF_vencimientosDataGridView.Name = "CONT_CPF_vencimientosDataGridView"
        Me.CONT_CPF_vencimientosDataGridView.Size = New System.Drawing.Size(599, 179)
        Me.CONT_CPF_vencimientosDataGridView.TabIndex = 1
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "fecha"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Fecha"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "capital"
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle1.Format = "N2"
        DataGridViewCellStyle1.NullValue = Nothing
        Me.DataGridViewTextBoxColumn3.DefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridViewTextBoxColumn3.HeaderText = "Capital"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "ultimo_pago"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Ultimo Pago"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "estatus"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Estatus"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "intereses"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle2.Format = "N2"
        DataGridViewCellStyle2.NullValue = Nothing
        Me.DataGridViewTextBoxColumn6.DefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridViewTextBoxColumn6.HeaderText = "Intereses"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'CONT_CPF_vencimientosBindingSource
        '
        Me.CONT_CPF_vencimientosBindingSource.DataMember = "CONT_CPF_vencimientos"
        Me.CONT_CPF_vencimientosBindingSource.DataSource = Me.DS_contratos
        '
        'DS_contratos
        '
        Me.DS_contratos.DataSetName = "DS_contratos"
        Me.DS_contratos.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CONT_CPF_vencimientosTableAdapter
        '
        Me.CONT_CPF_vencimientosTableAdapter.ClearBeforeFill = True
        '
        'bt_agregar
        '
        Me.bt_agregar.Location = New System.Drawing.Point(527, 190)
        Me.bt_agregar.Name = "bt_agregar"
        Me.bt_agregar.Size = New System.Drawing.Size(81, 23)
        Me.bt_agregar.TabIndex = 149
        Me.bt_agregar.Text = "Agregar"
        Me.bt_agregar.UseVisualStyleBackColor = True
        '
        'Nuevo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(633, 230)
        Me.Controls.Add(Me.bt_agregar)
        Me.Controls.Add(Me.CONT_CPF_vencimientosDataGridView)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Nuevo"
        Me.Text = "Vencimientos"
        CType(Me.CONT_CPF_vencimientosDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CONT_CPF_vencimientosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DS_contratos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DS_contratos As Fira_Cartera_Pasiva.DS_contratos
    Friend WithEvents CONT_CPF_vencimientosBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CONT_CPF_vencimientosTableAdapter As Fira_Cartera_Pasiva.DS_contratosTableAdapters.CONT_CPF_vencimientosTableAdapter
    Friend WithEvents CONT_CPF_vencimientosDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents bt_agregar As Button
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
End Class
