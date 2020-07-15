<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmImportaPagos
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.AnexoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CicloPagareDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdCreditoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ClienteDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaAplicacionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ImporteDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AdelantoDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.PagosFiraBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PagosDS = New Fira_Cartera_Pasiva.PagosDS()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.DTP_FechaFira = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PagosFiraTableAdapter = New Fira_Cartera_Pasiva.PagosDSTableAdapters.PagosFiraTableAdapter()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PagosFiraBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PagosDS, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.AnexoDataGridViewTextBoxColumn, Me.CicloPagareDataGridViewTextBoxColumn, Me.IdCreditoDataGridViewTextBoxColumn, Me.ClienteDataGridViewTextBoxColumn, Me.FechaAplicacionDataGridViewTextBoxColumn, Me.ImporteDataGridViewTextBoxColumn, Me.AdelantoDataGridViewCheckBoxColumn})
        Me.DataGridView1.DataSource = Me.PagosFiraBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(12, 12)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(838, 292)
        Me.DataGridView1.TabIndex = 0
        '
        'AnexoDataGridViewTextBoxColumn
        '
        Me.AnexoDataGridViewTextBoxColumn.DataPropertyName = "Anexo"
        Me.AnexoDataGridViewTextBoxColumn.HeaderText = "Anexo"
        Me.AnexoDataGridViewTextBoxColumn.Name = "AnexoDataGridViewTextBoxColumn"
        Me.AnexoDataGridViewTextBoxColumn.ReadOnly = True
        Me.AnexoDataGridViewTextBoxColumn.Width = 80
        '
        'CicloPagareDataGridViewTextBoxColumn
        '
        Me.CicloPagareDataGridViewTextBoxColumn.DataPropertyName = "CicloPagare"
        Me.CicloPagareDataGridViewTextBoxColumn.HeaderText = "Ciclo Pagare"
        Me.CicloPagareDataGridViewTextBoxColumn.Name = "CicloPagareDataGridViewTextBoxColumn"
        Me.CicloPagareDataGridViewTextBoxColumn.ReadOnly = True
        '
        'IdCreditoDataGridViewTextBoxColumn
        '
        Me.IdCreditoDataGridViewTextBoxColumn.DataPropertyName = "IdCredito"
        Me.IdCreditoDataGridViewTextBoxColumn.HeaderText = "Id Credito"
        Me.IdCreditoDataGridViewTextBoxColumn.Name = "IdCreditoDataGridViewTextBoxColumn"
        Me.IdCreditoDataGridViewTextBoxColumn.ReadOnly = True
        Me.IdCreditoDataGridViewTextBoxColumn.Width = 80
        '
        'ClienteDataGridViewTextBoxColumn
        '
        Me.ClienteDataGridViewTextBoxColumn.DataPropertyName = "Cliente"
        Me.ClienteDataGridViewTextBoxColumn.HeaderText = "Cliente"
        Me.ClienteDataGridViewTextBoxColumn.Name = "ClienteDataGridViewTextBoxColumn"
        Me.ClienteDataGridViewTextBoxColumn.ReadOnly = True
        Me.ClienteDataGridViewTextBoxColumn.Width = 250
        '
        'FechaAplicacionDataGridViewTextBoxColumn
        '
        Me.FechaAplicacionDataGridViewTextBoxColumn.DataPropertyName = "FechaAplicacion"
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.Format = "d"
        DataGridViewCellStyle1.NullValue = Nothing
        Me.FechaAplicacionDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle1
        Me.FechaAplicacionDataGridViewTextBoxColumn.HeaderText = "Fecha Aplicación"
        Me.FechaAplicacionDataGridViewTextBoxColumn.Name = "FechaAplicacionDataGridViewTextBoxColumn"
        Me.FechaAplicacionDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ImporteDataGridViewTextBoxColumn
        '
        Me.ImporteDataGridViewTextBoxColumn.DataPropertyName = "Importe"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle2.Format = "N2"
        DataGridViewCellStyle2.NullValue = Nothing
        Me.ImporteDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle2
        Me.ImporteDataGridViewTextBoxColumn.HeaderText = "Importe Pago"
        Me.ImporteDataGridViewTextBoxColumn.Name = "ImporteDataGridViewTextBoxColumn"
        Me.ImporteDataGridViewTextBoxColumn.ReadOnly = True
        '
        'AdelantoDataGridViewCheckBoxColumn
        '
        Me.AdelantoDataGridViewCheckBoxColumn.DataPropertyName = "Adelanto"
        Me.AdelantoDataGridViewCheckBoxColumn.HeaderText = "Adelanto"
        Me.AdelantoDataGridViewCheckBoxColumn.Name = "AdelantoDataGridViewCheckBoxColumn"
        Me.AdelantoDataGridViewCheckBoxColumn.ReadOnly = True
        Me.AdelantoDataGridViewCheckBoxColumn.Width = 70
        '
        'PagosFiraBindingSource
        '
        Me.PagosFiraBindingSource.DataMember = "PagosFira"
        Me.PagosFiraBindingSource.DataSource = Me.PagosDS
        '
        'PagosDS
        '
        Me.PagosDS.DataSetName = "PagosDS"
        Me.PagosDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(12, 306)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(108, 23)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Importar Pagos"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(587, 306)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(91, 23)
        Me.Button2.TabIndex = 2
        Me.Button2.Text = "Aplicar Pagos"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'DTP_FechaFira
        '
        Me.DTP_FechaFira.Enabled = False
        Me.DTP_FechaFira.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTP_FechaFira.Location = New System.Drawing.Point(747, 306)
        Me.DTP_FechaFira.Name = "DTP_FechaFira"
        Me.DTP_FechaFira.Size = New System.Drawing.Size(103, 20)
        Me.DTP_FechaFira.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(684, 311)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(57, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Fecha Fira"
        '
        'PagosFiraTableAdapter
        '
        Me.PagosFiraTableAdapter.ClearBeforeFill = True
        '
        'FrmImportaPagos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(861, 335)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DTP_FechaFira)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "FrmImportaPagos"
        Me.Text = "66666666666666666666t"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PagosFiraBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PagosDS, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents AnexoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CicloPagareDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents IdCreditoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ClienteDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FechaAplicacionDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ImporteDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AdelantoDataGridViewCheckBoxColumn As DataGridViewCheckBoxColumn
    Friend WithEvents PagosFiraBindingSource As BindingSource
    Friend WithEvents PagosDS As PagosDS
    Friend WithEvents PagosFiraTableAdapter As PagosDSTableAdapters.PagosFiraTableAdapter
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents DTP_FechaFira As DateTimePicker
    Friend WithEvents Label1 As Label
End Class
