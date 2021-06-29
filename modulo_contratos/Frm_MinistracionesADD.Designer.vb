<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Frm_MinistracionesADD
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
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_MinistracionesADD))
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
        Me.MinistracionesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DescuentosDS = New Fira_Cartera_Pasiva.DescuentosDS()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TxtAnexoCon = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtCicloPago = New System.Windows.Forms.TextBox()
        Me.dt_descuento = New System.Windows.Forms.DateTimePicker()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txt_importe = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TXT_IVA = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_porcentaje = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.dt_solicitud = New System.Windows.Forms.DateTimePicker()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txt_monto = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.LbFec = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.CONTCPFcontratosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DS_contratos = New Fira_Cartera_Pasiva.DS_contratos()
        Me.TxttasaFira = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.MinistracionesTableAdapter = New Fira_Cartera_Pasiva.DescuentosDSTableAdapters.MinistracionesTableAdapter()
        Me.CONT_CPF_contratosTableAdapter = New Fira_Cartera_Pasiva.DS_contratosTableAdapters.CONT_CPF_contratosTableAdapter()
        Me.TIIEBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TIIETableAdapter = New Fira_Cartera_Pasiva.DescuentosDSTableAdapters.TIIETableAdapter()
        Me.PagosDS = New Fira_Cartera_Pasiva.PagosDS()
        Me.GENComandosCMDBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GEN_ComandosCMDTableAdapter = New Fira_Cartera_Pasiva.PagosDSTableAdapters.GEN_ComandosCMDTableAdapter()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MinistracionesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DescuentosDS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CONTCPFcontratosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DS_contratos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TIIEBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PagosDS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GENComandosCMDBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.AnexoDataGridViewTextBoxColumn, Me.CicloDataGridViewTextBoxColumn, Me.AnexoConDataGridViewTextBoxColumn, Me.CicloPagareDataGridViewTextBoxColumn, Me.DescrDataGridViewTextBoxColumn, Me.ImporteDataGridViewTextBoxColumn, Me.MinistracionDataGridViewTextBoxColumn, Me.IdcontratoDataGridViewTextBoxColumn, Me.FechaPagoDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.MinistracionesBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(12, 12)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(763, 354)
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
        'MinistracionesBindingSource
        '
        Me.MinistracionesBindingSource.DataMember = "Ministraciones"
        Me.MinistracionesBindingSource.DataSource = Me.DescuentosDS
        '
        'DescuentosDS
        '
        Me.DescuentosDS.DataSetName = "DescuentosDS"
        Me.DescuentosDS.Locale = New System.Globalization.CultureInfo("es-ES")
        Me.DescuentosDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(685, 409)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(90, 32)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "Ministrar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'TxtAnexoCon
        '
        Me.TxtAnexoCon.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MinistracionesBindingSource, "AnexoCon", True))
        Me.TxtAnexoCon.Location = New System.Drawing.Point(15, 388)
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
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(97, 372)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(55, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Ciclo Pag."
        '
        'txtCicloPago
        '
        Me.txtCicloPago.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MinistracionesBindingSource, "CicloPagare", True))
        Me.txtCicloPago.Location = New System.Drawing.Point(97, 388)
        Me.txtCicloPago.Name = "txtCicloPago"
        Me.txtCicloPago.ReadOnly = True
        Me.txtCicloPago.Size = New System.Drawing.Size(100, 20)
        Me.txtCicloPago.TabIndex = 2
        '
        'dt_descuento
        '
        Me.dt_descuento.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dt_descuento.Location = New System.Drawing.Point(415, 387)
        Me.dt_descuento.Name = "dt_descuento"
        Me.dt_descuento.Size = New System.Drawing.Size(99, 20)
        Me.dt_descuento.TabIndex = 32
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(412, 369)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(92, 13)
        Me.Label7.TabIndex = 31
        Me.Label7.Text = "Fecha Descuento"
        '
        'txt_importe
        '
        Me.txt_importe.Location = New System.Drawing.Point(565, 387)
        Me.txt_importe.Name = "txt_importe"
        Me.txt_importe.ReadOnly = True
        Me.txt_importe.Size = New System.Drawing.Size(100, 20)
        Me.txt_importe.TabIndex = 28
        Me.txt_importe.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(565, 371)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(42, 13)
        Me.Label5.TabIndex = 27
        Me.Label5.Text = "Importe"
        '
        'TXT_IVA
        '
        Me.TXT_IVA.Location = New System.Drawing.Point(671, 387)
        Me.TXT_IVA.Name = "TXT_IVA"
        Me.TXT_IVA.ReadOnly = True
        Me.TXT_IVA.Size = New System.Drawing.Size(100, 20)
        Me.TXT_IVA.TabIndex = 26
        Me.TXT_IVA.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(668, 371)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(24, 13)
        Me.Label4.TabIndex = 25
        Me.Label4.Text = "IVA"
        '
        'txt_porcentaje
        '
        Me.txt_porcentaje.Location = New System.Drawing.Point(520, 387)
        Me.txt_porcentaje.Name = "txt_porcentaje"
        Me.txt_porcentaje.ReadOnly = True
        Me.txt_porcentaje.Size = New System.Drawing.Size(39, 20)
        Me.txt_porcentaje.TabIndex = 24
        Me.txt_porcentaje.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(520, 371)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(39, 13)
        Me.Label3.TabIndex = 23
        Me.Label3.Text = "% CXS"
        '
        'dt_solicitud
        '
        Me.dt_solicitud.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.MinistracionesBindingSource, "FechaPago", True))
        Me.dt_solicitud.Enabled = False
        Me.dt_solicitud.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dt_solicitud.Location = New System.Drawing.Point(309, 387)
        Me.dt_solicitud.Name = "dt_solicitud"
        Me.dt_solicitud.Size = New System.Drawing.Size(100, 20)
        Me.dt_solicitud.TabIndex = 22
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(312, 371)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(80, 13)
        Me.Label9.TabIndex = 21
        Me.Label9.Text = "Fecha Solicitud"
        '
        'txt_monto
        '
        Me.txt_monto.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MinistracionesBindingSource, "Importe", True, System.Windows.Forms.DataSourceUpdateMode.OnValidation, Nothing, "N2"))
        Me.txt_monto.Location = New System.Drawing.Point(203, 388)
        Me.txt_monto.Name = "txt_monto"
        Me.txt_monto.ReadOnly = True
        Me.txt_monto.Size = New System.Drawing.Size(100, 20)
        Me.txt_monto.TabIndex = 20
        Me.txt_monto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(200, 372)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(37, 13)
        Me.Label10.TabIndex = 19
        Me.Label10.Text = "Monto"
        '
        'LbFec
        '
        Me.LbFec.AutoSize = True
        Me.LbFec.Location = New System.Drawing.Point(12, 431)
        Me.LbFec.Name = "LbFec"
        Me.LbFec.Size = New System.Drawing.Size(10, 13)
        Me.LbFec.TabIndex = 33
        Me.LbFec.Text = "."
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(761, 372)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(10, 13)
        Me.Label6.TabIndex = 34
        Me.Label6.Text = "."
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.CONTCPFcontratosBindingSource, "subsidio", True))
        Me.CheckBox1.Location = New System.Drawing.Point(15, 411)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(129, 17)
        Me.CheckBox1.TabIndex = 35
        Me.CheckBox1.Text = "Subsidio por localidad"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'CONTCPFcontratosBindingSource
        '
        Me.CONTCPFcontratosBindingSource.DataMember = "CONT_CPF_contratos"
        Me.CONTCPFcontratosBindingSource.DataSource = Me.DS_contratos
        '
        'DS_contratos
        '
        Me.DS_contratos.DataSetName = "DS_contratos"
        Me.DS_contratos.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TxttasaFira
        '
        Me.TxttasaFira.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MinistracionesBindingSource, "TiieActiva", True, System.Windows.Forms.DataSourceUpdateMode.OnValidation, Nothing, "N4"))
        Me.TxttasaFira.Location = New System.Drawing.Point(568, 427)
        Me.TxttasaFira.Name = "TxttasaFira"
        Me.TxttasaFira.ReadOnly = True
        Me.TxttasaFira.Size = New System.Drawing.Size(100, 20)
        Me.TxttasaFira.TabIndex = 37
        Me.TxttasaFira.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(565, 411)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(95, 13)
        Me.Label8.TabIndex = 36
        Me.Label8.Text = "Tasa Fira Cotizada"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(150, 413)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(125, 25)
        Me.Button2.TabIndex = 38
        Me.Button2.Text = "Cambiar Subsidio"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'MinistracionesTableAdapter
        '
        Me.MinistracionesTableAdapter.ClearBeforeFill = True
        '
        'CONT_CPF_contratosTableAdapter
        '
        Me.CONT_CPF_contratosTableAdapter.ClearBeforeFill = True
        '
        'TIIEBindingSource
        '
        Me.TIIEBindingSource.DataMember = "TIIE"
        Me.TIIEBindingSource.DataSource = Me.DescuentosDS
        '
        'TIIETableAdapter
        '
        Me.TIIETableAdapter.ClearBeforeFill = True
        '
        'PagosDS
        '
        Me.PagosDS.DataSetName = "PagosDS"
        Me.PagosDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GENComandosCMDBindingSource
        '
        Me.GENComandosCMDBindingSource.DataMember = "GEN_ComandosCMD"
        Me.GENComandosCMDBindingSource.DataSource = Me.PagosDS
        '
        'GEN_ComandosCMDTableAdapter
        '
        Me.GEN_ComandosCMDTableAdapter.ClearBeforeFill = True
        '
        'Frm_MinistracionesADD
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(786, 453)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.TxttasaFira)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.LbFec)
        Me.Controls.Add(Me.TxtAnexoCon)
        Me.Controls.Add(Me.dt_descuento)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txt_importe)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.TXT_IVA)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txt_porcentaje)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.dt_solicitud)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txt_monto)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtCicloPago)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Frm_MinistracionesADD"
        Me.Text = "Agregar Ministraciones"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MinistracionesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DescuentosDS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CONTCPFcontratosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DS_contratos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TIIEBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PagosDS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GENComandosCMDBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents DescuentosDS As Fira_Cartera_Pasiva.DescuentosDS
    Friend WithEvents MinistracionesBindingSource As System.Windows.Forms.BindingSource
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
    Friend WithEvents MinistracionesTableAdapter As Fira_Cartera_Pasiva.DescuentosDSTableAdapters.MinistracionesTableAdapter
    Friend WithEvents dt_descuento As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txt_importe As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents TXT_IVA As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txt_porcentaje As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents dt_solicitud As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txt_monto As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents LbFec As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents TxttasaFira As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents DS_contratos As DS_contratos
    Friend WithEvents CONTCPFcontratosBindingSource As BindingSource
    Friend WithEvents CONT_CPF_contratosTableAdapter As DS_contratosTableAdapters.CONT_CPF_contratosTableAdapter
    Friend WithEvents TIIEBindingSource As BindingSource
    Friend WithEvents TIIETableAdapter As DescuentosDSTableAdapters.TIIETableAdapter
    Friend WithEvents PagosDS As PagosDS
    Friend WithEvents GENComandosCMDBindingSource As BindingSource
    Friend WithEvents GEN_ComandosCMDTableAdapter As PagosDSTableAdapters.GEN_ComandosCMDTableAdapter
End Class
