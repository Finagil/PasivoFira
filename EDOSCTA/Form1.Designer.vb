<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.TextFile = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.DataSet1 = New Fira_Cartera_Pasiva.DataSet1()
        Me.ZS976SDOBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ZS976SDOTableAdapter = New Fira_Cartera_Pasiva.DataSet1TableAdapters.ZS976SDOTableAdapter()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ZS976SDOBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TextFile
        '
        Me.TextFile.Location = New System.Drawing.Point(12, 12)
        Me.TextFile.Name = "TextFile"
        Me.TextFile.ReadOnly = True
        Me.TextFile.Size = New System.Drawing.Size(324, 20)
        Me.TextFile.TabIndex = 4
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(342, 10)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "Abrir"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'DataSet1
        '
        Me.DataSet1.DataSetName = "DataSet1"
        Me.DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ZS976SDOBindingSource
        '
        Me.ZS976SDOBindingSource.DataMember = "ZS976SDO"
        Me.ZS976SDOBindingSource.DataSource = Me.DataSet1
        '
        'ZS976SDOTableAdapter
        '
        Me.ZS976SDOTableAdapter.ClearBeforeFill = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(490, 50)
        Me.Controls.Add(Me.TextFile)
        Me.Controls.Add(Me.Button1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ZS976SDOBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TextFile As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents DataSet1 As DataSet1
    Friend WithEvents ZS976SDOBindingSource As BindingSource
    Friend WithEvents ZS976SDOTableAdapter As DataSet1TableAdapters.ZS976SDOTableAdapter
End Class
