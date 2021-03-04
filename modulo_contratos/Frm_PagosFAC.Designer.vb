<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Frm_PagosFAC
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
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.WEBLotesBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.FactorajeDS3 = New Fira_Cartera_Pasiva.FactorajeDS()
        Me.CONTCPFlotesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.FactorajeDS1 = New Fira_Cartera_Pasiva.FactorajeDS()
        Me.WEBLotesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.FactorajeDS = New Fira_Cartera_Pasiva.FactorajeDS()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.CONTCPFFactorPagosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.WEB_LotesTableAdapter = New Fira_Cartera_Pasiva.FactorajeDSTableAdapters.WEB_LotesTableAdapter()
        Me.CONT_CPF_Factor_PagosTableAdapter = New Fira_Cartera_Pasiva.FactorajeDSTableAdapters.CONT_CPF_Factor_PagosTableAdapter()
        Me.CONTCPFFactorPagosBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.FacturaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DG_pagos = New System.Windows.Forms.DataGridView()
        Me.IdpagoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FacturaDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MONTODELPAGODECAPITAL1DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FECHAPAGOACREDITADO1DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CONTCPFFactorPagosBindingSource2 = New System.Windows.Forms.BindingSource(Me.components)
        Me.txttotal = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btlayput = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.CONT_CPF_lotesTableAdapter = New Fira_Cartera_Pasiva.FactorajeDSTableAdapters.CONT_CPF_lotesTableAdapter()
        Me.DS_contratos = New Fira_Cartera_Pasiva.DS_contratos()
        Me.DScontratosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CONTCPFcontratosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CONT_CPF_contratosTableAdapter = New Fira_Cartera_Pasiva.DS_contratosTableAdapters.CONT_CPF_contratosTableAdapter()
        Me.DS_contratos1 = New Fira_Cartera_Pasiva.DS_contratos()
        Me.CONTCPFconfiguracionBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CONT_CPF_configuracionTableAdapter = New Fira_Cartera_Pasiva.DS_contratosTableAdapters.CONT_CPF_configuracionTableAdapter()
        Me.PagosDS = New Fira_Cartera_Pasiva.PagosDS()
        Me.PagosFiraBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PagosFiraTableAdapter = New Fira_Cartera_Pasiva.PagosDSTableAdapters.PagosFiraTableAdapter()
        Me.PagosFiraBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.PagosFiraBindingSource2 = New System.Windows.Forms.BindingSource(Me.components)
        Me.FactorajeDS2 = New Fira_Cartera_Pasiva.FactorajeDS()
        Me.CONTCPFPagosFiraBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CONT_CPF_PagosFiraTableAdapter = New Fira_Cartera_Pasiva.FactorajeDSTableAdapters.CONT_CPF_PagosFiraTableAdapter()
        Me.CONTCPFFacturasERRORBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CONT_CPF_FacturasERRORTableAdapter = New Fira_Cartera_Pasiva.FactorajeDSTableAdapters.CONT_CPF_FacturasERRORTableAdapter()
        Me.chk_adelantado = New System.Windows.Forms.CheckBox()
        Me.CONTCPFvencimientosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CONT_CPF_vencimientosTableAdapter = New Fira_Cartera_Pasiva.DS_contratosTableAdapters.CONT_CPF_vencimientosTableAdapter()
        Me.CONTCPFCalendariosRevisionTasaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CONT_CPF_CalendariosRevisionTasaTableAdapter = New Fira_Cartera_Pasiva.PagosDSTableAdapters.CONT_CPF_CalendariosRevisionTasaTableAdapter()
        Me.CONTCPFvencimientosBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.CONT_CPF_vencimientosTableAdapter1 = New Fira_Cartera_Pasiva.PagosDSTableAdapters.CONT_CPF_vencimientosTableAdapter()
        Me.PagosDS1 = New Fira_Cartera_Pasiva.PagosDS()
        Me.PagosDS1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CONTCPFPagosFiraBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.CONT_CPF_PagosFiraTableAdapter1 = New Fira_Cartera_Pasiva.PagosDSTableAdapters.CONT_CPF_PagosFiraTableAdapter()
        Me.PagosFiraBindingSource3 = New System.Windows.Forms.BindingSource(Me.components)
        Me.chk_anticipo = New System.Windows.Forms.CheckBox()
        CType(Me.WEBLotesBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FactorajeDS3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CONTCPFlotesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FactorajeDS1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WEBLotesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FactorajeDS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CONTCPFFactorPagosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CONTCPFFactorPagosBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DG_pagos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CONTCPFFactorPagosBindingSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DS_contratos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DScontratosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CONTCPFcontratosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DS_contratos1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CONTCPFconfiguracionBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PagosDS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PagosFiraBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PagosFiraBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PagosFiraBindingSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FactorajeDS2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CONTCPFPagosFiraBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CONTCPFFacturasERRORBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CONTCPFvencimientosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CONTCPFCalendariosRevisionTasaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CONTCPFvencimientosBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PagosDS1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PagosDS1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CONTCPFPagosFiraBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PagosFiraBindingSource3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ComboBox2
        '
        Me.ComboBox2.DataSource = Me.WEBLotesBindingSource1
        Me.ComboBox2.DisplayMember = "Id_Lote"
        Me.ComboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Location = New System.Drawing.Point(83, 11)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(203, 21)
        Me.ComboBox2.TabIndex = 316
        Me.ComboBox2.ValueMember = "Id_Lote"
        '
        'WEBLotesBindingSource1
        '
        Me.WEBLotesBindingSource1.DataMember = "WEB_Lotes"
        Me.WEBLotesBindingSource1.DataSource = Me.FactorajeDS3
        '
        'FactorajeDS3
        '
        Me.FactorajeDS3.DataSetName = "FactorajeDS"
        Me.FactorajeDS3.Locale = New System.Globalization.CultureInfo("es-ES")
        Me.FactorajeDS3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CONTCPFlotesBindingSource
        '
        Me.CONTCPFlotesBindingSource.DataMember = "CONT_CPF_lotes"
        Me.CONTCPFlotesBindingSource.DataSource = Me.FactorajeDS1
        '
        'FactorajeDS1
        '
        Me.FactorajeDS1.DataSetName = "FactorajeDS"
        Me.FactorajeDS1.Locale = New System.Globalization.CultureInfo("es-ES")
        Me.FactorajeDS1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'WEBLotesBindingSource
        '
        Me.WEBLotesBindingSource.DataMember = "WEB_Lotes"
        Me.WEBLotesBindingSource.DataSource = Me.FactorajeDS
        '
        'FactorajeDS
        '
        Me.FactorajeDS.DataSetName = "FactorajeDS"
        Me.FactorajeDS.Locale = New System.Globalization.CultureInfo("es-ES")
        Me.FactorajeDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(9, 17)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(33, 13)
        Me.Label7.TabIndex = 315
        Me.Label7.Text = "Lotes"
        '
        'CONTCPFFactorPagosBindingSource
        '
        Me.CONTCPFFactorPagosBindingSource.DataMember = "CONT_CPF_Factor_Pagos"
        Me.CONTCPFFactorPagosBindingSource.DataSource = Me.FactorajeDS
        '
        'WEB_LotesTableAdapter
        '
        Me.WEB_LotesTableAdapter.ClearBeforeFill = True
        '
        'CONT_CPF_Factor_PagosTableAdapter
        '
        Me.CONT_CPF_Factor_PagosTableAdapter.ClearBeforeFill = True
        '
        'CONTCPFFactorPagosBindingSource1
        '
        Me.CONTCPFFactorPagosBindingSource1.DataMember = "CONT_CPF_Factor_Pagos"
        Me.CONTCPFFactorPagosBindingSource1.DataSource = Me.FactorajeDS
        '
        'FacturaDataGridViewTextBoxColumn
        '
        Me.FacturaDataGridViewTextBoxColumn.DataPropertyName = "Factura"
        Me.FacturaDataGridViewTextBoxColumn.HeaderText = "Factura"
        Me.FacturaDataGridViewTextBoxColumn.Name = "FacturaDataGridViewTextBoxColumn"
        '
        'DG_pagos
        '
        Me.DG_pagos.AllowUserToAddRows = False
        Me.DG_pagos.AutoGenerateColumns = False
        Me.DG_pagos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DG_pagos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdpagoDataGridViewTextBoxColumn, Me.FacturaDataGridViewTextBoxColumn1, Me.MONTODELPAGODECAPITAL1DataGridViewTextBoxColumn, Me.FECHAPAGOACREDITADO1DataGridViewTextBoxColumn})
        Me.DG_pagos.DataSource = Me.CONTCPFFactorPagosBindingSource2
        Me.DG_pagos.Location = New System.Drawing.Point(12, 51)
        Me.DG_pagos.Name = "DG_pagos"
        Me.DG_pagos.Size = New System.Drawing.Size(544, 142)
        Me.DG_pagos.TabIndex = 317
        '
        'IdpagoDataGridViewTextBoxColumn
        '
        Me.IdpagoDataGridViewTextBoxColumn.DataPropertyName = "id_pago"
        Me.IdpagoDataGridViewTextBoxColumn.HeaderText = "id_pago"
        Me.IdpagoDataGridViewTextBoxColumn.Name = "IdpagoDataGridViewTextBoxColumn"
        Me.IdpagoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'FacturaDataGridViewTextBoxColumn1
        '
        Me.FacturaDataGridViewTextBoxColumn1.DataPropertyName = "Factura"
        Me.FacturaDataGridViewTextBoxColumn1.HeaderText = "Factura"
        Me.FacturaDataGridViewTextBoxColumn1.Name = "FacturaDataGridViewTextBoxColumn1"
        '
        'MONTODELPAGODECAPITAL1DataGridViewTextBoxColumn
        '
        Me.MONTODELPAGODECAPITAL1DataGridViewTextBoxColumn.DataPropertyName = "MONTO DEL PAGO DE CAPITAL1"
        Me.MONTODELPAGODECAPITAL1DataGridViewTextBoxColumn.HeaderText = "MONTO DEL PAGO DE CAPITAL1"
        Me.MONTODELPAGODECAPITAL1DataGridViewTextBoxColumn.Name = "MONTODELPAGODECAPITAL1DataGridViewTextBoxColumn"
        '
        'FECHAPAGOACREDITADO1DataGridViewTextBoxColumn
        '
        Me.FECHAPAGOACREDITADO1DataGridViewTextBoxColumn.DataPropertyName = "FECHA PAGO ACREDITADO1"
        Me.FECHAPAGOACREDITADO1DataGridViewTextBoxColumn.HeaderText = "FECHA PAGO ACREDITADO1"
        Me.FECHAPAGOACREDITADO1DataGridViewTextBoxColumn.Name = "FECHAPAGOACREDITADO1DataGridViewTextBoxColumn"
        '
        'CONTCPFFactorPagosBindingSource2
        '
        Me.CONTCPFFactorPagosBindingSource2.DataMember = "CONT_CPF_Factor_Pagos"
        Me.CONTCPFFactorPagosBindingSource2.DataSource = Me.FactorajeDS
        '
        'txttotal
        '
        Me.txttotal.Location = New System.Drawing.Point(444, 202)
        Me.txttotal.Name = "txttotal"
        Me.txttotal.Size = New System.Drawing.Size(111, 20)
        Me.txttotal.TabIndex = 318
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(405, 205)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(31, 13)
        Me.Label1.TabIndex = 319
        Me.Label1.Text = "Total"
        '
        'btlayput
        '
        Me.btlayput.Location = New System.Drawing.Point(562, 88)
        Me.btlayput.Name = "btlayput"
        Me.btlayput.Size = New System.Drawing.Size(93, 23)
        Me.btlayput.TabIndex = 321
        Me.btlayput.Text = "Generar Layout"
        Me.btlayput.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(562, 117)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(93, 23)
        Me.Button2.TabIndex = 322
        Me.Button2.Text = "Aplicar Pagos"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'CONT_CPF_lotesTableAdapter
        '
        Me.CONT_CPF_lotesTableAdapter.ClearBeforeFill = True
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
        'DS_contratos1
        '
        Me.DS_contratos1.DataSetName = "DS_contratos"
        Me.DS_contratos1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CONTCPFconfiguracionBindingSource
        '
        Me.CONTCPFconfiguracionBindingSource.DataMember = "CONT_CPF_configuracion"
        Me.CONTCPFconfiguracionBindingSource.DataSource = Me.DS_contratos1
        '
        'CONT_CPF_configuracionTableAdapter
        '
        Me.CONT_CPF_configuracionTableAdapter.ClearBeforeFill = True
        '
        'PagosDS
        '
        Me.PagosDS.DataSetName = "PagosDS"
        Me.PagosDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
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
        'PagosFiraBindingSource2
        '
        Me.PagosFiraBindingSource2.DataMember = "PagosFira"
        Me.PagosFiraBindingSource2.DataSource = Me.PagosDS
        '
        'FactorajeDS2
        '
        Me.FactorajeDS2.DataSetName = "FactorajeDS"
        Me.FactorajeDS2.Locale = New System.Globalization.CultureInfo("es-ES")
        Me.FactorajeDS2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CONTCPFPagosFiraBindingSource
        '
        Me.CONTCPFPagosFiraBindingSource.DataMember = "CONT_CPF_PagosFira"
        Me.CONTCPFPagosFiraBindingSource.DataSource = Me.FactorajeDS2
        '
        'CONT_CPF_PagosFiraTableAdapter
        '
        Me.CONT_CPF_PagosFiraTableAdapter.ClearBeforeFill = True
        '
        'CONTCPFFacturasERRORBindingSource
        '
        Me.CONTCPFFacturasERRORBindingSource.DataMember = "CONT_CPF_FacturasERROR"
        Me.CONTCPFFacturasERRORBindingSource.DataSource = Me.FactorajeDS3
        '
        'CONT_CPF_FacturasERRORTableAdapter
        '
        Me.CONT_CPF_FacturasERRORTableAdapter.ClearBeforeFill = True
        '
        'chk_adelantado
        '
        Me.chk_adelantado.AutoSize = True
        Me.chk_adelantado.Checked = True
        Me.chk_adelantado.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chk_adelantado.Location = New System.Drawing.Point(562, 146)
        Me.chk_adelantado.Name = "chk_adelantado"
        Me.chk_adelantado.Size = New System.Drawing.Size(104, 17)
        Me.chk_adelantado.TabIndex = 323
        Me.chk_adelantado.Text = "Pago Anticipado"
        Me.chk_adelantado.UseVisualStyleBackColor = True
        Me.chk_adelantado.Visible = False
        '
        'CONTCPFvencimientosBindingSource
        '
        Me.CONTCPFvencimientosBindingSource.DataMember = "CONT_CPF_vencimientos"
        Me.CONTCPFvencimientosBindingSource.DataSource = Me.DS_contratos
        '
        'CONT_CPF_vencimientosTableAdapter
        '
        Me.CONT_CPF_vencimientosTableAdapter.ClearBeforeFill = True
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
        'CONTCPFvencimientosBindingSource1
        '
        Me.CONTCPFvencimientosBindingSource1.DataMember = "CONT_CPF_vencimientos"
        Me.CONTCPFvencimientosBindingSource1.DataSource = Me.PagosDS
        '
        'CONT_CPF_vencimientosTableAdapter1
        '
        Me.CONT_CPF_vencimientosTableAdapter1.ClearBeforeFill = True
        '
        'PagosDS1
        '
        Me.PagosDS1.DataSetName = "PagosDS"
        Me.PagosDS1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PagosDS1BindingSource
        '
        Me.PagosDS1BindingSource.DataSource = Me.PagosDS1
        Me.PagosDS1BindingSource.Position = 0
        '
        'CONTCPFPagosFiraBindingSource1
        '
        Me.CONTCPFPagosFiraBindingSource1.DataMember = "CONT_CPF_PagosFira"
        Me.CONTCPFPagosFiraBindingSource1.DataSource = Me.PagosDS1
        '
        'CONT_CPF_PagosFiraTableAdapter1
        '
        Me.CONT_CPF_PagosFiraTableAdapter1.ClearBeforeFill = True
        '
        'PagosFiraBindingSource3
        '
        Me.PagosFiraBindingSource3.DataMember = "PagosFira"
        Me.PagosFiraBindingSource3.DataSource = Me.PagosDS
        '
        'chk_anticipo
        '
        Me.chk_anticipo.AutoSize = True
        Me.chk_anticipo.Location = New System.Drawing.Point(661, 94)
        Me.chk_anticipo.Name = "chk_anticipo"
        Me.chk_anticipo.Size = New System.Drawing.Size(118, 17)
        Me.chk_anticipo.TabIndex = 324
        Me.chk_anticipo.Text = "Anticipo Acreditado"
        Me.chk_anticipo.UseVisualStyleBackColor = True
        '
        'Frm_PagosFAC
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(806, 239)
        Me.Controls.Add(Me.chk_anticipo)
        Me.Controls.Add(Me.chk_adelantado)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.btlayput)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txttotal)
        Me.Controls.Add(Me.DG_pagos)
        Me.Controls.Add(Me.ComboBox2)
        Me.Controls.Add(Me.Label7)
        Me.Name = "Frm_PagosFAC"
        Me.Text = "Frm_PagosFAC"
        CType(Me.WEBLotesBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FactorajeDS3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CONTCPFlotesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FactorajeDS1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WEBLotesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FactorajeDS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CONTCPFFactorPagosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CONTCPFFactorPagosBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DG_pagos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CONTCPFFactorPagosBindingSource2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DS_contratos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DScontratosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CONTCPFcontratosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DS_contratos1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CONTCPFconfiguracionBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PagosDS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PagosFiraBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PagosFiraBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PagosFiraBindingSource2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FactorajeDS2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CONTCPFPagosFiraBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CONTCPFFacturasERRORBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CONTCPFvencimientosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CONTCPFCalendariosRevisionTasaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CONTCPFvencimientosBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PagosDS1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PagosDS1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CONTCPFPagosFiraBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PagosFiraBindingSource3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents FactorajeDS As FactorajeDS
    Friend WithEvents WEBLotesBindingSource As BindingSource
    Friend WithEvents WEB_LotesTableAdapter As FactorajeDSTableAdapters.WEB_LotesTableAdapter
    Friend WithEvents CONTCPFFactorPagosBindingSource As BindingSource
    Friend WithEvents CONT_CPF_Factor_PagosTableAdapter As FactorajeDSTableAdapters.CONT_CPF_Factor_PagosTableAdapter
    Friend WithEvents CONTCPFFactorPagosBindingSource1 As BindingSource
    Friend WithEvents FacturaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DG_pagos As DataGridView
    Friend WithEvents CONTCPFFactorPagosBindingSource2 As BindingSource
    Friend WithEvents IdpagoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FacturaDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents MONTODELPAGODECAPITAL1DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FECHAPAGOACREDITADO1DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents txttotal As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btlayput As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents FactorajeDS1 As FactorajeDS
    Friend WithEvents CONTCPFlotesBindingSource As BindingSource
    Friend WithEvents CONT_CPF_lotesTableAdapter As FactorajeDSTableAdapters.CONT_CPF_lotesTableAdapter
    Friend WithEvents DScontratosBindingSource As BindingSource
    Friend WithEvents DS_contratos As DS_contratos
    Friend WithEvents CONTCPFcontratosBindingSource As BindingSource
    Friend WithEvents CONT_CPF_contratosTableAdapter As DS_contratosTableAdapters.CONT_CPF_contratosTableAdapter
    Friend WithEvents DS_contratos1 As DS_contratos
    Friend WithEvents CONTCPFconfiguracionBindingSource As BindingSource
    Friend WithEvents CONT_CPF_configuracionTableAdapter As DS_contratosTableAdapters.CONT_CPF_configuracionTableAdapter
    Friend WithEvents PagosDS As PagosDS
    Friend WithEvents PagosFiraBindingSource As BindingSource
    Friend WithEvents PagosFiraTableAdapter As PagosDSTableAdapters.PagosFiraTableAdapter
    Friend WithEvents PagosFiraBindingSource1 As BindingSource
    Friend WithEvents PagosFiraBindingSource2 As BindingSource
    Friend WithEvents FactorajeDS2 As FactorajeDS
    Friend WithEvents CONTCPFPagosFiraBindingSource As BindingSource
    Friend WithEvents CONT_CPF_PagosFiraTableAdapter As FactorajeDSTableAdapters.CONT_CPF_PagosFiraTableAdapter
    Friend WithEvents FactorajeDS3 As FactorajeDS
    Friend WithEvents WEBLotesBindingSource1 As BindingSource
    Friend WithEvents CONTCPFFacturasERRORBindingSource As BindingSource
    Friend WithEvents CONT_CPF_FacturasERRORTableAdapter As FactorajeDSTableAdapters.CONT_CPF_FacturasERRORTableAdapter
    Friend WithEvents chk_adelantado As CheckBox
    Friend WithEvents CONTCPFvencimientosBindingSource As BindingSource
    Friend WithEvents CONT_CPF_vencimientosTableAdapter As DS_contratosTableAdapters.CONT_CPF_vencimientosTableAdapter
    Friend WithEvents CONTCPFCalendariosRevisionTasaBindingSource As BindingSource
    Friend WithEvents CONT_CPF_CalendariosRevisionTasaTableAdapter As PagosDSTableAdapters.CONT_CPF_CalendariosRevisionTasaTableAdapter
    Friend WithEvents CONTCPFvencimientosBindingSource1 As BindingSource
    Friend WithEvents CONT_CPF_vencimientosTableAdapter1 As PagosDSTableAdapters.CONT_CPF_vencimientosTableAdapter
    Friend WithEvents PagosDS1BindingSource As BindingSource
    Friend WithEvents PagosDS1 As PagosDS
    Friend WithEvents CONTCPFPagosFiraBindingSource1 As BindingSource
    Friend WithEvents CONT_CPF_PagosFiraTableAdapter1 As PagosDSTableAdapters.CONT_CPF_PagosFiraTableAdapter
    Friend WithEvents PagosFiraBindingSource3 As BindingSource
    Friend WithEvents chk_anticipo As CheckBox
End Class
