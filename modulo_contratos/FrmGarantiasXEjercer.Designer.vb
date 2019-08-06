<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmGarantiasXEjercer
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CmbCli = New System.Windows.Forms.ComboBox()
        Me.CliGarantiasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DescuentosDS = New Fira_Cartera_Pasiva.DescuentosDS()
        Me.CliGarantiasTableAdapter = New Fira_Cartera_Pasiva.DescuentosDSTableAdapters.CliGarantiasTableAdapter()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.AnexoConDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CicloPagareDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SaldocontingenteDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.id_credito = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GarantiasEjerBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GarantiasEjerTableAdapter = New Fira_Cartera_Pasiva.DescuentosDSTableAdapters.GarantiasEjerTableAdapter()
        Me.BtnEjercer = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtSaldo = New System.Windows.Forms.TextBox()
        Me.Texgar = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Txtnom = New System.Windows.Forms.TextBox()
        Me.CONTCPFcontratosgarantiasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DS_contratos = New Fira_Cartera_Pasiva.DS_contratos()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Txtefec = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.txtmonto = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.CONT_CPF_contratos_garantiasTableAdapter = New Fira_Cartera_Pasiva.DS_contratosTableAdapters.CONT_CPF_contratos_garantiasTableAdapter()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.ch_fonaga = New System.Windows.Forms.CheckBox()
        Me.CONTCPFgarantiasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CONT_CPF_garantiasTableAdapter = New Fira_Cartera_Pasiva.DS_contratosTableAdapters.CONT_CPF_garantiasTableAdapter()
        Me.DTFecha = New System.Windows.Forms.DateTimePicker()
        Me.Label7 = New System.Windows.Forms.Label()
        CType(Me.CliGarantiasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DescuentosDS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GarantiasEjerBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CONTCPFcontratosgarantiasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DS_contratos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CONTCPFgarantiasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(172, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Clientes con Garantias (por ejercer)"
        '
        'CmbCli
        '
        Me.CmbCli.DataSource = Me.CliGarantiasBindingSource
        Me.CmbCli.DisplayMember = "Nombre"
        Me.CmbCli.FormattingEnabled = True
        Me.CmbCli.Location = New System.Drawing.Point(16, 30)
        Me.CmbCli.Name = "CmbCli"
        Me.CmbCli.Size = New System.Drawing.Size(427, 21)
        Me.CmbCli.TabIndex = 1
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
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.AnexoConDataGridViewTextBoxColumn, Me.CicloPagareDataGridViewTextBoxColumn, Me.SaldocontingenteDataGridViewTextBoxColumn, Me.id_credito})
        Me.DataGridView1.DataSource = Me.GarantiasEjerBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(16, 58)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(427, 129)
        Me.DataGridView1.TabIndex = 2
        '
        'AnexoConDataGridViewTextBoxColumn
        '
        Me.AnexoConDataGridViewTextBoxColumn.DataPropertyName = "AnexoCon"
        Me.AnexoConDataGridViewTextBoxColumn.HeaderText = "Anexo"
        Me.AnexoConDataGridViewTextBoxColumn.Name = "AnexoConDataGridViewTextBoxColumn"
        Me.AnexoConDataGridViewTextBoxColumn.ReadOnly = True
        Me.AnexoConDataGridViewTextBoxColumn.Width = 80
        '
        'CicloPagareDataGridViewTextBoxColumn
        '
        Me.CicloPagareDataGridViewTextBoxColumn.DataPropertyName = "CicloPagare"
        Me.CicloPagareDataGridViewTextBoxColumn.HeaderText = "Ciclo Pagare"
        Me.CicloPagareDataGridViewTextBoxColumn.Name = "CicloPagareDataGridViewTextBoxColumn"
        Me.CicloPagareDataGridViewTextBoxColumn.ReadOnly = True
        Me.CicloPagareDataGridViewTextBoxColumn.Width = 80
        '
        'SaldocontingenteDataGridViewTextBoxColumn
        '
        Me.SaldocontingenteDataGridViewTextBoxColumn.DataPropertyName = "saldo_contingente"
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle1.Format = "N2"
        DataGridViewCellStyle1.NullValue = Nothing
        Me.SaldocontingenteDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle1
        Me.SaldocontingenteDataGridViewTextBoxColumn.HeaderText = "Saldo Contingente"
        Me.SaldocontingenteDataGridViewTextBoxColumn.Name = "SaldocontingenteDataGridViewTextBoxColumn"
        Me.SaldocontingenteDataGridViewTextBoxColumn.ReadOnly = True
        '
        'id_credito
        '
        Me.id_credito.DataPropertyName = "id_credito"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.id_credito.DefaultCellStyle = DataGridViewCellStyle2
        Me.id_credito.HeaderText = "ID Credito"
        Me.id_credito.Name = "id_credito"
        Me.id_credito.ReadOnly = True
        '
        'GarantiasEjerBindingSource
        '
        Me.GarantiasEjerBindingSource.DataMember = "GarantiasEjer"
        Me.GarantiasEjerBindingSource.DataSource = Me.DescuentosDS
        '
        'GarantiasEjerTableAdapter
        '
        Me.GarantiasEjerTableAdapter.ClearBeforeFill = True
        '
        'BtnEjercer
        '
        Me.BtnEjercer.Location = New System.Drawing.Point(368, 197)
        Me.BtnEjercer.Name = "BtnEjercer"
        Me.BtnEjercer.Size = New System.Drawing.Size(75, 23)
        Me.BtnEjercer.TabIndex = 3
        Me.BtnEjercer.Text = "Ejercer Gar."
        Me.BtnEjercer.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(487, 58)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(110, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Monto Incumplimiento"
        '
        'TxtSaldo
        '
        Me.TxtSaldo.Location = New System.Drawing.Point(602, 51)
        Me.TxtSaldo.Name = "TxtSaldo"
        Me.TxtSaldo.Size = New System.Drawing.Size(100, 20)
        Me.TxtSaldo.TabIndex = 5
        Me.TxtSaldo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Texgar
        '
        Me.Texgar.Location = New System.Drawing.Point(603, 80)
        Me.Texgar.Name = "Texgar"
        Me.Texgar.Size = New System.Drawing.Size(100, 20)
        Me.Texgar.TabIndex = 7
        Me.Texgar.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(477, 83)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(124, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Monto Garantia Aplicada"
        '
        'Txtnom
        '
        Me.Txtnom.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CONTCPFcontratosgarantiasBindingSource, "cobertura_nominal", True))
        Me.Txtnom.Location = New System.Drawing.Point(604, 109)
        Me.Txtnom.Name = "Txtnom"
        Me.Txtnom.Size = New System.Drawing.Size(33, 20)
        Me.Txtnom.TabIndex = 9
        Me.Txtnom.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'CONTCPFcontratosgarantiasBindingSource
        '
        Me.CONTCPFcontratosgarantiasBindingSource.DataMember = "CONT_CPF_contratos_garantias"
        Me.CONTCPFcontratosgarantiasBindingSource.DataSource = Me.DS_contratos
        '
        'DS_contratos
        '
        Me.DS_contratos.DataSetName = "DS_contratos"
        Me.DS_contratos.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(560, 112)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(37, 13)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "%Nom"
        '
        'Txtefec
        '
        Me.Txtefec.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CONTCPFcontratosgarantiasBindingSource, "cobertura_efectiva", True))
        Me.Txtefec.Location = New System.Drawing.Point(605, 137)
        Me.Txtefec.Name = "Txtefec"
        Me.Txtefec.Size = New System.Drawing.Size(31, 20)
        Me.Txtefec.TabIndex = 11
        Me.Txtefec.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(563, 140)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(37, 13)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "%Efec"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(727, 171)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 12
        Me.Button1.Text = "Cálcular Gar."
        Me.Button1.UseVisualStyleBackColor = True
        '
        'txtmonto
        '
        Me.txtmonto.Location = New System.Drawing.Point(605, 171)
        Me.txtmonto.Name = "txtmonto"
        Me.txtmonto.Size = New System.Drawing.Size(100, 20)
        Me.txtmonto.TabIndex = 14
        Me.txtmonto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(480, 174)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(124, 13)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "Monto Garantia Aplicada"
        '
        'CONT_CPF_contratos_garantiasTableAdapter
        '
        Me.CONT_CPF_contratos_garantiasTableAdapter.ClearBeforeFill = True
        '
        'TextBox1
        '
        Me.TextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.GarantiasEjerBindingSource, "id_contrato", True))
        Me.TextBox1.Location = New System.Drawing.Point(410, 167)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(33, 20)
        Me.TextBox1.TabIndex = 15
        Me.TextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'ch_fonaga
        '
        Me.ch_fonaga.AutoSize = True
        Me.ch_fonaga.Location = New System.Drawing.Point(710, 111)
        Me.ch_fonaga.Name = "ch_fonaga"
        Me.ch_fonaga.Size = New System.Drawing.Size(62, 17)
        Me.ch_fonaga.TabIndex = 16
        Me.ch_fonaga.Text = "Fonaga"
        Me.ch_fonaga.UseVisualStyleBackColor = True
        '
        'CONTCPFgarantiasBindingSource
        '
        Me.CONTCPFgarantiasBindingSource.DataMember = "CONT_CPF_garantias"
        Me.CONTCPFgarantiasBindingSource.DataSource = Me.DS_contratos
        '
        'CONT_CPF_garantiasTableAdapter
        '
        Me.CONT_CPF_garantiasTableAdapter.ClearBeforeFill = True
        '
        'DTFecha
        '
        Me.DTFecha.Location = New System.Drawing.Point(602, 23)
        Me.DTFecha.Name = "DTFecha"
        Me.DTFecha.Size = New System.Drawing.Size(200, 20)
        Me.DTFecha.TabIndex = 311
        Me.DTFecha.Value = New Date(2019, 7, 19, 16, 59, 14, 0)
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(557, 29)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(40, 13)
        Me.Label7.TabIndex = 312
        Me.Label7.Text = "Fecha "
        '
        'FrmGarantiasXEjercer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(834, 247)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.DTFecha)
        Me.Controls.Add(Me.ch_fonaga)
        Me.Controls.Add(Me.txtmonto)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Txtefec)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Txtnom)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Texgar)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TxtSaldo)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.BtnEjercer)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.CmbCli)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBox1)
        Me.Name = "FrmGarantiasXEjercer"
        Me.Text = "Saldo Garantias Ejercidas"
        CType(Me.CliGarantiasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DescuentosDS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GarantiasEjerBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CONTCPFcontratosgarantiasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DS_contratos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CONTCPFgarantiasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents CmbCli As System.Windows.Forms.ComboBox
    Friend WithEvents DescuentosDS As Fira_Cartera_Pasiva.DescuentosDS
    Friend WithEvents CliGarantiasBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CliGarantiasTableAdapter As Fira_Cartera_Pasiva.DescuentosDSTableAdapters.CliGarantiasTableAdapter
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents GarantiasEjerBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents GarantiasEjerTableAdapter As Fira_Cartera_Pasiva.DescuentosDSTableAdapters.GarantiasEjerTableAdapter
    Friend WithEvents AnexoConDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CicloPagareDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SaldocontingenteDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents id_credito As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BtnEjercer As System.Windows.Forms.Button
    Friend WithEvents Label2 As Label
    Friend WithEvents TxtSaldo As TextBox
    Friend WithEvents Texgar As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Txtnom As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Txtefec As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents txtmonto As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents DS_contratos As DS_contratos
    Friend WithEvents CONTCPFcontratosgarantiasBindingSource As BindingSource
    Friend WithEvents CONT_CPF_contratos_garantiasTableAdapter As DS_contratosTableAdapters.CONT_CPF_contratos_garantiasTableAdapter
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents ch_fonaga As CheckBox
    Friend WithEvents CONTCPFgarantiasBindingSource As BindingSource
    Friend WithEvents CONT_CPF_garantiasTableAdapter As DS_contratosTableAdapters.CONT_CPF_garantiasTableAdapter
    Friend WithEvents DTFecha As DateTimePicker
    Friend WithEvents Label7 As Label
End Class
