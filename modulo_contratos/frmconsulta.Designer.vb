<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmconsulta
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
        Me.lblAnexos = New System.Windows.Forms.Label()
        Me.lblClientes = New System.Windows.Forms.Label()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.VwdescuentoSABindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DS_contratos = New Fira_Cartera_Pasiva.DS_contratos()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.ClientesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ClientesTableAdapter = New Fira_Cartera_Pasiva.DS_contratosTableAdapters.ClientesTableAdapter()
        Me.Vw_descuentoSATableAdapter = New Fira_Cartera_Pasiva.DS_contratosTableAdapters.vw_descuentoSATableAdapter()
        Me.VwAnexos1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Vw_Anexos1TableAdapter = New Fira_Cartera_Pasiva.DS_contratosTableAdapters.Vw_Anexos1TableAdapter()
        CType(Me.VwdescuentoSABindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DS_contratos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClientesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VwAnexos1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblAnexos
        '
        Me.lblAnexos.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAnexos.Location = New System.Drawing.Point(461, 9)
        Me.lblAnexos.Name = "lblAnexos"
        Me.lblAnexos.Size = New System.Drawing.Size(149, 16)
        Me.lblAnexos.TabIndex = 7
        Me.lblAnexos.Text = "Contratos de este cliente"
        Me.lblAnexos.Visible = False
        '
        'lblClientes
        '
        Me.lblClientes.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblClientes.Location = New System.Drawing.Point(12, 9)
        Me.lblClientes.Name = "lblClientes"
        Me.lblClientes.Size = New System.Drawing.Size(432, 16)
        Me.lblClientes.TabIndex = 5
        Me.lblClientes.Text = "Selecciona un Cliente de la siguiente Lista"
        '
        'ListBox1
        '
        Me.ListBox1.DataSource = Me.VwdescuentoSABindingSource
        Me.ListBox1.DisplayMember = "idcredito"
        Me.ListBox1.Location = New System.Drawing.Point(442, 33)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(224, 472)
        Me.ListBox1.TabIndex = 8
        Me.ListBox1.ValueMember = "idcredito"
        Me.ListBox1.Visible = False
        '
        'VwdescuentoSABindingSource
        '
        Me.VwdescuentoSABindingSource.DataMember = "vw_descuentoSA"
        Me.VwdescuentoSABindingSource.DataSource = Me.DS_contratos
        '
        'DS_contratos
        '
        Me.DS_contratos.DataSetName = "DS_contratos"
        Me.DS_contratos.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ComboBox1
        '
        Me.ComboBox1.DataSource = Me.ClientesBindingSource
        Me.ComboBox1.DisplayMember = "Descr"
        Me.ComboBox1.Location = New System.Drawing.Point(12, 33)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(424, 21)
        Me.ComboBox1.TabIndex = 6
        Me.ComboBox1.ValueMember = "Cliente"
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
        'Vw_descuentoSATableAdapter
        '
        Me.Vw_descuentoSATableAdapter.ClearBeforeFill = True
        '
        'VwAnexos1BindingSource
        '
        Me.VwAnexos1BindingSource.DataMember = "Vw_Anexos1"
        Me.VwAnexos1BindingSource.DataSource = Me.DS_contratos
        '
        'Vw_Anexos1TableAdapter
        '
        Me.Vw_Anexos1TableAdapter.ClearBeforeFill = True
        '
        'frmconsulta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(728, 549)
        Me.Controls.Add(Me.lblAnexos)
        Me.Controls.Add(Me.lblClientes)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.ComboBox1)
        Me.Name = "frmconsulta"
        Me.Text = "frmconsulta"
        CType(Me.VwdescuentoSABindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DS_contratos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClientesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VwAnexos1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lblAnexos As Label
    Friend WithEvents lblClientes As Label
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents DS_contratos As DS_contratos
    Friend WithEvents ClientesBindingSource As BindingSource
    Friend WithEvents ClientesTableAdapter As DS_contratosTableAdapters.ClientesTableAdapter
    Friend WithEvents VwdescuentoSABindingSource As BindingSource
    Friend WithEvents Vw_descuentoSATableAdapter As DS_contratosTableAdapters.vw_descuentoSATableAdapter
    Friend WithEvents VwAnexos1BindingSource As BindingSource
    Friend WithEvents Vw_Anexos1TableAdapter As DS_contratosTableAdapters.Vw_Anexos1TableAdapter
End Class
