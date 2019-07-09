Public Class frm_rpt_saldo_contingente
    Private Sub frm_rpt_saldo_contingente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Me.Sp_CONT_CPF_RptSaldoContigenteTableAdapter.Fill(Me.DS_reportes.Sp_CONT_CPF_RptSaldoContigente)
            Dim rpt As New rpt_saldo_contingente

            rpt.SetDataSource(DS_reportes)
            crv_saldo_contingente.ReportSource = rpt

        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub crv_saldo_contingente_Load(sender As Object, e As EventArgs)

    End Sub
End Class