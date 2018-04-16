Public Class frm_rpt_solicitud_cargo

   
    Private Sub frm_rpt_solicitud_cargo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ' Me.Vw_descuentosTableAdapter.FillBy(Me.DescuentosDS.vw_descuentos)
        Me.Vw_descuentosTableAdapter.Fillbyid_contrato(Me.DescuentosDS.vw_descuentos, FrmGarantiasEjercidas.idcontrato)
        Me.SaldoGarantiaEjercidaTableAdapter.Fill(Me.DescuentosDS.SaldoGarantiaEjercida, FrmGarantiasEjercidas.idcontrato)
        Dim rpt As New rpt_solicitud_cargo()
        rpt.SetDataSource(DescuentosDS)
        rpt.SetParameterValue("fe_rec", FrmGarantiasEjercidas.fecRec)
        rpt.SetParameterValue("garantia", FrmGarantiasEjercidas.garantia)
        CRV.ReportSource = rpt

    End Sub

    Private Sub CRV_Load(sender As Object, e As EventArgs) Handles CRV.Load

    End Sub
End Class