<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmGarantiasEjercidas
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
        Dim DataGridViewCellStyle53 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle54 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle55 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle56 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle57 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle58 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle59 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle60 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle61 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle62 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle63 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle64 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle65 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.CmbCli = New System.Windows.Forms.ComboBox()
        Me.CliGarantiasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DescuentosDS = New Fira_Cartera_Pasiva.DescuentosDS()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CliGarantiasTableAdapter = New Fira_Cartera_Pasiva.DescuentosDSTableAdapters.CliGarantiasTableAdapter()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.CicloPagare = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdcreditoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ImporteGarantiaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CapitalRecuperadoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.InteresDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CoberturanominalDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CoberturaefectivaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SaldoGarantia = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GarantiaEjercidaRESUMBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GarantiaEjercidaRESUMTableAdapter = New Fira_Cartera_Pasiva.DescuentosDSTableAdapters.GarantiaEjercidaRESUMTableAdapter()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.ImporteGarantiaDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CapitalRecuperadoDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.InteresDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TasaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaInicialDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaFinalDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaRecuperacion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SaldoGarantiaEjercidaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SaldoGarantiaEjercidaTableAdapter = New Fira_Cartera_Pasiva.DescuentosDSTableAdapters.SaldoGarantiaEjercidaTableAdapter()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TxtImporte = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.DtpRec = New System.Windows.Forms.DateTimePicker()
        Me.DtpIni = New System.Windows.Forms.DateTimePicker()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.DtpFin = New System.Windows.Forms.DateTimePicker()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TxtCoberEfect = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TxtTasa = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TxtCapital = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TxtInte = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.txt_id_sg = New System.Windows.Forms.TextBox()
        CType(Me.CliGarantiasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DescuentosDS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GarantiaEjercidaRESUMBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SaldoGarantiaEjercidaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CmbCli
        '
        Me.CmbCli.DataSource = Me.CliGarantiasBindingSource
        Me.CmbCli.DisplayMember = "Nombre"
        Me.CmbCli.FormattingEnabled = True
        Me.CmbCli.Location = New System.Drawing.Point(12, 22)
        Me.CmbCli.Name = "CmbCli"
        Me.CmbCli.Size = New System.Drawing.Size(427, 21)
        Me.CmbCli.TabIndex = 3
        Me.CmbCli.ValueMember = "Cliente"
        '
        'CliGarantiasBindingSource
        '
        Me.CliGarantiasBindingSource.DataMember = "CliGarantias"
        Me.CliGarantiasBindingSource.DataSource = Me.DescuentosDS
        '
        'DescuentosDS
        '
        Me.DescuentosDS.DataSetName = "DescuentosDS"
        Me.DescuentosDS.Locale = New System.Globalization.CultureInfo("es-ES")
        Me.DescuentosDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 5)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(179, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Clientes con Garantias (ejercercidas)"
        '
        'CliGarantiasTableAdapter
        '
        Me.CliGarantiasTableAdapter.ClearBeforeFill = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CicloPagare, Me.IdcreditoDataGridViewTextBoxColumn, Me.ImporteGarantiaDataGridViewTextBoxColumn, Me.CapitalRecuperadoDataGridViewTextBoxColumn, Me.InteresDataGridViewTextBoxColumn, Me.CoberturanominalDataGridViewTextBoxColumn, Me.CoberturaefectivaDataGridViewTextBoxColumn, Me.SaldoGarantia})
        Me.DataGridView1.DataSource = Me.GarantiaEjercidaRESUMBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(12, 49)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(713, 124)
        Me.DataGridView1.TabIndex = 4
        '
        'CicloPagare
        '
        Me.CicloPagare.DataPropertyName = "CicloPagare"
        Me.CicloPagare.HeaderText = "Ciclo Pagare"
        Me.CicloPagare.Name = "CicloPagare"
        Me.CicloPagare.ReadOnly = True
        Me.CicloPagare.Width = 90
        '
        'IdcreditoDataGridViewTextBoxColumn
        '
        Me.IdcreditoDataGridViewTextBoxColumn.DataPropertyName = "id_credito"
        Me.IdcreditoDataGridViewTextBoxColumn.HeaderText = "ID Credito"
        Me.IdcreditoDataGridViewTextBoxColumn.Name = "IdcreditoDataGridViewTextBoxColumn"
        Me.IdcreditoDataGridViewTextBoxColumn.ReadOnly = True
        Me.IdcreditoDataGridViewTextBoxColumn.Width = 70
        '
        'ImporteGarantiaDataGridViewTextBoxColumn
        '
        Me.ImporteGarantiaDataGridViewTextBoxColumn.DataPropertyName = "ImporteGarantia"
        DataGridViewCellStyle53.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle53.Format = "n2"
        Me.ImporteGarantiaDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle53
        Me.ImporteGarantiaDataGridViewTextBoxColumn.HeaderText = "Importe Garantía"
        Me.ImporteGarantiaDataGridViewTextBoxColumn.Name = "ImporteGarantiaDataGridViewTextBoxColumn"
        Me.ImporteGarantiaDataGridViewTextBoxColumn.ReadOnly = True
        Me.ImporteGarantiaDataGridViewTextBoxColumn.Width = 80
        '
        'CapitalRecuperadoDataGridViewTextBoxColumn
        '
        Me.CapitalRecuperadoDataGridViewTextBoxColumn.DataPropertyName = "CapitalRecuperado"
        DataGridViewCellStyle54.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle54.Format = "N2"
        Me.CapitalRecuperadoDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle54
        Me.CapitalRecuperadoDataGridViewTextBoxColumn.HeaderText = "Capital Recuperado"
        Me.CapitalRecuperadoDataGridViewTextBoxColumn.Name = "CapitalRecuperadoDataGridViewTextBoxColumn"
        Me.CapitalRecuperadoDataGridViewTextBoxColumn.ReadOnly = True
        Me.CapitalRecuperadoDataGridViewTextBoxColumn.Width = 80
        '
        'InteresDataGridViewTextBoxColumn
        '
        Me.InteresDataGridViewTextBoxColumn.DataPropertyName = "Interes"
        DataGridViewCellStyle55.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle55.Format = "N2"
        Me.InteresDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle55
        Me.InteresDataGridViewTextBoxColumn.HeaderText = "Interes"
        Me.InteresDataGridViewTextBoxColumn.Name = "InteresDataGridViewTextBoxColumn"
        Me.InteresDataGridViewTextBoxColumn.ReadOnly = True
        Me.InteresDataGridViewTextBoxColumn.Width = 80
        '
        'CoberturanominalDataGridViewTextBoxColumn
        '
        Me.CoberturanominalDataGridViewTextBoxColumn.DataPropertyName = "cobertura_nominal"
        DataGridViewCellStyle56.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle56.Format = "N0"
        DataGridViewCellStyle56.NullValue = Nothing
        Me.CoberturanominalDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle56
        Me.CoberturanominalDataGridViewTextBoxColumn.HeaderText = "Cob. Nominal"
        Me.CoberturanominalDataGridViewTextBoxColumn.Name = "CoberturanominalDataGridViewTextBoxColumn"
        Me.CoberturanominalDataGridViewTextBoxColumn.ReadOnly = True
        Me.CoberturanominalDataGridViewTextBoxColumn.Width = 50
        '
        'CoberturaefectivaDataGridViewTextBoxColumn
        '
        Me.CoberturaefectivaDataGridViewTextBoxColumn.DataPropertyName = "cobertura_efectiva"
        DataGridViewCellStyle57.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle57.Format = "N0"
        Me.CoberturaefectivaDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle57
        Me.CoberturaefectivaDataGridViewTextBoxColumn.HeaderText = "Cob. Efectiva"
        Me.CoberturaefectivaDataGridViewTextBoxColumn.Name = "CoberturaefectivaDataGridViewTextBoxColumn"
        Me.CoberturaefectivaDataGridViewTextBoxColumn.ReadOnly = True
        Me.CoberturaefectivaDataGridViewTextBoxColumn.Width = 50
        '
        'SaldoGarantia
        '
        Me.SaldoGarantia.DataPropertyName = "SaldoGarantia"
        DataGridViewCellStyle58.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle58.Format = "N2"
        DataGridViewCellStyle58.NullValue = Nothing
        Me.SaldoGarantia.DefaultCellStyle = DataGridViewCellStyle58
        Me.SaldoGarantia.HeaderText = "Saldo Garantía"
        Me.SaldoGarantia.Name = "SaldoGarantia"
        Me.SaldoGarantia.ReadOnly = True
        '
        'GarantiaEjercidaRESUMBindingSource
        '
        Me.GarantiaEjercidaRESUMBindingSource.DataMember = "GarantiaEjercidaRESUM"
        Me.GarantiaEjercidaRESUMBindingSource.DataSource = Me.DescuentosDS
        '
        'GarantiaEjercidaRESUMTableAdapter
        '
        Me.GarantiaEjercidaRESUMTableAdapter.ClearBeforeFill = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 176)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(45, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Detalles"
        '
        'DataGridView2
        '
        Me.DataGridView2.AllowUserToAddRows = False
        Me.DataGridView2.AllowUserToDeleteRows = False
        Me.DataGridView2.AutoGenerateColumns = False
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ImporteGarantiaDataGridViewTextBoxColumn1, Me.CapitalRecuperadoDataGridViewTextBoxColumn1, Me.InteresDataGridViewTextBoxColumn1, Me.TasaDataGridViewTextBoxColumn, Me.FechaInicialDataGridViewTextBoxColumn, Me.FechaFinalDataGridViewTextBoxColumn, Me.FechaRecuperacion})
        Me.DataGridView2.DataSource = Me.SaldoGarantiaEjercidaBindingSource
        Me.DataGridView2.Location = New System.Drawing.Point(12, 193)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.ReadOnly = True
        Me.DataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView2.Size = New System.Drawing.Size(713, 142)
        Me.DataGridView2.TabIndex = 6
        '
        'ImporteGarantiaDataGridViewTextBoxColumn1
        '
        Me.ImporteGarantiaDataGridViewTextBoxColumn1.DataPropertyName = "ImporteGarantia"
        DataGridViewCellStyle59.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle59.Format = "N2"
        DataGridViewCellStyle59.NullValue = Nothing
        Me.ImporteGarantiaDataGridViewTextBoxColumn1.DefaultCellStyle = DataGridViewCellStyle59
        Me.ImporteGarantiaDataGridViewTextBoxColumn1.HeaderText = "Importe Garantia"
        Me.ImporteGarantiaDataGridViewTextBoxColumn1.Name = "ImporteGarantiaDataGridViewTextBoxColumn1"
        Me.ImporteGarantiaDataGridViewTextBoxColumn1.ReadOnly = True
        Me.ImporteGarantiaDataGridViewTextBoxColumn1.Width = 80
        '
        'CapitalRecuperadoDataGridViewTextBoxColumn1
        '
        Me.CapitalRecuperadoDataGridViewTextBoxColumn1.DataPropertyName = "CapitalRecuperado"
        DataGridViewCellStyle60.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle60.Format = "N2"
        Me.CapitalRecuperadoDataGridViewTextBoxColumn1.DefaultCellStyle = DataGridViewCellStyle60
        Me.CapitalRecuperadoDataGridViewTextBoxColumn1.HeaderText = "Capital Recuperado"
        Me.CapitalRecuperadoDataGridViewTextBoxColumn1.Name = "CapitalRecuperadoDataGridViewTextBoxColumn1"
        Me.CapitalRecuperadoDataGridViewTextBoxColumn1.ReadOnly = True
        Me.CapitalRecuperadoDataGridViewTextBoxColumn1.Width = 80
        '
        'InteresDataGridViewTextBoxColumn1
        '
        Me.InteresDataGridViewTextBoxColumn1.DataPropertyName = "Interes"
        DataGridViewCellStyle61.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle61.Format = "N2"
        Me.InteresDataGridViewTextBoxColumn1.DefaultCellStyle = DataGridViewCellStyle61
        Me.InteresDataGridViewTextBoxColumn1.HeaderText = "Intereses"
        Me.InteresDataGridViewTextBoxColumn1.Name = "InteresDataGridViewTextBoxColumn1"
        Me.InteresDataGridViewTextBoxColumn1.ReadOnly = True
        '
        'TasaDataGridViewTextBoxColumn
        '
        Me.TasaDataGridViewTextBoxColumn.DataPropertyName = "Tasa"
        DataGridViewCellStyle62.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle62.Format = "N4"
        DataGridViewCellStyle62.NullValue = Nothing
        Me.TasaDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle62
        Me.TasaDataGridViewTextBoxColumn.HeaderText = "Tasa Inte."
        Me.TasaDataGridViewTextBoxColumn.Name = "TasaDataGridViewTextBoxColumn"
        Me.TasaDataGridViewTextBoxColumn.ReadOnly = True
        '
        'FechaInicialDataGridViewTextBoxColumn
        '
        Me.FechaInicialDataGridViewTextBoxColumn.DataPropertyName = "FechaInicial"
        DataGridViewCellStyle63.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle63.Format = "d"
        DataGridViewCellStyle63.NullValue = Nothing
        Me.FechaInicialDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle63
        Me.FechaInicialDataGridViewTextBoxColumn.HeaderText = "Fecha Inicial"
        Me.FechaInicialDataGridViewTextBoxColumn.Name = "FechaInicialDataGridViewTextBoxColumn"
        Me.FechaInicialDataGridViewTextBoxColumn.ReadOnly = True
        Me.FechaInicialDataGridViewTextBoxColumn.Width = 80
        '
        'FechaFinalDataGridViewTextBoxColumn
        '
        Me.FechaFinalDataGridViewTextBoxColumn.DataPropertyName = "FechaFinal"
        DataGridViewCellStyle64.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle64.Format = "d"
        Me.FechaFinalDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle64
        Me.FechaFinalDataGridViewTextBoxColumn.HeaderText = "Fecha Final"
        Me.FechaFinalDataGridViewTextBoxColumn.Name = "FechaFinalDataGridViewTextBoxColumn"
        Me.FechaFinalDataGridViewTextBoxColumn.ReadOnly = True
        Me.FechaFinalDataGridViewTextBoxColumn.Width = 80
        '
        'FechaRecuperacion
        '
        Me.FechaRecuperacion.DataPropertyName = "FechaRecuperacion"
        DataGridViewCellStyle65.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle65.Format = "d"
        DataGridViewCellStyle65.NullValue = Nothing
        Me.FechaRecuperacion.DefaultCellStyle = DataGridViewCellStyle65
        Me.FechaRecuperacion.HeaderText = "Fecha de Recuperación"
        Me.FechaRecuperacion.Name = "FechaRecuperacion"
        Me.FechaRecuperacion.ReadOnly = True
        Me.FechaRecuperacion.Width = 80
        '
        'SaldoGarantiaEjercidaBindingSource
        '
        Me.SaldoGarantiaEjercidaBindingSource.DataMember = "SaldoGarantiaEjercida"
        Me.SaldoGarantiaEjercidaBindingSource.DataSource = Me.DescuentosDS
        '
        'SaldoGarantiaEjercidaTableAdapter
        '
        Me.SaldoGarantiaEjercidaTableAdapter.ClearBeforeFill = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 343)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(104, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Total Recuperación "
        '
        'TxtImporte
        '
        Me.TxtImporte.Location = New System.Drawing.Point(13, 359)
        Me.TxtImporte.Name = "TxtImporte"
        Me.TxtImporte.Size = New System.Drawing.Size(100, 20)
        Me.TxtImporte.TabIndex = 8
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(119, 343)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(98, 13)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Fec. Recuperación"
        '
        'DtpRec
        '
        Me.DtpRec.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtpRec.Location = New System.Drawing.Point(122, 358)
        Me.DtpRec.Name = "DtpRec"
        Me.DtpRec.Size = New System.Drawing.Size(95, 20)
        Me.DtpRec.TabIndex = 10
        '
        'DtpIni
        '
        Me.DtpIni.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.GarantiaEjercidaRESUMBindingSource, "FechaFinal", True))
        Me.DtpIni.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtpIni.Location = New System.Drawing.Point(223, 359)
        Me.DtpIni.Name = "DtpIni"
        Me.DtpIni.Size = New System.Drawing.Size(95, 20)
        Me.DtpIni.TabIndex = 12
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(220, 344)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(58, 13)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Fec. Inicial"
        '
        'DtpFin
        '
        Me.DtpFin.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtpFin.Location = New System.Drawing.Point(324, 359)
        Me.DtpFin.Name = "DtpFin"
        Me.DtpFin.Size = New System.Drawing.Size(95, 20)
        Me.DtpFin.TabIndex = 14
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(321, 344)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(53, 13)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "Fec. Final"
        '
        'TxtCoberEfect
        '
        Me.TxtCoberEfect.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.GarantiaEjercidaRESUMBindingSource, "cobertura_efectiva", True, System.Windows.Forms.DataSourceUpdateMode.OnValidation, Nothing, "N2"))
        Me.TxtCoberEfect.Location = New System.Drawing.Point(425, 360)
        Me.TxtCoberEfect.Name = "TxtCoberEfect"
        Me.TxtCoberEfect.ReadOnly = True
        Me.TxtCoberEfect.Size = New System.Drawing.Size(39, 20)
        Me.TxtCoberEfect.TabIndex = 16
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(424, 344)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(40, 13)
        Me.Label7.TabIndex = 15
        Me.Label7.Text = "%Efec."
        '
        'TxtTasa
        '
        Me.TxtTasa.Location = New System.Drawing.Point(471, 360)
        Me.TxtTasa.MaxLength = 7
        Me.TxtTasa.Name = "TxtTasa"
        Me.TxtTasa.Size = New System.Drawing.Size(55, 20)
        Me.TxtTasa.TabIndex = 18
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(470, 344)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(42, 13)
        Me.Label8.TabIndex = 17
        Me.Label8.Text = "Tasa %"
        '
        'TxtCapital
        '
        Me.TxtCapital.Location = New System.Drawing.Point(531, 360)
        Me.TxtCapital.Name = "TxtCapital"
        Me.TxtCapital.Size = New System.Drawing.Size(100, 20)
        Me.TxtCapital.TabIndex = 20
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(530, 344)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(39, 13)
        Me.Label9.TabIndex = 19
        Me.Label9.Text = "Capital"
        '
        'TxtInte
        '
        Me.TxtInte.Location = New System.Drawing.Point(637, 359)
        Me.TxtInte.Name = "TxtInte"
        Me.TxtInte.Size = New System.Drawing.Size(88, 20)
        Me.TxtInte.TabIndex = 22
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(636, 343)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(83, 13)
        Me.Label10.TabIndex = 21
        Me.Label10.Text = "Interes para Fira"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(637, 385)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(88, 23)
        Me.Button1.TabIndex = 23
        Me.Button1.Text = "Agregar Pago"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(12, 385)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(88, 23)
        Me.Button2.TabIndex = 24
        Me.Button2.Text = "Imprimir Pago"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'txt_id_sg
        '
        Me.txt_id_sg.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SaldoGarantiaEjercidaBindingSource, "id_SaldoGarantia", True))
        Me.txt_id_sg.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txt_id_sg.Location = New System.Drawing.Point(639, 253)
        Me.txt_id_sg.Name = "txt_id_sg"
        Me.txt_id_sg.ReadOnly = True
        Me.txt_id_sg.Size = New System.Drawing.Size(88, 20)
        Me.txt_id_sg.TabIndex = 25
        '
        'FrmGarantiasEjercidas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(730, 415)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TxtInte)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.TxtCapital)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.TxtTasa)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.TxtCoberEfect)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.DtpFin)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.DtpIni)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.DtpRec)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TxtImporte)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.DataGridView2)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.CmbCli)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txt_id_sg)
        Me.Name = "FrmGarantiasEjercidas"
        Me.Text = "Garantias Ejercidas (Saldos)"
        CType(Me.CliGarantiasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DescuentosDS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GarantiaEjercidaRESUMBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SaldoGarantiaEjercidaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents CmbCli As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DescuentosDS As Fira_Cartera_Pasiva.DescuentosDS
    Friend WithEvents CliGarantiasBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CliGarantiasTableAdapter As Fira_Cartera_Pasiva.DescuentosDSTableAdapters.CliGarantiasTableAdapter
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents GarantiaEjercidaRESUMBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents GarantiaEjercidaRESUMTableAdapter As Fira_Cartera_Pasiva.DescuentosDSTableAdapters.GarantiaEjercidaRESUMTableAdapter
    Friend WithEvents AnexoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents DataGridView2 As System.Windows.Forms.DataGridView
    Friend WithEvents SaldoGarantiaEjercidaBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SaldoGarantiaEjercidaTableAdapter As Fira_Cartera_Pasiva.DescuentosDSTableAdapters.SaldoGarantiaEjercidaTableAdapter
    Friend WithEvents ImporteGarantiaDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CapitalRecuperadoDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents InteresDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TasaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FechaInicialDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FechaFinalDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FechaRecuperacion As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TxtImporte As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents DtpRec As System.Windows.Forms.DateTimePicker
    Friend WithEvents DtpIni As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents DtpFin As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents TxtCoberEfect As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents TxtTasa As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents TxtCapital As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents TxtInte As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents CicloPagare As DataGridViewTextBoxColumn
    Friend WithEvents IdcreditoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ImporteGarantiaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CapitalRecuperadoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents InteresDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CoberturanominalDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CoberturaefectivaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SaldoGarantia As DataGridViewTextBoxColumn
    Friend WithEvents txt_id_sg As TextBox
End Class
