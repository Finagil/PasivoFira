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
        Me.DS_contratos = New Fira_Cartera_Pasiva.DS_contratos()
        Me.CONTCPFcontratosgarantiasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CONT_CPF_contratos_garantiasTableAdapter = New Fira_Cartera_Pasiva.DS_contratosTableAdapters.CONT_CPF_contratos_garantiasTableAdapter()
        Me.CONTCPFcontratosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CONTCPFcsgBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.CONT_CPF_contratosTableAdapter = New Fira_Cartera_Pasiva.DS_contratosTableAdapters.CONT_CPF_contratosTableAdapter()
        Me.CONTCPFcsgBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CONT_CPF_csgTableAdapter = New Fira_Cartera_Pasiva.DS_contratosTableAdapters.CONT_CPF_csgTableAdapter()
        CType(Me.DS_contratos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CONTCPFcontratosgarantiasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CONTCPFcontratosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CONTCPFcsgBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CONTCPFcsgBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.bt_aplicar.Location = New System.Drawing.Point(140, 79)
        Me.bt_aplicar.Name = "bt_aplicar"
        Me.bt_aplicar.Size = New System.Drawing.Size(75, 23)
        Me.bt_aplicar.TabIndex = 2
        Me.bt_aplicar.Text = "Aplicar Pago"
        Me.bt_aplicar.UseVisualStyleBackColor = True
        '
        'dt_fecha
        '
        Me.dt_fecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dt_fecha.Location = New System.Drawing.Point(140, 35)
        Me.dt_fecha.Name = "dt_fecha"
        Me.dt_fecha.Size = New System.Drawing.Size(126, 20)
        Me.dt_fecha.TabIndex = 3
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
        'frm_pagos_cierre
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(422, 160)
        Me.Controls.Add(Me.dt_fecha)
        Me.Controls.Add(Me.bt_aplicar)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frm_pagos_cierre"
        Me.Text = "frm_pagos_cierre"
        CType(Me.DS_contratos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CONTCPFcontratosgarantiasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CONTCPFcontratosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CONTCPFcsgBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CONTCPFcsgBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
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
End Class
