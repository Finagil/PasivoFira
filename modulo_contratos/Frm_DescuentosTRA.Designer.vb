<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Frm_DescuentosTRA
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_DescuentosTRA))
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.AnexoConDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DescrDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MontoFinanciadoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TipoCreditoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DescuentosTRABindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DescuentosDS = New Fira_Cartera_Pasiva.DescuentosDS()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TxtAnexoCon = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtAnexo = New System.Windows.Forms.TextBox()
        Me.DescuentosTRATableAdapter = New Fira_Cartera_Pasiva.DescuentosDSTableAdapters.DescuentosTRATableAdapter()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DescuentosTRABindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DescuentosDS, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.AnexoConDataGridViewTextBoxColumn, Me.DescrDataGridViewTextBoxColumn, Me.MontoFinanciadoDataGridViewTextBoxColumn, Me.TipoCreditoDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.DescuentosTRABindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(12, 12)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(763, 354)
        Me.DataGridView1.TabIndex = 0
        '
        'AnexoConDataGridViewTextBoxColumn
        '
        Me.AnexoConDataGridViewTextBoxColumn.DataPropertyName = "AnexoCon"
        Me.AnexoConDataGridViewTextBoxColumn.HeaderText = "Anexo"
        Me.AnexoConDataGridViewTextBoxColumn.Name = "AnexoConDataGridViewTextBoxColumn"
        Me.AnexoConDataGridViewTextBoxColumn.ReadOnly = True
        '
        'DescrDataGridViewTextBoxColumn
        '
        Me.DescrDataGridViewTextBoxColumn.DataPropertyName = "Descr"
        Me.DescrDataGridViewTextBoxColumn.HeaderText = "Cliente"
        Me.DescrDataGridViewTextBoxColumn.Name = "DescrDataGridViewTextBoxColumn"
        Me.DescrDataGridViewTextBoxColumn.ReadOnly = True
        Me.DescrDataGridViewTextBoxColumn.Width = 250
        '
        'MontoFinanciadoDataGridViewTextBoxColumn
        '
        Me.MontoFinanciadoDataGridViewTextBoxColumn.DataPropertyName = "MontoFinanciado"
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle1.Format = "n2"
        Me.MontoFinanciadoDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle1
        Me.MontoFinanciadoDataGridViewTextBoxColumn.HeaderText = "Monto Financiado"
        Me.MontoFinanciadoDataGridViewTextBoxColumn.Name = "MontoFinanciadoDataGridViewTextBoxColumn"
        Me.MontoFinanciadoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'TipoCreditoDataGridViewTextBoxColumn
        '
        Me.TipoCreditoDataGridViewTextBoxColumn.DataPropertyName = "TipoCredito"
        Me.TipoCreditoDataGridViewTextBoxColumn.HeaderText = "Tipo Credito"
        Me.TipoCreditoDataGridViewTextBoxColumn.Name = "TipoCreditoDataGridViewTextBoxColumn"
        Me.TipoCreditoDataGridViewTextBoxColumn.ReadOnly = True
        Me.TipoCreditoDataGridViewTextBoxColumn.Width = 200
        '
        'DescuentosTRABindingSource
        '
        Me.DescuentosTRABindingSource.DataMember = "DescuentosTRA"
        Me.DescuentosTRABindingSource.DataSource = Me.DescuentosDS
        '
        'DescuentosDS
        '
        Me.DescuentosDS.DataSetName = "DescuentosDS"
        Me.DescuentosDS.Locale = New System.Globalization.CultureInfo("es-ES")
        Me.DescuentosDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(97, 381)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(90, 32)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "Descontar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'TxtAnexoCon
        '
        Me.TxtAnexoCon.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DescuentosTRABindingSource, "AnexoCon", True))
        Me.TxtAnexoCon.Location = New System.Drawing.Point(12, 388)
        Me.TxtAnexoCon.Name = "TxtAnexoCon"
        Me.TxtAnexoCon.ReadOnly = True
        Me.TxtAnexoCon.Size = New System.Drawing.Size(79, 20)
        Me.TxtAnexoCon.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 372)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(37, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Anexo"
        '
        'TxtAnexo
        '
        Me.TxtAnexo.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DescuentosTRABindingSource, "Anexo", True))
        Me.TxtAnexo.Location = New System.Drawing.Point(147, 383)
        Me.TxtAnexo.Name = "TxtAnexo"
        Me.TxtAnexo.ReadOnly = True
        Me.TxtAnexo.Size = New System.Drawing.Size(23, 20)
        Me.TxtAnexo.TabIndex = 7
        '
        'DescuentosTRATableAdapter
        '
        Me.DescuentosTRATableAdapter.ClearBeforeFill = True
        '
        'Frm_DescuentosTRA
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(779, 420)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TxtAnexo)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TxtAnexoCon)
        Me.Controls.Add(Me.DataGridView1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Frm_DescuentosTRA"
        Me.Text = "Descuentos Tradicionales"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DescuentosTRABindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DescuentosDS, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents TxtAnexoCon As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TxtAnexo As System.Windows.Forms.TextBox
    Friend WithEvents DescuentosDS As DescuentosDS
    Friend WithEvents DescuentosTRABindingSource As BindingSource
    Friend WithEvents DescuentosTRATableAdapter As DescuentosDSTableAdapters.DescuentosTRATableAdapter
    Friend WithEvents AnexoConDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DescrDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MontoFinanciadoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TipoCreditoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
