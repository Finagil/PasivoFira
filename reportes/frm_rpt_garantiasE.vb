Public Class frm_rpt_garantiasE
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim fecha1 As Date
        fecha1 = Today


        Me.Vw_CONT_CPF_GarantiaerecidaRptTableAdapter.PORFECHA(Me.DS_reportes.vw_CONT_CPF_GarantiaerecidaRpt, fecha1)
        Dim rpt As New garantiasE()
        rpt.SetDataSource(DS_reportes)
        rpt.SetParameterValue("fecha", fecha1)
        crv.ReportSource = rpt

    End Sub

    Private Sub frm_rpt_garantiasE_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class