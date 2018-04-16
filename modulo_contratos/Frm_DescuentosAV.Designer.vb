<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_DescuentosAV
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
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.AnexoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CicloDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AnexoConDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CicloPagareDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DescrDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ImporteDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MinistracionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdcontratoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaPagoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DescuentosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DescuentosDS = New Fira_Cartera_Pasiva.DescuentosDS()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TxtAnexoCon = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtCicloPago = New System.Windows.Forms.TextBox()
        Me.TxtCiclo = New System.Windows.Forms.TextBox()
        Me.TxtAnexo = New System.Windows.Forms.TextBox()
        Me.DescuentosTableAdapter = New Fira_Cartera_Pasiva.DescuentosDSTableAdapters.DescuentosTableAdapter()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DescuentosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DescuentosDS, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.AnexoDataGridViewTextBoxColumn, Me.CicloDataGridViewTextBoxColumn, Me.AnexoConDataGridViewTextBoxColumn, Me.CicloPagareDataGridViewTextBoxColumn, Me.DescrDataGridViewTextBoxColumn, Me.ImporteDataGridViewTextBoxColumn, Me.MinistracionDataGridViewTextBoxColumn, Me.IdcontratoDataGridViewTextBoxColumn, Me.FechaPagoDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.DescuentosBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(12, 12)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(763, 385)
        Me.DataGridView1.TabIndex = 0
        '
        'AnexoDataGridViewTextBoxColumn
        '
        Me.AnexoDataGridViewTextBoxColumn.DataPropertyName = "Anexo"
        Me.AnexoDataGridViewTextBoxColumn.HeaderText = "Anexo"
        Me.AnexoDataGridViewTextBoxColumn.Name = "AnexoDataGridViewTextBoxColumn"
        Me.AnexoDataGridViewTextBoxColumn.ReadOnly = True
        Me.AnexoDataGridViewTextBoxColumn.Visible = False
        Me.AnexoDataGridViewTextBoxColumn.Width = 80
        '
        'CicloDataGridViewTextBoxColumn
        '
        Me.CicloDataGridViewTextBoxColumn.DataPropertyName = "Ciclo"
        Me.CicloDataGridViewTextBoxColumn.HeaderText = "Ciclo"
        Me.CicloDataGridViewTextBoxColumn.Name = "CicloDataGridViewTextBoxColumn"
        Me.CicloDataGridViewTextBoxColumn.ReadOnly = True
        Me.CicloDataGridViewTextBoxColumn.Visible = False
        '
        'AnexoConDataGridViewTextBoxColumn
        '
        Me.AnexoConDataGridViewTextBoxColumn.DataPropertyName = "AnexoCon"
        Me.AnexoConDataGridViewTextBoxColumn.HeaderText = "Anexo"
        Me.AnexoConDataGridViewTextBoxColumn.Name = "AnexoConDataGridViewTextBoxColumn"
        Me.AnexoConDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CicloPagareDataGridViewTextBoxColumn
        '
        Me.CicloPagareDataGridViewTextBoxColumn.DataPropertyName = "CicloPagare"
        Me.CicloPagareDataGridViewTextBoxColumn.HeaderText = "Ciclo Pagare"
        Me.CicloPagareDataGridViewTextBoxColumn.Name = "CicloPagareDataGridViewTextBoxColumn"
        Me.CicloPagareDataGridViewTextBoxColumn.ReadOnly = True
        '
        'DescrDataGridViewTextBoxColumn
        '
        Me.DescrDataGridViewTextBoxColumn.DataPropertyName = "Descr"
        Me.DescrDataGridViewTextBoxColumn.HeaderText = "Cliente"
        Me.DescrDataGridViewTextBoxColumn.Name = "DescrDataGridViewTextBoxColumn"
        Me.DescrDataGridViewTextBoxColumn.ReadOnly = True
        Me.DescrDataGridViewTextBoxColumn.Width = 300
        '
        'ImporteDataGridViewTextBoxColumn
        '
        Me.ImporteDataGridViewTextBoxColumn.DataPropertyName = "Importe"
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle1.Format = "N2"
        DataGridViewCellStyle1.NullValue = Nothing
        Me.ImporteDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle1
        Me.ImporteDataGridViewTextBoxColumn.HeaderText = "Importe"
        Me.ImporteDataGridViewTextBoxColumn.Name = "ImporteDataGridViewTextBoxColumn"
        Me.ImporteDataGridViewTextBoxColumn.ReadOnly = True
        '
        'MinistracionDataGridViewTextBoxColumn
        '
        Me.MinistracionDataGridViewTextBoxColumn.DataPropertyName = "Ministracion"
        Me.MinistracionDataGridViewTextBoxColumn.HeaderText = "Ministracion"
        Me.MinistracionDataGridViewTextBoxColumn.Name = "MinistracionDataGridViewTextBoxColumn"
        Me.MinistracionDataGridViewTextBoxColumn.ReadOnly = True
        Me.MinistracionDataGridViewTextBoxColumn.Visible = False
        '
        'IdcontratoDataGridViewTextBoxColumn
        '
        Me.IdcontratoDataGridViewTextBoxColumn.DataPropertyName = "id_contrato"
        Me.IdcontratoDataGridViewTextBoxColumn.HeaderText = "id_contrato"
        Me.IdcontratoDataGridViewTextBoxColumn.Name = "IdcontratoDataGridViewTextBoxColumn"
        Me.IdcontratoDataGridViewTextBoxColumn.ReadOnly = True
        Me.IdcontratoDataGridViewTextBoxColumn.Visible = False
        '
        'FechaPagoDataGridViewTextBoxColumn
        '
        Me.FechaPagoDataGridViewTextBoxColumn.DataPropertyName = "FechaPago"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.Format = "d"
        DataGridViewCellStyle2.NullValue = Nothing
        Me.FechaPagoDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle2
        Me.FechaPagoDataGridViewTextBoxColumn.HeaderText = "Fecha de Pago"
        Me.FechaPagoDataGridViewTextBoxColumn.Name = "FechaPagoDataGridViewTextBoxColumn"
        Me.FechaPagoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'DescuentosBindingSource
        '
        Me.DescuentosBindingSource.DataMember = "Descuentos"
        Me.DescuentosBindingSource.DataSource = Me.DescuentosDS
        '
        'DescuentosDS
        '
        Me.DescuentosDS.DataSetName = "DescuentosDS"
        Me.DescuentosDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(209, 445)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(90, 32)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "Descontar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'TxtAnexoCon
        '
        Me.TxtAnexoCon.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DescuentosBindingSource, "AnexoCon", True))
        Me.TxtAnexoCon.Location = New System.Drawing.Point(18, 452)
        Me.TxtAnexoCon.Name = "TxtAnexoCon"
        Me.TxtAnexoCon.ReadOnly = True
        Me.TxtAnexoCon.Size = New System.Drawing.Size(79, 20)
        Me.TxtAnexoCon.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(18, 436)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(37, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Anexo"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(103, 436)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(55, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Ciclo Pag."
        '
        'txtCicloPago
        '
        Me.txtCicloPago.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DescuentosBindingSource, "CicloPagare", True))
        Me.txtCicloPago.Location = New System.Drawing.Point(103, 452)
        Me.txtCicloPago.Name = "txtCicloPago"
        Me.txtCicloPago.ReadOnly = True
        Me.txtCicloPago.Size = New System.Drawing.Size(100, 20)
        Me.txtCicloPago.TabIndex = 2
        '
        'TxtCiclo
        '
        Me.TxtCiclo.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DescuentosBindingSource, "Ciclo", True))
        Me.TxtCiclo.Location = New System.Drawing.Point(219, 452)
        Me.TxtCiclo.Name = "TxtCiclo"
        Me.TxtCiclo.ReadOnly = True
        Me.TxtCiclo.Size = New System.Drawing.Size(23, 20)
        Me.TxtCiclo.TabIndex = 6
        '
        'TxtAnexo
        '
        Me.TxtAnexo.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DescuentosBindingSource, "Anexo", True))
        Me.TxtAnexo.Location = New System.Drawing.Point(248, 452)
        Me.TxtAnexo.Name = "TxtAnexo"
        Me.TxtAnexo.ReadOnly = True
        Me.TxtAnexo.Size = New System.Drawing.Size(23, 20)
        Me.TxtAnexo.TabIndex = 7
        '
        'DescuentosTableAdapter
        '
        Me.DescuentosTableAdapter.ClearBeforeFill = True
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Checked = True
        Me.CheckBox1.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBox1.Location = New System.Drawing.Point(690, 436)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(91, 17)
        Me.CheckBox1.TabIndex = 8
        Me.CheckBox1.Text = "Recursos Fira"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'Frm_DescuentosAV
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(796, 493)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TxtAnexo)
        Me.Controls.Add(Me.TxtCiclo)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtCicloPago)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TxtAnexoCon)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "Frm_DescuentosAV"
        Me.Text = "Descuentos Avío y Cuenta Corriente"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DescuentosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DescuentosDS, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents DescuentosDS As Fira_Cartera_Pasiva.DescuentosDS
    Friend WithEvents DescuentosBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DescuentosTableAdapter As Fira_Cartera_Pasiva.DescuentosDSTableAdapters.DescuentosTableAdapter
    Friend WithEvents AnexoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CicloDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AnexoConDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CicloPagareDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DescrDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ImporteDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MinistracionDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IdcontratoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FechaPagoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents TxtAnexoCon As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtCicloPago As System.Windows.Forms.TextBox
    Friend WithEvents TxtCiclo As System.Windows.Forms.TextBox
    Friend WithEvents TxtAnexo As System.Windows.Forms.TextBox
    Friend WithEvents CheckBox1 As CheckBox
End Class
