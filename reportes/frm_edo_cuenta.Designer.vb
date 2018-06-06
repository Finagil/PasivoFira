<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_edo_cuenta
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TXT_ORD_VE = New System.Windows.Forms.TextBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.FechaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ImporteDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FacturaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PagosClienteBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DS_reportes = New Fira_Cartera_Pasiva.DS_reportes()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.TxtTotal = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txt_cap_int_ve = New System.Windows.Forms.TextBox()
        Me.txt_cap_ve = New System.Windows.Forms.TextBox()
        Me.TXT_MOR_PE = New System.Windows.Forms.TextBox()
        Me.TXT_FIN_VE = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.TXT_CAP_INT_VIG = New System.Windows.Forms.TextBox()
        Me.TXT_CAP_VI = New System.Windows.Forms.TextBox()
        Me.TXT_MOR_OR = New System.Windows.Forms.TextBox()
        Me.TXT_FIN_VI = New System.Windows.Forms.TextBox()
        Me.TXT_ORD_VI = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TXT_ORD_VE1 = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Dtp_Fecha = New System.Windows.Forms.DateTimePicker()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.TxtPago = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.PagosClienteTableAdapter = New Fira_Cartera_Pasiva.DS_reportesTableAdapters.PagosClienteTableAdapter()
        Me.DS_contratos = New Fira_Cartera_Pasiva.DS_contratos()
        Me.CONT_CPF_edocuentaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CONT_CPF_edocuentaTableAdapter = New Fira_Cartera_Pasiva.DS_contratosTableAdapters.CONT_CPF_edocuentaTableAdapter()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PagosClienteBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DS_reportes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DS_contratos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CONT_CPF_edocuentaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.TXT_ORD_VE)
        Me.GroupBox1.Controls.Add(Me.DataGridView1)
        Me.GroupBox1.Controls.Add(Me.Label14)
        Me.GroupBox1.Controls.Add(Me.TxtTotal)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.txt_cap_int_ve)
        Me.GroupBox1.Controls.Add(Me.txt_cap_ve)
        Me.GroupBox1.Controls.Add(Me.TXT_MOR_PE)
        Me.GroupBox1.Controls.Add(Me.TXT_FIN_VE)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.TXT_CAP_INT_VIG)
        Me.GroupBox1.Controls.Add(Me.TXT_CAP_VI)
        Me.GroupBox1.Controls.Add(Me.TXT_MOR_OR)
        Me.GroupBox1.Controls.Add(Me.TXT_FIN_VI)
        Me.GroupBox1.Controls.Add(Me.TXT_ORD_VI)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(775, 174)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Saldo"
        '
        'TXT_ORD_VE
        '
        Me.TXT_ORD_VE.Location = New System.Drawing.Point(313, 26)
        Me.TXT_ORD_VE.Name = "TXT_ORD_VE"
        Me.TXT_ORD_VE.ReadOnly = True
        Me.TXT_ORD_VE.Size = New System.Drawing.Size(86, 20)
        Me.TXT_ORD_VE.TabIndex = 9
        Me.TXT_ORD_VE.Text = "0.00"
        Me.TXT_ORD_VE.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.FechaDataGridViewTextBoxColumn, Me.ImporteDataGridViewTextBoxColumn, Me.FacturaDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.PagosClienteBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(408, 33)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(355, 131)
        Me.DataGridView1.TabIndex = 23
        '
        'FechaDataGridViewTextBoxColumn
        '
        Me.FechaDataGridViewTextBoxColumn.DataPropertyName = "Fecha"
        DataGridViewCellStyle1.Format = "d"
        DataGridViewCellStyle1.NullValue = Nothing
        Me.FechaDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle1
        Me.FechaDataGridViewTextBoxColumn.HeaderText = "Fecha"
        Me.FechaDataGridViewTextBoxColumn.Name = "FechaDataGridViewTextBoxColumn"
        Me.FechaDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ImporteDataGridViewTextBoxColumn
        '
        Me.ImporteDataGridViewTextBoxColumn.DataPropertyName = "Importe"
        DataGridViewCellStyle2.Format = "N2"
        DataGridViewCellStyle2.NullValue = Nothing
        Me.ImporteDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle2
        Me.ImporteDataGridViewTextBoxColumn.HeaderText = "Importe"
        Me.ImporteDataGridViewTextBoxColumn.Name = "ImporteDataGridViewTextBoxColumn"
        Me.ImporteDataGridViewTextBoxColumn.ReadOnly = True
        '
        'FacturaDataGridViewTextBoxColumn
        '
        Me.FacturaDataGridViewTextBoxColumn.DataPropertyName = "Factura"
        Me.FacturaDataGridViewTextBoxColumn.HeaderText = "Factura"
        Me.FacturaDataGridViewTextBoxColumn.Name = "FacturaDataGridViewTextBoxColumn"
        Me.FacturaDataGridViewTextBoxColumn.ReadOnly = True
        '
        'PagosClienteBindingSource
        '
        Me.PagosClienteBindingSource.DataMember = "PagosCliente"
        Me.PagosClienteBindingSource.DataSource = Me.DS_reportes
        '
        'DS_reportes
        '
        Me.DS_reportes.DataSetName = "DS_reportes"
        Me.DS_reportes.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(405, 16)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(72, 13)
        Me.Label14.TabIndex = 22
        Me.Label14.Text = "Pagos Cliente"
        '
        'TxtTotal
        '
        Me.TxtTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtTotal.Location = New System.Drawing.Point(313, 148)
        Me.TxtTotal.Name = "TxtTotal"
        Me.TxtTotal.ReadOnly = True
        Me.TxtTotal.Size = New System.Drawing.Size(86, 20)
        Me.TxtTotal.TabIndex = 21
        Me.TxtTotal.Text = "0.00"
        Me.TxtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(262, 151)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(45, 13)
        Me.Label12.TabIndex = 20
        Me.Label12.Text = "TOTAL:"
        '
        'txt_cap_int_ve
        '
        Me.txt_cap_int_ve.Location = New System.Drawing.Point(313, 115)
        Me.txt_cap_int_ve.Name = "txt_cap_int_ve"
        Me.txt_cap_int_ve.ReadOnly = True
        Me.txt_cap_int_ve.Size = New System.Drawing.Size(86, 20)
        Me.txt_cap_int_ve.TabIndex = 19
        Me.txt_cap_int_ve.Text = "0.00"
        Me.txt_cap_int_ve.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txt_cap_ve
        '
        Me.txt_cap_ve.Location = New System.Drawing.Point(313, 92)
        Me.txt_cap_ve.Name = "txt_cap_ve"
        Me.txt_cap_ve.ReadOnly = True
        Me.txt_cap_ve.Size = New System.Drawing.Size(86, 20)
        Me.txt_cap_ve.TabIndex = 18
        Me.txt_cap_ve.Text = "0.00"
        Me.txt_cap_ve.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TXT_MOR_PE
        '
        Me.TXT_MOR_PE.Location = New System.Drawing.Point(313, 70)
        Me.TXT_MOR_PE.Name = "TXT_MOR_PE"
        Me.TXT_MOR_PE.ReadOnly = True
        Me.TXT_MOR_PE.Size = New System.Drawing.Size(86, 20)
        Me.TXT_MOR_PE.TabIndex = 17
        Me.TXT_MOR_PE.Text = "0.00"
        Me.TXT_MOR_PE.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TXT_FIN_VE
        '
        Me.TXT_FIN_VE.Location = New System.Drawing.Point(313, 46)
        Me.TXT_FIN_VE.Name = "TXT_FIN_VE"
        Me.TXT_FIN_VE.ReadOnly = True
        Me.TXT_FIN_VE.Size = New System.Drawing.Size(86, 20)
        Me.TXT_FIN_VE.TabIndex = 16
        Me.TXT_FIN_VE.Text = "0.00"
        Me.TXT_FIN_VE.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(225, 120)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(86, 13)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "Cap. Int. Vigente"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(230, 97)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(81, 13)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "Capital Vencido"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(250, 75)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(61, 13)
        Me.Label8.TabIndex = 12
        Me.Label8.Text = "Int Ord Pen"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(253, 51)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(58, 13)
        Me.Label9.TabIndex = 11
        Me.Label9.Text = "Int Fin Ven"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(247, 29)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(64, 13)
        Me.Label10.TabIndex = 10
        Me.Label10.Text = "Int. Ord Ven"
        '
        'TXT_CAP_INT_VIG
        '
        Me.TXT_CAP_INT_VIG.Location = New System.Drawing.Point(91, 115)
        Me.TXT_CAP_INT_VIG.Name = "TXT_CAP_INT_VIG"
        Me.TXT_CAP_INT_VIG.ReadOnly = True
        Me.TXT_CAP_INT_VIG.Size = New System.Drawing.Size(86, 20)
        Me.TXT_CAP_INT_VIG.TabIndex = 9
        Me.TXT_CAP_INT_VIG.Text = "0.00"
        Me.TXT_CAP_INT_VIG.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TXT_CAP_VI
        '
        Me.TXT_CAP_VI.Location = New System.Drawing.Point(91, 92)
        Me.TXT_CAP_VI.Name = "TXT_CAP_VI"
        Me.TXT_CAP_VI.ReadOnly = True
        Me.TXT_CAP_VI.Size = New System.Drawing.Size(86, 20)
        Me.TXT_CAP_VI.TabIndex = 8
        Me.TXT_CAP_VI.Text = "0.00"
        Me.TXT_CAP_VI.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TXT_MOR_OR
        '
        Me.TXT_MOR_OR.Location = New System.Drawing.Point(91, 70)
        Me.TXT_MOR_OR.Name = "TXT_MOR_OR"
        Me.TXT_MOR_OR.ReadOnly = True
        Me.TXT_MOR_OR.Size = New System.Drawing.Size(86, 20)
        Me.TXT_MOR_OR.TabIndex = 7
        Me.TXT_MOR_OR.Text = "0.00"
        Me.TXT_MOR_OR.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TXT_FIN_VI
        '
        Me.TXT_FIN_VI.Location = New System.Drawing.Point(91, 46)
        Me.TXT_FIN_VI.Name = "TXT_FIN_VI"
        Me.TXT_FIN_VI.ReadOnly = True
        Me.TXT_FIN_VI.Size = New System.Drawing.Size(86, 20)
        Me.TXT_FIN_VI.TabIndex = 6
        Me.TXT_FIN_VI.Text = "0.00"
        Me.TXT_FIN_VI.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TXT_ORD_VI
        '
        Me.TXT_ORD_VI.Location = New System.Drawing.Point(91, 24)
        Me.TXT_ORD_VI.Name = "TXT_ORD_VI"
        Me.TXT_ORD_VI.ReadOnly = True
        Me.TXT_ORD_VI.Size = New System.Drawing.Size(86, 20)
        Me.TXT_ORD_VI.TabIndex = 5
        Me.TXT_ORD_VI.Text = "0.00"
        Me.TXT_ORD_VI.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(5, 122)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(86, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Cap. Int. Vigente"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(13, 99)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(78, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Capital Vigente"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(31, 77)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(60, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Int Mor Ord"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(37, 53)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(54, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Int Fin Vig"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(31, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(60, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Int. Ord Vig"
        '
        'TXT_ORD_VE1
        '
        Me.TXT_ORD_VE1.Location = New System.Drawing.Point(287, 197)
        Me.TXT_ORD_VE1.Name = "TXT_ORD_VE1"
        Me.TXT_ORD_VE1.ReadOnly = True
        Me.TXT_ORD_VE1.Size = New System.Drawing.Size(86, 20)
        Me.TXT_ORD_VE1.TabIndex = 15
        Me.TXT_ORD_VE1.Text = "0.00"
        Me.TXT_ORD_VE1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(12, 220)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(87, 22)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Imprimir"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Enabled = False
        Me.Button3.Location = New System.Drawing.Point(678, 215)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(109, 22)
        Me.Button3.TabIndex = 3
        Me.Button3.Text = "Prepagar"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Dtp_Fecha
        '
        Me.Dtp_Fecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.Dtp_Fecha.Location = New System.Drawing.Point(72, 192)
        Me.Dtp_Fecha.Name = "Dtp_Fecha"
        Me.Dtp_Fecha.Size = New System.Drawing.Size(107, 20)
        Me.Dtp_Fecha.TabIndex = 4
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(9, 197)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(61, 13)
        Me.Label11.TabIndex = 5
        Me.Label11.Text = "Intereses al"
        '
        'TxtPago
        '
        Me.TxtPago.Location = New System.Drawing.Point(678, 189)
        Me.TxtPago.Name = "TxtPago"
        Me.TxtPago.Size = New System.Drawing.Size(109, 20)
        Me.TxtPago.TabIndex = 6
        Me.TxtPago.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(592, 194)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(84, 13)
        Me.Label13.TabIndex = 7
        Me.Label13.Text = "Importe de pago"
        '
        'PagosClienteTableAdapter
        '
        Me.PagosClienteTableAdapter.ClearBeforeFill = True
        '
        'DS_contratos
        '
        Me.DS_contratos.DataSetName = "DS_contratos"
        Me.DS_contratos.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CONT_CPF_edocuentaBindingSource
        '
        Me.CONT_CPF_edocuentaBindingSource.DataMember = "CONT_CPF_edocuenta"
        Me.CONT_CPF_edocuentaBindingSource.DataSource = Me.DS_contratos
        '
        'CONT_CPF_edocuentaTableAdapter
        '
        Me.CONT_CPF_edocuentaTableAdapter.ClearBeforeFill = True
        '
        'frm_edo_cuenta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(803, 249)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.TxtPago)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Dtp_Fecha)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.TXT_ORD_VE1)
        Me.Name = "frm_edo_cuenta"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Estado de Cuenta"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PagosClienteBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DS_reportes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DS_contratos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CONT_CPF_edocuentaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents txt_cap_int_ve As System.Windows.Forms.TextBox
    Friend WithEvents txt_cap_ve As System.Windows.Forms.TextBox
    Friend WithEvents TXT_MOR_PE As System.Windows.Forms.TextBox
    Friend WithEvents TXT_FIN_VE As System.Windows.Forms.TextBox
    Friend WithEvents TXT_ORD_VE1 As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents TXT_CAP_INT_VIG As System.Windows.Forms.TextBox
    Friend WithEvents TXT_CAP_VI As System.Windows.Forms.TextBox
    Friend WithEvents TXT_MOR_OR As System.Windows.Forms.TextBox
    Friend WithEvents TXT_FIN_VI As System.Windows.Forms.TextBox
    Friend WithEvents TXT_ORD_VI As System.Windows.Forms.TextBox
    Friend WithEvents DS_contratos As Fira_Cartera_Pasiva.DS_contratos
    Friend WithEvents CONT_CPF_edocuentaBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CONT_CPF_edocuentaTableAdapter As Fira_Cartera_Pasiva.DS_contratosTableAdapters.CONT_CPF_edocuentaTableAdapter
    Friend WithEvents Button3 As Button
    Friend WithEvents Dtp_Fecha As DateTimePicker
    Friend WithEvents Label11 As Label
    Friend WithEvents TxtTotal As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents TxtPago As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label14 As Label
    Friend WithEvents PagosClienteBindingSource As BindingSource
    Friend WithEvents DS_reportes As DS_reportes
    Friend WithEvents PagosClienteTableAdapter As DS_reportesTableAdapters.PagosClienteTableAdapter
    Friend WithEvents FechaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ImporteDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FacturaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TXT_ORD_VE As TextBox
End Class
