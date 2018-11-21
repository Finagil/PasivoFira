<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_ministraciones
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
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.CONT_CPF_ministracionesDataGridView = New System.Windows.Forms.DataGridView()
        Me.CONT_CPF_ministracionesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DS_contratos = New Fira_Cartera_Pasiva.DS_contratos()
        Me.bt_agregar = New System.Windows.Forms.Button()
        Me.bt_modificar = New System.Windows.Forms.Button()
        Me.bt_eliminar = New System.Windows.Forms.Button()
        Me.txt_id = New System.Windows.Forms.TextBox()
        Me.CONT_CPF_ministracionesTableAdapter = New Fira_Cartera_Pasiva.DS_contratosTableAdapters.CONT_CPF_ministracionesTableAdapter()
        Me.CONTCPFcontratosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CONT_CPF_contratosTableAdapter = New Fira_Cartera_Pasiva.DS_contratosTableAdapters.CONT_CPF_contratosTableAdapter()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.CONT_CPF_ministracionesDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CONT_CPF_ministracionesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DS_contratos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CONTCPFcontratosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CONT_CPF_ministracionesDataGridView
        '
        Me.CONT_CPF_ministracionesDataGridView.AllowUserToDeleteRows = False
        Me.CONT_CPF_ministracionesDataGridView.AutoGenerateColumns = False
        Me.CONT_CPF_ministracionesDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn10})
        Me.CONT_CPF_ministracionesDataGridView.DataSource = Me.CONT_CPF_ministracionesBindingSource
        Me.CONT_CPF_ministracionesDataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter
        Me.CONT_CPF_ministracionesDataGridView.Location = New System.Drawing.Point(12, 3)
        Me.CONT_CPF_ministracionesDataGridView.Name = "CONT_CPF_ministracionesDataGridView"
        Me.CONT_CPF_ministracionesDataGridView.Size = New System.Drawing.Size(870, 268)
        Me.CONT_CPF_ministracionesDataGridView.TabIndex = 10
        '
        'CONT_CPF_ministracionesBindingSource
        '
        Me.CONT_CPF_ministracionesBindingSource.DataMember = "CONT_CPF_ministraciones"
        Me.CONT_CPF_ministracionesBindingSource.DataSource = Me.DS_contratos
        '
        'DS_contratos
        '
        Me.DS_contratos.DataSetName = "DS_contratos"
        Me.DS_contratos.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'bt_agregar
        '
        Me.bt_agregar.Location = New System.Drawing.Point(449, 277)
        Me.bt_agregar.Name = "bt_agregar"
        Me.bt_agregar.Size = New System.Drawing.Size(81, 23)
        Me.bt_agregar.TabIndex = 148
        Me.bt_agregar.Text = "Agregar"
        Me.bt_agregar.UseVisualStyleBackColor = True
        '
        'bt_modificar
        '
        Me.bt_modificar.Location = New System.Drawing.Point(536, 277)
        Me.bt_modificar.Name = "bt_modificar"
        Me.bt_modificar.Size = New System.Drawing.Size(81, 23)
        Me.bt_modificar.TabIndex = 149
        Me.bt_modificar.Text = "Modificar"
        Me.bt_modificar.UseVisualStyleBackColor = True
        '
        'bt_eliminar
        '
        Me.bt_eliminar.Location = New System.Drawing.Point(623, 277)
        Me.bt_eliminar.Name = "bt_eliminar"
        Me.bt_eliminar.Size = New System.Drawing.Size(81, 23)
        Me.bt_eliminar.TabIndex = 150
        Me.bt_eliminar.Text = "Eliminar"
        Me.bt_eliminar.UseVisualStyleBackColor = True
        '
        'txt_id
        '
        Me.txt_id.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CONT_CPF_ministracionesBindingSource, "id_ministracion", True))
        Me.txt_id.Location = New System.Drawing.Point(102, 124)
        Me.txt_id.Name = "txt_id"
        Me.txt_id.Size = New System.Drawing.Size(100, 20)
        Me.txt_id.TabIndex = 151
        '
        'CONT_CPF_ministracionesTableAdapter
        '
        Me.CONT_CPF_ministracionesTableAdapter.ClearBeforeFill = True
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
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "consecutivo"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Id"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ToolTipText = "Consecutivo"
        Me.DataGridViewTextBoxColumn4.Width = 30
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "fecha"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Fecha"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.Width = 70
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "monto"
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle1.Format = "N2"
        DataGridViewCellStyle1.NullValue = Nothing
        Me.DataGridViewTextBoxColumn2.DefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridViewTextBoxColumn2.HeaderText = "Monto"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "porcentaje_cobro"
        Me.DataGridViewTextBoxColumn5.HeaderText = "% Cobro"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.Width = 70
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "iva"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle2.Format = "N2"
        Me.DataGridViewTextBoxColumn6.DefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridViewTextBoxColumn6.HeaderText = "IVA"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "importe"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle3.Format = "N2"
        Me.DataGridViewTextBoxColumn7.DefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridViewTextBoxColumn7.HeaderText = "Importe"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "estatus"
        Me.DataGridViewTextBoxColumn9.HeaderText = "Estatus"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "fe_descuento"
        Me.DataGridViewTextBoxColumn10.HeaderText = "Fec_descuento"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        Me.DataGridViewTextBoxColumn10.ToolTipText = "Fecha descuento Fira"
        '
        'frm_ministraciones
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(960, 304)
        Me.Controls.Add(Me.bt_eliminar)
        Me.Controls.Add(Me.bt_modificar)
        Me.Controls.Add(Me.bt_agregar)
        Me.Controls.Add(Me.CONT_CPF_ministracionesDataGridView)
        Me.Controls.Add(Me.txt_id)
        Me.Name = "frm_ministraciones"
        Me.Text = "Ministraciones"
        CType(Me.CONT_CPF_ministracionesDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CONT_CPF_ministracionesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DS_contratos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CONTCPFcontratosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DS_contratos As Fira_Cartera_Pasiva.DS_contratos
    Friend WithEvents CONT_CPF_ministracionesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CONT_CPF_ministracionesTableAdapter As Fira_Cartera_Pasiva.DS_contratosTableAdapters.CONT_CPF_ministracionesTableAdapter
    Friend WithEvents CONT_CPF_ministracionesDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents bt_agregar As Button
    Friend WithEvents bt_modificar As Button
    Friend WithEvents bt_eliminar As Button
    Friend WithEvents CONTCPFcontratosBindingSource As BindingSource
    Friend WithEvents CONT_CPF_contratosTableAdapter As DS_contratosTableAdapters.CONT_CPF_contratosTableAdapter
    Friend WithEvents txt_id As TextBox
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As DataGridViewTextBoxColumn
End Class
