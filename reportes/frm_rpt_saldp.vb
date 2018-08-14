Public Class frm_rpt_saldp
    Private Sub frm_rpt_saldp_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DS_reportes.vw_saldo_PF' Puede moverla o quitarla según sea necesario.
        ' Me.Vw_saldo_PFTableAdapter.Fill(Me.DS_reportes.vw_saldo_PF)
        'TODO: esta línea de código carga datos en la tabla 'DS_reportes.vw_saldo_PF' Puede moverla o quitarla según sea necesario.
        'Me.Vw_saldo_PFTableAdapter.Fill(Me.DS_reportes.vw_saldo_PF)
        'TODO: esta línea de código carga datos en la tabla 'DS_reportes.vw_saldo_PF' Puede moverla o quitarla según sea necesario.




    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Dim fecha1 As Date
        fecha1 = DT_FECHA.Text
        Dim fecha As String = Format(fecha1, "dd/MM/yyyy")

        Me.Vw_saldo_PFTableAdapter.FillByFECHA(Me.DS_reportes.vw_saldo_PF, fecha1)
        Dim rpt As New rpt_saldos()
        rpt.SetDataSource(DS_reportes)
        rpt.SetParameterValue("fecha", DT_FECHA.Text)

        'rpt.SetParameterValue("IMPORTE", frm_Solicitud_Transferencia.IMPORTE_T)
        'rpt.SetParameterValue("RECURSO", frm_Solicitud_Transferencia.recursos_fira)
        'rpt.SetParameterValue("fecha", frm_Solicitud_Transferencia.fecha_p)
        crv.ReportSource = rpt
    End Sub

    Private Sub DT_FECHA_ValueChanged(sender As Object, e As EventArgs) Handles DT_FECHA.ValueChanged

    End Sub
End Class