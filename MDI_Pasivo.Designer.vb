<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MDI_Pasivo
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.mncontratos = New System.Windows.Forms.ToolStripMenuItem()
        Me.AltaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DescuentosToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.DescuentosTRAToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MinistracionesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GarantiasEjercidasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaldosYMovimientosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaldoGarantiasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReportesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DescuentosPorFechaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConT_CPF_configuracionTableAdapter = New Fira_Cartera_Pasiva.DS_contratosTableAdapters.CONT_CPF_configuracionTableAdapter()
        Me.SaldosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(61, 4)
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mncontratos, Me.GarantiasEjercidasToolStripMenuItem, Me.ReportesToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(780, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'mncontratos
        '
        Me.mncontratos.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AltaToolStripMenuItem, Me.DescuentosToolStripMenuItem1, Me.DescuentosTRAToolStripMenuItem, Me.MinistracionesToolStripMenuItem})
        Me.mncontratos.Name = "mncontratos"
        Me.mncontratos.Size = New System.Drawing.Size(71, 20)
        Me.mncontratos.Text = "&Contratos"
        '
        'AltaToolStripMenuItem
        '
        Me.AltaToolStripMenuItem.Name = "AltaToolStripMenuItem"
        Me.AltaToolStripMenuItem.Size = New System.Drawing.Size(160, 22)
        Me.AltaToolStripMenuItem.Text = "Consultas"
        '
        'DescuentosToolStripMenuItem1
        '
        Me.DescuentosToolStripMenuItem1.Name = "DescuentosToolStripMenuItem1"
        Me.DescuentosToolStripMenuItem1.Size = New System.Drawing.Size(160, 22)
        Me.DescuentosToolStripMenuItem1.Text = "Descuentos &AV"
        '
        'DescuentosTRAToolStripMenuItem
        '
        Me.DescuentosTRAToolStripMenuItem.Name = "DescuentosTRAToolStripMenuItem"
        Me.DescuentosTRAToolStripMenuItem.Size = New System.Drawing.Size(160, 22)
        Me.DescuentosTRAToolStripMenuItem.Text = "Descuentos &TRA"
        '
        'MinistracionesToolStripMenuItem
        '
        Me.MinistracionesToolStripMenuItem.Name = "MinistracionesToolStripMenuItem"
        Me.MinistracionesToolStripMenuItem.Size = New System.Drawing.Size(160, 22)
        Me.MinistracionesToolStripMenuItem.Text = "&Ministraciones"
        '
        'GarantiasEjercidasToolStripMenuItem
        '
        Me.GarantiasEjercidasToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SaldosYMovimientosToolStripMenuItem, Me.SaldoGarantiasToolStripMenuItem})
        Me.GarantiasEjercidasToolStripMenuItem.Name = "GarantiasEjercidasToolStripMenuItem"
        Me.GarantiasEjercidasToolStripMenuItem.Size = New System.Drawing.Size(117, 20)
        Me.GarantiasEjercidasToolStripMenuItem.Text = "Garantias Ejercidas"
        '
        'SaldosYMovimientosToolStripMenuItem
        '
        Me.SaldosYMovimientosToolStripMenuItem.Name = "SaldosYMovimientosToolStripMenuItem"
        Me.SaldosYMovimientosToolStripMenuItem.Size = New System.Drawing.Size(156, 22)
        Me.SaldosYMovimientosToolStripMenuItem.Text = "Ejercer Garantia"
        '
        'SaldoGarantiasToolStripMenuItem
        '
        Me.SaldoGarantiasToolStripMenuItem.Name = "SaldoGarantiasToolStripMenuItem"
        Me.SaldoGarantiasToolStripMenuItem.Size = New System.Drawing.Size(156, 22)
        Me.SaldoGarantiasToolStripMenuItem.Text = "Saldo Garantias"
        '
        'ReportesToolStripMenuItem
        '
        Me.ReportesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DescuentosPorFechaToolStripMenuItem, Me.SaldosToolStripMenuItem})
        Me.ReportesToolStripMenuItem.Name = "ReportesToolStripMenuItem"
        Me.ReportesToolStripMenuItem.Size = New System.Drawing.Size(65, 20)
        Me.ReportesToolStripMenuItem.Text = "Reportes"
        '
        'DescuentosPorFechaToolStripMenuItem
        '
        Me.DescuentosPorFechaToolStripMenuItem.Name = "DescuentosPorFechaToolStripMenuItem"
        Me.DescuentosPorFechaToolStripMenuItem.Size = New System.Drawing.Size(190, 22)
        Me.DescuentosPorFechaToolStripMenuItem.Text = "Descuentos por Fecha"
        '
        'ConT_CPF_configuracionTableAdapter
        '
        Me.ConT_CPF_configuracionTableAdapter.ClearBeforeFill = True
        '
        'SaldosToolStripMenuItem
        '
        Me.SaldosToolStripMenuItem.Name = "SaldosToolStripMenuItem"
        Me.SaldosToolStripMenuItem.Size = New System.Drawing.Size(190, 22)
        Me.SaldosToolStripMenuItem.Text = "Saldos"
        '
        'MDI_Pasivo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(780, 356)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Name = "MDI_Pasivo"
        Me.Text = "Cartera Pasiva"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents mncontratos As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AltaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DescuentosToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MinistracionesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ConT_CPF_configuracionTableAdapter As Fira_Cartera_Pasiva.DS_contratosTableAdapters.CONT_CPF_configuracionTableAdapter
    Friend WithEvents ReportesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DescuentosPorFechaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GarantiasEjercidasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SaldosYMovimientosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SaldoGarantiasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DescuentosTRAToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SaldosToolStripMenuItem As ToolStripMenuItem
End Class
