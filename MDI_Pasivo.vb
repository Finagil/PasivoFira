Public Class MDI_Pasivo
    Private Sub AltaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AltaToolStripMenuItem.Click
        Dim f As New frm_contratos_alta
        sinanexo = True
        f.Show()

    End Sub

    Private Sub DescuentosToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DescuentosToolStripMenuItem1.Click
        Dim f As New Frm_DescuentosAV
        f.Show()
    End Sub

    Private Sub MinistracionesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MinistracionesToolStripMenuItem.Click
        Dim f As New Frm_MinistracionesADD
        f.Show()
    End Sub

    Private Sub MDI_Pasivo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If CargaTIIE(Today, "0", "21") = False Then
            End
        End If
        'FN = Me.ConT_CPF_configuracionTableAdapter.ScalarQueryconfiguracion(CONFIG.FN)
        'FB = Me.ConT_CPF_configuracionTableAdapter.ScalarQueryconfiguracion(CONFIG.FB)
        P1000 = Me.ConT_CPF_configuracionTableAdapter.ScalarQueryconfiguracion(CONFIG.MIL)
        P1001 = Me.ConT_CPF_configuracionTableAdapter.ScalarQueryconfiguracion(CONFIG.MIL1)
        PR = Me.ConT_CPF_configuracionTableAdapter.ScalarQueryconfiguracion(CONFIG.REFAC)
        PCXSG_FEGA = Me.ConT_CPF_configuracionTableAdapter.ScalarQueryconfiguracion(CONFIG.CXSG_FEGA)
        PCXSG_FONAGA = Me.ConT_CPF_configuracionTableAdapter.ScalarQueryconfiguracion(CONFIG.CXSG_FONAGA)
    End Sub

    Private Sub DescuentosPoFechaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim f As New frm_datos_contrato
        f.Show()
    End Sub


    Private Sub DescuentosPorFechaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DescuentosPorFechaToolStripMenuItem.Click

        Dim f As New frm_descuentos_porfecha
        f.Show()
    End Sub

    Private Sub SaldosYMovimientosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaldosYMovimientosToolStripMenuItem.Click
        Dim f As New FrmGarantiasXEjercer
        f.Show()
    End Sub

    Private Sub SaldoGarantiasToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaldoGarantiasToolStripMenuItem.Click
        Dim f As New FrmGarantiasEjercidas
        f.Show()
    End Sub

    Private Sub DescuentosTRAToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DescuentosTRAToolStripMenuItem.Click
        Dim f As New Frm_DescuentosTRA
        f.Show()
    End Sub

    Private Sub SaldosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaldosToolStripMenuItem.Click
        Dim f As New frm_rpt_saldp
        f.Show()
    End Sub

    Private Sub mncontratos_Click(sender As Object, e As EventArgs) Handles mncontratos.Click

    End Sub

    Private Sub AltasCToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub AltaDeContratoSinAnexoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AltaDeContratoSinAnexoToolStripMenuItem.Click
        Dim f As New frm_contrato2
        f.Show()
    End Sub

    Private Sub ImportaPagosFinagilToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ImportaPagosFinagilToolStripMenuItem.Click
        Dim f As New FrmImportaPagos
        f.Show()
    End Sub

    Private Sub CarteraToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CarteraToolStripMenuItem.Click
        Dim f As New frm_rpt_cartera
        f.Show()
    End Sub

    Private Sub ProyecciónCLToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProyecciónCLToolStripMenuItem.Click
        Dim f As New frm_cl_plazo
        f.Show()
    End Sub

    Private Sub SaldoContingenteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaldoContingenteToolStripMenuItem.Click
        Dim f As New frm_rpt_saldo_contingente
        f.Show()
    End Sub

    Private Sub ReportesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReportesToolStripMenuItem.Click

    End Sub

    Private Sub GarantíasEjercidasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GarantíasEjercidasToolStripMenuItem.Click
        Dim f As New frm_rpt_garantiasE
        f.Show()
    End Sub

    Private Sub AcreditadosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AcreditadosToolStripMenuItem.Click

    End Sub

    Private Sub AltaToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles AltaToolStripMenuItem1.Click
        Dim f As New frm_acreditados
        f.Show()
    End Sub



    Private Sub FactorajeToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles FactorajeToolStripMenuItem1.Click

    End Sub

    Private Sub ProcesarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProcesarToolStripMenuItem.Click
        Dim f As New frmLayoutFact

        f.Show()
    End Sub

    Private Sub DescontarToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Dim f As New Frm_DescuentosFAC

        f.Show()
    End Sub
End Class
