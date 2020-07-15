<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmPagoManual
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.PagosDS = New Fira_Cartera_Pasiva.PagosDS()
        Me.CONTCPFCalendariosRevisionTasaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CONT_CPF_CalendariosRevisionTasaTableAdapter = New Fira_Cartera_Pasiva.PagosDSTableAdapters.CONT_CPF_CalendariosRevisionTasaTableAdapter()
        Me.CONTCPFvencimientosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CONT_CPF_vencimientosTableAdapter = New Fira_Cartera_Pasiva.PagosDSTableAdapters.CONT_CPF_vencimientosTableAdapter()
        Me.DS_contratos = New Fira_Cartera_Pasiva.DS_contratos()
        Me.DScontratosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CONTCPFcontratosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CONT_CPF_contratosTableAdapter = New Fira_Cartera_Pasiva.DS_contratosTableAdapters.CONT_CPF_contratosTableAdapter()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.ClientesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.ClientesTableAdapter = New Fira_Cartera_Pasiva.DS_contratosTableAdapters.ClientesTableAdapter()
        Me.CONT_CPF_vencimientosDataGridView = New System.Windows.Forms.DataGridView()
        Me.IdvencimientosDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CapitalDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UltimopagoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EstatusDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.InteresesDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.InteresPagadoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CONTCPFvencimientosBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label4 = New System.Windows.Forms.Label()
        Me.dt_fecha = New System.Windows.Forms.DateTimePicker()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.bt_aplicar = New System.Windows.Forms.Button()
        Me.txt_monto = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.PagosFiraBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PagosFiraTableAdapter = New Fira_Cartera_Pasiva.PagosDSTableAdapters.PagosFiraTableAdapter()
        Me.PagosFiraBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.CONTCPFPagosFiraBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CONT_CPF_PagosFiraTableAdapter = New Fira_Cartera_Pasiva.PagosDSTableAdapters.CONT_CPF_PagosFiraTableAdapter()
        Me.txt_intereses = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        CType(Me.PagosDS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CONTCPFCalendariosRevisionTasaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CONTCPFvencimientosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DS_contratos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DScontratosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CONTCPFcontratosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClientesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CONT_CPF_vencimientosDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CONTCPFvencimientosBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PagosFiraBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PagosFiraBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CONTCPFPagosFiraBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PagosDS
        '
        Me.PagosDS.DataSetName = "PagosDS"
        Me.PagosDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CONTCPFCalendariosRevisionTasaBindingSource
        '
        Me.CONTCPFCalendariosRevisionTasaBindingSource.DataMember = "CONT_CPF_CalendariosRevisionTasa"
        Me.CONTCPFCalendariosRevisionTasaBindingSource.DataSource = Me.PagosDS
        '
        'CONT_CPF_CalendariosRevisionTasaTableAdapter
        '
        Me.CONT_CPF_CalendariosRevisionTasaTableAdapter.ClearBeforeFill = True
        '
        'CONTCPFvencimientosBindingSource
        '
        Me.CONTCPFvencimientosBindingSource.DataMember = "CONT_CPF_vencimientos"
        Me.CONTCPFvencimientosBindingSource.DataSource = Me.PagosDS
        '
        'CONT_CPF_vencimientosTableAdapter
        '
        Me.CONT_CPF_vencimientosTableAdapter.ClearBeforeFill = True
        '
        'DS_contratos
        '
        Me.DS_contratos.DataSetName = "DS_contratos"
        Me.DS_contratos.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DScontratosBindingSource
        '
        Me.DScontratosBindingSource.DataSource = Me.DS_contratos
        Me.DScontratosBindingSource.Position = 0
        '
        'CONTCPFcontratosBindingSource
        '
        Me.CONTCPFcontratosBindingSource.DataMember = "CONT_CPF_contratos"
        Me.CONTCPFcontratosBindingSource.DataSource = Me.DS_contratos
        '
        'CONT_CPF_contratosTableAdapter
        '
        Me.CONT_CPF_contratosTableAdapter.ClearBeforeFill = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(30, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(52, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Id Crédito"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(43, 46)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(39, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Cliente"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(219, 19)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(80, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Contrato Finagil"
        '
        'TextBox1
        '
        Me.TextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CONTCPFcontratosBindingSource, "id_credito", True))
        Me.TextBox1.Location = New System.Drawing.Point(98, 16)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 20)
        Me.TextBox1.TabIndex = 3
        '
        'TextBox2
        '
        Me.TextBox2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClientesBindingSource, "Descr", True))
        Me.TextBox2.Location = New System.Drawing.Point(98, 46)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(312, 20)
        Me.TextBox2.TabIndex = 4
        '
        'ClientesBindingSource
        '
        Me.ClientesBindingSource.DataMember = "Clientes"
        Me.ClientesBindingSource.DataSource = Me.DS_contratos
        '
        'TextBox3
        '
        Me.TextBox3.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CONTCPFcontratosBindingSource, "anexo", True))
        Me.TextBox3.Location = New System.Drawing.Point(305, 16)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(100, 20)
        Me.TextBox3.TabIndex = 5
        '
        'ClientesTableAdapter
        '
        Me.ClientesTableAdapter.ClearBeforeFill = True
        '
        'CONT_CPF_vencimientosDataGridView
        '
        Me.CONT_CPF_vencimientosDataGridView.AutoGenerateColumns = False
        Me.CONT_CPF_vencimientosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.CONT_CPF_vencimientosDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdvencimientosDataGridViewTextBoxColumn, Me.FechaDataGridViewTextBoxColumn, Me.CapitalDataGridViewTextBoxColumn, Me.UltimopagoDataGridViewTextBoxColumn, Me.EstatusDataGridViewTextBoxColumn, Me.InteresesDataGridViewTextBoxColumn, Me.InteresPagadoDataGridViewTextBoxColumn})
        Me.CONT_CPF_vencimientosDataGridView.DataSource = Me.CONTCPFvencimientosBindingSource1
        Me.CONT_CPF_vencimientosDataGridView.Location = New System.Drawing.Point(33, 186)
        Me.CONT_CPF_vencimientosDataGridView.Name = "CONT_CPF_vencimientosDataGridView"
        Me.CONT_CPF_vencimientosDataGridView.Size = New System.Drawing.Size(649, 146)
        Me.CONT_CPF_vencimientosDataGridView.TabIndex = 6
        '
        'IdvencimientosDataGridViewTextBoxColumn
        '
        Me.IdvencimientosDataGridViewTextBoxColumn.DataPropertyName = "id_vencimientos"
        Me.IdvencimientosDataGridViewTextBoxColumn.HeaderText = "id_vencimientos"
        Me.IdvencimientosDataGridViewTextBoxColumn.Name = "IdvencimientosDataGridViewTextBoxColumn"
        Me.IdvencimientosDataGridViewTextBoxColumn.ReadOnly = True
        Me.IdvencimientosDataGridViewTextBoxColumn.Visible = False
        '
        'FechaDataGridViewTextBoxColumn
        '
        Me.FechaDataGridViewTextBoxColumn.DataPropertyName = "fecha"
        Me.FechaDataGridViewTextBoxColumn.HeaderText = "fecha"
        Me.FechaDataGridViewTextBoxColumn.Name = "FechaDataGridViewTextBoxColumn"
        '
        'CapitalDataGridViewTextBoxColumn
        '
        Me.CapitalDataGridViewTextBoxColumn.DataPropertyName = "capital"
        Me.CapitalDataGridViewTextBoxColumn.HeaderText = "capital"
        Me.CapitalDataGridViewTextBoxColumn.Name = "CapitalDataGridViewTextBoxColumn"
        '
        'UltimopagoDataGridViewTextBoxColumn
        '
        Me.UltimopagoDataGridViewTextBoxColumn.DataPropertyName = "ultimo_pago"
        Me.UltimopagoDataGridViewTextBoxColumn.HeaderText = "ultimo_pago"
        Me.UltimopagoDataGridViewTextBoxColumn.Name = "UltimopagoDataGridViewTextBoxColumn"
        '
        'EstatusDataGridViewTextBoxColumn
        '
        Me.EstatusDataGridViewTextBoxColumn.DataPropertyName = "estatus"
        Me.EstatusDataGridViewTextBoxColumn.HeaderText = "estatus"
        Me.EstatusDataGridViewTextBoxColumn.Name = "EstatusDataGridViewTextBoxColumn"
        '
        'InteresesDataGridViewTextBoxColumn
        '
        Me.InteresesDataGridViewTextBoxColumn.DataPropertyName = "intereses"
        Me.InteresesDataGridViewTextBoxColumn.HeaderText = "intereses"
        Me.InteresesDataGridViewTextBoxColumn.Name = "InteresesDataGridViewTextBoxColumn"
        '
        'InteresPagadoDataGridViewTextBoxColumn
        '
        Me.InteresPagadoDataGridViewTextBoxColumn.DataPropertyName = "InteresPagado"
        Me.InteresPagadoDataGridViewTextBoxColumn.HeaderText = "InteresPagado"
        Me.InteresPagadoDataGridViewTextBoxColumn.Name = "InteresPagadoDataGridViewTextBoxColumn"
        '
        'CONTCPFvencimientosBindingSource1
        '
        Me.CONTCPFvencimientosBindingSource1.DataMember = "CONT_CPF_vencimientos"
        Me.CONTCPFvencimientosBindingSource1.DataSource = Me.PagosDS
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(30, 154)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(70, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Vencimientos"
        '
        'dt_fecha
        '
        Me.dt_fecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dt_fecha.Location = New System.Drawing.Point(99, 83)
        Me.dt_fecha.Name = "dt_fecha"
        Me.dt_fecha.Size = New System.Drawing.Size(99, 20)
        Me.dt_fecha.TabIndex = 8
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 83)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(80, 13)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Fecha de Pago"
        '
        'bt_aplicar
        '
        Me.bt_aplicar.Location = New System.Drawing.Point(599, 351)
        Me.bt_aplicar.Name = "bt_aplicar"
        Me.bt_aplicar.Size = New System.Drawing.Size(83, 22)
        Me.bt_aplicar.TabIndex = 10
        Me.bt_aplicar.Text = "Aplicar Pago"
        Me.bt_aplicar.UseVisualStyleBackColor = True
        '
        'txt_monto
        '
        Me.txt_monto.Location = New System.Drawing.Point(98, 115)
        Me.txt_monto.Name = "txt_monto"
        Me.txt_monto.Size = New System.Drawing.Size(100, 20)
        Me.txt_monto.TabIndex = 12
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(30, 118)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(39, 13)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Capital"
        '
        'PagosFiraBindingSource
        '
        Me.PagosFiraBindingSource.DataMember = "PagosFira"
        Me.PagosFiraBindingSource.DataSource = Me.PagosDS
        '
        'PagosFiraTableAdapter
        '
        Me.PagosFiraTableAdapter.ClearBeforeFill = True
        '
        'PagosFiraBindingSource1
        '
        Me.PagosFiraBindingSource1.DataMember = "PagosFira"
        Me.PagosFiraBindingSource1.DataSource = Me.PagosDS
        '
        'CONTCPFPagosFiraBindingSource
        '
        Me.CONTCPFPagosFiraBindingSource.DataMember = "CONT_CPF_PagosFira"
        Me.CONTCPFPagosFiraBindingSource.DataSource = Me.PagosDS
        '
        'CONT_CPF_PagosFiraTableAdapter
        '
        Me.CONT_CPF_PagosFiraTableAdapter.ClearBeforeFill = True
        '
        'txt_intereses
        '
        Me.txt_intereses.Location = New System.Drawing.Point(303, 115)
        Me.txt_intereses.Name = "txt_intereses"
        Me.txt_intereses.Size = New System.Drawing.Size(100, 20)
        Me.txt_intereses.TabIndex = 14
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(235, 118)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(50, 13)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "Intereses"
        '
        'frmPagoManual
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1037, 517)
        Me.Controls.Add(Me.txt_intereses)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txt_monto)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.bt_aplicar)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.dt_fecha)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.CONT_CPF_vencimientosDataGridView)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmPagoManual"
        Me.Text = "frmPagoManual"
        CType(Me.PagosDS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CONTCPFCalendariosRevisionTasaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CONTCPFvencimientosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DS_contratos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DScontratosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CONTCPFcontratosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClientesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CONT_CPF_vencimientosDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CONTCPFvencimientosBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PagosFiraBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PagosFiraBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CONTCPFPagosFiraBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PagosDS As PagosDS
    Friend WithEvents CONTCPFCalendariosRevisionTasaBindingSource As BindingSource
    Friend WithEvents CONT_CPF_CalendariosRevisionTasaTableAdapter As PagosDSTableAdapters.CONT_CPF_CalendariosRevisionTasaTableAdapter
    Friend WithEvents CONTCPFvencimientosBindingSource As BindingSource
    Friend WithEvents CONT_CPF_vencimientosTableAdapter As PagosDSTableAdapters.CONT_CPF_vencimientosTableAdapter
    Friend WithEvents DScontratosBindingSource As BindingSource
    Friend WithEvents DS_contratos As DS_contratos
    Friend WithEvents CONTCPFcontratosBindingSource As BindingSource
    Friend WithEvents CONT_CPF_contratosTableAdapter As DS_contratosTableAdapters.CONT_CPF_contratosTableAdapter
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents ClientesBindingSource As BindingSource
    Friend WithEvents ClientesTableAdapter As DS_contratosTableAdapters.ClientesTableAdapter
    Friend WithEvents CONT_CPF_vencimientosDataGridView As DataGridView
    Friend WithEvents CONTCPFvencimientosBindingSource1 As BindingSource
    Friend WithEvents IdvencimientosDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FechaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CapitalDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents UltimopagoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EstatusDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents InteresesDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents InteresPagadoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Label4 As Label
    Friend WithEvents dt_fecha As DateTimePicker
    Friend WithEvents Label5 As Label
    Friend WithEvents bt_aplicar As Button
    Friend WithEvents txt_monto As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents PagosFiraBindingSource As BindingSource
    Friend WithEvents PagosFiraTableAdapter As PagosDSTableAdapters.PagosFiraTableAdapter
    Friend WithEvents PagosFiraBindingSource1 As BindingSource
    Friend WithEvents CONTCPFPagosFiraBindingSource As BindingSource
    Friend WithEvents CONT_CPF_PagosFiraTableAdapter As PagosDSTableAdapters.CONT_CPF_PagosFiraTableAdapter
    Friend WithEvents txt_intereses As TextBox
    Friend WithEvents Label7 As Label
End Class
