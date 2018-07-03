Public Class frm_rpt_cartera
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnEnviar.Click
        Try
            Me.Sp_CONT_CPF_RptCarteraTableAdapter.Fill(Me.DS_reportes.Sp_CONT_CPF_RptCartera, New System.Nullable(Of Date)(CType(dtpFechaCartera.Value, Date)))

            Dim rpt As New rpt_cartera()


            rpt.SetDataSource(DS_reportes)
            rpt.SetParameterValue("var_fecha_dtp", dtpFechaCartera.Value.ToShortDateString)
            crvReporteCartera.ReportSource = rpt

        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub frm_rpt_cartera_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dtpFechaCartera.MinDate = New Date(Date.Now.Year, Date.Now.Month - 1, 1)
        dtpFechaCartera.MaxDate = Date.Now

    End Sub
End Class