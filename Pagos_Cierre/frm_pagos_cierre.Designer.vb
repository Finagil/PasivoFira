<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_pagos_cierre
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.bt_aplicar = New System.Windows.Forms.Button()
        Me.dt_fecha = New System.Windows.Forms.DateTimePicker()
        Me.ch_diario = New System.Windows.Forms.CheckBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.DS_contratos = New Fira_Cartera_Pasiva.DS_contratos()
        Me.CONTCPFcontratosgarantiasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CONT_CPF_contratos_garantiasTableAdapter = New Fira_Cartera_Pasiva.DS_contratosTableAdapters.CONT_CPF_contratos_garantiasTableAdapter()
        Me.CONTCPFcontratosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CONTCPFcsgBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.CONT_CPF_contratosTableAdapter = New Fira_Cartera_Pasiva.DS_contratosTableAdapters.CONT_CPF_contratosTableAdapter()
        Me.CONTCPFcsgBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CONT_CPF_csgTableAdapter = New Fira_Cartera_Pasiva.DS_contratosTableAdapters.CONT_CPF_csgTableAdapter()
        Me.CONTCPFvencimientosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CONT_CPF_vencimientosTableAdapter = New Fira_Cartera_Pasiva.DS_contratosTableAdapters.CONT_CPF_vencimientosTableAdapter()
        Me.CONTCPFvencimientointeresBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CONT_CPF_vencimiento_interesTableAdapter = New Fira_Cartera_Pasiva.DS_contratosTableAdapters.CONT_CPF_vencimiento_interesTableAdapter()
        Me.CONTCPFCierreContableBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CONT_CPF_CierreContableTableAdapter = New Fira_Cartera_Pasiva.DS_contratosTableAdapters.CONT_CPF_CierreContableTableAdapter()
        Me.CONTCPFcierremesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CONT_CPF_cierremesTableAdapter = New Fira_Cartera_Pasiva.DS_contratosTableAdapters.CONT_CPF_cierremesTableAdapter()
        Me.CONTCPFcierrediarioBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CONT_CPF_cierre_diarioTableAdapter = New Fira_Cartera_Pasiva.DS_contratosTableAdapters.CONT_CPF_cierre_diarioTableAdapter()
        Me.Button2 = New System.Windows.Forms.Button()
        CType(Me.DS_contratos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CONTCPFcontratosgarantiasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CONTCPFcontratosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CONTCPFcsgBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CONTCPFcsgBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CONTCPFvencimientosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CONTCPFvencimientointeresBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CONTCPFCierreContableBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CONTCPFcierremesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CONTCPFcierrediarioBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(49, 41)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(85, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Fecha Pago Fira"
        '
        'bt_aplicar
        '
        Me.bt_aplicar.Enabled = False
        Me.bt_aplicar.Location = New System.Drawing.Point(101, 194)
        Me.bt_aplicar.Name = "bt_aplicar"
        Me.bt_aplicar.Size = New System.Drawing.Size(33, 23)
        Me.bt_aplicar.TabIndex = 2
        Me.bt_aplicar.Text = "Cierre ANTES"
        Me.bt_aplicar.UseVisualStyleBackColor = True
        Me.bt_aplicar.Visible = False
        '
        'dt_fecha
        '
        Me.dt_fecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dt_fecha.Location = New System.Drawing.Point(140, 35)
        Me.dt_fecha.Name = "dt_fecha"
        Me.dt_fecha.Size = New System.Drawing.Size(126, 20)
        Me.dt_fecha.TabIndex = 3
        '
        'ch_diario
        '
        Me.ch_diario.AutoSize = True
        Me.ch_diario.Location = New System.Drawing.Point(12, 198)
        Me.ch_diario.Name = "ch_diario"
        Me.ch_diario.Size = New System.Drawing.Size(83, 17)
        Me.ch_diario.TabIndex = 4
        Me.ch_diario.Text = "Cierre Diario"
        Me.ch_diario.UseVisualStyleBackColor = True
        Me.ch_diario.Visible = False
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(140, 77)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(115, 23)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "Cierre Diario"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'DS_contratos
        '
        Me.DS_contratos.DataSetName = "DS_contratos"
        Me.DS_contratos.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
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
        'CONTCPFcontratosBindingSource
        '
        Me.CONTCPFcontratosBindingSource.DataMember = "CONT_CPF_contratos"
        Me.CONTCPFcontratosBindingSource.DataSource = Me.DS_contratos
        '
        'CONTCPFcsgBindingSource1
        '
        Me.CONTCPFcsgBindingSource1.DataMember = "CONT_CPF_csg"
        Me.CONTCPFcsgBindingSource1.DataSource = Me.DS_contratos
        '
        'CONT_CPF_contratosTableAdapter
        '
        Me.CONT_CPF_contratosTableAdapter.ClearBeforeFill = True
        '
        'CONTCPFcsgBindingSource
        '
        Me.CONTCPFcsgBindingSource.DataMember = "CONT_CPF_csg"
        Me.CONTCPFcsgBindingSource.DataSource = Me.DS_contratos
        '
        'CONT_CPF_csgTableAdapter
        '
        Me.CONT_CPF_csgTableAdapter.ClearBeforeFill = True
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
        'CONTCPFvencimientointeresBindingSource
        '
        Me.CONTCPFvencimientointeresBindingSource.DataMember = "CONT_CPF_vencimiento_interes"
        Me.CONTCPFvencimientointeresBindingSource.DataSource = Me.DS_contratos
        '
        'CONT_CPF_vencimiento_interesTableAdapter
        '
        Me.CONT_CPF_vencimiento_interesTableAdapter.ClearBeforeFill = True
        '
        'CONTCPFCierreContableBindingSource
        '
        Me.CONTCPFCierreContableBindingSource.DataMember = "CONT_CPF_CierreContable"
        Me.CONTCPFCierreContableBindingSource.DataSource = Me.DS_contratos
        '
        'CONT_CPF_CierreContableTableAdapter
        '
        Me.CONT_CPF_CierreContableTableAdapter.ClearBeforeFill = True
        '
        'CONTCPFcierremesBindingSource
        '
        Me.CONTCPFcierremesBindingSource.DataMember = "CONT_CPF_cierremes"
        Me.CONTCPFcierremesBindingSource.DataSource = Me.DS_contratos
        '
        'CONT_CPF_cierremesTableAdapter
        '
        Me.CONT_CPF_cierremesTableAdapter.ClearBeforeFill = True
        '
        'CONTCPFcierrediarioBindingSource
        '
        Me.CONTCPFcierrediarioBindingSource.DataMember = "CONT_CPF_cierre_diario"
        Me.CONTCPFcierrediarioBindingSource.DataSource = Me.DS_contratos
        '
        'CONT_CPF_cierre_diarioTableAdapter
        '
        Me.CONT_CPF_cierre_diarioTableAdapter.ClearBeforeFill = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(140, 121)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(115, 23)
        Me.Button2.TabIndex = 7
        Me.Button2.Text = "Cierre Mensual"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'frm_pagos_cierre
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(489, 218)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.dt_fecha)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ch_diario)
        Me.Controls.Add(Me.bt_aplicar)
        Me.Name = "frm_pagos_cierre"
        Me.Text = "frm_pagos_cierre"
        CType(Me.DS_contratos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CONTCPFcontratosgarantiasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CONTCPFcontratosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CONTCPFcsgBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CONTCPFcsgBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CONTCPFvencimientosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CONTCPFvencimientointeresBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CONTCPFCierreContableBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CONTCPFcierremesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CONTCPFcierrediarioBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents bt_aplicar As Button
    Friend WithEvents dt_fecha As DateTimePicker
    Friend WithEvents DS_contratos As DS_contratos
    Friend WithEvents CONTCPFcontratosgarantiasBindingSource As BindingSource
    Friend WithEvents CONT_CPF_contratos_garantiasTableAdapter As DS_contratosTableAdapters.CONT_CPF_contratos_garantiasTableAdapter
    Friend WithEvents CONTCPFcontratosBindingSource As BindingSource
    Friend WithEvents CONT_CPF_contratosTableAdapter As DS_contratosTableAdapters.CONT_CPF_contratosTableAdapter
    Friend WithEvents CONTCPFcsgBindingSource As BindingSource
    Friend WithEvents CONT_CPF_csgTableAdapter As DS_contratosTableAdapters.CONT_CPF_csgTableAdapter
    Friend WithEvents CONTCPFcsgBindingSource1 As BindingSource
    Friend WithEvents CONTCPFvencimientosBindingSource As BindingSource
    Friend WithEvents CONT_CPF_vencimientosTableAdapter As DS_contratosTableAdapters.CONT_CPF_vencimientosTableAdapter
    Friend WithEvents CONTCPFvencimientointeresBindingSource As BindingSource
    Friend WithEvents CONT_CPF_vencimiento_interesTableAdapter As DS_contratosTableAdapters.CONT_CPF_vencimiento_interesTableAdapter
    Friend WithEvents CONTCPFCierreContableBindingSource As BindingSource
    Friend WithEvents CONT_CPF_CierreContableTableAdapter As DS_contratosTableAdapters.CONT_CPF_CierreContableTableAdapter
    Friend WithEvents CONTCPFcierremesBindingSource As BindingSource
    Friend WithEvents CONT_CPF_cierremesTableAdapter As DS_contratosTableAdapters.CONT_CPF_cierremesTableAdapter
    Friend WithEvents ch_diario As CheckBox
    Friend WithEvents Button1 As Button
    Friend WithEvents CONTCPFcierrediarioBindingSource As BindingSource
    Friend WithEvents CONT_CPF_cierre_diarioTableAdapter As DS_contratosTableAdapters.CONT_CPF_cierre_diarioTableAdapter
    Friend WithEvents Button2 As Button
End Class
