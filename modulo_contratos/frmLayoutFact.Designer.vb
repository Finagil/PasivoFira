<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLayoutFact
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
        Me.Button2 = New System.Windows.Forms.Button()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.WEBLotesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.FactorajeDS = New Fira_Cartera_Pasiva.FactorajeDS()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cb_divisa = New System.Windows.Forms.ComboBox()
        Me.CONTCPFdivisasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DS_contratos = New Fira_Cartera_Pasiva.DS_contratos()
        Me.Label66 = New System.Windows.Forms.Label()
        Me.TXT_NOM = New System.Windows.Forms.TextBox()
        Me.cb_producto = New System.Windows.Forms.ComboBox()
        Me.CONTCPFproductosfiraBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label4 = New System.Windows.Forms.Label()
        Me.DGFACT = New System.Windows.Forms.DataGridView()
        Me.FacturaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RFCDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RFCCONTRAPARTEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MONTOSOLICITADODataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TASAIFDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FECHADEEXPEDICIÓNDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FECHADEVENCIMIENTODataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LoteDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdFacturaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CONTCPFFactorFacturasBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.clientetxt = New System.Windows.Forms.TextBox()
        Me.WEB_LotesTableAdapter = New Fira_Cartera_Pasiva.FactorajeDSTableAdapters.WEB_LotesTableAdapter()
        Me.DScontratosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CONT_CPF_productos_firaTableAdapter = New Fira_Cartera_Pasiva.DS_contratosTableAdapters.CONT_CPF_productos_firaTableAdapter()
        Me.CONT_CPF_divisasTableAdapter = New Fira_Cartera_Pasiva.DS_contratosTableAdapters.CONT_CPF_divisasTableAdapter()
        Me.CONTCPFconfiguracionBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CONT_CPF_configuracionTableAdapter = New Fira_Cartera_Pasiva.DS_contratosTableAdapters.CONT_CPF_configuracionTableAdapter()
        Me.CONTCPFFactorFacturasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CONT_CPF_Factor_FacturasTableAdapter = New Fira_Cartera_Pasiva.FactorajeDSTableAdapters.CONT_CPF_Factor_FacturasTableAdapter()
        Me.ClientesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ClientesTableAdapter = New Fira_Cartera_Pasiva.DS_contratosTableAdapters.ClientesTableAdapter()
        Me.DTFecha = New System.Windows.Forms.DateTimePicker()
        Me.bt_cambiarFecha = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.FactorajeDS1 = New Fira_Cartera_Pasiva.FactorajeDS()
        Me.GENCorreosSistemaFinagilBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GEN_Correos_SistemaFinagilTableAdapter = New Fira_Cartera_Pasiva.FactorajeDSTableAdapters.GEN_Correos_SistemaFinagilTableAdapter()
        Me.CONTCPFlotesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CONT_CPF_lotesTableAdapter = New Fira_Cartera_Pasiva.FactorajeDSTableAdapters.CONT_CPF_lotesTableAdapter()
        CType(Me.WEBLotesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FactorajeDS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CONTCPFdivisasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DS_contratos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CONTCPFproductosfiraBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DGFACT, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CONTCPFFactorFacturasBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DScontratosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CONTCPFconfiguracionBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CONTCPFFactorFacturasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClientesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FactorajeDS1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GENCorreosSistemaFinagilBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CONTCPFlotesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(401, 368)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(90, 32)
        Me.Button2.TabIndex = 308
        Me.Button2.Text = "Generar Layout"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'ComboBox2
        '
        Me.ComboBox2.DataSource = Me.WEBLotesBindingSource
        Me.ComboBox2.DisplayMember = "Id_Lote"
        Me.ComboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Location = New System.Drawing.Point(97, 29)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(203, 21)
        Me.ComboBox2.TabIndex = 306
        Me.ComboBox2.ValueMember = "Id_Lote"
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
        Me.Label7.Location = New System.Drawing.Point(23, 35)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(33, 13)
        Me.Label7.TabIndex = 305
        Me.Label7.Text = "Lotes"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(55, 428)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(36, 13)
        Me.Label1.TabIndex = 294
        Me.Label1.Text = "Divisa"
        '
        'cb_divisa
        '
        Me.cb_divisa.DataSource = Me.CONTCPFdivisasBindingSource
        Me.cb_divisa.DisplayMember = "codigo"
        Me.cb_divisa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_divisa.FormattingEnabled = True
        Me.cb_divisa.Location = New System.Drawing.Point(97, 428)
        Me.cb_divisa.Name = "cb_divisa"
        Me.cb_divisa.Size = New System.Drawing.Size(85, 21)
        Me.cb_divisa.TabIndex = 293
        Me.cb_divisa.ValueMember = "id_divisa"
        '
        'CONTCPFdivisasBindingSource
        '
        Me.CONTCPFdivisasBindingSource.DataMember = "CONT_CPF_divisas"
        Me.CONTCPFdivisasBindingSource.DataSource = Me.DS_contratos
        '
        'DS_contratos
        '
        Me.DS_contratos.DataSetName = "DS_contratos"
        Me.DS_contratos.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label66
        '
        Me.Label66.AutoSize = True
        Me.Label66.Location = New System.Drawing.Point(48, 401)
        Me.Label66.Name = "Label66"
        Me.Label66.Size = New System.Drawing.Size(43, 13)
        Me.Label66.TabIndex = 286
        Me.Label66.Text = "% NOM"
        '
        'TXT_NOM
        '
        Me.TXT_NOM.Location = New System.Drawing.Point(97, 398)
        Me.TXT_NOM.Name = "TXT_NOM"
        Me.TXT_NOM.Size = New System.Drawing.Size(27, 20)
        Me.TXT_NOM.TabIndex = 284
        Me.TXT_NOM.Text = "0"
        '
        'cb_producto
        '
        Me.cb_producto.DataSource = Me.CONTCPFproductosfiraBindingSource
        Me.cb_producto.DisplayMember = "descripcion_producto_fira"
        Me.cb_producto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_producto.FormattingEnabled = True
        Me.cb_producto.Location = New System.Drawing.Point(97, 368)
        Me.cb_producto.Name = "cb_producto"
        Me.cb_producto.Size = New System.Drawing.Size(242, 21)
        Me.cb_producto.TabIndex = 266
        Me.cb_producto.ValueMember = "id_producto_fira"
        '
        'CONTCPFproductosfiraBindingSource
        '
        Me.CONTCPFproductosfiraBindingSource.DataMember = "CONT_CPF_productos_fira"
        Me.CONTCPFproductosfiraBindingSource.DataSource = Me.DS_contratos
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(41, 371)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(50, 13)
        Me.Label4.TabIndex = 264
        Me.Label4.Text = "Producto"
        '
        'DGFACT
        '
        Me.DGFACT.AllowUserToAddRows = False
        Me.DGFACT.AllowUserToDeleteRows = False
        Me.DGFACT.AutoGenerateColumns = False
        Me.DGFACT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGFACT.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.FacturaDataGridViewTextBoxColumn, Me.RFCDataGridViewTextBoxColumn, Me.RFCCONTRAPARTEDataGridViewTextBoxColumn, Me.MONTOSOLICITADODataGridViewTextBoxColumn, Me.TASAIFDataGridViewTextBoxColumn, Me.FECHADEEXPEDICIÓNDataGridViewTextBoxColumn, Me.FECHADEVENCIMIENTODataGridViewTextBoxColumn, Me.LoteDataGridViewTextBoxColumn, Me.IdFacturaDataGridViewTextBoxColumn})
        Me.DGFACT.DataSource = Me.CONTCPFFactorFacturasBindingSource1
        Me.DGFACT.Location = New System.Drawing.Point(26, 56)
        Me.DGFACT.Name = "DGFACT"
        Me.DGFACT.ReadOnly = True
        Me.DGFACT.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGFACT.Size = New System.Drawing.Size(889, 290)
        Me.DGFACT.TabIndex = 263
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
        'IdFacturaDataGridViewTextBoxColumn
        '
        Me.IdFacturaDataGridViewTextBoxColumn.DataPropertyName = "id_Factura"
        Me.IdFacturaDataGridViewTextBoxColumn.HeaderText = "id_Factura"
        Me.IdFacturaDataGridViewTextBoxColumn.Name = "IdFacturaDataGridViewTextBoxColumn"
        Me.IdFacturaDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CONTCPFFactorFacturasBindingSource1
        '
        Me.CONTCPFFactorFacturasBindingSource1.DataMember = "CONT_CPF_Factor_Facturas"
        Me.CONTCPFFactorFacturasBindingSource1.DataSource = Me.FactorajeDS
        '
        'clientetxt
        '
        Me.clientetxt.Location = New System.Drawing.Point(806, 312)
        Me.clientetxt.Name = "clientetxt"
        Me.clientetxt.Size = New System.Drawing.Size(100, 20)
        Me.clientetxt.TabIndex = 307
        Me.clientetxt.Text = "0"
        '
        'WEB_LotesTableAdapter
        '
        Me.WEB_LotesTableAdapter.ClearBeforeFill = True
        '
        'DScontratosBindingSource
        '
        Me.DScontratosBindingSource.DataSource = Me.DS_contratos
        Me.DScontratosBindingSource.Position = 0
        '
        'CONT_CPF_productos_firaTableAdapter
        '
        Me.CONT_CPF_productos_firaTableAdapter.ClearBeforeFill = True
        '
        'CONT_CPF_divisasTableAdapter
        '
        Me.CONT_CPF_divisasTableAdapter.ClearBeforeFill = True
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
        'CONTCPFFactorFacturasBindingSource
        '
        Me.CONTCPFFactorFacturasBindingSource.DataMember = "CONT_CPF_Factor_Facturas"
        Me.CONTCPFFactorFacturasBindingSource.DataSource = Me.FactorajeDS
        '
        'CONT_CPF_Factor_FacturasTableAdapter
        '
        Me.CONT_CPF_Factor_FacturasTableAdapter.ClearBeforeFill = True
        '
        'ClientesBindingSource
        '
        Me.ClientesBindingSource.DataMember = "Clientes"
        Me.ClientesBindingSource.DataSource = Me.DS_contratos
        '
        'ClientesTableAdapter
        '
        Me.ClientesTableAdapter.ClearBeforeFill = True
        '
        'DTFecha
        '
        Me.DTFecha.Location = New System.Drawing.Point(971, 95)
        Me.DTFecha.Name = "DTFecha"
        Me.DTFecha.Size = New System.Drawing.Size(200, 20)
        Me.DTFecha.TabIndex = 310
        Me.DTFecha.Value = New Date(2019, 7, 19, 16, 59, 14, 0)
        '
        'bt_cambiarFecha
        '
        Me.bt_cambiarFecha.Location = New System.Drawing.Point(970, 121)
        Me.bt_cambiarFecha.Name = "bt_cambiarFecha"
        Me.bt_cambiarFecha.Size = New System.Drawing.Size(90, 32)
        Me.bt_cambiarFecha.TabIndex = 311
        Me.bt_cambiarFecha.Text = "Cambiar Fecha"
        Me.bt_cambiarFecha.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(968, 70)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(92, 13)
        Me.Label2.TabIndex = 312
        Me.Label2.Text = "Fecha Expedición"
        '
        'FactorajeDS1
        '
        Me.FactorajeDS1.DataSetName = "FactorajeDS"
        Me.FactorajeDS1.Locale = New System.Globalization.CultureInfo("es-ES")
        Me.FactorajeDS1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GENCorreosSistemaFinagilBindingSource
        '
        Me.GENCorreosSistemaFinagilBindingSource.DataMember = "GEN_Correos_SistemaFinagil"
        Me.GENCorreosSistemaFinagilBindingSource.DataSource = Me.FactorajeDS1
        '
        'GEN_Correos_SistemaFinagilTableAdapter
        '
        Me.GEN_Correos_SistemaFinagilTableAdapter.ClearBeforeFill = True
        '
        'CONTCPFlotesBindingSource
        '
        Me.CONTCPFlotesBindingSource.DataMember = "CONT_CPF_lotes"
        Me.CONTCPFlotesBindingSource.DataSource = Me.FactorajeDS
        '
        'CONT_CPF_lotesTableAdapter
        '
        Me.CONT_CPF_lotesTableAdapter.ClearBeforeFill = True
        '
        'frmLayoutFact
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1370, 646)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.bt_cambiarFecha)
        Me.Controls.Add(Me.DTFecha)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.ComboBox2)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cb_divisa)
        Me.Controls.Add(Me.Label66)
        Me.Controls.Add(Me.TXT_NOM)
        Me.Controls.Add(Me.cb_producto)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.DGFACT)
        Me.Controls.Add(Me.clientetxt)
        Me.Name = "frmLayoutFact"
        Me.Text = "frmLayoutFact"
        CType(Me.WEBLotesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FactorajeDS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CONTCPFdivisasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DS_contratos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CONTCPFproductosfiraBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DGFACT, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CONTCPFFactorFacturasBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DScontratosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CONTCPFconfiguracionBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CONTCPFFactorFacturasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClientesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FactorajeDS1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GENCorreosSistemaFinagilBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CONTCPFlotesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button2 As Button
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents cb_divisa As ComboBox
    Friend WithEvents Label66 As Label
    Friend WithEvents TXT_NOM As TextBox
    Friend WithEvents cb_producto As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents DGFACT As DataGridView
    Friend WithEvents clientetxt As TextBox
    Friend WithEvents FactorajeDS As FactorajeDS
    Friend WithEvents WEBLotesBindingSource As BindingSource
    Friend WithEvents WEB_LotesTableAdapter As FactorajeDSTableAdapters.WEB_LotesTableAdapter
    Friend WithEvents DScontratosBindingSource As BindingSource
    Friend WithEvents DS_contratos As DS_contratos
    Friend WithEvents CONTCPFproductosfiraBindingSource As BindingSource
    Friend WithEvents CONT_CPF_productos_firaTableAdapter As DS_contratosTableAdapters.CONT_CPF_productos_firaTableAdapter
    Friend WithEvents CONTCPFdivisasBindingSource As BindingSource
    Friend WithEvents CONT_CPF_divisasTableAdapter As DS_contratosTableAdapters.CONT_CPF_divisasTableAdapter
    Friend WithEvents CONTCPFconfiguracionBindingSource As BindingSource
    Friend WithEvents CONT_CPF_configuracionTableAdapter As DS_contratosTableAdapters.CONT_CPF_configuracionTableAdapter
    Friend WithEvents CONTCPFFactorFacturasBindingSource As BindingSource
    Friend WithEvents CONT_CPF_Factor_FacturasTableAdapter As FactorajeDSTableAdapters.CONT_CPF_Factor_FacturasTableAdapter
    Friend WithEvents ClientesBindingSource As BindingSource
    Friend WithEvents ClientesTableAdapter As DS_contratosTableAdapters.ClientesTableAdapter
    Friend WithEvents CONTCPFFactorFacturasBindingSource1 As BindingSource
    Friend WithEvents FacturaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents RFCDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents RFCCONTRAPARTEDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MONTOSOLICITADODataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TASAIFDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FECHADEEXPEDICIÓNDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FECHADEVENCIMIENTODataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LoteDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents IdFacturaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DTFecha As DateTimePicker
    Friend WithEvents bt_cambiarFecha As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents FactorajeDS1 As FactorajeDS
    Friend WithEvents GENCorreosSistemaFinagilBindingSource As BindingSource
    Friend WithEvents GEN_Correos_SistemaFinagilTableAdapter As FactorajeDSTableAdapters.GEN_Correos_SistemaFinagilTableAdapter
    Friend WithEvents CONTCPFlotesBindingSource As BindingSource
    Friend WithEvents CONT_CPF_lotesTableAdapter As FactorajeDSTableAdapters.CONT_CPF_lotesTableAdapter
End Class
