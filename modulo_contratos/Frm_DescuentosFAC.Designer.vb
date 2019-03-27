<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_DescuentosFAC
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
        Me.CONTCPFFactorFacturasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.FactorajeDS = New Fira_Cartera_Pasiva.FactorajeDS()
        Me.CONT_CPF_Factor_FacturasTableAdapter = New Fira_Cartera_Pasiva.FactorajeDSTableAdapters.CONT_CPF_Factor_FacturasTableAdapter()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.FacturaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RFCDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DGFACT = New System.Windows.Forms.DataGridView()
        Me.FacturaDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RFCDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RFCCONTRAPARTEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MONTOSOLICITADODataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TASAIFDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FECHADEEXPEDICIÓNDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FECHADEVENCIMIENTODataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LoteDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.id_Factura = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CONTCPFFactorFacturasBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.FactorajeDS1 = New Fira_Cartera_Pasiva.FactorajeDS()
        Me.TxtIntermediario = New System.Windows.Forms.TextBox()
        Me.cb_prestamo = New System.Windows.Forms.ComboBox()
        Me.CONTCPFtipoprestamosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DS_contratos = New Fira_Cartera_Pasiva.DS_contratos()
        Me.cb_operacion = New System.Windows.Forms.ComboBox()
        Me.CONTCPFoperacionBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label62 = New System.Windows.Forms.Label()
        Me.cb_intermediario = New System.Windows.Forms.ComboBox()
        Me.CONTCPFintermediariosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label57 = New System.Windows.Forms.Label()
        Me.cb_producto = New System.Windows.Forms.ComboBox()
        Me.CONTCPFproductosfiraBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cb_esquema = New System.Windows.Forms.ComboBox()
        Me.CONTCPFesquemacobroBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label15 = New System.Windows.Forms.Label()
        Me.cb_gl = New System.Windows.Forms.ComboBox()
        Me.CONTCPFGLBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DescuentosDS = New Fira_Cartera_Pasiva.DescuentosDS()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.CK_FONAGA = New System.Windows.Forms.CheckBox()
        Me.Label69 = New System.Windows.Forms.Label()
        Me.Label68 = New System.Windows.Forms.Label()
        Me.Label67 = New System.Windows.Forms.Label()
        Me.Label66 = New System.Windows.Forms.Label()
        Me.TXT_EFEC = New System.Windows.Forms.TextBox()
        Me.TXT_NOM = New System.Windows.Forms.TextBox()
        Me.PCXSG_TXT = New System.Windows.Forms.TextBox()
        Me.TXT_FN = New System.Windows.Forms.TextBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.TXT_FB = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_BP = New System.Windows.Forms.TextBox()
        Me.Label55 = New System.Windows.Forms.Label()
        Me.cb_tasa = New System.Windows.Forms.ComboBox()
        Me.CONTCPFtipotasasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label13 = New System.Windows.Forms.Label()
        Me.CONT_CPF_GLTableAdapter = New Fira_Cartera_Pasiva.DescuentosDSTableAdapters.CONT_CPF_GLTableAdapter()
        Me.cb_divisa = New System.Windows.Forms.ComboBox()
        Me.CONTCPFdivisasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.FactorajeDS2 = New Fira_Cartera_Pasiva.FactorajeDS()
        Me.ClientesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ClientesTableAdapter = New Fira_Cartera_Pasiva.FactorajeDSTableAdapters.ClientesTableAdapter()
        Me.TXT_IVA = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ch_subsidio = New System.Windows.Forms.CheckBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.CONTCPFcontratosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MinistracionesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MinistracionesTableAdapter = New Fira_Cartera_Pasiva.DescuentosDSTableAdapters.MinistracionesTableAdapter()
        Me.CLIENTETXT = New System.Windows.Forms.TextBox()
        Me.CONT_CPF_intermediariosTableAdapter = New Fira_Cartera_Pasiva.DS_contratosTableAdapters.CONT_CPF_intermediariosTableAdapter()
        Me.CONT_CPF_operacionTableAdapter = New Fira_Cartera_Pasiva.DS_contratosTableAdapters.CONT_CPF_operacionTableAdapter()
        Me.CONT_CPF_productos_firaTableAdapter = New Fira_Cartera_Pasiva.DS_contratosTableAdapters.CONT_CPF_productos_firaTableAdapter()
        Me.CONT_CPF_tipoprestamosTableAdapter = New Fira_Cartera_Pasiva.DS_contratosTableAdapters.CONT_CPF_tipoprestamosTableAdapter()
        Me.CONT_CPF_esquema_cobroTableAdapter = New Fira_Cartera_Pasiva.DS_contratosTableAdapters.CONT_CPF_esquema_cobroTableAdapter()
        Me.CONT_CPF_tipo_tasasTableAdapter = New Fira_Cartera_Pasiva.DS_contratosTableAdapters.CONT_CPF_tipo_tasasTableAdapter()
        Me.CONTCPFconfiguracionBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CONT_CPF_configuracionTableAdapter = New Fira_Cartera_Pasiva.DS_contratosTableAdapters.CONT_CPF_configuracionTableAdapter()
        Me.CONT_CPF_divisasTableAdapter = New Fira_Cartera_Pasiva.DS_contratosTableAdapters.CONT_CPF_divisasTableAdapter()
        Me.CONTCPFcontratosgarantiasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CONT_CPF_contratos_garantiasTableAdapter = New Fira_Cartera_Pasiva.DS_contratosTableAdapters.CONT_CPF_contratos_garantiasTableAdapter()
        Me.CONTCPFvencimientosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CONT_CPF_vencimientosTableAdapter = New Fira_Cartera_Pasiva.DS_contratosTableAdapters.CONT_CPF_vencimientosTableAdapter()
        Me.CONT_CPF_contratosTableAdapter = New Fira_Cartera_Pasiva.DS_contratosTableAdapters.CONT_CPF_contratosTableAdapter()
        Me.Label63 = New System.Windows.Forms.Label()
        Me.Label59 = New System.Windows.Forms.Label()
        Me.Label54 = New System.Windows.Forms.Label()
        Me.cb_periodo_revision = New System.Windows.Forms.ComboBox()
        Me.CONTCPFperiodicidadBindingSource2 = New System.Windows.Forms.BindingSource(Me.components)
        Me.cb_periodo_int = New System.Windows.Forms.ComboBox()
        Me.CONTCPFperiodicidadBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.cb_periodo_capital = New System.Windows.Forms.ComboBox()
        Me.CONTCPFperiodicidadBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CONT_CPF_periodicidadTableAdapter = New Fira_Cartera_Pasiva.DS_contratosTableAdapters.CONT_CPF_periodicidadTableAdapter()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.WEBLotesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.WEB_LotesTableAdapter = New Fira_Cartera_Pasiva.FactorajeDSTableAdapters.WEB_LotesTableAdapter()
        CType(Me.CONTCPFFactorFacturasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FactorajeDS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DGFACT, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CONTCPFFactorFacturasBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FactorajeDS1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CONTCPFtipoprestamosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DS_contratos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CONTCPFoperacionBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CONTCPFintermediariosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CONTCPFproductosfiraBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CONTCPFesquemacobroBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CONTCPFGLBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DescuentosDS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CONTCPFtipotasasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CONTCPFdivisasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FactorajeDS2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClientesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CONTCPFcontratosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MinistracionesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CONTCPFconfiguracionBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CONTCPFcontratosgarantiasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CONTCPFvencimientosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CONTCPFperiodicidadBindingSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CONTCPFperiodicidadBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CONTCPFperiodicidadBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WEBLotesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CONTCPFFactorFacturasBindingSource
        '
        Me.CONTCPFFactorFacturasBindingSource.DataMember = "CONT_CPF_Factor_Facturas"
        Me.CONTCPFFactorFacturasBindingSource.DataSource = Me.FactorajeDS
        '
        'FactorajeDS
        '
        Me.FactorajeDS.DataSetName = "FactorajeDS"
        Me.FactorajeDS.Locale = New System.Globalization.CultureInfo("es-ES")
        Me.FactorajeDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CONT_CPF_Factor_FacturasTableAdapter
        '
        Me.CONT_CPF_Factor_FacturasTableAdapter.ClearBeforeFill = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(835, 332)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(90, 32)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "Procesar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'FacturaDataGridViewTextBoxColumn
        '
        Me.FacturaDataGridViewTextBoxColumn.DataPropertyName = "Factura"
        Me.FacturaDataGridViewTextBoxColumn.HeaderText = "Factura"
        Me.FacturaDataGridViewTextBoxColumn.Name = "FacturaDataGridViewTextBoxColumn"
        Me.FacturaDataGridViewTextBoxColumn.ReadOnly = True
        '
        'RFCDataGridViewTextBoxColumn
        '
        Me.RFCDataGridViewTextBoxColumn.DataPropertyName = "RFC"
        Me.RFCDataGridViewTextBoxColumn.HeaderText = "RFC"
        Me.RFCDataGridViewTextBoxColumn.Name = "RFCDataGridViewTextBoxColumn"
        Me.RFCDataGridViewTextBoxColumn.ReadOnly = True
        '
        'DGFACT
        '
        Me.DGFACT.AllowUserToAddRows = False
        Me.DGFACT.AllowUserToDeleteRows = False
        Me.DGFACT.AutoGenerateColumns = False
        Me.DGFACT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGFACT.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.FacturaDataGridViewTextBoxColumn1, Me.RFCDataGridViewTextBoxColumn1, Me.RFCCONTRAPARTEDataGridViewTextBoxColumn, Me.MONTOSOLICITADODataGridViewTextBoxColumn, Me.TASAIFDataGridViewTextBoxColumn, Me.FECHADEEXPEDICIÓNDataGridViewTextBoxColumn, Me.FECHADEVENCIMIENTODataGridViewTextBoxColumn, Me.LoteDataGridViewTextBoxColumn, Me.id_Factura})
        Me.DGFACT.DataSource = Me.CONTCPFFactorFacturasBindingSource1
        Me.DGFACT.Location = New System.Drawing.Point(15, 25)
        Me.DGFACT.Name = "DGFACT"
        Me.DGFACT.ReadOnly = True
        Me.DGFACT.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGFACT.Size = New System.Drawing.Size(889, 290)
        Me.DGFACT.TabIndex = 5
        '
        'FacturaDataGridViewTextBoxColumn1
        '
        Me.FacturaDataGridViewTextBoxColumn1.DataPropertyName = "Factura"
        Me.FacturaDataGridViewTextBoxColumn1.HeaderText = "Factura"
        Me.FacturaDataGridViewTextBoxColumn1.Name = "FacturaDataGridViewTextBoxColumn1"
        Me.FacturaDataGridViewTextBoxColumn1.ReadOnly = True
        '
        'RFCDataGridViewTextBoxColumn1
        '
        Me.RFCDataGridViewTextBoxColumn1.DataPropertyName = "RFC"
        Me.RFCDataGridViewTextBoxColumn1.HeaderText = "RFC"
        Me.RFCDataGridViewTextBoxColumn1.Name = "RFCDataGridViewTextBoxColumn1"
        Me.RFCDataGridViewTextBoxColumn1.ReadOnly = True
        '
        'RFCCONTRAPARTEDataGridViewTextBoxColumn
        '
        Me.RFCCONTRAPARTEDataGridViewTextBoxColumn.DataPropertyName = "RFC CONTRAPARTE"
        Me.RFCCONTRAPARTEDataGridViewTextBoxColumn.HeaderText = "RFC CONTRAPARTE"
        Me.RFCCONTRAPARTEDataGridViewTextBoxColumn.Name = "RFCCONTRAPARTEDataGridViewTextBoxColumn"
        Me.RFCCONTRAPARTEDataGridViewTextBoxColumn.ReadOnly = True
        '
        'MONTOSOLICITADODataGridViewTextBoxColumn
        '
        Me.MONTOSOLICITADODataGridViewTextBoxColumn.DataPropertyName = "MONTO SOLICITADO"
        Me.MONTOSOLICITADODataGridViewTextBoxColumn.HeaderText = "MONTO SOLICITADO"
        Me.MONTOSOLICITADODataGridViewTextBoxColumn.Name = "MONTOSOLICITADODataGridViewTextBoxColumn"
        Me.MONTOSOLICITADODataGridViewTextBoxColumn.ReadOnly = True
        '
        'TASAIFDataGridViewTextBoxColumn
        '
        Me.TASAIFDataGridViewTextBoxColumn.DataPropertyName = "TASA IF"
        Me.TASAIFDataGridViewTextBoxColumn.HeaderText = "TASA IF"
        Me.TASAIFDataGridViewTextBoxColumn.Name = "TASAIFDataGridViewTextBoxColumn"
        Me.TASAIFDataGridViewTextBoxColumn.ReadOnly = True
        '
        'FECHADEEXPEDICIÓNDataGridViewTextBoxColumn
        '
        Me.FECHADEEXPEDICIÓNDataGridViewTextBoxColumn.DataPropertyName = "FECHA DE EXPEDICIÓN"
        Me.FECHADEEXPEDICIÓNDataGridViewTextBoxColumn.HeaderText = "FECHA DE EXPEDICIÓN"
        Me.FECHADEEXPEDICIÓNDataGridViewTextBoxColumn.Name = "FECHADEEXPEDICIÓNDataGridViewTextBoxColumn"
        Me.FECHADEEXPEDICIÓNDataGridViewTextBoxColumn.ReadOnly = True
        '
        'FECHADEVENCIMIENTODataGridViewTextBoxColumn
        '
        Me.FECHADEVENCIMIENTODataGridViewTextBoxColumn.DataPropertyName = "FECHA DE VENCIMIENTO"
        Me.FECHADEVENCIMIENTODataGridViewTextBoxColumn.HeaderText = "FECHA DE VENCIMIENTO"
        Me.FECHADEVENCIMIENTODataGridViewTextBoxColumn.Name = "FECHADEVENCIMIENTODataGridViewTextBoxColumn"
        Me.FECHADEVENCIMIENTODataGridViewTextBoxColumn.ReadOnly = True
        '
        'LoteDataGridViewTextBoxColumn
        '
        Me.LoteDataGridViewTextBoxColumn.DataPropertyName = "Lote"
        Me.LoteDataGridViewTextBoxColumn.HeaderText = "Lote"
        Me.LoteDataGridViewTextBoxColumn.Name = "LoteDataGridViewTextBoxColumn"
        Me.LoteDataGridViewTextBoxColumn.ReadOnly = True
        '
        'id_Factura
        '
        Me.id_Factura.DataPropertyName = "id_Factura"
        Me.id_Factura.HeaderText = "id_Factura"
        Me.id_Factura.Name = "id_Factura"
        Me.id_Factura.ReadOnly = True
        '
        'CONTCPFFactorFacturasBindingSource1
        '
        Me.CONTCPFFactorFacturasBindingSource1.DataMember = "CONT_CPF_Factor_Facturas"
        Me.CONTCPFFactorFacturasBindingSource1.DataSource = Me.FactorajeDS1
        '
        'FactorajeDS1
        '
        Me.FactorajeDS1.DataSetName = "FactorajeDS"
        Me.FactorajeDS1.Locale = New System.Globalization.CultureInfo("es-ES")
        Me.FactorajeDS1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TxtIntermediario
        '
        Me.TxtIntermediario.Location = New System.Drawing.Point(326, 342)
        Me.TxtIntermediario.Name = "TxtIntermediario"
        Me.TxtIntermediario.ReadOnly = True
        Me.TxtIntermediario.Size = New System.Drawing.Size(30, 20)
        Me.TxtIntermediario.TabIndex = 198
        Me.TxtIntermediario.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'cb_prestamo
        '
        Me.cb_prestamo.DataSource = Me.CONTCPFtipoprestamosBindingSource
        Me.cb_prestamo.DisplayMember = "descripcion_prestamo"
        Me.cb_prestamo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_prestamo.FormattingEnabled = True
        Me.cb_prestamo.Location = New System.Drawing.Point(116, 418)
        Me.cb_prestamo.Name = "cb_prestamo"
        Me.cb_prestamo.Size = New System.Drawing.Size(242, 21)
        Me.cb_prestamo.TabIndex = 197
        Me.cb_prestamo.ValueMember = "id_tipo_prestamo"
        '
        'CONTCPFtipoprestamosBindingSource
        '
        Me.CONTCPFtipoprestamosBindingSource.DataMember = "CONT_CPF_tipoprestamos"
        Me.CONTCPFtipoprestamosBindingSource.DataSource = Me.DS_contratos
        '
        'DS_contratos
        '
        Me.DS_contratos.DataSetName = "DS_contratos"
        Me.DS_contratos.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'cb_operacion
        '
        Me.cb_operacion.DataSource = Me.CONTCPFoperacionBindingSource
        Me.cb_operacion.DisplayMember = "desc"
        Me.cb_operacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_operacion.FormattingEnabled = True
        Me.cb_operacion.Location = New System.Drawing.Point(116, 366)
        Me.cb_operacion.Name = "cb_operacion"
        Me.cb_operacion.Size = New System.Drawing.Size(241, 21)
        Me.cb_operacion.TabIndex = 196
        Me.cb_operacion.ValueMember = "id_operacion"
        '
        'CONTCPFoperacionBindingSource
        '
        Me.CONTCPFoperacionBindingSource.DataMember = "CONT_CPF_operacion"
        Me.CONTCPFoperacionBindingSource.DataSource = Me.DS_contratos
        '
        'Label62
        '
        Me.Label62.AutoSize = True
        Me.Label62.Location = New System.Drawing.Point(23, 375)
        Me.Label62.Name = "Label62"
        Me.Label62.Size = New System.Drawing.Size(86, 13)
        Me.Label62.TabIndex = 195
        Me.Label62.Text = "Modo Operación"
        '
        'cb_intermediario
        '
        Me.cb_intermediario.DataSource = Me.CONTCPFintermediariosBindingSource
        Me.cb_intermediario.DisplayMember = "nombre_intermediario"
        Me.cb_intermediario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_intermediario.FormattingEnabled = True
        Me.cb_intermediario.Location = New System.Drawing.Point(117, 342)
        Me.cb_intermediario.Name = "cb_intermediario"
        Me.cb_intermediario.Size = New System.Drawing.Size(203, 21)
        Me.cb_intermediario.TabIndex = 194
        Me.cb_intermediario.ValueMember = "id_intermediario"
        '
        'CONTCPFintermediariosBindingSource
        '
        Me.CONTCPFintermediariosBindingSource.DataMember = "CONT_CPF_intermediarios"
        Me.CONTCPFintermediariosBindingSource.DataSource = Me.DS_contratos
        '
        'Label57
        '
        Me.Label57.AutoSize = True
        Me.Label57.Location = New System.Drawing.Point(43, 348)
        Me.Label57.Name = "Label57"
        Me.Label57.Size = New System.Drawing.Size(67, 13)
        Me.Label57.TabIndex = 193
        Me.Label57.Text = "Intermediario"
        '
        'cb_producto
        '
        Me.cb_producto.DataSource = Me.CONTCPFproductosfiraBindingSource
        Me.cb_producto.DisplayMember = "descripcion_producto_fira"
        Me.cb_producto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_producto.FormattingEnabled = True
        Me.cb_producto.Location = New System.Drawing.Point(116, 393)
        Me.cb_producto.Name = "cb_producto"
        Me.cb_producto.Size = New System.Drawing.Size(242, 21)
        Me.cb_producto.TabIndex = 192
        Me.cb_producto.ValueMember = "id_producto_fira"
        '
        'CONTCPFproductosfiraBindingSource
        '
        Me.CONTCPFproductosfiraBindingSource.DataMember = "CONT_CPF_productos_fira"
        Me.CONTCPFproductosfiraBindingSource.DataSource = Me.DS_contratos
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(34, 427)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(75, 13)
        Me.Label5.TabIndex = 191
        Me.Label5.Text = "Tipo Préstamo"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(59, 398)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(50, 13)
        Me.Label4.TabIndex = 190
        Me.Label4.Text = "Producto"
        '
        'cb_esquema
        '
        Me.cb_esquema.DataSource = Me.CONTCPFesquemacobroBindingSource
        Me.cb_esquema.DisplayMember = "esquema_cobro"
        Me.cb_esquema.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_esquema.FormattingEnabled = True
        Me.cb_esquema.Location = New System.Drawing.Point(116, 442)
        Me.cb_esquema.Name = "cb_esquema"
        Me.cb_esquema.Size = New System.Drawing.Size(243, 21)
        Me.cb_esquema.TabIndex = 200
        Me.cb_esquema.ValueMember = "id_esquema_cobro"
        '
        'CONTCPFesquemacobroBindingSource
        '
        Me.CONTCPFesquemacobroBindingSource.DataMember = "CONT_CPF_esquema_cobro"
        Me.CONTCPFesquemacobroBindingSource.DataSource = Me.DS_contratos
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(12, 450)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(97, 13)
        Me.Label15.TabIndex = 199
        Me.Label15.Text = "Esquema de Cobro"
        '
        'cb_gl
        '
        Me.cb_gl.DataSource = Me.CONTCPFGLBindingSource
        Me.cb_gl.DisplayMember = "valor"
        Me.cb_gl.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_gl.FormattingEnabled = True
        Me.cb_gl.Location = New System.Drawing.Point(598, 363)
        Me.cb_gl.Name = "cb_gl"
        Me.cb_gl.Size = New System.Drawing.Size(85, 21)
        Me.cb_gl.TabIndex = 242
        Me.cb_gl.ValueMember = "id_gl"
        '
        'CONTCPFGLBindingSource
        '
        Me.CONTCPFGLBindingSource.DataMember = "CONT_CPF_GL"
        Me.CONTCPFGLBindingSource.DataSource = Me.DescuentosDS
        '
        'DescuentosDS
        '
        Me.DescuentosDS.DataSetName = "DescuentosDS"
        Me.DescuentosDS.Locale = New System.Globalization.CultureInfo("es-ES")
        Me.DescuentosDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(499, 369)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(86, 13)
        Me.Label16.TabIndex = 241
        Me.Label16.Text = "Garantia Líquida"
        '
        'CK_FONAGA
        '
        Me.CK_FONAGA.AutoSize = True
        Me.CK_FONAGA.Location = New System.Drawing.Point(765, 367)
        Me.CK_FONAGA.Name = "CK_FONAGA"
        Me.CK_FONAGA.Size = New System.Drawing.Size(15, 14)
        Me.CK_FONAGA.TabIndex = 240
        Me.CK_FONAGA.UseVisualStyleBackColor = True
        '
        'Label69
        '
        Me.Label69.AutoSize = True
        Me.Label69.Location = New System.Drawing.Point(704, 368)
        Me.Label69.Name = "Label69"
        Me.Label69.Size = New System.Drawing.Size(51, 13)
        Me.Label69.TabIndex = 239
        Me.Label69.Text = "FONAGA"
        '
        'Label68
        '
        Me.Label68.AutoSize = True
        Me.Label68.Location = New System.Drawing.Point(733, 394)
        Me.Label68.Name = "Label68"
        Me.Label68.Size = New System.Drawing.Size(39, 13)
        Me.Label68.TabIndex = 238
        Me.Label68.Text = "% CXS"
        '
        'Label67
        '
        Me.Label67.AutoSize = True
        Me.Label67.Location = New System.Drawing.Point(633, 395)
        Me.Label67.Name = "Label67"
        Me.Label67.Size = New System.Drawing.Size(45, 13)
        Me.Label67.TabIndex = 237
        Me.Label67.Text = "% EFEC"
        '
        'Label66
        '
        Me.Label66.AutoSize = True
        Me.Label66.Location = New System.Drawing.Point(539, 395)
        Me.Label66.Name = "Label66"
        Me.Label66.Size = New System.Drawing.Size(43, 13)
        Me.Label66.TabIndex = 236
        Me.Label66.Text = "% NOM"
        '
        'TXT_EFEC
        '
        Me.TXT_EFEC.Location = New System.Drawing.Point(684, 389)
        Me.TXT_EFEC.Name = "TXT_EFEC"
        Me.TXT_EFEC.Size = New System.Drawing.Size(27, 20)
        Me.TXT_EFEC.TabIndex = 235
        '
        'TXT_NOM
        '
        Me.TXT_NOM.Location = New System.Drawing.Point(600, 391)
        Me.TXT_NOM.Name = "TXT_NOM"
        Me.TXT_NOM.Size = New System.Drawing.Size(27, 20)
        Me.TXT_NOM.TabIndex = 234
        '
        'PCXSG_TXT
        '
        Me.PCXSG_TXT.Location = New System.Drawing.Point(778, 392)
        Me.PCXSG_TXT.Name = "PCXSG_TXT"
        Me.PCXSG_TXT.Size = New System.Drawing.Size(36, 20)
        Me.PCXSG_TXT.TabIndex = 233
        '
        'TXT_FN
        '
        Me.TXT_FN.Location = New System.Drawing.Point(598, 459)
        Me.TXT_FN.Name = "TXT_FN"
        Me.TXT_FN.Size = New System.Drawing.Size(100, 20)
        Me.TXT_FN.TabIndex = 232
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(539, 462)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(48, 13)
        Me.Label20.TabIndex = 231
        Me.Label20.Text = "Tasa FN"
        '
        'TXT_FB
        '
        Me.TXT_FB.Location = New System.Drawing.Point(598, 414)
        Me.TXT_FB.Name = "TXT_FB"
        Me.TXT_FB.Size = New System.Drawing.Size(100, 20)
        Me.TXT_FB.TabIndex = 230
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(539, 420)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(47, 13)
        Me.Label3.TabIndex = 229
        Me.Label3.Text = "Tasa FB"
        '
        'txt_BP
        '
        Me.txt_BP.Location = New System.Drawing.Point(598, 436)
        Me.txt_BP.Name = "txt_BP"
        Me.txt_BP.Size = New System.Drawing.Size(100, 20)
        Me.txt_BP.TabIndex = 225
        '
        'Label55
        '
        Me.Label55.AutoSize = True
        Me.Label55.Location = New System.Drawing.Point(535, 442)
        Me.Label55.Name = "Label55"
        Me.Label55.Size = New System.Drawing.Size(51, 13)
        Me.Label55.TabIndex = 224
        Me.Label55.Text = "Tasa  BP"
        '
        'cb_tasa
        '
        Me.cb_tasa.DataSource = Me.CONTCPFtipotasasBindingSource
        Me.cb_tasa.DisplayMember = "des_tipo_tasa"
        Me.cb_tasa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_tasa.FormattingEnabled = True
        Me.cb_tasa.Location = New System.Drawing.Point(598, 334)
        Me.cb_tasa.Name = "cb_tasa"
        Me.cb_tasa.Size = New System.Drawing.Size(157, 21)
        Me.cb_tasa.TabIndex = 223
        Me.cb_tasa.ValueMember = "id_tipo_tasa"
        '
        'CONTCPFtipotasasBindingSource
        '
        Me.CONTCPFtipotasasBindingSource.DataMember = "CONT_CPF_tipo_tasas"
        Me.CONTCPFtipotasasBindingSource.DataSource = Me.DS_contratos
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(530, 342)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(55, 13)
        Me.Label13.TabIndex = 222
        Me.Label13.Text = "Tipo Tasa"
        '
        'CONT_CPF_GLTableAdapter
        '
        Me.CONT_CPF_GLTableAdapter.ClearBeforeFill = True
        '
        'cb_divisa
        '
        Me.cb_divisa.DataSource = Me.CONTCPFdivisasBindingSource
        Me.cb_divisa.DisplayMember = "codigo"
        Me.cb_divisa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_divisa.FormattingEnabled = True
        Me.cb_divisa.Location = New System.Drawing.Point(116, 469)
        Me.cb_divisa.Name = "cb_divisa"
        Me.cb_divisa.Size = New System.Drawing.Size(85, 21)
        Me.cb_divisa.TabIndex = 243
        Me.cb_divisa.ValueMember = "id_divisa"
        '
        'CONTCPFdivisasBindingSource
        '
        Me.CONTCPFdivisasBindingSource.DataMember = "CONT_CPF_divisas"
        Me.CONTCPFdivisasBindingSource.DataSource = Me.DS_contratos
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(59, 477)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(36, 13)
        Me.Label1.TabIndex = 244
        Me.Label1.Text = "Divisa"
        '
        'FactorajeDS2
        '
        Me.FactorajeDS2.DataSetName = "FactorajeDS"
        Me.FactorajeDS2.Locale = New System.Globalization.CultureInfo("es-ES")
        Me.FactorajeDS2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ClientesBindingSource
        '
        Me.ClientesBindingSource.DataMember = "Clientes"
        Me.ClientesBindingSource.DataSource = Me.FactorajeDS2
        '
        'ClientesTableAdapter
        '
        Me.ClientesTableAdapter.ClearBeforeFill = True
        '
        'TXT_IVA
        '
        Me.TXT_IVA.Location = New System.Drawing.Point(891, 389)
        Me.TXT_IVA.Name = "TXT_IVA"
        Me.TXT_IVA.Size = New System.Drawing.Size(43, 20)
        Me.TXT_IVA.TabIndex = 246
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(832, 392)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(51, 13)
        Me.Label2.TabIndex = 245
        Me.Label2.Text = "Tasa IVA"
        '
        'ch_subsidio
        '
        Me.ch_subsidio.AutoSize = True
        Me.ch_subsidio.Location = New System.Drawing.Point(120, 509)
        Me.ch_subsidio.Name = "ch_subsidio"
        Me.ch_subsidio.Size = New System.Drawing.Size(15, 14)
        Me.ch_subsidio.TabIndex = 248
        Me.ch_subsidio.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(59, 510)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(47, 13)
        Me.Label6.TabIndex = 247
        Me.Label6.Text = "Subsidio"
        '
        'ComboBox1
        '
        Me.ComboBox1.DataSource = Me.CONTCPFcontratosBindingSource
        Me.ComboBox1.DisplayMember = "id_gl"
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(388, 462)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(85, 21)
        Me.ComboBox1.TabIndex = 249
        Me.ComboBox1.ValueMember = "id_gl"
        '
        'CONTCPFcontratosBindingSource
        '
        Me.CONTCPFcontratosBindingSource.DataMember = "CONT_CPF_contratos"
        Me.CONTCPFcontratosBindingSource.DataSource = Me.DS_contratos
        '
        'MinistracionesBindingSource
        '
        Me.MinistracionesBindingSource.DataMember = "Ministraciones"
        Me.MinistracionesBindingSource.DataSource = Me.DescuentosDS
        '
        'MinistracionesTableAdapter
        '
        Me.MinistracionesTableAdapter.ClearBeforeFill = True
        '
        'CLIENTETXT
        '
        Me.CLIENTETXT.Location = New System.Drawing.Point(388, 427)
        Me.CLIENTETXT.Name = "CLIENTETXT"
        Me.CLIENTETXT.Size = New System.Drawing.Size(27, 20)
        Me.CLIENTETXT.TabIndex = 250
        '
        'CONT_CPF_intermediariosTableAdapter
        '
        Me.CONT_CPF_intermediariosTableAdapter.ClearBeforeFill = True
        '
        'CONT_CPF_operacionTableAdapter
        '
        Me.CONT_CPF_operacionTableAdapter.ClearBeforeFill = True
        '
        'CONT_CPF_productos_firaTableAdapter
        '
        Me.CONT_CPF_productos_firaTableAdapter.ClearBeforeFill = True
        '
        'CONT_CPF_tipoprestamosTableAdapter
        '
        Me.CONT_CPF_tipoprestamosTableAdapter.ClearBeforeFill = True
        '
        'CONT_CPF_esquema_cobroTableAdapter
        '
        Me.CONT_CPF_esquema_cobroTableAdapter.ClearBeforeFill = True
        '
        'CONT_CPF_tipo_tasasTableAdapter
        '
        Me.CONT_CPF_tipo_tasasTableAdapter.ClearBeforeFill = True
        '
        'CONTCPFconfiguracionBindingSource
        '
        Me.CONTCPFconfiguracionBindingSource.DataMember = "CONT_CPF_configuracion"
        Me.CONTCPFconfiguracionBindingSource.DataSource = Me.DS_contratos
        '
        'CONT_CPF_configuracionTableAdapter
        '
        Me.CONT_CPF_configuracionTableAdapter.ClearBeforeFill = True
        '
        'CONT_CPF_divisasTableAdapter
        '
        Me.CONT_CPF_divisasTableAdapter.ClearBeforeFill = True
        '
        'CONTCPFcontratosgarantiasBindingSource
        '
        Me.CONTCPFcontratosgarantiasBindingSource.DataMember = "CONT_CPF_contratos_garantias"
        Me.CONTCPFcontratosgarantiasBindingSource.DataSource = Me.DS_contratos
        '
        'CONT_CPF_contratos_garantiasTableAdapter
        '
        Me.CONT_CPF_contratos_garantiasTableAdapter.ClearBeforeFill = True
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
        'CONT_CPF_contratosTableAdapter
        '
        Me.CONT_CPF_contratosTableAdapter.ClearBeforeFill = True
        '
        'Label63
        '
        Me.Label63.AutoSize = True
        Me.Label63.Location = New System.Drawing.Point(453, 545)
        Me.Label63.Name = "Label63"
        Me.Label63.Size = New System.Drawing.Size(133, 13)
        Me.Label63.TabIndex = 257
        Me.Label63.Text = "Periodo Revision Intereses"
        '
        'Label59
        '
        Me.Label59.AutoSize = True
        Me.Label59.Location = New System.Drawing.Point(493, 518)
        Me.Label59.Name = "Label59"
        Me.Label59.Size = New System.Drawing.Size(89, 13)
        Me.Label59.TabIndex = 256
        Me.Label59.Text = "Periodo Intereses"
        '
        'Label54
        '
        Me.Label54.AutoSize = True
        Me.Label54.Location = New System.Drawing.Point(504, 491)
        Me.Label54.Name = "Label54"
        Me.Label54.Size = New System.Drawing.Size(78, 13)
        Me.Label54.TabIndex = 255
        Me.Label54.Text = "Periodo Capital"
        '
        'cb_periodo_revision
        '
        Me.cb_periodo_revision.DataSource = Me.CONTCPFperiodicidadBindingSource2
        Me.cb_periodo_revision.DisplayMember = "descripcion"
        Me.cb_periodo_revision.FormattingEnabled = True
        Me.cb_periodo_revision.Location = New System.Drawing.Point(600, 538)
        Me.cb_periodo_revision.Name = "cb_periodo_revision"
        Me.cb_periodo_revision.Size = New System.Drawing.Size(121, 21)
        Me.cb_periodo_revision.TabIndex = 254
        Me.cb_periodo_revision.ValueMember = "id_periodo"
        '
        'CONTCPFperiodicidadBindingSource2
        '
        Me.CONTCPFperiodicidadBindingSource2.DataMember = "CONT_CPF_periodicidad"
        Me.CONTCPFperiodicidadBindingSource2.DataSource = Me.DS_contratos
        '
        'cb_periodo_int
        '
        Me.cb_periodo_int.DataSource = Me.CONTCPFperiodicidadBindingSource1
        Me.cb_periodo_int.DisplayMember = "descripcion"
        Me.cb_periodo_int.FormattingEnabled = True
        Me.cb_periodo_int.Location = New System.Drawing.Point(600, 515)
        Me.cb_periodo_int.Name = "cb_periodo_int"
        Me.cb_periodo_int.Size = New System.Drawing.Size(121, 21)
        Me.cb_periodo_int.TabIndex = 253
        Me.cb_periodo_int.ValueMember = "id_periodo"
        '
        'CONTCPFperiodicidadBindingSource1
        '
        Me.CONTCPFperiodicidadBindingSource1.DataMember = "CONT_CPF_periodicidad"
        Me.CONTCPFperiodicidadBindingSource1.DataSource = Me.DS_contratos
        '
        'cb_periodo_capital
        '
        Me.cb_periodo_capital.DataSource = Me.CONTCPFperiodicidadBindingSource
        Me.cb_periodo_capital.DisplayMember = "descripcion"
        Me.cb_periodo_capital.FormattingEnabled = True
        Me.cb_periodo_capital.Location = New System.Drawing.Point(599, 488)
        Me.cb_periodo_capital.Name = "cb_periodo_capital"
        Me.cb_periodo_capital.Size = New System.Drawing.Size(121, 21)
        Me.cb_periodo_capital.TabIndex = 252
        Me.cb_periodo_capital.ValueMember = "id_periodo"
        '
        'CONTCPFperiodicidadBindingSource
        '
        Me.CONTCPFperiodicidadBindingSource.DataMember = "CONT_CPF_periodicidad"
        Me.CONTCPFperiodicidadBindingSource.DataSource = Me.DS_contratos
        '
        'CONT_CPF_periodicidadTableAdapter
        '
        Me.CONT_CPF_periodicidadTableAdapter.ClearBeforeFill = True
        '
        'ComboBox2
        '
        Me.ComboBox2.DataSource = Me.WEBLotesBindingSource
        Me.ComboBox2.DisplayMember = "Id_Lote"
        Me.ComboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Location = New System.Drawing.Point(86, 3)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(203, 21)
        Me.ComboBox2.TabIndex = 259
        Me.ComboBox2.ValueMember = "Id_Lote"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(12, 9)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(67, 13)
        Me.Label7.TabIndex = 258
        Me.Label7.Text = "Intermediario"
        '
        'WEBLotesBindingSource
        '
        Me.WEBLotesBindingSource.DataMember = "WEB_Lotes"
        Me.WEBLotesBindingSource.DataSource = Me.FactorajeDS
        '
        'WEB_LotesTableAdapter
        '
        Me.WEB_LotesTableAdapter.ClearBeforeFill = True
        '
        'Frm_DescuentosFAC
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1005, 597)
        Me.Controls.Add(Me.ComboBox2)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label63)
        Me.Controls.Add(Me.Label59)
        Me.Controls.Add(Me.Label54)
        Me.Controls.Add(Me.cb_periodo_revision)
        Me.Controls.Add(Me.cb_periodo_int)
        Me.Controls.Add(Me.cb_periodo_capital)
        Me.Controls.Add(Me.CLIENTETXT)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.ch_subsidio)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.TXT_IVA)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cb_divisa)
        Me.Controls.Add(Me.cb_gl)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.CK_FONAGA)
        Me.Controls.Add(Me.Label69)
        Me.Controls.Add(Me.Label68)
        Me.Controls.Add(Me.Label67)
        Me.Controls.Add(Me.Label66)
        Me.Controls.Add(Me.TXT_EFEC)
        Me.Controls.Add(Me.TXT_NOM)
        Me.Controls.Add(Me.PCXSG_TXT)
        Me.Controls.Add(Me.TXT_FN)
        Me.Controls.Add(Me.Label20)
        Me.Controls.Add(Me.TXT_FB)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txt_BP)
        Me.Controls.Add(Me.Label55)
        Me.Controls.Add(Me.cb_tasa)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.cb_esquema)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.TxtIntermediario)
        Me.Controls.Add(Me.cb_prestamo)
        Me.Controls.Add(Me.cb_operacion)
        Me.Controls.Add(Me.Label62)
        Me.Controls.Add(Me.cb_intermediario)
        Me.Controls.Add(Me.Label57)
        Me.Controls.Add(Me.cb_producto)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.DGFACT)
        Me.Controls.Add(Me.Button1)
        Me.Name = "Frm_DescuentosFAC"
        Me.Text = "Frm_DescuentosFAC"
        CType(Me.CONTCPFFactorFacturasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FactorajeDS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DGFACT, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CONTCPFFactorFacturasBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FactorajeDS1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CONTCPFtipoprestamosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DS_contratos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CONTCPFoperacionBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CONTCPFintermediariosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CONTCPFproductosfiraBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CONTCPFesquemacobroBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CONTCPFGLBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DescuentosDS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CONTCPFtipotasasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CONTCPFdivisasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FactorajeDS2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClientesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CONTCPFcontratosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MinistracionesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CONTCPFconfiguracionBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CONTCPFcontratosgarantiasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CONTCPFvencimientosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CONTCPFperiodicidadBindingSource2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CONTCPFperiodicidadBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CONTCPFperiodicidadBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WEBLotesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents FactorajeDS As FactorajeDS
    Friend WithEvents CONTCPFFactorFacturasBindingSource As BindingSource
    Friend WithEvents CONT_CPF_Factor_FacturasTableAdapter As FactorajeDSTableAdapters.CONT_CPF_Factor_FacturasTableAdapter
    Friend WithEvents Button1 As Button
    Friend WithEvents FacturaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents RFCDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DGFACT As DataGridView
    Friend WithEvents FactorajeDS1 As FactorajeDS
    Friend WithEvents CONTCPFFactorFacturasBindingSource1 As BindingSource
    Friend WithEvents TxtIntermediario As TextBox
    Friend WithEvents cb_prestamo As ComboBox
    Friend WithEvents cb_operacion As ComboBox
    Friend WithEvents Label62 As Label
    Friend WithEvents cb_intermediario As ComboBox
    Friend WithEvents Label57 As Label
    Friend WithEvents cb_producto As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents cb_esquema As ComboBox
    Friend WithEvents Label15 As Label
    Friend WithEvents cb_gl As ComboBox
    Friend WithEvents Label16 As Label
    Friend WithEvents CK_FONAGA As CheckBox
    Friend WithEvents Label69 As Label
    Friend WithEvents Label68 As Label
    Friend WithEvents Label67 As Label
    Friend WithEvents Label66 As Label
    Friend WithEvents TXT_EFEC As TextBox
    Friend WithEvents TXT_NOM As TextBox
    Friend WithEvents PCXSG_TXT As TextBox
    Friend WithEvents TXT_FN As TextBox
    Friend WithEvents Label20 As Label
    Friend WithEvents TXT_FB As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txt_BP As TextBox
    Friend WithEvents Label55 As Label
    Friend WithEvents cb_tasa As ComboBox
    Friend WithEvents Label13 As Label
    Friend WithEvents DS_contratos As DS_contratos
    Friend WithEvents CONTCPFintermediariosBindingSource As BindingSource
    Friend WithEvents CONT_CPF_intermediariosTableAdapter As DS_contratosTableAdapters.CONT_CPF_intermediariosTableAdapter
    Friend WithEvents CONTCPFoperacionBindingSource As BindingSource
    Friend WithEvents CONT_CPF_operacionTableAdapter As DS_contratosTableAdapters.CONT_CPF_operacionTableAdapter
    Friend WithEvents CONTCPFproductosfiraBindingSource As BindingSource
    Friend WithEvents CONT_CPF_productos_firaTableAdapter As DS_contratosTableAdapters.CONT_CPF_productos_firaTableAdapter
    Friend WithEvents CONTCPFtipoprestamosBindingSource As BindingSource
    Friend WithEvents CONT_CPF_tipoprestamosTableAdapter As DS_contratosTableAdapters.CONT_CPF_tipoprestamosTableAdapter
    Friend WithEvents CONTCPFesquemacobroBindingSource As BindingSource
    Friend WithEvents CONT_CPF_esquema_cobroTableAdapter As DS_contratosTableAdapters.CONT_CPF_esquema_cobroTableAdapter
    Friend WithEvents CONTCPFtipotasasBindingSource As BindingSource
    Friend WithEvents CONT_CPF_tipo_tasasTableAdapter As DS_contratosTableAdapters.CONT_CPF_tipo_tasasTableAdapter
    Friend WithEvents DescuentosDS As DescuentosDS
    Friend WithEvents CONTCPFGLBindingSource As BindingSource
    Friend WithEvents CONT_CPF_GLTableAdapter As DescuentosDSTableAdapters.CONT_CPF_GLTableAdapter
    Friend WithEvents CONTCPFconfiguracionBindingSource As BindingSource
    Friend WithEvents CONT_CPF_configuracionTableAdapter As DS_contratosTableAdapters.CONT_CPF_configuracionTableAdapter
    Friend WithEvents cb_divisa As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents CONTCPFdivisasBindingSource As BindingSource
    Friend WithEvents CONT_CPF_divisasTableAdapter As DS_contratosTableAdapters.CONT_CPF_divisasTableAdapter
    Friend WithEvents FactorajeDS2 As FactorajeDS
    Friend WithEvents ClientesBindingSource As BindingSource
    Friend WithEvents ClientesTableAdapter As FactorajeDSTableAdapters.ClientesTableAdapter
    Friend WithEvents TXT_IVA As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents ch_subsidio As CheckBox
    Friend WithEvents Label6 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents CONTCPFcontratosgarantiasBindingSource As BindingSource
    Friend WithEvents CONT_CPF_contratos_garantiasTableAdapter As DS_contratosTableAdapters.CONT_CPF_contratos_garantiasTableAdapter
    Friend WithEvents CONTCPFvencimientosBindingSource As BindingSource
    Friend WithEvents CONT_CPF_vencimientosTableAdapter As DS_contratosTableAdapters.CONT_CPF_vencimientosTableAdapter
    Friend WithEvents MinistracionesBindingSource As BindingSource
    Friend WithEvents MinistracionesTableAdapter As DescuentosDSTableAdapters.MinistracionesTableAdapter
    Friend WithEvents CLIENTETXT As TextBox
    Friend WithEvents FacturaDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents RFCDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents RFCCONTRAPARTEDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MONTOSOLICITADODataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TASAIFDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FECHADEEXPEDICIÓNDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FECHADEVENCIMIENTODataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LoteDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents id_Factura As DataGridViewTextBoxColumn
    Friend WithEvents CONTCPFcontratosBindingSource As BindingSource
    Friend WithEvents CONT_CPF_contratosTableAdapter As DS_contratosTableAdapters.CONT_CPF_contratosTableAdapter
    Friend WithEvents Label63 As Label
    Friend WithEvents Label59 As Label
    Friend WithEvents Label54 As Label
    Friend WithEvents cb_periodo_revision As ComboBox
    Friend WithEvents cb_periodo_int As ComboBox
    Friend WithEvents cb_periodo_capital As ComboBox
    Friend WithEvents CONTCPFperiodicidadBindingSource As BindingSource
    Friend WithEvents CONT_CPF_periodicidadTableAdapter As DS_contratosTableAdapters.CONT_CPF_periodicidadTableAdapter
    Friend WithEvents CONTCPFperiodicidadBindingSource2 As BindingSource
    Friend WithEvents CONTCPFperiodicidadBindingSource1 As BindingSource
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents WEBLotesBindingSource As BindingSource
    Friend WithEvents WEB_LotesTableAdapter As FactorajeDSTableAdapters.WEB_LotesTableAdapter
End Class
