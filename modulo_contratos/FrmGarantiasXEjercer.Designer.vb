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
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
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
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        CType(Me.CliGarantiasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DescuentosDS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GarantiasEjerBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
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
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle3.Format = "N2"
        DataGridViewCellStyle3.NullValue = Nothing
        Me.SaldocontingenteDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle3
        Me.SaldocontingenteDataGridViewTextBoxColumn.HeaderText = "Saldo Contingente"
        Me.SaldocontingenteDataGridViewTextBoxColumn.Name = "SaldocontingenteDataGridViewTextBoxColumn"
        Me.SaldocontingenteDataGridViewTextBoxColumn.ReadOnly = True
        '
        'id_credito
        '
        Me.id_credito.DataPropertyName = "id_credito"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.id_credito.DefaultCellStyle = DataGridViewCellStyle4
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
        Me.BtnEjercer.Location = New System.Drawing.Point(367, 194)
        Me.BtnEjercer.Name = "BtnEjercer"
        Me.BtnEjercer.Size = New System.Drawing.Size(75, 23)
        Me.BtnEjercer.TabIndex = 3
        Me.BtnEjercer.Text = "Ejercer Gar."
        Me.BtnEjercer.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(13, 194)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(110, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Monto Incumplimiento"
        '
        'TxtSaldo
        '
        Me.TxtSaldo.Location = New System.Drawing.Point(138, 187)
        Me.TxtSaldo.Name = "TxtSaldo"
        Me.TxtSaldo.Size = New System.Drawing.Size(100, 20)
        Me.TxtSaldo.TabIndex = 5
        Me.TxtSaldo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(138, 216)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 20)
        Me.TextBox1.TabIndex = 7
        Me.TextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(13, 219)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(124, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Monto Garantia Aplicada"
        '
        'FrmGarantiasXEjercer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(603, 292)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TxtSaldo)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.BtnEjercer)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.CmbCli)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FrmGarantiasXEjercer"
        Me.Text = "Saldo Garantias Ejercidas"
        CType(Me.CliGarantiasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DescuentosDS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GarantiasEjerBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label3 As Label
End Class
